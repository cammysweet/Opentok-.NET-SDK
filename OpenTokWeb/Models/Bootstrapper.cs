using Nancy;

namespace OpenTokWeb.Models
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureApplicationContainer(Nancy.TinyIoc.TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);

            container.Register<OpenTokService>().AsSingleton();
        }
    }
}
