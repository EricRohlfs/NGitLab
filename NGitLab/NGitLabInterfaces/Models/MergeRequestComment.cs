namespace NGitLabInterfaces.Models
{
    [DataContract]
    public class MergeRequestComment
    {
        [DataMember(Name = "note")] 
        public string Note;
    }
}