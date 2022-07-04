using BackEndCST.VizualizareModele;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace BackEndCST.Pages
{
    public class LoginModel : PageModel
    {

        private readonly SignInManager<IdentityUser> signIn;
        [BindProperty]
        public Login ModelLogin { get; set; }

        public LoginModel(SignInManager<IdentityUser> signIn)
        {
            this.signIn = signIn;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync(string URL_intoarcere = null)
        {
            if (ModelState.IsValid)
            {
                var rez = await signIn.PasswordSignInAsync(ModelLogin.Email, ModelLogin.Password, ModelLogin.tine_minte, false);
                if (rez.Succeeded)
                {
                    if(URL_intoarcere == null || URL_intoarcere == "/")
                    {
                        return RedirectToPage("Index");
                    }
                    else
                    {
                        return RedirectToPage(URL_intoarcere);
                    }
                }
                ModelState.AddModelError("", "Username-ul sau parola au fost introduse gresit");
            }
            return Page();
        }
    }
}
