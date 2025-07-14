using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvPedidoyDireccionUbigeo
    {
        public int Pkidpedido { get; set; }
        public string NumeroPedido { get; set; } = null!;
        public DateTime FechaPedido { get; set; }
        public bool PedidoAnulado { get; set; }
        public int Idcliente { get; set; }
        public string DirecCliente { get; set; } = null!;
        public int? IddirecZonaCliente { get; set; }
        public int? IdditritoClie { get; set; }
        public int? IdprovinciaClie { get; set; }
        public int? IddepartClie { get; set; }
        public string? DepartamentoClie { get; set; }
        public string? ProvinciaClie { get; set; }
        public string? DistritoClie { get; set; }
        public int? IdclienteEntrega { get; set; }
        public string DireccionEntrega { get; set; } = null!;
        public int? IddirecZonaEntrega { get; set; }
        public int EsAgenciatransporte { get; set; }
        public string? NombreAgenTransp { get; set; }
        public int? IdditritoEntrega { get; set; }
        public int? IdprovinciaEntrega { get; set; }
        public int? IddepartEntrega { get; set; }
        public string? DepartamentoEntrega { get; set; }
        public string? ProvinciaEntrega { get; set; }
        public string? DistritoEntrega { get; set; }
        public bool Anulado { get; set; }
    }
}
