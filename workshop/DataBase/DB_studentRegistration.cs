using Microsoft.EntityFrameworkCore;
using System;
using workshop.Models;

namespace workshop.DataBase
{
    public class DB_studentRegistration : DbContext

    {
        

        public DB_studentRegistration(DbContextOptions options) : base(options)
        {

        }
        public DbSet<student_register> student_register { get; set; }
    }
}
