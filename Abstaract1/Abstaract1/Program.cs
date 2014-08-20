using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstaract1
{
    class Program
    {
        static void Main(string[] args)
        {
            var mc = new MyClass();
        }
    }


    public interface IBaseInterface
    {
        string Hello();
    }

    public abstract class MyAbstractClass : IBaseInterface
    {
        public abstract void TurnOn();

        public virtual string TurnOff()
        {
            return "Hellloooo From Virtual";
        }

        public string Hello()
        {
            return "Hellloooo From IBASEINTERFACE METHOD";
        }
    }


    public class MyClass : MyAbstractClass
    {

        public override void TurnOn()
        {
            throw new NotImplementedException();
        }

        public override string TurnOff()
        {
            return base.TurnOff();
        }
    }

}
