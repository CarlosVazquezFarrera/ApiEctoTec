using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EctoTec.Infrastrucure.Data
{
    public partial class Usuario
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }
        public byte[] Fecha { get; set; }
        public int IdCiudad { get; set; }

        public virtual Ciudad IdCiudadNavigation { get; set; }
    }
}
