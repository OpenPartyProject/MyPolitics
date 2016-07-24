using System;
using System.Threading.Tasks;

namespace MyPolitics.CongressApi
{
    public class EnvironmentVariableApiKeyProvider : StringApiKeyProvider
    {
        public EnvironmentVariableApiKeyProvider(string environmentVariableName) : base(Environment.GetEnvironmentVariable(environmentVariableName))
        {
        }
    }
}