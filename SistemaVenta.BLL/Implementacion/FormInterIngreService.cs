using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVenta.BLL.Interfaces;
using SistemaVenta.DAL.Interfaces;
using SistemaVenta.Entity.Models;

namespace SistemaVenta.BLL.Implementacion
{
    public class FormInterIngreService :IFormInterIngre
    {
        private readonly IGenericRepository<FormInterIngre> _repositorio;

        public FormInterIngreService(IGenericRepository<FormInterIngre> repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<List<FormInterIngre>> Lista()
        {

            //IQueryable<FormInterIngre> query = await _repositorio.Consultar();
            IQueryable<FormInterIngre> query = await _repositorio.Consultar(incluirPropiedades: "IdUsuarioNavigation");


            return query.ToList();

        }

        public async Task<FormInterIngre> Crear(FormInterIngre entidad)
        {
            try
            {
                FormInterIngre FormInterIngre_creado = await _repositorio.Crear(entidad);
                if (FormInterIngre_creado.IdFormInterIngre == 0)
                    throw new TaskCanceledException("No se pudo crear el documento");

                return FormInterIngre_creado;
            }
            catch
            {
                throw;
            }
        }

        public async Task<FormInterIngre> Editar(FormInterIngre entidad)
        {
            try
            {
                FormInterIngre FormInterIngre_encontrado = await _repositorio.Obtener(c => c.IdFormInterIngre == entidad.IdFormInterIngre);
                FormInterIngre_encontrado.NombPersona = entidad.NombPersona;
                FormInterIngre_encontrado.ApePersona = entidad.ApePersona;
                FormInterIngre_encontrado.FechaIng = entidad.FechaIng;
                FormInterIngre_encontrado.DniPersona = entidad.DniPersona;
                FormInterIngre_encontrado.AreaPersona = entidad.AreaPersona;
                FormInterIngre_encontrado.CargPersona = entidad.CargPersona;
                FormInterIngre_encontrado.TipoPuesto = entidad.TipoPuesto;
                FormInterIngre_encontrado.Hardwlapt = entidad.Hardwlapt;
                FormInterIngre_encontrado.Hardwcompu = entidad.Hardwcompu;
                FormInterIngre_encontrado.Hardwcel = entidad.Hardwcel;
                FormInterIngre_encontrado.Softoffice = entidad.Softoffice;
                FormInterIngre_encontrado.SoftAntiv = entidad.SoftAntiv;
                FormInterIngre_encontrado.Softadob = entidad.Softadob;
                FormInterIngre_encontrado.Softcorr = entidad.Softcorr;
                FormInterIngre_encontrado.Softsys = entidad.Softsys;
                FormInterIngre_encontrado.Softflex = entidad.Softflex;
                FormInterIngre_encontrado.Observacion = entidad.Observacion;
                FormInterIngre_encontrado.IdUsuario = entidad.IdUsuario;
                FormInterIngre_encontrado.Estado = entidad.Estado;

                bool respuesta = await _repositorio.Editar(FormInterIngre_encontrado);

                if (!respuesta)
                    throw new TaskCanceledException("No se pudo modificar el domcumento");

                return FormInterIngre_encontrado;
            }
            catch
            {
                throw;
            }
        }

        public async Task<bool> Eliminar(int idFormInterIngre)
        {
            try
            {
                FormInterIngre FormInterIngre_encontrado = await _repositorio.Obtener(c => c.IdFormInterIngre == idFormInterIngre);

                if (FormInterIngre_encontrado == null)
                    throw new TaskCanceledException("El registro no existe");

                bool respuesta = await _repositorio.Eliminar(FormInterIngre_encontrado);

                return respuesta;
            }
            catch
            {
                throw;
            }
        }

    }
}
