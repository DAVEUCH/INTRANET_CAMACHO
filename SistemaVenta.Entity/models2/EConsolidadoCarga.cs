using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EConsolidadoCarga
    {
        public int Id { get; set; }
        public int IdtipoCp { get; set; }
        public DateTime Fecha { get; set; }
        public bool Cerrado { get; set; }
        public bool RealizoTransferencia { get; set; }
        public decimal MontoDevolucionTotal { get; set; }
        public decimal MontoDevolucionParcial { get; set; }
        public decimal MontoNeto { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal Peso { get; set; }
        public decimal Volumen { get; set; }
        public string NumCp { get; set; } = null!;
        public int Idvehiculo { get; set; }
        public int Idchofer { get; set; }
        public int Idestado { get; set; }
    }
}
