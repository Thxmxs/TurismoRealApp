using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoRealWeb.DALC;
namespace TurismoRealWeb.Negocio
{
    public class Departamento
    {
        public decimal idDepartamento { get; set; }
        public string direccion { get; set; }
        public decimal costoDepartamento { get; set; }
        public string estadoDepartamento { get; set; }
        public string descripcionEstadoDepartamento { get; set; }
        public string orientacionDepartamento { get; set; }
        public string estacionamiento { get; set; }
        public decimal numHabitaciones { get; set; }
        public decimal numBaño { get; set; }
        public decimal numEstacionamiento { get; set; }
        public decimal comunaIdComuna { get; set; }
        public decimal comunaProvinciaIdProvincia { get; set; }
        public decimal comunaProvinciaRegionIdRegion { get; set; }

        public Comuna comuna { get; set; }
        public Provincia provincia { get; set; }
        public Region region { get; set; }


        TurismoRealEntities db = new TurismoRealEntities();


        public List<Departamento> ReadAll()
        {
            return db.DEPARTAMENTO.Select(d => new Departamento()
            {
                idDepartamento = d.ID_DEPARTAMENTO,
                direccion = d.DIRECCION,
                costoDepartamento = (decimal)d.COSTO_DEPARTAMENTO,
                estadoDepartamento = d.ESTADO_DEPARTAMENTO,
                descripcionEstadoDepartamento = d.DESCRIPCION_ESTADO_DEPARTAMENTO,
                orientacionDepartamento = d.ORIENTACION_DEPARTAMENTO,
                estacionamiento = d.ESTACIONAMIENTO,
                numHabitaciones = (decimal)d.NUM_HABITACIONES,
                numBaño = (decimal)d.NUM_BAÑO,
                numEstacionamiento = (decimal)d.NUM_ESTACIONAMIENTO,
                comunaIdComuna = (decimal)d.COMUNA_ID_COMUNA,
                comunaProvinciaIdProvincia = (decimal)d.COMUNA_PROVINCIA_ID_PROVINCIA,
                comunaProvinciaRegionIdRegion = (decimal)d.COMUNA_PROVINCIA_REGION_ID_REGION,
                comuna = new Comuna()
                {
                    nombreComuna = d.COMUNA.NOMBRE_COMUNA,
                },
                provincia = new Provincia()
                {
                    nombreProvincia = d.COMUNA.PROVINCIA.NOMBRE_PROVINCIA
                },
                
                region = new Region()
                {
                    nombreRegion = d.COMUNA.PROVINCIA.REGION.NOMBRE_REGION
                }
            }).ToList();

        }

    }
}

