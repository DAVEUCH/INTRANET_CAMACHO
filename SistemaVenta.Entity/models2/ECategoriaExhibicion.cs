using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECategoriaExhibicion
    {
        public int Id { get; set; }
        public int Idcaracteristica { get; set; }
        public int Total { get; set; }
        public int IdtipoCaracteristica { get; set; }
        public int ItemsId { get; set; }
        public int ItemsIdcategoriaExhibicion { get; set; }
        public int ItemsIdalmacen { get; set; }
        public int ItemsCapacidadModelos { get; set; }
    }
}
