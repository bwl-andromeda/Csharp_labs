namespace Формы_РГР_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.sortButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.retirementButton = new System.Windows.Forms.Button();
            this.averageExperienceButton = new System.Windows.Forms.Button();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(21, 195);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(120, 26);
            this.sortButton.TabIndex = 1;
            this.sortButton.Text = "Сортировать";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(21, 159);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(166, 28);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Удалить сотрудника";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(21, 128);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(166, 25);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Добавить сотрудника";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Location = new System.Drawing.Point(208, 98);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.RowHeadersWidth = 51;
            this.employeeDataGridView.RowTemplate.Height = 24;
            this.employeeDataGridView.Size = new System.Drawing.Size(817, 336);
            this.employeeDataGridView.TabIndex = 7;
            // 
            // sortComboBox
            // 
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Location = new System.Drawing.Point(21, 227);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(121, 24);
            this.sortComboBox.TabIndex = 8;
            // 
            // retirementButton
            // 
            this.retirementButton.Location = new System.Drawing.Point(21, 257);
            this.retirementButton.Name = "retirementButton";
            this.retirementButton.Size = new System.Drawing.Size(120, 52);
            this.retirementButton.TabIndex = 9;
            this.retirementButton.Text = "Список пенсионеров";
            this.retirementButton.UseVisualStyleBackColor = true;
            this.retirementButton.Click += new System.EventHandler(this.retirementButton_Click);
            // 
            // averageExperienceButton
            // 
            this.averageExperienceButton.Location = new System.Drawing.Point(1058, 98);
            this.averageExperienceButton.Name = "averageExperienceButton";
            this.averageExperienceButton.Size = new System.Drawing.Size(120, 48);
            this.averageExperienceButton.TabIndex = 10;
            this.averageExperienceButton.Text = "Средний стаж работы";
            this.averageExperienceButton.UseVisualStyleBackColor = true;
            this.averageExperienceButton.Click += new System.EventHandler(this.averageExperienceButton_Click);
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Location = new System.Drawing.Point(1058, 168);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(120, 22);
            this.departmentTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1055, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Введите название департамента";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "Загрузить данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(597, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 44);
            this.button2.TabIndex = 14;
            this.button2.Text = "Сохранить данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 546);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(this.averageExperienceButton);
            this.Controls.Add(this.retirementButton);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.employeeDataGridView);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.sortButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.Button retirementButton;
        private System.Windows.Forms.Button averageExperienceButton;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

