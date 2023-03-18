using ThatsYourSchool.Domain.Entities;

namespace ThatsYourSchool.Domain.Repositories;

public interface IStudentRepository
{
    void Create(Student student);
    void Update(Student student);
}