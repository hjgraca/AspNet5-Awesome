using System;
using System.Collections.Generic;
using System.Linq;
using AspNet5_Awesome.Controllers;
using Microsoft.AspNet.Mvc;
using Xunit;

namespace AspNet5_Awesome.Tests
{
    public class HomeTest
    {
        [Fact]
        public void Test1()
        {
        	var controller = new HomeController(null);
            var result = controller.Index() as ViewResult;
            Assert.Equal("Hello",result.ViewData["Hello"]);
        }
    }
}
