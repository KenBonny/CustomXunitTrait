namespace CustomXunitTrait.Tests.Infrastructure
{
    public class EndToEndCategoryAttribute : CategoryAttribute
    {
        public override string Type => "EndToEnd";
    }
}