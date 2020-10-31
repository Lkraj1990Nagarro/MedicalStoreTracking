using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStore.Data
{
    public class ResponseMessage
    {
        public ResponseMessage(bool isSuccess,string message)
        {
            this.IsSuccess = isSuccess;
            this.Message = message;
        }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

    }
}
