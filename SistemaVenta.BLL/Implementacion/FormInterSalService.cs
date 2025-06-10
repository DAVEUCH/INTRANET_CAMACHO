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
    public class FormInterSalService: IFormInterSal
    {
        private readonly IGenericRepository<FormInterSal> _repositorio;

        public FormInterSalService(IGenericRepository<FormInterSal> repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<List<FormInterSal>> Lista()
        {

            IQueryable<FormInterSal> query = await _repositorio.Consultar();

            return query.ToList();

        }

        public async Task<FormInterSal> Crear(FormInterSal entidad)
        {
            try
            {
                FormInterSal FormInterSal_creado = await _repositorio.Crear(entidad);
                if (FormInterSal_creado.IdFormInterSal == 0)
                    throw new TaskCanceledException("No se pudo crear el rol");

                return FormInterSal_creado;
            }
            catch
            {
                throw;
            }
        }

        public async Task<FormInterSal> Editar(FormInterSal entidad)
        {
            try
            {
                FormInterSal FormInterSal_encontrado = await _repositorio.Obtener(c => c.IdFormInterSal == entidad.IdFormInterSal);
                FormInterSal_encontrado.NombPersona = entidad.NombPersona;
                FormInterSal_encontrado.ApePersona = entidad.ApePersona;
                FormInterSal_encontrado.FechaIng = entidad.FechaIng;
                FormInterSal_encontrado.DniPersona = entidad.DniPersona;
                FormInterSal_encontrado.AreaPersona = entidad.AreaPersona;
                FormInterSal_encontrado.CargPersona = entidad.CargPersona;
                FormInterSal_encontrado.PerfilAdpersona = entidad.PerfilAdpersona;
                FormInterSal_encontrado.Usured = entidad.Usured;
                FormInterSal_encontrado.Correocorp = entidad.Correocorp;
                FormInterSal_encontrado.Accefex = entidad.Accefex;
                FormInterSal_encontrado.Accessys = entidad.Accessys;
                FormInterSal_encontrado.Acceotro = entidad.Acceotro;
                FormInterSal_encontrado.DevdescripmodelLappc = entidad.DevdescripmodelLappc;
                FormInterSal_encontrado.DevserienumLappc = entidad.DevserienumLappc;
                FormInterSal_encontrado.Devdevuelto = entidad.Devdevuelto;
                FormInterSal_encontrado.Devnoaplica = entidad.Devnoaplica;
                FormInterSal_encontrado.Devobslappoc = entidad.Devobslappoc;
                FormInterSal_encontrado.Devdescripmodeotros = entidad.Devdescripmodeotros;
                FormInterSal_encontrado.Devdevueltootros = entidad.Devdevueltootros;
                FormInterSal_encontrado.Devserienumotros = entidad.Devserienumotros;
                FormInterSal_encontrado.Devnoaplicaotros = entidad.Devnoaplicaotros;
                FormInterSal_encontrado.Devobslappocotros = entidad.Devobslappocotros;
                FormInterSal_encontrado.Observacion = entidad.Observacion;
                FormInterSal_encontrado.IdUsuario = entidad.IdUsuario;
                FormInterSal_encontrado.Estado = entidad.Estado;



                bool respuesta = await _repositorio.Editar(FormInterSal_encontrado);

                if (!respuesta)
                    throw new TaskCanceledException("No se pudo modificar el domcumento");

                return FormInterSal_encontrado;
            }
            catch
            {
                throw;
            }
        }

        public async Task<bool> Eliminar(int idFormInterSal)
        {
            try
            {
                FormInterSal FormInterSal_encontrado = await _repositorio.Obtener(c => c.IdFormInterSal == idFormInterSal);

                if (FormInterSal_encontrado == null)
                    throw new TaskCanceledException("El registro no existe");

                bool respuesta = await _repositorio.Eliminar(FormInterSal_encontrado);

                return respuesta;
            }
            catch
            {
                throw;
            }
        }

    }
}
