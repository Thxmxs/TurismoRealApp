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
    
    public partial class IMPUESTO
    {
        public IMPUESTO()
        {
            this.DETALLE_IMPUESTO = new HashSet<DETALLE_IMPUESTO>();
        }
    
        public decimal ID_IMPUESTO { get; set; }
        public Nullable<decimal> MONTO_CONTRIBUCION { get; set; }
        public Nullable<decimal> MONTO_DIVIDENDO { get; set; }
    
        public virtual ICollection<DETALLE_IMPUESTO> DETALLE_IMPUESTO { get; set; }
    }
}