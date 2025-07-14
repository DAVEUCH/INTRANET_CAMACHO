using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EParametro
    {
        public string ParametrosId { get; set; } = null!;
        public string Idreporte { get; set; } = null!;
        public string ParametrosIdtipo { get; set; } = null!;
        public string ParametrosNombre { get; set; } = null!;
        public string ParametrosRutaCebusqueda { get; set; } = null!;
        public int ParametrosTipoDato { get; set; }
        public bool ParametrosOpcional { get; set; }
        public bool ParametrosListado { get; set; }
        public string ParametrosValorPorDefecto { get; set; } = null!;
        public bool ParametrosSolicitarValor { get; set; }
        public string ParametrosFiltro { get; set; } = null!;
        public int ParametrosPosicion { get; set; }
        public string ParametrosMaximo { get; set; } = null!;
        public string ParametrosMinimo { get; set; } = null!;
        public bool ParametrosSolicitarFiltro { get; set; }
        public bool ParametrosGuardarValorPorUsuario { get; set; }
        public string Id { get; set; } = null!;
        public string Idtipo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string RutaCebusqueda { get; set; } = null!;
        public int TipoDato { get; set; }
        public bool Opcional { get; set; }
        public bool Listado { get; set; }
        public string ValorPorDefecto { get; set; } = null!;
        public bool SolicitarValor { get; set; }
        public string Filtro { get; set; } = null!;
        public int Posicion { get; set; }
        public string Maximo { get; set; } = null!;
        public string Minimo { get; set; } = null!;
        public bool SolicitarFiltro { get; set; }
        public bool GuardarValorPorUsuario { get; set; }
    }
}
