using System.ComponentModel.DataAnnotations;

namespace HELMo_bilite.Models
{
    public class User
    {
        /// <summary>
        /// TODO: demander au prof si le client a un matricule
        /// </summary>
        public string Matricule { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
    }
}
