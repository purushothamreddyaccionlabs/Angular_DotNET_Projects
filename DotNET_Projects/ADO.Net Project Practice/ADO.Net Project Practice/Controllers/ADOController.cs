using ADO.Net_Project_Practice.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace ADO.Net_Project_Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ADOController : ControllerBase
    {
        SqlConnection con = new SqlConnection(@"Server=ALIPL2670; Database=NewDatabase; Trusted_Connection=True; TrustServerCertificate=True");


        [HttpPost("InsertData")]
        public IActionResult CreateData(ADOTestTable data)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into ADOTest(Name,PhoneNO,Email) values('" + data.Name + "','" + data.PhoneNO + "','" + data.Email + "')",con);
            cmd.ExecuteNonQuery();
            con.Close();
            return Ok("Saved");
        }

        [HttpPut("Update/{id}")]
        public IActionResult Update(int id,ADOTestTable data)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update ADOTest set name= '" + data.Name + "', PhoneNO= '" + data.PhoneNO + "',Email='" + data.Email + "' where Id = '"+id+"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            return Ok(data);
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete ADOTest where Id = '" + id + "'",con);
            cmd.ExecuteNonQuery();
            con.Close();
            return Ok("Deleted");
        }

        // Insert data using SP's
        [HttpPost("Inserting")]
        public IActionResult Inserting(ADOTestTable data)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert_Data", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Name", data.Name));
            cmd.Parameters.Add(new SqlParameter("@PhoneNo", data.PhoneNO));
            cmd.Parameters.Add(new SqlParameter("@Email", data.Email));
            cmd.ExecuteNonQuery();
            con.Close();
            return Ok("Created");
        }
    }
}
