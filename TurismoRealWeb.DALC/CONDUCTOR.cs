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
    
    public partial class CONDUCTOR
    {
        public CONDUCTOR()
        {
            this.VEHICULO = new HashSet<VEHICULO>();
        }
    
        public string RUT_CONDUCTOR { get; set; }
        public string NOMBRE_CONDUCTOR { get; set; }
        public string APELLIDO_CONDUCTOR { get; set; }
        public decimal TRANSPORTE_ID_TRANSPORTE { get; set; }
    
        public virtual TRANSPORTE TRANSPORTE { get; set; }
        public virtual ICollection<VEHICULO> VEHICULO { get; set; }
    }
}
