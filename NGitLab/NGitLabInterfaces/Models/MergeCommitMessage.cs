namespace NGitLabInterfaces.Models
{
    [DataContract]
    public class MergeCommitMessage
    {
        [DataMember(Name = "merge_commit_message")]
        public string Message;
    }
}