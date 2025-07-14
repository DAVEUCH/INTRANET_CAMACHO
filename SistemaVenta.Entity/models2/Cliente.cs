using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Cliente
    {
        public Cliente()
        {
            LineaCreditoPorFuerzaVenta = new HashSet<LineaCreditoPorFuerzaVenta>();
            Nopedidos = new HashSet<Nopedido>();
            SolicitudSoportes = new HashSet<SolicitudSoporte>();
        }

        public int Pkid { get; set; }
        public int IdcategoriaCliente { get; set; }
        public int Idmoneda { get; set; }
        public decimal LineaCredito { get; set; }
        public decimal BalanceSoles { get; set; }
        public decimal BalanceDolares { get; set; }
        public bool MejorPrecio { get; set; }
        public int IdmodalidadCredito { get; set; }
        public int DiasCredito { get; set; }
        public int IdtipoMedioDePago { get; set; }
        public bool CreditoContado { get; set; }
        public bool InhabilitadoBonificacion { get; set; }
        public bool InhabilitadoDescuento { get; set; }
        public int IdtipoCliente { get; set; }
        public bool LineaCreditoPorFuerzaVentas { get; set; }
        public int MaximoCuentasPorCobrarVencidas { get; set; }
        public string Campo1 { get; set; } = null!;
        public string Campo2 { get; set; } = null!;
        public string Campo3 { get; set; } = null!;
        public string Campo4 { get; set; } = null!;
        public int Idcaracteristica1 { get; set; }
        public int Idcaracteristica2 { get; set; }
        public int Idcaracteristica3 { get; set; }
        public int Idcaracteristica4 { get; set; }
        public bool Corporativo { get; set; }
        public int IdclienteCorporativo { get; set; }
        public bool LineaCreditoCorporativa { get; set; }
        public bool LineaCreditoActiva { get; set; }

        public virtual Caracteristica Idcaracteristica1Navigation { get; set; } = null!;
        public virtual Caracteristica Idcaracteristica2Navigation { get; set; } = null!;
        public virtual Caracteristica Idcaracteristica3Navigation { get; set; } = null!;
        public virtual Caracteristica Idcaracteristica4Navigation { get; set; } = null!;
        public virtual CategoriaCliente IdcategoriaClienteNavigation { get; set; } = null!;
        public virtual Monedum IdmonedaNavigation { get; set; } = null!;
        public virtual TipoCliente IdtipoClienteNavigation { get; set; } = null!;
        public virtual Persona Pk { get; set; } = null!;
        public virtual EmpresaTransporte EmpresaTransporte { get; set; } = null!;
        public virtual ICollection<LineaCreditoPorFuerzaVenta> LineaCreditoPorFuerzaVenta { get; set; }
        public virtual ICollection<Nopedido> Nopedidos { get; set; }
        public virtual ICollection<SolicitudSoporte> SolicitudSoportes { get; set; }
    }
}
