using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoRealWeb.DALC;
namespace TurismoRealWeb.Negocio
{
    public class Comuna
    {
        public decimal idComuna { get; set; }
        public String nombreComuna { get; set; }
        public decimal provinciaIdProvincia { get; set; }
        public decimal provinciaRegionIdRegion { get; set; }

        public Provincia Provincia { get; set; }
        public Region Region { get; set; }
    }
}
