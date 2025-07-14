using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Acumuladogeneral3
    {
        public int Pkid { get; set; }
        public string NumCp { get; set; } = null!;
        public string? Codigo { get; set; }
        public string? Codgv { get; set; }
        public string? Gv { get; set; }
        public decimal? ValorVentatotal { get; set; }
        public decimal? ValorVenta { get; set; }
        public string? Codfv { get; set; }
        public string? Fv { get; set; }
        public string Codprod { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? Codsup { get; set; }
        public string? Nombre { get; set; }
        public string? Codprov { get; set; }
        public string? Provnom { get; set; }
        public string Marca { get; set; } = null!;
        public string? Nomven { get; set; }
        public decimal? ValorAfecto { get; set; }
        public int? Inafecto { get; set; }
        public decimal? ValorUnitario { get; set; }
        public decimal? Total { get; set; }
        public decimal? Cantidad { get; set; }
        public string? Abreviacion { get; set; }
        public int? Factor { get; set; }
        public string? CodigoClase { get; set; }
        public string? Linea { get; set; }
        public decimal CostoUltimaCompraSoles { get; set; }
        public decimal CostoPromedioSoles { get; set; }
        public decimal CostoReferenciaSoles { get; set; }
        public decimal CostoParaleloSoles { get; set; }
        public string Codclie { get; set; } = null!;
        public string Codnom { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string? Memo { get; set; }
        public decimal? Cantidadunitaria { get; set; }
        public string? Observacion { get; set; }
        public int? Pkidproveedor { get; set; }
        public int? LineaId { get; set; }
        public int MarcaId { get; set; }
        public int Idproducto { get; set; }
        public int Pkidproducto { get; set; }
        public int Pkidcliente { get; set; }
        public string? Grupo { get; set; }
        public int Pkidcp { get; set; }
        public string? Caracteristica1 { get; set; }
    }
}
