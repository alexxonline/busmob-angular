using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusMob.BusinessLogic
{
    public interface IEstrategiaCalculoDeTramo
    {
        int CalcularDuracionTramo(Direccion origen, Direccion destino);
    }
}
