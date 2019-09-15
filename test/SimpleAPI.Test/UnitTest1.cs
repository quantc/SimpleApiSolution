using SimpleAPI.Controllers;
using System;
using Xunit;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();


        [Fact]
        public void GetValues()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Something else", returnValue);
        }
    }
}
