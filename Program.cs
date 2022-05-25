using System;

using System.Diagnostics;

using System.IO;
using System.Text;
using PdfSharp;

using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;

using PdfSharp.Pdf.IO;





class Program

{
    

        static void Main(string[] args)

        {
        // declarating variables 
        string consoleMonth = "u";
        string month = "w";
        string january = "1";
        string february = "2";
        string march = "3";
        string april = "4";
        string may = "5";
        string june = "6";
        string july = "7";
        string august = "8";
        string september = "9";
        string october = "10";
        string november = "11";
        string december = "12";


        string consoleYear = "b";
        int consoleYearNumber;
        string year = "Rok " + consoleYear;


        double width = 297;
        double height = 210;

        double yearA = width * 2;
        double yearB = width * .1;
        double yearC = height * .85;
        double yearD = height * .1;

        double monthA = width * .1;
        double monthB = width * .1;
        double monthC = height * .5;
        double monthD = height * .1;

        double mondayA = width * .1; //w poziomie
        double mondayB = width * .2; //w pionie
        double mondayC = height * .4; // szerokość 
        double mondayD = height * .1; //grubość

        double tuesdayA = width * .5;
        double tuesdayB = width * .2;
        double tuesdayC = height * .4;
        double tuesdayD = height * .1;

        double wednesdayA = width * .9;
        double wednesdayB = width * .2;
        double wednesdayC = height * .4;
        double wednesdayD = height * .1;

        double thursdayA = width * 1.3;
        double thursdayB = width * .2;
        double thursdayC = height * .4;
        double thursdayD = height * .1;

        double fridayA = width * 1.7;
        double fridayB = width * .2;
        double fridayC = height * .4;
        double fridayD = height * .1;

        double saturdayA = width * 2.1;
        double saturdayB = width * .2;
        double saturdayC = height * .4;
        double saturdayD = height * .1;

        double sundayA = width * 2.46;
        double sundayB = width * .2;
        double sundayC = height * .4;
        double sundayD = height * .1;

        string monday = "Poniedziałek";
        string tuesday = "Wtorek";
        string wednesday = "środa";
        string thursday = "Czwartek";
        string friday = "Piątek";
        string saturday = "Sobota";
        string sunday = "Niedziela";

        int fontSize = 20;
        int dayNameFontSize = 10;


        //CreatingMonth(); - do not work 

        Console.WriteLine("Podaj rok");
            consoleYear = Console.ReadLine();
            year = "Rok " + consoleYear;
            //do - do not work 
            //{
            //    Console.WriteLine("Podaj rok");
            //    consoleYear = Console.ReadLine();
            //}
            //while (int.TryParse(consoleYear);


            //try - do not work 
            //{
            //    consoleYear = Console.ReadLine();
            //    consoleYearNumber = int.Parse(consoleYear);
            //}
            //catch { Console.WriteLine = "Podaj poprawny rok"; }

            //consoleYearNumber = int.Parse(consoleYear);



            //do - do not work 
            //{
            Console.WriteLine("Podaj miesiąc (1-12)");
            consoleMonth = Console.ReadLine();
            //}
            //       while (consoleMonth != january || consoleMonth != february || consoleMonth != march || consoleMonth != april || consoleMonth != may || consoleMonth != june || consoleMonth != july || consoleMonth != august || consoleMonth != september || consoleMonth != november || consoleMonth != october || consoleMonth != december)
            //       {
            //Console.WriteLine("Podaj miesiąc (1-12)");
            //           consoleMonth = Console.ReadLine();

            //       }




            if (consoleMonth == january)
            {
                month = "Styczeń";
            }
            else if (consoleMonth == february)
            {
                month = "Luty";
            }
            else if (consoleMonth == march)
            {
                month = "Marzec";
            }
            else if (consoleMonth == april)
            {
                month = "Kwiecień";
            }
            else if (consoleMonth == may)
            {
                month = "Maj";
            }
            else if (consoleMonth == june)
            {
                month = "Czerwiec";
            }
            else if (consoleMonth == july)
            {
                month = "Lipiec";
            }
            else if (consoleMonth == august)
            {
                month = "Sierpień";
            }
            else if (consoleMonth == september)
            {
                month = "Wrzesień";
            }
            else if (consoleMonth == october)
            {
                month = "Październik";
            }
            else if (consoleMonth == november)
            {
                month = "Listopad";
            }
            else
            {
                month = "Grudzień";
            }


            //creating new pdf file
            PdfDocument document = new PdfDocument();

            //creating page of file
            PdfPage page = document.AddPage();



            page.Orientation = PageOrientation.Landscape;


            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);


