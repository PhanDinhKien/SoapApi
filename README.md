# SoapApi

## Mục đích dự án
Dự án SoapApi là một Web API ASP.NET Core (.NET 8) tích hợp SOAP client (WCF) để giao tiếp với dịch vụ CirculationService thông qua mã proxy sinh ra từ file WSDL.

## Công nghệ sử dụng
- .NET 8 (ASP.NET Core Web API)
- Swashbuckle.AspNetCore (Swagger/OpenAPI UI)
- System.ServiceModel.* (SOAP client)
- dotnet-svcutil (sinh mã proxy SOAP tương thích .NET 8)

## Cấu trúc thư mục
- `Controllers/` - Chứa các controller API
- `ServiceReference/Reference.cs` - Mã proxy SOAP sinh ra từ WSDL
- `Program.cs` - Cấu hình ứng dụng
- `SoapApi.csproj` - File cấu hình project
- `CirculationService.xml` - File WSDL dịch vụ SOAP

## Danh sách các phương thức SOAP CirculationService

Dưới đây là các phương thức (operations) được cung cấp bởi dịch vụ CirculationService (theo WSDL CirculationService.xml):

1. **CheckOut**  
   Mượn một tài liệu từ thư viện.
2. **CheckIn**  
   Trả lại tài liệu đã mượn về thư viện.
3. **Renew**  
   Gia hạn thời gian mượn tài liệu.
4. **GetItemStatus**  
   Lấy trạng thái hiện tại của một tài liệu (ví dụ: đang mượn, có sẵn, quá hạn...).
5. **GetUserInfo**  
   Lấy thông tin chi tiết về người dùng/thành viên thư viện.
6. **PlaceHold**  
   Đặt chỗ trước cho một tài liệu (giữ chỗ khi tài liệu đang được mượn).
7. **CancelHold**  
   Hủy yêu cầu giữ chỗ tài liệu.
8. **GetHoldStatus**  
   Lấy trạng thái của yêu cầu giữ chỗ.
9. **GetLoanHistory**  
   Lấy lịch sử mượn trả tài liệu của người dùng.
10. **GetOverdueItems**  
    Lấy danh sách các tài liệu quá hạn chưa trả.

## Danh sách đầy đủ các phương thức SOAP CirculationService

Dưới đây là danh sách tất cả các method (operation) do dịch vụ CirculationService cung cấp (theo interface ICirculationService, file Reference.cs):

