using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class RealEstateDbContext : DbContext
{
    public RealEstateDbContext(DbContextOptions<RealEstateDbContext> options)
        : base(options)
    {
    }

    // DbSet ها برای هر مجموعه از موجودیت ها
    public DbSet<Advertisement> Advertisements { get; set; }
    public DbSet<House> Houses { get; set; }
    public DbSet<Floor> Floors { get; set; }
    public DbSet<Deal> Deals { get; set; }
    public DbSet<Status> Statuses { get; set; }
    public DbSet<Keyword> keywords{ get; set; }
    public DbSet<Material> materials { get; set; }
    public DbSet<StaticData> staticDatas { get; set; }
    public DbSet<StaticDataGroup> staticDataGroups { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);       
    }
}
