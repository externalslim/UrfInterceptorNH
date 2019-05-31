using MSM.Core.RepositoryBase;
using MSM.Core.UnitOfWork;
using System;
using System.Reflection;

namespace MSM.Core.Dependencies.UoW
{
    public static class UnitOfWorkHelper
    {
        public static bool IsRepositoryMethod(MethodInfo methodInfo)
        {
            return IsRepositoryClass(methodInfo.DeclaringType);
        }

        public static bool IsRepositoryClass(Type type)
        {
            return typeof(IRepository).IsAssignableFrom(type);
        }

        public static bool HasUnitOfWorkAttribute(MethodInfo methodInfo)
        {
            return methodInfo.IsDefined(typeof(UnitOfWorkAttribute), true);
        }
    }
}
