using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;

namespace DemoIoC.Web.IoC
{
    public static class ServiceLocator
    {
        private static IKernel _kernel;

        public static void SetServiceLocator(IKernel kernel)
        {
            _kernel = kernel;
        }

        public static TObject Resolve<TObject>()
        {
            return _kernel.Get<TObject>();
        }
    }
}