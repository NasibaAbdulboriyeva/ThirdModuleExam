using System.IO.Enumeration;

namespace FileManagement.StorageBroker.Services;

public class LocalStorageBrokerService : IStorageBrokerService
{
    private readonly string _path;
    public LocalStorageBrokerService()
    {
        _path =Path.Combine(Directory.GetCurrentDirectory(), "txt");

    }
    public async Task CreateFolder(string folderPath)
    {
        folderPath = Path.Combine(_path, folderPath);
        if (!Directory.Exists(folderPath))
        {
            throw new Exception("Folder has created ");
        }


    }

    public async Task DeleteFile(string filePath)
    {

        if (!File.Exists(filePath))
        {
            throw new Exception("file not found to delete");
        }
        File.Delete(filePath);
    }

    public async Task DeleteFolder(string folderPath)
    {

        if (!Directory.Exists(folderPath))
        {
            throw new Exception("folder not found to delete");
        }
        Directory.Delete(folderPath);
    }

    public Task<Stream> DownloadFile(string filePath)
    {
        using (var stream = File.OpenRead(filePath))
        {

        }

    }

    public Task<Stream> DownloadFolderAzZip(string folderPath)
    {

        
    }

    public List<Task> GetAllInFolderPath(string? folderPath)
    {
       
    }

    public List<Task> GetContentOfTxt()
    {

        
    }

    public Task UpdateContentOfTxtFile(string filePath, string newContent)
    {
        throw new NotImplementedException();
    }

    public Task UploadFile(IFormFile file, string? folderPath)
    {
        Path.Combine(_path, folderPath);
        if (!File.Exists(folderPath))
        {
            throw new Exception($"{folderPath} does not exist to upload");

        }


    }

    public Task UploadFiles(List<IFormFile> files, string? folderPath)
    {
        var filename=Path.Combine(folderPath, 
    }


    public Task UploadFileWithChunks(IFormFile file, string? folderPath)
    {
        throw new NotImplementedException();
    }

}
