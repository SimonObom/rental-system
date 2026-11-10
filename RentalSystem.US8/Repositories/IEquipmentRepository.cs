using RentalSystem.US8.Models;

namespace RentalSystem.US8.Repositories;

public interface IEquipmentRepository
{
    Equipment? Get(Guid id);
}
