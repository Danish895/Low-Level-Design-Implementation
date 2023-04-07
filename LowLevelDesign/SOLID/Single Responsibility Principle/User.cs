namespace LowLevelDesign.SOLID.Single_Responsibility_Principle
{
    
    // Violation of SRP
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public void Authenticate()
        {
            // Code to authenticate user
        }

        public void ChangePassword(string newPassword)
        {
            // Code to change user's password
        }
    }

    // Here, the User class has two responsibilities: authentication and password management.
    // This violates SRP, as each class should have only one responsibility.

    // Adherence to SRP
    public class UserAuthenticator
    {
        public void Authenticate(User user)
        {
            // Code to authenticate user
        }
    }

    public class PasswordManager
    {
        public void ChangePassword(User user, string newPassword)
        {
            // Code to change user's password
        }
    }

    // Now, the responsibilities of authentication and password management have been separated into two different classes.


}
