using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConverterAPI.Repository.Contract
{
    public interface IUserActionsRepository<T>
    {
        IEnumerable<T> GetAllUserActions();
    }
}
