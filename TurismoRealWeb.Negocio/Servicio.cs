using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoRealWeb.DALC;
namespace TurismoRealWeb.Negocio
{
    public class Servicio
    {

        public decimal idServicio { get; set; }
        public String nombreServicio { get; set; }
        public DateTime fechaServicio { get; set; }
        public decimal contratoIdContrato { get; set; }
        public String contratoProveedorIdProveedor { get; set; }
        public decimal costoServicio { get; set; }
        public Contrato contrato { get; set; }


        TurismoRealEntities db = new TurismoRealEntities();

        public List<Servicio> ReadAll()
        {
            return db.SERVICIO.Select(s => new Servicio() {
                idServicio = s.ID_SERVICIO,
                nombreServicio = s.NOMBRE_SERVICIO,
                fechaServicio = (DateTime)s.FECHA_SERVICIO,
                contratoIdContrato = s.CONTRATO_ID_CONTRATO,
                contratoProveedorIdProveedor = s.CONTRATO_PROVEEDOR_ID_PROVEEDOR,
                costoServicio = (decimal)s.COSTO_SERVICIO
            }).ToList();
        }
    }
}
