using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EctoTec.Infrastrucure.Data
{
    public partial class Ciudad
    {
        public Ciudad()
        {
            Usuario = new HashSet<Usuario>();
        }

        public int Id { get; set; }
        public int IdEntidd { get; set; }
        public string Nombre { get; set; }

        public virtual Entidad IdEntiddNavigation { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
