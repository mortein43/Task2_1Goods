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
            textBoxAddType = new TextBox();
            buttonAddType = new Button();
            textBoxAddSupplier = new TextBox();
            buttonAddSupplier = new Button();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            ProductName = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numericUpDown4 = new NumericUpDown();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            buttonAddProduct = new Button();
            label6 = new Label();
            textBoxChangeTypeName = new TextBox();
            buttonChangeType = new Button();
            textBoxChangeSupplierName = new TextBox();
            buttonChangeSupplier = new Button();
            textBoxChangeNameProduct = new TextBox();
            numericProductChangeIdType = new NumericUpDown();
            numericProductChangeIdSupplier = new NumericUpDown();
            numericProductChangeIdQuantity = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            numericProductChangeCostPrice = new NumericUpDown();
            label11 = new Label();
            textBoxProductChangeSupplyDate = new TextBox();
            label12 = new Label();
            buttonUpdateProduct = new Button();
            label13 = new Label();
            numericChangeType = new NumericUpDown();
            numericChangeSupplier = new NumericUpDown();
            numericUpDownChooseId = new NumericUpDown();
            label14 = new Label();
            label15 = new Label();
            numericDeleteProduct = new NumericUpDown();
            label16 = new Label();
            buttonDeleteProduct = new Button();
            numericDeleteType = new NumericUpDown();
            numericDeleteSupplier = new NumericUpDown();
            buttonDeleteType = new Button();
            buttonDeleteSupplier = new Button();
            label17 = new Label();
            label18 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            numericNumberOfDays = new NumericUpDown();
            radioButton5 = new RadioButton();
            label19 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericProductChangeIdType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericProductChangeIdSupplier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericProductChangeIdQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericProductChangeCostPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericChangeType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericChangeSupplier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownChooseId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDeleteProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDeleteType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDeleteSupplier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericNumberOfDays).BeginInit();
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
            dataGridView1.Location = new Point(0, 514);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1221, 290);
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
            // textBoxAddType
            // 
            textBoxAddType.Location = new Point(12, 187);
            textBoxAddType.Name = "textBoxAddType";
            textBoxAddType.PlaceholderText = "Назва типу";
            textBoxAddType.Size = new Size(100, 23);
            textBoxAddType.TabIndex = 16;
            // 
            // buttonAddType
            // 
            buttonAddType.Location = new Point(119, 187);
            buttonAddType.Name = "buttonAddType";
            buttonAddType.Size = new Size(157, 23);
            buttonAddType.TabIndex = 17;
            buttonAddType.Text = "Додати новий тип товару";
            buttonAddType.UseVisualStyleBackColor = true;
            buttonAddType.Click += ButtonAddType_Click;
            // 
            // textBoxAddSupplier
            // 
            textBoxAddSupplier.Location = new Point(12, 216);
            textBoxAddSupplier.Name = "textBoxAddSupplier";
            textBoxAddSupplier.PlaceholderText = "Назва постачальника";
            textBoxAddSupplier.Size = new Size(132, 23);
            textBoxAddSupplier.TabIndex = 18;
            // 
            // buttonAddSupplier
            // 
            buttonAddSupplier.Location = new Point(150, 215);
            buttonAddSupplier.Name = "buttonAddSupplier";
            buttonAddSupplier.Size = new Size(195, 23);
            buttonAddSupplier.TabIndex = 19;
            buttonAddSupplier.Text = "Додати нового постачальника";
            buttonAddSupplier.UseVisualStyleBackColor = true;
            buttonAddSupplier.Click += ButtonAddSupplier_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 262);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Назва продукту";
            textBox1.Size = new Size(153, 23);
            textBox1.TabIndex = 20;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(171, 262);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(45, 23);
            numericUpDown1.TabIndex = 21;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(240, 262);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(36, 23);
            numericUpDown2.TabIndex = 22;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(349, 263);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(59, 23);
            numericUpDown3.TabIndex = 23;
            numericUpDown3.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ProductName
            // 
            ProductName.AutoSize = true;
            ProductName.Location = new Point(12, 244);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(95, 15);
            ProductName.TabIndex = 24;
            ProductName.Text = "Назва продукту:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 242);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 25;
            label1.Text = "ID типу:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 241);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 26;
            label2.Text = "ID Постачальника:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(348, 244);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 27;
            label3.Text = "Кількість:";
            // 
            // numericUpDown4
            // 
            numericUpDown4.DecimalPlaces = 2;
            numericUpDown4.Location = new Point(427, 262);
            numericUpDown4.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDown4.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(83, 23);
            numericUpDown4.TabIndex = 28;
            numericUpDown4.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(427, 244);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 29;
            label4.Text = "Ціна:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(516, 262);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "1972-12-31";
            textBox2.Size = new Size(136, 23);
            textBox2.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(516, 241);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 31;
            label5.Text = "Дата постачання:";
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Location = new Point(658, 262);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(137, 23);
            buttonAddProduct.TabIndex = 32;
            buttonAddProduct.Text = "Додати товар";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += ButtonAddProduct_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Green;
            label6.Location = new Point(12, 169);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 33;
            label6.Text = "Додавання:";
            // 
            // textBoxChangeTypeName
            // 
            textBoxChangeTypeName.Location = new Point(53, 315);
            textBoxChangeTypeName.Name = "textBoxChangeTypeName";
            textBoxChangeTypeName.Size = new Size(100, 23);
            textBoxChangeTypeName.TabIndex = 16;
            textBoxChangeTypeName.Text = "Нова назва";
            // 
            // buttonChangeType
            // 
            buttonChangeType.Location = new Point(160, 315);
            buttonChangeType.Name = "buttonChangeType";
            buttonChangeType.Size = new Size(92, 23);
            buttonChangeType.TabIndex = 17;
            buttonChangeType.Text = "Оновити тип";
            buttonChangeType.UseVisualStyleBackColor = true;
            buttonChangeType.Click += ButtonChangeType_Click;
            // 
            // textBoxChangeSupplierName
            // 
            textBoxChangeSupplierName.Location = new Point(53, 344);
            textBoxChangeSupplierName.Name = "textBoxChangeSupplierName";
            textBoxChangeSupplierName.Size = new Size(100, 23);
            textBoxChangeSupplierName.TabIndex = 18;
            textBoxChangeSupplierName.Text = "Нова назва";
            // 
            // buttonChangeSupplier
            // 
            buttonChangeSupplier.Location = new Point(160, 344);
            buttonChangeSupplier.Name = "buttonChangeSupplier";
            buttonChangeSupplier.Size = new Size(154, 23);
            buttonChangeSupplier.TabIndex = 19;
            buttonChangeSupplier.Text = "Оновити постачальника";
            buttonChangeSupplier.UseVisualStyleBackColor = true;
            buttonChangeSupplier.Click += ButtonChangeSupplier_Click;
            // 
            // textBoxChangeNameProduct
            // 
            textBoxChangeNameProduct.Location = new Point(55, 391);
            textBoxChangeNameProduct.Name = "textBoxChangeNameProduct";
            textBoxChangeNameProduct.PlaceholderText = "Назва продукту";
            textBoxChangeNameProduct.Size = new Size(153, 23);
            textBoxChangeNameProduct.TabIndex = 20;
            // 
            // numericProductChangeIdType
            // 
            numericProductChangeIdType.Location = new Point(214, 391);
            numericProductChangeIdType.Name = "numericProductChangeIdType";
            numericProductChangeIdType.Size = new Size(45, 23);
            numericProductChangeIdType.TabIndex = 21;
            // 
            // numericProductChangeIdSupplier
            // 
            numericProductChangeIdSupplier.Location = new Point(283, 391);
            numericProductChangeIdSupplier.Name = "numericProductChangeIdSupplier";
            numericProductChangeIdSupplier.Size = new Size(36, 23);
            numericProductChangeIdSupplier.TabIndex = 22;
            // 
            // numericProductChangeIdQuantity
            // 
            numericProductChangeIdQuantity.Location = new Point(392, 392);
            numericProductChangeIdQuantity.Name = "numericProductChangeIdQuantity";
            numericProductChangeIdQuantity.Size = new Size(59, 23);
            numericProductChangeIdQuantity.TabIndex = 23;
            numericProductChangeIdQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(55, 373);
            label7.Name = "label7";
            label7.Size = new Size(95, 15);
            label7.TabIndex = 24;
            label7.Text = "Назва продукту:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(213, 373);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 25;
            label8.Text = "ID типу:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(279, 374);
            label9.Name = "label9";
            label9.Size = new Size(109, 15);
            label9.TabIndex = 26;
            label9.Text = "ID Постачальника:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(391, 373);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 27;
            label10.Text = "Кількість:";
            // 
            // numericProductChangeCostPrice
            // 
            numericProductChangeCostPrice.DecimalPlaces = 2;
            numericProductChangeCostPrice.Location = new Point(470, 391);
            numericProductChangeCostPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericProductChangeCostPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericProductChangeCostPrice.Name = "numericProductChangeCostPrice";
            numericProductChangeCostPrice.Size = new Size(83, 23);
            numericProductChangeCostPrice.TabIndex = 28;
            numericProductChangeCostPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(470, 373);
            label11.Name = "label11";
            label11.Size = new Size(35, 15);
            label11.TabIndex = 29;
            label11.Text = "Ціна:";
            // 
            // textBoxProductChangeSupplyDate
            // 
            textBoxProductChangeSupplyDate.Location = new Point(559, 391);
            textBoxProductChangeSupplyDate.Name = "textBoxProductChangeSupplyDate";
            textBoxProductChangeSupplyDate.PlaceholderText = "1972-12-31";
            textBoxProductChangeSupplyDate.Size = new Size(136, 23);
            textBoxProductChangeSupplyDate.TabIndex = 30;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(559, 372);
            label12.Name = "label12";
            label12.Size = new Size(102, 15);
            label12.TabIndex = 31;
            label12.Text = "Дата постачання:";
            // 
            // buttonUpdateProduct
            // 
            buttonUpdateProduct.Location = new Point(701, 391);
            buttonUpdateProduct.Name = "buttonUpdateProduct";
            buttonUpdateProduct.Size = new Size(137, 23);
            buttonUpdateProduct.TabIndex = 32;
            buttonUpdateProduct.Text = "Оновити товар";
            buttonUpdateProduct.UseVisualStyleBackColor = true;
            buttonUpdateProduct.Click += ButtonUpdateProduct_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.DarkKhaki;
            label13.Location = new Point(12, 297);
            label13.Name = "label13";
            label13.Size = new Size(107, 15);
            label13.TabIndex = 33;
            label13.Text = "Оновлення даних:";
            // 
            // numericChangeType
            // 
            numericChangeType.Location = new Point(13, 315);
            numericChangeType.Name = "numericChangeType";
            numericChangeType.Size = new Size(34, 23);
            numericChangeType.TabIndex = 34;
            // 
            // numericChangeSupplier
            // 
            numericChangeSupplier.Location = new Point(12, 344);
            numericChangeSupplier.Name = "numericChangeSupplier";
            numericChangeSupplier.Size = new Size(35, 23);
            numericChangeSupplier.TabIndex = 35;
            // 
            // numericUpDownChooseId
            // 
            numericUpDownChooseId.Location = new Point(13, 391);
            numericUpDownChooseId.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownChooseId.Name = "numericUpDownChooseId";
            numericUpDownChooseId.Size = new Size(34, 23);
            numericUpDownChooseId.TabIndex = 36;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(13, 373);
            label14.Name = "label14";
            label14.Size = new Size(20, 15);
            label14.TabIndex = 37;
            label14.Text = "Id:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.Red;
            label15.Location = new Point(9, 429);
            label15.Name = "label15";
            label15.Size = new Size(69, 15);
            label15.TabIndex = 38;
            label15.Text = "Видалення:";
            // 
            // numericDeleteProduct
            // 
            numericDeleteProduct.Location = new Point(12, 462);
            numericDeleteProduct.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numericDeleteProduct.Name = "numericDeleteProduct";
            numericDeleteProduct.Size = new Size(37, 23);
            numericDeleteProduct.TabIndex = 39;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(12, 446);
            label16.Name = "label16";
            label16.Size = new Size(20, 15);
            label16.TabIndex = 40;
            label16.Text = "Id:";
            // 
            // buttonDeleteProduct
            // 
            buttonDeleteProduct.Location = new Point(55, 463);
            buttonDeleteProduct.Name = "buttonDeleteProduct";
            buttonDeleteProduct.Size = new Size(118, 23);
            buttonDeleteProduct.TabIndex = 41;
            buttonDeleteProduct.Text = "Видалити продукт";
            buttonDeleteProduct.UseVisualStyleBackColor = true;
            buttonDeleteProduct.Click += ButtonDeleteProduct_Click;
            // 
            // numericDeleteType
            // 
            numericDeleteType.Location = new Point(202, 462);
            numericDeleteType.Name = "numericDeleteType";
            numericDeleteType.Size = new Size(37, 23);
            numericDeleteType.TabIndex = 42;
            // 
            // numericDeleteSupplier
            // 
            numericDeleteSupplier.Location = new Point(373, 462);
            numericDeleteSupplier.Name = "numericDeleteSupplier";
            numericDeleteSupplier.Size = new Size(44, 23);
            numericDeleteSupplier.TabIndex = 43;
            // 
            // buttonDeleteType
            // 
            buttonDeleteType.Location = new Point(245, 462);
            buttonDeleteType.Name = "buttonDeleteType";
            buttonDeleteType.Size = new Size(100, 23);
            buttonDeleteType.TabIndex = 44;
            buttonDeleteType.Text = "Видалити тип";
            buttonDeleteType.UseVisualStyleBackColor = true;
            buttonDeleteType.Click += ButtonDeleteType_Click;
            // 
            // buttonDeleteSupplier
            // 
            buttonDeleteSupplier.Location = new Point(427, 463);
            buttonDeleteSupplier.Name = "buttonDeleteSupplier";
            buttonDeleteSupplier.Size = new Size(164, 23);
            buttonDeleteSupplier.TabIndex = 45;
            buttonDeleteSupplier.Text = "Видалити постачальника";
            buttonDeleteSupplier.UseVisualStyleBackColor = true;
            buttonDeleteSupplier.Click += buttonDeleteSupplier_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(202, 444);
            label17.Name = "label17";
            label17.Size = new Size(20, 15);
            label17.TabIndex = 40;
            label17.Text = "Id:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(373, 444);
            label18.Name = "label18";
            label18.Size = new Size(20, 15);
            label18.TabIndex = 40;
            label18.Text = "Id:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(914, 262);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(256, 19);
            radioButton1.TabIndex = 46;
            radioButton1.TabStop = true;
            radioButton1.Text = "Постачальник з максимальною кількістю";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += RadioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(914, 287);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(244, 19);
            radioButton2.TabIndex = 47;
            radioButton2.TabStop = true;
            radioButton2.Text = "Постачальник з мінімальною кількістю";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += RadioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(914, 312);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(197, 19);
            radioButton3.TabIndex = 48;
            radioButton3.TabStop = true;
            radioButton3.Text = "Тип з максимальною кількістю";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += RadioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(914, 337);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(185, 19);
            radioButton4.TabIndex = 49;
            radioButton4.TabStop = true;
            radioButton4.Text = "Тип з мінімальною кількістю";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += RadioButton4_CheckedChanged;
            // 
            // numericNumberOfDays
            // 
            numericNumberOfDays.Location = new Point(854, 458);
            numericNumberOfDays.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericNumberOfDays.Name = "numericNumberOfDays";
            numericNumberOfDays.Size = new Size(84, 23);
            numericNumberOfDays.TabIndex = 50;
            numericNumberOfDays.ValueChanged += RadioButton5_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(944, 462);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(265, 19);
            radioButton5.TabIndex = 51;
            radioButton5.TabStop = true;
            radioButton5.Text = "Товари, які знаходяться певну кількість днів";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += RadioButton5_CheckedChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(850, 440);
            label19.Name = "label19";
            label19.Size = new Size(84, 15);
            label19.TabIndex = 52;
            label19.Text = "Кількість днів:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 804);
            Controls.Add(label19);
            Controls.Add(radioButton5);
            Controls.Add(numericNumberOfDays);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(buttonDeleteSupplier);
            Controls.Add(buttonDeleteType);
            Controls.Add(numericDeleteSupplier);
            Controls.Add(numericDeleteType);
            Controls.Add(buttonDeleteProduct);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(numericDeleteProduct);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(numericUpDownChooseId);
            Controls.Add(numericChangeSupplier);
            Controls.Add(numericChangeType);
            Controls.Add(label13);
            Controls.Add(buttonUpdateProduct);
            Controls.Add(label6);
            Controls.Add(label12);
            Controls.Add(buttonAddProduct);
            Controls.Add(textBoxProductChangeSupplyDate);
            Controls.Add(label5);
            Controls.Add(label11);
            Controls.Add(textBox2);
            Controls.Add(numericProductChangeCostPrice);
            Controls.Add(label4);
            Controls.Add(label10);
            Controls.Add(numericUpDown4);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(numericProductChangeIdQuantity);
            Controls.Add(ProductName);
            Controls.Add(numericProductChangeIdSupplier);
            Controls.Add(numericUpDown3);
            Controls.Add(numericProductChangeIdType);
            Controls.Add(numericUpDown2);
            Controls.Add(textBoxChangeNameProduct);
            Controls.Add(numericUpDown1);
            Controls.Add(buttonChangeSupplier);
            Controls.Add(textBox1);
            Controls.Add(textBoxChangeSupplierName);
            Controls.Add(buttonAddSupplier);
            Controls.Add(buttonChangeType);
            Controls.Add(textBoxAddSupplier);
            Controls.Add(textBoxChangeTypeName);
            Controls.Add(buttonAddType);
            Controls.Add(textBoxAddType);
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericProductChangeIdType).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericProductChangeIdSupplier).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericProductChangeIdQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericProductChangeCostPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericChangeType).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericChangeSupplier).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownChooseId).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDeleteProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDeleteType).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDeleteSupplier).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericNumberOfDays).EndInit();
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
        private TextBox textBoxAddType;
        private Button buttonAddType;
        private TextBox textBoxAddSupplier;
        private Button buttonAddSupplier;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Label ProductName;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown4;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Button buttonAddProduct;
        private Label label6;
        private TextBox textBoxChangeTypeName;
        private Button buttonChangeType;
        private TextBox textBoxChangeSupplierName;
        private Button buttonChangeSupplier;
        private TextBox textBoxChangeNameProduct;
        private NumericUpDown numericProductChangeIdType;
        private NumericUpDown numericProductChangeIdSupplier;
        private NumericUpDown numericProductChangeIdQuantity;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private NumericUpDown numericProductChangeCostPrice;
        private Label label11;
        private TextBox textBoxProductChangeSupplyDate;
        private Label label12;
        private Button buttonUpdateProduct;
        private Label label13;
        private NumericUpDown numericChangeType;
        private NumericUpDown numericChangeSupplier;
        private NumericUpDown numericUpDownChooseId;
        private Label label14;
        private Label label15;
        private NumericUpDown numericDeleteProduct;
        private Label label16;
        private Button buttonDeleteProduct;
        private NumericUpDown numericDeleteType;
        private NumericUpDown numericDeleteSupplier;
        private Button buttonDeleteType;
        private Button buttonDeleteSupplier;
        private Label label17;
        private Label label18;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private NumericUpDown numericNumberOfDays;
        private RadioButton radioButton5;
        private Label label19;
    }
}
