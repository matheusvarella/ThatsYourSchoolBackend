using ThatsYourSchool.Domain.Enums;

namespace ThatsYourSchool.Domain.Entities;

public class Classroom : Entity
{
    public int StudentId { get; private set; }
    public int TeacherId { get; private set; }
    public DateTime InitialHour { get; private set; }
    public DateTime FinalHour { get; private set; }
    public EClassStatus ClassStatus { get; private set; }
    public string? Comments { get; private set; }
}