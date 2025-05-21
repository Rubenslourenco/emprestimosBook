using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmprestimosBook.Models;
using Microsoft.EntityFrameworkCore;

namespace EmprestimosBook.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<EmprestimosModel> Emprestimos { get; set; }

    }
}