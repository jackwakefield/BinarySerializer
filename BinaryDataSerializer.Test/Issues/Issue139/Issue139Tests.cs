﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryDataSerialization.Test.Issues.Issue139
{
    [TestClass]
    public class Issue139Tests : TestBase
    {
        [TestMethod]
        public void Test()
        {
            var expected = new Question();
            var actual = Roundtrip(expected);
        }
    }
}
