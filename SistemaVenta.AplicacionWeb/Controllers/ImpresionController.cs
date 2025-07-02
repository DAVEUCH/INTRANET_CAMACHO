using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using SistemaVenta.AplicacionWeb.Models.ViewModels;
using SistemaVenta.DAL.DBContext;
using SistemaVenta.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Rotativa.AspNetCore;

namespace SistemaVenta.AplicacionWeb.Controllers
{
    public class ImpresionController : Controller
    {
        private readonly DBVENTAContext _dbcontext;

        public ImpresionController (DBVENTAContext _context)
        {
            _dbcontext = _context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ImprimirFormato(int idforminteringre)
        {
            var registro = _dbcontext.FormInterIngres.FirstOrDefault(v => v.IdFormInterIngre == idforminteringre);

            if (registro == null)
                return NotFound();

            var modelo = new VMFormInterIngrePrint
            {
                IdFormInterIngre = registro.IdFormInterIngre,
                NombPersona = registro.NombPersona,
                ApePersona = registro.ApePersona,
                FechaIng = registro.FechaIng?.ToString("dd/MM/yyyy"),
                DniPersona = registro.DniPersona,
                AreaPersona = registro.AreaPersona,
                CargPersona = registro.CargPersona,
                TipoPuesto = registro.TipoPuesto == true ? "Reemplazo" : "Puesto nuevo",
                HardwLapt = registro.Hardwlapt == true ? "Sí" : "No",
                HardwCompu = registro.Hardwcompu == true ? "Sí" : "No",
                HardwCel = registro.Hardwcel == true ? "Sí" : "No",
                SoftOffice = registro.Softoffice == true ? "Sí" : "No",
                SoftAntiv = registro.SoftAntiv == true ? "Sí" : "No",
                SoftAdob = registro.Softadob == true ? "Sí" : "No",
                SoftCorr = registro.Softcorr == true ? "Sí" : "No",
                SoftSys = registro.Softsys == true ? "Sí" : "No",
                SoftFlex = registro.Softflex == true ? "Sí" : "No",
                Estado = registro.Estado == true ? "Activo" : "No Activo",
            };

            return new ViewAsPdf("ImprimirFormato", modelo)
            {
                FileName = $"Formato de Ingreso {modelo.IdFormInterIngre}.pdf",
                PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait,
                PageSize = Rotativa.AspNetCore.Options.Size.A4
            };
        }


    }
}
