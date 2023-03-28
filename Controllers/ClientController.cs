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
    public class ClientController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public ClientController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        public JsonResult Post(ClientDto client)
        {
            string query = @"
                           insert into dbo.Clients
                           (client_id, name_client, user_id, created_at)
                           values (@client_id, @name_client, @user_id, @created_at)
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("database");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {   
                    myCommand.Parameters.AddWithValue("@client_id", client.client_id = Guid.NewGuid());
                    myCommand.Parameters.AddWithValue("@name_client", client.name_client);
                    myCommand.Parameters.AddWithValue("@user_id", client.user_id);
                    myCommand.Parameters.AddWithValue("@created_at", client.created_at = DateTime.Now);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Created Client");
        }

        [HttpGet("get-all")]
        public JsonResult Get()
        {
            string query = @"
                            select 
                                *
                            from
                                clients
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

        [HttpGet("get-by-id/{client_id}")]
        public JsonResult GetById(string client_id)
        {
            string query = @"
                            select 
                                c.client_id, 
                                c.name_client,
                                c.user_id,
                                u.name_user,
                                c.created_at, 
                                c.updated_at
                            from
                                clients as c
                            inner join users as u
                            on u.user_id = c.user_id
                            where c.client_id = @client_id
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("database");
            SqlDataReader myReader;
            using(SqlConnection myCon=new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using(SqlCommand myCommand=new SqlCommand(query, myCon))
                {   
                    myCommand.Parameters.AddWithValue("@client_id", client_id);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }

        [HttpGet("get-clients-by-user/{user_id}")]
        public JsonResult GetClientsByUser(string user_id)
        {
            string query = @"
                            select
                                c.name_client,
                                c.client_id,
                                u.name_user,
                                u.email,
                                c.created_at, 
                                c.updated_at
                            from clients as c
                            inner join users  as u
                            on u.user_id = c.user_id 
                            where c.user_id = @user_id
                            order by c.name_client
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

        [HttpPut("{client_id}")]
        public JsonResult Put(string client_id, ClientUpdateDto client)
        {
            string query = @"
                           update dbo.clients
                           set 
                            name_client=@name_client,
                            user_id=@user_id,
                            updated_at=@updated_at
                            where client_id=@client_id
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("database");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@client_id", client_id);
                    myCommand.Parameters.AddWithValue("@name_client", client.name_client);
                    myCommand.Parameters.AddWithValue("@user_id", client.user_id);
                    myCommand.Parameters.AddWithValue("@updated_at", client.updated_at = DateTime.Now);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Updated client");
        }

        [HttpDelete("{client_id}")]
        public JsonResult Delete(string client_id)
        {
            string query = @"
                           delete from dbo.Clients
                            where client_id=@client_id
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("database");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@client_id", client_id);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Deleted client");
        }

    }
}