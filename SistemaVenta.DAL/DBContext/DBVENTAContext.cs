using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SistemaVenta.Entity.Models;

namespace SistemaVenta.DAL.DBContext
{
    public partial class DBVENTAContext : DbContext
    {
        public DBVENTAContext()
        {
        }

        public DBVENTAContext(DbContextOptions<DBVENTAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categoria { get; set; } = null!;
        public virtual DbSet<Configuracion> Configuracions { get; set; } = null!;
        public virtual DbSet<DetalleSalida> DetalleSalida { get; set; } = null!;
        public virtual DbSet<DetalleVenta> DetalleVenta { get; set; } = null!;
        public virtual DbSet<FormInterIngre> FormInterIngres { get; set; } = null!;
        public virtual DbSet<FormInterSal> FormInterSals { get; set; } = null!;
        public virtual DbSet<Menu> Menus { get; set; } = null!;
        public virtual DbSet<Negocio> Negocios { get; set; } = null!;
        public virtual DbSet<NumeroCorrelativo> NumeroCorrelativos { get; set; } = null!;
        public virtual DbSet<NumeroCorrelativo2> NumeroCorrelativos2{ get; set; } = null!;
        public virtual DbSet<Producto> Productos { get; set; } = null!;
        public virtual DbSet<Rol> Rols { get; set; } = null!;
        public virtual DbSet<RolMenu> RolMenus { get; set; } = null!;
        public virtual DbSet<Salida> Salida { get; set; } = null!;
        public virtual DbSet<TipoDocumentoOC> TipoDocumentoOC { get; set; } = null!;
        public virtual DbSet<TipoDocumentoVenta> TipoDocumentoVenta { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<Venta> Venta { get; set; } = null!;
       

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__Categori__8A3D240C53D71C6E");

                entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.EsActivo).HasColumnName("esActivo");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaRegistro")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Configuracion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Configuracion");

                entity.Property(e => e.Propiedad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("propiedad");

                entity.Property(e => e.Recurso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("recurso");

                entity.Property(e => e.Valor)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("valor");
            });

