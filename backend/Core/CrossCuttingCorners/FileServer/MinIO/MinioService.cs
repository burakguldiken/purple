using Core.Utilities.Connection;
using Microsoft.AspNetCore.Http;
using Minio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingCorners.FileServer
{
    public class MinioService : IMinioService
    {
        private readonly MinioClient _minioClient;

        public MinioService()
        {
            _minioClient = ConnectionHelper.MinioConnection();
        }

        /// <summary>
        /// Upload file to minio
        /// </summary>
        /// <param name="formFile"></param>
        /// <param name="bucketName"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public async Task<bool> UploadFile(IFormFile formFile, string bucketName, string fileName)
        {
            bool response = true;
            try
            {
                bool bucketFound = await _minioClient.BucketExistsAsync(bucketName);

                if (!bucketFound)
                {
                    _minioClient.MakeBucketAsync(bucketName, "Tr-tr").Wait();
                }
                using (Stream stream = formFile.OpenReadStream())
                {
                    await _minioClient.PutObjectAsync(bucketName, fileName, stream, stream.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                response = false;
            }
            return response;
        }

        /// <summary>
        /// Delete file to minio
        /// </summary>
        /// <param name="bucketName"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public async Task<bool> DeleteFile(string bucketName, string fileName)
        {
            bool response = true;
            try
            {
                await _minioClient.RemoveObjectAsync(bucketName, fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                response = false;
            }

            return response;
        }

        /// <summary>
        /// Exist bucket control
        /// </summary>
        /// <param name="bucketName"></param>
        /// <returns></returns>
        public async Task<bool> ExistsBucket(string bucketName)
        {
            bool response = true;
            try
            {
                response = await _minioClient.BucketExistsAsync(bucketName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                response = false;
            }

            return response;
        }
    }
}
