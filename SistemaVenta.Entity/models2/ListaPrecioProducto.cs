using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ListaPrecioProducto
    {
        public string Codigo { get; set; } = null!;
        public string Resumida { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal Descuentoa { get; set; }
        public decimal Descuentob { get; set; }
        public decimal? Descuentoc { get; set; }
        public decimal? Descuentod { get; set; }
        public decimal Precio { get; set; }
        public decimal Preciototal { get; set; }
        public int? Cantidad { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Motor { get; set; }
        public string? Litros { get; set; }
        public string? Ano { get; set; }
        public string? Cilindros { get; set; }
        public string? Voltios { get; set; }
        public string? Medidas { get; set; }
        public string? Tipoencendido { get; set; }
        public string? Lado { get; set; }
        public string? CodigoInterno { get; set; }
        public string Sistema { get; set; } = null!;
        public string Codigomarca { get; set; } = null!;
        public int Idmarca { get; set; }
        public string Codsistema { get; set; } = null!;
        public string Clase { get; set; } = null!;
        public string Codclase { get; set; } = null!;
    }
}
