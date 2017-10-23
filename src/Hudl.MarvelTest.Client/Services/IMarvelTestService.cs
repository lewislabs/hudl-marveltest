using System.Threading;
using System.Threading.Tasks;
using Hudl.Bifrost.Attributes;

namespace Hudl.MarvelTest.Client.Services
{
    public interface IMarvelTestService : IBifrostService
    {
        [BifrostMethodTimeout(BifrostMethodTimeout.Medium)]
        [BifrostPath("bifrost/marveltest/test-service/check-status")]
        [BifrostIsolationGroup("marvel-test", "test-service")]
        Task<bool> CheckStatus(CancellationToken? ct = null);

        [BifrostMethodTimeout(BifrostMethodTimeout.Medium)]
        [BifrostPath("bifrost/marveltest/test-service/echo")]
        [BifrostIsolationGroup("marvel-test", "test-service")]
        Task<string> Echo(string input, CancellationToken? ct = null);
    }
}