using System.Collections.Generic;
using System.Threading.Tasks;
using ExceptionHistory.Models;

namespace ExceptionHistory.Data
{
    public interface IRecordRepo
    {
        Task<IList<Record>> GetExceptions();
    }
}