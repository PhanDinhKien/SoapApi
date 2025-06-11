namespace SoapApi.Dtos
{
    public class InsertPatronDto
    {
        /// <summary>Mã bạn đọc (bắt buộc, duy nhất)</summary>
        public string? Barcode { get; set; }
        /// <summary>Mã phụ bạn đọc (có thể để trống)</summary>
        public string? AlternateCode { get; set; }
        /// <summary>Loại bạn đọc (bắt buộc)</summary>
        public string? TypeCode { get; set; }
        /// <summary>Họ (bắt buộc)</summary>
        public string? FirstName { get; set; }
        /// <summary>Tên (bắt buộc)</summary>
        public string? LastName { get; set; }
        /// <summary>URL ảnh đại diện (có thể để trống)</summary>
        public string? ImageUrl { get; set; }
        /// <summary>Giới tính (có thể để trống)</summary>
        public string? Gender { get; set; }
        /// <summary>Ngày sinh (có thể để trống, định dạng yyyy-MM-dd)</summary>
        public string? DateOfBirth { get; set; }
        /// <summary>Năm đào tạo (có thể để trống)</summary>
        public string? TrainingYear { get; set; }
        /// <summary>Lớp đào tạo (có thể để trống)</summary>
        public string? TrainingClass { get; set; }
        /// <summary>Loại hình đào tạo (có thể để trống)</summary>
        public string? TrainingType { get; set; }
        /// <summary>Chuyên ngành đào tạo (có thể để trống)</summary>
        public string? TrainingSpecialization { get; set; }
        /// <summary>Địa chỉ 1 (có thể để trống)</summary>
        public string? Address1 { get; set; }
        /// <summary>Địa chỉ 2 (có thể để trống)</summary>
        public string? Address2 { get; set; }
        /// <summary>Email (có thể để trống)</summary>
        public string? Email { get; set; }
        /// <summary>Số điện thoại (có thể để trống)</summary>
        public string? Phone { get; set; }
        /// <summary>Ngày bắt đầu hiệu lực (có thể để trống, định dạng yyyy-MM-dd)</summary>
        public string? MemberDate { get; set; }
        /// <summary>Ngày hết hiệu lực (có thể để trống, định dạng yyyy-MM-dd)</summary>
        public string? ExpireDate { get; set; }
        /// <summary>Ghi chú (có thể để trống)</summary>
        public string? Remark { get; set; }
        /// <summary>Thông báo cảnh báo (có thể để trống)</summary>
        public string? AlertMessage { get; set; }
        /// <summary>Mã trạng thái (có thể để trống)</summary>
        public string? StatusCode { get; set; }
        /// <summary>Trạng thái ghi nhận (bắt buộc, ví dụ: 1=active, 0=inactive)</summary>
        public int RecordStatus { get; set; }
    }
}
