using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVenta.Entity.Models;

namespace SistemaVenta.BLL.Interfaces
{
    public interface IFormInterIngre
    {
        Task<List<FormInterIngre>> Lista();
        Task<FormInterIngre> Crear(FormInterIngre entidad);
        Task<FormInterIngre> Editar(FormInterIngre entidad);
        Task<bool> Eliminar(int idFormInterIngre);
    }
}
