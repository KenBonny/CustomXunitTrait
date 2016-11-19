namespace CustomXunitTrait.Business
{
    public interface IBusinessRule
    {
        bool Validate(Dossier dossier);
    }
}