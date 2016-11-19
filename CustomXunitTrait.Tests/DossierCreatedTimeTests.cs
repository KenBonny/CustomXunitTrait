using System;
using CustomXunitTrait.Business;
using CustomXunitTrait.Tests.Infrastructure;
using Xunit;

namespace CustomXunitTrait.Tests
{
    public class DossierCreatedTimeTests
    {
        private readonly DossierCreatedTimeRule _createdTimeRule = new DossierCreatedTimeRule();
        
        [Fact]
        [TestCase("Biz001")]
        [ComponentCategory]
        public void DossierCreatedInPast()
        {
            var dossier = new Dossier
            {
                CreatedOn = DateTime.Now.AddSeconds(-1)
            };

            Assert.True(_createdTimeRule.Validate(dossier));
        }

        [Fact]
        [TestCase("Biz002")]
        [EndToEndCategory]
        public void DossierCreatedNow()
        {
            var dossier = new Dossier
            {
                CreatedOn = DateTime.Now
            };

            Assert.False(_createdTimeRule.Validate(dossier));
        }

        [Fact]
        [TestCase("Biz003")]
        [EndToEndCategory]
        public void DossierCreatedInFuture()
        {
            var dossier = new Dossier
            {
                CreatedOn = DateTime.Now.AddSeconds(1)
            };

            Assert.False(_createdTimeRule.Validate(dossier));
        }
    }
}
