using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EOrdenAnulacion
    {
        public int Id { get; set; }
        public string NumCp { get; set; } = null!;
        public int IdconsolidadoCarga { get; set; }
        public int IdcpVenta { get; set; }
        public int Idresponsable { get; set; }
        public DateTime Fecha { get; set; }
        public bool AnulacionTotal { get; set; }
        public int IdmotivoAnulacion { get; set; }
        public string EstadoEjecucion { get; set; } = null!;
        public int Idcliente { get; set; }
        public int IdtipoOrdenAnulacion { get; set; }
        public int Idalmacen { get; set; }
        public int? IdnotaCredito { get; set; }
        public decimal Total { get; set; }
    }
}
