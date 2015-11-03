using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusMob.BusinessLogic
{
    public class TipoTramo
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public string MostrarNombre()
        {
            return Nombre;
        }
    }
}
