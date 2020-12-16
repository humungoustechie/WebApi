using System.ComponentModel.DataAnnotations;

namespace Melsoft.Models
{
    /// <summary>
    /// Data Transfer
    /// </summary>
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Forename { get; set; }

        [Required]
        public string Surname { get; set; }

        public string Title { get; set; }

        [Required]
        public string Email { get; set; }
    }
}