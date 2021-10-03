using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoRealWeb.DALC;
using TurismoRealWeb.Negocio;

namespace TurismoRealWeb.Negocio
{
    public class DetalleReserva
    {
        public decimal  idDetalleReserva { get; set; }
        public decimal  reservaIdReserva{ get; set; }
        public decimal departamento_id_Departamento { get; set; }

        public Reserva reserva { get; set; }
        public Departamento departamento { get; set; }


        TurismoRealEntities db = new TurismoRealEntities();


    }
    
}

