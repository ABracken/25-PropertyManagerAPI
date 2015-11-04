using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PropertyManager.Core.Infrastructure;
using System.Linq;

namespace PropertyManger.Tests
{
    [TestClass]
    public class EntityFrameworkTests
    {
        [TestMethod]
        public void GenerateDatabaseTest()
        {
            using (var db = new PropertyManagerDbContext())
            {
                var firstProperty = db.Properties.FirstOrDefault();

                Assert.IsNull(firstProperty);
            }
        }
    }
}
