using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECptoOperacion
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int TipoItemCp { get; set; }
        public int IdtipoPersona { get; set; }
        public bool Activo { get; set; }
        public string IdtipoAsociado { get; set; } = null!;
        public string IdtipoOrigen { get; set; } = null!;
        public bool TieneCpInventario { get; set; }
        public bool TieneCpCaja { get; set; }
        public bool TieneCpCobrarPagar { get; set; }
        public bool TieneCpOrigen { get; set; }
        public bool Contabilizable { get; set; }
        public int IdtipoVoucher { get; set; }
        public string RutaAuxiliarRedondeo { get; set; } = null!;
        public int IdcuentaContableRedondeoCargo { get; set; }
        public bool TipoCambioEnComprobante { get; set; }
        public string RutaTipoCambio { get; set; } = null!;
        public int IdcuentaContableRedondeoAbono { get; set; }
        public bool ModificarFechaTipoCambio { get; set; }
    }
}
