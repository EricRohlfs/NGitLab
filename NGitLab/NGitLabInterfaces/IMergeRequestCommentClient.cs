using System.Collections.Generic;
using NGitLabInterfaces.Models;

namespace NGitLabInterfaces
{
    public interface IMergeRequestCommentClient
    {
        IEnumerable<Comment> All { get; }

        Comment Add(MergeRequestComment comment);
    }
}