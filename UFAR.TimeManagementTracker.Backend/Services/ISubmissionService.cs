using System.IO;
using System.Threading.Tasks;

public interface ISubmissionService
{
    Task<string> UploadFileToBlobAsync(Stream fileStream, string fileName);
    Task DeleteFileFromBlobAsync(string fileUrl);

}