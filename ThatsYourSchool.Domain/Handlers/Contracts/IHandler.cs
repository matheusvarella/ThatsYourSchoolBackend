using ThatsYourSchool.Domain.Commands.Contracts;

namespace ThatsYourSchool.Domain.Handlers.Contracts
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(ICommand command);
    }
}
