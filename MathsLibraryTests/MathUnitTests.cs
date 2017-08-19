using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MathsLibrary;

namespace MathsLibraryTests
{
    [TestFixture]
    public class MathUnitTests
    {
        OperationsClass opClass;
        
        [SetUp]
        public void Initialise()
        {
            opClass = new OperationsClass();
        }

        [Test]
        public void Test_Add_NonZero()
        {
            int a = 1, b = 1;
            Assert.AreEqual(2, opClass.AddInt(a, b));
        }

        [Test]
        public void Test_Div_NonZero()
        {
            int a = 1, b = 1;
            Assert.AreEqual("1", opClass.DivInt(a, b));
        }

        [Test]
        public void Test_Div_Zero()
        {
            int a = 1, b = 0;
            Assert.AreEqual("N", opClass.DivInt(a, b));
        }
    }
}
