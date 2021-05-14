namespace Monopoly__Mario_Kart_
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
            this.startbtn = new System.Windows.Forms.Button();
            this.characterselectbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(29, 631);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(75, 23);
            this.startbtn.TabIndex = 0;
            this.startbtn.Text = "Start";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // characterselectbtn
            // 
            this.characterselectbtn.Location = new System.Drawing.Point(425, 604);
            this.characterselectbtn.Name = "characterselectbtn";
            this.characterselectbtn.Size = new System.Drawing.Size(75, 23);
            this.characterselectbtn.TabIndex = 1;
            this.characterselectbtn.Text = "Select Character";
            this.characterselectbtn.UseVisualStyleBackColor = true;
            this.characterselectbtn.Click += new System.EventHandler(this.characterselectbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.characterselectbtn);
            this.Controls.Add(this.startbtn);
            this.Name = "Form1";
            this.Text = "Monopoly Gamer Mario Kart";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Button characterselectbtn;
    }
}

