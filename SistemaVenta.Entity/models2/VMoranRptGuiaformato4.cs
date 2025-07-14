using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMoranRptGuiaformato4
    {
        public string Puntopartida { get; set; } = null!;
        public string? ProveedorNombre { get; set; }
        public string PuntoLlegada { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public string ItemCodigo { get; set; } = null!;
        public string ItemDescripcion { get; set; } = null!;
        public string ItemUnidad { get; set; } = null!;
        public decimal ItemCantidad { get; set; }
        public decimal? Peso { get; set; }
        public decimal? Cajas { get; set; }
        public int IdComprobante { get; set; }
        public string Placa { get; set; } = null!;
        public string Chofer { get; set; } = null!;
        public string LicenciaConducir { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public string TransportistaNombre { get; set; } = null!;
        public string? TransportistaDocId { get; set; }
        public string? ProveedorDocId { get; set; }
        public string NumCp { get; set; } = null!;
        public int IdtipoCp { get; set; }
    }
}
