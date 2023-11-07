namespace MBPC_VeilingApp.Classes
{
    public class Member
    {
        private int id;
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string zipCode;
        private string country;
        private int memberNumber;
        private string email;
        private DateTime birthDate;
        private DateTime memberDate;
        private string telephoneNumber;

        public Member(int _id, string _firstName, string _lastName, string _address, string _city, string _zipCode, string _country, int _memberNumber, string _email, DateTime _birthDate, DateTime _memberDate, string _telephoneNumber)
        {
            // Controle om te kijken of de opgegeven argumenten voldoen aan de database regels
            if (_firstName.Length > 50) { throw new ArgumentException("First Name should be at most 50 characters long."); }
            if (_lastName.Length > 50) { throw new ArgumentException("Last Name should be at most 50 characters long."); }
            if (_address.Length > 50) { throw new ArgumentException("Address should be at most 50 characters long."); }
            if (_city.Length > 50) { throw new ArgumentException("City should be at most 50 characters long."); }
            if (_zipCode.Length > 10) { throw new ArgumentException("Zip Code should be at most 10 characters long."); }
            if (_country.Length > 50) { throw new ArgumentException("Country should be at most 50 characters long."); }
            if (_email.Length > 100) { throw new ArgumentException("Email should be at most 100 characters long."); }
            if (_telephoneNumber.Length > 15) { throw new ArgumentException("Telephonenumber should be at most 50 characters long."); }

            id = _id;
            firstName = _firstName;
            lastName = _lastName;
            address = _address;
            city = _city;
            zipCode = _zipCode;
            country = _country;
            memberNumber = _memberNumber;
            email = _email;
            birthDate = _birthDate;
            memberDate = _memberDate;
            telephoneNumber = _telephoneNumber;
        }

        // Getters
        public int GetId()
        {
            return id;
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public string GetAddress()
        {
            return address;
        }

        public string GetCity()
        {
            return city;
        }

        public string GetZipCode()
        {
            return zipCode;
        }

        public string GetCountry()
        {
            return country;
        }

        public int GetMemberNumber()
        {
            return memberNumber;
        }

        public string GetEmail()
        {
            return email;
        }

        public DateTime GetBirthDate()
        {
            return birthDate;
        }

        public DateTime GetMemberDate()
        {
            return memberDate;
        }

        public string GetTelephoneNumber()
        {
            return telephoneNumber;
        }

        // Setters
        public void SetFirstName(string _firstName)
        {
            firstName = _firstName;
        }

        public void SetLastName(string _lastName)
        {
            lastName = _lastName;
        }

        public void SetAddress(string _address)
        {
            address = _address;
        }

        public void SetCity(string _city)
        {
            city = _city;
        }

        public void SetZipCode(string _zipCode)
        {
            zipCode = _zipCode;
        }

        public void SetCountry(string _country)
        {
            country = _country;
        }

        public void SetMemberNumber(int _memberNumber)
        {
            memberNumber = _memberNumber;
        }

        public void SetEmail(string _email)
        {
            email = _email;
        }

        public void SetBirthDate(DateTime _birthDate)
        {
            birthDate = _birthDate;
        }

        public void SetMemberDate(DateTime _memberDate)
        {
            memberDate = _memberDate;
        }

        public void SetTelephoneNumber(string _telephoneNumber)
        {
            telephoneNumber = _telephoneNumber;
        }

        // DAL functies
        public void CreateMemberDAL()
        {
            DAL.CreateMember(this);
        }

        public void UpdateMemberDAL(string _firstName, string _lastName, string _address, string _city, string _zipCode, string _country, int _memberNumber, string _email, DateTime _birthDate, DateTime _memberDate, string _telephoneNumber)
        {
            DAL.UpdateMember(new Member(id, _firstName, _lastName, _address, _city, _zipCode, _country, _memberNumber, _email, _birthDate, _memberDate, _telephoneNumber));
        }

        public void DeleteMemberDAL()
        {
            DAL.DeleteMember(this);
        }
    }
}
