using IMS.CoreBusiness;

namespace IMS.UseCases.Inventories
{
    public interface IViewInventoryByNameUseCase
    {
        Task<IEnumerable<Inventory>> ExecuteAsync(string name = "");
    }
}