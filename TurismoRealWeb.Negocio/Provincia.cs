using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoRealWeb.DALC;
namespace TurismoRealWeb.Negocio
{
    public class Provincia
    {
        public decimal idProvincia { get; set; }
        public String nombreProvincia { get; set; }
        public decimal RegionIdRegion { get; set; }

        public Region region { get; set; }
    }
}
