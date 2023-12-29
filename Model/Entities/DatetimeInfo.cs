namespace Model.Entities;

public class DatetimeInfo
{
    public DateTime CreationTime { get; set; } = DateTime.Now;
    public DateTime? StartTime { get; set; }
    public DateTime? FinishTime { get; set; }
    public DateTime? LimitDate { get; set; }
    public string? Punctuality { get; set; }
    public string? TimeSpend { get; set; }
}