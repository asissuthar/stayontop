namespace StayOnTop
{
    partial class Main
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
            this.lbWindows = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSetNormal = new System.Windows.Forms.Button();
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.btnSetTop = new System.Windows.Forms.Button();
            this.btnSetBottom = new System.Windows.Forms.Button();
            this.layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbWindows
            // 
            this.lbWindows.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.layout.SetColumnSpan(this.lbWindows, 4);
            this.lbWindows.DisplayMember = "Title";
            this.lbWindows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbWindows.FormattingEnabled = true;
            this.lbWindows.Location = new System.Drawing.Point(0, 50);
            this.lbWindows.Margin = new System.Windows.Forms.Padding(0);
            this.lbWindows.Name = "lbWindows";
            this.lbWindows.Size = new System.Drawing.Size(550, 400);
            this.lbWindows.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.Location = new System.Drawing.Point(0, 0);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(137, 50);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSetNormal
            // 
            this.btnSetNormal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetNormal.Location = new System.Drawing.Point(137, 0);
            this.btnSetNormal.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetNormal.Name = "btnSetNormal";
            this.btnSetNormal.Size = new System.Drawing.Size(137, 50);
            this.btnSetNormal.TabIndex = 3;
            this.btnSetNormal.Text = "Set Normal";
            this.btnSetNormal.UseVisualStyleBackColor = true;
            this.btnSetNormal.Click += new System.EventHandler(this.btnSetNormal_Click);
            // 
            // layout
            // 
            this.layout.AutoSize = true;
            this.layout.ColumnCount = 4;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout.Controls.Add(this.btnSetNormal, 1, 0);
            this.layout.Controls.Add(this.lbWindows, 0, 1);
            this.layout.Controls.Add(this.btnSetTop, 2, 0);
            this.layout.Controls.Add(this.btnRefresh, 0, 0);
            this.layout.Controls.Add(this.btnSetBottom, 3, 0);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Margin = new System.Windows.Forms.Padding(0);
            this.layout.Name = "layout";
            this.layout.RowCount = 2;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.Size = new System.Drawing.Size(550, 450);
            this.layout.TabIndex = 4;
            // 
            // btnSetTop
            // 
            this.btnSetTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetTop.Location = new System.Drawing.Point(274, 0);
            this.btnSetTop.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetTop.Name = "btnSetTop";
            this.btnSetTop.Size = new System.Drawing.Size(137, 50);
            this.btnSetTop.TabIndex = 2;
            this.btnSetTop.Text = "Set Top";
            this.btnSetTop.UseVisualStyleBackColor = true;
            this.btnSetTop.Click += new System.EventHandler(this.btnSetTop_Click);
            // 
            // btnSetBottom
            // 
            this.btnSetBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetBottom.Location = new System.Drawing.Point(411, 0);
            this.btnSetBottom.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetBottom.Name = "btnSetBottom";
            this.btnSetBottom.Size = new System.Drawing.Size(139, 50);
            this.btnSetBottom.TabIndex = 4;
            this.btnSetBottom.Text = "Set Bottom";
            this.btnSetBottom.UseVisualStyleBackColor = true;
            this.btnSetBottom.Click += new System.EventHandler(this.btnSetBottom_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.layout);
            this.DoubleBuffered = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StayOnTop";
            this.Load += new System.EventHandler(this.Main_Load);
            this.layout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbWindows;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSetNormal;
        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Button btnSetTop;
        private System.Windows.Forms.Button btnSetBottom;
    }
}

