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
    public partial class createUserForm : Form
    {
        public createUserForm()
        {
            InitializeComponent();

            updateDepartmentList();
        }

        //Проверяет поля и создает нового пользователя, и добавляет его в базу данных, если указанного департамента нету в базе то создает новый
        private void createUserButtton_Click(object sender, EventArgs e)
        {
            string nullFields = "";
            if (nameTextBox.Text.Equals(""))
            {
                nullFields += "Имя" + "\n";
            }
            if(secondNameTextBox.Text.Equals(""))
            {
                nullFields += "Фамилию" + "\n";
            }
            if (occupationTextBox.Text.Equals(""))
            {
                nullFields += "Должность" + "\n";
            }
            if (addressBox.Text.Equals(""))
            {
                nullFields += "Адрес" + "\n";
            }

            if (!nullFields.Equals(""))
            {
                MessageBox.Show("Добавьте следующие поля" + "\n" + nullFields, "Внимание!");
            }
            else
            {
                User user = new User()
                {
                    firstName = nameTextBox.Text,
                    secondName = secondNameTextBox.Text,
                    occupation = occupationTextBox.Text,
                    address = addressBox.Text,
                    remoteWork = remoteCheckBox.Checked,
                    birthData = dateTimePicker.Value
                };
                Controller.createNewUser(user,comboDepartmentComboBox.Text);
                Program.formEditor.UpdateSheet();
                Program.sheduleForm.UpdateSheet();
                Program.sheduleForm.updateDepartmentList();
                this.Visible = false;
            }

        }

        public void updateDepartmentList()
        {
            List<Department> departemntsList = Controller.GetAllDepartments();
            comboDepartmentComboBox.Items.Clear();
            foreach (Department item in departemntsList)
            {
                comboDepartmentComboBox.Items.Add(item);
            }
        }

    }
}
