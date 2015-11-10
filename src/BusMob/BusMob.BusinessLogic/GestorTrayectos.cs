using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusMob.BusinessLogic
{
    public class GestorTrayectos : IGestorTrayectos
    {
        private readonly IEstrategiaCalculoTramoFactory EstrategiaFactory;
        public GestorTrayectos(IEstrategiaCalculoTramoFactory estrategiaFactory)
        {
            EstrategiaFactory = estrategiaFactory;
        }


        public List<TrayectoSugerido> CalcularTresMejoresTrayectos(Direccion origen, Direccion destino, DateTime? fechaDesde, DateTime? fechaHasta)
        {
            var trayecto1 = CrearPrimerTrayecto(origen, destino, fechaDesde, fechaHasta);
            var trayecto2 = CrearSegundoTrayecto(origen, destino, fechaDesde, fechaHasta);
            var trayecto3 = CrearTercerTrayecto(origen, destino, fechaDesde, fechaHasta);

            var trayectos = new List<TrayectoSugerido>();
            trayectos.Add(trayecto1);
            trayectos.Add(trayecto2);
            trayectos.Add(trayecto3);

            foreach(var trayecto in trayectos)
            {
                foreach (var tramo in trayecto.Tramos)
                {
                    var estrategia = EstrategiaFactory.CrearEstrategia(tramo.TipoTramo.Nombre);
                    tramo.AgregarEstrategiaCalculoTramo(estrategia);
                }
            }

            return trayectos;
        }

        private TrayectoSugerido CrearPrimerTrayecto(Direccion origen, Direccion destino, DateTime? fechaDesde, DateTime? fechaHasta)
        {
            // Normalmente esto implicaría llamadas a la base de datos
            // Para simplificar el patrón vamos a utilizar datos hardcodeados
            var tiposTramo = BuscarTiposTramo();

            var trayectoSugerido = new TrayectoSugerido();
            trayectoSugerido.Trayecto = new Trayecto();
            trayectoSugerido.Trayecto.Origen = origen;
            trayectoSugerido.Trayecto.Destino = destino;
            trayectoSugerido.FechaHoraInicio = fechaDesde.Value;
            trayectoSugerido.DistanciaACaminar = 22;
            trayectoSugerido.DuracionTotalEstimada = 44;
            trayectoSugerido.Tramos.Add(new Tramo
            {
                Distancia = 22,
                HoraSalida = new TimeSpan(fechaDesde.Value.Hour, fechaDesde.Value.Minute, fechaDesde.Value.Second),
                Orden = 1,
                UbicacionSalida = origen,
                UbicacionLlegada = new Direccion { Calle = "General Paez", Nro = 222 },
                TipoTramo = tiposTramo["walk"]
            });
            trayectoSugerido.Tramos.Add(new Tramo
            {
                Distancia = 900,
                HoraSalida = new TimeSpan(fechaDesde.Value.Hour, fechaDesde.Value.Minute, fechaDesde.Value.Second),
                Orden = 1,
                UbicacionSalida = trayectoSugerido.Tramos[0].UbicacionLlegada,
                UbicacionLlegada = new Direccion { Calle = "29 de abril", Nro = 11 },
                TipoTramo = tiposTramo["bus"]
            });
            trayectoSugerido.Tramos.Add(new Tramo
            {
                Distancia = 1400,
                HoraSalida = new TimeSpan(fechaDesde.Value.Hour, fechaDesde.Value.Minute, fechaDesde.Value.Second),
                Orden = 1,
                UbicacionSalida = trayectoSugerido.Tramos[1].UbicacionLlegada,
                UbicacionLlegada = new Direccion { Calle = "Octavio Pintos", Nro = 456 },
                TipoTramo = tiposTramo["trole"]
            });
            trayectoSugerido.Tramos.Add(new Tramo
            {
                Distancia = 929,
                HoraSalida = new TimeSpan(fechaDesde.Value.Hour, fechaDesde.Value.Minute, fechaDesde.Value.Second),
                Orden = 1,
                UbicacionSalida = trayectoSugerido.Tramos[2].UbicacionLlegada,
                UbicacionLlegada = new Direccion { Calle = "Ing. Martinez", Nro = 994 },
                TipoTramo = tiposTramo["walk"]
            });

            return trayectoSugerido;
        }

        public TrayectoSugerido CrearSegundoTrayecto(Direccion origen, Direccion destino, DateTime? fechaDesde, DateTime? fechaHasta)
        {
            // Normalmente esto implicaría llamadas a la base de datos
            // Para simplificar el patrón vamos a utilizar datos hardcodeados
            var tiposTramo = BuscarTiposTramo();

            var trayectoSugerido = new TrayectoSugerido();
            trayectoSugerido.Trayecto = new Trayecto();
            trayectoSugerido.Trayecto.Origen = origen;
            trayectoSugerido.Trayecto.Destino = destino;
            trayectoSugerido.FechaHoraInicio = fechaDesde.Value;
            trayectoSugerido.DistanciaACaminar = 67;
            trayectoSugerido.DuracionTotalEstimada = 49;
            trayectoSugerido.Tramos.Add(new Tramo
            {
                Distancia = 22,
                HoraSalida = new TimeSpan(fechaDesde.Value.Hour, fechaDesde.Value.Minute, fechaDesde.Value.Second),
                Orden = 1,
                UbicacionSalida = origen,
                UbicacionLlegada = new Direccion { Calle = "General perón 354", Nro = 11 },
                TipoTramo = tiposTramo["walk"]
            });
            trayectoSugerido.Tramos.Add(new Tramo
            {
                Distancia = 900,
                HoraSalida = new TimeSpan(fechaDesde.Value.Hour, fechaDesde.Value.Minute, fechaDesde.Value.Second),
                Orden = 1,
                UbicacionSalida = trayectoSugerido.Tramos[0].UbicacionLlegada,
                UbicacionLlegada = new Direccion { Calle = "29 de abril", Nro = 11 },
                TipoTramo = tiposTramo["bus"]
            });
            trayectoSugerido.Tramos.Add(new Tramo
            {
                Distancia = 1400,
                HoraSalida = new TimeSpan(fechaDesde.Value.Hour, fechaDesde.Value.Minute, fechaDesde.Value.Second),
                Orden = 1,
                UbicacionSalida = trayectoSugerido.Tramos[1].UbicacionLlegada,
                UbicacionLlegada = new Direccion { Calle = "Octavio Pintos", Nro = 456 },
                TipoTramo = tiposTramo["trole"]
            });
            trayectoSugerido.Tramos.Add(new Tramo
            {
                Distancia = 929,
                HoraSalida = new TimeSpan(fechaDesde.Value.Hour, fechaDesde.Value.Minute, fechaDesde.Value.Second),
                Orden = 1,
                UbicacionSalida = trayectoSugerido.Tramos[2].UbicacionLlegada,
                UbicacionLlegada = new Direccion { Calle = "Ing. Martinez", Nro = 994 },
                TipoTramo = tiposTramo["walk"]
            });

            return trayectoSugerido;
        }

        public TrayectoSugerido CrearTercerTrayecto(Direccion origen, Direccion destino, DateTime? fechaDesde, DateTime? fechaHasta)
        {
            // Normalmente esto implicaría llamadas a la base de datos
            // Para simplificar el patrón vamos a utilizar datos hardcodeados
            var tiposTramo = BuscarTiposTramo();

            var trayectoSugerido = new TrayectoSugerido();
            trayectoSugerido.Trayecto = new Trayecto();
            trayectoSugerido.Trayecto.Origen = origen;
            trayectoSugerido.Trayecto.Destino = destino;
            trayectoSugerido.FechaHoraInicio = fechaDesde.Value;
            trayectoSugerido.DistanciaACaminar = 92;
            trayectoSugerido.DuracionTotalEstimada = 49;
            trayectoSugerido.Tramos.Add(new Tramo
            {
                Distancia = 92,
                HoraSalida = new TimeSpan(fechaDesde.Value.Hour, fechaDesde.Value.Minute, fechaDesde.Value.Second),
                Orden = 1,
                UbicacionSalida = origen,
                UbicacionLlegada = new Direccion { Calle = "Boulevar Tecnológico", Nro = 887 },
                TipoTramo = tiposTramo["walk"]
            });
            trayectoSugerido.Tramos.Add(new Tramo
            {
                Distancia = 900,
                HoraSalida = new TimeSpan(fechaDesde.Value.Hour, fechaDesde.Value.Minute, fechaDesde.Value.Second),
                Orden = 1,
                UbicacionSalida = trayectoSugerido.Tramos[0].UbicacionLlegada,
                UbicacionLlegada = new Direccion { Calle = "29 de abril", Nro = 11 },
                TipoTramo = tiposTramo["bus"]
            });
            trayectoSugerido.Tramos.Add(new Tramo
            {
                Distancia = 1400,
                HoraSalida = new TimeSpan(fechaDesde.Value.Hour, fechaDesde.Value.Minute, fechaDesde.Value.Second),
                Orden = 1,
                UbicacionSalida = trayectoSugerido.Tramos[1].UbicacionLlegada,
                UbicacionLlegada = new Direccion { Calle = "Octavio Pintos", Nro = 456 },
                TipoTramo = tiposTramo["trole"]
            });
            trayectoSugerido.Tramos.Add(new Tramo
            {
                Distancia = 929,
                HoraSalida = new TimeSpan(fechaDesde.Value.Hour, fechaDesde.Value.Minute, fechaDesde.Value.Second),
                Orden = 1,
                UbicacionSalida = trayectoSugerido.Tramos[2].UbicacionLlegada,
                UbicacionLlegada = new Direccion { Calle = "Ing. Martinez", Nro = 994 },
                TipoTramo = tiposTramo["walk"]
            });

            return trayectoSugerido;
        }

        private Dictionary<string, TipoTramo> BuscarTiposTramo()
        {
            // Esto normalmente iría a una base de datos
            var tipoTramoBus = new TipoTramo { Nombre = "bus", Descripcion = "En colectivo" };
            var tipoTramoTrole = new TipoTramo { Nombre = "trole", Descripcion = "En trolebus" };
            var tipoTramoAPie = new TipoTramo { Nombre = "walk", Descripcion = "A pie" };

            var resultado = new Dictionary<string, TipoTramo>();
            resultado.Add("bus", tipoTramoBus);
            resultado.Add("trole", tipoTramoTrole);
            resultado.Add("walk", tipoTramoAPie);
            return resultado;
        }
    }
}
