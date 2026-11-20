using System;

namespace SolidRefactoring
{
    public interface IReportFormatter
    {
        void FormatReport();
    }

    public class PdfFormatter : IReportFormatter
    {
        public void FormatReport()
        {
            Console.WriteLine("Formatting report as PDF...");
        }
    }

    public class WordFormatter : IReportFormatter
    {
        public void FormatReport()
        {
            Console.WriteLine("Formatting report as Word Document...");
        }
    }

    public class PlainTextFormatter : IReportFormatter
    {
        public void FormatReport()
        {
            Console.WriteLine("Formatting report as plain text...");
        }
    }

    public class ReportManager
    {
        public string ReportData { get; set; }

        private IReportFormatter formatter;

        public ReportManager(IReportFormatter formatter)
        {
            this.formatter = formatter;
        }

        public void GenerateReport()
        {
            formatter.FormatReport();
        }
    }

    public class ReportSaver
    {
        public void SaveToFile(string filename)
        {
            Console.WriteLine($"Saving Report data to {filename}...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IReportFormatter formatter = new PdfFormatter();

            ReportManager manager = new ReportManager(formatter);
            manager.GenerateReport();

            ReportSaver saver = new ReportSaver();
            saver.SaveToFile("Q1_Report.pdf");
        }
    }
}

