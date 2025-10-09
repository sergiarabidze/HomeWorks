using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework12
{
    public interface IActor
    {
        void PerformScene(string sceneType);
    }

    public class MainActor : IActor
    {
        public void PerformScene(string sceneType)
        {
            Console.WriteLine($"Main actor performs {sceneType} scene.");
        }
    }

    public class StuntDouble : IActor
    {
        public void PerformScene(string sceneType)
        {
            Console.WriteLine($"Stunt double performs dangerous {sceneType} scene!");
        }
    }

    public class ProxyActor : IActor
    {
        private readonly MainActor _mainActor = new();
        private readonly StuntDouble _stuntDouble = new();

        public void PerformScene(string sceneType)
        {
            if (sceneType.ToLower().Contains("danger"))
                _stuntDouble.PerformScene(sceneType);
            else
                _mainActor.PerformScene(sceneType);
        }
    }

}
