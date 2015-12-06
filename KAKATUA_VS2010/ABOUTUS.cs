using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KAKATUA
{
    public partial class About_US : Form
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private Button CLOSE;
        public About_US()
        {
            InitializeComponent2();
        }
        void InitializeComponent2()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();

            this.CLOSE = new System.Windows.Forms.Button();
            this.CLOSE.BackColor = System.Drawing.Color.Red;

            this.CLOSE.Location = new System.Drawing.Point(480, 520);
            //this.CLOSE.Name = "btnReset";
            this.CLOSE.Size = new System.Drawing.Size(90, 35);
            this.CLOSE.TabIndex = 0;
            this.CLOSE.Text = "CLOSE";

            this.CLOSE.Click += new System.EventHandler(this.CLOSE_Click);
            // this.CLOSE.UseVisualStyleBackColor = false;

            this.Size = new System.Drawing.Size(600, 600);
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.Text = "About  US";
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Siyam Rupali", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Developed By :    MD.Ashikuzzaman   KUET CSE 3RD Year";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Siyam Rupali", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(10, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 80);
            this.label2.TabIndex = 0;
            this.label2.Text = "And Ahnaf Sermiabat   KUET CSE 3RD Year";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Siyam Rupali", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(100, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 390);
            this.label3.TabIndex = 0;
            this.label3.Text = "Salsabil Water Group                 Helped BY:                       IrrKlang .NET class Library                   And Kuet Dreamers";
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(this.CLOSE);
        }
        private void About_US_Load(object sender, EventArgs e)
        {

        }
        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
