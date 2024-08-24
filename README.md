# Exercise 3: Notification System with In-Memory Pub/Sub

## Giới Thiệu

Bài tập này yêu cầu phát triển một hệ thống thông báo cho nền tảng mạng xã hội. Hệ thống sẽ thông báo cho người dùng khi một bài đăng mới được xuất bản bởi người mà họ theo dõi. 

## Yêu Cầu

- **Publisher**: Khi người dùng tạo một bài đăng mới, hệ thống phải phát hành thông báo đến tất cả người theo dõi.
- **Subscriber**: Mỗi người theo dõi phải nhận được thông báo chứa nội dung bài đăng và thông tin tác giả.
- **Unit Test**: Viết các bài kiểm tra đơn vị để xác minh rằng các người theo dõi nhận được thông báo chính xác.

**Mô hình người dùng**: `Id`, `Name`, danh sách các ID người dùng được theo dõi.  
**Mô hình bài đăng**: `Id`, `UserId`, `Content`, `Timestamp`.
