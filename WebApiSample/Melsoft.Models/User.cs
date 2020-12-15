namespace Melsoft.Models
{
    /// <summary>
    /// Data Transfer
    /// </summary>
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Forename { get; set; }

        public string Surname { get; set; }

        public string Title { get; set; }

        public string Email { get; set; }
    }
}