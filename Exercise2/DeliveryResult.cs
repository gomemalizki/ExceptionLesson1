using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class DeliveryResult
    {
        public bool IsSuccess { get; }
        public string ErrorMessage { get; }

        private DeliveryResult(bool isSuccess, string errorMessage)
        {
            IsSuccess = isSuccess;
            ErrorMessage = errorMessage;
        }


        public static DeliveryResult Success()
        {
            return new DeliveryResult(true, null);
        }

        public static DeliveryResult Failure(string errorMessage)
        {
            return new DeliveryResult(false, errorMessage);
        }

        public override string ToString()
        {
            return IsSuccess ? "Success" : $"Failure: {ErrorMessage}";
        }
    }

}
}
