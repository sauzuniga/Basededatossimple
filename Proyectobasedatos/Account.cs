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

        //metodo para retornar los registros de la tabla Book
        public MySqlDataReader getAllBooks()
        {
            string query = "SELECT bookId,title,subtitle,ISBN,publishedDate FROM book";

            //llamado al metodo select de la clase Crud
            return crud.select(query);
        }

        //metodo para insertar o editar un registro
        public Boolean newEditAccount(string action)
        {
            if (action == "new")
            {
                string query = "INSERT INTO account(password, birthdate, owner, email)" +
                    "VALUES ('" + _password + "', '" + _birthDate + "', '" + _owner + "', '" + _email + "')";
                crud.executeQuery(query); //llamato al metodo executeQuery de la clase Crud
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

        //metodo para eliminar
        public Boolean deleteBook()
        {
            string query = "DELETE FROM book WHERE bookId='" + _idAccount + "'";
            crud.executeQuery(query);
            return true;
        }

    }
}
