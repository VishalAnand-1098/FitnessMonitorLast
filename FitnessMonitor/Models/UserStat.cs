namespace FitnessMonitor.Models
{
    public class UserStat
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime CurrentDate { get; set; } = DateTime.Now;
        public double CurrentWeight { get; set; }
        public int GoalCalories { get; set; }

        public User User { get; set; }
    }
}
