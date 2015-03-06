using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NGitLabInterfaces.Models;

namespace NGitLabInterfaces
{
    public interface IProjectRepo
    {
        IEnumerable<Project> GetAll();
        //IEnumerable<Project> GetOwned();
        //IEnumerable<Project> GetAccessible();
        //IEnumerable<Project> Create(Project proj);

    }
   
}
