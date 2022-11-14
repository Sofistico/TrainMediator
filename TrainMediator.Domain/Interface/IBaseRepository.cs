using TrainMediator.Domain.Entities;

namespace TrainMediator.Domain.Interface
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        void Insert(TEntity entity);

        void Update(TEntity entity);

        TEntity Delete(TEntity entity);

        IEnumerator<TEntity> GetAll();

        TEntity GetEntity(int id);
    }
}
