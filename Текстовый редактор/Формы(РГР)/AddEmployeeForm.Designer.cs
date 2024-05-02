namespace Формы_РГР_
{
    partial class AddEmployeeForm
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
            this.components = new System.ComponentModel.Container();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.birthYearTextBox = new System.Windows.Forms.TextBox();
            this.workExperienceTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(289, 66);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.lastNameTextBox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(289, 94);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.firstNameTextBox.TabIndex = 2;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(289, 122);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.middleNameTextBox.TabIndex = 3;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Location = new System.Drawing.Point(289, 150);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(100, 22);
            this.departmentTextBox.TabIndex = 4;
            // 
            // birthYearTextBox
            // 
            this.birthYearTextBox.Location = new System.Drawing.Point(289, 178);
            this.birthYearTextBox.Name = "birthYearTextBox";
            this.birthYearTextBox.Size = new System.Drawing.Size(100, 22);
            this.birthYearTextBox.TabIndex = 5;
            this.birthYearTextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // workExperienceTextBox
            // 
            this.workExperienceTextBox.Location = new System.Drawing.Point(289, 206);
            this.workExperienceTextBox.Name = "workExperienceTextBox";
            this.workExperienceTextBox.Size = new System.Drawing.Size(100, 22);
            this.workExperienceTextBox.TabIndex = 6;
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(289, 234);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(100, 22);
            this.positionTextBox.TabIndex = 7;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(289, 262);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 22);
            this.salaryTextBox.TabIndex = 8;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(289, 290);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 25);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Департамент";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Год рождения";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Опыт работы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Должность";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Зарплата";
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.workExperienceTextBox);
            this.Controls.Add(this.birthYearTextBox);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.TextBox birthYearTextBox;
        private System.Windows.Forms.TextBox workExperienceTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}