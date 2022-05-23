using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimeTraker;
using System;


namespace TimeTrakerUnittest
{
    [TestClass]
    public class IdDAteBaseUnitTest
    {
        [TestMethod]
        public void DateStartStringTest()
        {
            // arange
            
            TasksOver tasksOver = new TasksOver(40, "ДаваймногоДней", "ага", new DateTime(2022, 5, 15, 1, 1, 58), new DateTime(2022, 5, 17, 1, 1, 58));
            string resultEX = "15/5/2022";
            // act

            string relust = tasksOver.DateStartString();

            // assert

            Assert.AreEqual(resultEX, relust);
        }


    }
}
