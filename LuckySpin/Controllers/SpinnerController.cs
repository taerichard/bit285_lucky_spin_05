using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LuckySpin.Models;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
        Random random;
        //TODO: Create a new instance variable of type RepoService 
        RepoService repoService = new RepoService();
        /***
         * Constructor
         * TODO: Inject a RepoService object in the Constructor parameter
         *       Set the instance variable's initial value using the parameter 
         */
        public SpinnerController(RepoService RepoService)
        {
            random = new Random(); // Notice "random" is not injected, just created here
            repoService = RepoService;
        }

        /***
         * Entry Page Action
         **/

        [HttpGet]
        public IActionResult Index()
        {
                return View();
        }

        [HttpPost]
        public IActionResult Index(Player player)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Spin", player);
            }

            return View();
        }

        /***
         * Spin Action
         **/  
        [HttpGet]       
        public IActionResult Spin(Player player)
        {
            // Create a Spin with its data
            Spin spin = new Spin
            {
                Luck = player.LuckyNumber,
                A = random.Next(1, 10),
                B = random.Next(1, 10),
                C = random.Next(1, 10),
            };
            spin.IsWinner = (spin.A == spin.Luck || spin.B == spin.Luck || spin.C == spin.Luck);


            // Store some View data
            ViewBag.Display = spin.IsWinner ? "block": "none";
            ViewBag.FirstName = player.FirstName;

            //TODO: add the spin to the Spin Repository

            repoService.AddSpins(spin);

            return View(spin);
        }

        /***
         * List Action
         */
        [HttpGet]
        public IActionResult LuckList(Spin spin)
        {
            
          
            return View(spin);
        }
    }
}

