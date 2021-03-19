using System;
using System.Collections.Generic;
using System.Text;

namespace EctoTect.Core.Entities
{
    public class Ciudad
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
