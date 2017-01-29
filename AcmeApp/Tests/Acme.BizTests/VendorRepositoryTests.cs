using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class VendorRepositoryTests
    {
        [TestMethod]
        public void RetrieveValueTest()
        {
            var repository = new VendorRepository();
            var expected = 42;
            var actual = repository.RetrieveValue<int>("Select ...", 42);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RetrieveValueStringTest()
        {
            var repository = new VendorRepository();
            var expected = "Test";
            var actual = repository.RetrieveValue<string>("Select ...", "Test");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RetrieveValueObjectTest()
        {
            var repository = new VendorRepository();
            var vendor = new Vendor();
            var expected = vendor;
            var actual = repository.RetrieveValue<Vendor>("Select ...", vendor);
            Assert.AreEqual(expected, actual);
        }
    }
}