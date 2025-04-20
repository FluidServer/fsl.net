using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using fsl.net;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace tests
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void Test()
        {
            var Parser = new fsl.net.Parser();

            IDictionary<String, String> parsed = Parser.Parse(
                "FluidServer .fsl File, 1.0\nTest=abc\n;Test2=abc\n:Test3=abc"
            );

            IDictionary<String, String> expected = new Dictionary<String, String>
            {
                { "Version", "1" },
                { "Test", "abc" }
            };

            CollectionAssert.AreEquivalent(expected.ToList(), parsed.ToList());
        }
    }
}
