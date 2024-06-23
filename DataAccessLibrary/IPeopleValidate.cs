
namespace DataAccessLibrary
{
    public interface IPeopleValidate
    {
        Task<bool> CheckCredentials(string email, string password);
    }
}