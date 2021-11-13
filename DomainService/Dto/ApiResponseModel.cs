using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jwtTocketTest.Models
{
        public class ApiResponseModel
        {
            public ApiResponseInfoModel Info { get; set; }
            public object Data { get; set; }
        }
        public class ApiMulResponseModel
        {
            public ApiResponseInfoModel Info { get; set; }
            public object Bin { get; set; }
            public object TransactionType { get; set; }
        }
        public class ApiResponseInfoModel
        {
            public bool IsSuccess { get; set; } = true;
            public string Code { get; set; }
            public string Message { get; set; }
        }
    
}
