namespace WindowsFormsTASK
{
    partial class createUserForm
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
            this.createUserButtton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.occupationTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.remoteCheckBox = new System.Windows.Forms.CheckBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboDepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // createUserButtton
            // 
            this.createUserButtton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createUserButtton.Location = new System.Drawing.Point(29, 360);
            this.createUserButtton.Name = "createUserButtton";
            this.createUserButtton.Size = new System.Drawing.Size(332, 81);
            this.createUserButtton.TabIndex = 0;
            this.createUserButtton.Text = "Создать";
            this.createUserButtton.UseVisualStyleBackColor = true;
            this.createUserButtton.Click += new System.EventHandler(this.createUserButtton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(137, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя*";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(189, 23);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(172, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.Location = new System.Drawing.Point(189, 60);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.secondNameTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(96, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия*";
            // 
            // occupationTextBox
            // 
            this.occupationTextBox.Location = new System.Drawing.Point(189, 154);
            this.occupationTextBox.Name = "occupationTextBox";
            this.occupationTextBox.Size = new System.Drawing.Size(172, 20);
            this.occupationTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(73, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Должность*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Удаленная работа";
            // 
            // remoteCheckBox
            // 
            this.remoteCheckBox.Location = new System.Drawing.Point(189, 207);
            this.remoteCheckBox.Name = "remoteCheckBox";
            this.remoteCheckBox.Size = new System.Drawing.Size(20, 20);
            this.remoteCheckBox.TabIndex = 13;
            this.remoteCheckBox.UseVisualStyleBackColor = true;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(189, 259);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(172, 20);
            this.addressBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(120, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Адрес*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(64, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Департамент*";
            // 
            // comboDepartmentComboBox
            // 
            this.comboDepartmentComboBox.FormattingEnabled = true;
            this.comboDepartmentComboBox.Location = new System.Drawing.Point(189, 300);
            this.comboDepartmentComboBox.Name = "comboDepartmentComboBox";
            this.comboDepartmentComboBox.Size = new System.Drawing.Size(172, 21);
            this.comboDepartmentComboBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(48, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата Рождения";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(189, 101);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker.TabIndex = 11;
            this.dateTimePicker.Value = new System.DateTime(2020, 5, 19, 0, 0, 0, 0);
            // 
            // createUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 457);
            this.Controls.Add(this.comboDepartmentComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.remoteCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.occupationTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.secondNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createUserButtton);
            this.Name = "createUserForm";
            this.Text = "Новый Пользователь";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createUserButtton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox secondNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox occupationTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox remoteCheckBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboDepartmentComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}