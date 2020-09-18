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
        public void Index()
        {
            Board board = new Board();
            HomeController controler = new HomeController(board);

            var result = controler.Index(board);

            Assert.NotNull(result);



        }
    }
}
