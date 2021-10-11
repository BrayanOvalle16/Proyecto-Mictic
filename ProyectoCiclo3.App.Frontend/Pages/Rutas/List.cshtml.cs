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
 public class ListRutasModel : PageModel
    {
         [BindProperty]
        Rutas ruta {get; set;}
        private readonly RepositorioRutas repositorioRutas;
        public IEnumerable<Rutas> rutas {get;set;}
 
    public ListRutasModel(RepositorioRutas RepositorioRutas)
    {
        this.repositorioRutas=RepositorioRutas;
     }
 
    public void OnGet()
    {
        rutas=repositorioRutas.GetAll();
    }

       public IActionResult OnPost()
    {
        if(ruta.id>0)
        {
        ruta = repositorioRutas.Delete(ruta.id);
        }
        return RedirectToPage("./List");
    }

    }

    }
