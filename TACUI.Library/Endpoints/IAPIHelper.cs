using System.Net.Http;
using System.Threading.Tasks;

namespace TACUI.Library.Endpoints
{
    public interface IAPIHelper
    {
        HttpClient _apiClient { get; set; }

        Task Login(string username, string password);
        void Logout();
        Task Register(string email, string password, string confirmPassword);
    }
}