namespace Eduplex_Secretary
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvwProblems = new System.Windows.Forms.ListView();
            this.cmbSource = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filterPB = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PBSimpleview = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvwBucket = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSimpleview)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(86, 22);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(79, 23);
            this.cmbYear.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 60);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUserName.Location = new System.Drawing.Point(389, 12);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(81, 13);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "님, 환영합니다.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 3;
            // 
            // lvwProblems
            // 
            this.lvwProblems.FullRowSelect = true;
            this.lvwProblems.HideSelection = false;
            this.lvwProblems.Location = new System.Drawing.Point(11, 138);
            this.lvwProblems.Name = "lvwProblems";
            this.lvwProblems.Size = new System.Drawing.Size(452, 262);
            this.lvwProblems.TabIndex = 4;
            this.lvwProblems.UseCompatibleStateImageBehavior = false;
            this.lvwProblems.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwProblems_ColumnClick);
            this.lvwProblems.Click += new System.EventHandler(this.lvwProblems_Click);
            this.lvwProblems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwProblems_MouseDoubleClick);
            // 
            // cmbSource
            // 
            this.cmbSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSource.FormattingEnabled = true;
            this.cmbSource.Location = new System.Drawing.Point(239, 22);
            this.cmbSource.Name = "cmbSource";
            this.cmbSource.Size = new System.Drawing.Size(83, 23);
            this.cmbSource.TabIndex = 5;
            this.cmbSource.SelectedIndexChanged += new System.EventHandler(this.cmbSource_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "출제학년도 :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filterPB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbSource);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbYear);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(11, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 54);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "설정";
            // 
            // filterPB
            // 
            this.filterPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.filterPB.ImageLocation = "";
            this.filterPB.InitialImage = null;
            this.filterPB.Location = new System.Drawing.Point(422, 22);
            this.filterPB.Name = "filterPB";
            this.filterPB.Size = new System.Drawing.Size(23, 23);
            this.filterPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filterPB.TabIndex = 8;
            this.filterPB.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "문제출처 :";
            // 
            // PBSimpleview
            // 
            this.PBSimpleview.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PBSimpleview.Location = new System.Drawing.Point(6, 26);
            this.PBSimpleview.Name = "PBSimpleview";
            this.PBSimpleview.Size = new System.Drawing.Size(500, 591);
            this.PBSimpleview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBSimpleview.TabIndex = 8;
            this.PBSimpleview.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PBSimpleview);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(484, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 623);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "미리보기";
            // 
            // lvwBucket
            // 
            this.lvwBucket.FullRowSelect = true;
            this.lvwBucket.HideSelection = false;
            this.lvwBucket.Location = new System.Drawing.Point(11, 464);
            this.lvwBucket.Name = "lvwBucket";
            this.lvwBucket.Size = new System.Drawing.Size(451, 188);
            this.lvwBucket.TabIndex = 10;
            this.lvwBucket.UseCompatibleStateImageBehavior = false;
            this.lvwBucket.Click += new System.EventHandler(this.lvwBucket_Click);
            this.lvwBucket.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwBucket_MouseDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(12, 406);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(449, 52);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "나만의 문제집 만들기";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCreate.Location = new System.Drawing.Point(11, 658);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(118, 37);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "문제집 만들기";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lvwBucket);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvwProblems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "MainForm";
            this.Text = "Eduplex Secretary";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSimpleview)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvwProblems;
        private System.Windows.Forms.ComboBox cmbSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PBSimpleview;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvwBucket;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.PictureBox filterPB;
    }
}

