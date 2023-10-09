namespace arkaplanrenk
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
            this.cbBlue = new System.Windows.Forms.CheckBox();
            this.cbYellow = new System.Windows.Forms.CheckBox();
            this.cbDarkBlue = new System.Windows.Forms.CheckBox();
            this.cbRed = new System.Windows.Forms.CheckBox();
            this.cbPurple = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbBlue
            // 
            this.cbBlue.AutoSize = true;
            this.cbBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbBlue.Location = new System.Drawing.Point(12, 82);
            this.cbBlue.Name = "cbBlue";
            this.cbBlue.Size = new System.Drawing.Size(68, 28);
            this.cbBlue.TabIndex = 0;
            this.cbBlue.Text = "Mavi";
            this.cbBlue.UseVisualStyleBackColor = true;
            this.cbBlue.CheckedChanged += new System.EventHandler(this.cbBlue_CheckedChanged);
            // 
            // cbYellow
            // 
            this.cbYellow.AutoSize = true;
            this.cbYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbYellow.Location = new System.Drawing.Point(12, 119);
            this.cbYellow.Name = "cbYellow";
            this.cbYellow.Size = new System.Drawing.Size(61, 28);
            this.cbYellow.TabIndex = 1;
            this.cbYellow.Text = "Sarı";
            this.cbYellow.UseVisualStyleBackColor = true;
            this.cbYellow.CheckedChanged += new System.EventHandler(this.cbYellow_CheckedChanged);
            // 
            // cbDarkBlue
            // 
            this.cbDarkBlue.AutoSize = true;
            this.cbDarkBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbDarkBlue.Location = new System.Drawing.Point(12, 159);
            this.cbDarkBlue.Name = "cbDarkBlue";
            this.cbDarkBlue.Size = new System.Drawing.Size(116, 28);
            this.cbDarkBlue.TabIndex = 2;
            this.cbDarkBlue.Text = "Koyu mavi";
            this.cbDarkBlue.UseVisualStyleBackColor = true;
            this.cbDarkBlue.CheckedChanged += new System.EventHandler(this.cbDarkBlue_CheckedChanged);
            // 
            // cbRed
            // 
            this.cbRed.AutoSize = true;
            this.cbRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbRed.Location = new System.Drawing.Point(12, 204);
            this.cbRed.Name = "cbRed";
            this.cbRed.Size = new System.Drawing.Size(84, 28);
            this.cbRed.TabIndex = 3;
            this.cbRed.Text = "Kırmızı";
            this.cbRed.UseVisualStyleBackColor = true;
            this.cbRed.CheckedChanged += new System.EventHandler(this.cbGreen_CheckedChanged);
            // 
            // cbPurple
            // 
            this.cbPurple.AutoSize = true;
            this.cbPurple.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbPurple.Location = new System.Drawing.Point(12, 247);
            this.cbPurple.Name = "cbPurple";
            this.cbPurple.Size = new System.Drawing.Size(62, 28);
            this.cbPurple.TabIndex = 4;
            this.cbPurple.Text = "Mor";
            this.cbPurple.UseVisualStyleBackColor = true;
            this.cbPurple.CheckedChanged += new System.EventHandler(this.cbPurple_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 369);
            this.Controls.Add(this.cbPurple);
            this.Controls.Add(this.cbRed);
            this.Controls.Add(this.cbDarkBlue);
            this.Controls.Add(this.cbYellow);
            this.Controls.Add(this.cbBlue);
            this.Name = "Form1";
            this.Text = "DİSKO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbBlue;
        private System.Windows.Forms.CheckBox cbYellow;
        private System.Windows.Forms.CheckBox cbDarkBlue;
        private System.Windows.Forms.CheckBox cbRed;
        private System.Windows.Forms.CheckBox cbPurple;
    }
}

