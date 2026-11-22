
namespace SolidRefactoringLab
{
    public class ReportManager
    {
        private readonly IReportFormatter _formatter;

        public ReportManager(IReportFormatter formatter)
        {
            _formatter = formatter;
        }

        public void GenerateReport()
        {
            _formatter.FormatReport();
        }
    }
}
