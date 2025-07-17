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

        private int SafeToInt(object value)
        {
            int result;
            return int.TryParse(value?.ToString(), out result) ? result : 0;
        }

        private decimal SafeToDecimal(object value)
        {
            decimal result;
            return decimal.TryParse(value?.ToString(), out result) ? result : 0;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ListarMarcas()
        {
            var marcas = await _context.Marca
                .AsNoTracking()
                .Select(m => new VMMarcaCombo
                {
                    Id = m.Pkid,
                    Descripcion = m.Descripcion.Trim()
                })
                .ToListAsync();

            return Json(marcas);
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
                                Row = SafeToInt(reader["Row"]),
                                CodigoMarca = reader["CodigoMarca"].ToString(),
                                Codigo = reader["Codigo"].ToString(),
                                CodigoInterno = reader["CodigoInterno"].ToString(),
                                SEGCodigoMarca = reader["SEGCodigoMarca"].ToString(),
                                Puntuación_RFM = SafeToDecimal(reader["Puntuación_RFM"]),
                                SCORE_RFM = SafeToDecimal(reader["SCORE_RFM"]),
                                SEG_RFM = SafeToDecimal(reader["SEG_RFM"]),
                                CantClien1 = SafeToInt(reader["CantClien1"]),
                                Proveedor = reader["Proveedor"].ToString(),
                                Linea = reader["Linea"].ToString(),
                                Aplicacion = reader["Aplicacion"].ToString(),
                                Unid = reader["Unid"].ToString(),
                                UltVta_Fec = reader["UltVta_Fec"].ToString(),
                                UltCant_ingreso = SafeToInt(reader["UltCant_ingreso"]),
                                UltFec_Pedido = reader["UltFec_Pedido"].ToString(),
                                UltFec_ingreso = reader["UltFec_ingreso"].ToString(),
                                MesesDemoraImpor = SafeToDecimal(reader["MesesDemoraImpor"]),
                                UltCant_PorLlegar = SafeToInt(reader["UltCant_PorLlegar"]),
                                Fec1er_PorLlegar = reader["Fec1er_PorLlegar"].ToString(),
                                FecUlt_PorLlegar = reader["FecUlt_PorLlegar"].ToString(),
                                FechaSinStock_PorLlegar = reader["FechaSinStock_PorLlegar"].ToString(),
                                MesesPromeDemoraImpor = SafeToDecimal(reader["MesesPromeDemoraImpor"]),
                                PromCantVtasMes = SafeToDecimal(reader["PromCantVtasMes"]),
                                TotVtas_2020_FRE = SafeToInt(reader["TotVtas_2020_FRE"]),
                                TotVtas_2021_FRE = SafeToInt(reader["TotVtas_2021_FRE"]),
                                TotVtas_2022_FRE = SafeToInt(reader["TotVtas_2022_FRE"]),
                                TotVtas_2023_FRE = SafeToInt(reader["TotVtas_2023_FRE"]),
                                TotVtas_2024_FRE = SafeToInt(reader["TotVtas_2024_FRE"]),
                                TotVtas_2025_FRE = SafeToInt(reader["TotVtas_2025_FRE"]),
                                TotVtas_2020_GCI = SafeToInt(reader["TotVtas_2020_GCI"]),
                                TotVtas_2021_GCI = SafeToInt(reader["TotVtas_2021_GCI"]),
                                TotVtas_2022_GCI = SafeToInt(reader["TotVtas_2022_GCI"]),
                                TotVtas_2023_GCI = SafeToInt(reader["TotVtas_2023_GCI"]),
                                TotVtas_2024_GCI = SafeToInt(reader["TotVtas_2024_GCI"]),
                                TotVtas_2025_GCI = SafeToInt(reader["TotVtas_2025_GCI"]),
                                TotVtas_Ult3Mes = SafeToInt(reader["TotVtas_Ult3Mes"]),
                                TotVtas_Ult6Mes = SafeToInt(reader["TotVtas_Ult6Mes"]),
                                TotVtas_Ult9Mes = SafeToInt(reader["TotVtas_Ult9Mes"]),
                                TotVtas_Ult12Mes = SafeToInt(reader["TotVtas_Ult12Mes"]),
                                Stock_GCI = SafeToInt(reader["Stock_GCI"]),
                                Stock_Freddy = SafeToInt(reader["Stock_Freddy"]),
                                StockGrupo = SafeToInt(reader["StockGrupo"]),
                                NumMesesComprar = SafeToInt(reader["NumMesesComprar"]),
                                MesesConStock = SafeToInt(reader["MesesConStock"]),
                                CantSugerida_aComprar = SafeToInt(reader["CantSugerida_aComprar"]),
                                CantAComprar_Confir = SafeToInt(reader["CantAComprar_Confir"]),
                                ProxPedido_FechaPide = reader["ProxPedido_FechaPide"].ToString(),
                                ProxPedido_llega = reader["ProxPedido_llega"].ToString(),
                                ProxPedido_Cant = SafeToInt(reader["ProxPedido_Cant"]),
                                UltFOB_ingreso = SafeToDecimal(reader["UltFOB_ingreso"]),
                                UtilBruta = SafeToDecimal(reader["UtilBruta"]),
                                IDMarca = SafeToInt(reader["IDMarca"])
                            });

                        }
                    }
                }
            }

            return Json(new { data });
        }
    }
}
