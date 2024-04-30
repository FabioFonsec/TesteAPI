using CRUD_alunos.Models;
using Microsoft.EntityFrameworkCore;
using CRUD_alunos.Models;
using System.Collections.Generic;

namespace CRUD_alunos.Data
{
    public class Class
    {
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {
            }

            public DbSet<Estudante> Estudantes { get; set; }
        }
    }
}
