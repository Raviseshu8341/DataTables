using SampleCore.Core.Model;
using SampleCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCore.Core.IRepositories
{
    public interface IDataRepository
    {
        void CreateDataEntry(DataDetail detail);
        DataDetail SaveMethod(int id);
        void Update(int id, Data m);
        void DeleteConform(int id);


    }
}
