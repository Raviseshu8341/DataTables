using SampleCore.Core.IRepositories;
using SampleCore.Core.Model;
using SampleCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class DataRepositories : IDataRepository
    {
        public sampleContext entity;
        public DataRepositories(sampleContext masterContext)
        {
            entity = masterContext;
        }
        public void CreateDataEntry(DataDetail dataDetail)
        {
            SampleCore.Entity.Data d = new SampleCore.Entity.Data();
            d.Id = dataDetail.Id;
            d.FirstName = dataDetail.FirstName;
            d.LastName = dataDetail.LastName;
            d.Email = dataDetail.Email;
            d.Address = dataDetail.Address;
            d.Phone = dataDetail.Phone;
            d.Password = dataDetail.password;
            d.Re_Type_Password = dataDetail.Re_Type_Password;
            d.Is_Delete = dataDetail.Is_Delete;
            entity.Data.Add(d);
            entity.SaveChanges();
        }
        public DataDetail SaveMethod(int id)
        {
            DataDetail dataDetail = new DataDetail();
            var d = entity.Data.Where(x => x.Id == id).SingleOrDefault();
            dataDetail.FirstName = d.FirstName;
            dataDetail.LastName = d.LastName;
            dataDetail.Email = d.Email;
            dataDetail.Address = d.Address;
            dataDetail.Phone = d.Phone;
            dataDetail.password = d.Password;
            dataDetail.Re_Type_Password =d.Re_Type_Password ;
            dataDetail.Is_Delete=d.Is_Delete ;
            entity.SaveChanges();
            return dataDetail;
        }
        public void Update(int id, Data m)
        {
            var a = entity.Data.Where(x => x.Id == id).SingleOrDefault();
            if (a != null)
            {
                a.FirstName = m.FirstName;
                a.LastName = m.LastName;
                a.Email = m.Email;
                a.Address = m.Address;
                a.Phone = m.Phone;
                a.Password = m.Password;
                a.Re_Type_Password = m.Re_Type_Password;
                a.Is_Delete = m.Is_Delete;
                entity.SaveChanges();   
            }
        }
        public void DeleteConform(int id)
        {
            var a = entity.Data.Where(x => x.Id == id).SingleOrDefault();
            entity.Remove(a);
            entity.SaveChanges();
        }
    }
}
