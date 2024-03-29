using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoShared.Constants
{
    public class RoutingTable
    {
        public static readonly (string Icon, string Route, string Name, string PageTitle) DEFAULT_HOME = Root.INDEX;

        public class Root
        {
            public static readonly string BASE_PATH
                = "/";
            public static readonly string NO_CONTENT_PATH
                = "NoContent";
            public static readonly (string Icon, string Route, string Name, string PageTitle) INDEX
                = new("fa-xl fa-fw fa-solid fa-home", BASE_PATH + "", "ホーム", "ようこそ！");
            public static readonly (string Icon, string Route, string Name, string PageTitle) LOGOUT
                = new("fa-xl fa-fw fa-solid fa-right-from-bracket", "", "サインアウト", "サインアウト");
        }
        public class MasterManagement
        {
            public const string MAIN_NAME = "マスター管理";

            public const string ROUTE_TEACHNICAL_MASTER_MANAGEMENT = "/ADMIN";
            public static readonly (string menuRoute, string Name, string Id) TEACHNICAL_MASTER_MANAGEMENT
                = new(ROUTE_TEACHNICAL_MASTER_MANAGEMENT, "技術者マスター管理", "1");

            public static Dictionary<string, string> RootManager = new Dictionary<string, string>
            {
                { MasterManagement.TEACHNICAL_MASTER_MANAGEMENT.menuRoute, MasterManagement.TEACHNICAL_MASTER_MANAGEMENT.Name}
            };
        }
    }
}
