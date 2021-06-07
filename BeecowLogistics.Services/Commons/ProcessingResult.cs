using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecowLogistics.Services.Commons
{
    public class ProcessingResult
    {
        public string MessageType { set; get; }
        public string Message { set; get; }
        public bool Success { set; get; }
        public object Data { set; get; }
        public List<string> ValidateData { set; get; }

        public ProcessingResult()
        {
            this.Data = null;
        }

        public ProcessingResult(string messageType, string message, bool success)
        {
            this.MessageType = messageType;
            this.Message = message;
            this.Success = success;
        }

        public ProcessingResult(string message, bool success)
        {
            this.Message = message;
            this.Success = success;
        }

        public ProcessingResult(string messageType, string message, bool success, object data)
        {
            this.MessageType = messageType;
            this.Message = message;
            this.Success = success;
            this.Data = data;
        }

        public ProcessingResult(string messageType, string message, bool success, List<string> validateData)
        {
            this.MessageType = messageType;
            this.Message = message;
            this.Success = success;
            this.ValidateData = validateData;
        }
    }
}
