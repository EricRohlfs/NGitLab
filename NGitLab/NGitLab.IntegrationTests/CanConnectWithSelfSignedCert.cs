using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NGitLab;

namespace NGitLab.IntegrationTests
{
    [TestClass]
    public class CanConnectWithSelfSignedCert
    {
        public string Host { get; set; } 
        public string Token { get; set; }

        public CanConnectWithSelfSignedCert()
        {
            Host = "https://gitlab.example.com"; //change
            Token = "_qjAvWyFvhqHz754vVRx"; //change
        }

        [TestMethod]
        public void GivenSelfSignedCertShouldReturnMoreThanOneProject()
        {
            var client = GitLabClient.Connect(Host, Token, ignoreInvalidCert:true);
            var projects = client.Projects.All;
            var count = 0;
            foreach (var p in projects)
            {
                Console.WriteLine("Id:{0} , Name:{1}", p.Id, p.Name);
                count++;
            }

            Assert.IsTrue(count > 0);
        }

        [TestMethod]
        [ExpectedException(typeof(WebException))]
        public void GivenSelfSignedCertShouldThrowErrors()
        {
           
            var client = GitLabClient.Connect(Host, Token);
            var projects = client.Projects.All;
            var count = 0;
            foreach (var p in projects)
            {
                Console.WriteLine("Id:{0} , Name:{1}", p.Id, p.Name);
                count++;
            }

            Assert.IsTrue(count > 0);
        }
    }
}
