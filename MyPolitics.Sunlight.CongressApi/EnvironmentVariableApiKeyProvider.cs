using System;

namespace MyPolitics.Sunlight.CongressApi
{
    public class EnvironmentVariableApiKeyProvider : StringApiKeyProvider
    {
        public EnvironmentVariableApiKeyProvider(string environmentVariableName) : base(Environment.GetEnvironmentVariable(environmentVariableName))
        {
        }
    }
}