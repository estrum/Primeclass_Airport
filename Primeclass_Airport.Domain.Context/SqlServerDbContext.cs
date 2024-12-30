using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeclass_Airport.Domain.Context;

public class SqlServerDbContext : AppDbContext
{
    public SqlServerDbContext(DbContextOptions<SqlServerDbContext> options) : base(options)
    {
    }
}
