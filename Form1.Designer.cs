namespace Wordle
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.panTopbar = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.flpLetter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panTopbar
            // 
            this.panTopbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTopbar.Location = new System.Drawing.Point(0, 0);
            this.panTopbar.MinimumSize = new System.Drawing.Size(800, 80);
            this.panTopbar.Name = "panTopbar";
            this.panTopbar.Size = new System.Drawing.Size(800, 80);
            this.panTopbar.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // flpLetter
            // 
            this.flpLetter.AutoScroll = true;
            this.flpLetter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flpLetter.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpLetter.Location = new System.Drawing.Point(0, 80);
            this.flpLetter.Margin = new System.Windows.Forms.Padding(0);
            this.flpLetter.Name = "flpLetter";
            this.flpLetter.Size = new System.Drawing.Size(584, 272);
            this.flpLetter.TabIndex = 1;
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(100, 370);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(400, 80);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.flpLetter);
            this.Controls.Add(this.panTopbar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTopbar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flpLetter;
        private System.Windows.Forms.Button btnCheck;
    }
}

