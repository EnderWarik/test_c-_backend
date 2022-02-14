using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Tododo
{
    class Repository 
    {
        //создавать конекшен отдельным классом, чтобы он создавался в единственном экземпляре.
        // создать поле в классе, инжектить в конструкторе
        public MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=EnderWarAdmin;database=firstdb");
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }






        public void Create(string name, int price)
        {
            OpenConnection();
            MySqlCommand mySqlCommand = new MySqlCommand($"INSERT INTO Product(Name,Price) VALUES ('{name}',{price})", connection);
            mySqlCommand.ExecuteNonQuery();
            Console.WriteLine("exelent");
            CloseConnection();

        }
        public void Delete(int id)
        {
            OpenConnection();
            MySqlCommand mySqlCommand = new MySqlCommand($"DELETE FROM Product WHERE ID={id}", connection);
            mySqlCommand.ExecuteNonQuery();
            CloseConnection();
        }
        public List<Product> FindAll()
        {
            OpenConnection();
            List<Product> listProduct = new List<Product>();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM Product", connection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            if (mySqlDataReader.HasRows)
            {

                while (mySqlDataReader.Read())
                {
                    listProduct.Add(new Product { ID = Convert.ToInt32(mySqlDataReader[0]), Name = mySqlDataReader[1].ToString(), Price = Convert.ToInt32(mySqlDataReader[2]) });

                }

            }
            
            mySqlDataReader.Close();
            return listProduct;
            foreach (Product product in listProduct)
            {
                Console.WriteLine(product);
            }
            CloseConnection();
        }
        public void FindByID(int ID)
        {
            OpenConnection();
            MySqlCommand mySqlCommand = new MySqlCommand($"SELECT * FROM Product WHERE ID={ID}", connection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            List<Product> listProduct = new List<Product>();
            if (mySqlDataReader.HasRows)
            {

                while (mySqlDataReader.Read())
                {
                    listProduct.Add(new Product { ID = Convert.ToInt32(mySqlDataReader[0]), Name = mySqlDataReader[1].ToString(), Price = Convert.ToInt32(mySqlDataReader[2]) });

                }

            }

            mySqlDataReader.Close();
            foreach (Product product in listProduct)
            {
                Console.WriteLine(product);
            }
            CloseConnection();
        }

        public void Update(int ID, string name, int price)
        {
            OpenConnection();
            MySqlCommand mySqlCommand = new MySqlCommand($"UPDATE Product SET Name='{name}',Price={price} WHERE ID={ID}", connection);
            mySqlCommand.ExecuteNonQuery();
            CloseConnection();
        }


    }
}
