namespace Calculator
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
            this.FirstValue = new System.Windows.Forms.TextBox();
            this.SecondValue = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Calcbut = new System.Windows.Forms.Button();
            this.AddBut = new System.Windows.Forms.RadioButton();
            this.SubBut = new System.Windows.Forms.RadioButton();
            this.MultBut = new System.Windows.Forms.RadioButton();
            this.DivBut = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstValue
            // 
            this.FirstValue.Location = new System.Drawing.Point(12, 41);
            this.FirstValue.Multiline = true;
            this.FirstValue.Name = "FirstValue";
            this.FirstValue.Size = new System.Drawing.Size(149, 27);
            this.FirstValue.TabIndex = 0;
            this.FirstValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SecondValue
            // 
            this.SecondValue.Location = new System.Drawing.Point(12, 105);
            this.SecondValue.Multiline = true;
            this.SecondValue.Name = "SecondValue";
            this.SecondValue.Size = new System.Drawing.Size(149, 28);
            this.SecondValue.TabIndex = 1;
            this.SecondValue.TextChanged += new System.EventHandler(this.SecondValue_TextChanged);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(12, 186);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(149, 28);
            this.Result.TabIndex = 7;
            this.Result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "First Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Second Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Result:";
            // 
            // Calcbut
            // 
            this.Calcbut.Location = new System.Drawing.Point(86, 139);
            this.Calcbut.Name = "Calcbut";
            this.Calcbut.Size = new System.Drawing.Size(75, 25);
            this.Calcbut.TabIndex = 2;
            this.Calcbut.Text = "Calculate";
            this.Calcbut.UseVisualStyleBackColor = true;
            this.Calcbut.Click += new System.EventHandler(this.Calcbut_Click);
            // 
            // AddBut
            // 
            this.AddBut.AutoSize = true;
            this.AddBut.Location = new System.Drawing.Point(17, 19);
            this.AddBut.Name = "AddBut";
            this.AddBut.Size = new System.Drawing.Size(44, 17);
            this.AddBut.TabIndex = 3;
            this.AddBut.TabStop = true;
            this.AddBut.Text = "Add";
            this.AddBut.UseVisualStyleBackColor = true;
            this.AddBut.CheckedChanged += new System.EventHandler(this.AddBut_CheckedChanged);
            // 
            // SubBut
            // 
            this.SubBut.AutoSize = true;
            this.SubBut.Location = new System.Drawing.Point(17, 42);
            this.SubBut.Name = "SubBut";
            this.SubBut.Size = new System.Drawing.Size(65, 17);
            this.SubBut.TabIndex = 4;
            this.SubBut.TabStop = true;
            this.SubBut.Text = "Subtract";
            this.SubBut.UseVisualStyleBackColor = true;
            this.SubBut.CheckedChanged += new System.EventHandler(this.SubBut_CheckedChanged);
            // 
            // MultBut
            // 
            this.MultBut.AutoSize = true;
            this.MultBut.Location = new System.Drawing.Point(17, 65);
            this.MultBut.Name = "MultBut";
            this.MultBut.Size = new System.Drawing.Size(60, 17);
            this.MultBut.TabIndex = 5;
            this.MultBut.TabStop = true;
            this.MultBut.Text = "Multiply";
            this.MultBut.UseVisualStyleBackColor = true;
            this.MultBut.CheckedChanged += new System.EventHandler(this.MultBut_CheckedChanged);
            // 
            // DivBut
            // 
            this.DivBut.AutoSize = true;
            this.DivBut.Location = new System.Drawing.Point(17, 88);
            this.DivBut.Name = "DivBut";
            this.DivBut.Size = new System.Drawing.Size(55, 17);
            this.DivBut.TabIndex = 6;
            this.DivBut.TabStop = true;
            this.DivBut.Text = "Divide";
            this.DivBut.UseVisualStyleBackColor = true;
            this.DivBut.CheckedChanged += new System.EventHandler(this.DivBut_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DivBut);
            this.groupBox1.Controls.Add(this.MultBut);
            this.groupBox1.Controls.Add(this.SubBut);
            this.groupBox1.Controls.Add(this.AddBut);
            this.groupBox1.Location = new System.Drawing.Point(207, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 109);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operator";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 237);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Calcbut);
            this.Controls.Add(this.SecondValue);
            this.Controls.Add(this.FirstValue);
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstValue;
        private System.Windows.Forms.TextBox SecondValue;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Calcbut;
        private System.Windows.Forms.RadioButton AddBut;
        private System.Windows.Forms.RadioButton SubBut;
        private System.Windows.Forms.RadioButton MultBut;
        private System.Windows.Forms.RadioButton DivBut;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

