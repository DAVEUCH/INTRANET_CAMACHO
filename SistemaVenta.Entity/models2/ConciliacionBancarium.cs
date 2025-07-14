using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ConciliacionBancarium
    {
        public ConciliacionBancarium()
        {
            ItemConciliacionBancaria = new HashSet<ItemConciliacionBancarium>();
            ItemConciliacionBancariaDocumentos = new HashSet<ItemConciliacionBancariaDocumento>();
        }

        public int Pkid { get; set; }
        public int Idcaja { get; set; }
        public int Idresponsable { get; set; }
        public int Idmoneda { get; set; }
        public int IdtipoCp { get; set; }
        public int IdconfiguracionConciliacionBancaria { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public string NumCp { get; set; } = null!;
        public decimal SaldoBanco { get; set; }
        public decimal SaldoEmpresa { get; set; }

        public virtual Caja IdcajaNavigation { get; set; } = null!;
        public virtual ConfiguracionConciliacionBancarium IdconfiguracionConciliacionBancariaNavigation { get; set; } = null!;
        public virtual Monedum IdmonedaNavigation { get; set; } = null!;
        public virtual Persona IdresponsableNavigation { get; set; } = null!;
        public virtual ICollection<ItemConciliacionBancarium> ItemConciliacionBancaria { get; set; }
        public virtual ICollection<ItemConciliacionBancariaDocumento> ItemConciliacionBancariaDocumentos { get; set; }
    }
}
