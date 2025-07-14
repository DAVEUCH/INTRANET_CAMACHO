using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemTurnoCaja
    {
        public int ItemsId { get; set; }
        public int IdturnoCaja { get; set; }
        public int ItemsIdcp { get; set; }
        public string ItemsTipoCp { get; set; } = null!;
        public string ItemsNumCp { get; set; } = null!;
        public string ItemsPersonaNombre { get; set; } = null!;
        public decimal ItemsTotalSoles { get; set; }
        public decimal ItemsTotalDolares { get; set; }
    }
}
