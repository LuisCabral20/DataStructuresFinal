namespace DataStructuresFinal
{
    partial class CategoryUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryUserControl));
            this.contentPanel = new System.Windows.Forms.Panel();
            this.categoryCenterPanel = new System.Windows.Forms.Panel();
            this.frozenPictureBox = new System.Windows.Forms.PictureBox();
            this.producePictureBox = new System.Windows.Forms.PictureBox();
            this.meatAndFishPictureBox = new System.Windows.Forms.PictureBox();
            this.canGoodsPictureBox = new System.Windows.Forms.PictureBox();
            this.canLabel = new System.Windows.Forms.Label();
            this.meatsLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.frozenLabel = new System.Windows.Forms.Label();
            this.categoryTitleLabel = new System.Windows.Forms.Label();
            this.produceLabel = new System.Windows.Forms.Label();
            this.contentPanel.SuspendLayout();
            this.categoryCenterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frozenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meatAndFishPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canGoodsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.contentPanel.Controls.Add(this.categoryCenterPanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1368, 744);
            this.contentPanel.TabIndex = 14;
            // 
            // categoryCenterPanel
            // 
            this.categoryCenterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            this.categoryCenterPanel.Controls.Add(this.frozenPictureBox);
            this.categoryCenterPanel.Controls.Add(this.producePictureBox);
            this.categoryCenterPanel.Controls.Add(this.meatAndFishPictureBox);
            this.categoryCenterPanel.Controls.Add(this.canGoodsPictureBox);
            this.categoryCenterPanel.Controls.Add(this.canLabel);
            this.categoryCenterPanel.Controls.Add(this.meatsLabel);
            this.categoryCenterPanel.Controls.Add(this.exitButton);
            this.categoryCenterPanel.Controls.Add(this.checkOutButton);
            this.categoryCenterPanel.Controls.Add(this.frozenLabel);
            this.categoryCenterPanel.Controls.Add(this.categoryTitleLabel);
            this.categoryCenterPanel.Controls.Add(this.produceLabel);
            this.categoryCenterPanel.Location = new System.Drawing.Point(237, 27);
            this.categoryCenterPanel.Name = "categoryCenterPanel";
            this.categoryCenterPanel.Size = new System.Drawing.Size(895, 690);
            this.categoryCenterPanel.TabIndex = 17;
            // 
            // frozenPictureBox
            // 
            this.frozenPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("frozenPictureBox.Image")));
            this.frozenPictureBox.Location = new System.Drawing.Point(111, 112);
            this.frozenPictureBox.Name = "frozenPictureBox";
            this.frozenPictureBox.Size = new System.Drawing.Size(263, 227);
            this.frozenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frozenPictureBox.TabIndex = 17;
            this.frozenPictureBox.TabStop = false;
            this.frozenPictureBox.Click += new System.EventHandler(this.FrozenPictureBox_Click);
            // 
            // producePictureBox
            // 
            this.producePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("producePictureBox.Image")));
            this.producePictureBox.Location = new System.Drawing.Point(520, 112);
            this.producePictureBox.Name = "producePictureBox";
            this.producePictureBox.Size = new System.Drawing.Size(263, 227);
            this.producePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.producePictureBox.TabIndex = 19;
            this.producePictureBox.TabStop = false;
            this.producePictureBox.Click += new System.EventHandler(this.producePictureBox_Click);
            // 
            // meatAndFishPictureBox
            // 
            this.meatAndFishPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("meatAndFishPictureBox.Image")));
            this.meatAndFishPictureBox.Location = new System.Drawing.Point(520, 388);
            this.meatAndFishPictureBox.Name = "meatAndFishPictureBox";
            this.meatAndFishPictureBox.Size = new System.Drawing.Size(263, 227);
            this.meatAndFishPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.meatAndFishPictureBox.TabIndex = 21;
            this.meatAndFishPictureBox.TabStop = false;
            this.meatAndFishPictureBox.Click += new System.EventHandler(this.meatAndFishPictureBox_Click);
            // 
            // canGoodsPictureBox
            // 
            this.canGoodsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("canGoodsPictureBox.Image")));
            this.canGoodsPictureBox.Location = new System.Drawing.Point(111, 388);
            this.canGoodsPictureBox.Name = "canGoodsPictureBox";
            this.canGoodsPictureBox.Size = new System.Drawing.Size(263, 227);
            this.canGoodsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.canGoodsPictureBox.TabIndex = 20;
            this.canGoodsPictureBox.TabStop = false;
            this.canGoodsPictureBox.Click += new System.EventHandler(this.canGoodsPictureBox_Click);
            // 
            // canLabel
            // 
            this.canLabel.AutoSize = true;
            this.canLabel.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.canLabel.Location = new System.Drawing.Point(144, 353);
            this.canLabel.Name = "canLabel";
            this.canLabel.Size = new System.Drawing.Size(196, 32);
            this.canLabel.TabIndex = 23;
            this.canLabel.Text = "Canned Goods";
            // 
            // meatsLabel
            // 
            this.meatsLabel.AutoSize = true;
            this.meatsLabel.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meatsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.meatsLabel.Location = new System.Drawing.Point(553, 353);
            this.meatsLabel.Name = "meatsLabel";
            this.meatsLabel.Size = new System.Drawing.Size(196, 32);
            this.meatsLabel.TabIndex = 24;
            this.meatsLabel.Text = "Fish and Meats";
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.exitButton.Font = new System.Drawing.Font("Bauhaus 93", 10.8F);
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.exitButton.Location = new System.Drawing.Point(471, 633);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(86, 42);
            this.exitButton.TabIndex = 27;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // checkOutButton
            // 
            this.checkOutButton.AutoSize = true;
            this.checkOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.checkOutButton.Font = new System.Drawing.Font("Bauhaus 93", 10.8F);
            this.checkOutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.checkOutButton.Location = new System.Drawing.Point(337, 633);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(106, 42);
            this.checkOutButton.TabIndex = 26;
            this.checkOutButton.Text = "Check&Out";
            this.checkOutButton.UseVisualStyleBackColor = false;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click);
            // 
            // frozenLabel
            // 
            this.frozenLabel.AutoSize = true;
            this.frozenLabel.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frozenLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(143)))), ((int)(((byte)(133)))));
            this.frozenLabel.Location = new System.Drawing.Point(195, 77);
            this.frozenLabel.Name = "frozenLabel";
            this.frozenLabel.Size = new System.Drawing.Size(98, 32);
            this.frozenLabel.TabIndex = 22;
            this.frozenLabel.Text = "Frozen";
            // 
            // categoryTitleLabel
            // 
            this.categoryTitleLabel.AutoSize = true;
            this.categoryTitleLabel.Font = new System.Drawing.Font("Bauhaus 93", 25.8F);
            this.categoryTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.categoryTitleLabel.Location = new System.Drawing.Point(264, 24);
            this.categoryTitleLabel.Name = "categoryTitleLabel";
            this.categoryTitleLabel.Size = new System.Drawing.Size(366, 49);
            this.categoryTitleLabel.TabIndex = 18;
            this.categoryTitleLabel.Text = "Select A Category";
            // 
            // produceLabel
            // 
            this.produceLabel.AutoSize = true;
            this.produceLabel.BackColor = System.Drawing.Color.Transparent;
            this.produceLabel.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(142)))), ((int)(((byte)(68)))));
            this.produceLabel.Location = new System.Drawing.Point(594, 77);
            this.produceLabel.Name = "produceLabel";
            this.produceLabel.Size = new System.Drawing.Size(119, 32);
            this.produceLabel.TabIndex = 25;
            this.produceLabel.Text = "Produce";
            // 
            // CategoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.contentPanel);
            this.Name = "CategoryUserControl";
            this.Size = new System.Drawing.Size(1368, 744);
            this.contentPanel.ResumeLayout(false);
            this.categoryCenterPanel.ResumeLayout(false);
            this.categoryCenterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frozenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meatAndFishPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canGoodsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label canLabel;
        private System.Windows.Forms.Label meatsLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button checkOutButton;
        private System.Windows.Forms.Label frozenLabel;
        private System.Windows.Forms.Label categoryTitleLabel;
        private System.Windows.Forms.Label produceLabel;
        private System.Windows.Forms.PictureBox frozenPictureBox;
        private System.Windows.Forms.PictureBox meatAndFishPictureBox;
        private System.Windows.Forms.PictureBox canGoodsPictureBox;
        private System.Windows.Forms.Panel categoryCenterPanel;
        private System.Windows.Forms.PictureBox producePictureBox;
    }
}
