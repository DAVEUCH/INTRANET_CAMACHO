using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TmpConfiguracionCierreApertura
    {
        public int Pkid { get; set; }
        public int IdlibroAuxiliar { get; set; }
        public int Idresponsable { get; set; }
        public int IdtipoCp { get; set; }
        public int IdcuentaContable { get; set; }
        public int Idauxiliar { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Glosa { get; set; } = null!;
        public bool Resumido { get; set; }
        public bool Cierre { get; set; }
    }
}
