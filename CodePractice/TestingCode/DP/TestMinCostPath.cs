using CodePractice.Dynamic_Programming;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingCode.DP
{
    public class TestMinCostPath
    {
        [Test]
        public void TestMCP1()
        {
            var mcp = new MinCostPath();
            int[,] cost = { {1, 2, 3},
                            {4, 8, 2},
                            {1, 5, 3}};
            
            Assert.AreEqual(8, mcp.MCP(cost, 2, 2));
        }

        [Test]
        public void TestMCP2()
        {
            var mcp = new MinCostPath();
            int[,] cost = {   {1, 8, 8, 1, 5},
                              {4, 1, 1, 8, 1},
                              {4, 2, 8, 8, 1},
                              {1, 5, 8, 8, 1} };

            Assert.AreEqual(12, mcp.MCP(cost, 3, 4));
        }
    }
}
