namespace Analytics.Test
{
    public static class Credentials
    {
        public static class Vaild
        {
            public static UserCredentials Admin => new UserCredentials("test", "qwe123", "Admin", "Test");
            public static UserCredentials Expert => new UserCredentials("test", "123qwe", "Expert", "User");
            public static UserCredentials User => new UserCredentials("Alamakota12@test.com", "123qwe", "Ala", "Kot");

        }
    }
    public class UserCredentials
    {
        public UserCredentials(string email, string password, string name, string surname)
        {
            Email = email;
            Password = password;
            Name = name;
            Surname = surname;
        }
        public string Email { get; }
        public string Password { get; }
        public string Name { get; }
        public string Surname { get; }
        public string UserInfo => Name + " " + Surname + " (" + Email + ")";
    }
}
public static class InVaild
{
    public static class Email
    {
        public static string EmailWithoutAt = "master-admin.com";
        public static string EmailWithoitDomain = "master@admin";
        public static string EmailWithWhiteSpace = "master@    admin.com";
        public static class Password
        {
            public static string OneCharacters = "1";
            public static string TwoCharacters = "12";
            public static string ThreeCharacters = "123";
            public static string FourCharacters = "1234";
        }
    }
}





