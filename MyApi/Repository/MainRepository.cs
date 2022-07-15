using Dapper;
using MyApi.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MyApi.Repository
{
    public class MainRepository
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        public List<StudentReturnListModel> getList()
        {
            string sql = $@"
                         SELECT * FROM student 
						
                            ";
            List<StudentReturnListModel> res = connection.Query<StudentReturnListModel>(sql).ToList();

            return res;
        }

        public string userDelete(string id)
        {
            string sql = $@"
                            DELETE FROM student
                            WHERE id = '{id}' 						
                            ";
             connection.Query<string>(sql).ToList();
             return "";
        }

        public string userUpdate(string id, string name, string age, string from, string gender)
        {
            string sql = $@"
                            UPDATE student
		                    SET sName = '{name}', sAge = '{age}', sFrom = '{from}', sGender = '{gender}'	
                            WHERE id = '{id}' 						
                            ";
            connection.Query<string>(sql).ToList();
            return "";
        }



        //public List<StudentReturnListModel> getStudent(int id)
        //{
        //    string sql = $@"
        //                 SELECT * FROM student WHERE id = '{id}' 

        //                    ";
        //    List<StudentReturnListModel> res = connection.Query<StudentReturnListModel>(sql).ToList();

        //    return res;
        //}




    }
}