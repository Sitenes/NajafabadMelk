using Microsoft.EntityFrameworkCore;
using WebSite.Models;

public class RealEstateDbContext : DbContext
{
    public RealEstateDbContext(DbContextOptions<RealEstateDbContext> options)
        : base(options)
    {
    }

    public DbSet<Property> Properties { get; set; }
    public DbSet<Advertisement> Advertisements { get; set; }
    public DbSet<Applicant> Applicants { get; set; }
    public DbSet<Deal> Deals { get; set; }
    public DbSet<Floor> Floors { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Province> Provinces { get; set; }
    public DbSet<Neighborhood> Neighborhoods { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<PropertyImage> PropertyImages { get; set; }
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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configuration if needed
    }
}
