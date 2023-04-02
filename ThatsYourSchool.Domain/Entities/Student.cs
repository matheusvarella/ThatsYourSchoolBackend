using ThatsYourSchool.Domain.Enums;

namespace ThatsYourSchool.Domain.Entities;

public class Student : Entity
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set;}
    public string Password { get; private set; }
    public ENationality Nationality { get; private set; }
    public ECivilState CivilState { get; private set; }
    public string Occupation { get; private set; }
    public string Rg { get; private set; }
    public string Cpf { get; private set; }
    public EStudentStatus StudentStatus { get; private set; }
    public DateTime DateOfBirth { get; private set; }
    public IList<Classroom> Classrooms { get; private set; }
}