
namespace RSS_Feed
{
    partial class FrmMain
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
            this.lblCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFeeds = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudDaysInactive = new System.Windows.Forms.NumericUpDown();
            this.dgvInactiveFeeds = new System.Windows.Forms.DataGridView();
            this.btnGetInactiveFeeds = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysInactive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInactiveFeeds)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(56, 427);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 13);
            this.lblCount.TabIndex = 15;
            this.lblCount.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Feeds:";
            // 
            // cbFeeds
            // 
            this.cbFeeds.FormattingEnabled = true;
            this.cbFeeds.Location = new System.Drawing.Point(59, 12);
            this.cbFeeds.Name = "cbFeeds";
            this.cbFeeds.Size = new System.Drawing.Size(246, 21);
            this.cbFeeds.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Days Inactive:";
            // 
            // nudDaysInactive
            // 
            this.nudDaysInactive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudDaysInactive.Location = new System.Drawing.Point(413, 12);
            this.nudDaysInactive.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDaysInactive.Name = "nudDaysInactive";
            this.nudDaysInactive.Size = new System.Drawing.Size(66, 20);
            this.nudDaysInactive.TabIndex = 10;
            this.nudDaysInactive.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // dgvInactiveFeeds
            // 
            this.dgvInactiveFeeds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInactiveFeeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInactiveFeeds.Location = new System.Drawing.Point(12, 40);
            this.dgvInactiveFeeds.Name = "dgvInactiveFeeds";
            this.dgvInactiveFeeds.Size = new System.Drawing.Size(776, 379);
            this.dgvInactiveFeeds.TabIndex = 9;
            // 
            // btnGetInactiveFeeds
            // 
            this.btnGetInactiveFeeds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetInactiveFeeds.Location = new System.Drawing.Point(657, 11);
            this.btnGetInactiveFeeds.Name = "btnGetInactiveFeeds";
            this.btnGetInactiveFeeds.Size = new System.Drawing.Size(131, 23);
            this.btnGetInactiveFeeds.TabIndex = 8;
            this.btnGetInactiveFeeds.Text = "Get Inactive Feeds";
            this.btnGetInactiveFeeds.UseVisualStyleBackColor = true;
            this.btnGetInactiveFeeds.Click += new System.EventHandler(this.btnGetInactiveFeeds_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFeeds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudDaysInactive);
            this.Controls.Add(this.dgvInactiveFeeds);
            this.Controls.Add(this.btnGetInactiveFeeds);
            this.Name = "FrmMain";
            this.Text = "RSS Feed";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysInactive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInactiveFeeds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFeeds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudDaysInactive;
        private System.Windows.Forms.DataGridView dgvInactiveFeeds;
        private System.Windows.Forms.Button btnGetInactiveFeeds;
    }
}

