using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemConciliacionBancarium
    {
        public int ItemsId { get; set; }
        public int IdconciliacionBancaria { get; set; }
        public int ItemsIdmoneda { get; set; }
        public int ItemsIdtipoMedioDePago { get; set; }
        public int ItemsIdmedioDePago { get; set; }
        public int ItemsIdbanco { get; set; }
        public int ItemsIdtarjetaCredito { get; set; }
        public int ItemsIdcuentaContable { get; set; }
        public DateTime ItemsFechaEmpresa { get; set; }
        public DateTime ItemsFechaBanco { get; set; }
        public DateTime ItemsFechaOperacion { get; set; }
        public string ItemsDescripcion { get; set; } = null!;
        public decimal ItemsImporteEmpresa { get; set; }
        public decimal ItemsImporteBanco { get; set; }
        public bool ItemsEnBanco { get; set; }
        public bool ItemsEnEmpresa { get; set; }
        public bool ItemsConciliado { get; set; }
        public int ItemsCargoAbono { get; set; }
        public string ItemsNumero { get; set; } = null!;
        public int ItemsIdcentroDeCosto { get; set; }
        public string ItemsObservacion { get; set; } = null!;
        public string? ItemsIdtipoCpGenerado { get; set; }
        public int? ItemsIdcpGenerado { get; set; }
    }
}
