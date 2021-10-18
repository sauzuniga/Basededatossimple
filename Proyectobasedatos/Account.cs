using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Proyectobasedatos
{
    class Account
    {
        public int _idAccount { get; set; }
        public string _password { get; set; }
        public string _birthDate { get; set; }
        public string _owner { get; set;}
        public string _email { get; set; }
       
        private Crud cruds = new Crud();

        public MySqlDataReader getAllAccount()
        {
            string query = "SELECT idaccount,password,birthdate,owner,email FROM account";

            
            return crud.select(query);
        }
        private Crud crud = new Crud();

        
        public MySqlDataReader getAllBooks()
        {
            string query = "SELECT bookId,title,subtitle,ISBN,publishedDate FROM book";

            
            return crud.select(query);
        }

        
        public Boolean newEditAccount(string action)
        {
            if (action == "new")
            {
                string query = "INSERT INTO account(password, birthdate, owner, email)" +
                    "VALUES ('" + _password + "', '" + _birthDate + "', '" + _owner + "', '" + _email + "')";
                crud.executeQuery(query);
                return true;
            }
            else if (action == "edit")
            {
                string query = "UPDATE account SET "
                    + "password='" + _password + "' ,"
                    + "birthdate='" + _birthDate + "',"
                    + "owner='" + _owner + "',"
                    + "email='" + _email + "'"
                    + "WHERE "
                    + "idaccount='" + _idAccount + "'";
                crud.executeQuery(query);
                return true;
            }

            return false;
        }

        
        public Boolean deleteAccount()
        {
            string query = "DELETE FROM account WHERE idaccount='" + _idAccount + "'";
            crud.executeQuery(query);
            return true;
        }

    }
}
