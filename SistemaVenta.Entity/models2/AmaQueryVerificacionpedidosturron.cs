using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class AmaQueryVerificacionpedidosturron
    {
        public DateTime Fecha { get; set; }
        public int Idproducto { get; set; }
        public int CantidadBase { get; set; }
        public string? EstadoEntrega { get; set; }
        public string? EstadoFacturacion { get; set; }
        public int Pkid { get; set; }
        public int Idcp { get; set; }
        public int Idalmacen { get; set; }
        public int MovStockContable { get; set; }
        public int MovStockFisico { get; set; }
        public int MovStockPorEntregar { get; set; }
        public int MovStockPorRecibir { get; set; }
        public bool CostoPromedio { get; set; }
        public int CostoPromedioCantidad { get; set; }
        public int CostoPromedioMonto { get; set; }
        public bool CostoUltimaCompra { get; set; }
        public bool CostoReferencia { get; set; }
        public bool CostoParalelo { get; set; }
        public string TipoCpInventario { get; set; } = null!;
        public decimal Peso { get; set; }
        public decimal Volumen { get; set; }
        public bool SobregirarStockDisponible { get; set; }
        public int IdtipoOperacion { get; set; }
        public bool SugerenciaCompra { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public bool Bonificacion { get; set; }
        public decimal Cantidad { get; set; }
    }
}
