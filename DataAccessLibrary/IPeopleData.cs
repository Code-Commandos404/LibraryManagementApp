using LibraryManagementApp.Models;

namespace DataAccessLibrary
{
    public interface IPeopleData
    {
        Task<List<PeopleModel>> GetPeople();
        Task InsertPerson(PeopleModel person);
    }
}