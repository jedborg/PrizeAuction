using System.Web.Mvc;
using auction.Areas.FluentMetadata.Models;
using auction.Areas.FluentMetadata.Utility;

namespace auction.Areas.FluentMetadata
{
    public class FluentMetadataAreaRegistration : AreaRegistration
    {
        public override string AreaName { get { return "FluentMetadata"; } }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "FluentMetadata_default",
                "FluentMetadata/{action}/{id}",
                new { controller = "FluentMetadata", action = "Index", id = UrlParameter.Optional }
            );

            ModelMetadataProviders.Current =
                new FluentMetadataProvider()
                    .ForModel<Contact>()
                        .ForProperty(m => m.FirstName)
                            .DisplayName("First Name")
                            .DataTypeName("string")
                        .ForProperty(m => m.LastName)
                            .DisplayName("Last Name")
                            .DataTypeName("string")
                        .ForProperty(m => m.EmailAddress)
                            .DisplayName("E-mail Address")
                            .DataTypeName("email");
        }
    }
}
