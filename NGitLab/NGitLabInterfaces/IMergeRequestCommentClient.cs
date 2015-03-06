namespace NGitLabInterfaces
{
    public interface IMergeRequestCommentClient
    {
        IEnumerable<Comment> All { get; }

        Comment Add(MergeRequestComment comment);
    }
}