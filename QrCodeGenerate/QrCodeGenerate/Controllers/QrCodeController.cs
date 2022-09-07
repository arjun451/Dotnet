using iTextSharp.text.pdf.qrcode;
using Microsoft.AspNetCore.Mvc;
using QRCoder;
using IronBarCode;
using System.Drawing;

namespace QrCodeGenerate.Controllers
{
    public class QrCodeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 
        
        public IActionResult Booking()
        {
            GeneratedBarcode Barcode = IronBarCode.BarcodeWriter.CreateBarcode("Hello I am Bar Code",BarcodeEncoding.QRCode);
            Random random = new Random();
            int number = random.Next(1, 40);
            string path = "/QRCodeImage/barcode" + number + ".png";
            string rootPath = "wwwroot" + path;
            Barcode.SaveAsPng(rootPath);
            ViewBag.Barcode = path;
            return View();
        }
        public IActionResult GQRLogo()
        {
            GeneratedBarcode QrcodeWithLogo = IronBarCode.QRCodeWriter.CreateQrCodeWithLogo("hello QR with logo", "");
            Random random = new Random();
            int number = random.Next(1, 40);
            string path = "/QRCodeImage/barcode" + number + ".png";
            string rootPath = "wwwroot" + path;
            QrcodeWithLogo.SaveAsPng(rootPath);
            ViewBag.QRcode = path;
            return View();
        }

    }
}
