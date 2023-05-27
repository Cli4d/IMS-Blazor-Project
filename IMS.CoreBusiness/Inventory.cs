namespace IMS.CoreBusiness
{
    public class Inventory
    {
        public int InventoryId
        {
            get; set;
        }
        public string InventoryName
        {
            get; set;
        } = string.Empty;

        public double Price
        {
        get; set; }

        public int Quantity
        {
        get; set; }
    }
}