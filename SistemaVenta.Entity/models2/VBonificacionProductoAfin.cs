using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VBonificacionProductoAfin
    {
        public int Pkid { get; set; }
        public int IdproductoObsequio { get; set; }
        public int IdunidadObsequio { get; set; }
        public int CantidadObsequio { get; set; }
        public int CantidadMaximaObsequio { get; set; }
        public int CantidadMaximaPorClienteObsequio { get; set; }
        public DateTime DesdeObsequio { get; set; }
        public DateTime HastaObsequio { get; set; }
        public int StockFisico { get; set; }
        public int TieneStockFisico { get; set; }
        public int Idproducto { get; set; }
        public int FactorUnidad { get; set; }
        public int Idunidad { get; set; }
        public int Idbonificacion { get; set; }
        public bool PorMonto { get; set; }
        public bool UnidadExclusiva { get; set; }
        public decimal Desde { get; set; }
        public decimal Hasta { get; set; }
        public bool Activo { get; set; }
        public bool ActivoNotaCredito { get; set; }
        public string CodigoAfinidad { get; set; } = null!;
        public decimal CondicionDeRango { get; set; }
        public string CondicionGrupo { get; set; } = null!;
        public bool EsGrupo { get; set; }
        public int? NumeroItems { get; set; }
        public bool TieneStockObsequio { get; set; }
        public decimal StockObsequio { get; set; }
        public bool TieneCantidadPorClienteObsequio { get; set; }
        public bool TieneVigencia { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public int IdjerarquiaBonificaciones { get; set; }
        public int Jerarquia { get; set; }
        public int IdcategoriaCliente { get; set; }
        public int IdtipoCliente { get; set; }
        public int Idsucursal { get; set; }
    }
}
