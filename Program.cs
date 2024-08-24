using Exercise_3_NotifySystemInMemory;

var platForm = new SocialMediaPlatform();

var user1 = new User { Id = Guid.NewGuid(), Name = "Vu Kha Chanh Thai" };
var user2 = new User { Id = Guid.NewGuid(), Name = "Thuy Linh" };

platForm.FollowUser(user1, user2);

platForm.CreatePost(user2, $"New Post Create From {user2.Name}");

Console.ReadLine();
