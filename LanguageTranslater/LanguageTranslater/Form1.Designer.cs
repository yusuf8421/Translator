namespace LanguageTranslater
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
            this.txtSrc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnAc = new System.Windows.Forms.Button();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.comboAvailableLangs = new System.Windows.Forms.ComboBox();
            this.txtDestLang = new System.Windows.Forms.TextBox();
            this.lblSrcLang = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CmbSpeakers = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.CmbSpeakers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSrc
            // 
            this.txtSrc.Location = new System.Drawing.Point(12, 12);
            this.txtSrc.Multiline = true;
            this.txtSrc.Name = "txtSrc";
            this.txtSrc.Size = new System.Drawing.Size(260, 105);
            this.txtSrc.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dili Algıla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnAc
            // 
            this.BtnAc.Location = new System.Drawing.Point(13, 154);
            this.BtnAc.Name = "BtnAc";
            this.BtnAc.Size = new System.Drawing.Size(125, 23);
            this.BtnAc.TabIndex = 2;
            this.BtnAc.Text = "Dilleri Getir";
            this.BtnAc.UseVisualStyleBackColor = true;
            this.BtnAc.Click += new System.EventHandler(this.BtnAc_Click);
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(145, 153);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(127, 23);
            this.btnTranslate.TabIndex = 3;
            this.btnTranslate.Text = "Çevir";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // comboAvailableLangs
            // 
            this.comboAvailableLangs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboAvailableLangs.FormattingEnabled = true;
            this.comboAvailableLangs.Location = new System.Drawing.Point(12, 184);
            this.comboAvailableLangs.Name = "comboAvailableLangs";
            this.comboAvailableLangs.Size = new System.Drawing.Size(260, 21);
            this.comboAvailableLangs.TabIndex = 4;
            // 
            // txtDestLang
            // 
            this.txtDestLang.Location = new System.Drawing.Point(13, 212);
            this.txtDestLang.Multiline = true;
            this.txtDestLang.Name = "txtDestLang";
            this.txtDestLang.Size = new System.Drawing.Size(259, 85);
            this.txtDestLang.TabIndex = 5;
            // 
            // lblSrcLang
            // 
            this.lblSrcLang.AutoSize = true;
            this.lblSrcLang.Location = new System.Drawing.Point(12, 304);
            this.lblSrcLang.Name = "lblSrcLang";
            this.lblSrcLang.Size = new System.Drawing.Size(0, 13);
            this.lblSrcLang.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CmbSpeakers
            // 
            this.CmbSpeakers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CmbSpeakers.Location = new System.Drawing.Point(39, 304);
            this.CmbSpeakers.Name = "CmbSpeakers";
            this.CmbSpeakers.Size = new System.Drawing.Size(228, 20);
            this.CmbSpeakers.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 471);
            this.Controls.Add(this.CmbSpeakers);
            this.Controls.Add(this.lblSrcLang);
            this.Controls.Add(this.txtDestLang);
            this.Controls.Add(this.comboAvailableLangs);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.BtnAc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSrc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CmbSpeakers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSrc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnAc;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.ComboBox comboAvailableLangs;
        private System.Windows.Forms.TextBox txtDestLang;
        private System.Windows.Forms.Label lblSrcLang;
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.UI.RadDropDownList CmbSpeakers;
    }
}

