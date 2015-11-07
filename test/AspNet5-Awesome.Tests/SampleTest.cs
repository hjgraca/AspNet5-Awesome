using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace AspNet5_Awesome.Tests
{
    public class SampleTest
    {
        [Fact]
        public void Test1()
        {
        	Assert.True(true);
        }
        
        [Fact]
        public void Test2()
        {
        	Assert.True(false);
        }
    }
}
