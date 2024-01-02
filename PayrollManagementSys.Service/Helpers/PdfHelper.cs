
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using Document = DocumentFormat.OpenXml.Wordprocessing.Document;
using PayrollManagementSys.Entity.Entities;
using System.IO;

namespace PayrollManagementSys.Service.Helpers
{
    public class PdfHelper : IPdfHelper
    {
        public byte[] GenerateInvoice(PaymentInfo paymentInfo)
        {
            using(MemoryStream stream = new MemoryStream())
            {
                // Yeni bir Word belgesi oluştur
                using (WordprocessingDocument document = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
                {
                    // Başlık ekle
                    MainDocumentPart mainPart = document.AddMainDocumentPart();
                    mainPart.Document = new Document();
                    Body body = mainPart.Document.AppendChild(new Body());

                    // Fatura başlığı
                    Paragraph title = body.AppendChild(new Paragraph(new Run(new Text("Bordo"))));

                    // Fatura detayları tablosu
                    Table table = new Table(
                        new TableProperties(
                            new TableBorders(
                                new TopBorder() { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                                new BottomBorder() { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                                new LeftBorder() { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                                new RightBorder() { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                                new InsideHorizontalBorder() { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                                new InsideVerticalBorder() { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 }
                            ),
                            new TableWidth() { Width = "5000", Type = TableWidthUnitValues.Pct },
                            new TableLook() { Val = "04A0", FirstRow = true, LastRow = false, FirstColumn = true, LastColumn = false, NoHorizontalBand = false, NoVerticalBand = true }
                        )
                    );

                    // Tablo başlık satırı
                    TableRow headerRow = new TableRow();
                    headerRow.AppendChild(CreateHeaderCell("Ödeme Tarihi", "Calibri", 18, true));
                    headerRow.AppendChild(CreateHeaderCell("Maaş", "Calibri", 18, true));
                    headerRow.AppendChild(CreateHeaderCell("Maaş Katsayısı", "Calibri", 18, true));
                    headerRow.AppendChild(CreateHeaderCell("Vergi Kesintisi", "Calibri", 18, true));
                    headerRow.AppendChild(CreateHeaderCell("SGK Kesintisi", "Calibri", 18, true));
                    headerRow.AppendChild(CreateHeaderCell("Ek Ödemeler", "Calibri", 18, true));
                    table.AppendChild(headerRow);


                    if(paymentInfo.TaxDeduction == null)
                    {
                        paymentInfo.TaxDeduction = 0;
                    }
                    else if(paymentInfo.SgkDeduction == null)
                    {
                        paymentInfo.SgkDeduction = 0;
                    }
                    else if(paymentInfo.AdditionalPayments == null)
                    {
                        paymentInfo.AdditionalPayments = 0;
                    }
                    else if(paymentInfo.SalaryCoefficient  == null)
                    {
                        paymentInfo.SalaryCoefficient = 0;
                    }
                    table.AppendChild(CreateDataRow($"{paymentInfo.PaymentDate}", $"{paymentInfo.PaymentAmount}", $"{paymentInfo.SalaryCoefficient}",
                        $"{paymentInfo.TaxDeduction}", $"{paymentInfo.SgkDeduction}", $"{paymentInfo.AdditionalPayments}"));
                   

                    // Belgeye tabloyu ekle
                    body.AppendChild(table);

                    // Belgeyi kaydet
                    mainPart.Document.Save();
                }

                // MemoryStream'deki veriyi byte dizisine çevir
                return stream.ToArray();
            }

        }
      
        private Run CreateTextWithFormatting(string text, string fontName, int fontSize, bool isBold)
        {
            Run run = new Run();
            RunProperties runProperties = new RunProperties();
            RunFonts runFonts = new RunFonts() { Ascii = fontName };
            Bold bold = new Bold();
            FontSize fontSizeVal = new FontSize() { Val = fontSize.ToString() };

            runProperties.Append(runFonts);
            if (isBold)
                runProperties.Append(bold);
            runProperties.Append(fontSizeVal);

            run.AppendChild(runProperties);
            run.AppendChild(new Text(text));

            return run;
        }

        
        private TableCell CreateHeaderCell(string text, string fontName, int fontSize, bool isBold)
        {
            TableCell cell = new TableCell();
            Paragraph paragraph = new Paragraph();
            Run run = new Run();
            RunProperties runProperties = new RunProperties();
            RunFonts runFonts = new RunFonts() { Ascii = fontName };
            Bold bold = new Bold();
            FontSize fontSizeVal = new FontSize() { Val = fontSize.ToString() };

            runProperties.Append(runFonts);
            if (isBold)
                runProperties.Append(bold);
            runProperties.Append(fontSizeVal);

            run.AppendChild(runProperties);
            run.AppendChild(new Text(text));

            paragraph.AppendChild(run);
            cell.AppendChild(paragraph);

            return cell;
        }
        private TableRow CreateDataRow(string tarih, string maas, string? maasKat, string? vergi,string? sgk,string? ekodeme)
        {
            TableRow row = new TableRow();
            row.AppendChild(CreateTableCell(tarih));
            row.AppendChild(CreateTableCell(maas));
            row.AppendChild(CreateTableCell(maasKat));
            row.AppendChild(CreateTableCell(vergi));
            row.AppendChild(CreateTableCell(sgk));
            row.AppendChild(CreateTableCell(ekodeme));
            return row;
        }
        private TableCell CreateTableCell(string text)
        {
            TableCell cell = new TableCell();
            Paragraph paragraph = new Paragraph();
            Run run = new Run();
            run.AppendChild(new Text(text));
            paragraph.AppendChild(run);
            cell.AppendChild(paragraph);
            return cell;
        }
    }
}



