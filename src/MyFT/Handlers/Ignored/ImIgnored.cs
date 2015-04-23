using MyFT.Messages.Ignored;

namespace MyFT.Handlers.Ignored
{
    interface ImIgnored
    {
        ResponseMessage Handle(RequestMessage request);
    }
}
