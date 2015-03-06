using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NGitLab.Impl;
using NGitLabInterfaces;
using NUnit.Framework;

namespace NGitLab.Tests.RepositoryClient
{
   public class ClientConnection
    {

       [Test]
       public void CanConnectWithInvalidCert()
       {
           var ignoreInvalidCert = true;
           var c = new GitLabClient(string.Empty, string.Empty, ignoreInvalidCert);
       }	

       [Test]
       public void foo()
       {
           Assert.IsTrue(true);
       }

       [Test]
       public void CanGetProjectsFromClientThroughNonStaticClass()
       {
           var pb = new Mock<IProjectRepo>();


       }
    }
}
