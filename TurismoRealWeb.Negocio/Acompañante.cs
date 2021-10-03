using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoRealWeb.DALC;

namespace TurismoReal.Negocio
{
    public class Acompañante
    {

        public decimal idAcompañante { get; set; }
        public string nombreAcompañante { get; set; }
        public string apellidoAcompañante { get; set; }
        public string rangoEtario { get; set; }

        TurismoRealEntities db = new TurismoRealEntities();

        public List<Acompañante> ReadAll()
        {
            return this.db.ACOMPAÑANTE.Select(a => new Acompañante()
            {
                idAcompañante = a.ID_ACOMPAÑANTE,
                nombreAcompañante = a.NOMBRE_ACOMPAÑANTE,
                apellidoAcompañante = a.APELLIDO_ACOMPAÑANTE,
                rangoEtario = a.RANGO_ETARIO


            }).ToList();
        }
    }

}