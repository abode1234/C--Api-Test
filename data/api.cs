using Microsoft.EntityFrameworkCore;


    public class ApisDbC : DbContext
{
    public ApisDbC(DbContextOptions<ApisDbC> options) : base(options) { }
    public required DbSet<Api> Apis {get; set ;}
}
