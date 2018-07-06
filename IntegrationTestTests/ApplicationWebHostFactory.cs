using IntegrationTest;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace IntegrationTestTests
{
    public class ApplicationWebHostFactory<TStartp> : WebApplicationFactory<Startup>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            base.ConfigureWebHost(builder);
        }
        protected override void ConfigureClient(HttpClient client)
        {
            base.ConfigureClient(client);
        }
    }
}
