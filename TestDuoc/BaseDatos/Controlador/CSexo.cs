using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos.Controlador
{
    public class CSexo
    {
        public int agregarNuevoSexo(string descripcion)
        {
            using (test_duocEntities entidades = new test_duocEntities())
            {
                sexo insercion = new sexo();
                insercion.id_sexo = buscarUltimoId();
                insercion.descripcion = descripcion;
                entidades.sexo.Add(insercion);
                return entidades.SaveChanges();
                
            }
        }

        private int buscarUltimoId()
        {
            using(test_duocEntities entidades = new test_duocEntities())
            {
                var consulta = entidades.sexo.ToList();
                               
                return consulta.Count+1;
            }
        }
    }
}
