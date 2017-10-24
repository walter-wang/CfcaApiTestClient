namespace CfcaApiTestClient
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TopPanel = new System.Windows.Forms.Panel();
            this.SavePrivateAESKeyBtn = new System.Windows.Forms.Button();
            this.PrivateAESKeyTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PrivateAESKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SaveSettingBtn = new System.Windows.Forms.Button();
            this.FixedAESIV = new System.Windows.Forms.TextBox();
            this.FixedAESKey = new System.Windows.Forms.TextBox();
            this.APIUrl = new System.Windows.Forms.TextBox();
            this.UserAccount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.APIMessage = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GenerateMessageBtn = new System.Windows.Forms.Button();
            this.GetNewPrivateKeyLog = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DecryptKeyLog = new System.Windows.Forms.TextBox();
            this.DecryptedKey = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DecryptKeyBtn = new System.Windows.Forms.Button();
            this.EncryptedKey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.CardNumber = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.CardTypes = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CertificateType = new System.Windows.Forms.TextBox();
            this.CertificateNumber = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.BankCardValidationAPIMessage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GenerateBankCardMessageBtn = new System.Windows.Forms.Button();
            this.BankCardValidationLog = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.DecryptedValidationResult = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DecryptValidationResultBtn = new System.Windows.Forms.Button();
            this.EncryptedValidationResult = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.ValidDate = new System.Windows.Forms.TextBox();
            this.CVN2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ThreeParamatersRadioBtn = new System.Windows.Forms.RadioButton();
            this.FourParamatersRadioBtn = new System.Windows.Forms.RadioButton();
            this.CellPhoneNumber = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.AutoSize = true;
            this.TopPanel.Controls.Add(this.SavePrivateAESKeyBtn);
            this.TopPanel.Controls.Add(this.PrivateAESKeyTime);
            this.TopPanel.Controls.Add(this.label2);
            this.TopPanel.Controls.Add(this.PrivateAESKey);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1039, 31);
            this.TopPanel.TabIndex = 0;
            // 
            // SavePrivateAESKeyBtn
            // 
            this.SavePrivateAESKeyBtn.Location = new System.Drawing.Point(833, 3);
            this.SavePrivateAESKeyBtn.Name = "SavePrivateAESKeyBtn";
            this.SavePrivateAESKeyBtn.Size = new System.Drawing.Size(118, 23);
            this.SavePrivateAESKeyBtn.TabIndex = 4;
            this.SavePrivateAESKeyBtn.Text = "Save Key";
            this.SavePrivateAESKeyBtn.UseVisualStyleBackColor = true;
            this.SavePrivateAESKeyBtn.Click += new System.EventHandler(this.SavePrivateAESKeyBtn_Click);
            // 
            // PrivateAESKeyTime
            // 
            this.PrivateAESKeyTime.Location = new System.Drawing.Point(475, 4);
            this.PrivateAESKeyTime.Name = "PrivateAESKeyTime";
            this.PrivateAESKeyTime.Size = new System.Drawing.Size(278, 24);
            this.PrivateAESKeyTime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Key Date:";
            // 
            // PrivateAESKey
            // 
            this.PrivateAESKey.Location = new System.Drawing.Point(89, 4);
            this.PrivateAESKey.Name = "PrivateAESKey";
            this.PrivateAESKey.Size = new System.Drawing.Size(278, 24);
            this.PrivateAESKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "AES Key:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1039, 510);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SaveSettingBtn);
            this.tabPage1.Controls.Add(this.FixedAESIV);
            this.tabPage1.Controls.Add(this.FixedAESKey);
            this.tabPage1.Controls.Add(this.APIUrl);
            this.tabPage1.Controls.Add(this.UserAccount);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1031, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CFCA Setting";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SaveSettingBtn
            // 
            this.SaveSettingBtn.Location = new System.Drawing.Point(829, 345);
            this.SaveSettingBtn.Name = "SaveSettingBtn";
            this.SaveSettingBtn.Size = new System.Drawing.Size(118, 23);
            this.SaveSettingBtn.TabIndex = 8;
            this.SaveSettingBtn.Text = "Save Setting";
            this.SaveSettingBtn.UseVisualStyleBackColor = true;
            this.SaveSettingBtn.Click += new System.EventHandler(this.SaveSettingBtn_Click);
            // 
            // FixedAESIV
            // 
            this.FixedAESIV.Location = new System.Drawing.Point(138, 120);
            this.FixedAESIV.Name = "FixedAESIV";
            this.FixedAESIV.Size = new System.Drawing.Size(776, 24);
            this.FixedAESIV.TabIndex = 7;
            // 
            // FixedAESKey
            // 
            this.FixedAESKey.Location = new System.Drawing.Point(138, 84);
            this.FixedAESKey.Name = "FixedAESKey";
            this.FixedAESKey.Size = new System.Drawing.Size(776, 24);
            this.FixedAESKey.TabIndex = 6;
            // 
            // APIUrl
            // 
            this.APIUrl.Location = new System.Drawing.Point(138, 48);
            this.APIUrl.Name = "APIUrl";
            this.APIUrl.Size = new System.Drawing.Size(776, 24);
            this.APIUrl.TabIndex = 5;
            // 
            // UserAccount
            // 
            this.UserAccount.Location = new System.Drawing.Point(138, 12);
            this.UserAccount.Name = "UserAccount";
            this.UserAccount.Size = new System.Drawing.Size(776, 24);
            this.UserAccount.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fixed AES IV:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fixed AES Key:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "API Url:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "User Account:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.APIMessage);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.GenerateMessageBtn);
            this.tabPage2.Controls.Add(this.GetNewPrivateKeyLog);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1031, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Get New Private AES Key";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // APIMessage
            // 
            this.APIMessage.Location = new System.Drawing.Point(139, 35);
            this.APIMessage.Multiline = true;
            this.APIMessage.Name = "APIMessage";
            this.APIMessage.ReadOnly = true;
            this.APIMessage.Size = new System.Drawing.Size(884, 99);
            this.APIMessage.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "API Message:";
            // 
            // GenerateMessageBtn
            // 
            this.GenerateMessageBtn.Location = new System.Drawing.Point(868, 6);
            this.GenerateMessageBtn.Name = "GenerateMessageBtn";
            this.GenerateMessageBtn.Size = new System.Drawing.Size(155, 23);
            this.GenerateMessageBtn.TabIndex = 13;
            this.GenerateMessageBtn.Text = "Generate Message";
            this.GenerateMessageBtn.UseVisualStyleBackColor = true;
            this.GenerateMessageBtn.Click += new System.EventHandler(this.GenerateMessageBtn_Click);
            // 
            // GetNewPrivateKeyLog
            // 
            this.GetNewPrivateKeyLog.Location = new System.Drawing.Point(11, 140);
            this.GetNewPrivateKeyLog.Multiline = true;
            this.GetNewPrivateKeyLog.Name = "GetNewPrivateKeyLog";
            this.GetNewPrivateKeyLog.ReadOnly = true;
            this.GetNewPrivateKeyLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GetNewPrivateKeyLog.Size = new System.Drawing.Size(1012, 333);
            this.GetNewPrivateKeyLog.TabIndex = 12;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DecryptKeyLog);
            this.tabPage3.Controls.Add(this.DecryptedKey);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.DecryptKeyBtn);
            this.tabPage3.Controls.Add(this.EncryptedKey);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1031, 481);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Decrypt Key";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DecryptKeyLog
            // 
            this.DecryptKeyLog.Location = new System.Drawing.Point(11, 108);
            this.DecryptKeyLog.Multiline = true;
            this.DecryptKeyLog.Name = "DecryptKeyLog";
            this.DecryptKeyLog.ReadOnly = true;
            this.DecryptKeyLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DecryptKeyLog.Size = new System.Drawing.Size(1012, 365);
            this.DecryptKeyLog.TabIndex = 9;
            // 
            // DecryptedKey
            // 
            this.DecryptedKey.Location = new System.Drawing.Point(197, 59);
            this.DecryptedKey.Name = "DecryptedKey";
            this.DecryptedKey.ReadOnly = true;
            this.DecryptedKey.Size = new System.Drawing.Size(431, 24);
            this.DecryptedKey.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Decrypted Key:";
            // 
            // DecryptKeyBtn
            // 
            this.DecryptKeyBtn.Location = new System.Drawing.Point(713, 11);
            this.DecryptKeyBtn.Name = "DecryptKeyBtn";
            this.DecryptKeyBtn.Size = new System.Drawing.Size(128, 23);
            this.DecryptKeyBtn.TabIndex = 6;
            this.DecryptKeyBtn.Text = "Decrypt Key";
            this.DecryptKeyBtn.UseVisualStyleBackColor = true;
            this.DecryptKeyBtn.Click += new System.EventHandler(this.DecryptKeyBtn_Click);
            // 
            // EncryptedKey
            // 
            this.EncryptedKey.Location = new System.Drawing.Point(197, 12);
            this.EncryptedKey.Name = "EncryptedKey";
            this.EncryptedKey.Size = new System.Drawing.Size(431, 24);
            this.EncryptedKey.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Encrypted Key Message:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.CellPhoneNumber);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.FourParamatersRadioBtn);
            this.tabPage4.Controls.Add(this.ThreeParamatersRadioBtn);
            this.tabPage4.Controls.Add(this.CVN2);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.ValidDate);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.CardNumber);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.CardTypes);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.CertificateType);
            this.tabPage4.Controls.Add(this.CertificateNumber);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.BankCardValidationAPIMessage);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.GenerateBankCardMessageBtn);
            this.tabPage4.Controls.Add(this.BankCardValidationLog);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.UserName);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1031, 481);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Bank Card Validation";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // CardNumber
            // 
            this.CardNumber.Location = new System.Drawing.Point(487, 120);
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.Size = new System.Drawing.Size(317, 24);
            this.CardNumber.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(378, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 15);
            this.label17.TabIndex = 23;
            this.label17.Text = "Card Number:";
            // 
            // CardTypes
            // 
            this.CardTypes.FormattingEnabled = true;
            this.CardTypes.Items.AddRange(new object[] {
            "10",
            "20"});
            this.CardTypes.Location = new System.Drawing.Point(101, 118);
            this.CardTypes.Name = "CardTypes";
            this.CardTypes.Size = new System.Drawing.Size(221, 23);
            this.CardTypes.TabIndex = 22;
            this.CardTypes.SelectedValueChanged += new System.EventHandler(this.CardTypes_SelectedValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 15);
            this.label16.TabIndex = 21;
            this.label16.Text = "Card Type:";
            // 
            // CertificateType
            // 
            this.CertificateType.Location = new System.Drawing.Point(180, 52);
            this.CertificateType.Name = "CertificateType";
            this.CertificateType.Size = new System.Drawing.Size(319, 24);
            this.CertificateType.TabIndex = 20;
            // 
            // CertificateNumber
            // 
            this.CertificateNumber.Location = new System.Drawing.Point(180, 88);
            this.CertificateNumber.Name = "CertificateNumber";
            this.CertificateNumber.Size = new System.Drawing.Size(624, 24);
            this.CertificateNumber.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 15);
            this.label15.TabIndex = 18;
            this.label15.Text = "Certificate Number：";
            // 
            // BankCardValidationAPIMessage
            // 
            this.BankCardValidationAPIMessage.Location = new System.Drawing.Point(141, 211);
            this.BankCardValidationAPIMessage.Multiline = true;
            this.BankCardValidationAPIMessage.Name = "BankCardValidationAPIMessage";
            this.BankCardValidationAPIMessage.ReadOnly = true;
            this.BankCardValidationAPIMessage.Size = new System.Drawing.Size(884, 99);
            this.BankCardValidationAPIMessage.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "API Message:";
            // 
            // GenerateBankCardMessageBtn
            // 
            this.GenerateBankCardMessageBtn.Location = new System.Drawing.Point(859, 60);
            this.GenerateBankCardMessageBtn.Name = "GenerateBankCardMessageBtn";
            this.GenerateBankCardMessageBtn.Size = new System.Drawing.Size(164, 23);
            this.GenerateBankCardMessageBtn.TabIndex = 14;
            this.GenerateBankCardMessageBtn.Text = "Generate Message";
            this.GenerateBankCardMessageBtn.UseVisualStyleBackColor = true;
            this.GenerateBankCardMessageBtn.Click += new System.EventHandler(this.GenerateBankCardMessageBtn_Click);
            // 
            // BankCardValidationLog
            // 
            this.BankCardValidationLog.Location = new System.Drawing.Point(13, 316);
            this.BankCardValidationLog.Multiline = true;
            this.BankCardValidationLog.Name = "BankCardValidationLog";
            this.BankCardValidationLog.ReadOnly = true;
            this.BankCardValidationLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BankCardValidationLog.Size = new System.Drawing.Size(1012, 157);
            this.BankCardValidationLog.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "Certificate Type：";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(61, 10);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(319, 24);
            this.UserName.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Name:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.DecryptedValidationResult);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.DecryptValidationResultBtn);
            this.tabPage5.Controls.Add(this.EncryptedValidationResult);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1031, 481);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Decrypt Validation Result";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // DecryptedValidationResult
            // 
            this.DecryptedValidationResult.Location = new System.Drawing.Point(245, 74);
            this.DecryptedValidationResult.Multiline = true;
            this.DecryptedValidationResult.Name = "DecryptedValidationResult";
            this.DecryptedValidationResult.ReadOnly = true;
            this.DecryptedValidationResult.Size = new System.Drawing.Size(644, 128);
            this.DecryptedValidationResult.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(231, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "Decrypted Valication Result:";
            // 
            // DecryptValidationResultBtn
            // 
            this.DecryptValidationResultBtn.Location = new System.Drawing.Point(895, 13);
            this.DecryptValidationResultBtn.Name = "DecryptValidationResultBtn";
            this.DecryptValidationResultBtn.Size = new System.Drawing.Size(128, 55);
            this.DecryptValidationResultBtn.TabIndex = 12;
            this.DecryptValidationResultBtn.Text = "Decrypt Validation Relsult";
            this.DecryptValidationResultBtn.UseVisualStyleBackColor = true;
            this.DecryptValidationResultBtn.Click += new System.EventHandler(this.DecryptValidationResultBtn_Click);
            // 
            // EncryptedValidationResult
            // 
            this.EncryptedValidationResult.Location = new System.Drawing.Point(245, 10);
            this.EncryptedValidationResult.Multiline = true;
            this.EncryptedValidationResult.Name = "EncryptedValidationResult";
            this.EncryptedValidationResult.Size = new System.Drawing.Size(644, 58);
            this.EncryptedValidationResult.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(231, 15);
            this.label14.TabIndex = 10;
            this.label14.Text = "Encrypted Validation Result:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 152);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 15);
            this.label18.TabIndex = 25;
            this.label18.Text = "Valid Date:";
            // 
            // ValidDate
            // 
            this.ValidDate.Location = new System.Drawing.Point(109, 149);
            this.ValidDate.Name = "ValidDate";
            this.ValidDate.Size = new System.Drawing.Size(213, 24);
            this.ValidDate.TabIndex = 26;
            this.ValidDate.Visible = false;
            // 
            // CVN2
            // 
            this.CVN2.Location = new System.Drawing.Point(487, 149);
            this.CVN2.Name = "CVN2";
            this.CVN2.Size = new System.Drawing.Size(213, 24);
            this.CVN2.TabIndex = 28;
            this.CVN2.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(386, 152);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 15);
            this.label19.TabIndex = 27;
            this.label19.Text = "CVN2:";
            // 
            // ThreeParamatersRadioBtn
            // 
            this.ThreeParamatersRadioBtn.AutoSize = true;
            this.ThreeParamatersRadioBtn.Checked = true;
            this.ThreeParamatersRadioBtn.Location = new System.Drawing.Point(579, 10);
            this.ThreeParamatersRadioBtn.Name = "ThreeParamatersRadioBtn";
            this.ThreeParamatersRadioBtn.Size = new System.Drawing.Size(121, 19);
            this.ThreeParamatersRadioBtn.TabIndex = 29;
            this.ThreeParamatersRadioBtn.TabStop = true;
            this.ThreeParamatersRadioBtn.Text = "3 Paramaters";
            this.ThreeParamatersRadioBtn.UseVisualStyleBackColor = true;
            this.ThreeParamatersRadioBtn.CheckedChanged += new System.EventHandler(this.ThreeParamatersRadioBtn_CheckedChanged);
            // 
            // FourParamatersRadioBtn
            // 
            this.FourParamatersRadioBtn.AutoSize = true;
            this.FourParamatersRadioBtn.Location = new System.Drawing.Point(706, 9);
            this.FourParamatersRadioBtn.Name = "FourParamatersRadioBtn";
            this.FourParamatersRadioBtn.Size = new System.Drawing.Size(121, 19);
            this.FourParamatersRadioBtn.TabIndex = 30;
            this.FourParamatersRadioBtn.Text = "4 Paramaters";
            this.FourParamatersRadioBtn.UseVisualStyleBackColor = true;
            this.FourParamatersRadioBtn.CheckedChanged += new System.EventHandler(this.FourParamatersRadioBtn_CheckedChanged);
            // 
            // CellPhoneNumber
            // 
            this.CellPhoneNumber.Location = new System.Drawing.Point(165, 181);
            this.CellPhoneNumber.Name = "CellPhoneNumber";
            this.CellPhoneNumber.Size = new System.Drawing.Size(535, 24);
            this.CellPhoneNumber.TabIndex = 32;
            this.CellPhoneNumber.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 184);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(151, 15);
            this.label20.TabIndex = 31;
            this.label20.Text = "Cell Phone Number:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 541);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CFCA API Test Client";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.TextBox PrivateAESKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrivateAESKeyTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SavePrivateAESKeyBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox UserAccount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button SaveSettingBtn;
        private System.Windows.Forms.TextBox FixedAESIV;
        private System.Windows.Forms.TextBox FixedAESKey;
        private System.Windows.Forms.TextBox APIUrl;
        private System.Windows.Forms.TextBox DecryptedKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button DecryptKeyBtn;
        private System.Windows.Forms.TextBox EncryptedKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DecryptKeyLog;
        private System.Windows.Forms.TextBox GetNewPrivateKeyLog;
        private System.Windows.Forms.Button GenerateMessageBtn;
        private System.Windows.Forms.TextBox APIMessage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button GenerateBankCardMessageBtn;
        private System.Windows.Forms.TextBox BankCardValidationLog;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox BankCardValidationAPIMessage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox DecryptedValidationResult;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button DecryptValidationResultBtn;
        private System.Windows.Forms.TextBox EncryptedValidationResult;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox CertificateNumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox CertificateType;
        private System.Windows.Forms.ComboBox CardTypes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox CardNumber;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox ValidDate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox CVN2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton FourParamatersRadioBtn;
        private System.Windows.Forms.RadioButton ThreeParamatersRadioBtn;
        private System.Windows.Forms.TextBox CellPhoneNumber;
        private System.Windows.Forms.Label label20;
    }
}

