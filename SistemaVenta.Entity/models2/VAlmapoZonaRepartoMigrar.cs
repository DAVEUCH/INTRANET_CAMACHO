using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VAlmapoZonaRepartoMigrar
    {
        public int? IdzonaPadre { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public int Activo { get; set; }
        public int Nivel { get; set; }
        public int TieneSubZonas { get; set; }
        public string CodigoPostal { get; set; } = null!;
        public int Venta { get; set; }
        public int Reparto { get; set; }
        public int GestionaRecargos { get; set; }
        public int PorcentajeRecargo { get; set; }
    }
}
