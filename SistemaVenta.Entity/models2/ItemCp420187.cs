using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemCp420187
    {
        public int IditemCp { get; set; }
        public int Pkid { get; set; }
        public int Idcp { get; set; }
        public decimal Cantidad { get; set; }
        public string Descripcion { get; set; } = null!;
        public int? TipoItemCp { get; set; }
        public decimal Total { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal PorcentajeImpto { get; set; }
        public bool Inafecto { get; set; }
        public bool Bonificacion { get; set; }
        public decimal ValorAfecto { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ValorDescuento { get; set; }
        public decimal ValorInafecto { get; set; }
        public bool BonificacionManual { get; set; }
        public decimal DescuentoPieCp { get; set; }
        public decimal RecargoPieCp { get; set; }
        public decimal PorcentajePercepcion { get; set; }
        public decimal MontoPercepcion { get; set; }
        public decimal PorcentajeDetraccion { get; set; }
        public decimal MontoDetraccion { get; set; }
        public decimal ValorReferencialDetraccion { get; set; }
        public bool EsAgrupacion { get; set; }
        public bool EsItemAgrupacion { get; set; }
        public int Idagrupacion { get; set; }
        public bool PorcentajeAgrupacion { get; set; }
        public int Idalmacen { get; set; }
        public int Idproducto { get; set; }
        public int Idunidad { get; set; }
    }
}
