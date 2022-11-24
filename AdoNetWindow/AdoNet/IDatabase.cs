using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet
{
    public interface IDatabase
    {
        public string ConnectionString { get; set; }
    }
}
