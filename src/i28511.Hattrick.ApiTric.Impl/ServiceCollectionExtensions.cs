using Microsoft.Extensions.DependencyInjection;

namespace i28511.Hattrick.ApiTrick.Impl
{
    /// <summary>
    /// HattrickServiceCollectionExtensions
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the ApiTrick provider.
        /// </summary>
        /// <param name="serviceCollection">The service collection.</param>
        /// <param name="options">The options.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">serviceCollection</exception>
        public static IServiceCollection AddApiTrickProvider(
            this IServiceCollection serviceCollection, OAuthOptions options = null)
        {
            if (serviceCollection == null) throw new ArgumentNullException(nameof(serviceCollection));
            
            serviceCollection.AddSingleton<IXmlApiProvider, XmlApiProvider>(_ => new XmlApiProvider(options));

            return serviceCollection;
        }
    }
}
