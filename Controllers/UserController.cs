using System.Data;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Dtos;

namespace WebApi.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public UserController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        public JsonResult Post(UserDto user)
        {
            string query = @"
                           insert into dbo.Users
                           (user_id, name_user, email, created_at)
                           values (@user_id, @name_user, @email, @created_at)
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("database");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {   
                    myCommand.Parameters.AddWithValue("@user_id", user.user_id = Guid.NewGuid());
                    myCommand.Parameters.AddWithValue("@name_user", user.name_user);
                    myCommand.Parameters.AddWithValue("@email", user.email);
                    myCommand.Parameters.AddWithValue("@created_at", user.created_at = DateTime.Now);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Created User");
        }

        [HttpGet("get-all")]
        public JsonResult Get()
        {
            string query = @"
                            select 
                                user_id, 
                                name_user, 
                                email, 
                                created_at, 
                                updated_at 
                            from
                                dbo.Users
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("database");
            SqlDataReader myReader;
            using(SqlConnection myCon=new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using(SqlCommand myCommand=new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }

        [HttpGet("get-by-id/{user_id}")]
        public JsonResult GetById(string user_id)
        {
            string query = @"
                            select * from
                            dbo.Users
                            where user_id=@user_id
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("database");
            SqlDataReader myReader;
            using(SqlConnection myCon=new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using(SqlCommand myCommand=new SqlCommand(query, myCon))
                {   
                    myCommand.Parameters.AddWithValue("@user_id", user_id);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }

        [HttpPut("{user_id}")]
        public JsonResult Put(string user_id, UserUpdateDto user)
        {
            string query = @"
                           update dbo.Users
                           set 
                            name_user=@name_user,
                            email=@email,
                            updated_at=@updated_at
                            where user_id=@user_id
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("database");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@user_id", user_id);
                    myCommand.Parameters.AddWithValue("@name_user", user.name_user);
                    myCommand.Parameters.AddWithValue("@email", user.email);
                    myCommand.Parameters.AddWithValue("@updated_at", user.updated_at = DateTime.Now);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Updated User");
        }

        [HttpDelete("{user_id}")]
        public JsonResult Delete(string user_id)
        {
            string query = @"
                           delete from dbo.Users
                            where user_id=@user_id
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("database");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@user_id", user_id);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Deleted user");
        }
    }
}