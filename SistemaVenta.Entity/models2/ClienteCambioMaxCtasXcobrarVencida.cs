using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ClienteCambioMaxCtasXcobrarVencida
    {
        public int Pkid { get; set; }
        public int IdcategoriaCliente { get; set; }
        public int Idmoneda { get; set; }
        public decimal LineaCredito { get; set; }
        public decimal BalanceSoles { get; set; }
        public decimal BalanceDolares { get; set; }
        public bool MejorPrecio { get; set; }
        public int IdmodalidadCredito { get; set; }
        public int DiasCredito { get; set; }
        public int IdtipoMedioDePago { get; set; }
        public bool CreditoContado { get; set; }
        public bool InhabilitadoBonificacion { get; set; }
        public bool InhabilitadoDescuento { get; set; }
        public int IdtipoCliente { get; set; }
        public bool LineaCreditoPorFuerzaVentas { get; set; }
        public int MaximoCuentasPorCobrarVencidas { get; set; }
        public string Campo1 { get; set; } = null!;
        public string Campo2 { get; set; } = null!;
        public string Campo3 { get; set; } = null!;
        public string Campo4 { get; set; } = null!;
        public int Idcaracteristica1 { get; set; }
        public int Idcaracteristica2 { get; set; }
        public int Idcaracteristica3 { get; set; }
        public int Idcaracteristica4 { get; set; }
        public bool Corporativo { get; set; }
        public int IdclienteCorporativo { get; set; }
        public bool LineaCreditoCorporativa { get; set; }
        public bool LineaCreditoActiva { get; set; }
    }
}
