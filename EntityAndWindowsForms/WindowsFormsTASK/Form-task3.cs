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
    public partial class Form_task3 : Form
    {

        public User selectedUser;
        public List<User> users;
        public List<Department> departments;

        public Form_task3()
        {
            InitializeComponent();

        }

        //Обновляет таблицу всех Юзеров делает запросы Данных через Контроллер
        public void UpdateSheet()
        {

            usersTableGrid.Rows.Clear();


            users = Controller.getAllUsersFromDatabase();
            foreach (User user in users)
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewCell nameCell = new DataGridViewTextBoxCell();
                DataGridViewCell secondnameCell = new DataGridViewTextBoxCell();
                CalendarCell     birthdayCell = new CalendarCell();
                DataGridViewCell agesCell = new DataGridViewTextBoxCell();
                DataGridViewCell occupationCell = new DataGridViewTextBoxCell();
                DataGridViewCell remoteCell = new DataGridViewCheckBoxCell();
                DataGridViewCell addressCell = new DataGridViewTextBoxCell();
                DataGridViewCell personNumCell = new DataGridViewTextBoxCell();
                DataGridViewCell departmentCell = new DataGridViewTextBoxCell();

                nameCell.Value = user.firstName;
                secondnameCell.Value = user.secondName;
                birthdayCell.Value = user.birthData;
                occupationCell.Value = user.occupation.ToString();
                remoteCell.Value = user.remoteWork;
                addressCell.Value = user.address;
                agesCell.Value = user.age;
                departmentCell.Value = user.department;
                

                personNumCell.Value = user.personNum;
                row.Cells.AddRange(nameCell, secondnameCell, agesCell, occupationCell, remoteCell, addressCell,personNumCell, birthdayCell,departmentCell);


                usersTableGrid.Rows.Add(row);
            }
        }



        /*
        * Генерируемые Windows Forms События всех компонентов 
        */
        private void toSheduleButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            
        }


        //Проверяет изменение каждой ячейки таблицы и в случае допустимости перезаписывает в базе данных через Контроллер
        private void usersTableGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= users.Count)
                {
                    return;
                }
                DataGridViewCell cell = usersTableGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];

                switch (e.ColumnIndex)
                {
                    case 0: selectedUser.firstName =  cell.Value.ToString();  Controller.updateUserData(selectedUser);  UpdateSheet();  break;
                    case 1: selectedUser.secondName = cell.Value.ToString();  Controller.updateUserData(selectedUser);  UpdateSheet();  break;
                    case 2:
                        try
                        {
                            selectedUser.age = Convert.ToInt32(cell.Value);
                            if(selectedUser.age > 200)
                            {
                                MessageBox.Show("Слишком старый сотрудник, Увольте!!!", "Ошибка");
                                return;
                            }
                            int year = DateTime.Now.Year - selectedUser.age;
                            selectedUser.birthData = new DateTime(year, selectedUser.birthData.Month, selectedUser.birthData.Day);
                            Controller.updateUserData(selectedUser);
                            UpdateSheet();
                        }
                        catch (FormatException ex)
                        {
                            MessageBox.Show("Только цифры мой лорд", "Ошибка");
                            UpdateSheet();
                        }
                        break;
                    case 3: selectedUser.occupation = cell.Value.ToString();  Controller.updateUserData(selectedUser); UpdateSheet();   break;
                    case 4: selectedUser.remoteWork = (bool) cell.Value;      Controller.updateUserData(selectedUser); UpdateSheet();   break;
                    case 5: selectedUser.address = cell.Value.ToString();     Controller.updateUserData(selectedUser); UpdateSheet();   break;
                    case 6:
                        MessageBox.Show("Табельный номер менять запрещено!!! Только богу Рандома позволено это делать", "Запрет");
                        UpdateSheet();
                        break;
                    case 7: selectedUser.birthData = (DateTime)cell.Value;
                        selectedUser.age = DateTime.Now.Year - selectedUser.birthData.Year;
                        Controller.updateUserData(selectedUser);
                        UpdateSheet();
                        break;
                    case 8: Controller.setDepartmentToUser(selectedUser,cell.Value.ToString()); UpdateSheet();   break;

                }
                

                if(e.RowIndex >= users.Count)
                {
                    UpdateSheet();
                }
            }
            catch(Exception ex)
            {

            }
        }


        private void addUserButton_Click(object sender, EventArgs e)
        {
            createUserForm createUserForm = new createUserForm();
            createUserForm.Visible = true;

        }


        private void usersTableGrid_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= users.Count)
            {
                return;
            }
            DataGridViewCell cell = usersTableGrid.CurrentCell;
            selectedUser = users[cell.RowIndex];
        }

    }
}
