using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos.Controlador
{
    public class CPersona
    {
       public string obtenerNombre(int rut)
        {
            using(test_duocEntities entidades = new test_duocEntities())
            {
                var consulta = entidades.persona.Where(x => x.rut == rut).FirstOrDefault();
                return consulta.nombre;
            }
        }
        

    }
}
