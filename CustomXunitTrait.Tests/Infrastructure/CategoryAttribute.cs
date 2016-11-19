using System;
using Xunit.Sdk;

namespace CustomXunitTrait.Tests.Infrastructure
{
    [TraitDiscoverer("CustomXunitTrait.Tests.Infrastructure.CategoryDiscoverer", "CustomXunitTrait.Tests")]
    [AttributeUsage(AttributeTargets.Method)]
    public abstract class CategoryAttribute : Attribute, ITraitAttribute
    {
        public abstract string Type { get; }
    }
}