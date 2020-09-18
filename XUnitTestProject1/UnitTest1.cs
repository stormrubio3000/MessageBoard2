using System;
using Xunit;
using System.Collections.Generic;

using WebApplication2.Controllers;
using WebApplication2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void IndexTestPass()
        {
            Board board = new Board();
            HomeController controler = new HomeController(board);

            var result = controler.Index();

            Assert.NotNull(result);
        }

        [Fact]
        public void MessageTestPass() {
            Board board = new Board();
            HomeController controller = new HomeController(board);
            board.comments.Add(new Comment { comment = "something"});

            ViewResult result = controller.Index(new Comment { comment = "else" }) as ViewResult;

            Board resultBoard = result.ViewData.Model as Board;

            Assert.Equal("something", resultBoard.comments[0].comment);
            Assert.Equal("else", resultBoard.comments[1].comment);
        }
    }
}
