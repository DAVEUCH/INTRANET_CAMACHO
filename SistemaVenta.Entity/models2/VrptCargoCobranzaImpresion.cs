using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptCargoCobranzaImpresion
    {
        public int CargoCobranzaId { get; set; }
        public string CargoCobranzaTipoCodigo { get; set; } = null!;
        public string CargoCobranzaTipoAbrev { get; set; } = null!;
        public string CargoCobranzaTipoAbreviacion { get; set; } = null!;
        public string CargoCobranzaNumero { get; set; } = null!;
        public decimal CargoCobranzaTotal { get; set; }
        public bool CargoCobranzaCerrado { get; set; }
        public DateTime CargoCobranzaFecha { get; set; }
        public string OrigenDestinoCodigo { get; set; } = null!;
        public string OrigenDestinoNombre { get; set; } = null!;
        public bool OrigenDestinoActivo { get; set; }
        public string TipoClienteCodigo { get; set; } = null!;
        public string TipoClienteDescripcion { get; set; } = null!;
        public string CategoriaDescripcion { get; set; } = null!;
        public decimal LineaDeCredito { get; set; }
        public decimal LineaDeCreditoBalanceSoles { get; set; }
        public decimal LineaDeCreditoBalanceDolares { get; set; }
        public decimal CpCobrarPagarTotal { get; set; }
        public decimal CpCobrarPagarSaldo { get; set; }
        public bool CpCobrarPagarCredito { get; set; }
        public DateTime CpCobrarPagarFechaVto { get; set; }
        public string? CpModalidadCreditoCodigo { get; set; }
        public string? CpModalidadCreditoDescripcion { get; set; }
        public int? CpDiasDeCredito { get; set; }
        public int IdtipoCliente { get; set; }
        public int Idmoneda { get; set; }
        public int IdorigenDestino { get; set; }
        public int IdmodalidadCredito { get; set; }
        public int IdtipoMedioDePago { get; set; }
        public int IddireccionPrincipal { get; set; }
        public int IdtipoCpCargoCobranza { get; set; }
        public int Idempleado { get; set; }
        public int IdplanillaCobranza { get; set; }
        public int IdcategoriaCliente { get; set; }
        public int IdclienteCorporativo { get; set; }
        public bool Corporativo { get; set; }
    }
}
