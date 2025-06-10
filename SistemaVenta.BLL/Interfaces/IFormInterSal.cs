using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVenta.Entity.Models;

namespace SistemaVenta.BLL.Interfaces
{
    public interface IFormInterSal
    {
        Task<List<FormInterSal>> Lista();
        Task<FormInterSal> Crear(FormInterSal entidad);
        Task<FormInterSal> Editar(FormInterSal entidad);
        Task<bool> Eliminar(int idFormInterSal);
    }
}
