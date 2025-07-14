using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VDefinicionAsientosTipo
    {
        public string Comprobante { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Glosa { get; set; } = null!;
        public int CargoAbonoId { get; set; }
        public string CuentaCuenta { get; set; } = null!;
        public string CuentaDescripcion { get; set; } = null!;
        public int? Nivel { get; set; }
        public string Cargo { get; set; } = null!;
        public string Abono { get; set; } = null!;
        public string DependiendoDe { get; set; } = null!;
        public string CondicionadoA { get; set; } = null!;
        public string CondicionOperador { get; set; } = null!;
        public string CondicionValor { get; set; } = null!;
        public string CondicionEnlace { get; set; } = null!;
        public bool Activo { get; set; }
    }
}
