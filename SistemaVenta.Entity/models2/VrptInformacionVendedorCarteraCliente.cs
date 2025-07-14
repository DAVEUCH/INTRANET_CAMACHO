using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptInformacionVendedorCarteraCliente
    {
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public string? VendedorGrupoVentaNombre { get; set; }
        public string? VendedorFuerzaVentaCodigo { get; set; }
        public string? VendedorFuerzaVentaNombre { get; set; }
        public string? VendedorGrupoVentaCodigo { get; set; }
        public string VendedorZonaCodigo { get; set; } = null!;
        public string VendedorZonaDescripcion { get; set; } = null!;
        public string ClienteCodigo { get; set; } = null!;
        public string ClienteNombre { get; set; } = null!;
        public string? ClienteDocIdentidad { get; set; }
        public string ClienteTipoDescripcion { get; set; } = null!;
        public string ClienteCategoriaNombre { get; set; } = null!;
        public string ClienteDireccion { get; set; } = null!;
        public bool ClienteActivo { get; set; }
        public int VendedorId { get; set; }
        public int VendedorZonaId { get; set; }
        public string Distrito { get; set; } = null!;
        public string Provincia { get; set; } = null!;
        public string? ClienteCodigoAnterior { get; set; }
    }
}
