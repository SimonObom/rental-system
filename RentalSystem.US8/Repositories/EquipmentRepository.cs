using RentalSystem.US8.Models;

namespace RentalSystem.US8.Repositories;

public class EquipmentRepository(List<Equipment> equipment) : IEquipmentRepository
{
    public Equipment? Get(Guid id)
    {
        return equipment.FirstOrDefault(item => item.Id == id);
    }
}
