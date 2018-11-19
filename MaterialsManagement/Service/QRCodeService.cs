using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MaterialsManagement.Service
{
    class QRCodeService
    {
        public Bitmap GenerateQRCode(string data,int pixelsPerModule = 1,int height = 100,int width = 100)
        {
            QRCoder.QRCodeGenerator qRCodeGenerator = new QRCoder.QRCodeGenerator();
            var qrData = qRCodeGenerator.CreateQrCode(data,QRCoder.QRCodeGenerator.ECCLevel.H);
            var qrCode = new QRCoder.QRCode(qrData);
            Bitmap img = qrCode.GetGraphic(pixelsPerModule);
            Bitmap resized = new Bitmap(img, new Size(height, width));
            return resized;
        }
    }
}
