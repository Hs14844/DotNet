//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using BlazorSPA_CRUD.Data;
//using BlazorSPA_CRUD.Models;
//using Microsoft.Extensions.Logging;
//using Microsoft.Extensions.Options;

//namespace BlazorSPA_CRUD.Services
//{
//    public class EmployeeService
//    {
//        private readonly IHttpClientService _httpService;
//        ILogger<EmployeeService> _logger;
//        private readonly ConfigurationModel.APIEndPoints endPoints;


//            public EmployeeService(IHttpClientService httpService, ILogger<EmployeeService> logger,IOptions<ConfigurationModel.APIEndPoints> config)
//            {
//                _httpService = httpService;
//                endPoints = config?.Value;
//                _logger = logger;
//            }
        


//        public async Task GetBillStatus()
//        {
//            try
//            {
//                var response = await _httpService.GetAsyncCall(endPoints.GetNatureOfContractList);
//                if (response.IsSuccessStatusCode)
//                {
//                    var result = await response.Content.ReadAsStringAsync();
//                   // return JsonConvert.DeserializeObject<IEnumerable<Employee>>(result);
//                }
//            }
//            catch (Exception ex)
//            {
//                _logger.LogError("Exception Details {0}", "Error occured in GeneralInfoService Method GetAllContractNature" + ex);
//            }
//            //return null;

//        }

//        //public async Task<IList<Employee>> GetBillStates()
//        //{
//        //    try
//        //    {
//        //        IList<> result = new List<BillState>();
//        //        var response = await httpHelperclient.GetAsyncCall(BaseURL + "SearchAndViewBill/GetAllStates");
//        //        if (response.StatusCode == HttpStatusCode.OK)
//        //        {
//        //            result = JsonConvert.DeserializeObject<IList<BillState>>(response.ResponseContent);
//        //        }
//        //        return result;
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        logger.LogError("Error occured while getting Bill States: " + ex.Message);
//        //    }
//        //    return null;
//        //}

//        //To populate BillCategory Dropdown
//        //public async Task<IList<BillCategory>> GetBillCategory()
//        //{

//        //    try
//        //    {
//        //        IList<BillCategory> result = new List<BillCategory>();
//        //        var response = await httpHelperclient.GetAsyncCall(BaseURL + "SearchAndViewBill/GetAllBillCategory");
//        //        if (response.StatusCode == HttpStatusCode.OK)
//        //        {
//        //            result = JsonConvert.DeserializeObject<IList<BillCategory>>(response.ResponseContent);
//        //        }
//        //        return result;
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        logger.LogError("Error occured while getting Bill Category: " + ex.Message);
//        //    }
//        //    return null;
//        //}

//        ////To Get all the data in BillDetails Page from Bill Table
//        //public async Task<ViewBillDetails> GetBillDetails(int BillID)
//        //{
//        //    try
//        //    {
//        //        ViewBillDetails result = new ViewBillDetails();
//        //        var response = await httpHelperclient.PostAsyncCall(BaseURL + "SearchAndViewBill/GetBillDetail", BillID);
//        //        if (response.StatusCode == HttpStatusCode.OK)
//        //        {
//        //            result = JsonConvert.DeserializeObject<IList<ViewBillDetails>>(response.ResponseContent).FirstOrDefault();
//        //        }
//        //        return result;
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        logger.LogError("Error occured while getting Bill Details: " + ex.Message);
//        //    }
//        //    return null;
//        //}

//        //To Get all the data in BillDetails Page from ccm View 
//        //public async Task<ViewContractDetails> GetContractDetailsForBill(int Bill)
//        //{
//        //    try
//        //    {
//        //        ViewContractDetails result = new ViewContractDetails();
//        //        EmployeeDetailsInputParameters eEmployeeDetailsInputParameters = new EmployeeDetailsInputParameters();
//        //        eEmployeeDetailsInputParameters.FkBill = Bill;

//        //        var response = await httpHelperclient.PostAsyncCall(BaseURL + "SearchAndViewBill/GetContractDetailsForBill", eEmployeeDetailsInputParameters);

//        //        if (response.StatusCode == HttpStatusCode.OK)
//        //        {
//        //            result = JsonConvert.DeserializeObject<IList<ViewContractDetails>>(response.ResponseContent).FirstOrDefault();
//        //        }
//        //        return result;
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        logger.LogError("Error occured while getting Contract Details for Bill: " + ex.Message);
//        //    }
//        //    return null;
//        //}

//        //SP and API has to be created BillDetails page Grid.

//    }
//}
