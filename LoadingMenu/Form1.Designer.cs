namespace LoadingMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.frombox = new System.Windows.Forms.TextBox();
            this.tobox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.copybtn = new System.Windows.Forms.Button();
            this.abortbtn = new System.Windows.Forms.Button();
            this.resumebtn = new System.Windows.Forms.Button();
            this.suspendbtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frombox
            // 
            this.frombox.Location = new System.Drawing.Point(78, 56);
            this.frombox.Name = "frombox";
            this.frombox.Size = new System.Drawing.Size(348, 22);
            this.frombox.TabIndex = 1;
            this.frombox.TextChanged += new System.EventHandler(this.frombox_TextChanged);
            // 
            // tobox
            // 
            this.tobox.Location = new System.Drawing.Point(78, 116);
            this.tobox.Name = "tobox";
            this.tobox.Size = new System.Drawing.Size(348, 22);
            this.tobox.TabIndex = 2;
            this.tobox.TextChanged += new System.EventHandler(this.tobox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // copybtn
            // 
            this.copybtn.Location = new System.Drawing.Point(565, 171);
            this.copybtn.Name = "copybtn";
            this.copybtn.Size = new System.Drawing.Size(90, 37);
            this.copybtn.TabIndex = 4;
            this.copybtn.Text = "Copy";
            this.copybtn.UseVisualStyleBackColor = true;
            this.copybtn.Click += new System.EventHandler(this.copybtn_Click);
            // 
            // abortbtn
            // 
            this.abortbtn.Location = new System.Drawing.Point(469, 171);
            this.abortbtn.Name = "abortbtn";
            this.abortbtn.Size = new System.Drawing.Size(90, 37);
            this.abortbtn.TabIndex = 5;
            this.abortbtn.Text = "Abort";
            this.abortbtn.UseVisualStyleBackColor = true;
            this.abortbtn.Click += new System.EventHandler(this.abortbtn_Click);
            // 
            // resumebtn
            // 
            this.resumebtn.Location = new System.Drawing.Point(378, 171);
            this.resumebtn.Name = "resumebtn";
            this.resumebtn.Size = new System.Drawing.Size(85, 37);
            this.resumebtn.TabIndex = 6;
            this.resumebtn.Text = "Resume";
            this.resumebtn.UseVisualStyleBackColor = true;
            this.resumebtn.Click += new System.EventHandler(this.resumebtn_Click);
            // 
            // suspendbtn
            // 
            this.suspendbtn.Location = new System.Drawing.Point(286, 171);
            this.suspendbtn.Name = "suspendbtn";
            this.suspendbtn.Size = new System.Drawing.Size(86, 37);
            this.suspendbtn.TabIndex = 7;
            this.suspendbtn.Text = "Suspend";
            this.suspendbtn.UseVisualStyleBackColor = true;
            this.suspendbtn.Click += new System.EventHandler(this.suspendbtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 171);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(268, 37);
            this.progressBar1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 242);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.suspendbtn);
            this.Controls.Add(this.resumebtn);
            this.Controls.Add(this.abortbtn);
            this.Controls.Add(this.copybtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tobox);
            this.Controls.Add(this.frombox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox frombox;
        private System.Windows.Forms.TextBox tobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button copybtn;
        private System.Windows.Forms.Button abortbtn;
        private System.Windows.Forms.Button resumebtn;
        private System.Windows.Forms.Button suspendbtn;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

