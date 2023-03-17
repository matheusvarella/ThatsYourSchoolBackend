namespace ThatsYourSchool.Domain.Entities;

public class Teacher : Entity
{
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    public int ClassLimit { get; private set; }
    public IList<Timetable> Timetables { get; private set; }
    public IList<Classroom> Classrooms { get; private set; }
}