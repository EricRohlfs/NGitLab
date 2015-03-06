using System.Collections.Generic;
using NGitLabInterfaces.Models;

namespace NGitLabInterfaces
{
    public interface IUserClient
    {
        IEnumerable<User> All { get; }
        User this[int id] { get; }
        User Create(UserUpsert user);
        User Update(int id, UserUpsert user);
        void Delete(int id);

        Session Current { get; }
    }
}