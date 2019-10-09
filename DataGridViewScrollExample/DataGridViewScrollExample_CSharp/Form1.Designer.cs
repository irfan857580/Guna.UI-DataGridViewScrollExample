namespace DataGridViewScrollExample_CSharp
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
            this.GunaHScrollBar1 = new Guna.UI.WinForms.GunaHScrollBar();
            this.GunaVScrollBar1 = new Guna.UI.WinForms.GunaVScrollBar();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GunaHScrollBar1
            // 
            this.GunaHScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GunaHScrollBar1.BackColor = System.Drawing.Color.Transparent;
            this.GunaHScrollBar1.LargeChange = 10;
            this.GunaHScrollBar1.Location = new System.Drawing.Point(29, 418);
            this.GunaHScrollBar1.Maximum = 100;
            this.GunaHScrollBar1.Name = "GunaHScrollBar1";
            this.GunaHScrollBar1.ScrollIdleColor = System.Drawing.Color.Silver;
            this.GunaHScrollBar1.Size = new System.Drawing.Size(200, 10);
            this.GunaHScrollBar1.TabIndex = 5;
            this.GunaHScrollBar1.ThumbColor = System.Drawing.Color.DimGray;
            this.GunaHScrollBar1.ThumbHoverColor = System.Drawing.Color.Gray;
            this.GunaHScrollBar1.ThumbPressedColor = System.Drawing.Color.DarkGray;
            // 
            // GunaVScrollBar1
            // 
            this.GunaVScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GunaVScrollBar1.LargeChange = 10;
            this.GunaVScrollBar1.Location = new System.Drawing.Point(679, 51);
            this.GunaVScrollBar1.Maximum = 100;
            this.GunaVScrollBar1.Name = "GunaVScrollBar1";
            this.GunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.Silver;
            this.GunaVScrollBar1.Size = new System.Drawing.Size(10, 200);
            this.GunaVScrollBar1.TabIndex = 4;
            this.GunaVScrollBar1.ThumbColor = System.Drawing.Color.DimGray;
            this.GunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.Gray;
            this.GunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.DarkGray;
            // 
            // DataGridView1
            // 
            this.DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DataGridView1.Location = new System.Drawing.Point(29, 38);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(620, 347);
            this.DataGridView1.TabIndex = 3;
            this.DataGridView1.Resize += new System.EventHandler(this.DataGridView1_Resize);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 467);
            this.Controls.Add(this.GunaHScrollBar1);
            this.Controls.Add(this.GunaVScrollBar1);
            this.Controls.Add(this.DataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal Guna.UI.WinForms.GunaHScrollBar GunaHScrollBar1;
        internal Guna.UI.WinForms.GunaVScrollBar GunaVScrollBar1;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

