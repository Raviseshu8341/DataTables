using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleCore.Core.Model;
using SampleCore.Entity;

namespace SampleCore.Core.IServices
{
    public interface IDataService
    {
        void CreateDataEntry(DataDetail detail);
        DataDetail SaveMethod(int id);
        void Update(int id, Data m);
        void DeleteConform(int id);
    }
}
