using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Primeclass_Airport.Domain.Context.Repositories.Contracts;

public interface IGenericRepository<TModel> where TModel : class
{
    Task<IEnumerable<TModel>> GetAll(Expression<Func<TModel, bool>>? filter = null);
    Task<TModel?> Get(Expression<Func<TModel, bool>> filter);
    Task<TModel> Create(TModel model);
    Task<bool> Update(TModel model);
    Task<bool> Delete(TModel model);
}
