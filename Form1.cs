// <copyright file="Form1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Task2_1Goods;

public partial class Form1 : Form
{
    private readonly DataBase dataBase = new ();

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
}
