using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerce.Classes
{
    public class CombosHelper : IDisposable
    {
        private static ECommerceContext db = new ECommerceContext();
        public static List<Department> GetDepartments()
        {
        var dep = db.Departments.ToList();
        dep.Add(new Department
            {
                DepartmentId = 0,
                Name = "[ Select a Department ]"
            });

            return dep = dep.OrderBy(d => d.Name).ToList();
        }

        public static List<City> GetCities()
        {
            var cit = db.Cities.ToList();
            cit.Add(new City
            {
                CityId = 0,
                Name = "[ Select a City ]"
            });

            return cit = cit.OrderBy(d => d.Name).ToList();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}