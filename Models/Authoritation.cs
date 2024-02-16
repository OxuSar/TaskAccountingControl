namespace Models
{
    public class Authoritation
    {
        public string login { get; set; }
        public string password { get; set; }

        public bool isAdmin = false;
    }
}