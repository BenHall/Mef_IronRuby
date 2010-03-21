using System.ComponentModel.Composition;

using ClassLibrary1;

namespace ConsoleApplication1
{
    [Export(typeof(IContract))]
    public class DefaultContract : IContract
    {
        public string GetName()
        {
            return "chris";
        }
    }
}