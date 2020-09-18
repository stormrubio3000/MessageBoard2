using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        Board board;

        public HomeController(Board board) {
            this.board = board;
        }

        public IActionResult Index()
        {
            return View(board);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Index(Comment comm)
        {
            // Comment com = new Comment
            // {
            //     comment = comm.comment,
            //     board = comm.board
            // };
            board.comments.Add(comm);
            return View(board);
        }
        


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
