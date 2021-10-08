using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;

namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class FormRutasModel : PageModel
    {   
        
        private readonly RepositorioRutas repositorioRutas;
        [BindProperty]
        public Rutas ruta {get; set; }

        public  FormRutasModel(RepositorioRutas repositorioRutas){
            this.repositorioRutas = repositorioRutas;
        }
        public void OnGet()
        {
 
        }

       public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }            
             ruta = repositorioRutas.CreateRutas(ruta);            
            return RedirectToPage("./List");
        }
    }
}