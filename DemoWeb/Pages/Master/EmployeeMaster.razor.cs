using BlazorBootstrap;
using DemoShared.Models.Entities;
using Microsoft.AspNetCore.Components;
using DemoShared.Constants;


namespace DemoWeb.Pages.Master
{
    public partial class EmployeeMaster : ComponentBase
    {
        #region Inject
        [Inject]
        private ModalService? modal { get; set; }
        #endregion
        #region Const
        private const string COMPANY_MASTER_MANAGEMENT = "◆ 会社マスター管理入力";
        private const string SEARCH = "◆ 検索";
        private const string NAME_KATA = "氏名または氏名カナ";
        private const string TECH_ID = "技術者ID";
        private const string COMPANY_NUMBER = "会社番号";
        private const string IDENTITY = "氏名";
        private const string NAME_KATANA = "氏名カナ";
        private const string GENDER = "性別";
        private const string REGIST_BY = "登録者";
        private const string UPDATE_BY = "更新者";
        private const string DATE_BIRTH = "生年月日";
        private const string DATE_HIRE = "入社日";

        #endregion

        #region Variale
        private List<EmployeesModel> employees = new List<EmployeesModel>();

        private HashSet<EmployeesModel> selectedEmployees = new();

        private bool isShowModal = false;
        private bool isShowEmpModal = false;
        private string? actionState;
        #endregion

        #region Function
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private async Task<GridDataProviderResult<EmployeesModel>> EmployeesDataProvider(GridDataProviderRequest<EmployeesModel> request)
        {
            Console.WriteLine("EmployeesDataProvider called...");

            if (employees is null) // pull employees only one time for client-side filtering, sorting, and paging
                employees = (List<EmployeesModel>?)GetEmployees(); // call a service or an API to pull the employees

            return await Task.FromResult(request.ApplyTo(employees));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private IEnumerable<EmployeesModel> GetEmployees()
        {
            return new List<EmployeesModel>
            {

            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="employees"></param>
        /// <returns></returns>
        private Task OnSelectedItemsChanged(HashSet<EmployeesModel> employees)
        {
            selectedEmployees = employees is not null && employees.Any() ? employees : new();
            return Task.CompletedTask;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private async void ConfirmCallBack()
        {
            isShowModal = false;
            await InvokeAsync(StateHasChanged);
        }

        /// <summary>
        /// 
        /// </summary>
        private async void CancelCallBack()
        {
            isShowModal = false;
            await InvokeAsync(StateHasChanged);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private async Task btnOpenModalOnClick()
        {
            isShowModal = true;
            await InvokeAsync(StateHasChanged);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private async Task btnCreatOnClick()
        {
            actionState = Common.Action.INSERT;
            isShowEmpModal = true;
            await InvokeAsync(StateHasChanged);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private async void ConfirmEmpCallBack()
        {
            isShowEmpModal = false;
            await InvokeAsync(StateHasChanged);
        }

        /// <summary>
        /// 
        /// </summary>
        private async void CancelEmpCallBack()
        {
            isShowEmpModal = false;
            await InvokeAsync(StateHasChanged);
        }
        #endregion
    }
}
