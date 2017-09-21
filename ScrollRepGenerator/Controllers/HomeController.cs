using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ScrollRepGenerator.Models;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;

namespace ScrollRepGenerator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var scrollCase = new ScrollCase();
            return View(scrollCase);
        }

        public IActionResult PrettyScrolls(ScrollCase scrollCase)
        {
            return CreatePdf(scrollCase.ConvertToList());
        }

        private IActionResult CreatePdf(List<Scroll> list)
        {
            if (list.Count == 0)
            {

                return Redirect("~/home");
            }

            Document document = new Document(PageSize.LETTER, 0f, 0f, 0f, 0f);
            MemoryStream stream = new MemoryStream();

            var font = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 24);
            try
            {
                PdfWriter pdfWriter = PdfWriter.GetInstance(document, stream);
                pdfWriter.CloseStream = false;
                document.Open();
                int counter = 0;
                PdfPTable table = new PdfPTable(1);
                foreach (var scroll in list)
                {
                    for (int i = 0; i < scroll.Number; i++)
                    {
                        PdfPCell cell = new PdfPCell(new Paragraph(scroll.FetchIncant(), font));
                        cell.HorizontalAlignment = 1;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        cell.FixedHeight = 152f;
                        cell.Border = 0;
                        switch(counter)
                            { 
                            case 0: counter++; break;
                            case 1: case 2: case 3: counter++; cell.BorderWidthTop = 1; break;
                            case 4: cell.BorderWidthTop = 1; counter = 0;  break;
                        }
                        
                        table.AddCell(cell);
                    }
                }
                document.Add(table);
            }
            catch (DocumentException de)
            {
                Console.Error.WriteLine(de.Message);
            }
            catch (IOException ioe)
            {
                Console.Error.WriteLine(ioe.Message);
            }

            document.Close();

            stream.Flush();
            stream.Position = 0; 

            return File(stream, "application/pdf");
        }

        

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
