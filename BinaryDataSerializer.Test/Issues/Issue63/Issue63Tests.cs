﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryDataSerialization.Test.Issues.Issue63
{
    [TestClass]
    public class Issue63Tests : TestBase
    {
        [TestMethod]
        public void PaddingTest()
        {
            var testingClass = new TestingClass
            {
                Field1 = new byte[] { 0x01 },
                Field2 = new byte[] { 0x99, 0x98, 0x97, 0x96, 0x95, 0x94 }
            };

            Roundtrip(testingClass, new byte[] { 0x01, 0x00, 0x99, 0x98, 0x97, 0x96, 0x95, 0x94 });
        }
    }
}
