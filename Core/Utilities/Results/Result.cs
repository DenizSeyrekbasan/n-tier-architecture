using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //getter read-only'dir sadece constructor icerisinde set edilebilir
        //this kullanimi icerisindeki class'i ifade eder => this = Result
        public Result(bool success, string message) : this(success)
        {
            Message = message;
            Success = success;
        }
        public Result(bool success)
        {
            Success = success;
        }
        
        public bool Success { get; }

        public string Message { get; }
    }
}
