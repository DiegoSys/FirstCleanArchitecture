namespace NorthWind.Sales.BusinessObjects.ValueObjects
{
    public record struct OrderDetail(int ProductId, decimal Unitprice, short Quantity);
}
