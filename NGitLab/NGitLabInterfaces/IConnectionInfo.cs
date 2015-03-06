using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NGitLabInterfaces
{
   public class ConnectionInfo
    {
       public string Host { get; set; }
       public string Token { get; set; }
       public bool IgnoreSelfSignedCert { get; set; }
    }
}
