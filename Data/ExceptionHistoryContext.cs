using Microsoft.EntityFrameworkCore;
using ExceptionHistory.Models;

namespace ExceptionHistory.Data
{
    public class ExceptionHistoryContext : DbContext
    {
        public ExceptionHistoryContext(DbContextOptions<ExceptionHistoryContext> opt) : base(opt)
        {

        }

        public DbSet<Record> Records { get; set; }

    }
}