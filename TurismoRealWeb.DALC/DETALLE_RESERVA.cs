//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TurismoRealWeb.DALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class DETALLE_RESERVA
    {
        public decimal ID_DETALLE_RESERVA { get; set; }
        public decimal RESERVA_ID_RESERVA { get; set; }
        public decimal DEPARTAMENTO_ID_DEPARTAMENTO { get; set; }
    
        public virtual DEPARTAMENTO DEPARTAMENTO { get; set; }
        public virtual RESERVA RESERVA { get; set; }
    }
}
