namespace MyFirstWinForm
{
    partial class My2ndForm
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
            this.BTNClickMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNClickMe
            // 
            this.BTNClickMe.BackColor = System.Drawing.Color.Azure;
            this.BTNClickMe.ForeColor = System.Drawing.Color.DarkBlue;
            this.BTNClickMe.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BTNClickMe.Location = new System.Drawing.Point(287, 177);
            this.BTNClickMe.Name = "BTNClickMe";
            this.BTNClickMe.Size = new System.Drawing.Size(299, 251);
            this.BTNClickMe.TabIndex = 0;
            this.BTNClickMe.Text = "Click Me";
            this.BTNClickMe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTNClickMe.UseVisualStyleBackColor = false;
            this.BTNClickMe.Click += new System.EventHandler(this.BTNClickMe_Click);
            // 
            // My2ndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNClickMe);
            this.Name = "My2ndForm";
            this.Text = "My2ndForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNClickMe;
    }
}