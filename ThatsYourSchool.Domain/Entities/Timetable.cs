namespace ThatsYourSchool.Domain.Entities;

public class Timetable : Entity
{
    public int TeacherId { get; private set; }
    public DateTime InitialHour { get; private set; }
    public DateTime FinalHour { get; private set; }
    public Teacher Teacher { get; private set; }
}