# Tổng quan
- Đồ án môn học Nhập môn Công Nghệ Phần Mềm
  - Tên đề tài: Quản lý nhà sách
  - Mô tả: Quản lý cho một cửa hàng bán sách
  - GVHD: Huỳnh Ngọc Tín, Trần Khánh Nguyên
- Thành Viên:
  - [Đặng Hoàng Minh](https://github.com/danghoangminh) - 18520311
  - [Nguyễn Hoài Nam](https://github.com/hoainam2310) - 18521126
  - [Nguyễn Chí Dũng](https://github.com/nguyenchidungg) - 18520635
  - [Nguyễn Dương Hải](https://github.com/iamthedh7) - 19521464
- Công nghệ:
  - Ngôn ngữ: C#
  - Môi trường: .Net Framework 4.6
  - Database: SQL Server
- Mã nguồn: https://github.com/danghoangminh/BookStoreManagement

# Mục lục
- [Tổng quan](#tổng-quan)
- [Mục lục](#mục-lục)
- [1. Xác định bài toán](#1-xác-định-bài-toán)
- [2. Kế hoạch, Quy trình, Công cụ](#2-kế-hoạch-quy-trình-công-cụ)
  - [2.1. Quy trình Walterfall](#21-quy-trình-walterfall)
  - [2.2. Kế hoạch](#22-kế-hoạch)
  - [2.3. CASE tool](#23-case-tool)
- [3. Thiết kế dữ liệu](#3-thiết-kế-dữ-liệu)
  - [3.1. Sơ đồ logic](#31-sơ-đồ-logic)
  - [3.2. Mô tả chi tiết các kiểu dữ liệu trong sơ đồ logic](#32-mô-tả-chi-tiết-các-kiểu-dữ-liệu-trong-sơ-đồ-logic)
    - [3.2.1. Bảng TAIKHOAN](#321-bảng-taikhoan)
    - [3.2.2. Bảng TACGIA](#322-bảng-tacgia)
    - [3.2.3. Bảng LINHVUC](#323-bảng-linhvuc)
    - [3.2.4. Bảng LOAISACH](#324-bảng-loaisach)
    - [3.2.5. Bảng NHAXUATBAN](#325-bảng-nhaxuatban)
    - [3.2.6. Bảng SACH](#326-bảng-sach)
    - [3.2.7. Bảng KHO](#327-bảng-kho)
    - [3.2.8. Bảng HOADON](#328-bảng-hoadon)
    - [3.2.9. Bảng CHITIETHOADON](#329-bảng-chitiethoadon)
- [4. Thiết kế giao diện](#4-thiết-kế-giao-diện)
  - [4.1. Danh sách màn hình](#41-danh-sách-màn-hình)
  - [4.2. Mô tả chi tiết mỗi màn hình](#42-mô-tả-chi-tiết-mỗi-màn-hình)
    - [4.2.1. Màn hình fDangNhap](#421-màn-hình-fdangnhap)
    - [4.2.2. Màn hình fViewTong](#422-màn-hình-fviewtong)
    - [4.2.3. Màn hình fTaiKhoan](#423-màn-hình-ftaikhoan)
    - [4.2.4. Màn hình fThemSach](#424-màn-hình-fthemsach)
    - [4.2.5. Màn hình fSuaSach](#425-màn-hình-fsuasach)
    - [4.2.6. Màn hình fXoaSach](#426-màn-hình-fxoasach)
    - [4.2.7. Màn hình fThemTacGia](#427-màn-hình-fthemtacgia)
    - [4.2.8. Màn hình fSuaTacGia](#428-màn-hình-fsuatacgia)
    - [4.2.9. Màn hình fXoaTacGia](#429-màn-hình-fxoatacgia)
    - [4.2.10. Màn hình fLinhVuc](#4210-màn-hình-flinhvuc)
    - [4.2.11. Màn hình fLoaiSach](#4211-màn-hình-floaisach)
    - [4.2.12. Màn hình fNhaXuatBan](#4212-màn-hình-fnhaxuatban)
    - [4.2.13. Màn hình fKho](#4213-màn-hình-fkho)
    - [4.2.14. Màn hình fHoaDon](#4214-màn-hình-fhoadon)
    - [4.2.15. Màn hình fThongKe](#4215-màn-hình-fthongke)
    - [4.2.16. Màn hình fBaoCao](#4216-màn-hình-fbaocao)
- [5. Thiết kế kiến trúc](#5-thiết-kế-kiến-trúc)
  - [5.1. Kiến trúc hệ thống](#51-kiến-trúc-hệ-thống)
  - [5.2. Mô tả chi tiết kiến trúc hệ thống](#52-mô-tả-chi-tiết-kiến-trúc-hệ-thống)
- [6. Quy ước viết mã](#6-quy-ước-viết-mã)
  - [6.1. Quy tắc đặt tên](#61-quy-tắc-đặt-tên)
  - [6.2. Quy tắc sử dụng khi code](#62-quy-tắc-sử-dụng-khi-code)
  - [6.3. Tiền tố một số control](#63-tiền-tố-một-số-control)
  - [6.4. Quy định phân bố mã nguồn](#64-quy-định-phân-bố-mã-nguồn)
- [7. Kết quả thực hiện](#7-kết-quả-thực-hiện)
  - [7.1. Môi trường phát triển và Môi trường triển khai](#71-môi-trường-phát-triển-và-môi-trường-triển-khai)
  - [7.2. Kết quả đạt được](#72-kết-quả-đạt-được)
  - [7.3. Hướng phát triển](#73-hướng-phát-triển)
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
![](https://github.com/danghoangminh/BookStoreManagement/blob/finalcode/roadmap.png)

Kế hoạch gồm 5 giai đoạn:
- Analysis: Phân tích yêu cầu bài toán (03/04 đến 11/04)

- Requirement: Phân tích yêu cầu phần mềm gồm yêu cầu nghiệp vụ và tối ưu hệ thống (11/04 đến 24/04)

- Design: Thiết kế sơ đồ luồng dữ liệu, thiết kế dữ liệu, thiết kế giao diện và thiết kế xử lý (24/04 đến 21/05)

- Development: phát triển các chức năng của phần mềm và cơ sở dữ liệu (21/05 - 05/07)

- Testing: kiểm thử phần mềm và fix lỗi gặp phải (05/07 - 10/07)

## 2.3. CASE tool
- IDE: Visual Studio

- Code Repositories: Github

- Issues tracking: Github
# 3. Thiết kế dữ liệu
## 3.1. Sơ đồ logic
![](https://github.com/danghoangminh/BookStoreManagement/blob/finalcode/database.png)
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
![](https://github.com/danghoangminh/BookStoreManagement/blob/finalcode/Scene/DangNhap.png)

Người dùng điền thông tin Username/Password để đăng nhập. Nếu đăng nhập thất bại quá 3 lần sẽ tự tắt chương trình.
### 4.2.2. Màn hình fViewTong
![](https://github.com/danghoangminh/BookStoreManagement/blob/finalcode/Scene/Quanlynhasach.png)

Hiển thị những đầu sách có trong database, doanh thu và số lượng khách trong ngày hôm đó. Menu ở trên chứa các chức năng của chương trình.
### 4.2.3. Màn hình fTaiKhoan
![](https://github.com/danghoangminh/BookStoreManagement/blob/finalcode/Scene/ThayDoiThongTinAcc.png)

Cho phép thay đổi mật khẩu của tài khoản, yêu cầu nhập đúng mật khẩu cũ khi muốn thay đổi mật khẩu mới.
### 4.2.4. Màn hình fThemSach
![](https://github.com/danghoangminh/BookStoreManagement/blob/finalcode/Scene/ThemSach.png)

Cho phép thêm đầu sách mới vào database. Yêu cầu nhập đầy đủ thông tin, nếu không sẽ báo lỗi nhập thiếu và yêu cầu bổ sung.
### 4.2.5. Màn hình fSuaSach
![](https://github.com/danghoangminh/BookStoreManagement/blob/finalcode/Scene/SuaSach.png)

Cho phép sửa thông tin sách trong database. Yêu cầu nhập đầy đủ thông tin, nếu không sẽ báo lỗi nhập thiếu và yêu cầu bổ sung.
### 4.2.6. Màn hình fXoaSach
![](https://github.com/danghoangminh/BookStoreManagement/blob/finalcode/Scene/XoaSach.png)

Cho phép xóa sách trong database. Chọn sách cần xóa trong list sách hiển thị.
### 4.2.7. Màn hình fThemTacGia
![](https://github.com/danghoangminh/BookStoreManagement/blob/finalcode/Scene/ThemTG.png)

Cho phép thêm tác giả mới vào database. Yêu cầu nhập tên tác giả, nếu không sẽ báo lỗi nhập thiếu và yêu cầu bổ sung. Đối với ô Quê Quán, Năm Sinh, Năm Mất nếu không có thì phải chọn nút 'CHƯA RÕ' không sẽ báo lỗi thiếu thông tin.
### 4.2.8. Màn hình fSuaTacGia
![](https://github.com/danghoangminh/BookStoreManagement/blob/finalcode/Scene/SuaTG.png)

Cho phép sửa thông tin tác giả trong database. Yêu cầu nhập tên tác giả, nếu không sẽ báo lỗi nhập thiếu và yêu cầu bổ sung. Đối với ô Quê Quán, Năm Sinh, Năm Mất nếu không có thì phải chọn nút 'CHƯA RÕ' không sẽ báo lỗi thiếu thông tin.
### 4.2.9. Màn hình fXoaTacGia
![](https://github.com/danghoangminh/BookStoreManagement/blob/finalcode/Scene/XoaTG.png)

Cho phép xóa tác giả trong database. Chọn tác giả cần xóa trong list sách hiển thị.
### 4.2.10. Màn hình fLinhVuc
![](https://github.com/danghoangminh/BookStoreManagement/blob/finalcode/Scene/LinhVuc.png)

Cho phép thêm lĩnh vực mới vào database. Nếu muốn xóa thì chọn lĩnh vực cần xóa ở menu bên dưới và bấm nút xóa.
### 4.2.11. Màn hình fLoaiSach
![](https://github.com/danghoangminh/BookStoreManagement/blob/finalcode/Scene/LoaiSach.png)

Cho phép thêm loại sách mới vào database. Nếu muốn xóa thì chọn loại sách cần xóa ở menu bên dưới và bấm nút xóa.
### 4.2.12. Màn hình fNhaXuatBan
![](https://github.com/danghoangminh/BookStoreManagement/blob/finalcode/Scene/NXB.png)

Cho phép thêm nhà xuất bản mới vào database. Nếu muốn xóa thì chọn nhà xuất bản cần xóa ở menu bên dưới và bấm nút xóa.
### 4.2.13. Màn hình fKho
![](https://github.com/danghoangminh/BookStoreManagement/blob/finalcode/Scene/Kho.png)
Gồm 2 phần:
- Phần trên: cho phép sửa số lượng sách có trong kho hoặc xóa luôn sách.
- Phần dưới: thêm số lượng cho đầu sách có trong kho.
### 4.2.14. Màn hình fHoaDon
![](https://github.com/danghoangminh/BookStoreManagement/blob/finalcode/Scene/HoaDon.png)
Gồm 2 phần:
- Phần trên: hiển thị danh sách hóa đơn hiện có trong database cho phép xóa/sửa hóa đơn và xem chi tiết hóa đơn đó ở bảng kế bên.
- Phần dưới: thêm/sửa hóa đơn, thêm vật phẩm vô hóa đơn, yêu cầu nhập đầy đủ thông tin.
### 4.2.15. Màn hình fThongKe
![](https://github.com/danghoangminh/BookStoreManagement/blob/finalcode/Scene/ThongKe.png)
Chọn khoảng ngày cần thống kê bán hàng, phần mềm sẽ hiển thị những hóa đơn trong khoảng ngày được chọn.
### 4.2.16. Màn hình fBaoCao
![](https://github.com/danghoangminh/BookStoreManagement/blob/finalcode/Scene/BaoCao.png)
Xuất báo cáo chi tiết về số lượng bán đượccác loại sách, doanh thu và lợi nhuận trong khoảng ngày đã chọn ở màn hình fThongKe.
# 5. Thiết kế kiến trúc
## 5.1. Kiến trúc hệ thống
![](https://github.com/danghoangminh/BookStoreManagement/blob/finalcode/layer.png)
| Thành phần | Diễn giải                         |
|------------|-----------------------------------|
| Client     | Ứng dụng tương tác với người dùng |
| Data       | Nơi chứa dữ liệu của hệ thống     |
## 5.2. Mô tả chi tiết kiến trúc hệ thống
![](https://github.com/danghoangminh/BookStoreManagement/blob/finalcode/folderview.png)
- Ứng dụng được thiết kế theo mô hình 2 lớp (được viết chung trong 1 project) gồm:
  - View xử lý giao diện và xử lý tác vụ.
  - DAO gọi các truy xuất từ csdl (SQL).
# 6. Quy ước viết mã
## 6.1. Quy tắc đặt tên
| Kiểu        | Mô tả           | Ví dụ        |
|-------------|-----------------|--------------|
| Pascal Case | Chữ cái đầu tiên trong từ định danh và chữ cái đầu tiên của mỗi từ nối theo sau phải được viết hoa. Sử dụng Pascal Case để đặt tên cho một tên có từ 3 ký tự trở lên | `CodingConv` |
| Camel Case  | Chữ cái đầu tiên trong từ định danh là chữ thường và chữ cái đầu tiên của mối từ nối theo sau phải được viết hoa          | `codingConv` |
| Uppercase   | Tất cả các ký tự trong từ định danh phải được viết hoa. Sử dụng quy tắc này đối với tên định danh có từ 2 ký tự trở xuống | `System.IO ` |
## 6.2. Quy tắc sử dụng khi code
| Loại            | Kiểu        | Ví dụ                 | Ghi chú                  |
|-----------------|-------------|-----------------------|--------------------------|
| Tên biến        | Camel Case  | `firstName`           | Danh từ                  |
| Hằng số         | Uppercase   | `FIRST_WEEK_DAY`      | Có gạch chân giữa các từ |
| Tên class, enum | Pascal Case | `CreateUser`          | Danh từ                  |
| Tham số         | Camel Case  | `displayTime`         | Danh từ                  |
| Thuộc tính      | Pascal Case | `BackgroundColor`     | Danh từ                  |
| Phương thức     | Pascal Case | `GetAge()`            | Có gạch chân giữa các từ |
| Sự kiện         | Pascal Case | `SelectedIndexChanged`| Có gạch chân giữa các từ |
| Giao diện       | Pascal Case | `IButtonControl`      | Có gạch chân giữa các từ |
- Tránh thêm các tiền tố hoặc hậu tố dư thừa vô nghĩa:
  - Không nên:
  ```
  enum BorderEnum { ... }
  class CHuman { ... }
  ```
  - Nên:
  ```
  enum Border { ... }
  class Human { ... }
  ```
- Không thêm tên lớp chứa vào tên thuộc tính:
  - Không nên:
  ```
  Animal.WeightAnimal
  ```
  - Nên:
  ```
  Animal.Weight
  ```
- Tên biến, phương thức bool phải thể hiện được ý nghĩa nếu trả về true hoặc false. Nên sử dụng tiền tố “Is” “Can” “Has” trước tên biến, phương thức:
  - Không nên:
  ```
  bool CheckAdmin(int n) { }
  bool Expired() { }
  bool checked = true;
  ```
  - Nên:
  ```
  bool IsAdmin(int n) { }
  bool IsExpired() { }
  bool isChecked = true;
  ```
- Không dùng các tên giống nhau(chỉ phân biệt kiểu chữ in hoa hay thường). Ta khó nhận ra các định danh nhất là khi trong cùng ngữ cảnh và chỉ phân biệt các định danh bằng kiểu chữ in hoa/thường.
- Không tạo 2 namespace cùng tên và chỉ khác nhau ở kiểu chữ viết(chữ hoa/Chữ thường), ví dụ:
  ```
  Namespace SunAsterisk
  Namespace sunAsterisk
  ```
- Không nên xây dựng 1 phương thức với các tham số có cùng tên và chỉ khác nhau kiểu chữ, ví dụ:
  ```
  void MyFunction(string a, string A)
  ```
- Không xây dựng 1 kiểu với các tên property giống nhau và chỉ phân biệt ở kiểu chữ, ví dụ:
  ```
  int Color {get, set}
  int COLOR {get, set}
  ```
## 6.3. Tiền tố một số control
Bắt buộc đặt tên cho tất cả các control có tham gia xử lý dưới nền. Một số control được đặt theo kiểu Pascal với phần tiền tố như sau:
| Control      | Tiền tố | Ví dụ       |
|--------------|---------|-------------|
| Panel        | pnl     | pnlGroup    |
| Checkbox     | chk     | chkReadOnly |
| ComboBox     | cbo     | cboEnglish  |
| Button       | btn     | btnSave     |
| Dialog       | dlg     | dlgFileOpen |
| Form         | frm     | frmLogin    |
| Textbox      | txb     | txbUser     |
| User Control | uc      | ucBooks     |
| Label        | lbl     | lblName     |
| DataGridView | dgv     | dgvBook     |
## 6.4. Quy định phân bố mã nguồn
- Mỗi file mã nguồn chỉ chứa duy nhất một class. Tên class chính phải trùng với tên file mã nguồn. Ví dụ: Class Student sẽ được chứa trong file Student.cs.
- Với các kiểu enum, struct độc lập đơn giản ngoài class có thể được khai báo trong một file mã nguồn riêng hoặc trong file mã nguồn của class khác.
- Interface phải được khai báo trong một file mã nguồn riêng.
- Thứ tự khai báo:
  - Khối khai báo thư viện
  ```
  using System.Data;
  using System.Drawing;
  ```
  - Khai báo namespace
  ```
  namespace SQLBackup;
  ```
  - Khai báo các struct/enum độc lập (nếu có)
  ```
  public enum HumanClass { A, B, C, D, E }
  ```
  - Khai báo lớp chính
  ```
  public class Student : Human {}
  ```
# 7. Kết quả thực hiện
## 7.1. Môi trường phát triển và Môi trường triển khai
- Môi trường phát triển ứng dụng:
  - Hệ điều hành: Microsoft Windows 10
  - Hệ quản trị cơ sở dữ liệu: Microsoft SQL Server
  - Công cụ phân tích thiết kế: Visual Studio 2019
  - Công cụ xây dựng ứng dụng: Visual Studio 2019
- Môi trường triển khai ứng dụng:
  - Hệ điều hành: Microsoft Windows
  - Cần cài đặt .Net Framework 4.0 hoặc cao hơn
  - Để chương trình hoạt động cần có đủ các dll trong folder dll
## 7.2. Kết quả đạt được
- Chương trình đã được hoàn thiện hầu hết các chức năng, nhưng vẫn có những chức năng chưa được hoàn thiện như: Thêm tài khoản, Xuất file báo cáo dạng PDF hoặc Excel.
## 7.3. Hướng phát triển
- Hoàn thiện các chức năng và giao diện chưa hoàn tất.
- Cải thiện hiệu năng của chương trình để phù hợp với thực tiễn.
- Bổ sung các chức năng liên quan đến CSDL: backup/restore.
- Bổ sung phân quyền tài khoản cho các chức năng của phần mềm.