using System.Collections.Generic;
using NGitLabInterfaces.Models;

namespace NGitLabInterfaces
{
    public interface IProjectHooksClient
    {
        IEnumerable<ProjectHook> All { get; }
        ProjectHook this[int hookId] { get; }
        ProjectHook Create(ProjectHookUpsert hook);
        ProjectHook Update(int hookId, ProjectHookUpsert hook);
        void Delete(int hookId);
    }
}