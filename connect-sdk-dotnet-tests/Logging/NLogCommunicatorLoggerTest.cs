using System;
using System.Collections.Generic;
using System.Linq;
using Moq;
using NLog;
using NUnit.Framework;

namespace Ingenico.Connect.Sdk.Logging
{
    [TestFixture]
    public class NLogCommunicatorLoggerTest
    {
        [Test]
        public void TestLog()
        {
            var mock = new Mock<ILogger>();
            var messageList = new List<Tuple<LogLevel, string>>();
            mock.Setup(t => t.Log(It.IsAny<LogLevel>(), It.IsAny<string>())).Callback((LogLevel logLevel, string message) => messageList.Add(Tuple.Create(logLevel,message)));
            NLogCommunicatorLogger communicatorLogger = new NLogCommunicatorLogger(mock.Object, LogLevel.Info, LogLevel.Warn);
            communicatorLogger.Log("Hello world");

            Assert.That(messageList, Has.Count.EqualTo(1));

            var record = messageList.First();
            Assert.That(record.Item2, Is.EqualTo("Hello world"));
            Assert.That(record.Item1, Is.EqualTo(LogLevel.Info));
        }

        [Test]
        public void TestLogException()
        {
            var mock = new Mock<ILogger>();
            var messageList = new List<Tuple<LogLevel, string, Exception>>();
            var exception = new Exception();
            mock.Setup(t => t.Log(It.IsAny<LogLevel>(), It.IsAny<string>(), It.IsAny<Exception>(), new object[0])).Callback((LogLevel logLevel, string message, Exception e, object[] unused) => messageList.Add(Tuple.Create(logLevel, message,e)));
            NLogCommunicatorLogger communicatorLogger = new NLogCommunicatorLogger(mock.Object, LogLevel.Info, LogLevel.Warn);
            communicatorLogger.Log("Hello world", exception);
            Assert.That(messageList, Has.Count.EqualTo(1));

            var record = messageList.First();
            Assert.That(record.Item2, Is.EqualTo("Hello world"));
            Assert.That(record.Item1, Is.EqualTo(LogLevel.Warn));
            Assert.That(record.Item3, Is.SameAs(exception));
        }
    }
}
