using BackEndCST.VizualizareModele;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;


namespace BackEndCST.Pages
{
    public class InregistrareModel : PageModel
    {
        private readonly UserManager<IdentityUser> utilizatori;
        private readonly SignInManager<IdentityUser> utilizatori_logare;
        

        [BindProperty]
        public Inregistrare ModelInreg { get; set; }
        public InregistrareModel(UserManager<IdentityUser> utilizatori, SignInManager<IdentityUser> utilizatori_logare)
        {
            this.utilizatori = utilizatori;
            this.utilizatori_logare = utilizatori_logare;
        }
       
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser()
                {
                    UserName = ModelInreg.email,
                    Email = ModelInreg.email
                };

                var rezultat_inreg = await utilizatori.CreateAsync(user, ModelInreg.password);

                if (rezultat_inreg.Succeeded)
                {
                    await utilizatori_logare.SignInAsync(user, false);
                    return RedirectToPage("Index");
                }

                foreach(var eroare in rezultat_inreg.Errors)
                {
                    ModelState.AddModelError("", eroare.Description);
                    //in cazul unei erori se va apela clasa IdentityErrorDescriber
                }

            }
            return Page();
        }
    }
}
