using BusMob.BusinessLogic;
using BusMobServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BusMobServer.Controllers
{
    public class TrayectosController : ApiController
    {
        private readonly IGestorTrayectos GestorTrayectos;
        private readonly IRouteViewModelMapper RouteViewModelMapper;

        public TrayectosController(IGestorTrayectos gestorTrayectos,
            IRouteViewModelMapper routeViewModelMapper)
        {
            if(gestorTrayectos == null)
            {
                throw new ArgumentNullException("gestorTrayectos");
            }

            GestorTrayectos = gestorTrayectos;

            if(routeViewModelMapper == null)
            {
                throw new ArgumentNullException("routeViewModelMapper");
            }

            RouteViewModelMapper = routeViewModelMapper;
        }

        public List<RouteViewModel> Get([FromUri] RequestViewModel request)
        {
            var direccionOrigen = new Direccion();
            direccionOrigen.Calle = "9 de julio";
            direccionOrigen.Nro = 133;

            var direccionDestino = new Direccion();
            direccionDestino.Calle = "Av. Fuerza aerea";
            direccionDestino.Nro = 444;

            var trayectos = GestorTrayectos.CalcularTresMejoresTrayectos(direccionOrigen,
                    direccionDestino, request.FechaSalida, request.FechaLlegada);

            var lista = new List<RouteViewModel>();
            foreach (var trayecto in trayectos)
            {
                lista.Add(RouteViewModelMapper.Map(trayecto));
            }

            return lista;
        }
    }
}
