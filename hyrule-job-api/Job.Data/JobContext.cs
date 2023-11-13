using Cassandra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Cassandra.Storage;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Job.Data
{
    public class JobContext : DbContext
    {
        public JobContext(DbContextOptions<JobContext> options)
            : base(options) { }

        public DbSet<Core.Models.Job> Jobs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseCassandra("Contact Points=127.0.0.1;", "job", opt =>
            {
                opt.MigrationsHistoryTable(HistoryRepository.DefaultTableName);
            }, o =>
            {

                o.WithQueryOptions(new QueryOptions().SetConsistencyLevel(ConsistencyLevel.LocalOne))
                    .WithReconnectionPolicy(new ConstantReconnectionPolicy(1000))
                    .WithRetryPolicy(new DefaultRetryPolicy())
                    .WithLoadBalancingPolicy(new TokenAwarePolicy(Policies.DefaultPolicies.LoadBalancingPolicy))
                    .WithDefaultKeyspace(GetType().Name)
                    .WithPoolingOptions(
                    PoolingOptions.Create()
                        .SetMaxSimultaneousRequestsPerConnectionTreshold(HostDistance.Remote, 1_000_000)
                        .SetMaxSimultaneousRequestsPerConnectionTreshold(HostDistance.Local, 1_000_000)
                        .SetMaxConnectionsPerHost(HostDistance.Local, 1_000_000)
                        .SetMaxConnectionsPerHost(HostDistance.Remote, 1_000_000)
                        .SetMaxRequestsPerConnection(1_000_000)
                );
            });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var timeUuidConverter = new TimeUuidToGuidConverter();

            modelBuilder.EnsureKeyspaceCreated(new KeyspaceReplicationSimpleStrategyClass(2));

            modelBuilder.Entity<Core.Models.Job>()
                .ToTable("Jobs", "job")
                .HasKey(p => p.Id);

        }
    }
}
