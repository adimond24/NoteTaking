namespace NoteTaking
{
    partial class Form2
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
            this.form2_title = new System.Windows.Forms.Label();
            this.form2_message = new System.Windows.Forms.Label();
            this.form2_textNew = new System.Windows.Forms.Label();
            this.form2_messageNew = new System.Windows.Forms.Label();
            this.Form2_TitleOutput = new System.Windows.Forms.Label();
            this.Form2_MessageOutput = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // form2_title
            // 
            this.form2_title.AutoSize = true;
            this.form2_title.Location = new System.Drawing.Point(127, 64);
            this.form2_title.Name = "form2_title";
            this.form2_title.Size = new System.Drawing.Size(38, 20);
            this.form2_title.TabIndex = 0;
            this.form2_title.Text = "Title";
            // 
            // form2_message
            // 
            this.form2_message.AutoSize = true;
            this.form2_message.Location = new System.Drawing.Point(127, 151);
            this.form2_message.Name = "form2_message";
            this.form2_message.Size = new System.Drawing.Size(74, 20);
            this.form2_message.TabIndex = 1;
            this.form2_message.Text = "Message";
            // 
            // form2_textNew
            // 
            this.form2_textNew.AutoSize = true;
            this.form2_textNew.Location = new System.Drawing.Point(332, 64);
            this.form2_textNew.Name = "form2_textNew";
            this.form2_textNew.Size = new System.Drawing.Size(0, 20);
            this.form2_textNew.TabIndex = 2;
            // 
            // form2_messageNew
            // 
            this.form2_messageNew.AutoSize = true;
            this.form2_messageNew.Location = new System.Drawing.Point(336, 151);
            this.form2_messageNew.Name = "form2_messageNew";
            this.form2_messageNew.Size = new System.Drawing.Size(0, 20);
            this.form2_messageNew.TabIndex = 3;
            // 
            // Form2_TitleOutput
            // 
            this.Form2_TitleOutput.AutoSize = true;
            this.Form2_TitleOutput.Location = new System.Drawing.Point(377, 78);
            this.Form2_TitleOutput.Name = "Form2_TitleOutput";
            this.Form2_TitleOutput.Size = new System.Drawing.Size(51, 20);
            this.Form2_TitleOutput.TabIndex = 4;
            this.Form2_TitleOutput.Text = "label1";
            // 
            // Form2_MessageOutput
            // 
            this.Form2_MessageOutput.AutoSize = true;
            this.Form2_MessageOutput.Location = new System.Drawing.Point(381, 164);
            this.Form2_MessageOutput.Name = "Form2_MessageOutput";
            this.Form2_MessageOutput.Size = new System.Drawing.Size(51, 20);
            this.Form2_MessageOutput.TabIndex = 5;
            this.Form2_MessageOutput.Text = "label1";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(230, 250);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 41);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Go Back";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Form2_MessageOutput);
            this.Controls.Add(this.Form2_TitleOutput);
            this.Controls.Add(this.form2_messageNew);
            this.Controls.Add(this.form2_textNew);
            this.Controls.Add(this.form2_message);
            this.Controls.Add(this.form2_title);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label form2_title;
        private System.Windows.Forms.Label form2_message;
        private System.Windows.Forms.Label form2_textNew;
        private System.Windows.Forms.Label form2_messageNew;
        private System.Windows.Forms.Label Form2_TitleOutput;
        private System.Windows.Forms.Label Form2_MessageOutput;
        private System.Windows.Forms.Button btnClose;
    }
}