namespace Exercise_3_NotifySystemInMemory
{
    public class InMemoryNotificationSystem
    {
        private readonly Dictionary<Guid, List<Action<Post>>> _subscribers = [];

        public void PublishPost(Post post)
        {
            if (_subscribers.TryGetValue(post.UserId, out List<Action<Post>>? value))
            {
                foreach (var notify in value)
                    notify(post);
            }
        }

        public void Subscribe(Guid userId, Action<Post> notificationHandler)
        {
            if (!_subscribers.TryGetValue(userId, out List<Action<Post>>? value))
            {
                value = [];
                _subscribers[userId] = value;
            }

            value.Add(notificationHandler);
        }
    }
}
