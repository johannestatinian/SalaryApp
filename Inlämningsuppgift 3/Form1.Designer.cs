
namespace Inlämningsuppgift_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNamn = new System.Windows.Forms.TextBox();
            this.tbxLön = new System.Windows.Forms.TextBox();
            this.btnRegistrera = new System.Windows.Forms.Button();
            this.tbxUtdata = new System.Windows.Forms.TextBox();
            this.btnVisa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxLönegrans = new System.Windows.Forms.TextBox();
            this.tbxDetfinns = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxMedellön = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lön";
            // 
            // tbxNamn
            // 
            this.tbxNamn.Location = new System.Drawing.Point(94, 23);
            this.tbxNamn.Name = "tbxNamn";
            this.tbxNamn.Size = new System.Drawing.Size(100, 20);
            this.tbxNamn.TabIndex = 2;
            // 
            // tbxLön
            // 
            this.tbxLön.Location = new System.Drawing.Point(94, 69);
            this.tbxLön.Name = "tbxLön";
            this.tbxLön.Size = new System.Drawing.Size(100, 20);
            this.tbxLön.TabIndex = 3;
            // 
            // btnRegistrera
            // 
            this.btnRegistrera.Location = new System.Drawing.Point(290, 43);
            this.btnRegistrera.Name = "btnRegistrera";
            this.btnRegistrera.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrera.TabIndex = 4;
            this.btnRegistrera.Text = "Registrera";
            this.btnRegistrera.UseVisualStyleBackColor = true;
            this.btnRegistrera.Click += new System.EventHandler(this.btnRegistrera_Click);
            // 
            // tbxUtdata
            // 
            this.tbxUtdata.Location = new System.Drawing.Point(94, 95);
            this.tbxUtdata.Multiline = true;
            this.tbxUtdata.Name = "tbxUtdata";
            this.tbxUtdata.Size = new System.Drawing.Size(351, 169);
            this.tbxUtdata.TabIndex = 5;
            // 
            // btnVisa
            // 
            this.btnVisa.Location = new System.Drawing.Point(441, 301);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Size = new System.Drawing.Size(75, 23);
            this.btnVisa.TabIndex = 6;
            this.btnVisa.Text = "Visa";
            this.btnVisa.UseVisualStyleBackColor = true;
            this.btnVisa.Click += new System.EventHandler(this.btnVisa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lönegrans";
            // 
            // tbxLönegrans
            // 
            this.tbxLönegrans.Location = new System.Drawing.Point(168, 298);
            this.tbxLönegrans.Name = "tbxLönegrans";
            this.tbxLönegrans.Size = new System.Drawing.Size(100, 20);
            this.tbxLönegrans.TabIndex = 8;
            this.tbxLönegrans.TextChanged += new System.EventHandler(this.tbxLönegrans_TextChanged);
            // 
            // tbxDetfinns
            // 
            this.tbxDetfinns.Location = new System.Drawing.Point(80, 356);
            this.tbxDetfinns.Name = "tbxDetfinns";
            this.tbxDetfinns.Size = new System.Drawing.Size(264, 20);
            this.tbxDetfinns.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Medellön";
            // 
            // tbxMedellön
            // 
            this.tbxMedellön.Location = new System.Drawing.Point(168, 401);
            this.tbxMedellön.Name = "tbxMedellön";
            this.tbxMedellön.Size = new System.Drawing.Size(100, 20);
            this.tbxMedellön.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxMedellön);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxDetfinns);
            this.Controls.Add(this.tbxLönegrans);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVisa);
            this.Controls.Add(this.tbxUtdata);
            this.Controls.Add(this.btnRegistrera);
            this.Controls.Add(this.tbxLön);
            this.Controls.Add(this.tbxNamn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxNamn;
        private System.Windows.Forms.TextBox tbxLön;
        private System.Windows.Forms.Button btnRegistrera;
        private System.Windows.Forms.TextBox tbxUtdata;
        private System.Windows.Forms.Button btnVisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxLönegrans;
        private System.Windows.Forms.TextBox tbxDetfinns;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxMedellön;
    }
}

