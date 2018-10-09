namespace WindowsFormsApplication1
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
            this.itemTextbox = new System.Windows.Forms.TextBox();
            this.priceTextbox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.totalButton = new System.Windows.Forms.Button();
            this.typesOfItemLabel = new System.Windows.Forms.Label();
            this.receiptListbox = new System.Windows.Forms.ListBox();
            this.itemListbox = new System.Windows.Forms.ListBox();
            this.priceListbox = new System.Windows.Forms.ListBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.receiptPriceListbox = new System.Windows.Forms.ListBox();
            this.taxExemptedItemCheckbox = new System.Windows.Forms.CheckBox();
            this.ImportedCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item";
            // 
            // itemTextbox
            // 
            this.itemTextbox.Location = new System.Drawing.Point(13, 73);
            this.itemTextbox.Name = "itemTextbox";
            this.itemTextbox.Size = new System.Drawing.Size(173, 26);
            this.itemTextbox.TabIndex = 1;
            // 
            // priceTextbox
            // 
            this.priceTextbox.Location = new System.Drawing.Point(269, 73);
            this.priceTextbox.Name = "priceTextbox";
            this.priceTextbox.Size = new System.Drawing.Size(159, 26);
            this.priceTextbox.TabIndex = 2;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(276, 33);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(44, 20);
            this.PriceLabel.TabIndex = 3;
            this.PriceLabel.Text = "Price";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(463, 73);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(117, 37);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(606, 73);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(103, 37);
            this.totalButton.TabIndex = 7;
            this.totalButton.Text = "Total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // typesOfItemLabel
            // 
            this.typesOfItemLabel.AutoSize = true;
            this.typesOfItemLabel.Location = new System.Drawing.Point(12, 118);
            this.typesOfItemLabel.Name = "typesOfItemLabel";
            this.typesOfItemLabel.Size = new System.Drawing.Size(105, 20);
            this.typesOfItemLabel.TabIndex = 9;
            this.typesOfItemLabel.Text = "Types of Item";
            // 
            // receiptListbox
            // 
            this.receiptListbox.FormattingEnabled = true;
            this.receiptListbox.ItemHeight = 20;
            this.receiptListbox.Location = new System.Drawing.Point(463, 256);
            this.receiptListbox.Name = "receiptListbox";
            this.receiptListbox.Size = new System.Drawing.Size(175, 404);
            this.receiptListbox.TabIndex = 10;
            // 
            // itemListbox
            // 
            this.itemListbox.FormattingEnabled = true;
            this.itemListbox.ItemHeight = 20;
            this.itemListbox.Location = new System.Drawing.Point(12, 266);
            this.itemListbox.Name = "itemListbox";
            this.itemListbox.Size = new System.Drawing.Size(174, 384);
            this.itemListbox.TabIndex = 11;
            // 
            // priceListbox
            // 
            this.priceListbox.FormattingEnabled = true;
            this.priceListbox.ItemHeight = 20;
            this.priceListbox.Location = new System.Drawing.Point(182, 266);
            this.priceListbox.Name = "priceListbox";
            this.priceListbox.Size = new System.Drawing.Size(174, 384);
            this.priceListbox.TabIndex = 12;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(728, 73);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(103, 37);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // receiptPriceListbox
            // 
            this.receiptPriceListbox.FormattingEnabled = true;
            this.receiptPriceListbox.ItemHeight = 20;
            this.receiptPriceListbox.Location = new System.Drawing.Point(634, 256);
            this.receiptPriceListbox.Name = "receiptPriceListbox";
            this.receiptPriceListbox.Size = new System.Drawing.Size(175, 404);
            this.receiptPriceListbox.TabIndex = 14;
            // 
            // taxExemptedItemCheckbox
            // 
            this.taxExemptedItemCheckbox.AutoSize = true;
            this.taxExemptedItemCheckbox.Location = new System.Drawing.Point(16, 157);
            this.taxExemptedItemCheckbox.Name = "taxExemptedItemCheckbox";
            this.taxExemptedItemCheckbox.Size = new System.Drawing.Size(180, 24);
            this.taxExemptedItemCheckbox.TabIndex = 15;
            this.taxExemptedItemCheckbox.Text = "Tax Exempted Items";
            this.taxExemptedItemCheckbox.UseVisualStyleBackColor = true;
            // 
            // ImportedCheckbox
            // 
            this.ImportedCheckbox.AutoSize = true;
            this.ImportedCheckbox.Location = new System.Drawing.Point(16, 187);
            this.ImportedCheckbox.Name = "ImportedCheckbox";
            this.ImportedCheckbox.Size = new System.Drawing.Size(135, 24);
            this.ImportedCheckbox.TabIndex = 16;
            this.ImportedCheckbox.Text = "Imported Item";
            this.ImportedCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 762);
            this.Controls.Add(this.ImportedCheckbox);
            this.Controls.Add(this.taxExemptedItemCheckbox);
            this.Controls.Add(this.receiptPriceListbox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.priceListbox);
            this.Controls.Add(this.itemListbox);
            this.Controls.Add(this.receiptListbox);
            this.Controls.Add(this.typesOfItemLabel);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.priceTextbox);
            this.Controls.Add(this.itemTextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemTextbox;
        private System.Windows.Forms.TextBox priceTextbox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label typesOfItemLabel;
        private System.Windows.Forms.ListBox receiptListbox;
        private System.Windows.Forms.ListBox itemListbox;
        private System.Windows.Forms.ListBox priceListbox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ListBox receiptPriceListbox;
        private System.Windows.Forms.CheckBox taxExemptedItemCheckbox;
        private System.Windows.Forms.CheckBox ImportedCheckbox;
    }
}

