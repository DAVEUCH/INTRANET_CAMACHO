using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class PropuestaRvie
    {
        public string? Ruc { get; set; }
        public string? RazonSocialCia { get; set; }
        public string? Periodo { get; set; }
        public string? CarSunat { get; set; }
        public DateTime? FechaEmision { get; set; }
        public DateTime? FechaVcto { get; set; }
        public string? TipoCp { get; set; }
        public string? SerieCdp { get; set; }
        public int? TipoDocIdentidad { get; set; }
        public string? NroDocIdentidad { get; set; }
        public string? RazonSocialProv { get; set; }
        public decimal? ValorFacturadoExport { get; set; }
        public decimal? BiGravadoDg { get; set; }
        public decimal? DsctoBi { get; set; }
        public decimal? IgvIpmdg { get; set; }
        public decimal? DsctoIgvipm { get; set; }
        public decimal? MtoExonerado { get; set; }
        public decimal? MtoInafecto { get; set; }
        public decimal? Isc { get; set; }
        public decimal? BigravIvap { get; set; }
        public decimal? Ivap { get; set; }
        public decimal? Icbper { get; set; }
        public decimal? OtrosTribCargos { get; set; }
        public decimal? TotalCp { get; set; }
        public string? Moneda { get; set; }
        public decimal? TipoCambio { get; set; }
        public DateTime? FechaEmiDocModi { get; set; }
        public string? TipoDocModi { get; set; }
        public string? SerieDocModi { get; set; }
        public string? NroDocModi { get; set; }
        public string? IdproyectoOper { get; set; }
        public string? TipoNota { get; set; }
        public int? EstComp { get; set; }
        public decimal? ValorFobEmbarcado { get; set; }
        public decimal? ValorOpGratuitas { get; set; }
        public string? TipoOperac { get; set; }
        public string? DamCp { get; set; }
        public decimal? Clu { get; set; }
        public long? NroCpInicial { get; set; }
        public long? NroCpFinal { get; set; }
    }
}
