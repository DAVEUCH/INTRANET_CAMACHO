using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class PropuestaRce
    {
        public string? Ruc { get; set; }
        public string? RazonSocialCia { get; set; }
        public string? Periodo { get; set; }
        public string? CarSunat { get; set; }
        public DateTime? FechaEmision { get; set; }
        public string? FechaVcto { get; set; }
        public string? TipoCp { get; set; }
        public string? SerieCdp { get; set; }
        public int? Año { get; set; }
        public int? TipoDocIdentidad { get; set; }
        public string? NroDocIdentidad { get; set; }
        public string? RazonSocialProv { get; set; }
        public decimal? BiGravadoDg { get; set; }
        public decimal? IgvIpmdg { get; set; }
        public decimal? BiGravadoDgng { get; set; }
        public decimal? IgvIpmdgng { get; set; }
        public decimal? BiGravadoDng { get; set; }
        public decimal? IgvIpmdng { get; set; }
        public decimal? ValorAdqNg { get; set; }
        public decimal? Isc { get; set; }
        public decimal? Icbper { get; set; }
        public decimal? OtrosTribCargos { get; set; }
        public decimal? TotalCp { get; set; }
        public string? Moneda { get; set; }
        public decimal? TipoCambio { get; set; }
        public DateTime? FechaEmiDocModi { get; set; }
        public string? TipoDocModi { get; set; }
        public string? SerieDocModi { get; set; }
        public string? CodDamDsi { get; set; }
        public string? NroDocModi { get; set; }
        public string? ClasifBssySss { get; set; }
        public string? IdproyectoOper { get; set; }
        public string? PorcPart { get; set; }
        public string? Imb { get; set; }
        public string? CarOrig { get; set; }
        public string? Detracción { get; set; }
        public string? TipoNota { get; set; }
        public string? EstComp { get; set; }
        public int? Incal { get; set; }
        public string? NroCpInicial { get; set; }
        public string? NroCpFinal { get; set; }
    }
}
