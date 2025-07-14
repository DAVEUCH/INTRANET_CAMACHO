using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Usuario
    {
        public Usuario()
        {
            ConfiguracionReportes = new HashSet<ConfiguracionReporte>();
            Filtros = new HashSet<Filtro>();
            InverseIdperfilUsuarioNavigation = new HashSet<Usuario>();
            ItemConfiguracionVistaFiltros = new HashSet<ItemConfiguracionVistaFiltro>();
            ReporteValorPorDefectos = new HashSet<ReporteValorPorDefecto>();
            UsuarioEmpresas = new HashSet<UsuarioEmpresa>();
        }

        public int Pkid { get; set; }
        public string Idusuario { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int? IdperfilUsuario { get; set; }
        public string TipoUsuario { get; set; } = null!;
        public bool Perfil { get; set; }

        public virtual Usuario? IdperfilUsuarioNavigation { get; set; }
        public virtual ICollection<ConfiguracionReporte> ConfiguracionReportes { get; set; }
        public virtual ICollection<Filtro> Filtros { get; set; }
        public virtual ICollection<Usuario> InverseIdperfilUsuarioNavigation { get; set; }
        public virtual ICollection<ItemConfiguracionVistaFiltro> ItemConfiguracionVistaFiltros { get; set; }
        public virtual ICollection<ReporteValorPorDefecto> ReporteValorPorDefectos { get; set; }
        public virtual ICollection<UsuarioEmpresa> UsuarioEmpresas { get; set; }
    }
}
