namespace GraphTesting
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
            this.TACBxKustEelmine = new System.Windows.Forms.CheckBox();
            this.TATBSuurus = new System.Windows.Forms.TrackBar();
            this.TABAutoDraw = new System.Windows.Forms.Button();
            this.TACBxSuvalisedArvud = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GridY = new System.Windows.Forms.TextBox();
            this.GridX = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TARBSuvalineVärv = new System.Windows.Forms.RadioButton();
            this.TARBKindelVärv = new System.Windows.Forms.RadioButton();
            this.VärvPreview = new System.Windows.Forms.Label();
            this.TABVärv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TABDraw = new System.Windows.Forms.Button();
            this.Gridbox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TALPlus0 = new System.Windows.Forms.Label();
            this.TALPlus1 = new System.Windows.Forms.Label();
            this.TALPlus2 = new System.Windows.Forms.Label();
            this.TATBx2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TATBx1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TATBx0 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TATimer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TATBxAlg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TATBxLopp = new System.Windows.Forms.TextBox();
            this.TABClear = new System.Windows.Forms.Button();
            this.TAPBxCanvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TATBSuurus)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.Gridbox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TAPBxCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // TACBxKustEelmine
            // 
            this.TACBxKustEelmine.AutoSize = true;
            this.TACBxKustEelmine.Location = new System.Drawing.Point(13, 494);
            this.TACBxKustEelmine.Name = "TACBxKustEelmine";
            this.TACBxKustEelmine.Size = new System.Drawing.Size(160, 26);
            this.TACBxKustEelmine.TabIndex = 22;
            this.TACBxKustEelmine.Text = "Kustuta Eelmine";
            this.TACBxKustEelmine.UseVisualStyleBackColor = true;
            // 
            // TATBSuurus
            // 
            this.TATBSuurus.LargeChange = 1;
            this.TATBSuurus.Location = new System.Drawing.Point(742, 12);
            this.TATBSuurus.Name = "TATBSuurus";
            this.TATBSuurus.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TATBSuurus.Size = new System.Drawing.Size(69, 579);
            this.TATBSuurus.TabIndex = 21;
            this.TATBSuurus.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TATBSuurus.Value = 2;
            this.TATBSuurus.Scroll += new System.EventHandler(this.TATBSuurus_Scroll);
            // 
            // TABAutoDraw
            // 
            this.TABAutoDraw.Location = new System.Drawing.Point(12, 560);
            this.TABAutoDraw.Name = "TABAutoDraw";
            this.TABAutoDraw.Size = new System.Drawing.Size(724, 32);
            this.TABAutoDraw.TabIndex = 18;
            this.TABAutoDraw.Text = "Joonista Automaatselt [Sisse]";
            this.TABAutoDraw.UseVisualStyleBackColor = true;
            this.TABAutoDraw.Click += new System.EventHandler(this.TABAutoDraw_Click);
            // 
            // TACBxSuvalisedArvud
            // 
            this.TACBxSuvalisedArvud.AutoSize = true;
            this.TACBxSuvalisedArvud.Location = new System.Drawing.Point(21, 23);
            this.TACBxSuvalisedArvud.Name = "TACBxSuvalisedArvud";
            this.TACBxSuvalisedArvud.Size = new System.Drawing.Size(112, 48);
            this.TACBxSuvalisedArvud.TabIndex = 4;
            this.TACBxSuvalisedArvud.Text = "Suvalised \r\n Arvud";
            this.TACBxSuvalisedArvud.UseVisualStyleBackColor = true;
            this.TACBxSuvalisedArvud.CheckedChanged += new System.EventHandler(this.TACBxSuvalisedArvud_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "X=";
            // 
            // GridY
            // 
            this.GridY.Location = new System.Drawing.Point(116, 38);
            this.GridY.Name = "GridY";
            this.GridY.Size = new System.Drawing.Size(61, 29);
            this.GridY.TabIndex = 2;
            this.GridY.Text = "10";
            this.GridY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GridX
            // 
            this.GridX.Location = new System.Drawing.Point(116, 69);
            this.GridX.Name = "GridX";
            this.GridX.Size = new System.Drawing.Size(61, 29);
            this.GridX.TabIndex = 2;
            this.GridX.Text = "10";
            this.GridX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TARBSuvalineVärv);
            this.groupBox3.Controls.Add(this.TARBKindelVärv);
            this.groupBox3.Controls.Add(this.VärvPreview);
            this.groupBox3.Controls.Add(this.TABVärv);
            this.groupBox3.Location = new System.Drawing.Point(12, 347);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 141);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Värv   ";
            // 
            // TARBSuvalineVärv
            // 
            this.TARBSuvalineVärv.AutoSize = true;
            this.TARBSuvalineVärv.Location = new System.Drawing.Point(12, 25);
            this.TARBSuvalineVärv.Name = "TARBSuvalineVärv";
            this.TARBSuvalineVärv.Size = new System.Drawing.Size(137, 26);
            this.TARBSuvalineVärv.TabIndex = 11;
            this.TARBSuvalineVärv.TabStop = true;
            this.TARBSuvalineVärv.Text = "Suvaline Värv";
            this.TARBSuvalineVärv.UseVisualStyleBackColor = true;
            // 
            // TARBKindelVärv
            // 
            this.TARBKindelVärv.AutoSize = true;
            this.TARBKindelVärv.Location = new System.Drawing.Point(12, 53);
            this.TARBKindelVärv.Name = "TARBKindelVärv";
            this.TARBKindelVärv.Size = new System.Drawing.Size(121, 26);
            this.TARBKindelVärv.TabIndex = 11;
            this.TARBKindelVärv.TabStop = true;
            this.TARBKindelVärv.Text = "Kindel Värv";
            this.TARBKindelVärv.UseVisualStyleBackColor = true;
            this.TARBKindelVärv.CheckedChanged += new System.EventHandler(this.TARBKindelVärv_CheckedChanged);
            // 
            // VärvPreview
            // 
            this.VärvPreview.BackColor = System.Drawing.Color.WhiteSmoke;
            this.VärvPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VärvPreview.Location = new System.Drawing.Point(54, 2);
            this.VärvPreview.Name = "VärvPreview";
            this.VärvPreview.Size = new System.Drawing.Size(21, 18);
            this.VärvPreview.TabIndex = 3;
            // 
            // TABVärv
            // 
            this.TABVärv.Enabled = false;
            this.TABVärv.Location = new System.Drawing.Point(12, 85);
            this.TABVärv.Name = "TABVärv";
            this.TABVärv.Size = new System.Drawing.Size(176, 39);
            this.TABVärv.TabIndex = 2;
            this.TABVärv.Text = "Vali Värv";
            this.TABVärv.UseVisualStyleBackColor = true;
            this.TABVärv.Click += new System.EventHandler(this.TABVärv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Y=";
            // 
            // TABDraw
            // 
            this.TABDraw.Location = new System.Drawing.Point(12, 522);
            this.TABDraw.Name = "TABDraw";
            this.TABDraw.Size = new System.Drawing.Size(280, 32);
            this.TABDraw.TabIndex = 20;
            this.TABDraw.Text = "Joonista";
            this.TABDraw.UseVisualStyleBackColor = true;
            this.TABDraw.Click += new System.EventHandler(this.TABDraw_Click);
            // 
            // Gridbox
            // 
            this.Gridbox.Controls.Add(this.label4);
            this.Gridbox.Controls.Add(this.GridY);
            this.Gridbox.Controls.Add(this.GridX);
            this.Gridbox.Controls.Add(this.label1);
            this.Gridbox.Location = new System.Drawing.Point(12, 232);
            this.Gridbox.Name = "Gridbox";
            this.Gridbox.Size = new System.Drawing.Size(194, 109);
            this.Gridbox.TabIndex = 17;
            this.Gridbox.TabStop = false;
            this.Gridbox.Text = "Ruudustiku Suurus";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TACBxSuvalisedArvud);
            this.groupBox2.Controls.Add(this.TALPlus0);
            this.groupBox2.Controls.Add(this.TALPlus1);
            this.groupBox2.Controls.Add(this.TALPlus2);
            this.groupBox2.Controls.Add(this.TATBx2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TATBx1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TATBx0);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(724, 83);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Andmed";
            // 
            // TALPlus0
            // 
            this.TALPlus0.AutoSize = true;
            this.TALPlus0.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TALPlus0.Location = new System.Drawing.Point(271, 26);
            this.TALPlus0.Name = "TALPlus0";
            this.TALPlus0.Size = new System.Drawing.Size(34, 36);
            this.TALPlus0.TabIndex = 0;
            this.TALPlus0.Text = "+";
            this.TALPlus0.Click += new System.EventHandler(this.TALPlus1_Click);
            // 
            // TALPlus1
            // 
            this.TALPlus1.AutoSize = true;
            this.TALPlus1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TALPlus1.Location = new System.Drawing.Point(417, 26);
            this.TALPlus1.Name = "TALPlus1";
            this.TALPlus1.Size = new System.Drawing.Size(34, 36);
            this.TALPlus1.TabIndex = 0;
            this.TALPlus1.Text = "+";
            this.TALPlus1.Click += new System.EventHandler(this.TALPlus1_Click);
            // 
            // TALPlus2
            // 
            this.TALPlus2.AutoSize = true;
            this.TALPlus2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TALPlus2.Location = new System.Drawing.Point(563, 26);
            this.TALPlus2.Name = "TALPlus2";
            this.TALPlus2.Size = new System.Drawing.Size(34, 36);
            this.TALPlus2.TabIndex = 0;
            this.TALPlus2.Text = "+";
            this.TALPlus2.Click += new System.EventHandler(this.TALPlus1_Click);
            // 
            // TATBx2
            // 
            this.TATBx2.Location = new System.Drawing.Point(606, 30);
            this.TATBx2.Name = "TATBx2";
            this.TATBx2.Size = new System.Drawing.Size(40, 29);
            this.TATBx2.TabIndex = 2;
            this.TATBx2.Text = "0";
            this.TATBx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y=";
            // 
            // TATBx1
            // 
            this.TATBx1.Location = new System.Drawing.Point(460, 30);
            this.TATBx1.Name = "TATBx1";
            this.TATBx1.Size = new System.Drawing.Size(40, 29);
            this.TATBx1.TabIndex = 2;
            this.TATBx1.Text = "0";
            this.TATBx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(655, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 28);
            this.label8.TabIndex = 3;
            this.label8.Text = "C";
            // 
            // TATBx0
            // 
            this.TATBx0.Location = new System.Drawing.Point(314, 30);
            this.TATBx0.Name = "TATBx0";
            this.TATBx0.Size = new System.Drawing.Size(40, 29);
            this.TATBx0.TabIndex = 2;
            this.TATBx0.Text = "0";
            this.TATBx0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(509, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 28);
            this.label7.TabIndex = 3;
            this.label7.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "A";
            // 
            // TATimer2
            // 
            this.TATimer2.Tick += new System.EventHandler(this.TATimer2_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TATBxAlg);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TATBxLopp);
            this.groupBox1.Location = new System.Drawing.Point(12, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 125);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vahemik";
            // 
            // TATBxAlg
            // 
            this.TATBxAlg.Location = new System.Drawing.Point(116, 33);
            this.TATBxAlg.Name = "TATBxAlg";
            this.TATBxAlg.Size = new System.Drawing.Size(61, 29);
            this.TATBxAlg.TabIndex = 2;
            this.TATBxAlg.Text = "-3";
            this.TATBxAlg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 28);
            this.label9.TabIndex = 1;
            this.label9.Text = "Xalg  =";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 28);
            this.label10.TabIndex = 1;
            this.label10.Text = "Xlõpp =";
            // 
            // TATBxLopp
            // 
            this.TATBxLopp.Location = new System.Drawing.Point(116, 78);
            this.TATBxLopp.Name = "TATBxLopp";
            this.TATBxLopp.Size = new System.Drawing.Size(61, 29);
            this.TATBxLopp.TabIndex = 2;
            this.TATBxLopp.Text = "+3";
            this.TATBxLopp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TABClear
            // 
            this.TABClear.Location = new System.Drawing.Point(306, 522);
            this.TABClear.Name = "TABClear";
            this.TABClear.Size = new System.Drawing.Size(430, 32);
            this.TABClear.TabIndex = 14;
            this.TABClear.Text = "Puhasta";
            this.TABClear.UseVisualStyleBackColor = true;
            this.TABClear.Click += new System.EventHandler(this.TABClear_Click);
            // 
            // TAPBxCanvas
            // 
            this.TAPBxCanvas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TAPBxCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TAPBxCanvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.TAPBxCanvas.Location = new System.Drawing.Point(212, 101);
            this.TAPBxCanvas.Name = "TAPBxCanvas";
            this.TAPBxCanvas.Size = new System.Drawing.Size(524, 389);
            this.TAPBxCanvas.TabIndex = 13;
            this.TAPBxCanvas.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(803, 603);
            this.Controls.Add(this.TACBxKustEelmine);
            this.Controls.Add(this.TATBSuurus);
            this.Controls.Add(this.TABAutoDraw);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.TABDraw);
            this.Controls.Add(this.Gridbox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TABClear);
            this.Controls.Add(this.TAPBxCanvas);
            this.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Graph Theorem Testing";
            ((System.ComponentModel.ISupportInitialize)(this.TATBSuurus)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Gridbox.ResumeLayout(false);
            this.Gridbox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TAPBxCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox TACBxKustEelmine;
        private System.Windows.Forms.TrackBar TATBSuurus;
        private System.Windows.Forms.Button TABAutoDraw;
        private System.Windows.Forms.CheckBox TACBxSuvalisedArvud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GridY;
        private System.Windows.Forms.TextBox GridX;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton TARBSuvalineVärv;
        private System.Windows.Forms.RadioButton TARBKindelVärv;
        private System.Windows.Forms.Label VärvPreview;
        private System.Windows.Forms.Button TABVärv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TABDraw;
        private System.Windows.Forms.GroupBox Gridbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label TALPlus0;
        private System.Windows.Forms.Label TALPlus1;
        private System.Windows.Forms.Label TALPlus2;
        private System.Windows.Forms.TextBox TATBx2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TATBx1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TATBx0;
        private System.Windows.Forms.Timer TATimer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TATBxAlg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TATBxLopp;
        private System.Windows.Forms.Button TABClear;
        private System.Windows.Forms.PictureBox TAPBxCanvas;
    }
}

