using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace WebApi.ViewModel
{
    public class AppHealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(HealthCheckResult.Healthy());
        }
    }

    public class HealthResult
    {
        public string? Status { get; set; }
        public DateTime Timestamp{ get; set; }
        public string? HostName { get; set; }
    }
}
