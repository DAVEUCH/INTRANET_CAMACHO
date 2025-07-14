using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EVoucherContableCp
    {
        public int Id { get; set; }
        public int Idcp { get; set; }
        public int Idperiodo { get; set; }
        public int Idsucursal { get; set; }
        public int Idresponsable { get; set; }
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string TipoOperacion { get; set; } = null!;
        public decimal Cuadre { get; set; }
        public int IdtipoCp { get; set; }
        public DateTime FechaTipoCambio { get; set; }
        public decimal TipoCambioFecha { get; set; }
        public bool AjusteDiferenciaTipoCambio { get; set; }
        public string IdtipoCpOrigen { get; set; } = null!;
        public string ClavePeriodoCierre { get; set; } = null!;
    }
}
