namespace EctoTect.Core.Entities
{
    using System.Collections.Generic;
    public class Pais
    {
        public Pais()
        {
            Entidad = new HashSet<Entidad>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Entidad> Entidad { get; set; }
    }
}