            modelBuilder.Entity<DetalleVenta>(entity =>
            {
                entity.HasKey(e => e.IdDetalleVenta)
                    .HasName("PK__DetalleV__BFE2843FB0FBCE63");

                entity.Property(e => e.IdDetalleVenta).HasColumnName("idDetalleVenta");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.CategoriaProducto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("categoriaProducto");

                entity.Property(e => e.DescripcionProducto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcionProducto");

                entity.Property(e => e.IdProducto).HasColumnName("idProducto");

                entity.Property(e => e.IdVenta).HasColumnName("idVenta");

                entity.Property(e => e.MarcaProducto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("marcaProducto");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("precio");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("total");

                entity.HasOne(d => d.IdVentaNavigation)
                    .WithMany(p => p.DetalleVenta)
                    .HasForeignKey(d => d.IdVenta)
                    .HasConstraintName("FK__DetalleVe__idVen__300424B4");
            });

            modelBuilder.Entity<DetalleSalida>(entity =>
            {
                entity.HasKey(e => e.IdDetalleSalida)
                    .HasName("PK__DetalleS__E1C2A9222C5557D4");

                entity.Property(e => e.IdDetalleSalida).HasColumnName("idDetalleSalida");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.CategoriaProducto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("categoriaProducto");

                entity.Property(e => e.DescripcionProducto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcionProducto");

                entity.Property(e => e.IdProducto).HasColumnName("idProducto");

                entity.Property(e => e.IdSalida).HasColumnName("idSalida");

                entity.Property(e => e.MarcaProducto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("marcaProducto");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("precio");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("total");

                entity.HasOne(d => d.IdSalidaNavigation)
                    .WithMany(p => p.DetalleSalida)
                    .HasForeignKey(d => d.IdSalida)
                    .HasConstraintName("FK__DetalleSa__idSal__07C12930");
            });
            modelBuilder.Entity<FormInterIngre>(entity =>
            {
                entity.HasKey(e => e.IdFormInterIngre)
                    .HasName("PK__FormInte__715FF397EA52F6F2");

                entity.ToTable("FormInterIngre");

                entity.Property(e => e.IdFormInterIngre).HasColumnName("idFormInterIngre");

                entity.Property(e => e.ApePersona)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("apePersona");

                entity.Property(e => e.AreaPersona)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("areaPersona");

                entity.Property(e => e.CargPersona)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cargPersona");

                entity.Property(e => e.DniPersona)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("dniPersona");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaIng");

                entity.Property(e => e.Hardwcel).HasColumnName("hardwcel");

                entity.Property(e => e.Hardwcompu).HasColumnName("hardwcompu");

                entity.Property(e => e.Hardwlapt).HasColumnName("hardwlapt");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.NombPersona)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombPersona");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("observacion");

                entity.Property(e => e.SoftAntiv).HasColumnName("softAntiv");

                entity.Property(e => e.Softadob).HasColumnName("softadob");

                entity.Property(e => e.Softcorr).HasColumnName("softcorr");

                entity.Property(e => e.Softflex).HasColumnName("softflex");

                entity.Property(e => e.Softoffice).HasColumnName("softoffice");

                entity.Property(e => e.Softsys).HasColumnName("softsys");

                entity.Property(e => e.TipoPuesto).HasColumnName("tipoPuesto");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.FormInterIngres)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__FormInter__idUsu__6FE99F9F");
            });
            //modelBuilder.Entity<FormInterIngre>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("FormInterIngre");

            //    entity.Property(e => e.ApePersona)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("apePersona");

            //    entity.Property(e => e.AreaPersona)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("areaPersona");

            //    entity.Property(e => e.CargPersona)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("cargPersona");

            //    entity.Property(e => e.DniPersona)
            //        .HasMaxLength(12)
            //        .IsUnicode(false)
            //        .HasColumnName("dniPersona");

            //    entity.Property(e => e.Estado).HasColumnName("estado");

            //    entity.Property(e => e.FechaIng)
            //        .HasColumnType("datetime")
            //        .HasColumnName("fechaIng");

            //    entity.Property(e => e.Hardwcel).HasColumnName("hardwcel");

            //    entity.Property(e => e.Hardwcompu).HasColumnName("hardwcompu");

            //    entity.Property(e => e.Hardwlapt).HasColumnName("hardwlapt");

            //    entity.Property(e => e.IdFormInterIngre)
            //        .ValueGeneratedOnAdd()
            //        .HasColumnName("idFormInterIngre");

            //    entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

            //    entity.Property(e => e.NombPersona)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("nombPersona");

            //    entity.Property(e => e.Observacion)
            //        .HasMaxLength(8000)
            //        .IsUnicode(false)
            //        .HasColumnName("observacion");

            //    entity.Property(e => e.SoftAntiv).HasColumnName("softAntiv");

            //    entity.Property(e => e.Softadob).HasColumnName("softadob");

            //    entity.Property(e => e.Softcorr).HasColumnName("softcorr");

            //    entity.Property(e => e.Softflex).HasColumnName("softflex");

            //    entity.Property(e => e.Softoffice).HasColumnName("softoffice");

            //    entity.Property(e => e.Softsys).HasColumnName("softsys");

            //    entity.Property(e => e.TipoPuesto).HasColumnName("tipoPuesto");

            //    entity.HasOne(d => d.IdUsuarioNavigation)
            //        .WithMany()
            //        .HasForeignKey(d => d.IdUsuario)
            //        .HasConstraintName("FK__FormInter__idUsu__5FB337D6");
            //});

            modelBuilder.Entity<FormInterSal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FormInterSal");

                entity.Property(e => e.Accefex).HasColumnName("accefex");

                entity.Property(e => e.Acceotro).HasColumnName("acceotro");

                entity.Property(e => e.Accessys).HasColumnName("accessys");

                entity.Property(e => e.ApePersona)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("apePersona");

                entity.Property(e => e.AreaPersona)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("areaPersona");

                entity.Property(e => e.CargPersona)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cargPersona");

                entity.Property(e => e.Correocorp).HasColumnName("correocorp");

                entity.Property(e => e.DevdescripmodelLappc)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("devdescripmodelLappc");

                entity.Property(e => e.Devdescripmodeotros)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("devdescripmodeotros");

                entity.Property(e => e.Devdevuelto).HasColumnName("devdevuelto");

                entity.Property(e => e.Devdevueltootros).HasColumnName("devdevueltootros");

                entity.Property(e => e.Devnoaplica).HasColumnName("devnoaplica");

                entity.Property(e => e.Devnoaplicaotros).HasColumnName("devnoaplicaotros");

                entity.Property(e => e.Devobslappoc)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("devobslappoc");

                entity.Property(e => e.Devobslappocotros)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("devobslappocotros");

                entity.Property(e => e.DevserienumLappc)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("devserienumLappc");

                entity.Property(e => e.Devserienumotros)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("devserienumotros");

                entity.Property(e => e.DniPersona)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("dniPersona");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaIng");

                entity.Property(e => e.IdFormInterSal)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idFormInterSal");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.NombPersona)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombPersona");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("observacion");

                entity.Property(e => e.PerfilAdpersona)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("perfilADPersona");

                entity.Property(e => e.Usured).HasColumnName("usured");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__FormInter__idUsu__619B8048");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.HasKey(e => e.IdMenu)
                    .HasName("PK__Menu__C26AF483CA54C183");

                entity.ToTable("Menu");

                entity.Property(e => e.IdMenu).HasColumnName("idMenu");

                entity.Property(e => e.Controlador)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("controlador");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.EsActivo).HasColumnName("esActivo");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaRegistro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Icono)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("icono");

