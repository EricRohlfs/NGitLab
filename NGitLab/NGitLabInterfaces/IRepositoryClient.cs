using System;
using System.IO;

namespace NGitLabInterfaces
{
    public interface IRepositoryClient
    {
        IEnumerable<Tag> Tags { get; }
        IEnumerable<TreeOrBlob> Tree { get; }
        void GetRawBlob(string sha, Action<Stream> parser);
        
        IEnumerable<Commit> Commits { get; }
        SingleCommit GetCommit(Sha1 sha);
        IEnumerable<Diff> GetCommitDiff(Sha1 sha);

        IFilesClient Files { get; }

        IBranchClient Branches { get; }

        IProjectHooksClient ProjectHooks { get; }
    }
}