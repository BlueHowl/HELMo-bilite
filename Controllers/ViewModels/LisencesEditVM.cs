using System.ComponentModel.DataAnnotations;

namespace HELMo_bilite.Controllers.ViewModels
{
    public class LisencesEditVM
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Possessed { get; set; }
    }
}
    