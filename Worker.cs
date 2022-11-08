using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamWork
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Operation> OperationList { get; set; } = new List<Operation>();

        public Operation GetOperationByName(string Name)
        {
            foreach (var operation in OperationList)
            {
                if (operation.Name == Name)
                    return operation;
            }

            return null;
        }
    }
}
