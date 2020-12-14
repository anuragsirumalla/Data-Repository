using System;
using System.Reflection;
namespace interfaces
{
    class DynamicRepositoy
    {
        public static IOperations GetRepositoryName(String repoName)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Type RespositoryType = executingAssembly.GetType(repoName);
            object RespositoryInstance = Activator.CreateInstance(RespositoryType);
            return RespositoryInstance as IOperations;
        }
    }
}