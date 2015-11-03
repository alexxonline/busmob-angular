using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusMob.BusinessLogic
{
    public class EstrategiaCalculoColectivo : IEstrategiaCalculoDeTramo
    {
        private int EstadoCallesDelRecorrido = 2;
        private int TiempoDeEsperaDelColectivo = 15;
        private int TransitoEnzona = 3;
        public int CalcularDuracionTramo(Direccion origen, Direccion destino)
        {
            var cuadras = (origen.Nro - destino.Nro) / 100;
            if(cuadras < 0)
            {
                cuadras = cuadras * -1;
            }

            if(cuadras == 0)
            {
                cuadras = 30;
            }

            var resultado = TiempoDeEsperaDelColectivo + TransitoEnzona + cuadras;

            return resultado;
        }
    }
}
