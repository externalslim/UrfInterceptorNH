using Castle.DynamicProxy;
using NHibernate;
using System;
using System.Reflection;
using MSM.Core.UnitOfWork;
using IInterceptor = Castle.DynamicProxy.IInterceptor;

namespace MSM.Core.Dependencies.UoW
{
    public class UnitOfWorkInterceptor : IInterceptor
    {
        private readonly ISessionFactory _sessionFactory;

        /// <summary>
        /// Creates a new UnitOfWorkInterceptor object.
        /// </summary>
        /// <param name="sessionFactory">Nhibernate session factory.</param>
        public UnitOfWorkInterceptor(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }

        public void Intercept(IInvocation invocation)
        {
            //If there is a running transaction, just run the method
            if (NhUnitOfWork.Current != null || !RequiresDbConnection(invocation.MethodInvocationTarget))
            {
                invocation.Proceed();
                return;
            }

            try
            {
                NhUnitOfWork.Current = new NhUnitOfWork(_sessionFactory);
                NhUnitOfWork.Current.BeginTransaction();

                try
                {
                    invocation.Proceed();
                    NhUnitOfWork.Current.Commit();
                }
                catch (Exception ex)
                {
                    //logging here
                    NhUnitOfWork.Current.Rollback();
                }
            }
            finally
            {
                NhUnitOfWork.Current = null;
            }
        }
        private static bool RequiresDbConnection(MethodInfo methodInfo)
        {
            if (UnitOfWorkHelper.HasUnitOfWorkAttribute(methodInfo))
            {
                return true;
            }

            if (UnitOfWorkHelper.IsRepositoryMethod(methodInfo))
            {
                return true;
            }

            return false;
        }
    }
}
