namespace WebSite.Models;

// مدل تغییرات قیمت ملک
public class PropertyPriceChange
{
    public long Id { get; set; }

    public string PropertyId { get; set; }

    public long? SalePrice { get; set; }

    public long? MortgagePrice1 { get; set; }

    public long? RentPrice1 { get; set; }

    public long? MortgagePrice2 { get; set; }

    public long? RentPrice2 { get; set; }

    public int EditDate { get; set; }
}