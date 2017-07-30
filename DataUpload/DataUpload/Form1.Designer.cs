namespace DataUpload
{
    partial class Form1
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
            this.cmdLoadData = new System.Windows.Forms.Button();
            this.cmdLoadDefinition = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConnectionStr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdLoadData
            // 
            this.cmdLoadData.Location = new System.Drawing.Point(720, 63);
            this.cmdLoadData.Name = "cmdLoadData";
            this.cmdLoadData.Size = new System.Drawing.Size(116, 23);
            this.cmdLoadData.TabIndex = 1;
            this.cmdLoadData.Text = "LoadData";
            this.cmdLoadData.UseVisualStyleBackColor = true;
            this.cmdLoadData.Click += new System.EventHandler(this.cmdLoadData_Click);
            // 
            // cmdLoadDefinition
            // 
            this.cmdLoadDefinition.Location = new System.Drawing.Point(720, 102);
            this.cmdLoadDefinition.Name = "cmdLoadDefinition";
            this.cmdLoadDefinition.Size = new System.Drawing.Size(116, 23);
            this.cmdLoadDefinition.TabIndex = 2;
            this.cmdLoadDefinition.Text = "LoadDefinition";
            this.cmdLoadDefinition.UseVisualStyleBackColor = true;
            this.cmdLoadDefinition.Click += new System.EventHandler(this.cmdLoadDefinition_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(382, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Min. # of Branches  for each variable group  to calculate correlation value";
            // 
            // txtDataFolder
            // 
            this.txtDataFolder.Location = new System.Drawing.Point(382, 63);
            this.txtDataFolder.Name = "txtDataFolder";
            this.txtDataFolder.Size = new System.Drawing.Size(222, 20);
            this.txtDataFolder.TabIndex = 5;
            this.txtDataFolder.Text = "D:\\work\\data\\";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "DataFolder";
            // 
            // txtConnectionStr
            // 
            this.txtConnectionStr.Location = new System.Drawing.Point(382, 156);
            this.txtConnectionStr.Name = "txtConnectionStr";
            this.txtConnectionStr.Size = new System.Drawing.Size(491, 20);
            this.txtConnectionStr.TabIndex = 7;
            this.txtConnectionStr.Text = "Data Source=BT101NB\\SQLEXPRESS;Initial Catalog=DBWorldBank;Integrated Security=Tr" +
    "ue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Connection String";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 197);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConnectionStr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDataFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmdLoadDefinition);
            this.Controls.Add(this.cmdLoadData);
            this.Name = "Form1";
            this.Text = "Branch Analyser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdLoadData;
        private System.Windows.Forms.Button cmdLoadDefinition;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDataFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConnectionStr;
        private System.Windows.Forms.Label label3;
    }
}

