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
        public DateTime RegisterYear { get; set; }
        public int Label { get; set; }
        public string FrameNumber { get; set; }
        public string EIN { get; set; }
        public string OriginalExplanation { get; set; }
        public DateTime StartUsingYear { get; set; }
        public int ClLevel { get; set; }
        public int SclTime{ get; set; }
        public DateTime RecentSclYear { get; set; }
        public int GroupLabel { get; set; }
        public int UseStatus { get; set; }
        public int GndkNumber { get; set; }
        public string AcceptCode { get; set; }
        public string TypeDescription { get; set; }
        public Material()
        {
        }
        //Huy QRCode: 11/20/2018 Add Start
        public override string ToString()
        {
            StringBuilder data = new StringBuilder();
            data.AppendFormat("ID: {0}{1}",Id, Environment.NewLine);
            data.AppendFormat("Type: {0}{1}", Type, Environment.NewLine);
            data.AppendFormat("RegisterCode: {0}{1}", RegisterCode, Environment.NewLine);
            data.AppendFormat("Model: {0}{1}", Model, Environment.NewLine);
            data.AppendFormat("Origin: {0}{1}", Origin, Environment.NewLine);
            data.AppendFormat("CurrentKm: {0}{1}", CurrentKm, Environment.NewLine);
            data.AppendFormat("LastChangeOil: {0}{1}", LastChangeOil, Environment.NewLine);
            return data.ToString();
        }
        //Huy QRCode: 11/20/2018 Add End
    }
}
