using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsTASK.DataModel;

namespace WindowsFormsTASK
{
    public partial class Form_Task2 : Form
    {

        public int monthNumber = 1;

        /*
         * updateDepartmentList() - обновляет список из базы данных через класс Controller,
         * выводит компоненты с данными на Forms.ListBox DepartmentBox, 
         * выбор каждого компонента вызывает событие DepartmentBox_SelectedIndexChanged()
         */
        public Form_Task2()
        {
            
            InitializeComponent();
            
            updateDepartmentList(); 
        }

        //Обновляет таблицу "Календарь" делает запросы Данных через Контроллер в зависимости от DepartmentBox.SelectedItems
        public void UpdateSheet()
        {
            timeTableGrid.Columns.Clear();


            int countDay = DateTime.DaysInMonth(2020, monthNumber);


            /*
             *  отрисовка COLUMNS на таблице в зависимости от месяца countDay = daysInMonth
             */

            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "фио";
            column1.HeaderText = "ФИО";
            column1.Frozen = true;
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "Должность";
            column2.HeaderText = "ДОЛЖНОСТЬ";
            column2.Frozen = true;
            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.Name = "Табельный";
            column3.HeaderText = "ТАБЕЛЬ";
            column3.Frozen = true;

            timeTableGrid.Columns.AddRange(column1, column2, column3);

            // Столбцы Денечков
            DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[countDay];
            for (int i = 0; i < countDay; i++)
            {
                columns[i] = new DataGridViewTextBoxColumn();
                columns[i].Name = Convert.ToString(i + 1);

                DateTime dateValue = new DateTime(2020, monthNumber, i + 1);
                columns[i].HeaderText = Convert.ToString(i + 1) + " " + dateValue.ToString("ddd");
                columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            }
            timeTableGrid.Columns.AddRange(columns);





            /*
             *  отрисовка  ROWS с ДАННЫМИ ИЗ БАЗЫ через класс Controller
             */
            List<User> users = Controller.getUsersFromDatabase(DepartmentBox, monthNumber);
            foreach (User user in users)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewCell nameCell = new DataGridViewTextBoxCell();
                DataGridViewCell occupationCell = new DataGridViewTextBoxCell();
                DataGridViewCell personNumCell = new DataGridViewTextBoxCell();

                nameCell.Value = user.firstName + " " + user.secondName;
                occupationCell.Value = user.occupation.ToString();
                personNumCell.Value = user.personNum;
                row.Cells.AddRange(nameCell, occupationCell, personNumCell);



                DataGridViewCell[] dayCells = new DataGridViewTextBoxCell[countDay];
                List<Marker> userMarkersOfMonth = user.getMarkersOfMonth(monthNumber);

                for (int i = 0; i < countDay; i++)
                {
                    dayCells[i] = new DataGridViewTextBoxCell();
                    dayCells[i].Value = CodingMarker.Н.ToString();

                }
                foreach (Marker marker in userMarkersOfMonth)
                {
                    dayCells[marker.day - 1].Value = marker.state.ToString();
                }

                row.Cells.AddRange(dayCells);
                timeTableGrid.Rows.Add(row);
            }


        }

        // Обновляет список отделов(Департаменты) с Базы Данных через Контроллер
        public void updateDepartmentList()
        {
            DepartmentBox.Items.Clear();
            List<Department> departemntsList = Controller.GetAllDepartments();
            foreach (Department item in departemntsList)
            {
                DepartmentBox.Items.Add(item);
            }
        }




        /*
        * Генерируемые Windows Forms События всех компонентов 
        */


        //выделенные департаменты сохраняются в DepartmentBox
        private void DepartmentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSheet();
        }

        private void ToUserButton_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            Program.formEditor.Visible = true;
            Program.formEditor.departments = Controller.GetAllDepartments();
            Program.formEditor.UpdateSheet();

        }

        //Проверяет изменение каждой ячейки календаря и обновляет их кодировку(CodingMarker) в базе данных(DataModel.Marker) через Controller
        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)timeTableGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
            
            if (Enum.IsDefined(typeof(CodingMarker), cell.Value))
            {
                List<User> users = Controller.getUsersFromDatabase(DepartmentBox, monthNumber);

                CodingMarker state = (CodingMarker)Enum.Parse(typeof(CodingMarker), cell.Value.ToString());
                Controller.setMarkerToDatabase(monthNumber, e.ColumnIndex - 2, users[e.RowIndex].Id, state);
            }
            else if(e.ColumnIndex > 3)
            {
                string output =
                     "Виды отметок с кодировкой на работе, с кодировкой: \n"
                   + "Я – полный рабочий день; \n"
                   + "Н – отсутствие на рабочее место по невыясненным причинам; \n"
                   + "В – выходные и праздничные дни; \n"
                   + "Рв – работа в праздничные и выходные дни; а также работа в праздничные и выходные дни, при \n"
                   + "нахождении в командировке; \n"
                   + "Б – дни временной нетрудоспособности; \n"
                   + "К – командировочные дни; а также, выходные (нерабочие) дни при нахождении в командировке, \n"
                   + "когда сотрудник отдыхает, в соответствии с графиком работы ООО «Наука» в командировке; \n"
                   + "ОТ – ежегодный основной оплаченный отпуск; \n"
                   + "До – неоплачиваемый отпуск (отпуск за свой счет); \n"
                   + "Хд – хозяйственный день; \n"
                   + "У – отпуск на период обучения. \n"
                   + "Ож – Отпуск по уходу за ребенком. \n";




                MessageBox.Show(output, "Вы ввели неправильную кодировку! \n ");

                UpdateSheet();
            }
            else
            {
                string output = "Данные пользователей можно менять в другом окне";
                MessageBox.Show(output, "Запрет! \n ");
            }

        }

        private void januaryButton_Click(object sender, EventArgs e)
        {
            monthNumber = 1;
            UpdateSheet();
        }

        private void FebruaryButton_Click(object sender, EventArgs e)
        {
            monthNumber = 2;
            UpdateSheet();
        }

        private void MarchButton_Click(object sender, EventArgs e)
        {
            monthNumber = 3;
            UpdateSheet();
        }

        private void AprilButton_Click(object sender, EventArgs e)
        {
            monthNumber = 4;
            UpdateSheet();
        }

        private void AugustButton_Click(object sender, EventArgs e)
        {
            monthNumber = 5;
            UpdateSheet();
        }

        private void JuleButton_Click(object sender, EventArgs e)
        {
            monthNumber = 6;
            UpdateSheet();
        }

        private void JuneButton_Click(object sender, EventArgs e)
        {
            monthNumber = 7;
            UpdateSheet();
        }

        private void MayButton_Click(object sender, EventArgs e)
        {
            monthNumber = 8;
            UpdateSheet();
        }

        private void DecemberButton_Click(object sender, EventArgs e)
        {
            monthNumber = 9;
            UpdateSheet();
        }

        private void NovemberButton_Click(object sender, EventArgs e)
        {
            monthNumber = 10;
            UpdateSheet();
        }

        private void OctoberButton_Click(object sender, EventArgs e)
        {
            monthNumber = 11;
            UpdateSheet();
        }

        private void SeptemberButton_Click(object sender, EventArgs e)
        {
            monthNumber = 12;
            UpdateSheet();
        }
    }
}