            XGraphics gfx = XGraphics.FromPdfPage(page);

            //creating month in upper left corner
            XFont monthFont = new XFont("Times New Roman", fontSize, XFontStyle.Bold);
            XTextFormatter monthTf = new XTextFormatter(gfx);
            XRect montRect = new XRect(monthA, monthB, monthC, monthD);
            XRect montBGRect = new XRect(monthA, monthB, monthC, monthD);


            // creating year in upper right corner 
            XFont yearFont = new XFont("Times New Roman", fontSize, XFontStyle.Bold);
            XTextFormatter yearTf = new XTextFormatter(gfx);
            XRect yearRect = new XRect(yearA, yearB, yearC, yearD);
            XRect yearBGRect = new XRect(yearA, yearB, yearC, yearD);

            //creating monday 
            XFont dayFont = new XFont("Times New Roman", dayNameFontSize, XFontStyle.Bold);
            XTextFormatter mondayTf = new XTextFormatter(gfx);
            XRect mondayRect = new XRect(mondayA, mondayB, mondayC, mondayD);
            XRect mondayBGRect = new XRect(mondayA, mondayB, mondayC, mondayD);

            // creating tuesday
            XTextFormatter tuesdayTf = new XTextFormatter(gfx);
            XRect tuesdayRect = new XRect(tuesdayA, tuesdayB, tuesdayC, tuesdayD);
            XRect tuesdayBGRect = new XRect(tuesdayA, tuesdayB, tuesdayC, tuesdayD);

            // creating wednesday
            XTextFormatter wednesdayTf = new XTextFormatter(gfx);
            XRect wednesdayRect = new XRect(wednesdayA, wednesdayB, wednesdayC, wednesdayD);
            XRect wednesdayBGRect = new XRect(wednesdayA, wednesdayB, wednesdayC, wednesdayD);

            // creating thursday
            XTextFormatter thursdayTf = new XTextFormatter(gfx);
            XRect thursdayRect = new XRect(thursdayA, thursdayB, thursdayC, thursdayD);
            XRect thursdayBGRect = new XRect(thursdayA, thursdayB, thursdayC, thursdayD);

            // creating friday
            XTextFormatter fridayTf = new XTextFormatter(gfx);
            XRect fridayRect = new XRect(fridayA, fridayB, fridayC, fridayD);
            XRect fridayBGRect = new XRect(fridayA, fridayB, fridayC, fridayD);

            // creating saturday
            XTextFormatter saturdayTf = new XTextFormatter(gfx);
            XRect saturdayRect = new XRect(saturdayA, saturdayB, saturdayC, saturdayD);
            XRect saturdayBGRect = new XRect(saturdayA, saturdayB, saturdayC, saturdayD);

            // creating sunday
            XTextFormatter sundayTf = new XTextFormatter(gfx);
            XRect sundayRect = new XRect(sundayA, sundayB, sundayC, sundayD);
            XRect sundayBGRect = new XRect(sundayA, sundayB, sundayC, sundayD);

            //drawing year in corner
            gfx.DrawRectangle(XBrushes.AliceBlue, yearBGRect);

            yearTf.Alignment = XParagraphAlignment.Left;

            yearTf.DrawString(year, monthFont, XBrushes.Black, yearRect, XStringFormats.TopLeft);

            //drawing month in corner 
            gfx.DrawRectangle(XBrushes.AliceBlue, montBGRect);

            monthTf.Alignment = XParagraphAlignment.Center;

            monthTf.DrawString(month, monthFont, XBrushes.Black, montRect, XStringFormats.TopLeft);


            //drawing monday
            gfx.DrawRectangle(XBrushes.CornflowerBlue, mondayBGRect);

            mondayTf.Alignment = XParagraphAlignment.Center;

            mondayTf.DrawString(monday, dayFont, XBrushes.Black, mondayRect, XStringFormats.TopLeft);

            //drawing tuesday
            gfx.DrawRectangle(XBrushes.CornflowerBlue, tuesdayBGRect);

            tuesdayTf.Alignment = XParagraphAlignment.Center;

            tuesdayTf.DrawString(tuesday, dayFont, XBrushes.Black, tuesdayRect, XStringFormats.TopLeft);

            //drawing wednesday
            gfx.DrawRectangle(XBrushes.CornflowerBlue, wednesdayBGRect);

            wednesdayTf.Alignment = XParagraphAlignment.Center;

            wednesdayTf.DrawString(wednesday, dayFont, XBrushes.Black, wednesdayRect, XStringFormats.TopLeft);

