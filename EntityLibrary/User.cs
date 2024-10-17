using System.Data;

namespace EntityLibrary
{
    public class User
    {
        private int _UserID;
        private string _Username;
        private string _Password;
        private string _Role;


        public User()
        {
        }

        public User(int UserID, string Username, string Password, string Role)
        {
            this._UserID = UserID;
            this._Username = Username;
            this._Password = Password;
            this._Role = Role;
        }

        public int UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public string Role
        {
            get { return _Role; }
            set { _Role = value; }
        }

        public override string ToString()
        {
            return $"UserId: {UserID}, Username: {Username}, Role: {Role}";
        }

        public void PrintDetails()
        {
            Console.WriteLine("User ID: " + UserID);
            Console.WriteLine("Username: " + Username);
            Console.WriteLine("Role: " + Role);
        }
    }
}
