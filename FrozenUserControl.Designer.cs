namespace DataStructuresFinal
{
    partial class FrozenUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrozenUserControl));
            this.contentPanel = new System.Windows.Forms.Panel();
            this.frozenCenterPanel = new System.Windows.Forms.Panel();
            this.returnButton = new System.Windows.Forms.Button();
            this.iceCreamGroupBox = new System.Windows.Forms.GroupBox();
            this.iceCreamStocklabel = new System.Windows.Forms.Label();
            this.iceCreamPictureBox = new System.Windows.Forms.PictureBox();
            this.iceCreamBuyButton = new System.Windows.Forms.Button();
            this.frozenChickenDinnerGroupBox = new System.Windows.Forms.GroupBox();
            this.frozenChickenDinnerLabel = new System.Windows.Forms.Label();
            this.frozenChickenDinnerPictureBox = new System.Windows.Forms.PictureBox();
            this.frozenChickenDinnerBuyButton = new System.Windows.Forms.Button();
            this.pizzaGroupBox = new System.Windows.Forms.GroupBox();
            this.frozzenPizzaStockLabel = new System.Windows.Forms.Label();
            this.frozenPizzaPictureBox = new System.Windows.Forms.PictureBox();
            this.frozzenPizzaBuyButton = new System.Windows.Forms.Button();
            this.FrozenTitleLabel = new System.Windows.Forms.Label();
            this.contentPanel.SuspendLayout();
            this.frozenCenterPanel.SuspendLayout();
            this.iceCreamGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iceCreamPictureBox)).BeginInit();
            this.frozenChickenDinnerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frozenChickenDinnerPictureBox)).BeginInit();
            this.pizzaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frozenPizzaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.contentPanel.Controls.Add(this.frozenCenterPanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1368, 744);
            this.contentPanel.TabIndex = 13;
            // 
            // frozenCenterPanel
            // 
            this.frozenCenterPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.frozenCenterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.frozenCenterPanel.Controls.Add(this.returnButton);
            this.frozenCenterPanel.Controls.Add(this.iceCreamGroupBox);
            this.frozenCenterPanel.Controls.Add(this.frozenChickenDinnerGroupBox);
            this.frozenCenterPanel.Controls.Add(this.pizzaGroupBox);
            this.frozenCenterPanel.Controls.Add(this.FrozenTitleLabel);
            this.frozenCenterPanel.Location = new System.Drawing.Point(163, 37);
            this.frozenCenterPanel.Name = "frozenCenterPanel";
            this.frozenCenterPanel.Size = new System.Drawing.Size(1043, 671);
            this.frozenCenterPanel.TabIndex = 18;
            // 
            // returnButton
            // 
            this.returnButton.AutoSize = true;
            this.returnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.returnButton.Font = new System.Drawing.Font("Bauhaus 93", 10.8F);
            this.returnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.returnButton.Location = new System.Drawing.Point(468, 588);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(106, 42);
            this.returnButton.TabIndex = 27;
            this.returnButton.Text = "&Return";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // iceCreamGroupBox
            // 
            this.iceCreamGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.iceCreamGroupBox.Controls.Add(this.iceCreamStocklabel);
            this.iceCreamGroupBox.Controls.Add(this.iceCreamPictureBox);
            this.iceCreamGroupBox.Controls.Add(this.iceCreamBuyButton);
            this.iceCreamGroupBox.Font = new System.Drawing.Font("Bauhaus 93", 10.8F);
            this.iceCreamGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.iceCreamGroupBox.Location = new System.Drawing.Point(730, 198);
            this.iceCreamGroupBox.Name = "iceCreamGroupBox";
            this.iceCreamGroupBox.Size = new System.Drawing.Size(284, 277);
            this.iceCreamGroupBox.TabIndex = 22;
            this.iceCreamGroupBox.TabStop = false;
            this.iceCreamGroupBox.Text = "Ice Cream";
            // 
            // iceCreamStocklabel
            // 
            this.iceCreamStocklabel.AutoSize = true;
            this.iceCreamStocklabel.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.iceCreamStocklabel.Location = new System.Drawing.Point(11, 238);
            this.iceCreamStocklabel.Name = "iceCreamStocklabel";
            this.iceCreamStocklabel.Size = new System.Drawing.Size(93, 23);
            this.iceCreamStocklabel.TabIndex = 12;
            this.iceCreamStocklabel.Text = "Stock: 10";
            // 
            // iceCreamPictureBox
            // 
            this.iceCreamPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("iceCreamPictureBox.Image")));
            this.iceCreamPictureBox.Location = new System.Drawing.Point(15, 21);
            this.iceCreamPictureBox.Name = "iceCreamPictureBox";
            this.iceCreamPictureBox.Size = new System.Drawing.Size(254, 205);
            this.iceCreamPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iceCreamPictureBox.TabIndex = 11;
            this.iceCreamPictureBox.TabStop = false;
            // 
            // iceCreamBuyButton
            // 
            this.iceCreamBuyButton.AutoSize = true;
            this.iceCreamBuyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iceCreamBuyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.iceCreamBuyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iceCreamBuyButton.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iceCreamBuyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.iceCreamBuyButton.Image = ((System.Drawing.Image)(resources.GetObject("iceCreamBuyButton.Image")));
            this.iceCreamBuyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iceCreamBuyButton.Location = new System.Drawing.Point(125, 232);
            this.iceCreamBuyButton.Name = "iceCreamBuyButton";
            this.iceCreamBuyButton.Size = new System.Drawing.Size(120, 34);
            this.iceCreamBuyButton.TabIndex = 10;
            this.iceCreamBuyButton.Text = "Add to cart";
            this.iceCreamBuyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iceCreamBuyButton.UseVisualStyleBackColor = false;
            // 
            // frozenChickenDinnerGroupBox
            // 
            this.frozenChickenDinnerGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.frozenChickenDinnerGroupBox.Controls.Add(this.frozenChickenDinnerLabel);
            this.frozenChickenDinnerGroupBox.Controls.Add(this.frozenChickenDinnerPictureBox);
            this.frozenChickenDinnerGroupBox.Controls.Add(this.frozenChickenDinnerBuyButton);
            this.frozenChickenDinnerGroupBox.Font = new System.Drawing.Font("Bauhaus 93", 10.8F);
            this.frozenChickenDinnerGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.frozenChickenDinnerGroupBox.Location = new System.Drawing.Point(379, 198);
            this.frozenChickenDinnerGroupBox.Name = "frozenChickenDinnerGroupBox";
            this.frozenChickenDinnerGroupBox.Size = new System.Drawing.Size(284, 277);
            this.frozenChickenDinnerGroupBox.TabIndex = 21;
            this.frozenChickenDinnerGroupBox.TabStop = false;
            this.frozenChickenDinnerGroupBox.Text = "Chicken Dinner";
            // 
            // frozenChickenDinnerLabel
            // 
            this.frozenChickenDinnerLabel.AutoSize = true;
            this.frozenChickenDinnerLabel.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.frozenChickenDinnerLabel.Location = new System.Drawing.Point(11, 238);
            this.frozenChickenDinnerLabel.Name = "frozenChickenDinnerLabel";
            this.frozenChickenDinnerLabel.Size = new System.Drawing.Size(93, 23);
            this.frozenChickenDinnerLabel.TabIndex = 12;
            this.frozenChickenDinnerLabel.Text = "Stock: 10";
            // 
            // frozenChickenDinnerPictureBox
            // 
            this.frozenChickenDinnerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("frozenChickenDinnerPictureBox.Image")));
            this.frozenChickenDinnerPictureBox.Location = new System.Drawing.Point(15, 21);
            this.frozenChickenDinnerPictureBox.Name = "frozenChickenDinnerPictureBox";
            this.frozenChickenDinnerPictureBox.Size = new System.Drawing.Size(254, 205);
            this.frozenChickenDinnerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frozenChickenDinnerPictureBox.TabIndex = 11;
            this.frozenChickenDinnerPictureBox.TabStop = false;
            // 
            // frozenChickenDinnerBuyButton
            // 
            this.frozenChickenDinnerBuyButton.AutoSize = true;
            this.frozenChickenDinnerBuyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.frozenChickenDinnerBuyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.frozenChickenDinnerBuyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frozenChickenDinnerBuyButton.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frozenChickenDinnerBuyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.frozenChickenDinnerBuyButton.Image = ((System.Drawing.Image)(resources.GetObject("frozenChickenDinnerBuyButton.Image")));
            this.frozenChickenDinnerBuyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.frozenChickenDinnerBuyButton.Location = new System.Drawing.Point(125, 232);
            this.frozenChickenDinnerBuyButton.Name = "frozenChickenDinnerBuyButton";
            this.frozenChickenDinnerBuyButton.Size = new System.Drawing.Size(120, 34);
            this.frozenChickenDinnerBuyButton.TabIndex = 10;
            this.frozenChickenDinnerBuyButton.Text = "Add to cart";
            this.frozenChickenDinnerBuyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.frozenChickenDinnerBuyButton.UseVisualStyleBackColor = false;
            // 
            // pizzaGroupBox
            // 
            this.pizzaGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.pizzaGroupBox.Controls.Add(this.frozzenPizzaStockLabel);
            this.pizzaGroupBox.Controls.Add(this.frozenPizzaPictureBox);
            this.pizzaGroupBox.Controls.Add(this.frozzenPizzaBuyButton);
            this.pizzaGroupBox.Font = new System.Drawing.Font("Bauhaus 93", 10.8F);
            this.pizzaGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.pizzaGroupBox.Location = new System.Drawing.Point(29, 198);
            this.pizzaGroupBox.Name = "pizzaGroupBox";
            this.pizzaGroupBox.Size = new System.Drawing.Size(284, 277);
            this.pizzaGroupBox.TabIndex = 20;
            this.pizzaGroupBox.TabStop = false;
            this.pizzaGroupBox.Text = "Pizza";
            // 
            // frozzenPizzaStockLabel
            // 
            this.frozzenPizzaStockLabel.AutoSize = true;
            this.frozzenPizzaStockLabel.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.frozzenPizzaStockLabel.Location = new System.Drawing.Point(11, 235);
            this.frozzenPizzaStockLabel.Name = "frozzenPizzaStockLabel";
            this.frozzenPizzaStockLabel.Size = new System.Drawing.Size(93, 23);
            this.frozzenPizzaStockLabel.TabIndex = 12;
            this.frozzenPizzaStockLabel.Text = "Stock: 10";
            // 
            // frozenPizzaPictureBox
            // 
            this.frozenPizzaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("frozenPizzaPictureBox.Image")));
            this.frozenPizzaPictureBox.Location = new System.Drawing.Point(15, 21);
            this.frozenPizzaPictureBox.Name = "frozenPizzaPictureBox";
            this.frozenPizzaPictureBox.Size = new System.Drawing.Size(254, 205);
            this.frozenPizzaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frozenPizzaPictureBox.TabIndex = 11;
            this.frozenPizzaPictureBox.TabStop = false;
            // 
            // frozzenPizzaBuyButton
            // 
            this.frozzenPizzaBuyButton.AutoSize = true;
            this.frozzenPizzaBuyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.frozzenPizzaBuyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.frozzenPizzaBuyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.frozzenPizzaBuyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frozzenPizzaBuyButton.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frozzenPizzaBuyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.frozzenPizzaBuyButton.Image = ((System.Drawing.Image)(resources.GetObject("frozzenPizzaBuyButton.Image")));
            this.frozzenPizzaBuyButton.Location = new System.Drawing.Point(130, 232);
            this.frozzenPizzaBuyButton.Name = "frozzenPizzaBuyButton";
            this.frozzenPizzaBuyButton.Size = new System.Drawing.Size(120, 34);
            this.frozzenPizzaBuyButton.TabIndex = 10;
            this.frozzenPizzaBuyButton.Text = "Add to cart";
            this.frozzenPizzaBuyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.frozzenPizzaBuyButton.UseVisualStyleBackColor = false;
            // 
            // FrozenTitleLabel
            // 
            this.FrozenTitleLabel.AutoSize = true;
            this.FrozenTitleLabel.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrozenTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.FrozenTitleLabel.Location = new System.Drawing.Point(334, 40);
            this.FrozenTitleLabel.Name = "FrozenTitleLabel";
            this.FrozenTitleLabel.Size = new System.Drawing.Size(375, 68);
            this.FrozenTitleLabel.TabIndex = 18;
            this.FrozenTitleLabel.Text = "Frozen Foods";
            // 
            // FrozenUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contentPanel);
            this.Name = "FrozenUserControl";
            this.Size = new System.Drawing.Size(1368, 744);
            this.contentPanel.ResumeLayout(false);
            this.frozenCenterPanel.ResumeLayout(false);
            this.frozenCenterPanel.PerformLayout();
            this.iceCreamGroupBox.ResumeLayout(false);
            this.iceCreamGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iceCreamPictureBox)).EndInit();
            this.frozenChickenDinnerGroupBox.ResumeLayout(false);
            this.frozenChickenDinnerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frozenChickenDinnerPictureBox)).EndInit();
            this.pizzaGroupBox.ResumeLayout(false);
            this.pizzaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frozenPizzaPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel frozenCenterPanel;
        private System.Windows.Forms.GroupBox iceCreamGroupBox;
        private System.Windows.Forms.Label iceCreamStocklabel;
        private System.Windows.Forms.PictureBox iceCreamPictureBox;
        private System.Windows.Forms.Button iceCreamBuyButton;
        private System.Windows.Forms.GroupBox frozenChickenDinnerGroupBox;
        private System.Windows.Forms.Label frozenChickenDinnerLabel;
        private System.Windows.Forms.PictureBox frozenChickenDinnerPictureBox;
        private System.Windows.Forms.Button frozenChickenDinnerBuyButton;
        private System.Windows.Forms.GroupBox pizzaGroupBox;
        private System.Windows.Forms.Label frozzenPizzaStockLabel;
        private System.Windows.Forms.PictureBox frozenPizzaPictureBox;
        private System.Windows.Forms.Button frozzenPizzaBuyButton;
        private System.Windows.Forms.Label FrozenTitleLabel;
        private System.Windows.Forms.Button returnButton;
    }
}
