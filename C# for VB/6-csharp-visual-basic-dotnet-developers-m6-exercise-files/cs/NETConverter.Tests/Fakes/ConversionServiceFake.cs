using System.Threading.Tasks;
using NETConverter.Domain;
using NETConverter.Domain.ConvertService;

namespace NETConverter.Tests.Fakes
{
    public class ConversionServiceFake : IConversionService
    {
        public Task<ConvertResponse> ConvertFile(ICodeFileInfo info)
        {
            ConvertResponse result = new ConvertResponse();
            result.Body = new ConvertResponseBody();
            result.Body.ConvertedCode =
                info.TypeOfConversion == CodeConversionTypes.vbnet2cs ? "CS" : "VB";

            var source = new TaskCompletionSource<ConvertResponse>();
            source.SetResult(result);
            return source.Task;
        }
    }
}
