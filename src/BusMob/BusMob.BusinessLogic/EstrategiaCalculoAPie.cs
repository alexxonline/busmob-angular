using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusMob.BusinessLogic
{
    public class EstrategiaCalculoAPie :  IEstrategiaCalculoDeTramo
    {
        private int CantidadDeCuadras;
        private int TiempoAproximadoPorCuadra = 5;
        public int CalcularDuracionTramo(Direccion origen, Direccion destino)
        {
            CantidadDeCuadras = (origen.Nro - destino.Nro)/100;
            var resultado = CantidadDeCuadras * TiempoAproximadoPorCuadra;

            if(resultado < 0)
            {
                resultado = resultado * -1;
            }

            if(resultado == 0)
            {
                resultado = 5;
            }

            return resultado;
        }
    }
}
