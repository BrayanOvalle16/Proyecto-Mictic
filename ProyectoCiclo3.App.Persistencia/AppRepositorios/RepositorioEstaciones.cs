using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEstaciones
    {
        List<Estaciones> estaciones;
 
    public RepositorioEstaciones()
        {
            estaciones= new List<Estaciones>()
            {
                new Estaciones{id=1, nombre="Marly", direccion="Calle 57 #97a 20", coord_x=43, coord_y=89, Tipo="1"},
                new Estaciones{id=2, nombre="Bosa laurel", direccion="Calle 89 #97a 20", coord_x=93, coord_y=99, Tipo="3"},
                new Estaciones{id=3, nombre="Engativa", direccion="Calle 87 #97a 20", coord_x=23, coord_y=69, Tipo="1"}
 
            };
        }
 
        public IEnumerable<Estaciones> GetAll()
        {
            return estaciones;
        }
 
        public Estaciones GetEstacionesWithId(int id){
            return estaciones.SingleOrDefault(b => b.id == id);
        }

         public Estaciones Update(Estaciones newEstaciones){
            var estacion= estaciones.SingleOrDefault(b => b.id == newEstaciones.id);
            if(estacion != null){
                estacion.nombre = newEstaciones.nombre;
                estacion.direccion = newEstaciones.direccion;
                estacion.coord_x = newEstaciones.coord_x;
                estacion.coord_y = newEstaciones.coord_y;
                estacion.Tipo = newEstaciones.Tipo;
            }
        return estacion;
        }


         public Estaciones Delete(int id)
        {
        var estacion= estaciones.SingleOrDefault(b => b.id == id);
        estaciones.Remove(estacion);
        return estacion;
        }


    }
   

}
