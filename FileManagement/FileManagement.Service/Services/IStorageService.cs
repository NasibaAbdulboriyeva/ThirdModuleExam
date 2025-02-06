using FileManagement.StorageBroker.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagement.Service.Services
{
    public interface IStorageService
    {
        Task CreateFolder(string folderPath);
        Task UploadFile(IFormFile file, string? folderPath);
        Task UploadFileWithChunks(IFormFile file, string? folderPath);
        Task UploadFiles(List<IFormFile> files, string? folderPath);
        Task DeleteFolder(string folderPath);
        Task DeleteFile(string filePath);
        Task<Stream> DownloadFile(string filePath);
        Task<Stream> DownloadFolderAzZip(string folderPath);
        List<Task<string>> GetContentOfTxt();
        Task UpdateContentOfTxtFile(string filePath, string newContent);
        List<Task<string>> GetAllInFolderPath(string? folderPath);


    }
}
