using SampleCore.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Services.Services.Service;
using SampleCore.Core.IServices;
using SampleCore.Core.IRepositories;
using SampleCore.Entity;

namespace Services.Services
{
    public class Service
    {
        public class DataServices : IDataService
        {
            private readonly IDataRepository _dataRepository;
            public DataServices(IDataRepository dataRepository)
            {
                _dataRepository = dataRepository;
            }
            public void CreateDataEntry(DataDetail detail)
            {
                //business condition
                if (detail.FirstName != string.Empty && detail.FirstName != string.Empty)
                {
                    _dataRepository.CreateDataEntry(detail);
                }
            }
            public DataDetail SaveMethod(int id)
            {
                return _dataRepository.SaveMethod(id);
            }
            public void Update(int id, Data m)
            {
                 _dataRepository.Update( id, m);
            }
            public void DeleteConform(int id)
            {
                _dataRepository.DeleteConform(id);
            }

        }
    }
}
