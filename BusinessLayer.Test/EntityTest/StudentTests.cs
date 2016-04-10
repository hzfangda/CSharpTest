using BusinessLayer.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.Test.EntityTest
{
    [TestFixture]
    public class StudentTests
    {
        [Test]
        public void Add()
        {
            var student = new Student();

            int a = 10;
            int b = 20;
            Assert.AreEqual(30, student.Add(a, b));
        }
    }
}
