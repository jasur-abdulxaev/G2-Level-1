namespace N28_T1.Events;

public class BonusAchievedEvent
{
    public int UserId { get; set; }
    public decimal OldBonus { get; set; }
    public decimal NewBonus { get; set; }
    public decimal Threshold { get; set; }
    public DateTime OccuredAt { get; set; } = DateTime.UtcNow;
}
