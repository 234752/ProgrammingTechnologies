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
            bool testedValue = program.isEven(102);
            Assert.IsTrue(testedValue);
        }
    }
}