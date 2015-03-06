using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NGitLabInterfaces;
using NGitLabInterfaces.Models;

namespace NGitLab.UnitTestV2
{
    [TestClass]
    public class Projects
    {
        [TestMethod]
        public void TestMethod1()
        {
            var info = new ConnectionInfo
                {
                    Host = "https://localhost",
                    IgnoreSelfSignedCert = true,
                    Token = "1234565nfiza"
                };
            var resp = new Mock<IWebResponseWrap>();
            resp.Setup(x => x.GetResponseStream()).Returns(GetJsonStrStream());

            var req = new Mock<IWebRequestWrap>();
            req.Setup(x => x.GetResponse()).Returns(resp.Object);

            var r = new ProjectRepo(info, req.Object);
            var projs = new List<Project>(r.GetAll());
            foreach (var p in projs)
            {
                Console.WriteLine("Id: {0} , Name: {1}" ,p.Id, p.Name);
            }
            
            Assert.IsTrue(projs.Count > 1);

        }

        public Stream GetJsonStrStream()
        {
           var filePath =   @"C:\Data\AllProjectsSample.json";//need to clean up data before check in.
           var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            return fileStream;
        }

       
        
    }
}
