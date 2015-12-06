using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IrrKlang;
using Detecting_Converting_String;
namespace KAKATUA
{


    public partial class BODY : System.Windows.Forms.Form
    {
        string current_string = "";
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private Button btnReset;
        private Button button1;
        private Button Body_Color;
        private TextBox Editor;
        private TrackBar play_position;
        private TrackBar volume;
        private TrackBar tempo;




        int Body_Color_value = 0;
        int Text_Tox_Color = 0;
        //Exercise2 ex = new program2.Exercise2();
        private System.ComponentModel.Container components = null;
        public BODY()
        {

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Editor = new System.Windows.Forms.TextBox();
            this.play_position = new System.Windows.Forms.TrackBar();
            this.btnReset = new System.Windows.Forms.Button();
            this.Body_Color = new System.Windows.Forms.Button();
            this.volume = new System.Windows.Forms.TrackBar();
            this.tempo = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.play_position)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Siyam Rupali", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(1210, 623);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 104);
            this.label1.TabIndex = 0;
            this.label1.Text = "বর্তমান শব্দ : তোমার";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Siyam Rupali", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(186, 738);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 104);
            this.label2.TabIndex = 0;
            this.label2.Text = "Volume";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Siyam Rupali", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(444, 738);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 104);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tempo";
            // 
            // Editor
            // 
            this.Editor.BackColor = System.Drawing.SystemColors.Window;
            this.Editor.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editor.Location = new System.Drawing.Point(166, 22);
            this.Editor.Multiline = true;
            this.Editor.Name = "Editor";
            this.Editor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Editor.Size = new System.Drawing.Size(532, 222);
            this.Editor.TabIndex = 2;
            this.Editor.Text = "তোমার নাম কি ? আমার নাম আশিক । আমার নাম আহনাফ । আমরা খাবো । ";
            this.Editor.TextChanged += new System.EventHandler(this.Editor_TextChanged);
            this.Editor.MouseLeave += new System.EventHandler(this.Editor_MouseLeave);
            this.Editor.MouseHover += new System.EventHandler(this.Editor_MouseHover);
            // 
            // play_position
            // 
            this.play_position.Location = new System.Drawing.Point(24, 652);
            this.play_position.Maximum = "তোমার নাম কি তোমার নাম কি তোমার নাম কি ".Length;
            this.play_position.Name = "play_position";
            this.play_position.Size = new System.Drawing.Size(1176, 56);
            this.play_position.TabIndex = 1;
            this.play_position.MouseCaptureChanged += new System.EventHandler(this.play_position_MouseCaptureChanged);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnReset.Location = new System.Drawing.Point(166, 288);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(108, 40);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "READ";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.OnbtnResetClick);
            // 
            // Body_Color
            // 
            this.Body_Color.BackColor = System.Drawing.Color.DarkOrange;
            this.Body_Color.ForeColor = System.Drawing.Color.White;
            this.Body_Color.Location = new System.Drawing.Point(1212, 69);
            this.Body_Color.Name = "Body_Color";
            this.Body_Color.Size = new System.Drawing.Size(157, 60);
            this.Body_Color.TabIndex = 4;
            this.Body_Color.Text = "CHANE BODY COLOR";
            this.Body_Color.UseVisualStyleBackColor = false;
            this.Body_Color.Click += new System.EventHandler(this.Body_Color_Click);
            // 
            // volume
            // 
            this.volume.Location = new System.Drawing.Point(168, 704);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(120, 56);
            this.volume.TabIndex = 3;
            this.volume.Value = 10;
            // 
            // tempo
            // 
            this.tempo.Location = new System.Drawing.Point(420, 704);
            this.tempo.Name = "tempo";
            this.tempo.Size = new System.Drawing.Size(144, 56);
            this.tempo.TabIndex = 3;
            this.tempo.Value = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Location = new System.Drawing.Point(1214, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "ABOUT US";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BODY
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(811, 380);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Editor);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.play_position);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.Body_Color);
            this.Controls.Add(this.tempo);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Name = "BODY";
            this.Text = "কাকাতুয়া";
            this.TransparencyKey = System.Drawing.Color.SpringGreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BODY_FormClosed);
            this.Load += new System.EventHandler(this.Exercise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.play_position)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }


        #region Section Used to Initialize Controls

        #endregion
        static void Main()
        {
            Application.Run(new BODY());
            // Notice how CountDown is qualified by Counter.

            //Exercise mt=new Exercise ();
            //Thread newThrd = new Thread(mt.InitializeComponent);
            // newThrd.Start();
        }
        public void Close()
        {

            char_no = Editor.Text.Length + 2;
        }


        public void OnbtnResetClick(object sender, System.EventArgs e)
        {

            play_position.Minimum = 0;
            this.play_position.Maximum = Editor.Text.Length - 1;
            // this.play_position.Value =0;
            //  MessageBox.Show(Editor.Text.Length.ToString());
            if (btnReset.Text == "STOP")
            {
                char_no = Editor.Text.Length + 1;
                btnReset.Text = "READ";
            }
            else if (btnReset.Text == "READ")
            {
                btnReset.Text = "STOP";

                BODY mt = new BODY();
                Thread newThrd = new Thread(this.SPEAK);
                // Finally, start execution of the thread.

                newThrd.Start(this.Editor.Text);
            }
            //    MessageBox.Show("play_position.Value.ToString()");

        }



        private void Exercise_Load(object sender, EventArgs e)
        {

        }

        private void Editor_TextChanged(object sender, EventArgs e)
        {
            this.play_position.Maximum = Editor.Text.Length - 1;
        }

        private void play_position_MouseCaptureChanged(object sender, EventArgs e)
        {
            this.play_position.Maximum = Editor.Text.Length - 1;

            if (play_position.Value != 0 && Editor.Text[play_position.Value] != ' ')
            {
                int i = 0;
                for (i = play_position.Value; i >= 0; i--)
                {
                    if (Editor.Text[i] == ' ') break;
                }
                play_position.Value = i + 1;
            }
            current_string = Editor.Text + "                                              ";
            current_string = current_string.Substring(play_position.Value, 15);
            current_string = current_string.Substring(0, current_string.IndexOf(" "));
            this.label1.Text = "বর্তমান শব্দ : " + current_string;
        }

        private void Body_Color_Click(object sender, EventArgs e)
        {
            Body_Color_value++;
            if (Body_Color_value > 7) Body_Color_value = 0;

            if (Body_Color_value == 0)
            {
                this.BackColor = System.Drawing.Color.PowderBlue; btnReset.BackColor = System.Drawing.SystemColors.HotTrack; ;
            }
            else if (Body_Color_value == 1) { this.BackColor = System.Drawing.Color.CadetBlue; btnReset.BackColor = System.Drawing.Color.SkyBlue; }
            else if (Body_Color_value == 2) { this.BackColor = System.Drawing.Color.Magenta; btnReset.BackColor = System.Drawing.Color.NavajoWhite; }
            else if (Body_Color_value == 3) { this.BackColor = System.Drawing.Color.NavajoWhite; btnReset.BackColor = System.Drawing.Color.Khaki; }
            else if (Body_Color_value == 4) { this.BackColor = System.Drawing.Color.Beige; btnReset.BackColor = System.Drawing.Color.Plum; }
            else if (Body_Color_value == 5) this.BackColor = System.Drawing.Color.AliceBlue;
            else if (Body_Color_value == 6) this.BackColor = System.Drawing.Color.DarkOrange;
            else if (Body_Color_value == 7) this.BackColor = System.Drawing.Color.Black;


        }

        private void Editor_MouseHover(object sender, EventArgs e)
        {
            Editor.BackColor = System.Drawing.SystemColors.Window;
        }

        private void Editor_MouseLeave(object sender, EventArgs e)
        {
            Editor.BackColor = System.Drawing.SystemColors.Window;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            About_US about = new About_US();
            about.Show();
        }

        private void BODY_FormClosed(object sender, FormClosedEventArgs e)
        {
            char_no = Editor.Text.Length + 6;
        }








    }
}
