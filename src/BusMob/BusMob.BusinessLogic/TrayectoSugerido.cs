using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusMob.BusinessLogic
{
    public class TrayectoSugerido
    {
        public TrayectoSugerido()
        {
            Tramos = new List<Tramo>();
        }

        public int DistanciaACaminar { get; set; }
        public int DuracionTotalEstimada { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        
        public List<Tramo> Tramos { get; set; }

        public Trayecto Trayecto { get; set; }
    }
}
