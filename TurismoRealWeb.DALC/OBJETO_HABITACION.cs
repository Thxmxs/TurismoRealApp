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
    
    public partial class OBJETO_HABITACION
    {
        public OBJETO_HABITACION()
        {
            this.CHECKLIST_ESTADO_INVENTARIO = new HashSet<CHECKLIST_ESTADO_INVENTARIO>();
            this.DETALLE_INVENTARIO = new HashSet<DETALLE_INVENTARIO>();
        }
    
        public decimal ID_OBJETO_HABITACION { get; set; }
        public string NOMBRE_OBJETO { get; set; }
        public Nullable<decimal> integer { get; set; }
        public string CATEGORIA_OBJETO { get; set; }
    
        public virtual ICollection<CHECKLIST_ESTADO_INVENTARIO> CHECKLIST_ESTADO_INVENTARIO { get; set; }
        public virtual ICollection<DETALLE_INVENTARIO> DETALLE_INVENTARIO { get; set; }
    }
}
