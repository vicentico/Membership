//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Template.Domain.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Email
    {
        public int Id { get; set; }
        public string NombreRemitente { get; set; }
        public string DireccionRemitente { get; set; }
        public string DireccionesCC { get; set; }
        public string DireccionesCCO { get; set; }
        public string Asunto { get; set; }
        public string Cuerpo { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
    }
}
