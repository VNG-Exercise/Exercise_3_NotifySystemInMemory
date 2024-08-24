namespace Exercise_3_NotifySystemInMemory
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Guid> FollowedUserIds { get; set; } = new();

        public void ReceiveNotification(Post post)
        {
            Console.WriteLine($"{Name} received a notification: {post.Content} by User {post.UserId}");
        }
    }
}
