namespace NGitLabInterfaces.Models
{
    [DataContract]
    public class FileDelete
    {
        [Required]
        [DataMember(Name = "file_path")]
        public string Path;
        
        [Required]
        [DataMember(Name = "branch_name")]
        public string Branch;
        
        [Required]
        [DataMember(Name = "commit_message")]
        public string CommitMessage;
    }
}