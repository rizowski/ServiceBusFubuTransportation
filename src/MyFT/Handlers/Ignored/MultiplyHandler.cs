using MyFT.Messages.Ignored;

namespace MyFT.Handlers.Ignored
{
    public class MultiplyHandler
    {
        public ResponseMessage Handle(MultiplyMessage request)
        {
            var result = Multiply(request.NumberOne, request.NumberTwo);
            return new ResponseMessage
            {
                Result = result
            };
        }

        private int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
