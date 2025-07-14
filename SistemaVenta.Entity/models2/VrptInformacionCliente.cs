using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptInformacionCliente
    {
        public string ClienteCodigo { get; set; } = null!;
        public string ClienteNombre { get; set; } = null!;
        public string? ClienteDocIdentidad { get; set; }
        public string ClienteEmail { get; set; } = null!;
        public string ClienteWeb { get; set; } = null!;
        public decimal ClienteLineaCredito { get; set; }
        public bool ClienteActivo { get; set; }
        public string ClienteDireccionDescripcion { get; set; } = null!;
        public string ClienteTipoDocIdentidadCodigo { get; set; } = null!;
        public string ClienteTipoDocIdentidadDescripcion { get; set; } = null!;
        public string ClienteTipoCodigo { get; set; } = null!;
        public string ClienteTipoDescripcion { get; set; } = null!;
        public string ClienteCategoriaNombre { get; set; } = null!;
        public string ClienteDistritoNombre { get; set; } = null!;
        public string ClienteProvinciaNombre { get; set; } = null!;
        public string ClienteDepartamentoNombre { get; set; } = null!;
        public string ClienteZonaCodigo { get; set; } = null!;
        public string ClienteZonaDescripcion { get; set; } = null!;
        public int ClienteDistritoId { get; set; }
        public int ClienteProvinciaId { get; set; }
        public int ClienteDepartamentoId { get; set; }
        public int ClienteCategoriaClienteId { get; set; }
        public int ClienteZonaId { get; set; }
        public int ClienteTipoId { get; set; }
        public int ClienteId { get; set; }
        public string ClienteCodigoAnterior { get; set; } = null!;
    }
}