- **GetBranches**: Lấy danh sách chi nhánh/thư viện.
- **InsertPatronDisposal**: Thêm thông tin xử lý bạn đọc.
- **UpdatePatronDisposal**: Cập nhật thông tin xử lý bạn đọc.
- **ResetPatronDisposalStatus**: Đặt lại trạng thái xử lý bạn đọc.
- **DeletePatronDisposal**: Xóa thông tin xử lý bạn đọc.
- **GetPatronDisposals**: Lấy danh sách xử lý bạn đọc.
- **GetPatronDisposalDetails**: Lấy chi tiết xử lý bạn đọc.
- **InsertUpdatePatronDisposalDetail**: Thêm/cập nhật chi tiết xử lý bạn đọc.
- **DeletePatronDisposalDetail**: Xóa chi tiết xử lý bạn đọc.
- **SearchDisposalPatron**: Tìm kiếm bạn đọc bị xử lý.
- **GetPatronTasks**: Lấy danh sách công việc của bạn đọc.
- **UpdatePatronTask**: Cập nhật công việc của bạn đọc.
- **GetPatronTypes**: Lấy loại bạn đọc.
- **GetPatronTrainingTypes**: Lấy loại hình đào tạo.
- **GetPatronTrainingYears**: Lấy năm đào tạo.
- **GetPatronTrainingClasses**: Lấy lớp đào tạo.
- **GetPatronTrainingSpecializations**: Lấy chuyên ngành đào tạo.
- **InsertPatron**: Thêm bạn đọc.
- **UpdatePatron**: Cập nhật bạn đọc.
- **UpdatePatronFieldValue**: Cập nhật trường thông tin bạn đọc.
- **UpdatePatronLogInAccount**: Cập nhật tài khoản đăng nhập bạn đọc.
- **InsertPatronNote**: Thêm ghi chú cho bạn đọc.
- **SetActivePatronNote**: Kích hoạt/khóa ghi chú bạn đọc.
- **DeletePatronNote**: Xóa ghi chú bạn đọc.
- **GetPatronNotes**: Lấy danh sách ghi chú bạn đọc.
- **ResetPatronPassword**: Đặt lại mật khẩu bạn đọc.
- **GetPatronID**: Lấy ID bạn đọc.
- **GetPatron**: Lấy thông tin bạn đọc.
- **DeletePatron**: Xóa bạn đọc.
- **GetPatronSearchCount**: Đếm số lượng bạn đọc theo điều kiện tìm kiếm.
- **GetPatronSearchPage**: Lấy danh sách bạn đọc theo trang.
- **GetLookupPatrons**: Lấy danh sách bạn đọc tra cứu nhanh.
- **GetLocations**: Lấy danh sách kho/tầng/thư viện.
- **GetLocationShelfs**: Lấy danh sách kệ trong kho.
- **GetItemClasses**: Lấy danh mục phân loại tài liệu.
- **GetItem**: Lấy thông tin tài liệu.
- **GetInventoryItem**: Lấy thông tin kiểm kê tài liệu.
- **InsertItem**: Thêm tài liệu.
- **UpdateItem**: Cập nhật tài liệu.
- **UpdateItemFieldValue**: Cập nhật trường thông tin tài liệu.
- **GetDmdItemCount**: Đếm số lượng tài liệu theo yêu cầu.
- **GetDmdItemPage**: Lấy danh sách tài liệu theo trang.
- **GetDmdItemsStatistic**: Thống kê tài liệu theo yêu cầu.
- **GetNextItemBarcode**: Sinh mã vạch tiếp theo cho tài liệu.
- **GetItemMaxBarcode**: Lấy mã vạch lớn nhất của tài liệu.
- **LockBarcodeOrPrefix**: Khóa mã vạch hoặc tiền tố mã vạch.
- **UnlockBarcodeOrPrefix**: Mở khóa mã vạch hoặc tiền tố mã vạch.
- **IsLockedBarcodeOrPrefix**: Kiểm tra trạng thái khóa mã vạch hoặc tiền tố mã vạch.
- **DeleteItem**: Xóa tài liệu.
- **GetMetsCirculation**: Lấy thông tin lưu thông METS.
- **GetMetsCirculationLog**: Lấy nhật ký lưu thông METS.
- **GetMetsFileCirculation**: Lấy thông tin file METS lưu thông.
- **GetMetsFileCirculationLog**: Lấy nhật ký file METS lưu thông.
- **GetFineType**: Lấy loại phí phạt.
- **GetPatronFineTypes**: Lấy loại phí phạt của bạn đọc.
- **GetPatronAccountEntries**: Lấy các khoản phí của bạn đọc.
- **InsertPatronAccountEntry**: Thêm khoản phí cho bạn đọc.
- **PayPatronAccount**: Thanh toán khoản phí cho bạn đọc.
- **DismissPatronAccount**: Miễn giảm khoản phí cho bạn đọc.
- **ClearPatronAccount**: Xóa toàn bộ khoản phí của bạn đọc.
- **GetItemCirculations**: Lấy thông tin lưu thông tài liệu.
- **GetPatronLoanItems**: Lấy danh sách tài liệu bạn đọc đang mượn.
- **GetCheckInByPatronItems**: Lấy danh sách tài liệu bạn đọc đã trả.
- **CheckOutItem**: Mượn tài liệu.
- **ImportItemCirculatonData**: Nhập dữ liệu lưu thông tài liệu.
- **RenewItemCirculation**: Gia hạn lưu thông tài liệu.
- **CheckInItem**: Trả tài liệu.
- **GetItemLoanPolicy**: Lấy chính sách mượn tài liệu.
- **GetPatronCheckOutParams**: Lấy tham số mượn tài liệu của bạn đọc.
- **GetItemCheckOutParams**: Lấy tham số mượn tài liệu của tài liệu.
- **GetItemRequestByPatron**: Lấy yêu cầu tài liệu theo bạn đọc.
- **GetItemRequestByDmd**: Lấy yêu cầu tài liệu theo biểu ghi.
- **GetDmdRequestableItems**: Lấy danh sách tài liệu có thể yêu cầu theo biểu ghi.
- **GetItemCirculationLogSeachCount**: Đếm số lượng nhật ký lưu thông tài liệu.
- **GetItemCirculationLogSearchPage**: Lấy danh sách nhật ký lưu thông tài liệu theo trang.
- **GetAuditTrailSeachCount**: Đếm số lượng nhật ký thao tác.
- **GetAuditTrailSearchPage**: Lấy danh sách nhật ký thao tác theo trang.
- **IsWorkingDay**: Kiểm tra ngày làm việc.
- **IsWorkingTime**: Kiểm tra thời gian làm việc.
- **UpdateItemRequestLibrarianNote**: Cập nhật ghi chú thủ thư cho yêu cầu tài liệu.
- **UpdateItemRequestPending**: Đánh dấu yêu cầu tài liệu đang chờ xử lý.
- **UpadateItemRequestRefuse**: Từ chối yêu cầu tài liệu.
- **UpdateItemRequestShipped**: Đánh dấu yêu cầu tài liệu đã gửi đi.
- **UpdateItemRequestArrived**: Đánh dấu yêu cầu tài liệu đã đến nơi.
- **GetItemRequestSearchCount**: Đếm số lượng yêu cầu tài liệu.
- **GetItemRequestSearchPage**: Lấy danh sách yêu cầu tài liệu theo trang.
- **GetItemRequestLogOnLoan**: Lấy nhật ký yêu cầu tài liệu đang mượn.
- **GetItemRequestLogOnLoanSearchPage**: Lấy danh sách nhật ký yêu cầu tài liệu đang mượn theo trang.
- **GetItemRequestLogOnLoanSearchCount**: Đếm số lượng nhật ký yêu cầu tài liệu đang mượn.
- **GetItemRequestLogSearchPage**: Lấy danh sách nhật ký yêu cầu tài liệu theo trang.
- **GetItemRequestLogSearchCount**: Đếm số lượng nhật ký yêu cầu tài liệu.
- **GetLastItemRequestLogShippingAddressByCirculationIds**: Lấy địa chỉ giao nhận cuối cùng theo mã lưu thông.
- **GetItemInventorySearchCount**: Đếm số lượng kiểm kê tài liệu.
- **GetItemInventorySearchPage**: Lấy danh sách kiểm kê tài liệu theo trang.
- **GetItemInventory**: Lấy thông tin kiểm kê tài liệu.
- **GetLocationBrowseSearchCount**: Đếm số lượng tìm kiếm duyệt kho.
- **GetLocationBrowseSearchPage**: Lấy danh sách tìm kiếm duyệt kho theo trang.

## Hướng dẫn build và chạy
```sh
# Restore các package
 dotnet restore
# Build project
 dotnet build
# Chạy project
 dotnet run
```

## Hướng dẫn cập nhật proxy SOAP khi WSDL thay đổi
```sh
dotnet-svcutil CirculationService.xml --namespace "*,SoapApi.CirculationServiceReference" --outputDir ServiceReference
```

## Lưu ý kỹ thuật
- Dự án sử dụng .NET 8, chỉ hỗ trợ SOAP client (không hỗ trợ host WCF server).
- Không sử dụng mã proxy sinh ra cho .NET Framework, luôn dùng dotnet-svcutil để sinh mã mới.
- Swagger UI có sẵn tại `/swagger` khi chạy ở môi trường Development.

## Liên hệ
- Người phát triển: <Điền tên bạn ở đây>
- Ngày tạo: 2025-06-10
