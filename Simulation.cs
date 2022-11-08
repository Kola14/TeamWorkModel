using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamWork
{
    internal class Simulation
    {
        public List<Worker> WorkerList { get; set; } = new List<Worker>();
        public Worker FirstWorker { get; private set; }

        public String WorkTime { get; private set; }


        public void Simulate()
        {
            if (WorkerList.Count < 2)
            {
                throw new Exception("Not enough workers for simulation");
            }

            if (WorkerList.Count > 2)
            {
                throw new Exception("Too many workers for this simulation");
            }

            var rndGen = new Random();
            var rnd = rndGen.Next();

        }

        public Worker GetWorkerById(int Id)
        {
            foreach (var worker in WorkerList)
            {
                if (worker.Id == Id)
                    return worker;
            }

            return null;
        }
    }
}
