namespace SoapApi.Dtos
{
    /// <summary>
    /// Thông tin vị trí/kho sách.
    /// </summary>
    public class LocationDto
    {
        /// <summary>Mã vị trí/kho sách.</summary>
        public string? LocationCode { get; set; }
        /// <summary>Tên vị trí/kho sách.</summary>
        public string? LocationDescription { get; set; }
        /// <summary>Mã chi nhánh.</summary>
        public string? BranchCode { get; set; }
        /// <summary>Tiền tố mã vạch tài sản.</summary>
        public string? ItemBarcodePrefix { get; set; }
        /// <summary>Mã nhãn tài sản.</summary>
        public string? ItemLabelCode { get; set; }
        /// <summary>Cấp độ truy cập bản ghi.</summary>
        public short? RecordAccessLevel { get; set; }
        /// <summary>Trạng thái bản ghi.</summary>
        public short? RecordStatus { get; set; }
        /// <summary>Phiên bản bản ghi.</summary>
        public short? RecordVersion { get; set; }
        /// <summary>Người tạo bản ghi.</summary>
        public string? RecordCreator { get; set; }
        /// <summary>Ngày tạo bản ghi.</summary>
        public DateTime? RecordCreatedDate { get; set; }
        /// <summary>Người sửa bản ghi.</summary>
        public string? RecordModifier { get; set; }
        /// <summary>Ngày sửa bản ghi.</summary>
        public DateTime? RecordModifiedDate { get; set; }
        /// <summary>Cho phép lưu thông.</summary>
        public bool? AllowCirculation { get; set; }
    }
}
