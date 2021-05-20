using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingCorners.Queue.RabbitMq
{
    public interface IRabbitMqService
    {
        /// <summary>
        /// Data is added to the queue
        /// </summary>
        /// <param name="queueName"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        bool Publisher(string queueName, string body);
        /// <summary>
        /// Data is pulled from the queue
        /// </summary>
        /// <param name="queueName"></param>
        /// <returns></returns>
        bool Consumer(string queueName);
    }
}
