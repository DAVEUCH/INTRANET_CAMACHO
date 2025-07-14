using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class RptListaClientesLineaCredUtil
    {
        public int ClienteId { get; set; }
        public string ClienteCodigo { get; set; } = null!;
        public string ClienteNombre { get; set; } = null!;
        public string ClienteDireccion { get; set; } = null!;
        public string ClienteEmail { get; set; } = null!;
        public string ClienteDocIdentidad { get; set; } = null!;
        public string ClienteTelefono { get; set; } = null!;
        public string ClienteActivo { get; set; } = null!;
        public decimal LineaCreditoMonto { get; set; }
        public int LineaCreditoDiasCredito { get; set; }
        public string LineaCreditoSimbolo { get; set; } = null!;
        public bool LineaCreditoMonedaBase { get; set; }
        public decimal MonedaTipoCambioVenta { get; set; }
        public decimal? LineaCreditoUtilizada { get; set; }
    }
}
