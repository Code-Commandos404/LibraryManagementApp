using LibraryManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class PeopleData : IPeopleData
    {
        private readonly ISqlDb _db; //Initializer

        public PeopleData(ISqlDb db) // Assigning the interface as a parameter for the constructor
        {
            _db = db;
        }

        public Task<List<PeopleModel>> GetPeople() // returns list of type people Model. no purpose to await it as its already processing the task asyncronously
        {
            String sql = "Select * from dbo.People;";
            return _db.LoadData<PeopleModel, dynamic>(sql, new { }); //passes parameters to the function as created. people model being type t and dynamic is type u
                                                                     //new{ } means that there are no paramters for the sql query

        }
        public Task InsertPerson(PeopleModel person)
        {
            string sql = @"insert into dbo.People(FirstName,LastName,ContactNumber,Address,Gender,Email)" +
                            "values (@FirstName,@LastName,@ContactNumber,@Address,@Gender,@Email)"; ///only if the variable names are the same as the column names else use the name of the variables

            return _db.SaveData(sql, person);///no purpose to await the data

        }
    }
}