                entity.Property(e => e.IdMenuPadre).HasColumnName("idMenuPadre");

                entity.Property(e => e.PaginaAccion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("paginaAccion");

                entity.HasOne(d => d.IdMenuPadreNavigation)
                    .WithMany(p => p.InverseIdMenuPadreNavigation)
                    .HasForeignKey(d => d.IdMenuPadre)
                    .HasConstraintName("FK__Menu__idMenuPadr__108B795B");
            });

            modelBuilder.Entity<Negocio>(entity =>
            {
                entity.HasKey(e => e.IdNegocio)
                    .HasName("PK__Negocio__70E1E107C38B04E3");

                entity.ToTable("Negocio");

                entity.Property(e => e.IdNegocio)
                    .ValueGeneratedNever()
                    .HasColumnName("idNegocio");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.NombreLogo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombreLogo");

                entity.Property(e => e.NumeroDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numeroDocumento");

                entity.Property(e => e.PorcentajeImpuesto)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("porcentajeImpuesto");

                entity.Property(e => e.SimboloMoneda)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("simboloMoneda");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefono");

                entity.Property(e => e.UrlLogo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("urlLogo");
            });

            modelBuilder.Entity<NumeroCorrelativo>(entity =>
            {
                entity.HasKey(e => e.IdNumeroCorrelativo)
                    .HasName("PK__NumeroCo__25FB547EF83526BF");

                entity.ToTable("NumeroCorrelativo");

                entity.Property(e => e.IdNumeroCorrelativo).HasColumnName("idNumeroCorrelativo");

                entity.Property(e => e.CantidadDigitos).HasColumnName("cantidadDigitos");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaActualizacion");

                entity.Property(e => e.Gestion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("gestion");

                entity.Property(e => e.UltimoNumero).HasColumnName("ultimoNumero");
            });

            modelBuilder.Entity<NumeroCorrelativo2>(entity =>
            {
                entity.HasKey(e => e.IdNumeroCorrelativo2)
                    .HasName("PK__NumeroCo__8676094F2CF62770");

                entity.ToTable("NumeroCorrelativo2");

                entity.Property(e => e.IdNumeroCorrelativo2).HasColumnName("idNumeroCorrelativo2");

                entity.Property(e => e.CantidadDigitos).HasColumnName("cantidadDigitos");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaActualizacion");

                entity.Property(e => e.Gestion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("gestion");

                entity.Property(e => e.UltimoNumero).HasColumnName("ultimoNumero");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto)
                    .HasName("PK__Producto__07F4A13260F2207D");

                entity.ToTable("Producto");

                entity.Property(e => e.IdProducto).HasColumnName("idProducto");

                entity.Property(e => e.CodigoBarra)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codigoBarra");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.EsActivo).HasColumnName("esActivo");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaRegistro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");

                entity.Property(e => e.Marca)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("marca");

                entity.Property(e => e.NombreImagen)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombreImagen");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("precio");

                entity.Property(e => e.Stock).HasColumnName("stock");

                entity.Property(e => e.UrlImagen)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("urlImagen");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK__Producto__idCate__22AA2996");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PK__Rol__3C872F763C1D1497");

                entity.ToTable("Rol");

                entity.Property(e => e.IdRol).HasColumnName("idRol");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.EsActivo).HasColumnName("esActivo");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaRegistro")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<RolMenu>(entity =>
            {
                entity.HasKey(e => e.IdRolMenu)
                    .HasName("PK__RolMenu__CD2045D8F6A2531C");

                entity.ToTable("RolMenu");

                entity.Property(e => e.IdRolMenu).HasColumnName("idRolMenu");

                entity.Property(e => e.EsActivo).HasColumnName("esActivo");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaRegistro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdMenu).HasColumnName("idMenu");

                entity.Property(e => e.IdRol).HasColumnName("idRol");

                entity.HasOne(d => d.IdMenuNavigation)
                    .WithMany(p => p.RolMenus)
                    .HasForeignKey(d => d.IdMenu)
                    .HasConstraintName("FK__RolMenu__idMenu__182C9B23");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.RolMenus)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("FK__RolMenu__idRol__173876EA");
            });

            modelBuilder.Entity<TipoDocumentoVenta>(entity =>
            {
                entity.HasKey(e => e.IdTipoDocumentoVenta)
                    .HasName("PK__TipoDocu__A9D59AEE5E34668E");

                entity.Property(e => e.IdTipoDocumentoVenta).HasColumnName("idTipoDocumentoVenta");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.EsActivo).HasColumnName("esActivo");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaRegistro")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TipoDocumentoOC>(entity =>
            {
                entity.HasKey(e => e.IdTipoDocumentoOC)
                    .HasName("PK__TipoDocu__759652B5B59DBFDC");

                entity.ToTable("TipoDocumentoOC");

                entity.Property(e => e.IdTipoDocumentoOC).HasColumnName("IdTipoDocumentoOC");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.EsActivo).HasColumnName("esActivo");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaRegistro")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__645723A6E5D3BBB4");

                entity.ToTable("Usuario");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Clave)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("clave");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.EsActivo).HasColumnName("esActivo");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaRegistro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdRol).HasColumnName("idRol");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.NombreFoto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombreFoto");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefono");

                entity.Property(e => e.UrlFoto)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("urlFoto");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("FK__Usuario__idRol__1BFD2C07");
            });

            modelBuilder.Entity<Venta>(entity =>
            {
                entity.HasKey(e => e.IdVenta)
                    .HasName("PK__Venta__077D56144A1DEFDA");

                entity.Property(e => e.IdVenta).HasColumnName("idVenta");

                entity.Property(e => e.DocumentoCliente)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("documentoCliente");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaRegistro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdTipoDocumentoVenta).HasColumnName("idTipoDocumentoVenta");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.ImpuestoTotal)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("impuestoTotal");

                entity.Property(e => e.NombreCliente)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nombreCliente");

                entity.Property(e => e.NumeroVenta)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("numeroVenta");

                entity.Property(e => e.SubTotal)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("subTotal");

                entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.IdTipoDocumentoVentaNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.IdTipoDocumentoVenta)
                    .HasConstraintName("FK__Venta__idTipoDoc__2B3F6F97");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Venta__idUsuario__2C3393D0");
            });

            modelBuilder.Entity<Salida>(entity =>
            {
                entity.HasKey(e => e.IdSalida)
                    .HasName("PK__Salida__BBE6FB5D9CC9FBF1");

                entity.Property(e => e.IdSalida).HasColumnName("idSalida");

                entity.Property(e => e.DocumentoCliente)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("documentoCliente");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaRegistro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdTipoDocumentoOc).HasColumnName("IdTipoDocumentoOC");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.ImpuestoTotal)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("impuestoTotal");

                entity.Property(e => e.NombreCliente)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nombreCliente");

                entity.Property(e => e.NumeroSalida)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("numeroSalida");

                entity.Property(e => e.SubTotal)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("subTotal");

                entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.IdTipoDocumentoOCNavigation)
                    .WithMany(p => p.Salida)
                    .HasForeignKey(d => d.IdTipoDocumentoOc)
                    .HasConstraintName("FK__Salida__IdTipoDo__02FC7413");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Salida)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Salida__idUsuari__03F0984C");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
