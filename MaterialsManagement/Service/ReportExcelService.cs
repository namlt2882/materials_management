using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

using MaterialsManagement.Model;
using System.Drawing;
using MaterialsManagement.ApiModel;
using MaterialsManagement.Utility;
namespace MaterialsManagement.Service
{
    class ReportExcelService
    {
        private int COLUMN_NUMBER = 22;
        private String[] co = { "", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        private int row = 1;
        private String title = "";
        private Application oXL;
        private _Workbook oWB;
        private _Worksheet oSheet;
        private Range oRng;
        public ReportExcelService(Boolean isOpenExcel)
        {
            oXL = new Application();
            oXL.Visible = isOpenExcel;
            oWB = (_Workbook)(oXL.Workbooks.Add());
            oSheet = (_Worksheet)oWB.ActiveSheet;

        }
        public virtual void ThickBorderAround(Range cells)
        {
            Borders border = cells.Borders;
            border[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            border[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            border[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            border[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
        }
        public void GenerateTitle(String title)
        {
            //[A1->--FontSize:18 Bold TextAlign:Center--<-HEADER]
            oSheet.Cells[1, 1] = title;
            oSheet.Range[co[1] + 1, co[COLUMN_NUMBER] + 1].Merge();
            oSheet.Range[co[1] + 1, co[COLUMN_NUMBER] + 1].Font.Size = 18;
            oSheet.Range[co[1] + 1, co[COLUMN_NUMBER] + 1].Font.Bold = true;
            oSheet.Range[co[1] + 1, co[COLUMN_NUMBER] + 1].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row += 2;
        }
        public void GenerateTable(String captain, List<Material> data)
        {
            if (data == null || data.Count == 0) return;

            //Captain[->--FontSize:16 Bold--<--]
            oSheet.Cells[row, 1] = captain;
            oSheet.Range[co[1] + row, co[1] + row].Font.Size = 16;
            oSheet.Range[co[1] + row, co[1] + row].Font.Color = Color.Red;
            oSheet.Range[co[1] + row, co[1] + row].Font.Bold = true;
            row++;
            //Header
            oSheet.Range[co[1] + row, co[COLUMN_NUMBER] + (row + 1)].Font.Bold = true;
            oSheet.Range[co[1] + row, co[COLUMN_NUMBER] + (row + 1)].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            oSheet.Range[co[1] + row, co[COLUMN_NUMBER] + (row + 1)].VerticalAlignment = XlHAlign.xlHAlignCenter;

            int col = 1;
            //TT
            oSheet.Cells[row, col] = "TT";
            //Border data [->--Dot Thin--<--]
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.Weight = XlBorderWeight.xlThin;
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.LineStyle = XlLineStyle.xlDot;
            //Boder header [->--Thin--<--]
            oSheet.Range[co[col] + row, co[col] + (row + 1)].Merge();
            ThickBorderAround(oSheet.Range[co[col] + row, co[col] + (row + 1)]);
            ThickBorderAround(oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)]);
            //Số đăng ký
            col++;
            oSheet.Cells[row, col] = "Số";
            oSheet.Cells[row + 1, col] = "đăng ký";
            //Border data [->--Dot Thin--<--]
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.Weight = XlBorderWeight.xlThin;
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.LineStyle = XlLineStyle.xlDot;
            //Boder header [->--Thin--<--]
            ThickBorderAround(oSheet.Range[co[col] + row, co[col] + (row + 1)]);
            ThickBorderAround(oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)]);

            //Thời gian đăng ký
            col++;
            oSheet.Cells[row, col] = "Thời gian";
            oSheet.Cells[row + 1, col] = "đăng ký";
            //Border data [->--Dot Thin--<--]
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.Weight = XlBorderWeight.xlThin;
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.LineStyle = XlLineStyle.xlDot;
            //Boder header [->--Thin--<--]
            ThickBorderAround(oSheet.Range[co[col] + row, co[col] + (row + 1)]);
            ThickBorderAround(oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)]);

