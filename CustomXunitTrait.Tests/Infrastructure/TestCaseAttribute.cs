using System;
using Xunit.Sdk;

namespace CustomXunitTrait.Tests.Infrastructure
{
    [TraitDiscoverer("CustomXunitTrait.Tests.Infrastructure.TestCaseDiscoverer", "CustomXunitTrait.Tests")]
    [AttributeUsage(AttributeTargets.Method)]
    public class TestCaseAttribute : Attribute, ITraitAttribute
    {
        public string TestCase { get; set; }

        public TestCaseAttribute(string testCase)
        {
            TestCase = testCase;
        }
    }
}