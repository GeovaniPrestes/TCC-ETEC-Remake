using BackEnd.Aritmica.Features.Logs.Enum;

namespace BackEnd.Aritmica.Features.Logs.Models
{
    public class LogModel
    {
        public string Message { get; set; }
        public string Entity  { get; set; }

        public DateTime Time { get; } = DateTime.Now; 
        public LogTypeEnum LogType { get; set; }
    }
}
