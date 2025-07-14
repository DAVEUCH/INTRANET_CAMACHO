using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvCpRelacionadoInfo
    {
        public string OrigenTipoCp { get; set; } = null!;
        public string OrigenNumCp { get; set; } = null!;
        public string? OrigenNombre { get; set; }
        public DateTime OrigenFecha { get; set; }
        public string OrigenMoneda { get; set; } = null!;
        public decimal OrigenTotal { get; set; }
        public bool OrigenAnulado { get; set; }
        public int Idcp { get; set; }
        public int IdcpRelacionado { get; set; }
        public string IdtipoCpRelacionado { get; set; } = null!;
        public string IdtipoCpDestino { get; set; } = null!;
        public int PkidDestinoTipoCp { get; set; }
        public string DestinoTipoCp { get; set; } = null!;
        public string DestinoNumCp { get; set; } = null!;
        public string? DestinoNombre { get; set; }
        public DateTime DestinoFecha { get; set; }
        public string DestinoMoneda { get; set; } = null!;
        public decimal DestinoTotal { get; set; }
        public bool DestinoAnulado { get; set; }
        public string Nombre { get; set; } = null!;
    }
}
