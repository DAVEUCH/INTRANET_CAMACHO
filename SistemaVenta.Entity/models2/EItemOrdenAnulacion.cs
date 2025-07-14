using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemOrdenAnulacion
    {
        public int ItemsId { get; set; }
        public int ItemsIditemCp { get; set; }
        public int ItemsIdunidad { get; set; }
        public int IdordenAnulacion { get; set; }
        public decimal ItemsCantidad { get; set; }
        public int Id { get; set; }
        public int ItemsIdproducto { get; set; }
        public decimal ItemsPrecioUnitario { get; set; }
    }
}
