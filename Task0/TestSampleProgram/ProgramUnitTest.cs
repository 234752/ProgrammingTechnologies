using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleProgram;

namespace TestSampleProgram
{
    [TestClass]
    public class ProgramUnitTest
    {
        [TestMethod]
        public void TestIsEven102()
        {
            SampleProgram.Program program = new Program();
            bool testedValue = program.IsEven(102);
            Assert.IsTrue(testedValue);
        }

        [TestMethod]
        public void TestIsEven1337()
        {
            SampleProgram.Program program = new Program();
            bool testedValue = program.IsEven(1337);
            Assert.IsFalse(testedValue);
        }
    }
}