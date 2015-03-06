using System;

namespace NGitLabInterfaces.Models
{
    [DataContract]
    public class ProjectHookUpsert
    {
        [Required]
        [DataMember(Name = "url")]
        public Uri Url;

        [DataMember(Name = "push_events")]
        public bool PushEvents;
        
        [DataMember(Name = "merge_requests_events")]
        public bool MergeRequestsEvents;
    }
}