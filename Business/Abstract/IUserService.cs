using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int UserId);

        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<User> GetByMail(string email);

    }
}
