using System.Collections.Generic;
using System.Linq;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace CustomXunitTrait.Tests.Infrastructure
{
    public class TestCaseDiscoverer : ITraitDiscoverer
    {
        private const string Key = "TestCase";

        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
        {
            string testCase;

            var attributeInfo = traitAttribute as ReflectionAttributeInfo;
            var testCaseAttribute = attributeInfo?.Attribute as TestCaseAttribute;
            if (testCaseAttribute != null)
            {
                testCase = testCaseAttribute.TestCase;
            }
            else
            {
                var constructorArguments = traitAttribute.GetConstructorArguments().ToArray();
                testCase = constructorArguments[0].ToString();
            }

            yield return new KeyValuePair<string, string>(Key, testCase);
        }
    }
}