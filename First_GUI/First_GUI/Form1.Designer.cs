
namespace First_GUI
{
    partial class stationMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stationMainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.twoTLabelFirst = new System.Windows.Forms.Label();
            this.twoTLabelSecond = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.speedLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.threeTLabelFirst = new System.Windows.Forms.Label();
            this.threeTLabelSecond = new System.Windows.Forms.Label();
            this.B227AT_Label = new System.Windows.Forms.Label();
            this.YT_Label = new System.Windows.Forms.Label();
            this.XT_Label = new System.Windows.Forms.Label();
            this.B226BT_Label = new System.Windows.Forms.Label();
            this.diagLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(1797, 982);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "종료";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 29.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(872, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "역 이름";
            // 
            // twoTLabelFirst
            // 
            this.twoTLabelFirst.BackColor = System.Drawing.Color.White;
            this.twoTLabelFirst.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.twoTLabelFirst.ForeColor = System.Drawing.Color.Blue;
            this.twoTLabelFirst.Location = new System.Drawing.Point(533, 628);
            this.twoTLabelFirst.Name = "twoTLabelFirst";
            this.twoTLabelFirst.Size = new System.Drawing.Size(405, 33);
            this.twoTLabelFirst.TabIndex = 2;
            this.twoTLabelFirst.Text = "2T";
            this.twoTLabelFirst.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // twoTLabelSecond
            // 
            this.twoTLabelSecond.BackColor = System.Drawing.Color.White;
            this.twoTLabelSecond.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.twoTLabelSecond.ForeColor = System.Drawing.Color.Blue;
            this.twoTLabelSecond.Location = new System.Drawing.Point(944, 628);
            this.twoTLabelSecond.Name = "twoTLabelSecond";
            this.twoTLabelSecond.Size = new System.Drawing.Size(405, 33);
            this.twoTLabelSecond.TabIndex = 3;
            this.twoTLabelSecond.Text = "2T";
            this.twoTLabelSecond.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(533, 86);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(405, 180);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // speedLabel
            // 
            this.speedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speedLabel.AutoSize = true;
            this.speedLabel.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.SetColumnSpan(this.speedLabel, 2);
            this.speedLabel.Font = new System.Drawing.Font("맑은 고딕", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.speedLabel.ForeColor = System.Drawing.Color.White;
            this.speedLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.speedLabel.Location = new System.Drawing.Point(107, 34);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(196, 63);
            this.speedLabel.TabIndex = 5;
            this.speedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.speedLabel, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 798);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(720, 230);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 63);
            this.label4.TabIndex = 0;
            this.label4.Text = "속도";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // threeTLabelFirst
            // 
            this.threeTLabelFirst.BackColor = System.Drawing.Color.White;
            this.threeTLabelFirst.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.threeTLabelFirst.ForeColor = System.Drawing.Color.Blue;
            this.threeTLabelFirst.Location = new System.Drawing.Point(533, 463);
            this.threeTLabelFirst.Name = "threeTLabelFirst";
            this.threeTLabelFirst.Size = new System.Drawing.Size(405, 33);
            this.threeTLabelFirst.TabIndex = 7;
            this.threeTLabelFirst.Text = "3T";
            this.threeTLabelFirst.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // threeTLabelSecond
            // 
            this.threeTLabelSecond.BackColor = System.Drawing.Color.White;
            this.threeTLabelSecond.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.threeTLabelSecond.ForeColor = System.Drawing.Color.Blue;
            this.threeTLabelSecond.Location = new System.Drawing.Point(944, 463);
            this.threeTLabelSecond.Name = "threeTLabelSecond";
            this.threeTLabelSecond.Size = new System.Drawing.Size(405, 33);
            this.threeTLabelSecond.TabIndex = 8;
            this.threeTLabelSecond.Text = "3T";
            this.threeTLabelSecond.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // B227AT_Label
            // 
            this.B227AT_Label.BackColor = System.Drawing.Color.White;
            this.B227AT_Label.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B227AT_Label.ForeColor = System.Drawing.Color.Blue;
            this.B227AT_Label.Location = new System.Drawing.Point(263, 628);
            this.B227AT_Label.Name = "B227AT_Label";
            this.B227AT_Label.Size = new System.Drawing.Size(264, 33);
            this.B227AT_Label.TabIndex = 9;
            this.B227AT_Label.Text = "B227AT";
            this.B227AT_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // YT_Label
            // 
            this.YT_Label.BackColor = System.Drawing.Color.White;
            this.YT_Label.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YT_Label.ForeColor = System.Drawing.Color.Blue;
            this.YT_Label.Location = new System.Drawing.Point(75, 628);
            this.YT_Label.Name = "YT_Label";
            this.YT_Label.Size = new System.Drawing.Size(182, 33);
            this.YT_Label.TabIndex = 10;
            this.YT_Label.Text = "YT";
            this.YT_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // XT_Label
            // 
            this.XT_Label.BackColor = System.Drawing.Color.White;
            this.XT_Label.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.XT_Label.ForeColor = System.Drawing.Color.Blue;
            this.XT_Label.Location = new System.Drawing.Point(1625, 628);
            this.XT_Label.Name = "XT_Label";
            this.XT_Label.Size = new System.Drawing.Size(182, 33);
            this.XT_Label.TabIndex = 12;
            this.XT_Label.Text = "XT";
            this.XT_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // B226BT_Label
            // 
            this.B226BT_Label.BackColor = System.Drawing.Color.White;
            this.B226BT_Label.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B226BT_Label.ForeColor = System.Drawing.Color.Blue;
            this.B226BT_Label.Location = new System.Drawing.Point(1355, 628);
            this.B226BT_Label.Name = "B226BT_Label";
            this.B226BT_Label.Size = new System.Drawing.Size(264, 33);
            this.B226BT_Label.TabIndex = 11;
            this.B226BT_Label.Text = "B226BT";
            this.B226BT_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // diagLabel
            // 
            this.diagLabel.BackColor = System.Drawing.Color.White;
            this.diagLabel.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diagLabel.ForeColor = System.Drawing.Color.Blue;
            this.diagLabel.Location = new System.Drawing.Point(353, 463);
            this.diagLabel.Name = "diagLabel";
            this.diagLabel.Size = new System.Drawing.Size(174, 33);
            this.diagLabel.TabIndex = 13;
            this.diagLabel.Text = "3T";
            this.diagLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(7, 8);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 30);
            this.timeLabel.TabIndex = 14;
            // 
            // stationMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1920, 1040);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.diagLabel);
            this.Controls.Add(this.XT_Label);
            this.Controls.Add(this.B226BT_Label);
            this.Controls.Add(this.YT_Label);
            this.Controls.Add(this.B227AT_Label);
            this.Controls.Add(this.threeTLabelSecond);
            this.Controls.Add(this.threeTLabelFirst);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.twoTLabelSecond);
            this.Controls.Add(this.twoTLabelFirst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "stationMainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label twoTLabelFirst;
        private System.Windows.Forms.Label twoTLabelSecond;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label threeTLabelFirst;
        private System.Windows.Forms.Label threeTLabelSecond;
        private System.Windows.Forms.Label B227AT_Label;
        private System.Windows.Forms.Label YT_Label;
        private System.Windows.Forms.Label XT_Label;
        private System.Windows.Forms.Label B226BT_Label;
        private System.Windows.Forms.Label diagLabel;
        private System.Windows.Forms.Label timeLabel;
    }
}

