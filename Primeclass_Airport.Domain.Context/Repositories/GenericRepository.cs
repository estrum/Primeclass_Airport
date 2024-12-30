using Microsoft.EntityFrameworkCore;
using Primeclass_Airport.Domain.Context.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Primeclass_Airport.Domain.Context.Repositories;

public class GenericRepository<TModel> : IGenericRepository<TModel> where TModel : class
{
    private readonly AppDbContext _context;

    public GenericRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<TModel> Create(TModel model)
    {
        try
        {
            _context.Set<TModel>().Add(model);
            await _context.SaveChangesAsync();
            return model;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }

    public async Task<bool> Delete(TModel model)
    {
        try
        {
            _context.Set<TModel>().Remove(model);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }

    public async Task<TModel?> Get(Expression<Func<TModel, bool>> filter)
    {
        try
        {
            TModel? model = await _context.Set<TModel>().FirstOrDefaultAsync(filter);
            return model;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }

    public async Task<IEnumerable<TModel>> GetAll(Expression<Func<TModel, bool>>? filter = null)
    {
        try
        {
            var query = _context.Set<TModel>().AsNoTracking(); // No rastrea cambios (ideal para lectura).

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return await query.ToListAsync(); // Evalúa completamente la consulta antes de retornarla.
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }


    public async Task<bool> Update(TModel model)
    {
        try
        {
            _context.Set<TModel>().Update(model);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }
}
