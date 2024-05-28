public class Reporting
{
    private List<IReport> reports = new List<IReport>();

    public void AddReport(IReport report)
    {
        if (report == null)
        {
            throw new ArgumentNullException(nameof(report));
        }

        reports.Add(report);
    }

    public void GenerateReports()
    {
        foreach (var report in reports)
        {
            report.GenerateReport();
        }
    }
}