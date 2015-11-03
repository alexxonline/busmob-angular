using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusMob.BusinessLogic
{
    public class Trayecto
    {
        public string Nombre { get; set; }
        public Direccion Origen { get; set; }
        public Direccion Destino { get; set; }
    }
}
