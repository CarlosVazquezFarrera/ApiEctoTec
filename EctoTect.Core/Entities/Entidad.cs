namespace EctoTect.Core.Entities
{
    using System.Collections.Generic;

    public class Entidad
    {
        public Entidad()
        {
            Ciudad = new HashSet<Ciudad>();
        }

        public int Id { get; set; }
        public int IdPais { get; set; }
        public string Nombre { get; set; }

        public virtual Pais IdPaisNavigation { get; set; }
        public virtual ICollection<Ciudad> Ciudad { get; set; }
    }
}
