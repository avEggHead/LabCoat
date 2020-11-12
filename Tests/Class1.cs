using CSharpEight;
using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Tests
{
    public class Class1
    {
        [Fact]
        public void TestOne()
        {
            Cheetah cheetah = new Cheetah();

            cheetah.SayHello();
        }
    }
}