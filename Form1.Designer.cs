namespace lab1
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
            this.tbn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnDeikstru = new System.Windows.Forms.Button();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnFloida = new System.Windows.Forms.Button();
            this.btnTest2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // tbn
            // 
            this.tbn.Location = new System.Drawing.Point(68, 30);
            this.tbn.Name = "tbn";
            this.tbn.Size = new System.Drawing.Size(66, 22);
            this.tbn.TabIndex = 0;
            this.tbn.Text = "6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "N =";
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(359, 12);
            this.dg.Name = "dg";
            this.dg.RowHeadersWidth = 51;
            this.dg.RowTemplate.Height = 24;
            this.dg.Size = new System.Drawing.Size(930, 430);
            this.dg.TabIndex = 2;
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
            this.dg.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellValueChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(38, 87);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(95, 35);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(39, 139);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(95, 35);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "Test 1";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnDeikstru
            // 
            this.btnDeikstru.Location = new System.Drawing.Point(39, 197);
            this.btnDeikstru.Name = "btnDeikstru";
            this.btnDeikstru.Size = new System.Drawing.Size(95, 35);
            this.btnDeikstru.TabIndex = 5;
            this.btnDeikstru.Text = "Дейкстри";
            this.btnDeikstru.UseVisualStyleBackColor = true;
            this.btnDeikstru.Click += new System.EventHandler(this.btnDeikstru_Click);
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(174, 30);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(119, 24);
            this.cb1.TabIndex = 18;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 321);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(326, 260);
            this.listBox1.TabIndex = 19;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(182, 92);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 20);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Симетрія";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnFloida
            // 
            this.btnFloida.Location = new System.Drawing.Point(161, 197);
            this.btnFloida.Name = "btnFloida";
            this.btnFloida.Size = new System.Drawing.Size(95, 35);
            this.btnFloida.TabIndex = 21;
            this.btnFloida.Text = "Флойда";
            this.btnFloida.UseVisualStyleBackColor = true;
            this.btnFloida.Click += new System.EventHandler(this.btnFloida_Click);
            // 
            // btnTest2
            // 
            this.btnTest2.Location = new System.Drawing.Point(161, 139);
            this.btnTest2.Name = "btnTest2";
            this.btnTest2.Size = new System.Drawing.Size(95, 35);
            this.btnTest2.TabIndex = 22;
            this.btnTest2.Text = "Test 2";
            this.btnTest2.UseVisualStyleBackColor = true;
            this.btnTest2.Click += new System.EventHandler(this.btnTest2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 616);
            this.Controls.Add(this.btnTest2);
            this.Controls.Add(this.btnFloida);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.btnDeikstru);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnDeikstru;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnFloida;
        private System.Windows.Forms.Button btnTest2;
    }
}

