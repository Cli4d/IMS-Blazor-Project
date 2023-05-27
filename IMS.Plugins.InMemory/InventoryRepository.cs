using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.Plugins.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {
        private List<Inventory> _inventories;

        public InventoryRepository()
        {
            _inventories = new List<Inventory>()
            {
                new Inventory {InventoryId = 1, InventoryName = "Laptops", Price=35000, Quantity=7},
                new Inventory {InventoryId = 2, InventoryName = "Mobile Phones", Price=18000, Quantity=21},
                new Inventory {InventoryId = 3, InventoryName = "Fridge", Price=75000, Quantity=12},
                new Inventory {InventoryId = 4, InventoryName = "Electric Kettles", Price=4000, Quantity=120},
                new Inventory {InventoryId = 5, InventoryName = "Blender", Price=5000, Quantity=15},
                new Inventory {InventoryId = 6, InventoryName = "Electric Iron", Price=3000, Quantity=23},
                new Inventory {InventoryId = 7, InventoryName = "Electric Cooker", Price=65000, Quantity=9}
            };
        }

        public async Task<IEnumerable<Inventory>> GetInventoryByNameAsync(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return await Task.FromResult(_inventories);
            return _inventories.Where(x => x.InventoryName.Contains(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}