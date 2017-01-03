using System.Threading.Tasks;
using NETConverter.Domain.ConvertService;

namespace NETConverter.Domain
{
    public class ConversionWebService : IConversionService
    {
        private ConvertServiceSoapClient _client = new ConvertServiceSoapClient();

        public async Task<ConvertResponse> ConvertFile(ICodeFileInfo info)
        {
            ConvertResponse response = await this._client.ConvertAsync(
                info.TypeOfConversion.ToString(),
                info.OriginalContents);

            return response;
        }
    }
}
