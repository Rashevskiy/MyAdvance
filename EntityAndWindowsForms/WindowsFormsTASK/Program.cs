using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsTASK.DataModel;


namespace WindowsFormsTASK
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 

        public static Form_Task2 sheduleForm;
        public static Form_task3 formEditor;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            sheduleForm = new Form_Task2();
            formEditor = new Form_task3();

            //Запуск
            Application.Run(sheduleForm);
        }
    }
    
}
