namespace P2Ü_Stunde_1
{
    public class Contact
    {
        private string nickName;
        public string NickName
        {
            get
            {
                return nickName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception();
                }
                else
                {
                    nickName = value;
                }
            }
        }
        public string FirstName { get; private set; } //FirstName darf nur in Contact geändert werden
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Contact(string pFirstName, string pLastName, string pEmail, string pPhoneNumber)
        {
            FirstName = pFirstName;
            LastName = pLastName;
            Email = pEmail;
            PhoneNumber = pPhoneNumber;
        }

        public string Name
        {
            get
            {
                return $"firstname: {FirstName}, lastname: {LastName}";
            }
        }

        public string FormatString()
        {
            return $"Firstname: {FirstName}, Lastname: {LastName}, Email: {Email}, Telefonummer: {PhoneNumber}";

        }

        //Mit override wird ToString() aus Superklasse Object überschrieben
        public override string ToString()
        {
            return $"Firstname: {FirstName}, Lastname: {LastName}, Email: {Email}, Telefonummer: {PhoneNumber}";
        }
    }
}
