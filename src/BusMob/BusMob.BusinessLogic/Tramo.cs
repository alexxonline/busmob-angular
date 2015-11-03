using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusMob.BusinessLogic
{
    public class Tramo
    {
        public int Distancia { get; set; }
        public int Duracion { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public int Orden { get; set; }
        public TipoTramo TipoTramo { get; set; }

        public Direccion UbicacionSalida { get; set; }
        public Direccion UbicacionLlegada { get; set; }

        private IEstrategiaCalculoDeTramo EstrategiaCalculoTramo { get; set; }

        private void AgregarEstrategiaCalculoTramo(IEstrategiaCalculoDeTramo estrategia)
        {
            EstrategiaCalculoTramo = estrategia;
        }
    }
}
