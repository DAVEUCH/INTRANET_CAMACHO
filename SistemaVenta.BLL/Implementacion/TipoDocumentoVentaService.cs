﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaVenta.BLL.Interfaces;
using SistemaVenta.DAL.Interfaces;
using SistemaVenta.Entity.Models;


namespace SistemaVenta.BLL.Implementacion
{
    public class TipoDocumentoVentaService : ITipoDocumentoVentaService
    {
        private readonly IGenericRepository<TipoDocumentoVenta> _repositorio;

        public TipoDocumentoVentaService(IGenericRepository<TipoDocumentoVenta> repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<List<TipoDocumentoVenta>> Lista()
        {
            IQueryable<TipoDocumentoVenta> query = await _repositorio.Consultar();
            return query.ToList();
        }
    }
}
