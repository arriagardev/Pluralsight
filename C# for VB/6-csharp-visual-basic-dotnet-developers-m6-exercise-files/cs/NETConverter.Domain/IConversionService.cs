using System.Threading.Tasks;
using NETConverter.Domain.ConvertService;

namespace NETConverter.Domain
{
    public interface IConversionService
    {
        Task<ConvertResponse> ConvertFile(ICodeFileInfo info);
    }
}
