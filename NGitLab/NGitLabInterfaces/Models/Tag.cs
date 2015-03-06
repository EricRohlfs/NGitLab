using System.Runtime.Serialization;

namespace NGitLabInterfaces.Models
{
    [DataContract]
    public class Tag
    {
        [DataMember(Name = "name")]
        public string Name;

        [DataMember(Name = "commit")]
        public CommitInfo Commit;
    }
}