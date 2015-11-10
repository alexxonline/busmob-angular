using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusMobServer.Models
{
    public class RequestViewModel
    {
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime? FechaSalida { get; set; }
        public DateTime? FechaLlegada { get; set; }
    }
}
