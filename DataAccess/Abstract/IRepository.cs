namespace ConsoleApp.DataAccess.Abstract {
    public interface IRepository<TEntity> {
    TEntity getById(int id);
    void update(TEntity entity);
    void create(TEntity entity);
     void delete(int id);
    
}
}