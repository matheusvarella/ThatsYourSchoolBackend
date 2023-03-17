namespace ThatsYourSchool.Domain.Commands.Contracts;

public interface ICommand
{
    bool Validate();
}