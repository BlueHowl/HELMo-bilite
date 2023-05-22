using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HELMo_bilite.Data;
using HELMo_bilite.Models;
using HELMo_bilite.Controllers.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace HELMo_bilite.Controllers
{
    public class HelmoMembersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public HelmoMembersController(ApplicationDbContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        // GET: HelmoMembers
        public async Task<IActionResult> Index()
        {
              return _context.HelmoMembers != null ? 
                          View(TransformListOfMember(await _context.HelmoMembers.ToListAsync())) :
                          Problem("Entity set 'ApplicationDbContext.HelmoMembers'  is null.");
        }

        // GET: HelmoMembers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.HelmoMembers == null)
            {
                return NotFound();
            }

            var helmoMember = await _context.HelmoMembers
                .FirstOrDefaultAsync(m => m.Matricule == id);
            if (helmoMember == null)
            {
                return NotFound();
            }

            return View(helmoMember);
        }

        // GET: HelmoMembers/Create
        public IActionResult Create()
        {
            return View();
        }

       

        private List<HelmoMemberVM> TransformListOfMember(List<HelmoMember> helmoMembers)
        {
            
            return helmoMembers.Select(m => new HelmoMemberVM
            {
                PictureScr = m.PictureScr,
                Matricule = m.Matricule,
                Name = m.Name,
                FirstName = m.FirstName,
                Role = (m.Matricule.StartsWith("DR")) ?"Driver" : "Dispatcher"
            }).ToList();
        }
    }
}
