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
    public class ReposicionStockMarcaController : Controller
    {
        private readonly PostDbContext _context;

        public ReposicionStockMarcaController(PostDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ListarMarcas()
        {
            var marca = await _context.Marca
                .AsNoTracking() // ✅ evita tracking innecesario
                .Where(a => new[] { 3, 5, 6, 7, 51 }.Contains(a.Pkid))
                .Select(a => new VMMarcaCombo
                {
                    Id = a.Pkid,
                    Descripcion = a.Codigo.Trim() + " - " + a.Descripcion.Trim()
                })
                .ToListAsync();

            return Json(marca);
        }

        [HttpPost]
        public async Task<IActionResult> Lista(int idMarca, int cantmesescomp)
        {
            var p1 = new SqlParameter("@IDMarca", idMarca);
            var p2 = new SqlParameter("@NumMesesCompra", cantmesescomp);


        var data = new List<VMReposicionMarca>();
            using (var conn = _context.Database.GetDbConnection())
            {
                await conn.OpenAsync();
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = "usp_Reposicion_Stock_Marca3";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(p1);
                    command.Parameters.Add(p2);


                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            data.Add(new VMReposicionMarca
                            {
                                Row = Convert.ToInt32(reader["Row"]),
                                CodigoMarca = reader["CodigoMarca"].ToString(),
                                Codigo = reader["Codigo"].ToString(),
                                CodigoInterno = reader["CodigoInterno"].ToString(),
                                SEGCodigoMarca = reader["SEGCodigoMarca"].ToString(),
                                Puntuación_RFM = Convert.ToDecimal(reader["Puntuación_RFM"]),
                                SCORE_RFM = Convert.ToDecimal(reader["SCORE_RFM"]),
                                SEG_RFM = Convert.ToDecimal(reader["SEG_RFM"]),
                                CantClien1 = Convert.ToInt32(reader["CantClien1"]),
                                Proveedor = reader["Proveedor"].ToString(),
                                Linea = reader["Linea"].ToString(),
                                Aplicacion = reader["Aplicacion"].ToString(),
                                Unid = reader["Unid"].ToString(),
                                UltVta_Fec = reader["UltVta_Fec"].ToString(),
                                UltCant_ingreso = Convert.ToInt32(reader["UltCant_ingreso"]),
                                UltFec_Pedido = reader["UltFec_Pedido"].ToString(),
                                UltFec_ingreso = reader["UltFec_ingreso"].ToString(),
                                MesesDemoraImpor = Convert.ToDecimal(reader["MesesDemoraImpor"]),
                                UltCant_PorLlegar = Convert.ToInt32(reader["UltCant_PorLlegar"]),
                                Fec1er_PorLlegar = reader["Fec1er_PorLlegar"].ToString(),
                                FecUlt_PorLlegar = reader["FecUlt_PorLlegar"].ToString(),
                                FechaSinStock_PorLlegar = reader["FechaSinStock_PorLlegar"].ToString(),
                                MesesPromeDemoraImpor = Convert.ToDecimal(reader["MesesPromeDemoraImpor"]),
                                PromCantVtasMes = Convert.ToDecimal(reader["PromCantVtasMes"]),
                                TotVtas_2020_FRE = Convert.ToInt32(reader["TotVtas_2020_FRE"]),
                                TotVtas_2021_FRE = Convert.ToInt32(reader["TotVtas_2021_FRE"]),
                                TotVtas_2022_FRE = Convert.ToInt32(reader["TotVtas_2022_FRE"]),
                                TotVtas_2023_FRE = Convert.ToInt32(reader["TotVtas_2023_FRE"]),
                                TotVtas_2024_FRE = Convert.ToInt32(reader["TotVtas_2024_FRE"]),
                                TotVtas_2025_FRE = Convert.ToInt32(reader["TotVtas_2025_FRE"]),
                                TotVtas_2020_GCI = Convert.ToInt32(reader["TotVtas_2020_GCI"]),
                                TotVtas_2021_GCI = Convert.ToInt32(reader["TotVtas_2021_GCI"]),
                                TotVtas_2022_GCI = Convert.ToInt32(reader["TotVtas_2022_GCI"]),
                                TotVtas_2023_GCI = Convert.ToInt32(reader["TotVtas_2023_GCI"]),
                                TotVtas_2024_GCI = Convert.ToInt32(reader["TotVtas_2024_GCI"]),
                                TotVtas_2025_GCI = Convert.ToInt32(reader["TotVtas_2025_GCI"]),
                                TotVtas_Ult3Mes = Convert.ToInt32(reader["TotVtas_Ult3Mes"]),
                                TotVtas_Ult6Mes = Convert.ToInt32(reader["TotVtas_Ult6Mes"]),
                                TotVtas_Ult12Mes = Convert.ToInt32(reader["TotVtas_Ult12Mes"]),
                                Stock_GCI = Convert.ToInt32(reader["Stock_GCI"]),
                                Stock_Freddy = Convert.ToInt32(reader["Stock_Freddy"]),
                                StockGrupo = Convert.ToInt32(reader["StockGrupo"]),
                                NumMesesComprar = Convert.ToInt32(reader["NumMesesComprar"]),
                                MesesConStock = Convert.ToInt32(reader["MesesConStock"]),
                                CantSugerida_aComprar = Convert.ToInt32(reader["CantSugerida_aComprar"]),
                                CantAComprar_Confir = Convert.ToInt32(reader["CantAComprar_Confir"]),
                                ProxPedido_FechaPide = reader["ProxPedido_FechaPide"].ToString(),
                                ProxPedido_llega = reader["ProxPedido_llega"].ToString(),
                                ProxPedido_Cant = Convert.ToInt32(reader["ProxPedido_Cant"]),
                                UltFOB_ingreso = Convert.ToDecimal(reader["UltFOB_ingreso"]),
                                UtilBruta = Convert.ToDecimal(reader["UtilBruta"]),
                                IDMarca = Convert.ToInt32(reader["IDMarca"])
                            });
                        }
                    }
                }
            }

            return Json(new { data });
        }
    }
}
