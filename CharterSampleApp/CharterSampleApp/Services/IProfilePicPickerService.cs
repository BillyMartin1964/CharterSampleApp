using System.IO;
using System.Threading.Tasks;

namespace CharterSampleApp.Services
{
    public interface IProfilePicPickerService
    {
        Task<Stream> GetImageStreamAsync();
    }
}
