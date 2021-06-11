namespace Eduplex_Secretary
{
    partial class ProblemDetailForm
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
            this.ProblemPB = new System.Windows.Forms.PictureBox();
            this.PBMirror = new System.Windows.Forms.PictureBox();
            this.lvwMain = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMainUnitCode = new System.Windows.Forms.Label();
            this.lblMain = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMirrorUnitCode = new System.Windows.Forms.Label();
            this.lblMirrorSource = new System.Windows.Forms.Label();
            this.lvwMirror = new System.Windows.Forms.ListView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProblemPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMirror)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProblemPB
            // 
            this.ProblemPB.Location = new System.Drawing.Point(12, 12);
            this.ProblemPB.Name = "ProblemPB";
            this.ProblemPB.Size = new System.Drawing.Size(500, 434);
            this.ProblemPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProblemPB.TabIndex = 0;
            this.ProblemPB.TabStop = false;
            // 
            // PBMirror
            // 
            this.PBMirror.Location = new System.Drawing.Point(522, 12);
            this.PBMirror.Name = "PBMirror";
            this.PBMirror.Size = new System.Drawing.Size(500, 434);
            this.PBMirror.TabIndex = 1;
            this.PBMirror.TabStop = false;
            // 
            // lvwMain
            // 
            this.lvwMain.FullRowSelect = true;
            this.lvwMain.HideSelection = false;
            this.lvwMain.Location = new System.Drawing.Point(12, 555);
            this.lvwMain.Name = "lvwMain";
            this.lvwMain.Size = new System.Drawing.Size(500, 194);
            this.lvwMain.TabIndex = 2;
            this.lvwMain.UseCompatibleStateImageBehavior = false;
            this.lvwMain.DoubleClick += new System.EventHandler(this.lvwMain_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMainUnitCode);
            this.groupBox1.Controls.Add(this.lblMain);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 452);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 97);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "속성";
            // 
            // lblMainUnitCode
            // 
            this.lblMainUnitCode.AutoSize = true;
            this.lblMainUnitCode.Location = new System.Drawing.Point(11, 60);
            this.lblMainUnitCode.Name = "lblMainUnitCode";
            this.lblMainUnitCode.Size = new System.Drawing.Size(39, 15);
            this.lblMainUnitCode.TabIndex = 2;
            this.lblMainUnitCode.Text = "label1";
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new System.Drawing.Point(11, 25);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(31, 15);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "설명";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMirrorUnitCode);
            this.groupBox2.Controls.Add(this.lblMirrorSource);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(522, 452);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 97);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "틀릴만한 문제";
            // 
            // lblMirrorUnitCode
            // 
            this.lblMirrorUnitCode.AutoSize = true;
            this.lblMirrorUnitCode.Location = new System.Drawing.Point(10, 60);
            this.lblMirrorUnitCode.Name = "lblMirrorUnitCode";
            this.lblMirrorUnitCode.Size = new System.Drawing.Size(39, 15);
            this.lblMirrorUnitCode.TabIndex = 1;
            this.lblMirrorUnitCode.Text = "label1";
            // 
            // lblMirrorSource
            // 
            this.lblMirrorSource.AutoSize = true;
            this.lblMirrorSource.Location = new System.Drawing.Point(10, 24);
            this.lblMirrorSource.Name = "lblMirrorSource";
            this.lblMirrorSource.Size = new System.Drawing.Size(31, 15);
            this.lblMirrorSource.TabIndex = 0;
            this.lblMirrorSource.Text = "설명";
            // 
            // lvwMirror
            // 
            this.lvwMirror.FullRowSelect = true;
            this.lvwMirror.HideSelection = false;
            this.lvwMirror.Location = new System.Drawing.Point(522, 559);
            this.lvwMirror.Name = "lvwMirror";
            this.lvwMirror.Size = new System.Drawing.Size(498, 147);
            this.lvwMirror.TabIndex = 5;
            this.lvwMirror.UseCompatibleStateImageBehavior = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.Location = new System.Drawing.Point(950, 712);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 37);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "나가기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ProblemDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1034, 761);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lvwMirror);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvwMain);
            this.Controls.Add(this.PBMirror);
            this.Controls.Add(this.ProblemPB);
            this.Name = "ProblemDetailForm";
            this.Text = "ProblemDetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProblemPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMirror)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ProblemPB;
        private System.Windows.Forms.PictureBox PBMirror;
        private System.Windows.Forms.ListView lvwMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMainUnitCode;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMirrorUnitCode;
        private System.Windows.Forms.Label lblMirrorSource;
        private System.Windows.Forms.ListView lvwMirror;
        private System.Windows.Forms.Button btnClose;
    }
}