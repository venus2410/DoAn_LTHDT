using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class ServiceResult<T>
    {
        public bool IsSuccess { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }
        public ServiceResult(bool issc, T data, string msg)
        {
            this.IsSuccess = issc;
            this.Data = data;
            this.Message = msg;
        }
    }
}
