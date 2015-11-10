using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusMob.BusinessLogic;

namespace BusMobServer.Models
{
    public class DefaultRouteViewModelMapper : IRouteViewModelMapper
    {
        public RouteViewModel Map(TrayectoSugerido trayectoSugerido)
        {
            var route = new RouteViewModel();
            route.Start = trayectoSugerido.FechaHoraInicio.ToString("hh:mm");
            route.End = trayectoSugerido.FechaHoraInicio.AddMinutes(trayectoSugerido.DuracionTotalEstimada).ToString("hh:mm");
            route.TotalTime = trayectoSugerido.DuracionTotalEstimada;
            route.WalkDistance = trayectoSugerido.DistanciaACaminar;


            foreach (var tramo in trayectoSugerido.Tramos)
            {
                var part = new RoutePartViewModel();
                part.Name = GetPartName(tramo);
                part.Additional = GetAdditional(tramo);
                part.Instruction = GetPartInstruction(tramo);
                part.Time = tramo.HoraSalida.Hours.ToString() + ":" + tramo.HoraSalida.Minutes;
                part.Type = tramo.TipoTramo.Nombre;
                part.Distance = tramo.Distancia;
                part.Duration = tramo.Duracion;
                route.Parts.Add(part);
            }

            return route;
        }

        private string GetPartName(Tramo tramo)
        {
            var mensaje = tramo.UbicacionSalida.Calle + " " + tramo.UbicacionSalida.Nro;

            return mensaje;
        }

        private string GetPartInstruction(Tramo tramo)
        {
            var mensaje  = "";
            var random = new Random();
            if (tramo.TipoTramo.Nombre == "bus")
            {
                var colectivo = random.Next(100);
                mensaje += string.Format("Tomar el colectivo {0} de Ersa", colectivo);
            }
            else if(tramo.TipoTramo.Nombre == "trole")
            {
                var trole = random.Next(100);
                mensaje += string.Format("Tomar el trole {0} de Tamse", trole);
            }
            else if (tramo.TipoTramo.Nombre == "walk")
            {
                mensaje += string.Format("Andar a destino {0} {1}", tramo.UbicacionLlegada.Calle, tramo.UbicacionSalida.Nro);
            }
            return mensaje;
        }

        private string GetAdditional(Tramo tramo)
        {
            if(tramo.TipoTramo.Nombre == "bus" || tramo.TipoTramo.Nombre == "trole")
            {
                return tramo.UbicacionLlegada.Calle + " " + tramo.UbicacionLlegada.Nro;
            }
            return null;
        }
    }
}
