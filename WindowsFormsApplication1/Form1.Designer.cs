namespace WindowsFormsApplication1
{
    partial class HttpTest
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
            this.AddParameter = new System.Windows.Forms.Button();
            this.URL = new System.Windows.Forms.TextBox();
            this.Parameters = new System.Windows.Forms.TableLayoutPanel();
            this.GETButton = new System.Windows.Forms.RadioButton();
            this.POSTButton = new System.Windows.Forms.RadioButton();
            this.PrivateFile = new System.Windows.Forms.TextBox();
            this.ChoosePrivateFile = new System.Windows.Forms.Button();
            this.openPrivateKey = new System.Windows.Forms.OpenFileDialog();
            this.Submit = new System.Windows.Forms.Button();
            this.URLLabel = new System.Windows.Forms.Label();
            this.ParametersTextBox = new System.Windows.Forms.TextBox();
            this.ClearParametersButton = new System.Windows.Forms.Button();
            this.ParameterTabControl = new System.Windows.Forms.TabControl();
            this.ParameterRawPage = new System.Windows.Forms.TabPage();
            this.ParameterFormPage = new System.Windows.Forms.TabPage();
            this.ParameterGroupBox = new System.Windows.Forms.GroupBox();
            this.ResponseGroupBox = new System.Windows.Forms.GroupBox();
            this.LoadingTime = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MethodGroupBox = new System.Windows.Forms.GroupBox();
            this.ParameterTabControl.SuspendLayout();
            this.ParameterRawPage.SuspendLayout();
            this.ParameterFormPage.SuspendLayout();
            this.ParameterGroupBox.SuspendLayout();
            this.ResponseGroupBox.SuspendLayout();
            this.MethodGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddParameter
            // 
            this.AddParameter.Location = new System.Drawing.Point(6, 6);
            this.AddParameter.Name = "AddParameter";
            this.AddParameter.Size = new System.Drawing.Size(162, 23);
            this.AddParameter.TabIndex = 0;
            this.AddParameter.Text = "Add Parameter";
            this.AddParameter.UseVisualStyleBackColor = true;
            this.AddParameter.Click += new System.EventHandler(this.button1_Click);
            // 
            // URL
            // 
            this.URL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.URL.Location = new System.Drawing.Point(53, 9);
            this.URL.Margin = new System.Windows.Forms.Padding(10);
            this.URL.Name = "URL";
            this.URL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.URL.Size = new System.Drawing.Size(941, 22);
            this.URL.TabIndex = 1;
            this.URL.TextChanged += new System.EventHandler(this.URL_TextChanged);
            // 
            // Parameters
            // 
            this.Parameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Parameters.AutoScroll = true;
            this.Parameters.ColumnCount = 3;
            this.Parameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Parameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Parameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Parameters.Location = new System.Drawing.Point(6, 35);
            this.Parameters.Name = "Parameters";
            this.Parameters.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Parameters.Size = new System.Drawing.Size(959, 385);
            this.Parameters.TabIndex = 2;
            // 
            // GETButton
            // 
            this.GETButton.AutoSize = true;
            this.GETButton.Checked = true;
            this.GETButton.Location = new System.Drawing.Point(6, 21);
            this.GETButton.Name = "GETButton";
            this.GETButton.Size = new System.Drawing.Size(58, 21);
            this.GETButton.TabIndex = 3;
            this.GETButton.TabStop = true;
            this.GETButton.Text = "GET";
            this.GETButton.UseVisualStyleBackColor = true;
            // 
            // POSTButton
            // 
            this.POSTButton.AutoSize = true;
            this.POSTButton.Location = new System.Drawing.Point(70, 21);
            this.POSTButton.Name = "POSTButton";
            this.POSTButton.Size = new System.Drawing.Size(67, 21);
            this.POSTButton.TabIndex = 4;
            this.POSTButton.Text = "POST";
            this.POSTButton.UseVisualStyleBackColor = true;
            // 
            // PrivateFile
            // 
            this.PrivateFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PrivateFile.Enabled = false;
            this.PrivateFile.Location = new System.Drawing.Point(308, 53);
            this.PrivateFile.Name = "PrivateFile";
            this.PrivateFile.ReadOnly = true;
            this.PrivateFile.Size = new System.Drawing.Size(686, 22);
            this.PrivateFile.TabIndex = 5;
            // 
            // ChoosePrivateFile
            // 
            this.ChoosePrivateFile.Location = new System.Drawing.Point(159, 51);
            this.ChoosePrivateFile.Name = "ChoosePrivateFile";
            this.ChoosePrivateFile.Size = new System.Drawing.Size(143, 23);
            this.ChoosePrivateFile.TabIndex = 6;
            this.ChoosePrivateFile.Text = "Choose Private Key";
            this.ChoosePrivateFile.UseVisualStyleBackColor = true;
            this.ChoosePrivateFile.Click += new System.EventHandler(this.ChoosePrivateFile_Click);
            // 
            // openPrivateKey
            // 
            this.openPrivateKey.FileName = "privateKey";
            // 
            // Submit
            // 
            this.Submit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Submit.Location = new System.Drawing.Point(12, 678);
            this.Submit.Margin = new System.Windows.Forms.Padding(20);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(982, 40);
            this.Submit.TabIndex = 7;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // URLLabel
            // 
            this.URLLabel.AutoEllipsis = true;
            this.URLLabel.AutoSize = true;
            this.URLLabel.Location = new System.Drawing.Point(12, 12);
            this.URLLabel.Name = "URLLabel";
            this.URLLabel.Size = new System.Drawing.Size(36, 17);
            this.URLLabel.TabIndex = 8;
            this.URLLabel.Text = "URL";
            // 
            // ParametersTextBox
            // 
            this.ParametersTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParametersTextBox.Location = new System.Drawing.Point(3, 3);
            this.ParametersTextBox.Multiline = true;
            this.ParametersTextBox.Name = "ParametersTextBox";
            this.ParametersTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ParametersTextBox.Size = new System.Drawing.Size(965, 402);
            this.ParametersTextBox.TabIndex = 10;
            // 
            // ClearParametersButton
            // 
            this.ClearParametersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearParametersButton.Location = new System.Drawing.Point(882, 6);
            this.ClearParametersButton.Name = "ClearParametersButton";
            this.ClearParametersButton.Size = new System.Drawing.Size(83, 23);
            this.ClearParametersButton.TabIndex = 12;
            this.ClearParametersButton.Text = "Delete All";
            this.ClearParametersButton.UseVisualStyleBackColor = true;
            this.ClearParametersButton.Click += new System.EventHandler(this.ClearParametersButton_Click);
            // 
            // ParameterTabControl
            // 
            this.ParameterTabControl.Controls.Add(this.ParameterRawPage);
            this.ParameterTabControl.Controls.Add(this.ParameterFormPage);
            this.ParameterTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParameterTabControl.Location = new System.Drawing.Point(3, 18);
            this.ParameterTabControl.Name = "ParameterTabControl";
            this.ParameterTabControl.SelectedIndex = 0;
            this.ParameterTabControl.Size = new System.Drawing.Size(979, 437);
            this.ParameterTabControl.TabIndex = 13;
            this.ParameterTabControl.SelectedIndexChanged += new System.EventHandler(this.ParameterTabControl_SelectedIndexChanged);
            // 
            // ParameterRawPage
            // 
            this.ParameterRawPage.Controls.Add(this.ParametersTextBox);
            this.ParameterRawPage.Location = new System.Drawing.Point(4, 25);
            this.ParameterRawPage.Name = "ParameterRawPage";
            this.ParameterRawPage.Padding = new System.Windows.Forms.Padding(3);
            this.ParameterRawPage.Size = new System.Drawing.Size(971, 408);
            this.ParameterRawPage.TabIndex = 0;
            this.ParameterRawPage.Text = "Raw";
            this.ParameterRawPage.UseVisualStyleBackColor = true;
            // 
            // ParameterFormPage
            // 
            this.ParameterFormPage.Controls.Add(this.Parameters);
            this.ParameterFormPage.Controls.Add(this.ClearParametersButton);
            this.ParameterFormPage.Controls.Add(this.AddParameter);
            this.ParameterFormPage.Location = new System.Drawing.Point(4, 25);
            this.ParameterFormPage.Name = "ParameterFormPage";
            this.ParameterFormPage.Padding = new System.Windows.Forms.Padding(3);
            this.ParameterFormPage.Size = new System.Drawing.Size(971, 408);
            this.ParameterFormPage.TabIndex = 1;
            this.ParameterFormPage.Text = "Form";
            this.ParameterFormPage.UseVisualStyleBackColor = true;
            // 
            // ParameterGroupBox
            // 
            this.ParameterGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ParameterGroupBox.Controls.Add(this.ParameterTabControl);
            this.ParameterGroupBox.Location = new System.Drawing.Point(12, 87);
            this.ParameterGroupBox.Name = "ParameterGroupBox";
            this.ParameterGroupBox.Size = new System.Drawing.Size(985, 458);
            this.ParameterGroupBox.TabIndex = 14;
            this.ParameterGroupBox.TabStop = false;
            this.ParameterGroupBox.Text = "Parameters";
            // 
            // ResponseGroupBox
            // 
            this.ResponseGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ResponseGroupBox.Controls.Add(this.LoadingTime);
            this.ResponseGroupBox.Controls.Add(this.textBox1);
            this.ResponseGroupBox.Location = new System.Drawing.Point(12, 551);
            this.ResponseGroupBox.Name = "ResponseGroupBox";
            this.ResponseGroupBox.Size = new System.Drawing.Size(985, 122);
            this.ResponseGroupBox.TabIndex = 15;
            this.ResponseGroupBox.TabStop = false;
            this.ResponseGroupBox.Text = "Response";
            this.ResponseGroupBox.Visible = false;
            // 
            // LoadingTime
            // 
            this.LoadingTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadingTime.Location = new System.Drawing.Point(3, 21);
            this.LoadingTime.Name = "LoadingTime";
            this.LoadingTime.ReadOnly = true;
            this.LoadingTime.Size = new System.Drawing.Size(979, 22);
            this.LoadingTime.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(3, 49);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(979, 70);
            this.textBox1.TabIndex = 0;
            // 
            // MethodGroupBox
            // 
            this.MethodGroupBox.Controls.Add(this.GETButton);
            this.MethodGroupBox.Controls.Add(this.POSTButton);
            this.MethodGroupBox.Location = new System.Drawing.Point(12, 32);
            this.MethodGroupBox.Name = "MethodGroupBox";
            this.MethodGroupBox.Size = new System.Drawing.Size(141, 49);
            this.MethodGroupBox.TabIndex = 16;
            this.MethodGroupBox.TabStop = false;
            this.MethodGroupBox.Text = "Method";
            // 
            // HttpTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 723);
            this.Controls.Add(this.MethodGroupBox);
            this.Controls.Add(this.ParameterGroupBox);
            this.Controls.Add(this.URLLabel);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.ChoosePrivateFile);
            this.Controls.Add(this.PrivateFile);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.ResponseGroupBox);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "HttpTest";
            this.Text = "HttpTest";
            this.ParameterTabControl.ResumeLayout(false);
            this.ParameterRawPage.ResumeLayout(false);
            this.ParameterRawPage.PerformLayout();
            this.ParameterFormPage.ResumeLayout(false);
            this.ParameterGroupBox.ResumeLayout(false);
            this.ResponseGroupBox.ResumeLayout(false);
            this.ResponseGroupBox.PerformLayout();
            this.MethodGroupBox.ResumeLayout(false);
            this.MethodGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddParameter;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.TableLayoutPanel Parameters;
        private System.Windows.Forms.RadioButton GETButton;
        private System.Windows.Forms.RadioButton POSTButton;
        private System.Windows.Forms.TextBox PrivateFile;
        private System.Windows.Forms.Button ChoosePrivateFile;
        private System.Windows.Forms.OpenFileDialog openPrivateKey;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label URLLabel;
        private System.Windows.Forms.TextBox ParametersTextBox;
        private System.Windows.Forms.Button ClearParametersButton;
        private System.Windows.Forms.TabControl ParameterTabControl;
        private System.Windows.Forms.TabPage ParameterRawPage;
        private System.Windows.Forms.TabPage ParameterFormPage;
        private System.Windows.Forms.GroupBox ParameterGroupBox;
        private System.Windows.Forms.GroupBox ResponseGroupBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox MethodGroupBox;
        private System.Windows.Forms.TextBox LoadingTime;
    }
}

