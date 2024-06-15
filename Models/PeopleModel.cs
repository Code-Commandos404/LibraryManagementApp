namespace LibraryManagementApp.Models
{
    public class PeopleModel
    {
        public class People
        {
            private string _firstName { get; set; }
            private string _lastName { get; set; }
            private int _personId { get; set; }
            private string _contactNumber { get; set; }
            private string _Address { get; set; }
            private string _Gender { get; set; }
            private string _Email { get; set; }
            public People(string firstName, string lastName, string contactNumber, string Address, string Gender, string Email)
            {
                _firstName = firstName;
                _lastName = lastName;
                _contactNumber = contactNumber;
                _Address = Address;
                _Gender = Gender;
                _Email = Email;

            }

        }

    }
}