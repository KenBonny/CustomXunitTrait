using System;

namespace CustomXunitTrait.Business
{
    public class DossierCreatedTimeRule : IBusinessRule
    {
        public bool Validate(Dossier dossier)
        {
            return dossier.CreatedOn < DateTime.Now;
        }
    }
}