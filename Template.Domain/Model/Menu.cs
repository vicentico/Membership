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
    
    public partial class Menu
    {
        public Menu()
        {
            this.Menu1 = new HashSet<Menu>();
            this.RolMenu = new HashSet<RolMenu>();
        }
    
        public int Id { get; set; }
        public Nullable<int> Menu_Id { get; set; }
        public string Url { get; set; }
        public string Icono { get; set; }
        public string Texto { get; set; }
        public string Ayuda { get; set; }
        public Nullable<int> Orden { get; set; }
        public bool Activo { get; set; }
    
        public virtual ICollection<Menu> Menu1 { get; set; }
        public virtual Menu Menu2 { get; set; }
        public virtual ICollection<RolMenu> RolMenu { get; set; }
    }
}
