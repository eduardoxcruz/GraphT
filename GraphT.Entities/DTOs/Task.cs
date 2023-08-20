using GraphT.Entities.Enums;

namespace GraphT.Entities.DTOs;

public class Task
{
    public string Id { get; set; }
    public string Name { get; set; }
    public Status Status { get; set; }
    public Priority Priority { get; set; }
    public float Progress { get; set; }
    
    #region Punctuality And Time Spend

    public DateTime CreatedTime { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime FinishDate { get; set; }
    public DateTime LimitDate { get; set; }
    public TimeSpan TimeSpend { get; set; }
    public string Punctuality { get; set; }

    #endregion

    #region Rewards

    public decimal ExpReward { get; set; }
    public decimal GoldReward { get; set; }

    #endregion
    
    public List<Task> Upstreams { get; set; }
    public List<Task> Downstreams { get; set; }
    public List<Area> Areas { get; set; }
}