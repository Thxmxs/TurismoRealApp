using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoRealWeb.DALC;
namespace TurismoRealWeb.Negocio
{
    public class Contrato
    {
        public decimal idContrato { get; set; }
        public DateTime fechaInicioContrato { get; set; }
        public DateTime fechaTerminoContrato { get; set; }
        public decimal proveedorIdProveedor { get; set; }

        public PROVEEDOR proveedor { get; set; }
    }
}
