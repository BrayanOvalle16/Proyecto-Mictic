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
 public class DetailsRutasModel : PageModel
    {
       
        private readonly RepositorioRutas RepositorioRutas;
        public Rutas rutas {get;set;}
 
    public DetailsRutasModel(RepositorioRutas RepositorioRutas)
    {
        this.RepositorioRutas=RepositorioRutas;
     }
 
 
        public IActionResult OnGet(int rutasId)
        {
                rutas=RepositorioRutas.GetRutasWithId(rutasId);
                return Page();
 
        }
    }
}
