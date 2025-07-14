using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EUnidad
    {
        public int UnidadesId { get; set; }
        public string UnidadesDescripcion { get; set; } = null!;
        public string UnidadesAbreviacion { get; set; } = null!;
        public bool UnidadesBase { get; set; }
        public int UnidadesFactor { get; set; }
        public bool UnidadesActivo { get; set; }
        public int? IdproductoServicio { get; set; }
        public decimal UnidadesPeso { get; set; }
        public decimal UnidadesVolumen { get; set; }
        public bool UnidadesReferencia { get; set; }
        public bool UnidadesCompra { get; set; }
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Abreviacion { get; set; } = null!;
        public bool Base { get; set; }
        public int Factor { get; set; }
        public bool Activo { get; set; }
        public decimal Peso { get; set; }
        public decimal Volumen { get; set; }
        public bool Referencia { get; set; }
        public bool Compra { get; set; }
        public string UnidadesCodigo { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public decimal? FactorUnidadMedida { get; set; }
        public decimal? UnidadesFactorUnidadMedida { get; set; }
        public decimal Largo { get; set; }
        public decimal Ancho { get; set; }
        public decimal Alto { get; set; }
        public decimal UnidadesLargo { get; set; }
        public decimal UnidadesAncho { get; set; }
        public decimal UnidadesAlto { get; set; }
        public bool? Inventario { get; set; }
        public bool? UnidadesInventario { get; set; }
    }
}
