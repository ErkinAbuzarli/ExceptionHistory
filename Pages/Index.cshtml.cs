using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExceptionHistory.Data;
using ExceptionHistory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ExceptionHistory.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IRecordRepo _repo;

        public IndexModel(ILogger<IndexModel> logger, IRecordRepo repo)
        {
            _logger = logger;
            _repo = repo;
        }

        public IList<Record> Records { get; set; }

        public void OnSet(){

        }
        public async Task OnGetAsync()
        {
            Console.WriteLine(DateTime.Today.ToString("yyyy-mm-dd"));
            Records = await _repo.GetExceptions();
        }
    }
}
