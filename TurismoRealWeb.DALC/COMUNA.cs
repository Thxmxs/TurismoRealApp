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
    
    public partial class COMUNA
    {
        public COMUNA()
        {
            this.DEPARTAMENTO = new HashSet<DEPARTAMENTO>();
        }
    
        public decimal ID_COMUNA { get; set; }
        public string NOMBRE_COMUNA { get; set; }
        public decimal PROVINCIA_ID_PROVINCIA { get; set; }
        public decimal PROVINCIA_REGION_ID_REGION { get; set; }
    
        public virtual PROVINCIA PROVINCIA { get; set; }
        public virtual ICollection<DEPARTAMENTO> DEPARTAMENTO { get; set; }
    }
}
