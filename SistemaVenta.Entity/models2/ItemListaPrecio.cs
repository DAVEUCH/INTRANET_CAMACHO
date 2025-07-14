using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemListaPrecio
    {
        public int Pkid { get; set; }
        public int IdlistaPrecios { get; set; }
        public int Idproducto { get; set; }
        public bool Bonificacion { get; set; }
        public bool Desactivado { get; set; }
        public bool TieneDescuentoPorVale { get; set; }
        public decimal PorcentajeDescuentoPorVale { get; set; }
        public bool DescuentoVariable { get; set; }
        public bool ItemModificado { get; set; }
        public bool PagoEfectivo { get; set; }
        public bool BonificacionManual { get; set; }
        public bool GestionaRecargos { get; set; }
        public bool? Credito { get; set; }
        public bool? Contado { get; set; }

        public virtual ListaPrecio IdlistaPreciosNavigation { get; set; } = null!;
        public virtual ProductoServicio IdproductoNavigation { get; set; } = null!;
    }
}
