using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using DemoShared.Constants;
using BlazorBootstrap;

namespace DemoWeb.Layout
{
    public partial class NavMenu : ComponentBase
    {
        Sidebar? sidebar;
        IEnumerable<NavItem>? navItems;

        private async Task<SidebarDataProviderResult> SidebarDataProvider(SidebarDataProviderRequest request)
        {
            if (navItems is null)
                navItems = GetNavItems();

            return await Task.FromResult(request.ApplyTo(navItems));
        }

        private IEnumerable<NavItem> GetNavItems()
        {
            navItems = new List<NavItem>
        {
            new NavItem { Id = "1", IconName = IconName.LayoutSidebarInset, Text = Common.Header.EMPLOYEE_MASTER },
            new NavItem { Id = "2", Href = "/EmployeeMaster", IconName = IconName.PersonSquare, Text = Common.Header.EMPLOYEE_MASTER_MANAGEMENT, ParentId="1" },

            new NavItem { Id = "3", IconName = IconName.LayoutSidebarInset, Text = Common.Header.INFORMATION },
            new NavItem { Id = "4", Href = "/EmployeeInformation", IconName = IconName.PersonSquare, Text = Common.Header.EMPLOYEE_INFORMATION, ParentId="3" },
        };

            return navItems;
        }

        private void ToggleSidebar() => sidebar!.ToggleSidebar();
    }
}
