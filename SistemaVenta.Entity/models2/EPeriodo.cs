using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EPeriodo
    {
        public int PeriodosId { get; set; }
        public int PeriodosIdejercicio { get; set; }
        public string PeriodosMes { get; set; } = null!;
        public bool PeriodosActivo { get; set; }
        public bool PeriodosCerrado { get; set; }
        public string PeriodosDescripcion { get; set; } = null!;
        public bool PeriodosApertura { get; set; }
        public bool PeriodosCierre { get; set; }
        public bool PeriodosCierreNivel { get; set; }
        public int PeriodosIdconfiguracion { get; set; }
        public int Id { get; set; }
        public int Idejercicio { get; set; }
        public string Mes { get; set; } = null!;
        public bool Activo { get; set; }
        public bool Cerrado { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool Apertura { get; set; }
        public bool Cierre { get; set; }
        public bool CierreNivel { get; set; }
        public int Idconfiguracion { get; set; }
    }
}
