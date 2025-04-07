using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Database;
using System.Data;

namespace CapaNegocio
{
    public  class AccionesBases
    {
        public DbliraryDataContext dbLibContex = new DbliraryDataContext();

        public List<ReportesIncidencias> ListReportesIncidencias() => dbLibContex.ReportesIncidencias.ToList();

        public List<Roles> ListRoles()
        {
            return dbLibContex.Roles.ToList();
        }
    }
}
