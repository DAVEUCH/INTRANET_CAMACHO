using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using SistemaVenta.AplicacionWeb.Models.ViewModels;
using SistemaVenta.AplicacionWeb.Utilidades.Response;
using SistemaVenta.BLL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using SistemaVenta.Entity.Models;
using System.Security.Claims;

namespace SistemaVenta.AplicacionWeb.Controllers
{
    [Authorize]
    public class FormInterIngreController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IFormInterIngre _formInterIngreServicio;

        public FormInterIngreController(IMapper mapper, IFormInterIngre formInterIngreServicio)
        {
            _mapper = mapper;
            _formInterIngreServicio = formInterIngreServicio;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Lista()
        {

            List<VMFormInterIngre> vmFormInterIngreLista = _mapper.Map<List<VMFormInterIngre>>(await _formInterIngreServicio.Lista());
            return StatusCode(StatusCodes.Status200OK, new { data = vmFormInterIngreLista });

        }

        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] VMFormInterIngre modelo)
        {
            GenericResponse<VMFormInterIngre> gResponse = new GenericResponse<VMFormInterIngre>();

            try
            {
                // Obtener usuario logueado
                ClaimsPrincipal claimUser = HttpContext.User;

                string idUsuario = claimUser.Claims
                    .Where(c => c.Type == ClaimTypes.NameIdentifier)
                    .Select(c => c.Value)
                    .SingleOrDefault();

                modelo.IdUsuario = int.Parse(idUsuario); // Asignar al modelo

                FormInterIngre FormInterIngre_creado = await _formInterIngreServicio.Crear(_mapper.Map<FormInterIngre>(modelo));
                modelo = _mapper.Map<VMFormInterIngre>(FormInterIngre_creado);

                gResponse.Estado = true;
                gResponse.Objeto = modelo;
            }
            catch (Exception ex)
            {
                gResponse.Estado = false;
                gResponse.Mensaje = ex.Message;
            }

            return StatusCode(StatusCodes.Status200OK, gResponse);
        }

        [HttpPut]
        public async Task<IActionResult> Editar([FromBody] VMFormInterIngre modelo)
        {
            GenericResponse<VMFormInterIngre> gResponse = new GenericResponse<VMFormInterIngre>();

            try
            {
                FormInterIngre FormInterIngre_editado = await _formInterIngreServicio.Editar(_mapper.Map<FormInterIngre>(modelo));
                modelo = _mapper.Map<VMFormInterIngre>(FormInterIngre_editado);

                gResponse.Estado = true;
                gResponse.Objeto = modelo;
            }
            catch (Exception ex)
            {
                gResponse.Estado = false;
                gResponse.Mensaje = ex.Message;
            }

            return StatusCode(StatusCodes.Status200OK, gResponse);
        }

        [HttpDelete]
        public async Task<IActionResult> Eliminar(int idFormInterIngre)
        {

            GenericResponse<string> gResponse = new GenericResponse<string>();
            try
            {
                gResponse.Estado = await _formInterIngreServicio.Eliminar(idFormInterIngre);

            }
            catch (Exception ex)
            {
                gResponse.Estado = false;
                gResponse.Mensaje = ex.Message;
            }
            return StatusCode(StatusCodes.Status200OK, gResponse);
        }
    }
}
