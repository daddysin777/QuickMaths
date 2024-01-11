
namespace QuickMathsDisp
{
    partial class MulQuizDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.EnterAnsBtn = new System.Windows.Forms.Button();
            this.Anstxtbox = new System.Windows.Forms.TextBox();
            this.QuesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(362, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 76);
            this.label1.TabIndex = 14;
            this.label1.Text = "P R E S S   N E X T\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(369, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "N E X T\r\n\r\n\r\n\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EnterAnsBtn
            // 
            this.EnterAnsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EnterAnsBtn.FlatAppearance.BorderSize = 3;
            this.EnterAnsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterAnsBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterAnsBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EnterAnsBtn.Location = new System.Drawing.Point(369, 229);
            this.EnterAnsBtn.Name = "EnterAnsBtn";
            this.EnterAnsBtn.Size = new System.Drawing.Size(245, 51);
            this.EnterAnsBtn.TabIndex = 12;
            this.EnterAnsBtn.Text = "E N T E R\r\n";
            this.EnterAnsBtn.UseVisualStyleBackColor = true;
            this.EnterAnsBtn.Click += new System.EventHandler(this.EnterAnsBtn_Click);
            // 
            // Anstxtbox
            // 
            this.Anstxtbox.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anstxtbox.Location = new System.Drawing.Point(514, 180);
            this.Anstxtbox.Name = "Anstxtbox";
            this.Anstxtbox.Size = new System.Drawing.Size(100, 43);
            this.Anstxtbox.TabIndex = 11;
            this.Anstxtbox.TextChanged += new System.EventHandler(this.Anstxtbox_TextChanged);
            // 
            // QuesLabel
            // 
            this.QuesLabel.AutoSize = true;
            this.QuesLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuesLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.QuesLabel.Location = new System.Drawing.Point(362, 181);
            this.QuesLabel.Name = "QuesLabel";
            this.QuesLabel.Size = new System.Drawing.Size(17, 38);
            this.QuesLabel.TabIndex = 10;
            this.QuesLabel.Text = "\r\n";
            this.QuesLabel.Click += new System.EventHandler(this.QuesLabel_Click);
            // 
            // MulQuizDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EnterAnsBtn);
            this.Controls.Add(this.Anstxtbox);
            this.Controls.Add(this.QuesLabel);
            this.Name = "MulQuizDisplay";
            this.Size = new System.Drawing.Size(994, 583);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button EnterAnsBtn;
        private System.Windows.Forms.TextBox Anstxtbox;
        private System.Windows.Forms.Label QuesLabel;
    }
}
