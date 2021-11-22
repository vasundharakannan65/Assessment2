using CustomerFeedBackFormWebAPI.Interfaces;
using CustomerFeedBackFormWebAPI.ViewModels;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerFeedBackFormWebAPI.Repositories
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly IConfiguration _configuration;

        public FeedbackRepository(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        //Create
        public void Create(CustomerForm customerForm)
        {
            using IDbConnection dbConnection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));

            string sp = "[dbo].[SP_CustomerFeedback]";

            DynamicParameters parameters = new();

            parameters.Add("Title", customerForm.Title);
            parameters.Add("Name", customerForm.Name);
            parameters.Add("Initials", customerForm.Initials);
            parameters.Add("EmailId", customerForm.EmailId);
            parameters.Add("StreetAddress1", customerForm.StreetAddress1);
            parameters.Add("StreetAddress2", customerForm.StreetAddress2);
            parameters.Add("City", customerForm.City);
            parameters.Add("ZipCode", customerForm.ZipCode);
            parameters.Add("Region", customerForm.Region);
            parameters.Add("Country", customerForm.Country);
            parameters.Add("RatingId", customerForm.RatingId);
            parameters.Add("ProductId", customerForm.ProductId);
            parameters.Add("Information", customerForm.Information);
            parameters.Add("ReasonForUnsatisfactory", customerForm.ReasonForUnsatisfactory);
            parameters.Add("FileUpload", customerForm.FileUpload);


            SqlMapper.Execute(dbConnection, sp, commandType: CommandType.StoredProcedure, param: parameters);

        } 

        //GetFeedbackInfo 
        public async Task<FeedbackViewModel> GetFeedbackInfo()
        {
            using IDbConnection dbConnection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));

            string sp = "[dbo].[SP_GetFeedbackInfo]";

            return await Task.FromResult(dbConnection.Query<FeedbackViewModel>(sp, commandType: CommandType.StoredProcedure).FirstOrDefault());
        }
    }
}
