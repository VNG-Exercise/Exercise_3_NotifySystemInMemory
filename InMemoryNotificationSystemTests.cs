using Xunit;

namespace Exercise_3_NotifySystemInMemory
{
    public class InMemoryNotificationSystemTests
    {
        [Fact]
        public void TestSubscribersReceiveNotifications()
        {
            var notificationSystem = new InMemoryNotificationSystem();

            var user1 = new User { Id = Guid.NewGuid(), Name = "Thai Vu" };
            var user2 = new User { Id = Guid.NewGuid(), Name = "Ka Tham" };

            var receivedPostsByUser2 = new List<Post>();

            notificationSystem.Subscribe(user1.Id, receivedPostsByUser2.Add);

            var post1 = new Post
            {
                Id = Guid.NewGuid(),
                UserId = user1.Id,
                Content = $"{user1.Name} is first post",
                Timestamp = DateTime.Now
            };
            notificationSystem.PublishPost(post1);

            Assert.Single(receivedPostsByUser2);
            Assert.Equal(post1.Content, receivedPostsByUser2[0].Content);
        }
    }
}
