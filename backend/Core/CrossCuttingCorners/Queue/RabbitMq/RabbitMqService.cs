using Core.Utilities.Connection;
using Core.Utilities.Environment;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingCorners.Queue.RabbitMq
{
    public class RabbitMqService : IRabbitMqService
    {
        IConnection _context;

        public RabbitMqService()
        {
            //_context = ConnectionHelper.Instance.RabbitMqConnection();
        }

        /// <summary>
        /// Data is added to the queue
        /// </summary>
        /// <param name="queueName"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        public bool Publisher(string queueName, string body)
        {
            bool response = false;
            try
            {
                using (var channel = _context.CreateModel())
                {
                    channel.QueueDeclare(queue: queueName,
                                        durable: false,
                                        exclusive: false,
                                        autoDelete: false,
                                        arguments: null);

                    var arr = Encoding.UTF8.GetBytes(body);
                    channel.BasicPublish("", queueName, null, arr);
                    response = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return response;
        }

        /// <summary>
        /// Data is pulled from the queue
        /// </summary>
        /// <param name="queueName"></param>
        /// <returns></returns>
        public bool Consumer(string queueName)
        {
            bool response = false;
            try
            {
                using (var channel = _context.CreateModel())
                {
                    channel.QueueDeclare(queue: queueName,
                                        durable: false,
                                        exclusive: false,
                                        autoDelete: false,
                                        arguments: null);

                    var consumer = new EventingBasicConsumer(channel);
                    consumer.Received += (model, ea) =>
                    {
                        var body = ea.Body.ToArray();
                        var message = Encoding.UTF8.GetString(body);
                    };
                    channel.BasicConsume(queue: queueName, autoAck: true, consumer: consumer);
                    response = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return response;
        }
    }
}
