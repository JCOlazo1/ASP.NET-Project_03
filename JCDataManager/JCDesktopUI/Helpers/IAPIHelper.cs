using JCDesktopUI.Models;
using System.Threading.Tasks;

namespace JCDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}