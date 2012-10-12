namespace GuidGenerator
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
            this.txtDisplayGuids = new System.Windows.Forms.TextBox();
            this.txtNumGuids = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDisplayGuids
            // 
            this.txtDisplayGuids.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDisplayGuids.BackColor = System.Drawing.SystemColors.Window;
            this.txtDisplayGuids.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayGuids.Location = new System.Drawing.Point(12, 41);
            this.txtDisplayGuids.Multiline = true;
            this.txtDisplayGuids.Name = "txtDisplayGuids";
            this.txtDisplayGuids.ReadOnly = true;
            this.txtDisplayGuids.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDisplayGuids.Size = new System.Drawing.Size(293, 88);
            this.txtDisplayGuids.TabIndex = 0;
            // 
            // txtNumGuids
            // 
            this.txtNumGuids.Location = new System.Drawing.Point(166, 12);
            this.txtNumGuids.Name = "txtNumGuids";
            this.txtNumGuids.Size = new System.Drawing.Size(50, 20);
            this.txtNumGuids.TabIndex = 1;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(241, 10);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(64, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of GUIDs to generate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 141);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtNumGuids);
            this.Controls.Add(this.txtDisplayGuids);
            this.MinimumSize = new System.Drawing.Size(304, 150);
            this.Name = "Form1";
            this.Text = "GUID Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplayGuids;
        private System.Windows.Forms.TextBox txtNumGuids;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label1;
    }
}

