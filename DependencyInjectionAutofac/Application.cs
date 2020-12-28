using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionAutofac
{
    public class Application : IApplication
    {
        IBusinessLogic _businessLogic;
        public Application(IBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;

        }
        public void Run()
        {
            _businessLogic.ProcessData();
        }
    }
}
