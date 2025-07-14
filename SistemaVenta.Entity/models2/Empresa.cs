using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Empresa
    {
        public Empresa()
        {
            UsuarioEmpresas = new HashSet<UsuarioEmpresa>();
        }

        public string Pkid { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string RazonSocial { get; set; } = null!;
        public string DocumentoIdentidad { get; set; } = null!;
        public string BaseDatos { get; set; } = null!;
        public string BaseDatosReplica { get; set; } = null!;
        public string ServidorBaseDatos { get; set; } = null!;
        public string ServidorBaseDatosReplica { get; set; } = null!;
        public int PrefijoGeneracionId { get; set; }
        public string Direccion { get; set; } = null!;
        public bool EnviarAcolaMensajes { get; set; }

        public virtual EmpresaConfiguracion EmpresaConfiguracion { get; set; } = null!;
        public virtual ICollection<UsuarioEmpresa> UsuarioEmpresas { get; set; }
    }
}
