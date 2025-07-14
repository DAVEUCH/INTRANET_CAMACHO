using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Clasificador
    {
        public Clasificador()
        {
            Comando2s = new HashSet<Comando2>();
            ConfiguracionConciliacionBancariumIdtipoPersonaCpCajaEntradaNavigations = new HashSet<ConfiguracionConciliacionBancarium>();
            ConfiguracionConciliacionBancariumIdtipoPersonaCpCajaSalidaNavigations = new HashSet<ConfiguracionConciliacionBancarium>();
            ConfiguracionPeriodoCierres = new HashSet<ConfiguracionPeriodoCierre>();
            CpContabilizables = new HashSet<CpContabilizable>();
            Cps = new HashSet<Cp>();
            CptoOperacionIdtipoAsociadoNavigations = new HashSet<CptoOperacion>();
            CptoOperacionIdtipoOrigenNavigations = new HashSet<CptoOperacion>();
            ElementoTipos = new HashSet<ElementoTipo>();
            PlanCuenta = new HashSet<PlanCuenta>();
            ReglaCodificacions = new HashSet<ReglaCodificacion>();
        }

        public string Pkid { get; set; } = null!;
        public string Idensamblado { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string NombreClase { get; set; } = null!;
        public string Alias { get; set; } = null!;

        public virtual Ensamblado IdensambladoNavigation { get; set; } = null!;
        public virtual ContenedorConfiguracionVistum ContenedorConfiguracionVistum { get; set; } = null!;
        public virtual Tipo Tipo { get; set; } = null!;
        public virtual TipoDato TipoDato { get; set; } = null!;
        public virtual ICollection<Comando2> Comando2s { get; set; }
        public virtual ICollection<ConfiguracionConciliacionBancarium> ConfiguracionConciliacionBancariumIdtipoPersonaCpCajaEntradaNavigations { get; set; }
        public virtual ICollection<ConfiguracionConciliacionBancarium> ConfiguracionConciliacionBancariumIdtipoPersonaCpCajaSalidaNavigations { get; set; }
        public virtual ICollection<ConfiguracionPeriodoCierre> ConfiguracionPeriodoCierres { get; set; }
        public virtual ICollection<CpContabilizable> CpContabilizables { get; set; }
        public virtual ICollection<Cp> Cps { get; set; }
        public virtual ICollection<CptoOperacion> CptoOperacionIdtipoAsociadoNavigations { get; set; }
        public virtual ICollection<CptoOperacion> CptoOperacionIdtipoOrigenNavigations { get; set; }
        public virtual ICollection<ElementoTipo> ElementoTipos { get; set; }
        public virtual ICollection<PlanCuenta> PlanCuenta { get; set; }
        public virtual ICollection<ReglaCodificacion> ReglaCodificacions { get; set; }
    }
}
