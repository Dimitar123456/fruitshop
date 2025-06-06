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
            this.button1 = new System.Windows.Forms.Button();
            this.fruitShopDataSet = new Proekt_magazin.FruitShopDataSet();
            this.fruitShopDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fruitTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fruitTypesTableAdapter = new Proekt_magazin.FruitShopDataSetTableAdapters.FruitTypesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fruitShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitShopDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitTypesBindingSource)).BeginInit();
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
            this.ProdTypecmb.DisplayMember = "TypeName";
            this.ProdTypecmb.FormattingEnabled = true;
            this.ProdTypecmb.Location = new System.Drawing.Point(494, 66);
            this.ProdTypecmb.Name = "ProdTypecmb";
            this.ProdTypecmb.Size = new System.Drawing.Size(121, 21);
            this.ProdTypecmb.TabIndex = 10;
            this.ProdTypecmb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fruitShopDataSet
            // 
            this.fruitShopDataSet.DataSetName = "FruitShopDataSet";
            this.fruitShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fruitShopDataSetBindingSource
            // 
            this.fruitShopDataSetBindingSource.DataSource = this.fruitShopDataSet;
            this.fruitShopDataSetBindingSource.Position = 0;
            // 
            // fruitTypesBindingSource
            // 
            this.fruitTypesBindingSource.DataMember = "FruitTypes";
            this.fruitTypesBindingSource.DataSource = this.fruitShopDataSetBindingSource;
            // 
            // fruitTypesTableAdapter
            // 
            this.fruitTypesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
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
            ((System.ComponentModel.ISupportInitialize)(this.fruitShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitShopDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitTypesBindingSource)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource fruitShopDataSetBindingSource;
        private FruitShopDataSet fruitShopDataSet;
        private System.Windows.Forms.BindingSource fruitTypesBindingSource;
        private FruitShopDataSetTableAdapters.FruitTypesTableAdapter fruitTypesTableAdapter;
    }
}

