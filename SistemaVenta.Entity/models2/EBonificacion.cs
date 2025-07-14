using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EBonificacion
    {
        public int Id { get; set; }
        public int Idbonificacion { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string TipoBonificacion { get; set; } = null!;
        public decimal Desde { get; set; }
        public decimal Hasta { get; set; }
        public bool PorMonto { get; set; }
        public bool Activo { get; set; }
        public bool ActivoNotaCredito { get; set; }
        public bool EsGrupo { get; set; }
        public string CondicionGrupo { get; set; } = null!;
        public decimal CondicionDeRango { get; set; }
        public bool TieneVigencia { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public int MarcaAuspiciadorPkid { get; set; }
        public int MarcaAuspiciadorIdmarca { get; set; }
        public int MarcaAuspiciadorIdbonificacion { get; set; }
        public decimal MarcaAuspiciadorDesde { get; set; }
        public decimal MarcaAuspiciadorHasta { get; set; }
        public decimal MarcaAuspiciadorCondicionDeRango { get; set; }
        public int ProveedorAuspiciadorPkid { get; set; }
        public int ProveedorAuspiciadorIdproveedor { get; set; }
        public int ProveedorAuspiciadorIdbonificacion { get; set; }
        public decimal ProveedorAuspiciadorDesde { get; set; }
        public decimal ProveedorAuspiciadorHasta { get; set; }
        public decimal ProveedorAuspiciadorCondicionDeRango { get; set; }
    }
}
