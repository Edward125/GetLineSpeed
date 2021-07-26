namespace GetLineSpeed
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblAppName = new System.Windows.Forms.Label();
            this.picWistronLogo = new System.Windows.Forms.PictureBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabRun = new System.Windows.Forms.TabPage();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.lblUploadInterval = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbPLCModel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLine = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPLCIP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWebService = new System.Windows.Forms.TextBox();
            this.richMessage = new System.Windows.Forms.RichTextBox();
            this.lstPLCInfo = new System.Windows.Forms.ListView();
            this.axActPLC = new AxActProgTypeLib.AxActProgType();
            ((System.ComponentModel.ISupportInitialize)(this.picWistronLogo)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabRun.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axActPLC)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(107)))), ((int)(((byte)(146)))));
            this.lblAppName.Location = new System.Drawing.Point(275, 9);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(356, 46);
            this.lblAppName.TabIndex = 3;
            this.lblAppName.Text = "FA 智能綫速獲取系統";
            // 
            // picWistronLogo
            // 
            this.picWistronLogo.Image = ((System.Drawing.Image)(resources.GetObject("picWistronLogo.Image")));
            this.picWistronLogo.Location = new System.Drawing.Point(82, 12);
            this.picWistronLogo.Name = "picWistronLogo";
            this.picWistronLogo.Size = new System.Drawing.Size(187, 35);
            this.picWistronLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWistronLogo.TabIndex = 2;
            this.picWistronLogo.TabStop = false;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabRun);
            this.tabMain.Location = new System.Drawing.Point(12, 58);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(764, 564);
            this.tabMain.TabIndex = 10;
            // 
            // tabRun
            // 
            this.tabRun.Controls.Add(this.btnStop);
            this.tabRun.Controls.Add(this.btnStart);
            this.tabRun.Controls.Add(this.groupBox1);
            this.tabRun.Controls.Add(this.richMessage);
            this.tabRun.Controls.Add(this.lstPLCInfo);
            this.tabRun.Location = new System.Drawing.Point(4, 22);
            this.tabRun.Name = "tabRun";
            this.tabRun.Padding = new System.Windows.Forms.Padding(3);
            this.tabRun.Size = new System.Drawing.Size(756, 538);
            this.tabRun.TabIndex = 0;
            this.tabRun.Text = "運行";
            this.tabRun.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(642, 63);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(105, 39);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(642, 18);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(105, 39);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInfo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtInterval);
            this.groupBox1.Controls.Add(this.lblUploadInterval);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.cbPLCModel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbLine);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbPLCIP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtWebService);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 112);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.Silver;
            this.txtInfo.ForeColor = System.Drawing.Color.Blue;
            this.txtInfo.Location = new System.Drawing.Point(208, 81);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(410, 22);
            this.txtInfo.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "Min";
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(107, 80);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(51, 22);
            this.txtInterval.TabIndex = 12;
            this.txtInterval.TextChanged += new System.EventHandler(this.txtInterval_TextChanged);
            // 
            // lblUploadInterval
            // 
            this.lblUploadInterval.AutoSize = true;
            this.lblUploadInterval.Location = new System.Drawing.Point(6, 84);
            this.lblUploadInterval.Name = "lblUploadInterval";
            this.lblUploadInterval.Size = new System.Drawing.Size(95, 14);
            this.lblUploadInterval.TabIndex = 11;
            this.lblUploadInterval.Text = "Upload Interval:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(560, 50);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 24);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(504, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(448, 51);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbPLCModel
            // 
            this.cbPLCModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPLCModel.FormattingEnabled = true;
            this.cbPLCModel.Items.AddRange(new object[] {
            "Q03UDE",
            "Q03UDV",
            "FX5U"});
            this.cbPLCModel.Location = new System.Drawing.Point(363, 50);
            this.cbPLCModel.Name = "cbPLCModel";
            this.cbPLCModel.Size = new System.Drawing.Size(79, 22);
            this.cbPLCModel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "PLC Model:";
            // 
            // cbLine
            // 
            this.cbLine.FormattingEnabled = true;
            this.cbLine.Location = new System.Drawing.Point(205, 50);
            this.cbLine.Name = "cbLine";
            this.cbLine.Size = new System.Drawing.Size(79, 22);
            this.cbLine.TabIndex = 5;
            this.cbLine.SelectedIndexChanged += new System.EventHandler(this.cbLine_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Line:";
            // 
            // cbPLCIP
            // 
            this.cbPLCIP.FormattingEnabled = true;
            this.cbPLCIP.Location = new System.Drawing.Point(52, 49);
            this.cbPLCIP.Name = "cbPLCIP";
            this.cbPLCIP.Size = new System.Drawing.Size(106, 22);
            this.cbPLCIP.TabIndex = 3;
            this.cbPLCIP.SelectedIndexChanged += new System.EventHandler(this.cbPLCIP_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "PLC IP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "WebService:";
            // 
            // txtWebService
            // 
            this.txtWebService.Location = new System.Drawing.Point(85, 21);
            this.txtWebService.Name = "txtWebService";
            this.txtWebService.Size = new System.Drawing.Size(533, 22);
            this.txtWebService.TabIndex = 0;
            this.txtWebService.TextChanged += new System.EventHandler(this.txtWebService_TextChanged);
            // 
            // richMessage
            // 
            this.richMessage.Location = new System.Drawing.Point(301, 124);
            this.richMessage.Name = "richMessage";
            this.richMessage.Size = new System.Drawing.Size(446, 408);
            this.richMessage.TabIndex = 1;
            this.richMessage.Text = "";
            // 
            // lstPLCInfo
            // 
            this.lstPLCInfo.Location = new System.Drawing.Point(0, 124);
            this.lstPLCInfo.Name = "lstPLCInfo";
            this.lstPLCInfo.Size = new System.Drawing.Size(295, 408);
            this.lstPLCInfo.TabIndex = 0;
            this.lstPLCInfo.UseCompatibleStateImageBehavior = false;
            // 
            // axActPLC
            // 
            this.axActPLC.Enabled = true;
            this.axActPLC.Location = new System.Drawing.Point(687, 23);
            this.axActPLC.Name = "axActPLC";
            this.axActPLC.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axActPLC.OcxState")));
            this.axActPLC.Size = new System.Drawing.Size(32, 32);
            this.axActPLC.TabIndex = 11;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 647);
            this.Controls.Add(this.axActPLC);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.picWistronLogo);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWistronLogo)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabRun.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axActPLC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.PictureBox picWistronLogo;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabRun;
        private System.Windows.Forms.RichTextBox richMessage;
        private System.Windows.Forms.ListView lstPLCInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWebService;
        private System.Windows.Forms.ComboBox cbPLCIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPLCModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblUploadInterval;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private AxActProgTypeLib.AxActProgType axActPLC;
    }
}

