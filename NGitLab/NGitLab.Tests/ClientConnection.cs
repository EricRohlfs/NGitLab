using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
