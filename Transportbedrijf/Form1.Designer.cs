namespace Transportbedrijf
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
            this.components = new System.ComponentModel.Container();
            this.TextBoxM3 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TextBoxKg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckBoxVloeibaar = new System.Windows.Forms.CheckBox();
            this.Vloeibaar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxKm = new System.Windows.Forms.TextBox();
            this.Bereken = new System.Windows.Forms.Button();
            this.TextBoxBuitenKm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxM3
            // 
            this.TextBoxM3.Location = new System.Drawing.Point(109, 12);
            this.TextBoxM3.Name = "TextBoxM3";
            this.TextBoxM3.Size = new System.Drawing.Size(100, 20);
            this.TextBoxM3.TabIndex = 0;
            this.TextBoxM3.Text = "0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TextBoxKg
            // 
            this.TextBoxKg.Location = new System.Drawing.Point(109, 39);
            this.TextBoxKg.Name = "TextBoxKg";
            this.TextBoxKg.Size = new System.Drawing.Size(100, 20);
            this.TextBoxKg.TabIndex = 2;
            this.TextBoxKg.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "M3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kg";
            // 
            // CheckBoxVloeibaar
            // 
            this.CheckBoxVloeibaar.AutoSize = true;
            this.CheckBoxVloeibaar.Location = new System.Drawing.Point(109, 117);
            this.CheckBoxVloeibaar.Name = "CheckBoxVloeibaar";
            this.CheckBoxVloeibaar.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxVloeibaar.TabIndex = 5;
            this.CheckBoxVloeibaar.UseVisualStyleBackColor = true;
            // 
            // Vloeibaar
            // 
            this.Vloeibaar.AutoSize = true;
            this.Vloeibaar.Location = new System.Drawing.Point(21, 117);
            this.Vloeibaar.Name = "Vloeibaar";
            this.Vloeibaar.Size = new System.Drawing.Size(82, 13);
            this.Vloeibaar.TabIndex = 6;
            this.Vloeibaar.Text = "Vloeibare lading";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Km binnenland";
            // 
            // TextBoxKm
            // 
            this.TextBoxKm.Location = new System.Drawing.Point(109, 65);
            this.TextBoxKm.Name = "TextBoxKm";
            this.TextBoxKm.Size = new System.Drawing.Size(100, 20);
            this.TextBoxKm.TabIndex = 9;
            this.TextBoxKm.Text = "0";
            // 
            // Bereken
            // 
            this.Bereken.Location = new System.Drawing.Point(109, 137);
            this.Bereken.Name = "Bereken";
            this.Bereken.Size = new System.Drawing.Size(100, 23);
            this.Bereken.TabIndex = 11;
            this.Bereken.Text = "Bereken";
            this.Bereken.UseVisualStyleBackColor = true;
            this.Bereken.Click += new System.EventHandler(this.Bereken_Click);
            // 
            // TextBoxBuitenKm
            // 
            this.TextBoxBuitenKm.Location = new System.Drawing.Point(109, 91);
            this.TextBoxBuitenKm.Name = "TextBoxBuitenKm";
            this.TextBoxBuitenKm.Size = new System.Drawing.Size(100, 20);
            this.TextBoxBuitenKm.TabIndex = 12;
            this.TextBoxBuitenKm.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Km buitenland";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(12, 163);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(224, 23);
            this.Output.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 205);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxBuitenKm);
            this.Controls.Add(this.Bereken);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxKm);
            this.Controls.Add(this.Vloeibaar);
            this.Controls.Add(this.CheckBoxVloeibaar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxKg);
            this.Controls.Add(this.TextBoxM3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Transport kosten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxM3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TextBoxKg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CheckBoxVloeibaar;
        private System.Windows.Forms.Label Vloeibaar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxKm;
        private System.Windows.Forms.Button Bereken;
        private System.Windows.Forms.TextBox TextBoxBuitenKm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Output;
    }
}

