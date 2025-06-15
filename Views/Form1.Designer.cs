namespace Proekt_magazin
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
            this.components = new System.ComponentModel.Container();
            this.ProdNum = new System.Windows.Forms.Label();
            this.ProdName = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.ProdType = new System.Windows.Forms.Label();
            this.ProdNumtxt = new System.Windows.Forms.TextBox();
            this.ProdNametxt = new System.Windows.Forms.TextBox();
            this.Desctxt = new System.Windows.Forms.TextBox();
            this.Pricetxt = new System.Windows.Forms.TextBox();
            this.ProdTypecmb = new System.Windows.Forms.ComboBox();
            this.fruitTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fruitShopDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fruitShopDataSet = new Proekt_magazin.FruitShopDataSet();
            this.fruitTypesTableAdapter = new Proekt_magazin.FruitShopDataSetTableAdapters.FruitTypesTableAdapter();
            this.Btn_clear = new System.Windows.Forms.Button();
            this.ListBoxProducts = new System.Windows.Forms.ListBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.DeleteListboxData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fruitTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitShopDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitShopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdNum
            // 
            this.ProdNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProdNum.Location = new System.Drawing.Point(70, 41);
            this.ProdNum.Name = "ProdNum";
            this.ProdNum.Size = new System.Drawing.Size(100, 23);
            this.ProdNum.TabIndex = 0;
            this.ProdNum.Text = "Product Number";
            // 
            // ProdName
            // 
            this.ProdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProdName.Location = new System.Drawing.Point(176, 41);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(100, 23);
            this.ProdName.TabIndex = 1;
            this.ProdName.Text = "Product Name";
            // 
            // Description
            // 
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Description.Location = new System.Drawing.Point(282, 41);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(100, 23);
            this.Description.TabIndex = 2;
            this.Description.Text = "Description";
            // 
            // Price
            // 
            this.Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Price.Location = new System.Drawing.Point(388, 41);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 23);
            this.Price.TabIndex = 3;
            this.Price.Text = "Price";
            // 
            // ProdType
            // 
            this.ProdType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProdType.Location = new System.Drawing.Point(494, 41);
            this.ProdType.Name = "ProdType";
            this.ProdType.Size = new System.Drawing.Size(100, 23);
            this.ProdType.TabIndex = 4;
            this.ProdType.Text = "Product Type";
            this.ProdType.Click += new System.EventHandler(this.label5_Click);
            // 
            // ProdNumtxt
            // 
            this.ProdNumtxt.Location = new System.Drawing.Point(70, 67);
            this.ProdNumtxt.Name = "ProdNumtxt";
            this.ProdNumtxt.Size = new System.Drawing.Size(100, 20);
            this.ProdNumtxt.TabIndex = 5;
            // 
            // ProdNametxt
            // 
            this.ProdNametxt.Location = new System.Drawing.Point(176, 67);
            this.ProdNametxt.Name = "ProdNametxt";
            this.ProdNametxt.Size = new System.Drawing.Size(100, 20);
            this.ProdNametxt.TabIndex = 6;
            // 
            // Desctxt
            // 
            this.Desctxt.Location = new System.Drawing.Point(282, 67);
            this.Desctxt.Name = "Desctxt";
            this.Desctxt.Size = new System.Drawing.Size(100, 20);
            this.Desctxt.TabIndex = 7;
            // 
            // Pricetxt
            // 
            this.Pricetxt.Location = new System.Drawing.Point(388, 67);
            this.Pricetxt.Name = "Pricetxt";
            this.Pricetxt.Size = new System.Drawing.Size(100, 20);
            this.Pricetxt.TabIndex = 8;
            // 
            // ProdTypecmb
            // 
            this.ProdTypecmb.DataSource = this.fruitTypesBindingSource;
            this.ProdTypecmb.FormattingEnabled = true;
            this.ProdTypecmb.Location = new System.Drawing.Point(494, 66);
            this.ProdTypecmb.Name = "ProdTypecmb";
            this.ProdTypecmb.Size = new System.Drawing.Size(121, 21);
            this.ProdTypecmb.TabIndex = 10;
            this.ProdTypecmb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // fruitTypesBindingSource
            // 
            this.fruitTypesBindingSource.DataMember = "FruitTypes";
            this.fruitTypesBindingSource.DataSource = this.fruitShopDataSetBindingSource;
            // 
            // fruitShopDataSetBindingSource
            // 
            this.fruitShopDataSetBindingSource.DataSource = this.fruitShopDataSet;
            this.fruitShopDataSetBindingSource.Position = 0;
            // 
            // fruitShopDataSet
            // 
            this.fruitShopDataSet.DataSetName = "FruitShopDataSet";
            this.fruitShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fruitTypesTableAdapter
            // 
            this.fruitTypesTableAdapter.ClearBeforeFill = true;
            // 
            // Btn_clear
            // 
            this.Btn_clear.Location = new System.Drawing.Point(70, 214);
            this.Btn_clear.Name = "Btn_clear";
            this.Btn_clear.Size = new System.Drawing.Size(113, 77);
            this.Btn_clear.TabIndex = 11;
            this.Btn_clear.Text = "Clear";
            this.Btn_clear.UseVisualStyleBackColor = true;
            this.Btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // ListBoxProducts
            // 
            this.ListBoxProducts.FormattingEnabled = true;
            this.ListBoxProducts.Location = new System.Drawing.Point(517, 160);
            this.ListBoxProducts.Name = "ListBoxProducts";
            this.ListBoxProducts.Size = new System.Drawing.Size(143, 121);
            this.ListBoxProducts.TabIndex = 12;
            this.ListBoxProducts.SelectedIndexChanged += new System.EventHandler(this.ListBoxProducts_SelectedIndexChanged);
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Addbtn.Location = new System.Drawing.Point(225, 214);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(114, 76);
            this.Addbtn.TabIndex = 13;
            this.Addbtn.Text = "Add items";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // DeleteListboxData
            // 
            this.DeleteListboxData.Location = new System.Drawing.Point(369, 217);
            this.DeleteListboxData.Name = "DeleteListboxData";
            this.DeleteListboxData.Size = new System.Drawing.Size(119, 74);
            this.DeleteListboxData.TabIndex = 14;
            this.DeleteListboxData.Text = "Delete listbox data";
            this.DeleteListboxData.UseVisualStyleBackColor = true;
            this.DeleteListboxData.Click += new System.EventHandler(this.DeleteListboxData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteListboxData);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.ListBoxProducts);
            this.Controls.Add(this.Btn_clear);
            this.Controls.Add(this.ProdTypecmb);
            this.Controls.Add(this.Pricetxt);
            this.Controls.Add(this.Desctxt);
            this.Controls.Add(this.ProdNametxt);
            this.Controls.Add(this.ProdNumtxt);
            this.Controls.Add(this.ProdType);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.ProdName);
            this.Controls.Add(this.ProdNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fruitTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitShopDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitShopDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProdNum;
        private System.Windows.Forms.Label ProdName;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label ProdType;
        private System.Windows.Forms.TextBox ProdNumtxt;
        private System.Windows.Forms.TextBox ProdNametxt;
        private System.Windows.Forms.TextBox Desctxt;
        private System.Windows.Forms.TextBox Pricetxt;
        private System.Windows.Forms.ComboBox ProdTypecmb;
        private System.Windows.Forms.BindingSource fruitShopDataSetBindingSource;
        private FruitShopDataSet fruitShopDataSet;
        private System.Windows.Forms.BindingSource fruitTypesBindingSource;
        private FruitShopDataSetTableAdapters.FruitTypesTableAdapter fruitTypesTableAdapter;
        private System.Windows.Forms.Button Btn_clear;
        private System.Windows.Forms.ListBox ListBoxProducts;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button DeleteListboxData;
    }
}

