using ExemploMvcEplayers.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Players_AspNETCore.Controllers
{
    [Route("Login")]
    public class LoginController : Controller
    {
        Jogador jogadorModel = new Jogador();

        public IActionResult Index()
        {
            return View();
        }
    [Route("Logar")]
        public IActionResult Logar(IFormCollection form)
        {
            return LocalRedirect("~/");
        }
    }
}