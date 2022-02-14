using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tododo
{
    class Service:Repository
    {
        // Create(string name, int price);
        // Delete(int id);
        public List<Product> GET()
        {
            FindAll();
            return new List<Product>(); 
        }
        
        // FindByID(int ID);
        // Update(int ID, string name, int price);
    }
}
