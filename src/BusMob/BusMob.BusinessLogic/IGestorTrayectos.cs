using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusMob.BusinessLogic
{
    public interface IGestorTrayectos
    {
        List<TrayectoSugerido> CalcularTresMejoresTrayectos(Direccion origen, Direccion destino, DateTime fechaDesde, DateTime fechaHasta);
    }
}
