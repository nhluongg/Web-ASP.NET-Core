🧩 Giới thiệu

Dự án QlySanPham là ứng dụng Web MVC được phát triển bằng ASP.NET Core (.NET 8),
sử dụng Entity Framework Core (Code First) để quản lý dữ liệu sản phẩm trong SQL Server.

Giao diện được xây dựng bằng Bootstrap 5, thân thiện, trực quan và dễ sử dụng.

⚙️ Công nghệ sử dụng: 

Ngôn ngữ:	C# (.NET 8)
Framework:	ASP.NET Core MVC
ORM	Entity Framework Core (Code First)
Cơ sở dữ liệu:	SQL Server (LocalDB hoặc SQLEXPRESS)
Thư viện: UI	Bootstrap 5, Bootstrap Icons
IDE khuyến nghị	Visual Studio 2022


🏗️ Cấu trúc dự án
QlySanPham/
├── Controllers/
│   └── ProductsController.cs
│
├── Models/
│   ├── Product.cs
│   └── AppDbContext.cs
│
├── Views/
│   ├── Products/
│   │   ├── Index.cshtml
│   │   ├── Create.cshtml
│   │   ├── Edit.cshtml
│   │   ├── Details.cshtml
│   │   └── Delete.cshtml
│   ├── Shared/
│   │   ├── _Layout.cshtml
│   │   └── _ValidationScriptsPartial.cshtml
│   └── _ViewStart.cshtml
│
├── appsettings.json
├── Program.cs
└── QlySanPham.csproj
📦 Các gói NuGet cần cài đặt

Microsoft.EntityFrameworkCore	(ORM cho mô hình dữ liệu)
Microsoft.EntityFrameworkCore.SqlServer	(Kết nối SQL Server)
Microsoft.EntityFrameworkCore.Tools	(Dùng cho migration và update DB)
Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore	(Hiển thị lỗi database trong môi trường Development)
Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation	(Cho phép chỉnh sửa view và xem ngay)
Microsoft.VisualStudio.Web.CodeGeneration.Design	(Hỗ trợ Scaffolding (tạo controller/view tự động))
Microsoft.Extensions.Configuration.UserSecrets (tuỳ chọn)

🗄️ Cấu trúc cơ sở dữ liệu

Bảng **Products** gồm các cột:

| Cột | Kiểu dữ liệu | Mô tả |
|------|---------------|--------|
| `Id` | `int` | Khóa chính |
| `Name` | `nvarchar(100)` | Tên sản phẩm |
| `Price` | `decimal(18,2)` | Giá sản phẩm |
| `Stock` | `int` | Số lượng tồn kho |
| `Description` | `nvarchar(max)` | Mô tả sản phẩm |


🚀 Cách chạy dự án
1️⃣ Yêu cầu môi trường
Visual Studio 2022 hoặc mới hơn
.NET 8 SDK
SQL Server (hoặc LocalDB)

2️⃣ Cấu hình chuỗi kết nối

Trong file appsettings.json, chỉnh lại DefaultConnection cho phù hợp với máy bạn:

"ConnectionStrings": {
  "DefaultConnection": "Server=LUONGNGUYEN\\SQLEXPRESS;Database=QlySanPhamDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
}

3️⃣ Tạo database từ migration:

Mở Package Manager Console hoặc Terminal, chạy lệnh:
dotnet ef database update

💡 Nếu chưa có thư mục Migrations, tạo mới bằng:
dotnet ef migrations add InitialCreate
dotnet ef database update

4️⃣ Chạy ứng dụng:
dotnet run
Ứng dụng sẽ chạy tại địa chỉ:
https://localhost:xxxx

💻 Các chức năng chính
Chức năng	Mô tả
🏠 Trang chủ (Index):	Hiển thị danh sách tất cả sản phẩm
➕ Thêm mới (Create):	Tạo sản phẩm mới
✏️ Chỉnh sửa (Edit):	Sửa thông tin sản phẩm
🔍 Chi tiết (Details):	Xem thông tin chi tiết từng sản phẩm
🗑️ Xóa (Delete): 	Xóa sản phẩm khỏi cơ sở dữ liệu

🧰 Công cụ & Thư viện Front-End
Bootstrap 5: giao diện responsive
Bootstrap Icons: biểu tượng trong các nút
jQuery & jQuery Validation: kiểm tra dữ liệu form client-side

🧱 Dữ liệu mẫu (tuỳ chọn)

Có thể seed dữ liệu trong AppDbContext.cs như sau:

modelBuilder.Entity<Product>().HasData(
    new Product { Id = 1, Name = "Laptop Dell", Price = 18000000, Stock = 10, Description = "Laptop văn phòng bền bỉ" },
    new Product { Id = 2, Name = "iPhone 15", Price = 24000000, Stock = 5, Description = "Điện thoại cao cấp" }
);

🏁 Tác giả

Nguyễn Hữu Lương
📅 Năm thực hiện: 2025
🛠️ Môn học: Lập trình ứng dụng doanh nghiệp trong .Net