            //drawing thursday
            gfx.DrawRectangle(XBrushes.CornflowerBlue, thursdayBGRect);

            thursdayTf.Alignment = XParagraphAlignment.Center;

            thursdayTf.DrawString(thursday, dayFont, XBrushes.Black, thursdayRect, XStringFormats.TopLeft);

            //drawing friday
            gfx.DrawRectangle(XBrushes.CornflowerBlue, fridayBGRect);

            fridayTf.Alignment = XParagraphAlignment.Center;

            fridayTf.DrawString(friday, dayFont, XBrushes.Black, fridayRect, XStringFormats.TopLeft);

            //drawing saturday
            gfx.DrawRectangle(XBrushes.CornflowerBlue, saturdayBGRect);

            saturdayTf.Alignment = XParagraphAlignment.Center;

            saturdayTf.DrawString(saturday, dayFont, XBrushes.Black, saturdayRect, XStringFormats.TopLeft);

            //drawing sunday
            gfx.DrawRectangle(XBrushes.CornflowerBlue, sundayBGRect);

            sundayTf.Alignment = XParagraphAlignment.Center;

            sundayTf.DrawString(sunday, dayFont, XBrushes.Black, sundayRect, XStringFormats.TopLeft);




            // creatig name of file and saving it 
            string monthName = month + consoleYear;
            document.Save(monthName + ".pdf");


        }


    }



////////version 2


//////using System;

//////using System.Diagnostics;

//////using System.IO;
//////using System.Text;
//////using PdfSharp;

//////using PdfSharp.Drawing;
//////using PdfSharp.Drawing.Layout;
//////using PdfSharp.Pdf;

//////using PdfSharp.Pdf.IO;





//////class Program

//////{
//////    // declarating variables 
//////    string consoleMonth = "u";
//////    string month = "w";
//////    string january = "1";
//////    string february = "2";
//////    string march = "3";
//////    string april = "4";
//////    string may = "5";
//////    string june = "6";
//////    string july = "7";
//////    string august = "8";
//////    string september = "9";
//////    string october = "10";
//////    string november = "11";
//////    string december = "12";


//////    string consoleYear;
//////    int consoleYearNumber;
//////    string year;


//////    double width = 297;
//////    double height = 210;

//////    double yearA = width * 2;
//////    double yearB = width * .1;
//////    double yearC = height * .85;
//////    double yearD = height * .1;

//////    double monthA = width * .1;
//////    double monthB = width * .1;
//////    double monthC = height * .5;
//////    double monthD = height * .1;

//////    double mondayA = width * .1; //w poziomie
//////    double mondayB = width * .2; //w pionie
//////    double mondayC = height * .4; // szerokość 
//////    double mondayD = height * .1; //grubość

//////    double tuesdayA = width * .5;
//////    double tuesdayB = width * .2;
//////    double tuesdayC = height * .4;
//////    double tuesdayD = height * .1;

//////    double wednesdayA = width * .9;
//////    double wednesdayB = width * .2;
//////    double wednesdayC = height * .4;
//////    double wednesdayD = height * .1;

//////    double thursdayA = width * 1.3;
//////    double thursdayB = width * .2;
//////    double thursdayC = height * .4;
//////    double thursdayD = height * .1;

//////    double fridayA = width * 1.7;
//////    double fridayB = width * .2;
//////    double fridayC = height * .4;
//////    double fridayD = height * .1;

//////    double saturdayA = width * 2.1;
//////    double saturdayB = width * .2;
//////    double saturdayC = height * .4;
//////    double saturdayD = height * .1;

//////    double sundayA = width * 2.46;
//////    double sundayB = width * .2;
//////    double sundayC = height * .4;
//////    double sundayD = height * .1;

//////    string monday = "Poniedziałek";
//////    string tuesday = "Wtorek";
//////    string wednesday = "środa";
//////    string thursday = "Czwartek";
//////    string friday = "Piątek";
//////    string saturday = "Sobota";
//////    string sunday = "Niedziela";

//////    int fontSize = 20;
//////    int dayNameFontSize = 10;

//////    void CreatingFile()
//////    {
////// //creating new pdf file
//////    PdfDocument document = new PdfDocument();

//////    //creating page of file
//////    PdfPage page = document.AddPage();

//////    }




//////    public void CreatingMonth()
//////    {
//////        Console.WriteLine("Podaj miesiąc (1-12)");
//////        string consoleMonth = Console.ReadLine();


