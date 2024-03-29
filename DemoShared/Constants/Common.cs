using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoShared.Constants
{
    public class Common
    {

        public static readonly string SYSTEM_COPYRIGHT = "©2023 City Ascom co.Ltd";

        public class MenuId
        {
            public const string TEACHNICAL_MANAGEMENT = "M-01";
        }
        public class Label
        {
            public const string NAME_MAIN = "新技術DBシステム";
            public const string LOGIN = "ログイン";
            public const string EDIT = "編集";
            public const string DELETE = "削除";
            public const string ADD = "追加";
            public const string LOAD_IMP = "読込み実";
            public const string CANCEL = "キャンセル";
            public const string LOG_OUT = "サインアウト";
            public const string DELETE_TITLE = "削除する";
            public const string INSERT = "登録";
            public const string UPDATE = "更新";
        }
        public class Header
        {
            public const string EMPLOYEE_MASTER = "マスター管理";
            public const string EMPLOYEE_MASTER_MANAGEMENT = "技術者マスター管理";
            public const string INFORMATION = "情報管理";
            public const string EMPLOYEE_INFORMATION = "技術者情報";
            public const string NEW_ADDITION = "新規追加";
        }
        public class Action
        {
            public const string UPDATE = "UPDATE";
            public const string INSERT = "INSERT";
            public const string DELETE = "DELETE";
        }
    }
}
