using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingCorners.FileServer
{
    public interface IMinioService
    {
        /// <summary>
        /// Upload file operation
        /// </summary>
        /// <param name="formFile"></param>
        /// <param name="bucketName"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        Task<bool> UploadFile(IFormFile formFile, string bucketName, string fileName);
        /// <summary>
        /// Delete file operation
        /// </summary>
        /// <param name="bucketName"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        Task<bool> DeleteFile(string bucketName, string fileName);
        /// <summary>
        /// Exist bucket control
        /// </summary>
        /// <param name="bucketName"></param>
        /// <returns></returns>
        Task<bool> ExistsBucket(string bucketName);
    }
}
