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
    
    public partial class DETALLE_SERVICIO_EXTRA
    {
        public decimal ID_DETALLE_SERVICIO_EXTRA { get; set; }
        public decimal SERVICIO_ID_SERVICIO { get; set; }
        public decimal SERVICIO_CONTRATO_ID_CONTRATO { get; set; }
        public string SERVICIO_CONTRATO_PROVEEDOR_ID_PROVEEDOR { get; set; }
        public decimal RESERVA_ID_RESERVA { get; set; }
    
        public virtual RESERVA RESERVA { get; set; }
        public virtual SERVICIO SERVICIO { get; set; }
    }
}
