using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptePreparacionConsolidadoRechazo
    {
        public string Abreviacion { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string NumCp { get; set; } = null!;
        public string VehiculoCodigo { get; set; } = null!;
        public string VehiculoNombre { get; set; } = null!;
        public string ChoferCodigo { get; set; } = null!;
        public string ChoferNombre { get; set; } = null!;
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public string PersonaCodigo { get; set; } = null!;
        public string PersonaNombre { get; set; } = null!;
        public string PersonaDireccion { get; set; } = null!;
        public string PersonaDireccionEntrega { get; set; } = null!;
        public string DocumentoCargaNumCp { get; set; } = null!;
        public DateTime DocumentoCargaFecha { get; set; }
        public string DocumentoCargaTipo { get; set; } = null!;
        public bool DocumentoCargaCredito { get; set; }
        public decimal? DocumentoCargaMontoSoles { get; set; }
        public decimal? DocumentoCargaMontoDolares { get; set; }
        public string? DocumentoCargaZonaCodigo { get; set; }
        public string? DocumentoCargaZonaDescripcion { get; set; }
        public string ProductoCodigo { get; set; } = null!;
        public string ProductoDescripcion { get; set; } = null!;
        public int ProductoCantidad { get; set; }
        public string ProductoUbabreviacion { get; set; } = null!;
        public string ProductoUrabreviacion { get; set; } = null!;
        public int ProductoUrfactor { get; set; }
        public decimal? ProductoPeso { get; set; }
        public decimal? ProductoVolumen { get; set; }
        public int Idsucursal { get; set; }
        public int Idvehiculo { get; set; }
        public int Pkid { get; set; }
    }
}
