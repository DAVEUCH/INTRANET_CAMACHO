using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EnvioLibroElectronico
    {
        public EnvioLibroElectronico()
        {
            ItemEnvioLibroElectronicos = new HashSet<ItemEnvioLibroElectronico>();
        }

        public int Pkid { get; set; }
        public int Idperiodo { get; set; }
        public string? Xmlitems { get; set; }

        public virtual Periodo IdperiodoNavigation { get; set; } = null!;
        public virtual ICollection<ItemEnvioLibroElectronico> ItemEnvioLibroElectronicos { get; set; }
    }
}
