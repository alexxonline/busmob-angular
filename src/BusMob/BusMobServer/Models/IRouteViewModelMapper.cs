using BusMob.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusMobServer.Models
{
    public interface IRouteViewModelMapper
    {
        RouteViewModel Map(TrayectoSugerido trayectoSugerido);
    }
}
