using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EZona
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string CodigoPostal { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public bool Activo { get; set; }
        public int IdfuerzaVentas { get; set; }
        public int Nivel { get; set; }
        public bool SubZonas { get; set; }
        public int IdzonaPadre { get; set; }
        public bool Venta { get; set; }
        public bool Reparto { get; set; }
        public bool GestionaRecargos { get; set; }
        public decimal PorcentajeRecargo { get; set; }
    }
}
