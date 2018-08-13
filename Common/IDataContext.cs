using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{

    public interface IDataContext
    {
        T Add<T>(T item) where T : class, IDataEntity, new();
        IList<T> Add<T>(List<T> itemList) where T : class, IDataEntity, new();
    
        T Update<T>(T item) where T : class, IDataEntity, new();
        List<T> Update<T>(List<T> itemList) where T : class, IDataEntity, new();
      
        bool Delete<T>(List<T> itemList) where T : class, IDataEntity, new();
        bool Delete<T>(T item) where T : class, IDataEntity, new();
      
        IList<T> Query<T>(IQuery queryCondition) where T : class, IDataEntity, new();
        IList<T> Query<T>(IQuery queryCondition, int pageIndex, int pageCount) where T : class, IDataEntity, new();  
    }

    public interface IDataEntityContent : IDataContext
    {
        TEntity Add<TEntity>(TEntity entity) where TEntity : IDataEntity;
        List<TEntity> Add<TEntity>(List<TEntity> entityList) where TEntity : IDataEntity;

        bool Update<TEntity>(TEntity entity) where TEntity : IDataEntity;
        bool Update<TEntity>(List<TEntity> entityList) where TEntity : IDataEntity;
        bool Update(ICriteria condiftion, object value);

        bool Delete<TEntity>(TEntity entity) where TEntity : IDataEntity;
        bool Delete<TEntity>(List<TEntity> entityList) where TEntity : IDataEntity;
        bool Delete(ICriteria condition);

        int GetCount(ICriteria condition);
        List<TEntity> Query<TEntity>(ICriteria condition);
        List<TEntity> Query<TEntity>(ICriteria condition, int pageIndex, int pageSize, ref int entityCount) where TEntity : IDataEntity;
        List<object> Query(ICriteria condiftion);
    }

    public interface IDataTableContent : IDataContext
    {

    }
}
