using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EConciliacionBancarium
    {
        public int Id { get; set; }
        public int Idcaja { get; set; }
        public int Idresponsable { get; set; }
        public int Idmoneda { get; set; }
        public int IdtipoCp { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public string NumCp { get; set; } = null!;
        public decimal SaldoBanco { get; set; }
        public decimal SaldoEmpresa { get; set; }
        public int IdconfiguracionConciliacionBancaria { get; set; }
    }
}
