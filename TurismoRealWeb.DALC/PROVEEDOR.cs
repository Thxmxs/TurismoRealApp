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
    
    public partial class PROVEEDOR
    {
        public PROVEEDOR()
        {
            this.CONTRATO = new HashSet<CONTRATO>();
        }
    
        public string ID_PROVEEDOR { get; set; }
        public string NOMBRE_PROVEEDOR { get; set; }
    
        public virtual ICollection<CONTRATO> CONTRATO { get; set; }
    }
}
