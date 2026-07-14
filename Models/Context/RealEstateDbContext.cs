using Microsoft.EntityFrameworkCore;
using WebSite.Models;

public class RealEstateDbContext : DbContext
{
    public RealEstateDbContext(DbContextOptions<RealEstateDbContext> options)
        : base(options)
    {
    }

    public DbSet<Property> Property { get; set; }
    public DbSet<Advertisement> Advertisement { get; set; }
    public DbSet<Applicant> Applicant { get; set; }
    public DbSet<Deal> Deal { get; set; }
    public DbSet<Floor> Floor { get; set; }
    public DbSet<Location> Location { get; set; }
    public DbSet<City> City { get; set; }
    public DbSet<Province> Province { get; set; }
    public DbSet<Neighborhood> Neighborhood { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<Agent> Agents { get; set; }
    public DbSet<Article> Articles { get; set; }
    public DbSet<Supplier> Supplier { get; set; }
    public DbSet<Tag> Tag { get; set; }
    public DbSet<Room> Room { get; set; }
    public DbSet<PropertyImage> PropertyImage { get; set; }
    public DbSet<StaticData> StaticDatas { get; set; }
    public DbSet<StaticDataGroup> StaticDataGroups { get; set; }

    // Relation Tables
    public DbSet<Location_CityRelation> Location_CityRelations { get; set; }
    public DbSet<Property_Advertisement_FloorRelation> Property_Advertisement_FloorRelations { get; set; }
    public DbSet<Property_Applicant_FloorRelation> Property_Applicant_FloorRelations { get; set; }
    public DbSet<Property_Deal_FloorRelation> Property_Deal_FloorRelations { get; set; }
    public DbSet<Property_FloorRelation> Property_FloorRelations { get; set; }
    public DbSet<Property_Location_FloorRelation> Property_Location_FloorRelations { get; set; }
    public DbSet<Property_PropertyImage_FloorRelation> Property_PropertyImage_FloorRelations { get; set; }
    public DbSet<Property_Supplier_FloorRelation> Property_Supplier_FloorRelations { get; set; }
    public DbSet<Property_Tag_FloorRelation> Property_Tag_FloorRelations { get; set; }
    public DbSet<Floor_RoomRelation> Floor_RoomRelations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Location_CityRelation>().ToTable("Location_CityRelation");
        modelBuilder.Entity<Property_Advertisement_FloorRelation>().ToTable("Property_Advertisement_FloorRelation");
        modelBuilder.Entity<Property_Applicant_FloorRelation>().ToTable("Property_Applicant_FloorRelation");
        modelBuilder.Entity<Property_Deal_FloorRelation>().ToTable("Property_Deal_FloorRelation");
        modelBuilder.Entity<Property_FloorRelation>().ToTable("Property_FloorRelation");
        modelBuilder.Entity<Property_Location_FloorRelation>().ToTable("Property_Location_FloorRelation");
        modelBuilder.Entity<Property_PropertyImage_FloorRelation>().ToTable("Property_PropertyImage_FloorRelation");
        modelBuilder.Entity<Property_Supplier_FloorRelation>().ToTable("Property_Supplier_FloorRelation");
        modelBuilder.Entity<Property_Tag_FloorRelation>().ToTable("Property_Tag_FloorRelation");
        modelBuilder.Entity<Floor_RoomRelation>().ToTable("Floor_RoomRelation");
    }
}