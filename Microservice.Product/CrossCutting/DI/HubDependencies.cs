using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CrossCutting.DI
{
    public static class HubDependencies
    {
        public static void AddHubDependencies(this WebApplicationBuilder builder)
        {
            builder.Services.AddSignalR();
        }

    }
}
