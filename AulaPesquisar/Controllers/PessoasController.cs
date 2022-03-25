using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AulaPesquisar.Controllers
{
    public class PessoasController : Controller
    {
        private readonly Contexto db;

        public PessoasController(Contexto _db)
        {
            db = _db;   
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
