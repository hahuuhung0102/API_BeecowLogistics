using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecowLogistics.Services.Commons
{
    public class MessageEnum
    {
        public const string SuccessInsert = "Thêm thành công.";
        public const string SuccessUpdate = "Cập nhật thành công.";
        public const string SuccessDelete = "Xóa thành công.";
        public const string DangerInsert = "Thêm thất bại";
        public const string DangerUpdate = "Cập nhật thất bại";
        public const string DangerDelete = "Xóa thất bại";
        public const string Danger = "Thất bại";
    }
}
