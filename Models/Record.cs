using System;
using System.ComponentModel.DataAnnotations;

namespace ExceptionHistory.Models
{
    public class Record
    {
        public long Id { get; set; }

        public string ProjectName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfException { get; set; }

        public string Catagory { get; set; }

        public string Note { get; set; }
    }
}
