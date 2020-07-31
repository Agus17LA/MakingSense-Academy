using Phones.Model;
using System.Threading.Tasks;

namespace Phones.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}