using FileManagement.StorageBroker.Services;
using System.Reflection.Metadata.Ecma335;

namespace FileManagement.Service.Services
{
    public class StorageService : IStorageService
    {
        private readonly IStorageBrokerService _storageBrokerService;
        public StorageService(IStorageBrokerService storageBrokerService)
        {
            _storageBrokerService=storageBrokerService;
        }
        public async Task CreateFolder(string folderPath)
        {
            await _storageBrokerService.CreateFolder(folderPath);
        }

        public async Task DeleteFile(string filePath)
        {
            await _storageBrokerService.DeleteFile(filePath);
        }

        public async Task DeleteFolder(string folderPath)
        {
            await _storageBrokerService.DeleteFolder(folderPath);
        }

        public async Task<Stream> DownloadFolderAzZip(string folderPath)
        {
           return await _storageBrokerService.DownloadFolderAzZip(folderPath);
        }

        public async List<Task<string>> GetAllInFolderPath(string? folderPath)
        {
            var res = _storageBrokerService.GetAllInFolderPath(folderPath).ToList();
            return await res;

        }

        public async List<Task<string>> GetContentOfTxt()
        {
            return await _storageBrokerService.GetContentOfTxt();
        }

        public async Task UpdateContentOfTxtFile(string filePath, string newContent)
        {
            await _storageBrokerService.UpdateContentOfTxtFile(filePath, newContent);
        }

        public async Task UploadFile(IFormFile file, string? folderPath)
        {
            await _storageBrokerService.UploadFile(file, folderPath);
        }

        public async Task UploadFiles(List<IFormFile> files, string? folderPath)
        {
            await _storageBrokerService.UploadFiles(files, folderPath);
        }

        public async Task UploadFileWithChunks(IFormFile file, string? folderPath)
        {
            await _storageBrokerService.UploadFileWithChunks(file, folderPath);
        }

     public async  Task<Stream>DownloadFileFile(IFormFile file, string? folderPath)
        {
     return await _storageBrokerService.DownloadFile(folderPath);
        }
    }
}
