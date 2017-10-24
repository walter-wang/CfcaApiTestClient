// ***********************************************************************
// Assembly         : CfcaApiTestClient
// Author           : Walter Wang
// Created          : 2017-10-23
//
// Last Modified By : Walter Wang
// Last Modified On : 2017-10-24
// ***********************************************************************
// <copyright file="MainForm.cs" company="">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CfcaApiTestClient
{
    /// <summary>
    /// Class MainForm.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm" /> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            Initialize();
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public void Initialize()
        {
            PrivateAESKey.Text = CFCAAPI.Default.PrivateAESKey;
            PrivateAESKeyTime.Text = CFCAAPI.Default.PrivateAESKeyTime;
            FixedAESKey.Text = CFCAAPI.Default.FixedAESKey;
            FixedAESIV.Text = CFCAAPI.Default.FixedAESIV;
            APIUrl.Text = CFCAAPI.Default.APIUrl;
            UserAccount.Text = CFCAAPI.Default.UserAccount;

            
        }

        /// <summary>
        /// Saves the private aes key BTN click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void SavePrivateAESKeyBtn_Click(object sender, EventArgs e)
        {
            CFCAAPI.Default.PrivateAESKey = PrivateAESKey.Text;
            CFCAAPI.Default.PrivateAESKeyTime = PrivateAESKeyTime.Text;
            CFCAAPI.Default.Save();
        }

        /// <summary>
        /// Handles the Click event of the SaveSettingBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void SaveSettingBtn_Click(object sender, EventArgs e)
        {
            CFCAAPI.Default.FixedAESKey = FixedAESKey.Text;
            CFCAAPI.Default.FixedAESIV = FixedAESIV.Text;
            CFCAAPI.Default.APIUrl = APIUrl.Text;
            CFCAAPI.Default.UserAccount = UserAccount.Text;

            CFCAAPI.Default.Save();

        }

        /// <summary>
        /// Decrypts the key BTN click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void DecryptKeyBtn_Click(object sender, EventArgs e)
        {
            DecryptKeyLog.Text = string.Empty;
            DecryptedKey.Text = string.Empty;

            if (string.IsNullOrEmpty(EncryptedKey.Text))
            {
                DecryptKeyLog.Text += "The encrypted key message is null." + Environment.NewLine;
                return;
            }

            DecryptKeyLog.Text += "Start to process Key: " + EncryptedKey.Text + Environment.NewLine;

            DecryptKeyLog.Text += "Convert the encrypted key from Base64 string to byte arry." + Environment.NewLine;

            byte[] encryptedKeyMessage = null;
            try
            {
                encryptedKeyMessage = Convert.FromBase64String(EncryptedKey.Text);
            }
            catch (FormatException)
            {
                DecryptKeyLog.Text += "Not a Base64 string." + Environment.NewLine;
                return;
            }


            DecryptKeyLog.Text += "Decrpyt key base on fixed AES kay and fixed AES IV." + Environment.NewLine;
            DecryptedKey.Text = AESHelper.DecryptStringFromBytes_Aes(encryptedKeyMessage, CFCAAPI.Default.FixedAESKey, CFCAAPI.Default.FixedAESIV);

            DecryptKeyLog.Text += "Decrpyt complete." + Environment.NewLine;
        }

        /// <summary>
        /// Handles the Click event of the GenerateMessageBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void GenerateMessageBtn_Click(object sender, EventArgs e)
        {
            GetNewPrivateKeyLog.Text = string.Empty;
            APIMessage.Text = string.Empty;

            string dataMessage = generateMessageHeader("CF00000001");

            dataMessage = dataMessage +
                ",\"body\":{\"keyType\":\"0\",\"validationTime\":\"2\",\"lastKeyGenTime\":\"" +
                CFCAAPI.Default.PrivateAESKeyTime + 
                "\",\"lastKey\":\"" + 
                CFCAAPI.Default.PrivateAESKey + 
                "\"}";

            GetNewPrivateKeyLog.Text += "Generate data message:" + Environment.NewLine;
            GetNewPrivateKeyLog.Text += dataMessage + Environment.NewLine;

            string sha256Hash = SHA256Helper.GetSHA256HashFromString(dataMessage);

            GetNewPrivateKeyLog.Text += "Get SHA256 hash key:" + Environment.NewLine;
            GetNewPrivateKeyLog.Text += sha256Hash + Environment.NewLine;

            APIMessage.Text = "{" + dataMessage + ",\"hashValue\":\"" + sha256Hash + "\"}";

            GetNewPrivateKeyLog.Text += Environment.NewLine;
            GetNewPrivateKeyLog.Text += "The final API message:" + Environment.NewLine;
            GetNewPrivateKeyLog.Text += APIMessage.Text;

        }

        /// <summary>
        /// Generates the message header.
        /// </summary>
        /// <param name="transactionCode">The transaction code.</param>
        /// <returns>System.String.</returns>
        private static string generateMessageHeader(string transactionCode)
        {
            string uuid = Guid.NewGuid().ToString("N");

            StringBuilder dataMessageBuilder = new StringBuilder();

            dataMessageBuilder.Append("\"head\":{\"chanel\":\"0\",\"transactionCode\":\"");
            dataMessageBuilder.Append(transactionCode);
            dataMessageBuilder.Append("\",\"userAccountID\":\"");

            dataMessageBuilder.Append(CFCAAPI.Default.UserAccount);
            dataMessageBuilder.Append("\",\"action\":\"0\",\"authorizationID\":\"11111111\",\"transactionID\":\"");
            dataMessageBuilder.Append(CFCAAPI.Default.UserAccount);
            dataMessageBuilder.Append(uuid);
            dataMessageBuilder.Append("\"}");

            string dataMessage = dataMessageBuilder.ToString();
            dataMessageBuilder.Clear();

            return dataMessage;
        }

        /// <summary>
        /// Handles the Click event of the GenerateBankCardMessageBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void GenerateBankCardMessageBtn_Click(object sender, EventArgs e)
        {
            BankCardValidationLog.Text = string.Empty;
            BankCardValidationAPIMessage.Text = string.Empty;

            string messageHeader = generateMessageHeader("CF207b0004");

            BankCardValidationLog.Text += "Generate Message Header:" + Environment.NewLine;
            BankCardValidationLog.Text += messageHeader + Environment.NewLine;

            string messageBody = "{\"personName\":\"" +
                UserName.Text +
                "\",\"identityType\":\"" +
                CertificateType.Text +
                "\",\"identityNumber\":\"" +
                CertificateNumber.Text +
                "\",\"cardType\":\"" +
                CardTypes.Text +
                "\",\"cardNumber\":\"" +
                CardNumber.Text +
                "\"}";

            BankCardValidationLog.Text += "Generate Message Body:" + Environment.NewLine;
            BankCardValidationLog.Text += messageBody + Environment.NewLine;

            string encryptedMessageBody = AESHelper.EncryptStringToBase64_Aes(messageBody, CFCAAPI.Default.PrivateAESKey, CFCAAPI.Default.FixedAESIV);
            
            BankCardValidationLog.Text += "Encrypt Message Body:" + Environment.NewLine;
            BankCardValidationLog.Text += encryptedMessageBody + Environment.NewLine;

            string dataMessage = messageHeader + ",\"body\":\"" + encryptedMessageBody + "\"";
            BankCardValidationLog.Text += "Message is:" + Environment.NewLine;
            BankCardValidationLog.Text += dataMessage + Environment.NewLine;

            string sha256Hash = SHA256Helper.GetSHA256HashFromString(dataMessage);

            BankCardValidationLog.Text += "Get SHA256 hash key:" + Environment.NewLine;
            BankCardValidationLog.Text += sha256Hash + Environment.NewLine;

            BankCardValidationAPIMessage.Text = "{" + dataMessage + ",\"hashValue\":\"" + sha256Hash + "\"}";

            BankCardValidationLog.Text += Environment.NewLine;
            BankCardValidationLog.Text += "The final API message:" + Environment.NewLine;
            BankCardValidationLog.Text += BankCardValidationAPIMessage.Text;
        }

        private void DecryptValidationResultBtn_Click(object sender, EventArgs e)
        {
            DecryptedValidationResult.Text = string.Empty;

            byte[] encryptedValidationResultArry = null;
            try
            {
                encryptedValidationResultArry = Convert.FromBase64String(EncryptedValidationResult.Text);
            }
            catch (FormatException)
            {
                return;
            }

            DecryptedValidationResult.Text = AESHelper.DecryptStringFromBytes_Aes(encryptedValidationResultArry, CFCAAPI.Default.PrivateAESKey, CFCAAPI.Default.FixedAESIV);
        }
    }
}
