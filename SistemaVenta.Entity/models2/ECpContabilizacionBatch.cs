using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECpContabilizacionBatch
    {
        public int Id { get; set; }
        public int IdtipoCp { get; set; }
        public int Idpersona { get; set; }
        public int Idmoneda { get; set; }
        public int IdcptoOperacion { get; set; }
        public int Idperiodo { get; set; }
        public int Idsucursal { get; set; }
        public string IdtipoPersona { get; set; } = null!;
        public int IdmotivoAnulacion { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime Hora { get; set; }
        public bool Impreso { get; set; }
        public string NumCp { get; set; } = null!;
        public string NumCpContable { get; set; } = null!;
        public string Observacion { get; set; } = null!;
        public string PersonaNombre { get; set; } = null!;
        public decimal Total { get; set; }
        public bool Anulado { get; set; }
        public bool Contabilizado { get; set; }
        public int IdvoucherContable { get; set; }
        public bool Preliminar { get; set; }
        public bool MonedaBase { get; set; }
        public string TipoCp { get; set; } = null!;
        public bool Tercero { get; set; }
        public string NumeroVerificacion { get; set; } = null!;
    }
}
