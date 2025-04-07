using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos.Database;  

namespace CapaNegocio.Accion
{
    internal class AccionesConsulta : AccionesBases
    {
        //metodos de Listar

        #region Listados Genericos

        public List<ConfiguracionSistema> ListConfiguracionSistema()
        {
            return dbLibContex.ConfiguracionSistema.ToList();
        }

        public List<HistorialUso> ListHistorialUso()
        {
            return dbLibContex.HistorialUso.ToList();
        }
    

    public List<Equipos> ListEquipos()
        {
            return dbLibContex.Equipos.ToList();
        }

       public List<Horarios> ListHorarios()
        {
            return dbLibContex.Horarios.ToList();
        }

        public List<TiposSala> ListTiposSala()
        {
            return dbLibContex.TiposSala.ToList();
        }
       
        public List<Salas> ListSala()
        {
            return dbLibContex.Salas.ToList();
        }

        public List<Reservaciones> ListReservaciones()
        {
            return dbLibContex.Reservaciones.ToList();
        }


        public List<Usuarios> ListUsuarios()
        {
            return dbLibContex.Usuarios.ToList();
        }

        List<ReportesIncidencias> ListReportesIncidencias()
        {
            return dbLibContex.ReportesIncidencias.ToList();
        }


        #endregion Listados Genericos

    }
}
