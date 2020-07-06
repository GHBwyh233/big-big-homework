using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigHomework
{
    
    static class Program
    {
        public static int status = 0; //如果为1表示进入管理员主窗口，2则是家族管理员，3是普通用户
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]

        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            if (status == 1){
                Application.Run(new RootForm());
            }else if(status == 2)
            {
                Application.Run(new FamCtrForm());
            }else if(status == 3)
            {
                Application.Run(new LocatingForm());
            }
        }
    }
}