            //Nhãn xe cơ sở
            col++;
            oSheet.Cells[row, col] = "Nhãn xe";
            oSheet.Cells[row + 1, col] = "cơ sở";
            //Border data [->--Dot Thin--<--]
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.Weight = XlBorderWeight.xlThin;
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.LineStyle = XlLineStyle.xlDot;
            //Boder header [->--Thin--<--]
            ThickBorderAround(oSheet.Range[co[col] + row, co[col] + (row + 1)]);
            ThickBorderAround(oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)]);

            //Nhãn xe ch/dùng
            col++;
            oSheet.Cells[row, col] = "Nhãn xe";
            oSheet.Cells[row + 1, col] = "ch/dùng";
            //Border data [->--Dot Thin--<--]
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.Weight = XlBorderWeight.xlThin;
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.LineStyle = XlLineStyle.xlDot;
            //Boder header [->--Thin--<--]
            ThickBorderAround(oSheet.Range[co[col] + row, co[col] + (row + 1)]);
            ThickBorderAround(oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)]);

            //Loại xe
            col++;
            oSheet.Cells[row, col] = "Loại";
            oSheet.Cells[row + 1, col] = "xe";
            //Border data [->--Dot Thin--<--]
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.Weight = XlBorderWeight.xlThin;
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.LineStyle = XlLineStyle.xlDot;
            //Boder header [->--Thin--<--]
            ThickBorderAround(oSheet.Range[co[col] + row, co[col] + (row + 1)]);
            ThickBorderAround(oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)]);

            //Số Khung
            col++;
            oSheet.Cells[row, col] = "Số";
            oSheet.Cells[row + 1, col] = "khung";
            //Border data [->--Dot Thin--<--]
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.Weight = XlBorderWeight.xlThin;
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.LineStyle = XlLineStyle.xlDot;
            //Boder header [->--Thin--<--]
            ThickBorderAround(oSheet.Range[co[col] + row, co[col] + (row + 1)]);
            ThickBorderAround(oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)]);

            //Số máy
            col++;
            oSheet.Cells[row, col] = "Số";
            oSheet.Cells[row + 1, col] = "máy";
            //Border data [->--Dot Thin--<--]
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.Weight = XlBorderWeight.xlThin;
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.LineStyle = XlLineStyle.xlDot;
            //Boder header [->--Thin--<--]
            ThickBorderAround(oSheet.Range[co[col] + row, co[col] + (row + 1)]);
            ThickBorderAround(oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)]);

            //Năm s/xuất
            col++;
            oSheet.Cells[row, col] = "Năm";
            oSheet.Cells[row + 1, col] = "s/xuất";
            //Border data [->--Dot Thin--<--]
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.Weight = XlBorderWeight.xlThin;
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.LineStyle = XlLineStyle.xlDot;
            //Boder header [->--Thin--<--]
            ThickBorderAround(oSheet.Range[co[col] + row, co[col] + (row + 1)]);
            ThickBorderAround(oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)]);

            //Nguồn gốc
            col++;
            oSheet.Cells[row, col] = "Nguồn";
            oSheet.Cells[row + 1, col] = "gốc";
            //Border data [->--Dot Thin--<--]
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.Weight = XlBorderWeight.xlThin;
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.LineStyle = XlLineStyle.xlDot;
            //Boder header [->--Thin--<--]
            ThickBorderAround(oSheet.Range[co[col] + row, co[col] + (row + 1)]);
            ThickBorderAround(oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)]);

            //Biên chế ở
            col++;
            oSheet.Cells[row, col] = "Biên chế ở";
            //Border data [->--Dot Thin--<--]
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.Weight = XlBorderWeight.xlThin;
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.LineStyle = XlLineStyle.xlDot;
            //Boder header [->--Thin--<--]
            oSheet.Range[co[col] + row, co[col] + (row + 1)].Merge();
            ThickBorderAround(oSheet.Range[co[col] + row, co[col] + (row + 1)]);
            ThickBorderAround(oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)]);

            //Khối đơn vị
            col++;
            oSheet.Cells[row, col] = "Khối";
            oSheet.Cells[row + 1, col] = "đơn vị";
            //Border data [->--Dot Thin--<--]
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.Weight = XlBorderWeight.xlThin;
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.LineStyle = XlLineStyle.xlDot;
            //Boder header [->--Thin--<--]
            ThickBorderAround(oSheet.Range[co[col] + row, co[col] + (row + 1)]);
            ThickBorderAround(oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)]);

            //Năm b/đầu sản xuất
            col++;
            oSheet.Cells[row, col] = "Năm b/đầu";
            oSheet.Cells[row + 1, col] = "sản xuất";
            //Border data [->--Dot Thin--<--]
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.Weight = XlBorderWeight.xlThin;
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.LineStyle = XlLineStyle.xlDot;
            //Boder header [->--Thin--<--]
            ThickBorderAround(oSheet.Range[co[col] + row, co[col] + (row + 1)]);
            ThickBorderAround(oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)]);

            //Phân cấp CL
            col++;
            oSheet.Cells[row, col] = "Phân";
            oSheet.Cells[row + 1, col] = "cấp CL";
            //Border data [->--Dot Thin--<--]
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.Weight = XlBorderWeight.xlThin;
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.LineStyle = XlLineStyle.xlDot;
            //Boder header [->--Thin--<--]
            ThickBorderAround(oSheet.Range[co[col] + row, co[col] + (row + 1)]);
            ThickBorderAround(oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)]);

            //Đã qua SCL lần
            col++;
            oSheet.Cells[row, col] = "Đã qua";
            oSheet.Cells[row + 1, col] = "SCL lần";
            //Border data [->--Dot Thin--<--]
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.Weight = XlBorderWeight.xlThin;
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.LineStyle = XlLineStyle.xlDot;
            //Boder header [->--Thin--<--]
            ThickBorderAround(oSheet.Range[co[col] + row, co[col] + (row + 1)]);
            ThickBorderAround(oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)]);

            //Năm SCL gần nhất
            col++;
            oSheet.Cells[row, col] = "Năm SCL";
            oSheet.Cells[row + 1, col] = "gần nhất";
            //Border data [->--Dot Thin--<--]
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.Weight = XlBorderWeight.xlThin;
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.LineStyle = XlLineStyle.xlDot;
            //Boder header [->--Thin--<--]
            ThickBorderAround(oSheet.Range[co[col] + row, co[col] + (row + 1)]);
            ThickBorderAround(oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)]);

            //Nhóm xe
            col++;
            oSheet.Cells[row, col] = "Nhóm";
            oSheet.Cells[row + 1, col] = "xe";
            //Border data [->--Dot Thin--<--]
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.Weight = XlBorderWeight.xlThin;
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.LineStyle = XlLineStyle.xlDot;
            //Boder header [->--Thin--<--]
            ThickBorderAround(oSheet.Range[co[col] + row, co[col] + (row + 1)]);
            ThickBorderAround(oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)]);

            //Trạng thái SD
            col++;
            oSheet.Cells[row, col] = "Trạng";
            oSheet.Cells[row + 1, col] = "thái SD";
            //Border data [->--Dot Thin--<--]
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.Weight = XlBorderWeight.xlThin;
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.LineStyle = XlLineStyle.xlDot;
            //Boder header [->--Thin--<--]
            ThickBorderAround(oSheet.Range[co[col] + row, co[col] + (row + 1)]);
            ThickBorderAround(oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)]);

            //Số GCNĐK
            col++;
            oSheet.Cells[row, col] = "Số";
            oSheet.Cells[row + 1, col] = "GCNĐK";
            //Border data [->--Dot Thin--<--]
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.Weight = XlBorderWeight.xlThin;
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.LineStyle = XlLineStyle.xlDot;
            //Boder header [->--Thin--<--]
            ThickBorderAround(oSheet.Range[co[col] + row, co[col] + (row + 1)]);
            ThickBorderAround(oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)]);

            //Loại đơn vị
            col++;
            oSheet.Cells[row, col] = "Loại";
            oSheet.Cells[row + 1, col] = "đơn vị";
            //Border data [->--Dot Thin--<--]
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.Weight = XlBorderWeight.xlThin;
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.LineStyle = XlLineStyle.xlDot;
            //Boder header [->--Thin--<--]
            ThickBorderAround(oSheet.Range[co[col] + row, co[col] + (row + 1)]);
            ThickBorderAround(oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)]);

            //Số QĐ, thời gian đưa vào biên chế
            col++;
            oSheet.Cells[row, col] = "Số QĐ, thời gian";
            oSheet.Cells[row + 1, col] = "đưa vào biên chế";
            //Border data [->--Dot Thin--<--]
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.Weight = XlBorderWeight.xlThin;
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.LineStyle = XlLineStyle.xlDot;
            //Boder header [->--Thin--<--]
            ThickBorderAround(oSheet.Range[co[col] + row, co[col] + (row + 1)]);
            ThickBorderAround(oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)]);

            //Ghi chú
            col++;
            oSheet.Cells[row, col] = "Ghi";
            oSheet.Cells[row + 1, col] = "chú";
            //Border data [->--Dot Thin--<--]
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.Weight = XlBorderWeight.xlThin;
            oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)].Borders.LineStyle = XlLineStyle.xlDot;
            //Boder header [->--Thin--<--]
            ThickBorderAround(oSheet.Range[co[col] + row, co[col] + (row + 1)]);
            ThickBorderAround(oSheet.Range[co[col] + (row + 2), co[col] + (row + data.Count + 1)]);
            col = 0;
            row += 1;
           

            DvService dvService = new DvService();
            for (int i = 0; i < data.Count; i++)
            {
                row++;
                col++;
                Material material = data[i];
                oSheet.Cells[row, col++] = i + 1;//TT
                oSheet.Cells[row, col++] = material.RegisterCode;//Số đăng ký
                oSheet.Cells[row, col++] = material.RegisterYear.Year;//Thời gian đăng ký
                oSheet.Cells[row, col++] = material.Model;//Nhãn xe cơ sở
                oSheet.Cells[row, col++] = SingletonModelProvider.GetMaterialLabelModel(material.Label).Name;//Nhãn xe ch/dùng
                oSheet.Cells[row, col++] = SingletonModelProvider.GetMaterialTypeModel( material.Type).Name;//Loại xe
                oSheet.Cells[row, col++] = StringUtility.TrimIfPresent(material.FrameNumber);//Số Khung
                oSheet.Cells[row, col++] = StringUtility.TrimIfPresent(material.EIN);//Số máy
                oSheet.Cells[row, col++] = material.ManufacturingDate.Year;//Năm s/xuất
                oSheet.Cells[row, col++] = material.OriginalExplanation;//Nguồn gốc
                oSheet.Cells[row, col++] = StringUtility.TrimIfPresent(material.OwnedBy);//Biên chế ở
                oSheet.Cells[row, col++] = StringUtility.TrimIfPresent(material.OwnedBy);//Khối đơn vị
                oSheet.Cells[row, col++] = material.StartUsingYear.Year;//Năm b/đầu sản xuất
                oSheet.Cells[row, col++] = material.ClLevel;//Phân cấp CL
                oSheet.Cells[row, col++] = material.SclTime;//Đã qua SCL lần
                oSheet.Cells[row, col++] = material.RecentSclYear.Year;//Năm SCL gần nhất
                oSheet.Cells[row, col++] = SingletonModelProvider.GetMaterialGroupLabelModel(material.GroupLabel).Name;//Nhóm xe
                oSheet.Cells[row, col++] = SingletonModelProvider.GetMaterialUseStatusModel(material.UseStatus).Name;//Trạng thái SD
                string gcndk = material.GndkNumber >= 1000 ? material.GndkNumber.ToString("D5") : material.GndkNumber.ToString("D4");
                oSheet.Cells[row, col++] = gcndk;//Số GCNĐK
                oSheet.Cells[row, col++] = SingletonModelProvider.GetMaterialTypeModel(material.Type).Name;//Loại đơn vị
                oSheet.Cells[row, col++] = material.AcceptCode;//Số QĐ, thời gian đưa vào biên chế
                oSheet.Cells[row, col++] = material.Notes;//Ghi chú
                col = 0;
            }
            row+=2;
        }
        public void DownLoad(String path)
        {
            oWB.SaveAs(path, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
                        false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            oWB.Close();
            oXL.Quit();
        }
    }
}
