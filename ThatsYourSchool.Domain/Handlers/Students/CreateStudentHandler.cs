using Flunt.Notifications;
using ThatsYourSchool.Domain.Commands;
using ThatsYourSchool.Domain.Commands.Contracts;
using ThatsYourSchool.Domain.Commands.Students;
using ThatsYourSchool.Domain.Entities;
using ThatsYourSchool.Domain.Handlers.Contracts;
using ThatsYourSchool.Domain.Repositories;

namespace ThatsYourSchool.Domain.Handlers.Students;

public class CreateStudentHandler : Notifiable<Notification>, IHandler<CreateStudentCommand>
{
    private readonly IStudentRepository _repository;

    public CreateStudentHandler(IStudentRepository repository)
    {
        _repository = repository;
    }

    public ICommandResult Handle(CreateStudentCommand command)
    {
        command.Validate();
        if (command.IsValid)
            return new GenericCommandResult(
                false, 
                "Aconteceu um erro!", 
                command.Notifications);

        var student = new Student();

        _repository.Create(student);

        return new GenericCommandResult(
            true,
            "Estudante salvo",
            command);
    }
}