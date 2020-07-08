namespace WindowsFormsTASK
{
    partial class Form_task3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toSheduleButton = new System.Windows.Forms.Button();
            this.usersTableGrid = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Occupation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remote = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personNumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewCalendarColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addUserButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCalendarColumn1 = new System.Windows.Forms.DataGridViewCalendarColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersTableGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toSheduleButton
            // 
            this.toSheduleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toSheduleButton.BackColor = System.Drawing.Color.Maroon;
            this.toSheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toSheduleButton.Location = new System.Drawing.Point(877, 12);
            this.toSheduleButton.Name = "toSheduleButton";
            this.toSheduleButton.Size = new System.Drawing.Size(185, 66);
            this.toSheduleButton.TabIndex = 0;
            this.toSheduleButton.Text = "ЗАКРЫТЬ";
            this.toSheduleButton.UseVisualStyleBackColor = false;
            this.toSheduleButton.Click += new System.EventHandler(this.toSheduleButton_Click);
            // 
            // usersTableGrid
            // 
            this.usersTableGrid.AllowUserToOrderColumns = true;
            this.usersTableGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersTableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersTableGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.secondName,
            this.age,
            this.Occupation,
            this.Remote,
            this.Address,
            this.personNumColumn,
            this.birthday,
            this.department});
            this.usersTableGrid.Location = new System.Drawing.Point(12, 84);
            this.usersTableGrid.Name = "usersTableGrid";
            this.usersTableGrid.Size = new System.Drawing.Size(1050, 263);
            this.usersTableGrid.TabIndex = 1;
            this.usersTableGrid.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.usersTableGrid_CellMouseUp);
            this.usersTableGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersTableGrid_CellValueChanged);
            // 
            // name
            // 
            this.name.HeaderText = "Имя";
            this.name.MaxInputLength = 15;
            this.name.Name = "name";
            // 
            // secondName
            // 
            this.secondName.HeaderText = "Фамилия";
            this.secondName.MaxInputLength = 15;
            this.secondName.Name = "secondName";
            // 
            // age
            // 
            this.age.HeaderText = "Возраст";
            this.age.MaxInputLength = 3;
            this.age.Name = "age";
            // 
            // Occupation
            // 
            this.Occupation.HeaderText = "Должность";
            this.Occupation.Name = "Occupation";
            this.Occupation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Remote
            // 
            this.Remote.HeaderText = "Удаленная работа";
            this.Remote.Name = "Remote";
            // 
            // Address
            // 
            this.Address.HeaderText = "Адрес проживания";
            this.Address.Name = "Address";
            // 
            // personNumColumn
            // 
            this.personNumColumn.HeaderText = "Табельный №";
            this.personNumColumn.Name = "personNumColumn";
            // 
            // birthday
            // 
            this.birthday.HeaderText = "Дата Рождения";
            this.birthday.Name = "birthday";
            // 
            // department
            // 
            this.department.HeaderText = "Департамент";
            this.department.Name = "department";
            this.department.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.department.Width = 200;
            // 
            // addUserButton
            // 
            this.addUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addUserButton.Location = new System.Drawing.Point(12, 33);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(110, 33);
            this.addUserButton.TabIndex = 2;
            this.addUserButton.Text = "Добавить";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteUserButton.Location = new System.Drawing.Point(128, 34);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(131, 32);
            this.deleteUserButton.TabIndex = 4;
            this.deleteUserButton.Text = "Удалить";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Возраст";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 3;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Адрес проживания";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Табельный №";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCalendarColumn1
            // 
            this.dataGridViewCalendarColumn1.HeaderText = "Дата Рождения";
            this.dataGridViewCalendarColumn1.Name = "dataGridViewCalendarColumn1";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Департамент";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // Form_task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 359);
            this.ControlBox = false;
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.usersTableGrid);
            this.Controls.Add(this.toSheduleButton);
            this.Name = "Form_task3";
            this.Text = "Редактор сотрудников";
            ((System.ComponentModel.ISupportInitialize)(this.usersTableGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toSheduleButton;
        private System.Windows.Forms.DataGridView usersTableGrid;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCalendarColumn dataGridViewCalendarColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Occupation;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Remote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn personNumColumn;
        private System.Windows.Forms.DataGridViewCalendarColumn birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
    }
}