using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ECommerce.Startup))]
namespace ECommerce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //No Nuget, eu fiz o comando: Enable-Migrations -ContextTypeName ECommerceContext -EnableAutomaticMigrations -Force
            //Em Migrations> Configuration, inclui o comando AutomaticMigrationDataLossAllowed = true;
            //Para fazer a migração automática, foi necessário incluir o comando Database.SetInitializer(new MigrateDatabaseToLatestVersion<Models.ECommerceContext, Migrations.Configuration>()); em Global.asax


            ConfigureAuth(app);
        }
    }
}
