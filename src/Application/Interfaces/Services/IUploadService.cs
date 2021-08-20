using ProjectServices.Application.Requests;

namespace ProjectServices.Application.Interfaces.Services
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}