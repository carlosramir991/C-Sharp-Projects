using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller

    {

        public ActionResult Index()
        {
            return View();
        }

       

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Admin()
        {
            string queryString = @"SELECT FirstName, LastName, EmailAddress, DateOfBirth, CarYear, CarMake, CarModel, DUI, SpeedingTickets,CoverageType,Quote";
            List<Table> quotes = new List<Table>();
            string connectionString = @"Z:\Desktop\CarInsurance\CarInsurance\App_Data\Insurance.mdf";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var quote = new Table();
                    quote.Id = Convert.ToInt32(reader["Id"]);
                    quote.FirstName = reader["FirstName"].ToString();
                    quote.LastName = reader["LastName"].ToString();
                    quote.EmailAddress = reader["EmailAddress"].ToString();
                    quote.DateOfBirth = reader["DateOfBirth"].ToString();
                    quote.CarYear = Convert.ToInt32(reader["CarYear"]);
                    quote.CarMake = reader["CarMake"].ToString();
                    quote.CarModel = reader["CarModel"].ToString();
                    quote.DUI = reader["DUI"].ToString();
                    quote.SpeedingTickets = Convert.ToInt32(reader["SpeedingTickets"]);
                    quote.CoverageType = reader["CoverageType"].ToString();
                    quote.Quote = Convert.ToInt32(reader["Quote"]);



                }
            }
                return View(quotes);
        }
    }
}