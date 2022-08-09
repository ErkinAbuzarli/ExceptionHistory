using Microsoft.EntityFrameworkCore;
using ExceptionHistory.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace ExceptionHistory.Data
{
    public class RecordRepo : IRecordRepo
    {
        private readonly ExceptionHistoryContext _context;

        public RecordRepo(ExceptionHistoryContext context)
        {
            _context = context;
        }
        public async Task<IList<Record>> GetExceptions()
        {
            return await _context.Records.ToListAsync();
        }


    }
}
