using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VWapConsultum
    {
        public int? Cobertura { get; set; }
        public int? NumeroPedidos { get; set; }
        public decimal? TotalPedidos { get; set; }
        public bool Credito { get; set; }
        public int Idvendedor { get; set; }
        public int? CarteraDiaria { get; set; }
        public int? CarteraTotal { get; set; }
        public DateTime Fecha { get; set; }
        public int Idsupervisor { get; set; }
        public string? CodigoVendedor { get; set; }
        public string? NombreVendedor { get; set; }
        public string? MinHora { get; set; }
        public string? MaxHora { get; set; }
    }
}
