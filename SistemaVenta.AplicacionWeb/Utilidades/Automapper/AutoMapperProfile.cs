﻿
using SistemaVenta.AplicacionWeb.Models.ViewModels;
using System.Globalization;
using AutoMapper;
using SistemaVenta.Entity.Models;

namespace SistemaVenta.AplicacionWeb.Utilidades.Automapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            #region Rol
            //CreateMap<Rol, VMRol>().ReverseMap();
            CreateMap<Rol, VMRol>()
            .ForMember(destino =>
            destino.esActivo,
            opt => opt.MapFrom(origen => origen.EsActivo == true ? 1 : 0)
              );

            CreateMap<VMRol, Rol>()
            .ForMember(destino =>
                destino.EsActivo,
                opt => opt.MapFrom(origen => origen.esActivo == 1 ? true : false)
            );
            #endregion Rol

            #region Usuario
            CreateMap<Usuario, VMUsuario>()
                .ForMember(destino =>
                    destino.EsActivo,
                    opt => opt.MapFrom(origen => origen.EsActivo == true ? 1 : 0)
                )
                .ForMember(destino =>
                    destino.NombreRol,
                    opt => opt.MapFrom(origen => origen.IdRolNavigation.Descripcion)
                );

            CreateMap<VMUsuario, Usuario>()
                .ForMember(destino =>
                    destino.EsActivo,
                    opt => opt.MapFrom(origen => origen.EsActivo == 1 ? true : false)
                )
                .ForMember(destino =>
                    destino.IdRolNavigation,
                    opt => opt.Ignore()
                    );

            #endregion

            #region Negocio
            CreateMap<Negocio, VMNegocio>()
                .ForMember(destino =>
                    destino.PorcentajeImpuesto,
                    opt => opt.MapFrom(origen => Convert.ToString(origen.PorcentajeImpuesto.Value, new CultureInfo("es-PE")))
                );

            CreateMap<VMNegocio , Negocio>()
               .ForMember(destino =>
                   destino.PorcentajeImpuesto,
                   opt => opt.MapFrom(origen => Convert.ToDecimal(origen.PorcentajeImpuesto, new CultureInfo("es-PE")))
               );


            #endregion

            #region Categoria
            CreateMap<Categoria, VMCategoria>()
           .ForMember(destino =>
               destino.esActivo,
               opt => opt.MapFrom(origen => origen.EsActivo == true ? 1 : 0)
           );

            CreateMap<VMCategoria, Categoria>()
            .ForMember(destino =>
                destino.EsActivo,
                opt => opt.MapFrom(origen => origen.esActivo == 1 ? true : false)
            );
            #endregion

            #region Producto

            CreateMap<Producto, VMProducto>()
                .ForMember(destino =>
                    destino.EsActivo,
                    opt => opt.MapFrom(origen => origen.EsActivo == true ? 1 : 0)
                )
                .ForMember(destino =>
                    destino.NombreCategoria,
                    opt => opt.MapFrom(origen => origen.IdCategoriaNavigation.Descripcion)
                )
                .ForMember(destino =>
                    destino.Precio,
                    opt => opt.MapFrom(origen => Convert.ToString(origen.Precio.Value, new CultureInfo("es-PE")))
                );

            CreateMap<VMProducto, Producto >()
                .ForMember(destino =>
                    destino.EsActivo,
                    opt => opt.MapFrom(origen => origen.EsActivo == 1 ? true : false)
                )
                .ForMember(destino =>
                    destino.IdCategoriaNavigation,
                    opt => opt.Ignore()
                )
                .ForMember(destino =>
                    destino.Precio,
                    opt => opt.MapFrom(origen => Convert.ToDecimal(origen.Precio, new CultureInfo("es-PE")))
                );

            #endregion

            #region TipoDocumentoVenta
            CreateMap<TipoDocumentoVenta, VMTipoDocumentoVenta>().ReverseMap();
            #endregion

            #region Venta
            CreateMap<Venta,VMVenta>()
                 .ForMember(destino =>
                    destino.TipoDocumentoVenta,
                    opt => opt.MapFrom(origen => origen.IdTipoDocumentoVentaNavigation.Descripcion)
                )
                 .ForMember(destino =>
                    destino.Usuario,
                    opt => opt.MapFrom(origen => origen.IdUsuarioNavigation.Nombre)
                )
                .ForMember(destino =>
                    destino.SubTotal,
                    opt => opt.MapFrom(origen => Convert.ToString(origen.SubTotal.Value, new CultureInfo("es-PE")))
                )
                .ForMember(destino =>
                    destino.ImpuestoTotal,
                    opt => opt.MapFrom(origen => Convert.ToString(origen.ImpuestoTotal.Value, new CultureInfo("es-PE")))
                )
                 .ForMember(destino =>
                    destino.Total,
                    opt => opt.MapFrom(origen => Convert.ToString(origen.Total.Value, new CultureInfo("es-PE")))
                )
                 .ForMember(destino =>
                    destino.FechaRegistro,
                    opt => opt.MapFrom(origen => origen.FechaRegistro.Value.ToString("dd/MM/yyyy"))
                );

            CreateMap<VMVenta, Venta>()
              .ForMember(destino =>
                   destino.SubTotal,
                   opt => opt.MapFrom(origen => Convert.ToDecimal(origen.SubTotal, new CultureInfo("es-PE")))
               )
               .ForMember(destino =>
                   destino.ImpuestoTotal,
                   opt => opt.MapFrom(origen => Convert.ToDecimal(origen.ImpuestoTotal, new CultureInfo("es-PE")))
               )
                .ForMember(destino =>
                   destino.Total,
                   opt => opt.MapFrom(origen => Convert.ToDecimal(origen.Total, new CultureInfo("es-PE")))
               );
            #endregion

            #region DetalleVenta
            CreateMap<DetalleVenta, VMDetalleVenta>()
                 .ForMember(destino =>
                    destino.Precio,
                    opt => opt.MapFrom(origen => Convert.ToString(origen.Precio.Value, new CultureInfo("es-PE")))
                )
                 .ForMember(destino =>
                    destino.Total,
                    opt => opt.MapFrom(origen => Convert.ToString(origen.Total.Value, new CultureInfo("es-PE")))
                );

            CreateMap< VMDetalleVenta,DetalleVenta>()
               .ForMember(destino =>
                  destino.Precio,
                  opt => opt.MapFrom(origen => Convert.ToDecimal(origen.Precio, new CultureInfo("es-PE")))
              )
               .ForMember(destino =>
                  destino.Total,
                  opt => opt.MapFrom(origen => Convert.ToDecimal(origen.Total, new CultureInfo("es-PE")))
              );

            CreateMap<DetalleVenta,VMReporteVenta>()
            .ForMember(destino =>
                  destino.FechaRegistro,
                  opt => opt.MapFrom(origen => origen.IdVentaNavigation.FechaRegistro.Value.ToString("dd/MM/yyyy"))
              )
            .ForMember(destino =>
                  destino.NumeroVenta,
                  opt => opt.MapFrom(origen => origen.IdVentaNavigation.NumeroVenta )
              )
            .ForMember(destino =>
                  destino.TipoDocumento,
                  opt => opt.MapFrom(origen => origen.IdVentaNavigation.IdTipoDocumentoVentaNavigation.Descripcion)
              )
            .ForMember(destino =>
                  destino.DocumentoCliente,
                  opt => opt.MapFrom(origen => origen.IdVentaNavigation.DocumentoCliente)
              )
             .ForMember(destino =>
                  destino.NombreCliente,
                  opt => opt.MapFrom(origen => origen.IdVentaNavigation.NombreCliente)
              )

              .ForMember(destino =>
                  destino.SubTotalVenta,
                  opt => opt.MapFrom(origen => Convert.ToString(origen.IdVentaNavigation.SubTotal.Value, new CultureInfo("es-PE")))
              )
              .ForMember(destino =>
                  destino.ImpuestoTotalVenta,
                  opt => opt.MapFrom(origen => Convert.ToString(origen.IdVentaNavigation.ImpuestoTotal.Value, new CultureInfo("es-PE")))
              )
               .ForMember(destino =>
                  destino.TotalVenta,
                  opt => opt.MapFrom(origen => Convert.ToString(origen.IdVentaNavigation.Total.Value, new CultureInfo("es-PE")))
              )
               .ForMember(destino =>
                  destino.Producto,
                  opt => opt.MapFrom(origen => origen.DescripcionProducto)
              )
               .ForMember(destino =>
                  destino.Precio,
                  opt => opt.MapFrom(origen => Convert.ToString(origen.Precio.Value, new CultureInfo("es-PE")))
              )
                .ForMember(destino =>
                  destino.Total,
                  opt => opt.MapFrom(origen => Convert.ToString(origen.Total.Value, new CultureInfo("es-PE")))
              )
            ;

            #endregion

            #region Menu
            CreateMap<Menu, VMMenu>()
                 .ForMember(destino =>
                  destino.SubMenus,
                  opt => opt.MapFrom(origen => origen.InverseIdMenuPadreNavigation)
              );
            #endregion

            #region Salida
            CreateMap<Salida, VMSalida>()
                 .ForMember(destino =>
                    destino.TipoDocumentoOC,
                    opt => opt.MapFrom(origen => origen.IdTipoDocumentoOCNavigation.Descripcion)
                )
                 .ForMember(destino =>
                    destino.Usuario,
                    opt => opt.MapFrom(origen => origen.IdUsuarioNavigation.Nombre)
                )
                .ForMember(destino =>
                    destino.SubTotal,
                    opt => opt.MapFrom(origen => Convert.ToString(origen.SubTotal.Value, new CultureInfo("es-PE")))
                )
                .ForMember(destino =>
                    destino.ImpuestoTotal,
                    opt => opt.MapFrom(origen => Convert.ToString(origen.ImpuestoTotal.Value, new CultureInfo("es-PE")))
                )
                 .ForMember(destino =>
                    destino.Total,
                    opt => opt.MapFrom(origen => Convert.ToString(origen.Total.Value, new CultureInfo("es-PE")))
                )
                 .ForMember(destino =>
                    destino.FechaRegistro,
                    opt => opt.MapFrom(origen => origen.FechaRegistro.Value.ToString("dd/MM/yyyy"))
                );

            CreateMap<VMSalida, Salida>()
              .ForMember(destino =>
                   destino.SubTotal,
                   opt => opt.MapFrom(origen => Convert.ToDecimal(origen.SubTotal, new CultureInfo("es-PE")))
               )
               .ForMember(destino =>
                   destino.ImpuestoTotal,
                   opt => opt.MapFrom(origen => Convert.ToDecimal(origen.ImpuestoTotal, new CultureInfo("es-PE")))
               )
                .ForMember(destino =>
                   destino.Total,
                   opt => opt.MapFrom(origen => Convert.ToDecimal(origen.Total, new CultureInfo("es-PE")))
               );
            #endregion

            #region DetalleSalida
            CreateMap<DetalleSalida, VMDetalleSalida>()
                 .ForMember(destino =>
                    destino.Precio,
                    opt => opt.MapFrom(origen => Convert.ToString(origen.Precio.Value, new CultureInfo("es-PE")))
                )
                 .ForMember(destino =>
                    destino.Total,
                    opt => opt.MapFrom(origen => Convert.ToString(origen.Total.Value, new CultureInfo("es-PE")))
                );

            CreateMap<VMDetalleSalida, DetalleSalida>()
               .ForMember(destino =>
                  destino.Precio,
                  opt => opt.MapFrom(origen => Convert.ToDecimal(origen.Precio, new CultureInfo("es-PE")))
              )
               .ForMember(destino =>
                  destino.Total,
                  opt => opt.MapFrom(origen => Convert.ToDecimal(origen.Total, new CultureInfo("es-PE")))
              );

            CreateMap<DetalleSalida, VMReporteSalida>()
            .ForMember(destino =>
                  destino.FechaRegistro,
                  opt => opt.MapFrom(origen => origen.IdSalidaNavigation.FechaRegistro.Value.ToString("dd/MM/yyyy"))
              )
            .ForMember(destino =>
                  destino.NumeroVenta,
                  opt => opt.MapFrom(origen => origen.IdSalidaNavigation.NumeroSalida)
              )
            .ForMember(destino =>
                  destino.TipoDocumento,
                  opt => opt.MapFrom(origen => origen.IdSalidaNavigation.IdTipoDocumentoOCNavigation.Descripcion)
              )
            .ForMember(destino =>
                  destino.DocumentoCliente,
                  opt => opt.MapFrom(origen => origen.IdSalidaNavigation.DocumentoCliente)
              )
             .ForMember(destino =>
                  destino.NombreCliente,
                  opt => opt.MapFrom(origen => origen.IdSalidaNavigation.NombreCliente)
              )

              .ForMember(destino =>
                  destino.SubTotalVenta,
                  opt => opt.MapFrom(origen => Convert.ToString(origen.IdSalidaNavigation.SubTotal.Value, new CultureInfo("es-PE")))
              )
              .ForMember(destino =>
                  destino.ImpuestoTotalVenta,
                  opt => opt.MapFrom(origen => Convert.ToString(origen.IdSalidaNavigation.ImpuestoTotal.Value, new CultureInfo("es-PE")))
              )
               .ForMember(destino =>
                  destino.TotalVenta,
                  opt => opt.MapFrom(origen => Convert.ToString(origen.IdSalidaNavigation.Total.Value, new CultureInfo("es-PE")))
              )
               .ForMember(destino =>
                  destino.Producto,
                  opt => opt.MapFrom(origen => origen.DescripcionProducto)
              )
               .ForMember(destino =>
                  destino.Precio,
                  opt => opt.MapFrom(origen => Convert.ToString(origen.Precio.Value, new CultureInfo("es-PE")))
              )
                .ForMember(destino =>
                  destino.Total,
                  opt => opt.MapFrom(origen => Convert.ToString(origen.Total.Value, new CultureInfo("es-PE")))
              )
            ;

            #endregion

            #region TipoDocumentoOC
            CreateMap<TipoDocumentoOC, VMTipoDocumentoOC>().ReverseMap();
            #endregion

            #region FormInterIngre
            //CreateMap<Rol, VMRol>().ReverseMap();
            CreateMap<FormInterIngre, VMFormInterIngre>()
            .ForMember(destino =>
            destino.Estado,
            opt => opt.MapFrom(origen => origen.Estado == true ? 1 : 0))
            .ForMember(destino =>
            destino.TipoPuesto,
            opt => opt.MapFrom(origen => origen.TipoPuesto ==true ? 1:0))
            .ForMember(destino =>
            destino.Hardwlapt,
            opt => opt.MapFrom(origen => origen.Hardwlapt == true ? 1 : 0))
            .ForMember(destino =>
            destino.Hardwcompu,
            opt => opt.MapFrom(origen => origen.Hardwcompu == true ? 1 : 0))
            .ForMember(destino =>
            destino.Hardwcel,
            opt => opt.MapFrom(origen => origen.Hardwcel == true ? 1 : 0))
            .ForMember(destino =>
            destino.Softoffice,
            opt => opt.MapFrom(origen => origen.Softoffice == true ? 1 : 0))
            .ForMember(destino =>
            destino.SoftAntiv,
            opt => opt.MapFrom(origen => origen.SoftAntiv == true ? 1 : 0))
            .ForMember(destino =>
            destino.Softadob,
            opt => opt.MapFrom(origen => origen.Softadob == true ? 1 : 0))
            .ForMember(destino =>
            destino.Softcorr,
            opt => opt.MapFrom(origen => origen.Softcorr == true ? 1 : 0))
            .ForMember(destino =>
            destino.Softsys,
            opt => opt.MapFrom(origen => origen.Softsys == true ? 1 : 0))
            .ForMember(destino =>
            destino.Softflex,
            opt => opt.MapFrom(origen => origen.Softflex == true ? 1 : 0))
            .ForMember(destino =>
            destino.Usuario,
            opt => opt.MapFrom(origen => origen.IdUsuarioNavigation != null ? origen.IdUsuarioNavigation.Nombre : null)
            );

            CreateMap<VMFormInterIngre, FormInterIngre>()
            .ForMember(destino =>
                destino.Estado,
                opt => opt.MapFrom(origen => origen.Estado == 1 ? true : false))
            .ForMember(destino =>
                destino.TipoPuesto,
                opt => opt.MapFrom(origen => origen.TipoPuesto == 1? true : false))
            .ForMember(destino =>
                destino.Hardwlapt,
                opt => opt.MapFrom(origen => origen.Hardwlapt == 1 ? true : false))
             .ForMember(destino =>
                destino.Hardwcompu,
                opt => opt.MapFrom(origen => origen.Hardwcompu == 1 ? true : false))
             .ForMember(destino =>
                destino.Hardwcel,
                opt => opt.MapFrom(origen => origen.Hardwcel == 1 ? true : false))
             .ForMember(destino =>
                destino.Softoffice,
                opt => opt.MapFrom(origen => origen.Softoffice == 1 ? true : false))
             .ForMember(destino =>
                destino.SoftAntiv,
                opt => opt.MapFrom(origen => origen.SoftAntiv == 1 ? true : false))
             .ForMember(destino =>
                destino.Softadob,
                opt => opt.MapFrom(origen => origen.Softadob == 1 ? true : false))
             .ForMember(destino =>
                destino.Softcorr,
                opt => opt.MapFrom(origen => origen.Softcorr == 1 ? true : false))
             .ForMember(destino =>
                destino.Softsys,
                opt => opt.MapFrom(origen => origen.Softsys == 1 ? true : false))
             .ForMember(destino =>
                destino.Softflex,
                opt => opt.MapFrom(origen => origen.Softflex == 1 ? true : false)
            );
            #endregion
        }

    }
}
