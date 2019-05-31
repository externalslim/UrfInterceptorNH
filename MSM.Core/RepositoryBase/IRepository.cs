using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MSM.Core.RepositoryBase
{
    public interface IRepository
    {

    }

    public interface IRepository<TEntity> : IRepository where TEntity : class
    {
        #region Read Block

        /// <summary>
        /// Global Get All Method
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// Global Get With Filter Method. Expression is optional
        /// </summary>
        /// <param name="expression">x => x.Column == input.Column etc</param>
        /// <returns></returns>
        TEntity GetWithFilter(Expression<Func<TEntity, bool>> expression = null);

        /// <summary>
        /// Global Get All With Filter. Difference between Get With Filter is Return Type -> List
        /// </summary>
        /// <param name="expression">x => x.Column == input.Column etc</param>
        /// <returns></returns>
        List<TEntity> GetAllWithFilter(Expression<Func<TEntity, bool>> expression);
        #endregion

        #region Create Update Delete Block

        /// <summary>
        /// Global Create Method
        /// </summary>
        /// <param name="entity">input model</param>
        /// <returns></returns>
        int Create(TEntity entity);

        /// <summary>
        /// Global Update Method
        /// </summary>
        /// <param name="entity">input model</param>
        void Update(TEntity entity);

        /// <summary>
        /// Global Delete Method
        /// </summary>
        /// <param name="entity">input model</param>
        void Delete(TEntity entity);
        #endregion
    }
}
