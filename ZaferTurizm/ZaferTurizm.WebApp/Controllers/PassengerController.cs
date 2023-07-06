using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;
using System.Xml.Linq;
using ZaferTurizm.Business.Services.BusTripManagers;
using ZaferTurizm.Business.Services.PassengerManagers;
using ZaferTurizm.Business.Services.TicketManagers;
using ZaferTurizm.DTOs.TicketAllDtos;
using Document = iTextSharp.text.Document;

namespace ZaferTurizm.WebApp.Controllers
{
    public class PassengerController : Controller
    {
        private readonly IBusTripService _bustripService;
        private readonly IPassengerService _passengerService;
        private readonly ITicketService _ticketService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public PassengerController(IBusTripService bustripService,
                                   IPassengerService passengerService, 
                                    ITicketService ticketService,
                                    IWebHostEnvironment webHostEnvironment)
        {
            _bustripService = bustripService;
            _passengerService = passengerService;
            _ticketService = ticketService;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var ticketsAll = _ticketService.GetSummaries();
           
            return View(ticketsAll);
        }
        public IActionResult Details(int id)
        {
            var summary = _ticketService.GetSummaryById(id);
            return View(summary);
        }
        public ActionResult ExportToPDF(int id)
        {
            var model = _ticketService.GetSummaryById(id);
            
           
            MemoryStream memoryStream = new MemoryStream();

           
            Document document = new Document();

           
            PdfWriter writer = PdfWriter.GetInstance(document, memoryStream);

            
            document.Open();

           
            Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);

           
            Paragraph title = new Paragraph($"{model.PassengerFName} {model.PassengerLName} Bilet Bilgileri", titleFont);
            title.Alignment = Element.ALIGN_CENTER;
            title.SpacingAfter = 10f;
            document.Add(title);

            
            PdfPTable table = new PdfPTable(2);
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 1f, 2f });

            string imagePath = Path.Combine(_webHostEnvironment.WebRootPath, "OtobusResimleri", "Zafer-Partisi.png");
            Image image = Image.GetInstance(imagePath);
            image.ScaleToFit(150f, 150f);
            image.Alignment = Element.ALIGN_CENTER;
            document.Add(image);


            // Tabloyu doldur
            table.AddCell("Sefer Tarihi:");
            table.AddCell(model.Date.ToString());

            table.AddCell("Tc Kimlik Numarası:");
            table.AddCell(model.PassengerIdentityNumber);
            table.AddCell("Ad - Soyad:");
            table.AddCell($"{model.PassengerFName} {model.PassengerLName}");

            table.AddCell("Yolcu Yasi:");
            table.AddCell(model.Age.ToString());

            table.AddCell("İletisim Bilgileri:");
            table.AddCell(model.PhoneNumber);

            table.AddCell("Koltuk Numarasi:");
            table.AddCell(model.SeatNumber.ToString());

            document.Add(table);

            // Resmi ekle
           

            // Diğer bilgileri ekle
            Paragraph busTripName = new Paragraph(model.BusTripName, FontFactory.GetFont(FontFactory.COURIER_BOLD, 20));
            busTripName.Alignment = Element.ALIGN_CENTER;
            document.Add(busTripName);

            Paragraph route = new Paragraph(model.Route);
            route.Alignment = Element.ALIGN_CENTER;
            document.Add(route);

            Paragraph paidAmount = new Paragraph($"Bilet Fiyatı: {model.PaidAmount}", FontFactory.GetFont(FontFactory.HELVETICA, 14));
            paidAmount.Alignment = Element.ALIGN_CENTER;
            document.Add(paidAmount);

            // PDF belgesini kapatın
            document.Close();

            // Bellek akışını baytlara dönüştürerek PDF dosyasını alın
            byte[] bytes = memoryStream.ToArray();

            // PDF dosyasını kullanıcıya indirme olarak sunmak için FileResult döndürün
            return File(bytes, "application/pdf", $"{model.PassengerFName}.pdf");
        }
    }

}
    
