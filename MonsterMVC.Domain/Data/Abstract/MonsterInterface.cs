using MonsterMVC.Domain.DomainModel;
using System.Threading.Tasks;

namespace MonsterMVC.Domain.Data.Abstract
{
    public interface IMonsterService
    {
        Task<Monster> GetMonsterAsync(int id);
    }
}
