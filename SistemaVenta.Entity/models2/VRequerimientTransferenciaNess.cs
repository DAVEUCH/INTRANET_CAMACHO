using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VRequerimientTransferenciaNess
    {
        public int Id { get; set; }
        public string TipoCp { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Anula { get; set; } = null!;
        public string Sucursal { get; set; } = null!;
        public string EstadoEntrega { get; set; } = null!;
        public string EstadoRecepcion { get; set; } = null!;
        public string Aentrada { get; set; } = null!;
        public string Asalida { get; set; } = null!;
        public string Responsable { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string? CodigoInterno { get; set; }
        public string Clase { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public string? Unidad { get; set; }
    }
}
