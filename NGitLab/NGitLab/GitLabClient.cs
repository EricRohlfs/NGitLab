using NGitLab.Impl;
using NGitLabInterfaces;

namespace NGitLab
{
    public interface IGitLabClient
    {
        IRepositoryClient GetRepository(int projectId);
        IMergeRequestClient GetMergeRequest(int projectId);
        IProjectClient GetProjects();
        IUserClient GetUsers();
    }

    public class GitLabClient : IGitLabClient
    {
        public GitLabClient(string hostUrl, string apiToken)
        {
            _api = new API(hostUrl, apiToken);
            Users = new UserClient(_api);
            Projects = new ProjectClient(_api);
        }


        public static GitLabClient Connect(string hostUrl, string apiToken)
        {
            return new GitLabClient(hostUrl, apiToken);
        }

        public static GitLabClient Connect(string hostUrl, string apiToken, bool ignoreInvalidCert)
        {
            return new GitLabClient(hostUrl, apiToken,ignoreInvalidCert);
        }

        private readonly API _api;

        public readonly IUserClient Users;
        public readonly IProjectClient Projects;

        public GitLabClient(string hostUrl, string apiToken, bool ignoreInvalidCert)
        {
            _api = new API(hostUrl, apiToken,ignoreInvalidCert);
            Users = new UserClient(_api);
            Projects = new ProjectClient(_api);
        }

        public IRepositoryClient GetRepository(int projectId)
        {
            return new RepositoryClient(_api, projectId);
        }

        public IMergeRequestClient GetMergeRequest(int projectId)
        {
            return new MergeRequestClient(_api, projectId);
        }

        public IProjectClient GetProjects()
        {
            return Projects;
        }

        public IUserClient GetUsers()
        {
            return Users;
        }
    }
}