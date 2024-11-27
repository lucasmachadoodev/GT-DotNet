using System.Diagnostics;
using System.Linq;
using GT_Visiontec.Context;
using GT_Visiontec.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GT_Visiontec.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TaskManagerContext context;

        public HomeController(ILogger<HomeController> logger, TaskManagerContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            // selecionar com eager loading
            var group = context.Group
                .Where(g => g.Id == 1)
                .Include(g => g.GroupUsers)
                .ThenInclude(gu => gu.User)
                .FirstOrDefault();
            
            // selecionar
            var user = context.User.Where(u => u.Name == "Murilo").FirstOrDefault();


            // delete
            /*
            context.User.Remove(user);

            context.SaveChanges();
            */

            /*
            // atualizar
            user.Password = "666555";

            context.SaveChanges();
            */

            /*
            // criar
            context.User.Add(new Models.User()
            {
                Name = "Murilo",
                Login = "murilo",
                Password = "123456"
            } );

            context.SaveChanges();
            */

            // codigo
            return View();
        }
        public IActionResult criarTarefa()
        {
            return View();
        }
        public IActionResult minhasTarefas()
        {
            return View();
        }
        public IActionResult logout()
        {
            return View();
        }
        public IActionResult dashboard()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
