using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class RptListaProveedoresLineaCredUtil
    {
        public int ProveedorId { get; set; }
        public string ProveedorCodigo { get; set; } = null!;
        public string ProveedorNombre { get; set; } = null!;
        public string ProveedorDireccion { get; set; } = null!;
        public string ProveedorEmail { get; set; } = null!;
        public string ProveedorDocIdentidad { get; set; } = null!;
        public string ProveedorTelefono { get; set; } = null!;
        public string ProveedorActivo { get; set; } = null!;
        public decimal LineaCreditoMonto { get; set; }
        public int LineaCreditoDiasCredito { get; set; }
        public string LineaCreditoSimbolo { get; set; } = null!;
        public bool LineaCreditoMonedaBase { get; set; }
        public decimal MonedaTipoCambioVenta { get; set; }
        public decimal? LineaCreditoUtilizada { get; set; }
        public bool Extranjero { get; set; }
    }
}
