using Nancy;

namespace OpenTokWebNancy.Modules
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureApplicationContainer(Nancy.TinyIoc.TinyIoCContainer container)
        {
            StaticConfiguration.DisableErrorTraces = false;

            base.ConfigureApplicationContainer(container);

            container.Register<OpenTokService>().AsSingleton();
        }
    }
}