//////        //while (consoleMonth != january || consoleMonth != february || consoleMonth != march || consoleMonth != april || consoleMonth != may || consoleMonth != june || consoleMonth != july || consoleMonth != august || consoleMonth != september || consoleMonth != november || consoleMonth != october || consoleMonth != december)
//////        //       {
//////        //Console.WriteLine("Podaj miesiąc (1-12)");
//////        //           consoleMonth = Console.ReadLine();

//////        //       }
//////        if (consoleMonth == january)
//////        {
//////            month = "Styczeń";
//////        }
//////        else if (consoleMonth == february)
//////        {
//////            month = "Luty";
//////        }
//////        else if (consoleMonth == march)
//////        {
//////            month = "Marzec";
//////        }
//////        else if (consoleMonth == april)
//////        {
//////            month = "Kwiecień";
//////        }
//////        else if (consoleMonth == may)
//////        {
//////            month = "Maj";
//////        }
//////        else if (consoleMonth == june)
//////        {
//////            month = "Czerwiec";
//////        }
//////        else if (consoleMonth == july)
//////        {
//////            month = "Lipiec";
//////        }
//////        else if (consoleMonth == august)
//////        {
//////            month = "Sierpień";
//////        }
//////        else if (consoleMonth == september)
//////        {
//////            month = "Wrzesień";
//////        }
//////        else if (consoleMonth == october)
//////        {
//////            month = "Październik";
//////        }
//////        else if (consoleMonth == november)
//////        {
//////            month = "Listopad";
//////        }
//////        else if (consoleMonth == december)
//////        {
//////            month = "Grudzień";
//////        }
//////        else
//////        {
//////            Console.WriteLine("Podaeś zły miesiąc");
//////        }
//////    }
//////    public void CreatingYear()
//////    {
//////        Console.WriteLine("Podaj rok");
//////        consoleYear = Console.ReadLine();
//////        year = "Rok " + consoleYear;
//////        //do - do not work 
//////        //{
//////        //    Console.WriteLine("Podaj rok");
//////        //    consoleYear = Console.ReadLine();
//////        //}
//////        //while (int.TryParse(consoleYear);


//////        //try - do not work 
//////        //{
//////        //    consoleYear = Console.ReadLine();
//////        //    consoleYearNumber = int.Parse(consoleYear);
//////        //}
//////        //catch { Console.WriteLine = "Podaj poprawny rok"; }

//////        //consoleYearNumber = int.Parse(consoleYear);

//////    }





//////    void CreatingDocument()
//////    {


//////        page.Orientation = PageOrientation.Landscape;


//////        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

//////    }


//////    void CreatingPartsOfCalendar()
//////    {
//////        XGraphics gfx = XGraphics.FromPdfPage(page);

//////        //creating month in upper left corner
//////        XFont monthFont = new XFont("Times New Roman", fontSize, XFontStyle.Bold);
//////        XTextFormatter monthTf = new XTextFormatter(gfx);
//////        XRect montRect = new XRect(monthA, monthB, monthC, monthD);
//////        XRect montBGRect = new XRect(monthA, monthB, monthC, monthD);


//////        // creating year in upper right corner 
//////        XFont yearFont = new XFont("Times New Roman", fontSize, XFontStyle.Bold);
//////        XTextFormatter yearTf = new XTextFormatter(gfx);
//////        XRect yearRect = new XRect(yearA, yearB, yearC, yearD);
//////        XRect yearBGRect = new XRect(yearA, yearB, yearC, yearD);

//////        //creating monday 
//////        XFont dayFont = new XFont("Times New Roman", dayNameFontSize, XFontStyle.Bold);
//////        XTextFormatter mondayTf = new XTextFormatter(gfx);
//////        XRect mondayRect = new XRect(mondayA, mondayB, mondayC, mondayD);
//////        XRect mondayBGRect = new XRect(mondayA, mondayB, mondayC, mondayD);

//////        // creating tuesday
//////        XTextFormatter tuesdayTf = new XTextFormatter(gfx);
//////        XRect tuesdayRect = new XRect(tuesdayA, tuesdayB, tuesdayC, tuesdayD);
//////        XRect tuesdayBGRect = new XRect(tuesdayA, tuesdayB, tuesdayC, tuesdayD);

//////        // creating wednesday
//////        XTextFormatter wednesdayTf = new XTextFormatter(gfx);
//////        XRect wednesdayRect = new XRect(wednesdayA, wednesdayB, wednesdayC, wednesdayD);
//////        XRect wednesdayBGRect = new XRect(wednesdayA, wednesdayB, wednesdayC, wednesdayD);

