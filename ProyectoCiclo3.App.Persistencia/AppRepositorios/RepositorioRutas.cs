using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {
        
        List<Rutas> rutas;
 
    public RepositorioRutas()
        {
            rutas= new List<Rutas>()
            {
                new Rutas{id=1,origen="Audi",destino= "Bosa",tiempo_estimado= 1},
                new Rutas{id=2,origen="Toyota",destino= "Engativa",tiempo_estimado= 2},
                new Rutas{id=3,origen="Mazda",destino= "Suba",tiempo_estimado= 3}
 
            };
        }
 
        public IEnumerable<Rutas> GetAll()
        {
            return rutas;
        }
 
        public Rutas GetRutasWithId(int id){
            return rutas.SingleOrDefault(b => b.id == id);
        }


        public Rutas CreateRutas(Rutas newRuta){
         if(rutas.Count > 0){
           newRuta.id=rutas.Max(r => r.id) +1; 
            }else{
               newRuta.id = 1; 
            }
          rutas.Add(newRuta);
           return newRuta;
        }


         public Rutas Update(Rutas newRuta){
            var ruta= rutas.SingleOrDefault(b => b.id == newRuta.id);
            if(ruta != null){
                ruta.origen = newRuta.origen;
                ruta.destino = newRuta.destino;
                ruta.tiempo_estimado = newRuta.tiempo_estimado;
            }
        return ruta;
        }
       public Rutas Delete(int id)
        {
        var ruta= rutas.SingleOrDefault(b => b.id == id);
        rutas.Remove(ruta);
        return ruta;
        }
    
    }
   

}
