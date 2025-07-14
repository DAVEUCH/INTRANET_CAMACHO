using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemListaPrecio
    {
        public int Id { get; set; }
        public int IdlistaPrecio { get; set; }
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
    }
}
