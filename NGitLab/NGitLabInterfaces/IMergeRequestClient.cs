using System.Collections.Generic;
using NGitLabInterfaces.Models;

namespace NGitLabInterfaces
{
    public interface IMergeRequestClient
    {
        IEnumerable<MergeRequest> All { get; }
        IEnumerable<MergeRequest> AllInState(MergeRequestState state);
        MergeRequest this[int id] { get; }

        MergeRequest Create(MergeRequestCreate mergeRequest);
        MergeRequest Update(int mergeRequestId, MergeRequestUpdate mergeRequest);
        MergeRequest Accept(int mergeRequestId, MergeCommitMessage message);

        IMergeRequestCommentClient Comments(int mergeRequestId);
    }
}