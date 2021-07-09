# Tổng quan
- Đồ án môn học Nhập môn Công Nghệ Phần Mềm - GVHD: Huỳnh Ngọc Tín, Trần Khánh Nguyên:
  - Tên đề tài: Quản lý nhà sách
  - Mô tả: Quản lý cho một cửa hàng bán sách.
- Thành Viên:
  - [Đặng Hoàng Minh](https://github.com/danghoangminh) - 18520311
  - [Nguyễn Hoài Nam](https://github.com/hoainam2310) - 18521126
  - [Nguyễn Chí Dũng](https://github.com/nguyenchidungg) - 18520635
  - [Nguyễn Dương Hải](https://github.com/iamthedh7) - 19521464
- Công nghệ:
  - Ngôn ngữ: C#
  - Môi trường: .Net Framework 4.6
  - Database: SQL Server
- Mã nguồn: [https://github.com/danghoangminh/quan-li-nha-sach](https://github.com/danghoangminh/quan-li-nha-sach)

# Mục lục
# 1. Xác định bài toán
- Khảo sát hiện trạng:
  - Nhu cầu: Các cửa hàng sách cần 1 giải pháp giúp họ có thể quản lý các đầu sách và bán sách cho khách hàng.
  - Hiện trạng: Đơn vị là 1 cửa hàng sách bán lẻ, sử dụng sổ tay và trí nhớ của cá nhân con người để nhớ tất cả các đầu sách và giá bán. Hoặc chỉ có thể dùng các tài liệu Excel để quản lý 1 cách cơ bản.
  - Công nghệ đang sử dụng: Microsoft Excel hoặc không sử dụng công nghệ thông tin.
  - Hạn chế những phần mềm hiện có: Không có ứng dụng chuyên biệt cho cả 2 việc bán sách và quản lý.
- Yêu cầu hệ thống:
  - Thêm/xóa/sửa sách và thông tin sách. Nhập sách.
  - Phân loại theo tác giả, lĩnh vực, loại sách, NXB của từng đầu sách.
  - Tích hợp hệ thống thanh toán cho cửa hàng.
  - Thống kê doanh thu.
  - Quản lý tài khoản.
  - Quản lý số lượng sách tồn.
# 2. Kế hoạch, Quy trình, Công cụ
## 2.1. Quy trình Walterfall
![](https://github.com/danghoangminh/quan-li-nha-sach/blob/finalcode/model.png)

Mô hình này gồm các giai đoạn xử lý nối tiếp nhau như sau:

- Thu thập yêu cầu: xác định các yêu cầu chức năng và phi chức năng mà hệ thống phần mềm cần có.

- Phân tích yêu cầu phần mềm: xác định hệ thống phần mềm đáp ứng đúng yêu cầu của khách hàng. Giai đoạn này thực hiện phân tích, thiết kế hệ thống phần mềm.

- Thiết kế: xây dựng mô hình của phần mềm, thiết kế dữ liệu, thiết kế giao diện và thiết kế xử lý

- Phát triển: thực hiện sản phẩm dựa trên đặc tả yêu cầu và tài liệu thiết kế module.

- Testing: thực hiện kiểm thử cho nhóm các thành phần và kiểm thử hệ thống. Kiểm tra các ngoại lệ có thể xảy ra và sửa lỗi
## 2.2. Kế hoạch
![](https://github.com/danghoangminh/quan-li-nha-sach/blob/finalcode/roadmap.png)

Kế hoạch gồm 5 giai đoạn:
- Analysis: Phân tích yêu cầu bài toán (03/04 đến 11/04)

- Requirement: Phân tích yêu cầu phần mềm gồm yêu cầu nghiệp vụ và tối ưu hệ thống (11/04 đến 24/04)

- Design: Thiết kế sơ đồ luồng dữ liệu, thiết kế dữ liệu, thiết kế giao diện và thiết kế xử lý (24/04 đến 21/05)

- Development: phát triển các chức năng của phần mền và cơ sở dữ liệu (21/05 - 05/07)

- Testing: kiểm thử phần mềm và fix lỗi gặp phải (05/07 - 10/07)

## 2.3. CASE tool
- IDE: Visual Studio

- Code Repositories: Github

- Issues tracking: Github
# 3. Thiết kế dữ liệu
## 3.1. Sơ đồ logic
![](https://github.com/danghoangminh/quan-li-nha-sach/blob/finalcode/database.png)
## 3.2. Mô tả chi tiết các kiểu dữ liệu trong sơ đồ logic
### 3.2.1. Bảng TAIKHOAN
| STT | Tên thuộc tính | Kiểu          | Ràng buộc                   | Ý nghĩa/Ghi chú             |
|-----|----------------|---------------|-----------------------------|-----------------------------|
| 1   | USERNAME       | nvarchar(20)  | Tự phát sinh                | Tên đăng nhập hệ thống      |
| 2   | PASS_WORD      | nvarchar(100) | Khác null                   | Mật khẩu đăng nhập hệ thống |
### 3.2.2. Bảng TACGIA
| STT | Tên thuộc tính | Kiểu          | Ràng buộc                   | Ý nghĩa/Ghi chú             |
|-----|----------------|---------------|-----------------------------|-----------------------------|
| 1   | MATG           | char(7)       | Tự phát sinh                | Mã phân biệt tác giả        |
| 2   | TENTG          | nvarchar(40)  | Khác null                   | Tên tác giả                 |
| 3   | NAMSINH        | date          | Không có ràng buộc          | Năm sinh của tác giả        |
| 4   | NAMMAT         | date          | Không có ràng buộc          | Năm mất của tác giả         |
| 5   | QUEQUAN        | nvarchar(20)  | Không có ràng buộc          | Quê quán của tác giả        |
### 3.2.3. Bảng LINHVUC
| STT | Tên thuộc tính | Kiểu          | Ràng buộc                   | Ý nghĩa/Ghi chú             |
|-----|----------------|---------------|-----------------------------|-----------------------------|
| 1   | TENLINHVUC     | nvarchar(30)  | Khác Null                   | Tên lĩnh vực sách           |
### 3.2.4. Bảng LOAISACH
| STT | Tên thuộc tính | Kiểu          | Ràng buộc                   | Ý nghĩa/Ghi chú             |
|-----|----------------|---------------|-----------------------------|-----------------------------|
| 1   | TENLOAISACH    | nvarchar(30)  | Khác Null                   | Tên loại sách               |
### 3.2.5. Bảng NHAXUATBAN
| STT | Tên thuộc tính | Kiểu          | Ràng buộc                   | Ý nghĩa/Ghi chú             |
|-----|----------------|---------------|-----------------------------|-----------------------------|
| 1   | TENNHAXUATBAN  | nvarchar(50)  | Khác Null                   | Tên nhà xuất bản sách       |
### 3.2.6. Bảng SACH
| STT | Tên thuộc tính | Kiểu          | Ràng buộc                   | Ý nghĩa/Ghi chú             |
|-----|----------------|---------------|-----------------------------|-----------------------------|
| 1   | MASACH         | char(7)       | Tự phát sinh                | Mã phân biệt sách           |
| 2   | TENSACH        | nvarchar(100) | Khác null                   | Tên của sách                |
| 3   | MATG           | char(7)       | Khác Null, đã tồn tại trước | Mã phân biệt tác giả        |
| 4   | TENLINHVUC     | nvarchar(30)  | Khác Null, đã tồn tại trước | Tên lĩnh vực sách           |
| 5   | TENLOAISACH    | nvarchar(30)  | Khác Null, đã tồn tại trước | Tên loại sách               |
| 6   | GIAMUA         | int           | >= 0                        | Giá nhập sách               |
| 7   | GIABIA         | int           | >= 0                        | Giá bán sách                |
| 8   | LANTAIBAN      | int           | >= 0                        | Số lần tái bản của sách     |
| 9   | TENNHAXUATBAN  | nvarchar(50)  | Khác Null, đã tồn tại trước | Tên nhà xuất bản sách       |
| 10  | NAMXUATBAN     | datetime      | Khác Null, đã tồn tại trước | Năm sách được xuất bản      |
### 3.2.7. Bảng KHO
| STT | Tên thuộc tính | Kiểu          | Ràng buộc                   | Ý nghĩa/Ghi chú             |
|-----|----------------|---------------|-----------------------------|-----------------------------|
| 1   | MASACH         | char(7)       | Đã tồn tại trước            | Mã phân biệt sách           |
| 2   | SOLUONG        | int           | >= 1                        | Số lượng sách còn           |
### 3.2.8. Bảng HOADON
| STT | Tên thuộc tính | Kiểu          | Ràng buộc                   | Ý nghĩa/Ghi chú             |
|-----|----------------|---------------|-----------------------------|-----------------------------|
| 1   | MAHOADON       | char(7)       | Tự phát sinh                | Mã phân biệt hóa đơn        |
| 2   | TENKHACHHANG   | nvarchar(50)  | Khác null                   | Tên của khách hàng          |
| 3   | NGAYLAP        | datetime      | Tự phát sinh                | Ngày lập hóa đơn            |
| 4   | TONGTIEN       | decimal(10, 2)| >= 0                        | Tổng tiền hóa đơn           |
### 3.2.9. Bảng CHITIETHOADON
| STT | Tên thuộc tính | Kiểu          | Ràng buộc                   | Ý nghĩa/Ghi chú             |
|-----|----------------|---------------|-----------------------------|-----------------------------|
| 1   | MAHOADON       | char(7)       | Đã tồn tại trước            | Mã phân biệt hóa đơn        |
| 2   | MASACH         | char(7)       | Đã tồn tại trước            | Mã phân biệt sách           |
| 3   | SOLUONG        | int           | >= 1                        | Số lượng sách mua           |
| 4   | GIATIEN        | int           | >= 0                        | Giá bán sách                |
| 5   | THANHTIEN      | int           | >= 0                        | Giá bán sách x Số lượng sách|
# 4. Thiết kế giao diện
## 4.1. Danh sách màn hình
| STT | Tên màn hình | Ý nghĩa/Ghi chú                                                                          |
|-----|--------------|------------------------------------------------------------------------------------------|
| 1   | fDangNhap    | Đăng nhập vào hệ thống bằng username và password                                         |
| 2   | fViewTong    | Màn hình chính, hiển thị danh sách các đầu sách hiện có                                  |
| 3   | fTaiKhoan    | Hiển thị danh sách user của hệ thống và chỉnh sửa mật khẩu                               |
| 4   | fThemSach    | Nhập thông tin để thêm sách                                                              |
| 5   | fSuaSach     | Sửa thông tin của sách theo mã sách                                                      |
| 6   | fXoaSach     | Xóa thông tin của sách theo mã sách                                                      |
| 7   | fThemTacGia  | Nhập thông tin để thêm tác giả                                                           |
| 8   | fSuaTacGia   | Sửa thông tin của tác giả theo mã tác giả                                                |
| 9   | fXoaTacGia   | Xóa thông tin của tác giả theo mã tác giả                                                |
| 10  | fLinhVuc     | Thêm và xóa lĩnh vực sách                                                                |
| 11  | fLoaiSach    | Thêm và xóa loại sách                                                                    |
| 12  | fNhaXuatBan  | Thêm và xóa nhà xuất bản sách                                                            |
| 13  | fKho         | Hiển thị số lượng sách còn trong kho và thêm số lượng sách                               |
| 14  | fHoaDon      | Hiển thị hóa đơn và chi tiết hóa đơn. Thêm/xóa/sửa hóa đơn và chi tiết hóa đơn           |
| 15  | fThongKe     | Hiển thị danh sách hóa đơn trong khoảng ngày chọn                                        |
| 16  | fBaoCao      | Hiển thị danh sách các đầu sách đã bán được, doanh thu, lợi nhuận trong khoảng ngày chọn |
## 4.2. Mô tả chi tiết mỗi màn hình
### 4.2.1. Màn hình fDangNhap
![](https://github.com/danghoangminh/quan-li-nha-sach/blob/finalcode/Scene/DangNhap.png)
### 4.2.2. Màn hình fViewTong
![](https://github.com/danghoangminh/quan-li-nha-sach/blob/finalcode/Scene/Quanlynhasach.png)
### 4.2.3. Màn hình fTaiKhoan
![](https://github.com/danghoangminh/quan-li-nha-sach/blob/finalcode/Scene/ThayDoiThongTinAcc.png)
### 4.2.4. Màn hình fThemSach
![](https://github.com/danghoangminh/quan-li-nha-sach/blob/finalcode/Scene/ThemSach.png)
### 4.2.5. Màn hình fSuaSach
![](https://github.com/danghoangminh/quan-li-nha-sach/blob/finalcode/Scene/SuaSach.png)
### 4.2.6. Màn hình fXoaSach
![](https://github.com/danghoangminh/quan-li-nha-sach/blob/finalcode/Scene/XoaSach.png)
### 4.2.7. Màn hình fThemTacGia
![](https://github.com/danghoangminh/quan-li-nha-sach/blob/finalcode/Scene/ThemTG.png)
### 4.2.8. Màn hình fSuaTacGia
![](https://github.com/danghoangminh/quan-li-nha-sach/blob/finalcode/Scene/SuaTG.png)
### 4.2.9. Màn hình fXoaTacGia
![](https://github.com/danghoangminh/quan-li-nha-sach/blob/finalcode/Scene/XoaTG.png)
### 4.2.10. Màn hình fLinhVuc
![](https://github.com/danghoangminh/quan-li-nha-sach/blob/finalcode/Scene/LinhVuc.png)
### 4.2.11. Màn hình fLoaiSach
![](https://github.com/danghoangminh/quan-li-nha-sach/blob/finalcode/Scene/LoaiSach.png)
### 4.2.12. Màn hình fNhaXuatBan
![](https://github.com/danghoangminh/quan-li-nha-sach/blob/finalcode/Scene/NXB.png)
### 4.2.13. Màn hình fKho
![](https://github.com/danghoangminh/quan-li-nha-sach/blob/finalcode/Scene/Kho.png)
### 4.2.14. Màn hình fHoaDon
![](https://github.com/danghoangminh/quan-li-nha-sach/blob/finalcode/Scene/HoaDon.png)
### 4.2.15. Màn hình fThongKe
![](https://github.com/danghoangminh/quan-li-nha-sach/blob/finalcode/Scene/ThongKe.png)
### 4.2.16. Màn hình fBaoCao
![](https://github.com/danghoangminh/quan-li-nha-sach/blob/finalcode/Scene/BaoCao.png)