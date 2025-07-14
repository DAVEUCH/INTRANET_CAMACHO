using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EListaPrecio
    {
        public int Id { get; set; }
        public int Idmoneda { get; set; }
        public int IdcategoriaCliente { get; set; }
        public int Idcliente { get; set; }
        public string Descripcion { get; set; } = null!;
        public string CostoReferencia { get; set; } = null!;
        public string TipoEntidad { get; set; } = null!;
        public bool Activo { get; set; }
        public int DigitosRedondeo { get; set; }
        public bool DescuentoPorcentual { get; set; }
        public bool RestringirPorGrupoVentas { get; set; }
        public bool RestringirBonificaciones { get; set; }
        public bool RestringirAfinidad { get; set; }
        public bool MantenerUtilidadPorcentual { get; set; }
        public bool GestionaRecargosPorZona { get; set; }
        public decimal TipoCambioCompra { get; set; }
        public decimal TipoCambioVenta { get; set; }
        public decimal TipoCambio { get; set; }
        public string TipoMargen { get; set; } = null!;
        public bool? RestringirVentaCreditoContado { get; set; }
    }
}
