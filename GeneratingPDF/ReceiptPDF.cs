using Domain;
using iText.IO.Image;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Image = iText.Layout.Element.Image;

namespace GeneratingPDF
{
    public class ReceiptPDF
    {
        ReceiptHeader receiptHeader;

        public ReceiptPDF(ReceiptHeader receiptHeader)
        {
            this.receiptHeader = receiptHeader;
        }

        static void Main(String[] arg)
        {

        }
        public void CreatePDF() {

            String path = @"C:\Users\Asus\Desktop\Tijana\FON\ReceiptPDF\"+receiptHeader.receiptNumber+".pdf";
            PdfWriter writer = new PdfWriter(path);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            String imFile = "C:/Users/Asus/Desktop/Tijana/FON/ReceiptPDF/SpaLogo.png";
            ImageData data = ImageDataFactory.Create(imFile);

            // Creating an Image object        
            Image image = new Image(data);
            image.SetHeight(50);
            image.SetWidth(30);
            image.SetFixedPosition(110, 700);
            

            float col = 300f;
            float[] colwidth = { col, col };

            Table table = new Table(colwidth);

            Cell cell11 = new Cell(1, 1)
                .SetFontSize(26)
                .SetTextAlignment(TextAlignment.LEFT)
                .SetBold()
                .SetBorder(Border.NO_BORDER)
                .Add(image)
                .Add(new Paragraph("SPA CENTER"));

            Cell cell21 = new Cell(2, 1)
                .SetFontSize(26)
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetBold()
                .SetBorder(Border.NO_BORDER)
                .Add(new Paragraph("RECEIPT"));

            Cell cell22 = new Cell(2, 2)
                .SetFontSize(14)
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetBorder(Border.NO_BORDER)
                .Add(new Paragraph("ID "+receiptHeader.receiptNumber));

            Cell cell23 = new Cell(2, 3)
                .SetFontSize(14)
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetBorder(Border.NO_BORDER)
                .Add(new Paragraph(DateTime.Now.ToShortDateString()));

            Table clientPayment = new Table(colwidth);
            clientPayment.SetMarginTop(30f);

            Cell cell32;

            if (receiptHeader.Client != null)
            {
                Cell cell31 = new Cell(1, 1)
                    .SetFontSize(14)
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetBorder(Border.NO_BORDER)
                    .Add(new Paragraph("Client:" + receiptHeader.Client.firstName + " " + receiptHeader.Client.lastName + "\n" + receiptHeader.Client.email));

                clientPayment.AddCell(cell31);

                cell32 = new Cell(2, 1)
                    .SetFontSize(14)
                    .SetTextAlignment(TextAlignment.RIGHT)
                    .SetBorder(Border.NO_BORDER)
                    .Add(new Paragraph("Payment:\n" + receiptHeader.PaymentMethod.Name));

            }
            else {
                cell32 = new Cell(1, 1)
                    .SetFontSize(14)
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetBorder(Border.NO_BORDER)
                    .Add(new Paragraph("Payment:\n" + receiptHeader.PaymentMethod.Name));
            }
            
            
            Table receiptLines = new Table(6).UseAllAvailableWidth();
            receiptLines.SetMarginTop(40f);
            

            receiptLines.AddCell("Line number");
            receiptLines.AddCell("Service name");
            receiptLines.AddCell("Quantity");
            receiptLines.AddCell("Price");
            receiptLines.AddCell("Discount");
            receiptLines.AddCell("Line amount");

            foreach (ReceiptLine line in receiptHeader.receiptLines)
            {
                receiptLines.AddCell(line.LineNumber.ToString());
                receiptLines.AddCell(line.ServiceName);
                receiptLines.AddCell(line.Quantity.ToString());
                receiptLines.AddCell(line.Price.ToString());
                receiptLines.AddCell(line.Discount.ToString());
                receiptLines.AddCell(line.LineAmount.ToString());
            }

            Table totalAmount = new Table(colwidth);

            Cell cellNote = new Cell(1, 1)
                .SetFontSize(14)
                .SetTextAlignment(TextAlignment.LEFT)
                .SetBorder(Border.NO_BORDER)
                .Add(image)
                .Add(new Paragraph("Note: " + receiptHeader.Note));


            Cell cellTA = new Cell(2, 1)
               .SetFontSize(14)
               .SetTextAlignment(TextAlignment.RIGHT)
               .SetBorder(Border.NO_BORDER)
               .SetBold()
           .Add(new Paragraph("Total amount: "+receiptHeader.Amount));

            Table tableBottom = new Table(1);
            Cell cellBottom = new Cell()
                .SetTextAlignment(TextAlignment.CENTER)
                .SetBorder(Border.NO_BORDER)
                .Add(new Paragraph("Thank you for using our services.\nIf you have any questions about this receipt, please contact us."));

            PageSize ps = document.GetPdfDocument().GetDefaultPageSize();

            tableBottom.SetFixedPosition(document.GetLeftMargin(), document.GetBottomMargin(), ps.GetWidth() - document.GetLeftMargin() - document.GetRightMargin());

            tableBottom.AddCell(cellBottom);


            table.AddCell(cell11);
            table.AddCell(cell21);
            table.AddCell(cell22);
            table.AddCell(cell23);

            clientPayment.AddCell(cell32);

            totalAmount.AddCell(cellNote);
            totalAmount.AddCell(cellTA);

            document.Add(table);
            document.Add(clientPayment);
            document.Add(receiptLines);
            document.Add(totalAmount);
            document.Add(tableBottom);

            document.Close();

            Process.Start(path);

        }



    }
}
