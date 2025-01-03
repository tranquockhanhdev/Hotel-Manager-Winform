# Báo Cáo Đồ Án: Phần Mềm Đặt Phòng Khách Sạn
File Báo Cáo
https://docs.google.com/document/d/1F2ZaNzEcTFH8zTPPx4mrkw-WyVCke9tC/edit?usp=drive_link&ouid=101800604296951103835&rtpof=true&sd=true
## Giới Thiệu
Dự án "Phần Mềm Đặt Phòng Khách Sạn" được phát triển theo mô hình 3 lớp (BLL, DAL, DTO), nhằm hỗ trợ khách hàng đặt phòng một cách nhanh chóng, tiện lợi, và cung cấp công cụ quản lý hiệu quả cho Admin khách sạn.

## Thành Viên Nhóm
- **Nhóm Trưởng:** Trần Quốc Khánh - 0306221031
- **Thành Viên:**
  - Trần Thiện Hữu Dũng - 0306221009
  - Lê Hoàng Khang - 0306221030
- **Lớp:** CDTH22WEBB
- **Khóa:** 2022 - 2025

## Mô Hình 3 Lớp
### 1. Data Transfer Object (DTO)
- Đại diện cho dữ liệu với các thuộc tính cơ bản (getter, setter).
- **Ví dụ:**
  - `PhongDTO`: Mã phòng, tên phòng, diện tích, trạng thái...
  - `DichVuDTO`: Mã dịch vụ, tên dịch vụ, giá tiền...

### 2. Data Access Layer (DAL)
- Quản lý giao tiếp với cơ sở dữ liệu, thực hiện các truy vấn.
- **Ví dụ:**
  - `PhongDAL`: Thêm, sửa, xóa, tra cứu phòng.
  - `DichVuDAL`: Thực hiện các truy vấn liên quan đến dịch vụ.

### 3. Business Logic Layer (BLL)
- Xử lý logic nghiệp vụ, kết nối giữa DAL và giao diện người dùng.
- **Ví dụ:**
  - `PhongBLL`: Gọi DAL và xử lý dữ liệu trước khi trả về giao diện.
  - `DichVuBLL`: Quản lý các nghiệp vụ liên quan đến dịch vụ.

## Tính Năng Chính
### Chức Năng Cho Khách Hàng
- Đăng ký, đăng nhập, quên mật khẩu.
- Tìm kiếm và đặt phòng theo loại, số lượng, thời gian, và dịch vụ đi kèm.
- Thanh toán và nhận thông tin đặt phòng chi tiết.

### Chức Năng Cho Admin
- **Quản lý phòng:** Thêm, xóa, cập nhật trạng thái và số lượng phòng.
- **Quản lý loại phòng:** Thêm, xóa, cập nhật loại phòng.
- **Quản lý dịch vụ:** Thêm, xóa, cập nhật các dịch vụ khách sạn.
- **Quản lý đặt phòng:** Duyệt và cập nhật tình trạng phòng khi có đơn đặt phòng.
- **Quản lý hóa đơn:** Tạo, chỉnh sửa, và quản lý hóa đơn khách hàng.

## Công Nghệ Sử Dụng
- **Ngôn ngữ lập trình:** C# (WinForms)
- **Cơ sở dữ liệu:** SQL Server
- **Kiến trúc:** Mô hình 3 lớp (BLL, DAL, DTO)
- **Công cụ thiết kế:** Visual Studio

## Hướng Dẫn Cài Đặt
### Yêu Cầu Hệ Thống
- Hệ điều hành: Windows 10 hoặc mới hơn.
- Visual Studio 2019 trở lên.
- SQL Server 2019 trở lên.

### Các Bước Cài Đặt
1. **Clone Dự Án**
   ```bash
   git clone https://github.com/your-repo/hotel-booking-system.git
   cd hotel-booking-system
2. **Cài CSDL**
   https://drive.google.com/file/d/14gtJvhUkmHBoWelco3Qcai47UtzdCjPP/view?usp=drive_link
### Hình Ảnh Giao Diện
![image](https://github.com/user-attachments/assets/80537e4a-be16-4185-9158-44849c432647)
![image](https://github.com/user-attachments/assets/6b3dc8dd-a32d-4622-b246-7a73063c48db)
![image](https://github.com/user-attachments/assets/3eeee601-b987-4567-a5cb-7e563e643f22)
![image](https://github.com/user-attachments/assets/e437d98e-99a4-4e6e-b512-6fe4640d9121)
![image](https://github.com/user-attachments/assets/feb89467-ae70-48f1-b9c3-9344b44fe173)
![image](https://github.com/user-attachments/assets/1651a43c-9367-4905-b8f3-a0bafa4a8c86)
![image](https://github.com/user-attachments/assets/a31acc6c-883e-47e3-b18d-a6cc8e823b5c)
![image](https://github.com/user-attachments/assets/01e68617-1635-42f3-a395-dca18e850e45)

   
   
