using System;

namespace EctoTect.Core.Entities
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }
        public DateTime Fecha { get; set; }
        public int IdCiudad { get; set; }

        public virtual Ciudad IdCiudadNavigation { get; set; }
    }
}