//////        // creating thursday
//////        XTextFormatter thursdayTf = new XTextFormatter(gfx);
//////        XRect thursdayRect = new XRect(thursdayA, thursdayB, thursdayC, thursdayD);
//////        XRect thursdayBGRect = new XRect(thursdayA, thursdayB, thursdayC, thursdayD);

//////        // creating friday
//////        XTextFormatter fridayTf = new XTextFormatter(gfx);
//////        XRect fridayRect = new XRect(fridayA, fridayB, fridayC, fridayD);
//////        XRect fridayBGRect = new XRect(fridayA, fridayB, fridayC, fridayD);

//////        // creating saturday
//////        XTextFormatter saturdayTf = new XTextFormatter(gfx);
//////        XRect saturdayRect = new XRect(saturdayA, saturdayB, saturdayC, saturdayD);
//////        XRect saturdayBGRect = new XRect(saturdayA, saturdayB, saturdayC, saturdayD);

//////        // creating sunday
//////        XTextFormatter sundayTf = new XTextFormatter(gfx);
//////        XRect sundayRect = new XRect(sundayA, sundayB, sundayC, sundayD);
//////        XRect sundayBGRect = new XRect(sundayA, sundayB, sundayC, sundayD);

//////    }



//////    void DrawingCalendar()
//////    {
//////        //drawing year in corner
//////        gfx.DrawRectangle(XBrushes.AliceBlue, yearBGRect);

//////        yearTf.Alignment = XParagraphAlignment.Left;

//////        yearTf.DrawString(year, monthFont, XBrushes.Black, yearRect, XStringFormats.TopLeft);

//////        //drawing month in corner 
//////        gfx.DrawRectangle(XBrushes.AliceBlue, montBGRect);

//////        monthTf.Alignment = XParagraphAlignment.Center;

//////        monthTf.DrawString(month, monthFont, XBrushes.Black, montRect, XStringFormats.TopLeft);


//////        //drawing monday
//////        gfx.DrawRectangle(XBrushes.CornflowerBlue, mondayBGRect);

//////        mondayTf.Alignment = XParagraphAlignment.Center;

//////        mondayTf.DrawString(monday, dayFont, XBrushes.Black, mondayRect, XStringFormats.TopLeft);

//////        //drawing tuesday
//////        gfx.DrawRectangle(XBrushes.CornflowerBlue, tuesdayBGRect);

//////        tuesdayTf.Alignment = XParagraphAlignment.Center;

//////        tuesdayTf.DrawString(tuesday, dayFont, XBrushes.Black, tuesdayRect, XStringFormats.TopLeft);

//////        //drawing wednesday
//////        gfx.DrawRectangle(XBrushes.CornflowerBlue, wednesdayBGRect);

//////        wednesdayTf.Alignment = XParagraphAlignment.Center;

//////        wednesdayTf.DrawString(wednesday, dayFont, XBrushes.Black, wednesdayRect, XStringFormats.TopLeft);

//////        //drawing thursday
//////        gfx.DrawRectangle(XBrushes.CornflowerBlue, thursdayBGRect);

//////        thursdayTf.Alignment = XParagraphAlignment.Center;

//////        thursdayTf.DrawString(thursday, dayFont, XBrushes.Black, thursdayRect, XStringFormats.TopLeft);

//////        //drawing friday
//////        gfx.DrawRectangle(XBrushes.CornflowerBlue, fridayBGRect);

//////        fridayTf.Alignment = XParagraphAlignment.Center;

//////        fridayTf.DrawString(friday, dayFont, XBrushes.Black, fridayRect, XStringFormats.TopLeft);

//////        //drawing saturday
//////        gfx.DrawRectangle(XBrushes.CornflowerBlue, saturdayBGRect);

//////        saturdayTf.Alignment = XParagraphAlignment.Center;

//////        saturdayTf.DrawString(saturday, dayFont, XBrushes.Black, saturdayRect, XStringFormats.TopLeft);

//////        //drawing sunday
//////        gfx.DrawRectangle(XBrushes.CornflowerBlue, sundayBGRect);

//////        sundayTf.Alignment = XParagraphAlignment.Center;

//////        sundayTf.DrawString(sunday, dayFont, XBrushes.Black, sundayRect, XStringFormats.TopLeft);

//////    }


//////    void SavingFile()
//////    {
//////        // creatig name of file and saving it 
//////        string monthName = month + consoleYear;
//////        document.Save(monthName + ".pdf");

//////    }

//////    CreatingFile();
//////    CreatingDocument();
//////    CreatinMonth();
//////    CreatingYear();
//////    CreatingPartsOfCalendar();
//////    DrawingCalendar();


//////}



