using BlazorBootstrap;
using DemoShared.Models.Entities;
using Microsoft.AspNetCore.Components;

namespace DemoWeb.Pages.Information
{
    public partial class EmployeeInformation : ComponentBase
    {
        #region Const
        private const string EMPLOYEE_INFORMATION = "技術者情報";
        private const string TECH_ID = "技術者ID";
        private const string COMPANY_NUMBER = "会社番号";
        private const string IDENTITY = "氏名";
        private const string NAME_KATANA = "氏名カナ";
        private const string GENDER = "性別";
        private const string REGIST_BY = "登録者";
        private const string UPDATE_BY = "更新者";
        private const string DATE_BIRTH = "生年月日";
        private const string DATE_HIRE = "入社日";

        private IEnumerable<EmployeesModel> employees = default!;

        private HashSet<EmployeesModel> selectedEmployees = new();

        private async Task<GridDataProviderResult<EmployeesModel>> EmployeesDataProvider(GridDataProviderRequest<EmployeesModel> request)
        {
            Console.WriteLine("EmployeesDataProvider called...");

            if (employees is null) // pull employees only one time for client-side filtering, sorting, and paging
                employees = GetEmployees(); // call a service or an API to pull the employees

            return await Task.FromResult(request.ApplyTo(employees));
        }

        private IEnumerable<EmployeesModel> GetEmployees()
        {
            return new List<EmployeesModel>
            {
            
            };
        }

        private Task OnSelectedItemsChanged(HashSet<EmployeesModel> employees)
        {
            selectedEmployees = employees is not null && employees.Any() ? employees : new();
            return Task.CompletedTask;
        }
        #endregion

        #region Variale

        #endregion

    }
}
