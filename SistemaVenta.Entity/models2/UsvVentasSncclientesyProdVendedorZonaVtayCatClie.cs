using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasSncclientesyProdVendedorZonaVtayCatClie
    {
        public string Sucursal { get; set; } = null!;
        public int Idvendedor { get; set; }
        public int Idpersona { get; set; }
        public DateTime FechaEmision { get; set; }
        public string Numcp { get; set; } = null!;
        public string? Vendedor { get; set; }
        public string? Cliente { get; set; }
        public string? CategoriaCliente { get; set; }
        public int? IdzonaVenta { get; set; }
        public string? ZonaVenta { get; set; }
        public int? Idproducto { get; set; }
        public int? Idmarca { get; set; }
        public int? Factor { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? ValorUnitario { get; set; }
        public decimal? CantidadBase { get; set; }
        public decimal? TotVtasdetSol { get; set; }
        public decimal? TotVtasdetDol { get; set; }
        public int Id { get; set; }
        public string? EstadoDevolucion { get; set; }
    }
}
