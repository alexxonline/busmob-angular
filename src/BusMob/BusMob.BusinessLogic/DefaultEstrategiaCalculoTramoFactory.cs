using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusMob.BusinessLogic
{
    public class DefaultEstrategiaCalculoTramoFactory : IEstrategiaCalculoTramoFactory
    {
        public IEstrategiaCalculoDeTramo CrearEstrategia(string tipo)
        {
            switch(tipo)
            {
                case "bus":
                    return new EstrategiaCalculoColectivo();
                case "walk":
                    return new EstrategiaCalculoAPie();
                case "trole":
                    return new EstrategiaCalculoTrolebus();
                default:
                    return null;
            }
        }
    }
}
