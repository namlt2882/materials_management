using MaterialsManagement.ApiModel;
using MaterialsManagement.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialsManagement.Model
{
    public class Material
    {
        public string Id { get; set; }
        public int Type { get; set; }
        public string RegisterCode { get; set; }
        public string Model { get; set; }
        public string Origin { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public int CurrentKm { get; set; }
        public int LastChangeOil { get; set; }
        public int OilWarning { get; set; }
        public string Notes { get; set; }
        public int Status { get; set; }
        public string DvId { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public Dv dv { get; set; }
        public Qk qk { get; set; }
        public string Controller { get; set; }
        //Thời gian đăng kí 
        public DateTime RegisterYear { get; set; }
        //Nhãn xe chuyên dùng 
        public int Label { get; set; }
        //Số khung
        public string FrameNumber { get; set; }
        //Số máy - EIN (Engine dentification number)
        public string EIN { get; set; }
        //Nguồn gốc
        public string OriginalExplanation { get; set; }
        //Năm bắt đầu sử dụng
        public DateTime StartUsingYear { get; set; }
        //Phân cấp CL
        public int ClLevel { get; set; }
        //Đã qua SCL lần
        public int SclTime { get; set; }
        //Năm SCL gần nhất
        public DateTime RecentSclYear { get; set; }
        //Nhóm xe
        public int GroupLabel { get; set; }
        //Trạng thái sử dụng
        public int UseStatus { get; set; }
        //Số GCNĐK
        public int GndkNumber { get; set; }
        //Số quyết định
        public string AcceptCode { get; set; }
        //Loại xe
        public string TypeDescription { get; set; }
        public string OwnedBy { get; set; }
        public Material()
        {
        }
        //Huy QRCode: 11/20/2018 Add Start
        public override string ToString()
        {
            StringBuilder data = new StringBuilder();
            data.AppendFormat("ID: {0}{1}", Id, Environment.NewLine);
            data.AppendFormat("Loại trang bị: {0}{1}", SingletonModelProvider.GetMaterialTypeModel(Type).Name, Environment.NewLine);
            data.AppendFormat("Số đăng ký / Năm đăng ký: {0} / {1}{2}", StringUtility.TrimIfPresent(RegisterCode), RegisterYear.Year, Environment.NewLine);
            data.AppendFormat("Năm sản xuất / Năm bắt đầu sử dụng: {0} / {1}{2}", ManufacturingDate.Year, StartUsingYear.Year, Environment.NewLine);
            data.AppendFormat("Số khung / Số máy: {0} / {1}{2}", StringUtility.TrimIfPresent(FrameNumber), EIN, Environment.NewLine);
            data.AppendFormat("Số GNĐK: {0}{1}", GndkNumber, Environment.NewLine);
            data.AppendFormat("Nhóm xe: {0}{1}", SingletonModelProvider.GetMaterialGroupLabelModel(GroupLabel), Environment.NewLine);
            data.AppendFormat("Model / Nơi sản xuất: {0} / {1}{2}", Model, Origin, Environment.NewLine);
            data.AppendFormat("Phan cấp chất lượng: {0}{1}", ClLevel, Environment.NewLine);
            data.AppendFormat("Số lần scl: {0}{1}", SclTime, Environment.NewLine);
            data.AppendFormat("Năm scl gần nhất: {0}{1}", RecentSclYear.Year, Environment.NewLine);
            data.AppendFormat("Người điều khiển: {0}{1}", Controller, Environment.NewLine);
            return data.ToString();
        }
        //Huy QRCode: 11/20/2018 Add End
    }
}
