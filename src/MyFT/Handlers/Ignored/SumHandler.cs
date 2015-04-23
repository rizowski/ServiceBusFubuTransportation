using MyFT.Messages.Ignored;

namespace MyFT.Handlers.Ignored
{
    public class SumHandler
    {
        public ResponseMessage Handle(SumMessage request)
        {
            var result = Sum(request.NumberOne, request.NumberTwo);
            return new ResponseMessage
            {
                Result = result
            };
        }

        private int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
