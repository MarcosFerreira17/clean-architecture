using System;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Serilog.Sinks.Elasticsearch;

namespace Costumer.Host.Configurations;

public static class ElasticSearchConfiguration
{
    public static ElasticsearchSinkOptions ConfigureELS(IConfigurationRoot configuration, string env)
    {
        return new ElasticsearchSinkOptions(new Uri(configuration["ELKConfiguration:Uri"]))
        {
            //Must be renamed == AutoRegisterCostumer, the project has a conflict with namespaces 
            AutoRegisterTemplate = true,
            IndexFormat = $"{Assembly.GetExecutingAssembly().GetName().Name.ToLower()}-{env.ToLower().Replace(".", "-")}-{DateTime.UtcNow:yyyy-MM}"
        };
    }
}
