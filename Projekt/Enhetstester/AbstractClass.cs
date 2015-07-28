using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Enhetstester
{
    [TestClass]
    public abstract class AbstractClass
    {

        [TestMethod]
        public abstract void TestIsPresent();

        [TestMethod]
        public abstract void TestIsSelected();

        [TestMethod]
        public abstract void TestIsRSS();

        [TestMethod]
        public abstract void TestIsDecimal();

        [TestMethod]
        public abstract void TestIsItInt();

        [TestMethod]
        public abstract void TestIsValid();
    }
}
