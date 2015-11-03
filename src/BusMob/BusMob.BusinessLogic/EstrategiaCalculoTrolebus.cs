using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusMob.BusinessLogic
{
    public class EstrategiaCalculoTrolebus : IEstrategiaCalculoDeTramo
    {
        private int EstadoDelCableado = 4;
        private int TiempoEsperaTrolebus = 12;
        private int TransitoEnZona = 3;
        public int CalcularDuracionTramo(Direccion origen, Direccion destino)
        {
            var aleatorio = new Random().Next(10) * origen.Nro / 10;
            var resultado = EstadoDelCableado * TiempoEsperaTrolebus * TransitoEnZona * aleatorio * 0.1;
            return (int)Math.Round(resultado);
        }
    }
}
