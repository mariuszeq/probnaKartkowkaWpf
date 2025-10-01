using Microsoft.VisualStudio.TestTools.UnitTesting;
using probnaKartkowkaWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probnaKartkowkaWpf.Tests
{
    [TestClass()]
    public class MainWindowTests
    {
        [TestMethod()]
        public void metodaSilniaTest()
        {
            Assert.AreEqual(720, MainWindow.metodaSilnia(6));
        }
    }
}