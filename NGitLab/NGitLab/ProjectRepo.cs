using System;
using System.Collections.Generic;
using System.IO;
using NGitLab.Impl;
using NGitLabInterfaces;
using NGitLabInterfaces.Models;
using Newtonsoft.Json;

namespace NGitLab
{
   public class ProjectRepo: IProjectRepo
    {
       public ConnectionInfo Info { get; set; }
       public IWebRequestWrap Request { get; set; }

       public ProjectRepo(ConnectionInfo info,IWebRequestWrap req)
       {
           Info = info;
           Request = req;
       }
       public IEnumerable<Project> GetAll()
       {
           var results = new List<Project>();
           var projectStr = Info.Host;
           var uri = new Uri(projectStr);

           Request.Create(uri);
           Request.AddHeader("PRIVATE-TOKEN", Info.Token);
           Request.SetMethod(MethodType.Get);
           Deserialize(results);

           return results;
       }

       public void Deserialize(List<Project> results)
       {
           using (var resp = Request.GetResponse())
           using (var stream = resp.GetResponseStream())
           {
               var s = new StreamReader(stream).ReadToEnd();
               var proj = (Project[]) JsonConvert.DeserializeObject<Project[]>(s);
               results.AddRange(proj);
           }
       }
    }
}
