using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Caching.Memory;

namespace DataAccessLibrary
{
    public class CacheDataAccess
    {
        private readonly IMemoryCache memoryCache;

        public CacheDataAccess(IMemoryCache memoryCache)
        {
            this.memoryCache = memoryCache;
        }

        //public List<CustomerModel> GetCustomer()
        //{
        //    List<CustomerModel> customerList = new();
        //    customerList.Add(new() { FirstName = "İsmail", LastName = "Türk" });
        //    customerList.Add(new() { FirstName = "Necati", LastName = "Yıldırım" });
        //    customerList.Add(new() { FirstName = "Eren", LastName = "Güzel" });
        //    customerList.Add(new() { FirstName = "Berkay", LastName = "Çetin" });
        //    customerList.Add(new() { FirstName = "Sungur", LastName = "Sevgilice" });
        //    customerList.Add(new() { FirstName = "Mustafa ", LastName = "Aslan" });
        //    customerList.Add(new() { FirstName = "Özcan", LastName = "Köseoğlu" });
        //    customerList.Add(new() { FirstName = "Burak", LastName = "Çınar" });

        //    Thread.Sleep(2000);

        //    return customerList;

        //}

        public Task<List<CustomerModel>> GetCustomerCache()
        {
            List<CustomerModel> customerModels;

            customerModels = memoryCache.Get<List<CustomerModel>>("customers");

            if (customerModels is null)
            {
                customerModels = new();
                customerModels.Add(new() { FirstName = "İsmail", LastName = "Türk" });
                customerModels.Add(new() { FirstName = "Necati", LastName = "Yıldırım" });
                customerModels.Add(new() { FirstName = "Eren", LastName = "Güzel" });
                customerModels.Add(new() { FirstName = "Berkay", LastName = "Çetin" });
                customerModels.Add(new() { FirstName = "Sungur", LastName = "Sevgilice" });
                customerModels.Add(new() { FirstName = "Mustafa ", LastName = "Aslan" });
                customerModels.Add(new() { FirstName = "Özcan", LastName = "Köseoğlu" });
                customerModels.Add(new() { FirstName = "Burak", LastName = "Çınar" });

                Thread.Sleep(2000);

                memoryCache.Set("customers", customerModels, TimeSpan.FromMinutes(1));
            }




            return Task.FromResult(customerModels);


        }


    }
}
