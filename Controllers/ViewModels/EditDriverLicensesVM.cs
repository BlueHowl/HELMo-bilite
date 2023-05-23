using HELMo_bilite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace HELMo_bilite.Controllers.ViewModels
{
    public class EditDriverLicensesVM
    {
        public string Matricule { get; set; }

        public List<SelectListItem>? Licenses { get; set; }

        public List<string>? IdsLicensesSelect { get; set; }
    }
}
