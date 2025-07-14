using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CanjeLetra
    {
        public CanjeLetra()
        {
            ItemCanjeLetras = new HashSet<ItemCanjeLetra>();
        }

        public int Pkid { get; set; }
        public int IdmodalidadCredito { get; set; }
        public int Idbanco { get; set; }
        public int IdcptoOperacionLetra { get; set; }
        public int IdtipoLetra { get; set; }
        public int Idestado { get; set; }
        public string Direccion { get; set; } = null!;
        public decimal TotalCanjear { get; set; }

        public virtual CptoOperacion IdcptoOperacionLetraNavigation { get; set; } = null!;
        public virtual Estado IdestadoNavigation { get; set; } = null!;
        public virtual TipoCp IdtipoLetraNavigation { get; set; } = null!;
        public virtual Cp Pk { get; set; } = null!;
        public virtual ICollection<ItemCanjeLetra> ItemCanjeLetras { get; set; }
    }
}
