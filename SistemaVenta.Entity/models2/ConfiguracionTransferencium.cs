using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ConfiguracionTransferencium
    {
        public ConfiguracionTransferencium()
        {
            ItemConfiguracionTransferencia = new HashSet<ItemConfiguracionTransferencium>();
        }

        public int Pkid { get; set; }
        public int IdcptoOperacion { get; set; }
        public int IdtipoCp { get; set; }
        public int Idresponsable { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool RestringirConfiguracion { get; set; }

        public virtual CptoOperacion IdcptoOperacionNavigation { get; set; } = null!;
        public virtual Persona IdresponsableNavigation { get; set; } = null!;
        public virtual TipoCp IdtipoCpNavigation { get; set; } = null!;
        public virtual ICollection<ItemConfiguracionTransferencium> ItemConfiguracionTransferencia { get; set; }
    }
}
