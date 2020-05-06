namespace DataStructuresFinal
{
    partial class CheckOutUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOutUserControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.checkoutSplitContainer = new System.Windows.Forms.SplitContainer();
            this.cartPanel = new System.Windows.Forms.Panel();
            this.emptyCartLabel = new System.Windows.Forms.Label();
            this.totalPrintLabel = new System.Windows.Forms.Label();
            this.totalTitleLabel = new System.Windows.Forms.Label();
            this.emptyCartPictureBox = new System.Windows.Forms.PictureBox();
            this.cartDataGridView = new System.Windows.Forms.DataGridView();
            this.cartEditLabel = new System.Windows.Forms.Label();
            this.timePickComboBox = new System.Windows.Forms.ComboBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.timePickTitleLabel = new System.Windows.Forms.Label();
            this.dayPickTitleLabel = new System.Windows.Forms.Label();
            this.dayPickComboBox = new System.Windows.Forms.ComboBox();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutSplitContainer)).BeginInit();
            this.checkoutSplitContainer.Panel1.SuspendLayout();
            this.checkoutSplitContainer.Panel2.SuspendLayout();
            this.checkoutSplitContainer.SuspendLayout();
            this.cartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emptyCartPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.contentPanel.Controls.Add(this.checkoutSplitContainer);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1026, 604);
            this.contentPanel.TabIndex = 0;
            // 
            // checkoutSplitContainer
            // 
            this.checkoutSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkoutSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.checkoutSplitContainer.Name = "checkoutSplitContainer";
            // 
            // checkoutSplitContainer.Panel1
            // 
            this.checkoutSplitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.checkoutSplitContainer.Panel1.Controls.Add(this.cartPanel);
            this.checkoutSplitContainer.Panel1.Controls.Add(this.cartEditLabel);
            // 
            // checkoutSplitContainer.Panel2
            // 
            this.checkoutSplitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.checkoutSplitContainer.Panel2.Controls.Add(this.timePickComboBox);
            this.checkoutSplitContainer.Panel2.Controls.Add(this.returnButton);
            this.checkoutSplitContainer.Panel2.Controls.Add(this.checkoutButton);
            this.checkoutSplitContainer.Panel2.Controls.Add(this.timePickTitleLabel);
            this.checkoutSplitContainer.Panel2.Controls.Add(this.dayPickTitleLabel);
            this.checkoutSplitContainer.Panel2.Controls.Add(this.dayPickComboBox);
            this.checkoutSplitContainer.Size = new System.Drawing.Size(1026, 604);
            this.checkoutSplitContainer.SplitterDistance = 676;
            this.checkoutSplitContainer.TabIndex = 0;
            // 
            // cartPanel
            // 
            this.cartPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.cartPanel.Controls.Add(this.emptyCartLabel);
            this.cartPanel.Controls.Add(this.totalPrintLabel);
            this.cartPanel.Controls.Add(this.totalTitleLabel);
            this.cartPanel.Controls.Add(this.emptyCartPictureBox);
            this.cartPanel.Controls.Add(this.cartDataGridView);
            this.cartPanel.Location = new System.Drawing.Point(78, 126);
            this.cartPanel.Name = "cartPanel";
            this.cartPanel.Size = new System.Drawing.Size(521, 442);
            this.cartPanel.TabIndex = 21;
            // 
            // emptyCartLabel
            // 
            this.emptyCartLabel.AutoSize = true;
            this.emptyCartLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.emptyCartLabel.Font = new System.Drawing.Font("Bauhaus 93", 19.25F);
            this.emptyCartLabel.Location = new System.Drawing.Point(145, 394);
            this.emptyCartLabel.Name = "emptyCartLabel";
            this.emptyCartLabel.Size = new System.Drawing.Size(225, 29);
            this.emptyCartLabel.TabIndex = 2;
            this.emptyCartLabel.Text = "Your Cart is empty";
            // 
            // totalPrintLabel
            // 
            this.totalPrintLabel.AutoSize = true;
            this.totalPrintLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.totalPrintLabel.Font = new System.Drawing.Font("Bauhaus 93", 19.25F);
            this.totalPrintLabel.Location = new System.Drawing.Point(332, 378);
            this.totalPrintLabel.Name = "totalPrintLabel";
            this.totalPrintLabel.Size = new System.Drawing.Size(186, 29);
            this.totalPrintLabel.TabIndex = 33;
            this.totalPrintLabel.Text = "total gose here";
            this.totalPrintLabel.Visible = false;
            // 
            // totalTitleLabel
            // 
            this.totalTitleLabel.AutoSize = true;
            this.totalTitleLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.totalTitleLabel.Font = new System.Drawing.Font("Bauhaus 93", 19.25F);
            this.totalTitleLabel.Location = new System.Drawing.Point(177, 378);
            this.totalTitleLabel.Name = "totalTitleLabel";
            this.totalTitleLabel.Size = new System.Drawing.Size(140, 29);
            this.totalTitleLabel.TabIndex = 32;
            this.totalTitleLabel.Text = "Your Total:";
            this.totalTitleLabel.Visible = false;
            // 
            // emptyCartPictureBox
            // 
            this.emptyCartPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emptyCartPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("emptyCartPictureBox.Image")));
            this.emptyCartPictureBox.Location = new System.Drawing.Point(0, 0);
            this.emptyCartPictureBox.Name = "emptyCartPictureBox";
            this.emptyCartPictureBox.Size = new System.Drawing.Size(521, 442);
            this.emptyCartPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.emptyCartPictureBox.TabIndex = 1;
            this.emptyCartPictureBox.TabStop = false;
            // 
            // cartDataGridView
            // 
            this.cartDataGridView.AllowUserToAddRows = false;
            this.cartDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cartDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.cartDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cartDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bauhaus 93", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDataGridView.Location = new System.Drawing.Point(0, 0);
            this.cartDataGridView.MultiSelect = false;
            this.cartDataGridView.Name = "cartDataGridView";
            this.cartDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bauhaus 93", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.cartDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.cartDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.cartDataGridView.Size = new System.Drawing.Size(521, 363);
            this.cartDataGridView.TabIndex = 0;
            this.cartDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CartDataGridView_CellContentClick);
            // 
            // cartEditLabel
            // 
            this.cartEditLabel.AutoSize = true;
            this.cartEditLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.cartEditLabel.Font = new System.Drawing.Font("Bauhaus 93", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartEditLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.cartEditLabel.Image = ((System.Drawing.Image)(resources.GetObject("cartEditLabel.Image")));
            this.cartEditLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cartEditLabel.Location = new System.Drawing.Point(185, 36);
            this.cartEditLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cartEditLabel.Name = "cartEditLabel";
            this.cartEditLabel.Size = new System.Drawing.Size(284, 73);
            this.cartEditLabel.TabIndex = 20;
            this.cartEditLabel.Text = "Edit Cart";
            // 
            // timePickComboBox
            // 
            this.timePickComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.timePickComboBox.Font = new System.Drawing.Font("Bauhaus 93", 15F);
            this.timePickComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.timePickComboBox.FormattingEnabled = true;
            this.timePickComboBox.Location = new System.Drawing.Point(47, 339);
            this.timePickComboBox.Name = "timePickComboBox";
            this.timePickComboBox.Size = new System.Drawing.Size(246, 31);
            this.timePickComboBox.TabIndex = 31;
            this.timePickComboBox.Text = "12PM - 6PM";
            // 
            // returnButton
            // 
            this.returnButton.AutoSize = true;
            this.returnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.returnButton.Font = new System.Drawing.Font("Bauhaus 93", 10.8F);
            this.returnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.returnButton.Location = new System.Drawing.Point(130, 443);
            this.returnButton.Margin = new System.Windows.Forms.Padding(2);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(80, 34);
            this.returnButton.TabIndex = 30;
            this.returnButton.Text = "&Return";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // checkoutButton
            // 
            this.checkoutButton.AutoSize = true;
            this.checkoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.checkoutButton.Font = new System.Drawing.Font("Bauhaus 93", 36F);
            this.checkoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.checkoutButton.Location = new System.Drawing.Point(47, 495);
            this.checkoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(253, 64);
            this.checkoutButton.TabIndex = 29;
            this.checkoutButton.Text = "&CheckOut";
            this.checkoutButton.UseVisualStyleBackColor = false;
            this.checkoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // timePickTitleLabel
            // 
            this.timePickTitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.timePickTitleLabel.Font = new System.Drawing.Font("Bauhaus 93", 36F);
            this.timePickTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.timePickTitleLabel.Location = new System.Drawing.Point(12, 127);
            this.timePickTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timePickTitleLabel.Name = "timePickTitleLabel";
            this.timePickTitleLabel.Size = new System.Drawing.Size(318, 223);
            this.timePickTitleLabel.TabIndex = 24;
            this.timePickTitleLabel.Text = "Select an available PickUp Time";
            this.timePickTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayPickTitleLabel
            // 
            this.dayPickTitleLabel.AutoSize = true;
            this.dayPickTitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.dayPickTitleLabel.Font = new System.Drawing.Font("Bauhaus 93", 36F);
            this.dayPickTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.dayPickTitleLabel.Location = new System.Drawing.Point(38, 36);
            this.dayPickTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dayPickTitleLabel.Name = "dayPickTitleLabel";
            this.dayPickTitleLabel.Size = new System.Drawing.Size(258, 54);
            this.dayPickTitleLabel.TabIndex = 22;
            this.dayPickTitleLabel.Text = "Pick a Day";
            // 
            // dayPickComboBox
            // 
            this.dayPickComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.dayPickComboBox.Font = new System.Drawing.Font("Bauhaus 93", 15F);
            this.dayPickComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.dayPickComboBox.FormattingEnabled = true;
            this.dayPickComboBox.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.dayPickComboBox.Location = new System.Drawing.Point(88, 93);
            this.dayPickComboBox.Name = "dayPickComboBox";
            this.dayPickComboBox.Size = new System.Drawing.Size(171, 31);
            this.dayPickComboBox.TabIndex = 21;
            this.dayPickComboBox.Text = "Monday";
            this.dayPickComboBox.SelectedIndexChanged += new System.EventHandler(this.DayPickComboBox_SelectedIndexChanged);
            // 
            // CheckOutUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contentPanel);
            this.Font = new System.Drawing.Font("Bauhaus 93", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CheckOutUserControl";
            this.Size = new System.Drawing.Size(1026, 604);
            this.Load += new System.EventHandler(this.CheckOutUserControl_Load);
            this.contentPanel.ResumeLayout(false);
            this.checkoutSplitContainer.Panel1.ResumeLayout(false);
            this.checkoutSplitContainer.Panel1.PerformLayout();
            this.checkoutSplitContainer.Panel2.ResumeLayout(false);
            this.checkoutSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutSplitContainer)).EndInit();
            this.checkoutSplitContainer.ResumeLayout(false);
            this.cartPanel.ResumeLayout(false);
            this.cartPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emptyCartPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.SplitContainer checkoutSplitContainer;
        private System.Windows.Forms.Panel cartPanel;
        private System.Windows.Forms.Label cartEditLabel;
        private System.Windows.Forms.ComboBox dayPickComboBox;
        private System.Windows.Forms.Label timePickTitleLabel;
        private System.Windows.Forms.Label dayPickTitleLabel;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.DataGridView cartDataGridView;
        private System.Windows.Forms.Label emptyCartLabel;
        private System.Windows.Forms.PictureBox emptyCartPictureBox;
        private System.Windows.Forms.ComboBox timePickComboBox;
        private System.Windows.Forms.Label totalPrintLabel;
        private System.Windows.Forms.Label totalTitleLabel;
    }
}
