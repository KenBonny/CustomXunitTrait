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

    public class ComponentCategoryAttribute : CategoryAttribute
    {
        public override string Type => "Component";
    }

    public class EndToEndCategoryAttribute : CategoryAttribute
    {
        public override string Type => "EndToEnd";
    }
}