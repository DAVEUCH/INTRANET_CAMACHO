using System.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SistemaVenta.AplicacionWeb.Models.ViewModels;
using SistemaVenta.DAL.DBContext;

namespace SistemaVenta.AplicacionWeb.Controllers
{
    [Authorize]
    public class ColectorController : Controller
    {
        private readonly PostDbContext _context;

        public ColectorController(PostDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ListarAlmacenes()
        {
            var almacenes = await _context.Almacen
                .AsNoTracking() // ✅ evita tracking innecesario
                .Where(a => new[] { 3, 5, 6, 7, 51 }.Contains(a.Pkid))
                .Select(a => new VMAlmacenCombo
                {
                    Id = a.Pkid,
                    Descripcion = a.Codigo.Trim() + " - " + a.Nombre.Trim()
                })
                .ToListAsync();

            return Json(almacenes);
        }

        [HttpPost]
        public async Task<IActionResult> Lista(int idAlmacen, DateTime fechaInicio, DateTime fechaFin)
        {
            var p1 = new SqlParameter("@IDAlmacen", idAlmacen);
            var p2 = new SqlParameter("@Fecha_Ini", fechaInicio);
            var p3 = new SqlParameter("@Fecha_Fin", fechaFin);

            var data = new List<VMColector>();
            using (var conn = _context.Database.GetDbConnection())
            {
                await conn.OpenAsync();
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = "usp_GC_M_Colectores_show_Almacen_Fechas";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(p1);
                    command.Parameters.Add(p2);
                    command.Parameters.Add(p3);

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            data.Add(new VMColector
                            {
                                Empresa = reader["Empresa"].ToString(),
                                Almacen = reader["Almacen"].ToString(),
                                Ubicacion = reader["Ubicacion"].ToString(),
                                Producto = reader["Producto"].ToString(),
                                Cantidad = Convert.ToInt32(reader["Cantidad"]),
                                Fecha = reader["Fecha"].ToString()
                            });
                        }
                    }
                }
            }

            return Json(new { data });
        }
    }

}
