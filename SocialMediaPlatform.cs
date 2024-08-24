namespace Exercise_3_NotifySystemInMemory
{
    public class SocialMediaPlatform
    {
        private readonly InMemoryNotificationSystem _notificationSystem = new();

        public void CreatePost(User user, string content)
        {
            var post = new Post
            {
                Id = Guid.NewGuid(),
                UserId = user.Id,
                Content = content,
                Timestamp = DateTime.Now
            };

            _notificationSystem.PublishPost(post);
        }

        public void FollowUser(User follower, User followee)
        {
            _notificationSystem.Subscribe(followee.Id, follower.ReceiveNotification);

            follower.FollowedUserIds.Add(followee.Id);
        }
    }
}
