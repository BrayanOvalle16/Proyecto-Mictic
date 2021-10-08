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
    public class EditEstacionesModel : PageModel
    {
        private readonly RepositorioEstaciones repositorioEstaciones;
        [BindProperty]
        public Estaciones Estaciones {get;set;}
 
        public EditEstacionesModel(RepositorioEstaciones repositorioEstaciones) 
       {
            this.repositorioEstaciones=repositorioEstaciones;
       }
 
        public IActionResult OnGet(int estacionId)
        {
                Estaciones=repositorioEstaciones.GetEstacionesWithId(estacionId);
                return Page();
 
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Estaciones.id>0)
            {
            Estaciones = repositorioEstaciones.Update(Estaciones);
            }
            return Page();
        }

    }
    
}
