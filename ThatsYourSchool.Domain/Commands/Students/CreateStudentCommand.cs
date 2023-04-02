using Flunt.Notifications;
using Flunt.Validations;
using ThatsYourSchool.Domain.Commands.Contracts;
using ThatsYourSchool.Domain.Enums;

namespace ThatsYourSchool.Domain.Commands.Students;

public class CreateStudentCommand : Notifiable<Notification>, ICommand
{
    public CreateStudentCommand() { }

    public CreateStudentCommand(
        string firstName, 
        string lastName, 
        string email, 
        string password, 
        ENationality nationality, 
        ECivilState civilState, 
        string occupation, 
        string rg, 
        string cpf, 
        EStudentStatus studentStatus, 
        DateTime dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
        Nationality = nationality;
        CivilState = civilState;
        Occupation = occupation;
        Rg = rg;
        Cpf = cpf;
        StudentStatus = studentStatus;
        DateOfBirth = dateOfBirth;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
    public ENationality Nationality { get; set; }
    public ECivilState CivilState { get; set; }
    public string Occupation { get; set; }
    public string Rg { get; set; }
    public string Cpf { get; set; }
    public EStudentStatus StudentStatus { get; set; }
    public DateTime DateOfBirth { get; set; }

    public bool Validate()
    {
        var contract = new Contract<CreateStudentCommand>()
            .Requires()
            .IsEmail(Email, "Mensagem de erro");

        AddNotifications(contract);

        return IsValid;
    }
}