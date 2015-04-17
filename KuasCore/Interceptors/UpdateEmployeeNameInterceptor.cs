using AopAlliance.Intercept;
using KuasCore.Models;
using System;
using System.Diagnostics;

namespace KuasCore.Interceptors
{
    class UpdateEmployeeNameInterceptor : IMethodInterceptor
    {

        public object Invoke(IMethodInvocation invocation)
        {
            Console.WriteLine("DebogLogInterceptor 攔截到一個方法呼叫 = [{0}]", invocation);
            Debug.Print("DebogLogInterceptor 攔截到一個方法呼叫 = [{0}]", invocation);

            Employee result = (Employee)invocation.Proceed();

            result.Name =  result.Name + " success~~~" ;

            Console.WriteLine("回傳的資料已取得 [{0}]", result);
            Debug.Print("回傳的資料已取得 [{0}]", result);

            return result;
        }
    }
}
