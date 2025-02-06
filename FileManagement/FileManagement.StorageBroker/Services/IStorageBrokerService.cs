using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagement.StorageBroker.Services;

public interface IStorageBrokerService
{
    Task CreateFolder(string folderPath);
    Task UploadFile(IFormFile file, string? folderPath);
    Task UploadFileWithChunks(IFormFile file, string? folderPath);
    Task UploadFiles(List<IFormFile> files, string? folderPath);
    Task DeleteFolder(string folderPath);
    Task DeleteFile(string filePath);
    Task<Stream> DownloadFile(string filePath);
    Task<Stream> DownloadFolderAzZip(string folderPath);
    List<Task> GetContentOfTxt();
    Task UpdateContentOfTxtFile(string filePath, string newContent);
    List<Task> GetAllInFolderPath(string ? folderPath); 


}
