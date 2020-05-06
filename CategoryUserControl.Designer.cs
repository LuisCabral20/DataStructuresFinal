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
            this.contentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1026, 604);
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
            this.categoryCenterPanel.Location = new System.Drawing.Point(178, 22);
            this.categoryCenterPanel.Margin = new System.Windows.Forms.Padding(2);
            this.categoryCenterPanel.Name = "categoryCenterPanel";
            this.categoryCenterPanel.Size = new System.Drawing.Size(671, 561);
            this.categoryCenterPanel.TabIndex = 17;
            // 
            // frozenPictureBox
            // 
            this.frozenPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("frozenPictureBox.Image")));
            this.frozenPictureBox.Location = new System.Drawing.Point(83, 91);
            this.frozenPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.frozenPictureBox.Name = "frozenPictureBox";
            this.frozenPictureBox.Size = new System.Drawing.Size(197, 184);
            this.frozenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frozenPictureBox.TabIndex = 17;
            this.frozenPictureBox.TabStop = false;
            this.frozenPictureBox.Click += new System.EventHandler(this.FrozenPictureBox_Click);
            // 
            // producePictureBox
            // 
            this.producePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("producePictureBox.Image")));
            this.producePictureBox.Location = new System.Drawing.Point(390, 91);
            this.producePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.producePictureBox.Name = "producePictureBox";
            this.producePictureBox.Size = new System.Drawing.Size(197, 184);
            this.producePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.producePictureBox.TabIndex = 19;
            this.producePictureBox.TabStop = false;
            this.producePictureBox.Click += new System.EventHandler(this.ProducePictureBox_Click);
            // 
            // meatAndFishPictureBox
            // 
            this.meatAndFishPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("meatAndFishPictureBox.Image")));
            this.meatAndFishPictureBox.Location = new System.Drawing.Point(390, 315);
            this.meatAndFishPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.meatAndFishPictureBox.Name = "meatAndFishPictureBox";
            this.meatAndFishPictureBox.Size = new System.Drawing.Size(197, 184);
            this.meatAndFishPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.meatAndFishPictureBox.TabIndex = 21;
            this.meatAndFishPictureBox.TabStop = false;
            this.meatAndFishPictureBox.Click += new System.EventHandler(this.MeatAndFishPictureBox_Click);
            // 
            // canGoodsPictureBox
            // 
            this.canGoodsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("canGoodsPictureBox.Image")));
            this.canGoodsPictureBox.Location = new System.Drawing.Point(83, 315);
            this.canGoodsPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.canGoodsPictureBox.Name = "canGoodsPictureBox";
            this.canGoodsPictureBox.Size = new System.Drawing.Size(197, 184);
            this.canGoodsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.canGoodsPictureBox.TabIndex = 20;
            this.canGoodsPictureBox.TabStop = false;
            this.canGoodsPictureBox.Click += new System.EventHandler(this.CanGoodsPictureBox_Click);
            // 
            // canLabel
            // 
            this.canLabel.AutoSize = true;
            this.canLabel.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.canLabel.Location = new System.Drawing.Point(108, 287);
            this.canLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.canLabel.Name = "canLabel";
            this.canLabel.Size = new System.Drawing.Size(155, 25);
            this.canLabel.TabIndex = 23;
            this.canLabel.Text = "Canned Goods";
            // 
            // meatsLabel
            // 
            this.meatsLabel.AutoSize = true;
            this.meatsLabel.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meatsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.meatsLabel.Location = new System.Drawing.Point(415, 287);
            this.meatsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.meatsLabel.Name = "meatsLabel";
            this.meatsLabel.Size = new System.Drawing.Size(157, 25);
            this.meatsLabel.TabIndex = 24;
            this.meatsLabel.Text = "Fish and Meats";
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.exitButton.Font = new System.Drawing.Font("Bauhaus 93", 10.8F);
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.exitButton.Location = new System.Drawing.Point(353, 514);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(64, 34);
            this.exitButton.TabIndex = 27;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // checkOutButton
            // 
            this.checkOutButton.AutoSize = true;
            this.checkOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.checkOutButton.Font = new System.Drawing.Font("Bauhaus 93", 10.8F);
            this.checkOutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.checkOutButton.Location = new System.Drawing.Point(253, 514);
            this.checkOutButton.Margin = new System.Windows.Forms.Padding(2);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(85, 34);
            this.checkOutButton.TabIndex = 26;
            this.checkOutButton.Text = "Check&Out";
            this.checkOutButton.UseVisualStyleBackColor = false;
            this.checkOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // frozenLabel
            // 
            this.frozenLabel.AutoSize = true;
            this.frozenLabel.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frozenLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(143)))), ((int)(((byte)(133)))));
            this.frozenLabel.Location = new System.Drawing.Point(146, 63);
            this.frozenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.frozenLabel.Name = "frozenLabel";
            this.frozenLabel.Size = new System.Drawing.Size(77, 25);
            this.frozenLabel.TabIndex = 22;
            this.frozenLabel.Text = "Frozen";
            // 
            // categoryTitleLabel
            // 
            this.categoryTitleLabel.AutoSize = true;
            this.categoryTitleLabel.Font = new System.Drawing.Font("Bauhaus 93", 25.8F);
            this.categoryTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.categoryTitleLabel.Location = new System.Drawing.Point(198, 20);
            this.categoryTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryTitleLabel.Name = "categoryTitleLabel";
            this.categoryTitleLabel.Size = new System.Drawing.Size(298, 39);
            this.categoryTitleLabel.TabIndex = 18;
            this.categoryTitleLabel.Text = "Select A Category";
            // 
            // produceLabel
            // 
            this.produceLabel.AutoSize = true;
            this.produceLabel.BackColor = System.Drawing.Color.Transparent;
            this.produceLabel.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(142)))), ((int)(((byte)(68)))));
            this.produceLabel.Location = new System.Drawing.Point(446, 63);
            this.produceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.produceLabel.Name = "produceLabel";
            this.produceLabel.Size = new System.Drawing.Size(92, 25);
            this.produceLabel.TabIndex = 25;
            this.produceLabel.Text = "Produce";
            // 
            // CategoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.contentPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CategoryUserControl";
            this.Size = new System.Drawing.Size(1026, 604);
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
