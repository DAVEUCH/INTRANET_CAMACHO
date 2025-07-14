using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvGcPedidosShowConPlazo
    {
        public int Id { get; set; }
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int Idpersona { get; set; }
        public string? PersonaNombre { get; set; }
        public string? ZonaRep { get; set; }
        public string? ModalidadCredito { get; set; }
        public string Registraplazos { get; set; } = null!;
        public string EstadoAprobacion { get; set; } = null!;
        public string EstadoFacturacion { get; set; } = null!;
        public string Anulados { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public decimal Total { get; set; }
        public int Idvende { get; set; }
        public string VendedorNombre { get; set; } = null!;
    }
}
