using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VCtasporCobrar
    {
        public DateTime? Fecha { get; set; }
        public DateTime? FechaEmision { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string? NumCp { get; set; }
        public string? Abreviacion { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public int DiasCredito { get; set; }
        public string Direccion { get; set; } = null!;
        public string Distrito { get; set; } = null!;
        public string Provincia { get; set; } = null!;
        public string Departamento { get; set; } = null!;
        public string? VendedorCodigo { get; set; }
        public string? VendedorNombre { get; set; }
        public string Zona { get; set; } = null!;
        public string? CategoriaCliente { get; set; }
        public int? Pkid { get; set; }
        public int? Idpersona { get; set; }
        public int Idzona { get; set; }
        public int? Idvendedor { get; set; }
    }
}
