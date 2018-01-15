using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using the;
using System.Collections.Generic;
using System.Linq;

namespace the_test
{
    [TestClass]
    public class DummyTest
    {

        [TestMethod]
        public void testSomething()
        {
            var myDummy = new Dummy(1);
            Assert.AreEqual(1,myDummy.id);
            //Assert.AreEqual(1, solution2.moves.Count);
            //CollectionAssert.AreNotEqual(solution2.initialState, solution2.solutionSequence);
            //CollectionAssert.AreEqual(solution1.solutionSequence, solution2.solutionSequence);                        
        }

    }
}
