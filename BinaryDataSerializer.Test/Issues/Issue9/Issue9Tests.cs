﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryDataSerialization.Test.Issues.Issue9
{
    [TestClass]
    public class Issue9Tests : TestBase
    {
        [TestMethod]
        public void TestMethod()
        {
            var expected = new ElementClass();
            var actual = Roundtrip(expected);
        }
    }
}
