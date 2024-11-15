namespace lab1
{
    partial class Form2
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
            this.dgD = new System.Windows.Forms.DataGridView();
            this.dgS = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgD
            // 
            this.dgD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgD.Location = new System.Drawing.Point(13, 61);
            this.dgD.Name = "dgD";
            this.dgD.RowHeadersWidth = 51;
            this.dgD.RowTemplate.Height = 24;
            this.dgD.Size = new System.Drawing.Size(934, 408);
            this.dgD.TabIndex = 0;
            // 
            // dgS
            // 
            this.dgS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgS.Location = new System.Drawing.Point(968, 61);
            this.dgS.Name = "dgS";
            this.dgS.RowHeadersWidth = 51;
            this.dgS.RowTemplate.Height = 24;
            this.dgS.Size = new System.Drawing.Size(944, 408);
            this.dgS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(462, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "D";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1441, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "S";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 473);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgS);
            this.Controls.Add(this.dgD);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgD;
        private System.Windows.Forms.DataGridView dgS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}