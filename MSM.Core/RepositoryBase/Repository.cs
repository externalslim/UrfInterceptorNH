using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using NHibernate;
using MSM.Core.UnitOfWork;

namespace MSM.Core.RepositoryBase
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected ISession Session { get { return NhUnitOfWork.Current.Session; } }

        #region Crud
        public int Create(TEntity entity)
        {
            var id = Session.Save(entity);
            return Convert.ToInt32(id);
        }
        public void Update(TEntity entity)
        {
            Session.Update(entity);
        }

        public void Delete(TEntity entity)
        {

            TEntity _entity = entity;
            _entity.GetType().GetProperty("IsDeleted").SetValue(_entity, true);
            this.Update(_entity);
        }
        #endregion

        #region Read
        public IEnumerable<TEntity> GetAll()
        {
            return Session.Query<TEntity>().ToList();
        }

        public List<TEntity> GetAllWithFilter(Expression<Func<TEntity, bool>> expression)
        {
            return Session.Query<TEntity>().Where(expression).ToList();
        }

        public TEntity GetWithFilter(Expression<Func<TEntity, bool>> expression = null)
        {
            if (expression != null)
                return Session.Query<TEntity>().Where(expression).SingleOrDefault();
            return Session.Query<TEntity>().SingleOrDefault();
        }

        #endregion


    }
}
