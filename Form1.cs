// <copyright file="Form1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Task2_1Goods;

public partial class Form1 : Form
{
    private readonly DataBase dataBase = new();

    /// <summary>
    /// Initializes a new instance of the <see cref="Form1"/> class.
    /// </summary>
    public Form1()
    {
        this.InitializeComponent();
        this.dataBase.CreateDataBase();
        _ = this.dataBase.PrintDataBase(this.dataGridView1);
        _ = this.comboBoxTypes.SelectedIndex = 0;
        _ = this.comboBoxSuppliers.SelectedIndex = 0;
    }

    private void ButtonConnect_Click(object sender, EventArgs e)
    {
        if (this.dataBase.ToConnect())
        {
            _ = this.dataBase.PrintDataBase(this.dataGridView1);
            this.AllInfo.Checked = true;
        }
    }

    private void ButtonDisconnect_Click(object sender, EventArgs e)
    {
        this.dataBase.Disconnect(this.dataGridView1);
    }

    private void AllInfo_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.dataBase.PrintDataBase(this.dataGridView1);
    }

    private void AllTypes_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.dataBase.PrintAllTypes(this.dataGridView1);
    }

    private void AllSuppliers_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.dataBase.PrintAllSuppliers(this.dataGridView1);
    }

    private void MaxQuantity_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.dataBase.PrintMaxQuantity(this.dataGridView1);
    }

    private void MinQuantity_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.dataBase.PrintMinQuantity(this.dataGridView1);
    }

    private void MinCostPrice_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.dataBase.PrintMinCostPrice(this.dataGridView1);
    }

    private void MaxCostPrice_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.dataBase.PrintMaxCostPrice(this.dataGridView1);
    }

    private void ShowGoodsThisCategory_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.dataBase.PrintGoodsThisCategory(this.dataGridView1, this.comboBoxTypes.Text, this.ShowGoodsThisCategory);
    }

    private void ShowGoodsThisCategory_CheckedChanged_1(object sender, EventArgs e)
    {
        _ = this.dataBase.PrintGoodsThisCategory(this.dataGridView1, this.comboBoxTypes.Text, this.ShowGoodsThisCategory);
    }

    private void ShowGoodsThisSupplier_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.dataBase.PrintGoodsThisSupplier(this.dataGridView1, this.comboBoxSuppliers.Text, this.ShowGoodsThisSupplier);
    }

    private void GoodsOld_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.dataBase.PrintGoodsOld(this.dataGridView1);
    }

    private void AverageByType_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.dataBase.PrintAverageByType(this.dataGridView1);
    }

    private void ButtonAddType_Click(object sender, EventArgs e)
    {
        this.dataBase.AddNewProductType(this.textBoxAddType.Text.ToString());
        this.AllTypes.Checked = true;
        _ = this.dataBase.PrintAllTypes(this.dataGridView1);
    }

    private void ButtonAddSupplier_Click(object sender, EventArgs e)
    {
        this.dataBase.AddNewProductSupplier(this.textBoxAddSupplier.Text.ToString());
        this.AllSuppliers.Checked = true;
        _ = this.dataBase.PrintAllSuppliers(this.dataGridView1);
    }

    private void ButtonAddProduct_Click(object sender, EventArgs e)
    {
        this.dataBase.AddNewProduct(this.textBox1.Text.ToString(), (int)this.numericUpDown1.Value, (int)this.numericUpDown2.Value, (int)this.numericUpDown3.Value, this.numericUpDown4.Value, this.textBox2.Text.ToString());
        this.AllInfo.Checked = true;
        _ = this.dataBase.PrintDataBase(this.dataGridView1);
    }

    private void ButtonChangeType_Click(object sender, EventArgs e)
    {
        this.dataBase.UpdateTypeInfo((int)this.numericChangeType.Value, this.textBoxChangeTypeName.Text);
        this.AllTypes.Checked = true;
        _ = this.dataBase.PrintAllTypes(this.dataGridView1);
    }

    private void ButtonChangeSupplier_Click(object sender, EventArgs e)
    {
        this.dataBase.UpdateSupplierInfo((int)this.numericChangeSupplier.Value, this.textBoxChangeSupplierName.Text);
        this.AllSuppliers.Checked = true;
        _ = this.dataBase.PrintAllSuppliers(this.dataGridView1);
    }

    private void ButtonUpdateProduct_Click(object sender, EventArgs e)
    {
        this.dataBase.UpdateProductInfo((int)this.numericUpDownChooseId.Value, this.textBoxChangeNameProduct.Text, (int)this.numericProductChangeIdType.Value, (int)this.numericProductChangeIdSupplier.Value, (int)this.numericProductChangeIdQuantity.Value, this.numericProductChangeCostPrice.Value, this.textBoxProductChangeSupplyDate.Text);
        this.AllInfo.Checked = true;
        _ = this.dataBase.PrintDataBase(this.dataGridView1);
    }

    private void ButtonDeleteProduct_Click(object sender, EventArgs e)
    {
        this.dataBase.DeleteProduct((int)this.numericDeleteProduct.Value);
        this.AllInfo.Checked = true;
        _ = this.dataBase.PrintDataBase(this.dataGridView1);
    }

    private void ButtonDeleteType_Click(object sender, EventArgs e)
    {
        this.dataBase.DeleteProductType((int)this.numericDeleteType.Value);
        this.AllTypes.Checked = true;
        _ = this.dataBase.PrintAllTypes(this.dataGridView1);
    }

    private void buttonDeleteSupplier_Click(object sender, EventArgs e)
    {
        this.dataBase.DeleteSupplier((int)this.numericDeleteSupplier.Value);
        this.AllSuppliers.Checked = true;
        _ = this.dataBase.PrintAllSuppliers(this.dataGridView1);
    }

    private void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.dataBase.PrintSupplierGoodsMax(this.dataGridView1);
    }

    private void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.dataBase.PrintSupplierGoodsMin(this.dataGridView1);
    }

    private void RadioButton3_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.dataBase.PrintTypeGoodsMax(this.dataGridView1);
    }

    private void RadioButton4_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.dataBase.PrintTypeGoodsMin(this.dataGridView1);
    }

    private void RadioButton5_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.dataBase.PrintGoodsDays(this.dataGridView1, (int)this.numericNumberOfDays.Value);
    }
}
