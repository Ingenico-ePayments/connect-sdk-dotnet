using NUnit.Framework;
using System;
using System.IO;

namespace Ingenico.Connect.Sdk.Logging
{
    [TestFixture]
    public class SysOutCommunicatorLoggerTest
    {
        TextWriter oldStdOut;
        TextWriter newStdOut;
        [TestCase]
        public void TestLogUnicode()
        {
            oldStdOut = Console.Out;
            newStdOut = new StringWriter();
            Console.SetOut(newStdOut);
            try
            {
                ICommunicatorLogger logger = SystemConsoleCommunicatorLogger.Instance;
                logger.Log("Schröder");
                var aString = newStdOut.ToString();
                StringAssert.EndsWith("Schröder" + Environment.NewLine, aString);
            }
            finally
            {
                Console.SetOut(oldStdOut);
            }
        }
        [TestCase]
        public void TestLog()
        {
            oldStdOut = Console.Out;
            newStdOut = new StringWriter();
            Console.SetOut(newStdOut);
            try
            {
                ICommunicatorLogger logger = SystemConsoleCommunicatorLogger.Instance;
                logger.Log("Hello world");
                var aString = newStdOut.ToString();
                StringAssert.EndsWith("Hello world" + Environment.NewLine, aString);
            }
            finally
            {
                Console.SetOut(oldStdOut);
            }
        }
        [TestCase]
        public void TestLogWithException()
        {
            oldStdOut = Console.Out;
            newStdOut = new StringWriter();
            Console.SetOut(newStdOut);
            try
            {
                ICommunicatorLogger logger = SystemConsoleCommunicatorLogger.Instance;
                var exception = new Exception();
                try{
                    throw exception;
                }
                catch (Exception e) {
                    logger.Log("Hello world", e);
                }
                var aString = newStdOut.ToString();
                StringAssert.EndsWith("Hello world" + Environment.NewLine + exception.ToString() + Environment.NewLine, aString);
            }
            finally
            {
                Console.SetOut(oldStdOut);
            }
        }
    }
}
