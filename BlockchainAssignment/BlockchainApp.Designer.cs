namespace BlockchainAssignment
{
    partial class BlockchainApp
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.publicKey = new System.Windows.Forms.TextBox();
            this.privateKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.createTransaction = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fee = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.receiver = new System.Windows.Forms.Label();
            this.receiverKey = new System.Windows.Forms.TextBox();
            this.newBlock = new System.Windows.Forms.Button();
            this.validateChain = new System.Windows.Forms.Button();
            this.checkBalance = new System.Windows.Forms.Button();
            this.readAll = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(30, 27);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1637, 720);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 765);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 78);
            this.button1.TabIndex = 1;
            this.button1.Text = "Print Block";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 784);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 42);
            this.textBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1497, 784);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 99);
            this.button2.TabIndex = 3;
            this.button2.Text = "Generate Wallet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // publicKey
            // 
            this.publicKey.Location = new System.Drawing.Point(918, 784);
            this.publicKey.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.publicKey.Name = "publicKey";
            this.publicKey.Size = new System.Drawing.Size(566, 42);
            this.publicKey.TabIndex = 4;
            // 
            // privateKey
            // 
            this.privateKey.Location = new System.Drawing.Point(922, 844);
            this.privateKey.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.privateKey.Name = "privateKey";
            this.privateKey.Size = new System.Drawing.Size(562, 42);
            this.privateKey.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(745, 789);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Public Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(740, 847);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Private Key";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1448, 894);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 58);
            this.button3.TabIndex = 8;
            this.button3.Text = "Validate Keys";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // createTransaction
            // 
            this.createTransaction.Location = new System.Drawing.Point(30, 992);
            this.createTransaction.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.createTransaction.Name = "createTransaction";
            this.createTransaction.Size = new System.Drawing.Size(192, 100);
            this.createTransaction.TabIndex = 9;
            this.createTransaction.Text = "Create Transaction";
            this.createTransaction.UseVisualStyleBackColor = true;
            this.createTransaction.Click += new System.EventHandler(this.createTransaction_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 1058);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 999);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "Amount";
            // 
            // fee
            // 
            this.fee.Location = new System.Drawing.Point(395, 1053);
            this.fee.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.fee.Name = "fee";
            this.fee.Size = new System.Drawing.Size(99, 42);
            this.fee.TabIndex = 11;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(392, 993);
            this.amount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(102, 42);
            this.amount.TabIndex = 10;
            // 
            // receiver
            // 
            this.receiver.AutoSize = true;
            this.receiver.Location = new System.Drawing.Point(725, 1100);
            this.receiver.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.receiver.Name = "receiver";
            this.receiver.Size = new System.Drawing.Size(193, 30);
            this.receiver.TabIndex = 15;
            this.receiver.Text = "Receiver Key";
            // 
            // receiverKey
            // 
            this.receiverKey.Location = new System.Drawing.Point(922, 1095);
            this.receiverKey.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.receiverKey.Name = "receiverKey";
            this.receiverKey.Size = new System.Drawing.Size(566, 42);
            this.receiverKey.TabIndex = 14;
            // 
            // newBlock
            // 
            this.newBlock.Location = new System.Drawing.Point(30, 878);
            this.newBlock.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.newBlock.Name = "newBlock";
            this.newBlock.Size = new System.Drawing.Size(192, 92);
            this.newBlock.TabIndex = 16;
            this.newBlock.Text = "Generate New Block";
            this.newBlock.UseVisualStyleBackColor = true;
            this.newBlock.Click += new System.EventHandler(this.newBlock_Click);
            // 
            // validateChain
            // 
            this.validateChain.Location = new System.Drawing.Point(1448, 969);
            this.validateChain.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.validateChain.Name = "validateChain";
            this.validateChain.Size = new System.Drawing.Size(225, 79);
            this.validateChain.TabIndex = 17;
            this.validateChain.Text = "Validate Chain";
            this.validateChain.UseVisualStyleBackColor = true;
            this.validateChain.Click += new System.EventHandler(this.validateChain_Click);
            // 
            // checkBalance
            // 
            this.checkBalance.Location = new System.Drawing.Point(1193, 896);
            this.checkBalance.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.checkBalance.Name = "checkBalance";
            this.checkBalance.Size = new System.Drawing.Size(228, 56);
            this.checkBalance.TabIndex = 18;
            this.checkBalance.Text = "Check Balance";
            this.checkBalance.UseVisualStyleBackColor = true;
            this.checkBalance.Click += new System.EventHandler(this.checkBalancce_Click);
            // 
            // readAll
            // 
            this.readAll.Location = new System.Drawing.Point(429, 768);
            this.readAll.Name = "readAll";
            this.readAll.Size = new System.Drawing.Size(154, 72);
            this.readAll.TabIndex = 19;
            this.readAll.Text = "Read All";
            this.readAll.UseVisualStyleBackColor = true;
            this.readAll.Click += new System.EventHandler(this.readAll_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(369, 860);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(257, 110);
            this.button4.TabIndex = 20;
            this.button4.Text = "Reading Pending Transactions";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button5_Click);
            // 
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1715, 1198);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.readAll);
            this.Controls.Add(this.checkBalance);
            this.Controls.Add(this.validateChain);
            this.Controls.Add(this.newBlock);
            this.Controls.Add(this.receiver);
            this.Controls.Add(this.receiverKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fee);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.createTransaction);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.privateKey);
            this.Controls.Add(this.publicKey);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "BlockchainApp";
            this.Text = "Blockchain App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox publicKey;
        private System.Windows.Forms.TextBox privateKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button createTransaction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fee;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label receiver;
        private System.Windows.Forms.TextBox receiverKey;
        private System.Windows.Forms.Button newBlock;
        private System.Windows.Forms.Button validateChain;
        private System.Windows.Forms.Button checkBalance;
        private System.Windows.Forms.Button readAll;
        private System.Windows.Forms.Button button4;
    }
}

