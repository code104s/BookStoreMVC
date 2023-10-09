## Demo asp.net

## Install packages

- EntityFramework (design,sqlserver,tools)
# Database
- Sử dụng Fluent API để config Entities

- Migration database ( di chuyen database ) Cai dat : - Microsoft.Extensions.Configuration.Json - Microsoft.Extensions.Configuration.FileExtensions

- Package Manager Console: Add-Migration InitialCreate -context shopDbcontext update-database -context shopDbcontext
- Seeding data
- add bang identity : + install: Microsoft.AspNetCore.Identity.EntityFramewo
- Xây dựng cấu trúc phân tầng Application : folder catalog - products

- Tao interface - product
- Tao phuong thuc phan search va phan trang :
- Phuong thuc quan li anh Image #16 AddImages , RemoveImages , UpdateImages , GetListImage
- Tao API Project : BackendApi #17
- Tao Swagger cho web Api (Hoc Resful Api)
- Install : Swashbuckle.AspNetCore.Swagger Swashbuckle.AspNetCore.SwaggerUI washbuckle.AspNetCore.SwaggerGen
- Tao Resful Api cho Product
- Tao Api quan li Anh
- Tạo API đăng nhập và đăng kí : login jwt
- Tao API : usercontroller
- Them Authorization header cho swagger ( Bao ve API de su dung Token)
- Admin App
- template : https://startbootstrap.com/template/sb-admin
- Tich hop api
26: Cookie Authentication va Login Logout
## Cấu hình và Run
* Git clone
* Mở eShopSolution.sln VS2022
* Đặt Start up project là eShopSolution.Data
* Trong màn hình VS : Tools --> Nuget Package Manager --> Package Manager Console in Visual Studio
* Copy update-database và enter
* Sau khi di chuyển cơ sở dữ liệu thành công, đặt Startup Project là eShopSolution.WebApp
* Thay đổi kết nối cơ sở dữ liệu trong appsinstall.Development.json trong dự án eShopSolution.WebApp
* Chọn 3 project BackEndApi-AdminApp-WebApp thành self-host
* Chọn multiple run project: Chuột phải vào Solution và choose Properties and set Multiple Project, choose Start for 3 Projects: BackendApi, WebApp and AdminApp
* Build Prj và F5
* Done