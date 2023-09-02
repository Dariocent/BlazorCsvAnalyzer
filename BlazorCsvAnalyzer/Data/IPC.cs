using Microsoft.AspNetCore.Mvc;

namespace BlazorCsvAnalyzer.Data
{
    public class IPCData
    {
        public string? IPC { get; set; }
        public double AvgValue { get; set; }
        public double MaxValue { get; set; }
        public double CpuMHz { get; set; }
        public bool CanDownsize { get; set; }
    }

}
