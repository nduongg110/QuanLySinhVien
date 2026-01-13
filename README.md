Phần mềm quản lý sinh viên được xây dựng bằng Windows Forms kết hợp với ADO.NET để kết nối và thao tác với cơ sở dữ liệu SQL Server. 
Dự án này giúp quản lý thông tin sinh viên một cách trực quan, dễ sử dụng và phù hợp với các bài tập hoặc đồ án môn học về lập trình ứng dụng.

Công nghệ sử dụng
- *Ngôn ngữ: C# (.NET Framework)
- Giao diện: Windows Forms
- Cơ sở dữ liệu: SQL Server
- Kết nối DB: ADO.NET

Tính năng chính
- Thêm, sửa, xóa thông tin sinh viên
- Tìm kiếm sinh viên theo mã hoặc tên
- Hiển thị danh sách sinh viên theo lớp/khoa
- Kết nối và thao tác dữ liệu bằng ADO.NET
- Giao diện thân thiện, dễ sử dụng

Hướng dẫn cài đặt
1. Clone hoặc tải về dự án:
   ```bash
   git clone https://github.com/nduongg110/QuanLySinhVien.git
   ```
2. Mở file `QuanLySinhVien.sln` bằng Visual Studio.
3. Chạy script `QuanLySinhVien.sql` trong SQL Server để tạo cơ sở dữ liệu.
4. Cập nhật chuỗi kết nối trong file `App.config` hoặc trong phần code để phù hợp với cấu hình SQL Server của bạn.
5. Build và chạy ứng dụng.
