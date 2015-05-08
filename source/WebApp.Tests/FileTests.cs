using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace WebApp.Tests
{
    [TestClass]
    public class FileTests
    {
        [TestMethod]
        public void Exists_ReturnsTrue_IsTrue()
        {
            var mockFile = new Mock<IFileProxy>();
            mockFile.Setup(x => x.Exists("abc")).Returns(true);
            var result = mockFile.Object.Exists("abc");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Exists_ReturnsFalse_IsFalse()
        {
            var mockFile = new Mock<IFileProxy>();
            mockFile.Setup(x => x.Exists("abc")).Returns(false);
            var result = mockFile.Object.Exists("abc");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void AppendAllLines_IsCalled()
        {
            var mockFile = new Mock<IFileProxy>();
            const string input1 = "abc";
            var input2 = new List<string>();
            mockFile.Setup(x => x.AppendAllLines(input1, input2));
            mockFile.Object.AppendAllLines(input1, input2);
            mockFile.VerifyAll();
        }
        [TestMethod]
        public void AppendAllText_IsCalled()
        {
            var mockFile = new Mock<IFileProxy>();
            const string input1 = "abc";
            const string input2 = "abc";
            mockFile.Setup(x => x.AppendAllText(input1, input2));
            mockFile.Object.AppendAllText(input1, input2);
            mockFile.VerifyAll();
        }
        [TestMethod]
        public void GetAccessControl_ReturnsFileSecurity()
        {
            var mockFile = new Mock<IFileProxy>();
            const string input1 = "abc";
            var output = new FileSecurity();            
            mockFile.Setup(x => x.GetAccessControl(input1)).Returns(output);
            var result = mockFile.Object.GetAccessControl(input1);
            mockFile.VerifyAll();
            Assert.AreSame(output, result);
        }
        [TestMethod]
        public void GetLastAccessTimeUtc_ReturnsDateTime()
        {
            var mockFile = new Mock<IFileProxy>();
            const string input1 = "abc";
            var output = DateTime.Parse("1/1/2015");
            mockFile.Setup(x => x.GetLastAccessTimeUtc(input1)).Returns(output);
            var result = mockFile.Object.GetLastAccessTimeUtc(input1);
            mockFile.VerifyAll();
            Assert.AreEqual(output, result);
        }
        [TestMethod]
        public void Open_ReturnsFileStream()
        {
            var mockFile = new Mock<IFileProxy>();
            const string input1 = "abc";
            const FileMode input2 = FileMode.Open;
            var output = new FileStream("def", FileMode.Create);
            mockFile.Setup(x => x.Open(input1, input2)).Returns(output);
            var result = mockFile.Object.Open(input1, input2);
            mockFile.VerifyAll();
            Assert.AreEqual(output, result);
        }
        [TestMethod]
        public void ReadAllLines_ReturnsStringArray()
        {
            var mockFile = new Mock<IFileProxy>();
            const string input1 = "abc";
            var output = new[] { "1", "2", "3" };
            mockFile.Setup(x => x.ReadAllLines(input1, Encoding.UTF8)).Returns(output);
            var result = mockFile.Object.ReadAllLines(input1, Encoding.UTF8);
            mockFile.VerifyAll();
            Assert.AreEqual(output, result);
        }
    }
}
