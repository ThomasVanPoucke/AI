using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using AI;


namespace AIUnitTest
{
    [TestClass]
    public class InteractionManagerTest
    {
        [TestMethod]
        public void TestGetID()
        {
            InteractionManager interactionManager = new InteractionManager();
            Assert.AreEqual("hello.question", interactionManager.GetID("Hello Jarvis"));
        }
    }
}
