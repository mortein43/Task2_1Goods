namespace Task2_1Goods
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonConnect = new Button();
            buttonDisconnect = new Button();
            dataGridView1 = new DataGridView();
            AllInfo = new RadioButton();
            AllTypes = new RadioButton();
            AllSuppliers = new RadioButton();
            MaxQuantity = new RadioButton();
            MinQuantity = new RadioButton();
            MinCostPrice = new RadioButton();
            MaxCostPrice = new RadioButton();
            comboBoxTypes = new ComboBox();
            ShowGoodsThisCategory = new RadioButton();
            comboBoxSuppliers = new ComboBox();
            ShowGoodsThisSupplier = new RadioButton();
            GoodsOld = new RadioButton();
            AverageByType = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(12, 12);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(101, 23);
            buttonConnect.TabIndex = 0;
            buttonConnect.Text = "Підключитися";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += ButtonConnect_Click;
            // 
            // buttonDisconnect
            // 
            buttonDisconnect.Location = new Point(119, 12);
            buttonDisconnect.Name = "buttonDisconnect";
            buttonDisconnect.Size = new Size(97, 23);
            buttonDisconnect.TabIndex = 1;
            buttonDisconnect.Text = "Відключитися";
            buttonDisconnect.UseVisualStyleBackColor = true;
            buttonDisconnect.Click += ButtonDisconnect_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(807, 290);
            dataGridView1.TabIndex = 2;
            // 
            // AllInfo
            // 
            AllInfo.AutoSize = true;
            AllInfo.Checked = true;
            AllInfo.Location = new Point(12, 40);
            AllInfo.Name = "AllInfo";
            AllInfo.Size = new Size(111, 19);
            AllInfo.TabIndex = 3;
            AllInfo.TabStop = true;
            AllInfo.Text = "Вся інформація";
            AllInfo.UseVisualStyleBackColor = true;
            AllInfo.CheckedChanged += AllInfo_CheckedChanged;
            // 
            // AllTypes
            // 
            AllTypes.AutoSize = true;
            AllTypes.Location = new Point(12, 65);
            AllTypes.Name = "AllTypes";
            AllTypes.Size = new Size(113, 19);
            AllTypes.TabIndex = 4;
            AllTypes.TabStop = true;
            AllTypes.Text = "Всі типи товарів";
            AllTypes.UseVisualStyleBackColor = true;
            AllTypes.CheckedChanged += AllTypes_CheckedChanged;
            // 
            // AllSuppliers
            // 
            AllSuppliers.AutoSize = true;
            AllSuppliers.Location = new Point(12, 90);
            AllSuppliers.Name = "AllSuppliers";
            AllSuppliers.Size = new Size(159, 19);
            AllSuppliers.TabIndex = 5;
            AllSuppliers.TabStop = true;
            AllSuppliers.Text = "Всі види постачальників";
            AllSuppliers.UseVisualStyleBackColor = true;
            AllSuppliers.CheckedChanged += AllSuppliers_CheckedChanged;
            // 
            // MaxQuantity
            // 
            MaxQuantity.AutoSize = true;
            MaxQuantity.Location = new Point(12, 115);
            MaxQuantity.Name = "MaxQuantity";
            MaxQuantity.Size = new Size(153, 19);
            MaxQuantity.TabIndex = 6;
            MaxQuantity.TabStop = true;
            MaxQuantity.Text = "Максимальна кількість";
            MaxQuantity.UseVisualStyleBackColor = true;
            MaxQuantity.CheckedChanged += MaxQuantity_CheckedChanged;
            // 
            // MinQuantity
            // 
            MinQuantity.AutoSize = true;
            MinQuantity.Location = new Point(12, 138);
            MinQuantity.Name = "MinQuantity";
            MinQuantity.Size = new Size(141, 19);
            MinQuantity.TabIndex = 7;
            MinQuantity.TabStop = true;
            MinQuantity.Text = "Мінімальна кількість";
            MinQuantity.UseVisualStyleBackColor = true;
            MinQuantity.CheckedChanged += MinQuantity_CheckedChanged;
            // 
            // MinCostPrice
            // 
            MinCostPrice.AutoSize = true;
            MinCostPrice.Location = new Point(202, 40);
            MinCostPrice.Name = "MinCostPrice";
            MinCostPrice.Size = new Size(160, 19);
            MinCostPrice.TabIndex = 8;
            MinCostPrice.TabStop = true;
            MinCostPrice.Text = "Мінімальна собівартість";
            MinCostPrice.UseVisualStyleBackColor = true;
            MinCostPrice.CheckedChanged += MinCostPrice_CheckedChanged;
            // 
            // MaxCostPrice
            // 
            MaxCostPrice.AutoSize = true;
            MaxCostPrice.Location = new Point(202, 65);
            MaxCostPrice.Name = "MaxCostPrice";
            MaxCostPrice.Size = new Size(172, 19);
            MaxCostPrice.TabIndex = 9;
            MaxCostPrice.TabStop = true;
            MaxCostPrice.Text = "Максимальна собівартість";
            MaxCostPrice.UseVisualStyleBackColor = true;
            MaxCostPrice.CheckedChanged += MaxCostPrice_CheckedChanged;
            // 
            // comboBoxTypes
            // 
            comboBoxTypes.FormattingEnabled = true;
            comboBoxTypes.Items.AddRange(new object[] { "Ноутбук", "Планшет", "Монітор" });
            comboBoxTypes.Location = new Point(426, 36);
            comboBoxTypes.Name = "comboBoxTypes";
            comboBoxTypes.Size = new Size(121, 23);
            comboBoxTypes.TabIndex = 10;
            comboBoxTypes.SelectedIndexChanged += ShowGoodsThisCategory_CheckedChanged;
            // 
            // ShowGoodsThisCategory
            // 
            ShowGoodsThisCategory.AutoSize = true;
            ShowGoodsThisCategory.Location = new Point(553, 37);
            ShowGoodsThisCategory.Name = "ShowGoodsThisCategory";
            ShowGoodsThisCategory.Size = new Size(190, 19);
            ShowGoodsThisCategory.TabIndex = 11;
            ShowGoodsThisCategory.TabStop = true;
            ShowGoodsThisCategory.Text = "Показати товари цієї категорії";
            ShowGoodsThisCategory.UseVisualStyleBackColor = true;
            ShowGoodsThisCategory.CheckedChanged += ShowGoodsThisCategory_CheckedChanged_1;
            // 
            // comboBoxSuppliers
            // 
            comboBoxSuppliers.FormattingEnabled = true;
            comboBoxSuppliers.Items.AddRange(new object[] { "Sumsung", "Dell", "Lenovo" });
            comboBoxSuppliers.Location = new Point(426, 65);
            comboBoxSuppliers.Name = "comboBoxSuppliers";
            comboBoxSuppliers.Size = new Size(121, 23);
            comboBoxSuppliers.TabIndex = 12;
            comboBoxSuppliers.SelectedIndexChanged += ShowGoodsThisSupplier_CheckedChanged;
            // 
            // ShowGoodsThisSupplier
            // 
            ShowGoodsThisSupplier.AutoSize = true;
            ShowGoodsThisSupplier.Location = new Point(553, 66);
            ShowGoodsThisSupplier.Name = "ShowGoodsThisSupplier";
            ShowGoodsThisSupplier.Size = new Size(255, 19);
            ShowGoodsThisSupplier.TabIndex = 13;
            ShowGoodsThisSupplier.TabStop = true;
            ShowGoodsThisSupplier.Text = "Показати товари заданого постачальника";
            ShowGoodsThisSupplier.UseVisualStyleBackColor = true;
            ShowGoodsThisSupplier.CheckedChanged += ShowGoodsThisSupplier_CheckedChanged;
            // 
            // GoodsOld
            // 
            GoodsOld.AutoSize = true;
            GoodsOld.Location = new Point(202, 90);
            GoodsOld.Name = "GoodsOld";
            GoodsOld.Size = new Size(215, 19);
            GoodsOld.TabIndex = 14;
            GoodsOld.TabStop = true;
            GoodsOld.Text = "Товар який знаходиться найдовше";
            GoodsOld.UseVisualStyleBackColor = true;
            GoodsOld.CheckedChanged += GoodsOld_CheckedChanged;
            // 
            // AverageByType
            // 
            AverageByType.AutoSize = true;
            AverageByType.Location = new Point(202, 115);
            AverageByType.Name = "AverageByType";
            AverageByType.Size = new Size(261, 19);
            AverageByType.TabIndex = 15;
            AverageByType.TabStop = true;
            AverageByType.Text = "Середня кількість товару по кожному типу";
            AverageByType.UseVisualStyleBackColor = true;
            AverageByType.CheckedChanged += AverageByType_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 450);
            Controls.Add(AverageByType);
            Controls.Add(GoodsOld);
            Controls.Add(ShowGoodsThisSupplier);
            Controls.Add(comboBoxSuppliers);
            Controls.Add(ShowGoodsThisCategory);
            Controls.Add(comboBoxTypes);
            Controls.Add(MaxCostPrice);
            Controls.Add(MinCostPrice);
            Controls.Add(MinQuantity);
            Controls.Add(MaxQuantity);
            Controls.Add(AllSuppliers);
            Controls.Add(AllTypes);
            Controls.Add(AllInfo);
            Controls.Add(dataGridView1);
            Controls.Add(buttonDisconnect);
            Controls.Add(buttonConnect);
            Name = "Form1";
            Text = "Товари";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonConnect;
        private Button buttonDisconnect;
        private DataGridView dataGridView1;
        private RadioButton AllInfo;
        private RadioButton AllTypes;
        private RadioButton AllSuppliers;
        private RadioButton MaxQuantity;
        private RadioButton MinQuantity;
        private RadioButton MinCostPrice;
        private RadioButton MaxCostPrice;
        private ComboBox comboBoxTypes;
        private RadioButton ShowGoodsThisCategory;
        private ComboBox comboBoxSuppliers;
        private RadioButton ShowGoodsThisSupplier;
        private RadioButton GoodsOld;
        private RadioButton AverageByType;
    }
}
