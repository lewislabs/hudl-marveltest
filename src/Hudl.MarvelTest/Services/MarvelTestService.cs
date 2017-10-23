using System.Threading;
using System.Threading.Tasks;
using Hudl.MarvelTest.Client.Services;

namespace Hudl.MarvelTest.Services
{
    public class MarvelTestService : IMarvelTestService
    {
        public Task<bool> CheckStatus(CancellationToken? ct = null)
        {
            return Task.FromResult(true);
        }

        public Task<string> Echo(string input, CancellationToken? ct = null)
        {
            return Task.FromResult(input);
        }
    }
}