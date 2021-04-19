using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace KubernetesHealthChecks
{
    public class ReadyHealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            if (DateTime.Now.Second % 15 != 0)
            {
                return Task.FromResult(
                    HealthCheckResult.Healthy("A healthy result."));
            }
            else 
            { 
                return Task.FromResult(
                    HealthCheckResult.Degraded("An unhealthy result."));
            }
        }
    }
}
