// <copyright file="DataBase.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace Task2_1Goods;
using Microsoft.Data.Sqlite;
using System;
using System.Data;
using System.Linq.Expressions;
using System.Windows.Forms;

internal class DataBase
{
    private readonly string connectionString = "Data Source= GoodsDB.sqlite;";
    private bool access = false;

    public void CreateDataBase()
    {
        string createSuppliersTable = @"
            CREATE TABLE IF NOT EXISTS Suppliers (
                SupplierId INTEGER UNIQUE PRIMARY KEY,
                SupplierName NVARCHAR(255) NOT NULL
            );
        ";
        string createTypesTable = @"
            CREATE TABLE IF NOT EXISTS Types (
                TypeId INTEGER UNIQUE PRIMARY KEY,
                TypeName NVARCHAR(255) NOT NULL
            );
        ";
        string createGoodsTable = @"
            CREATE TABLE IF NOT EXISTS Goods (
                ProductId INTEGER PRIMARY KEY AUTOINCREMENT,
                Name NVARCHAR(255) UNIQUE NOT NULL,
                TypeId INTEGER NOT NULL,
                SupplierId INTEGER NOT NULL,
                Quantity INTEGER NOT NULL,
                CostPrice DECIMAL(18,2) NOT NULL,
                SupplyDate DATETIME NOT NULL,
                FOREIGN KEY(TypeId) REFERENCES Types(TypeId),
                FOREIGN KEY(SupplierId) REFERENCES Suppliers(SupplierId)
            );
        ";

        using (SqliteConnection connection = new (this.connectionString))
        {
            connection.Open();

            using (SqliteCommand command = new (createSuppliersTable, connection))
            {
                command.ExecuteNonQuery();
            }

            using (SqliteCommand command = new (createTypesTable, connection))
            {
                command.ExecuteNonQuery();
            }

            using (SqliteCommand command = new (createGoodsTable, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        string insertTypes = @"
            INSERT OR IGNORE INTO Types (TypeId, TypeName) VALUES (1, 'Ноутбук'), (2, 'Планшет'), (3, 'Монітор');";

        string insertSuppliers = @"
            INSERT OR IGNORE INTO Suppliers (SupplierId, SupplierName) VALUES (1, 'Sumsung'), (2, 'Dell'), (3, 'Lenovo');";

        string insertGoods = @"
            INSERT OR IGNORE INTO Goods (Name, TypeId, SupplierId, Quantity, CostPrice, SupplyDate) VALUES 
            ('Ноутбук Lenovo IdeaPad Slim 5 16IAH8', 1, 3, 4, 26999, '2023-11-29'),
            ('Ноутбук Dell Latitude 5540', 1, 2, 2, 60849, '2022-11-29'),
            ('Ноутбук Samsung Galaxy Book2 Pro', 1, 1, 3, 45999, '2023-10-29'),
            ('Планшет Samsung Galaxy Tab S7', 2, 1, 1, 20899, '2023-08-29'),
            ('Планшет Lenovo Tab P11 Plus', 2, 3, 3, 9999, '2023-02-25'),
            ('Dell Latitude 7212 Rugged Extreme Tablet i5', 2, 2, 1, 17450, '2023-01-29'),
            ('Монитор Lenovo 29 L29w-30', 3, 3, 4, 7999, '2023-04-29'),
            ('Монитор 28 Samsung Odyssey G7 LS28BG702', 3, 1, 2, 18999, '2023-07-29'),
            ('Монитор 34 Dell Alienware AW3423DWF', 3, 2, 2, 37999, '2023-08-29')
            ;";

        using (SqliteConnection connection = new (this.connectionString))
        {
            connection.Open();

            using (SqliteCommand command = new (insertTypes, connection))
            {
                command.ExecuteNonQuery();
            }

            using (SqliteCommand command = new (insertSuppliers, connection))
            {
                command.ExecuteNonQuery();
            }

            using (SqliteCommand command = new (insertGoods, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }

    public bool ToConnect()
    {
        using SqliteConnection connection = new (this.connectionString);

        if (this.access)
        {
            MessageBox.Show("Ви вже підключені до бази даних.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return true;
        }
        else
        {
            try
            {
                connection.Open();
                MessageBox.Show("Успішне підключення!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.access = true;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Підключення невдалося. Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.access = false;
                return false;
            }
        }
    }

    public void Disconnect(DataGridView field)
    {
        field.DataSource = null;
        MessageBox.Show("Від’єдналися!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.access = false;
    }

    public async Task PrintDataBase(DataGridView field)
    {
        if (this.access)
        {
            field.DataSource = string.Empty;

            using (SqliteConnection connection = new (this.connectionString))
            {
                await connection.OpenAsync();

                try
                {
                    SqliteCommand command = new ("SELECT ProductId AS №, Name AS 'Назва', Types.TypeName AS 'Тип', " +
                        "Suppliers.SupplierName AS 'Постачальник', Quantity AS 'Кількість', CostPrice AS 'Собівартість', " +
                        "SupplyDate AS 'Дата постачання' FROM Goods " +
                        "JOIN Types ON Goods.TypeId = Types.TypeId " +
                        "JOIN Suppliers ON Goods.SupplierId = Suppliers.SupplierId", connection);
                    using SqliteDataReader reader = await command.ExecuteReaderAsync();
                    DataTable dataTable = new ();
                    dataTable.Load(reader);

                    field.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при виконанні запиту: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

    public async Task PrintAllTypes(DataGridView field)
    {
        if (this.access)
        {
            field.DataSource = string.Empty;

            using (SqliteConnection connection = new (this.connectionString))
            {
                await connection.OpenAsync();

                try
                {
                    SqliteCommand command = new ("SELECT TypeId AS №, TypeName AS Назва FROM Types", connection);
                    using SqliteDataReader reader = await command.ExecuteReaderAsync();
                    DataTable dataTable = new ();
                    dataTable.Load(reader);

                    field.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при виконанні запиту: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

    public async Task PrintAllSuppliers(DataGridView field)
    {
        if (this.access)
        {
            field.DataSource = string.Empty;

            using (SqliteConnection connection = new (this.connectionString))
            {
                await connection.OpenAsync();

                try
                {
                    SqliteCommand command = new ("SELECT SupplierId AS №, SupplierName AS Назва FROM Suppliers", connection);
                    using SqliteDataReader reader = await command.ExecuteReaderAsync();
                    DataTable dataTable = new ();
                    dataTable.Load(reader);

                    field.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при виконанні запиту: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

    public async Task PrintMaxQuantity(DataGridView field)
    {
        if (this.access)
        {
            field.DataSource = string.Empty;

            using (SqliteConnection connection = new (this.connectionString))
            {
                await connection.OpenAsync();

                try
                {
                    SqliteCommand command = new ("SELECT ProductId AS №, Name AS 'Назва', Types.TypeName AS 'Тип', " +
                        "Suppliers.SupplierName AS 'Постачальник', Quantity AS 'Кількість', CostPrice AS 'Собівартість', " +
                        "SupplyDate AS 'Дата постачання' FROM Goods " +
                        "JOIN Types ON Goods.TypeId = Types.TypeId " +
                        "JOIN Suppliers ON Goods.SupplierId = Suppliers.SupplierId " +
                        "WHERE Quantity = (SELECT MAX(Quantity) FROM Goods)", connection);
                    using SqliteDataReader reader = await command.ExecuteReaderAsync();
                    DataTable dataTable = new ();
                    dataTable.Load(reader);

                    field.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при виконанні запиту: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

    public async Task PrintMinQuantity(DataGridView field)
    {
        if (this.access)
        {
            field.DataSource = string.Empty;

            using (SqliteConnection connection = new (this.connectionString))
            {
                await connection.OpenAsync();

                try
                {
                    SqliteCommand command = new ("SELECT ProductId AS №, Name AS 'Назва', Types.TypeName AS 'Тип', " +
                        "Suppliers.SupplierName AS 'Постачальник', Quantity AS 'Кількість', CostPrice AS 'Собівартість', " +
                        "SupplyDate AS 'Дата постачання' FROM Goods " +
                        "JOIN Types ON Goods.TypeId = Types.TypeId " +
                        "JOIN Suppliers ON Goods.SupplierId = Suppliers.SupplierId " +
                        "WHERE Quantity = (SELECT MIN(Quantity) FROM Goods)", connection);
                    using SqliteDataReader reader = await command.ExecuteReaderAsync();
                    DataTable dataTable = new ();
                    dataTable.Load(reader);

                    field.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при виконанні запиту: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

    public async Task PrintMinCostPrice(DataGridView field)
    {
        if (this.access)
        {
            field.DataSource = string.Empty;

            using (SqliteConnection connection = new (this.connectionString))
            {
                await connection.OpenAsync();

                try
                {
                    SqliteCommand command = new ("SELECT ProductId AS №, Name AS 'Назва', Types.TypeName AS 'Тип', " +
                        "Suppliers.SupplierName AS 'Постачальник', Quantity AS 'Кількість', CostPrice AS 'Собівартість', " +
                        "SupplyDate AS 'Дата постачання' FROM Goods " +
                        "JOIN Types ON Goods.TypeId = Types.TypeId " +
                        "JOIN Suppliers ON Goods.SupplierId = Suppliers.SupplierId " +
                        "WHERE CostPrice = (SELECT MIN(CostPrice) FROM Goods)", connection);
                    using SqliteDataReader reader = await command.ExecuteReaderAsync();
                    DataTable dataTable = new ();
                    dataTable.Load(reader);

                    field.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при виконанні запиту: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

    public async Task PrintMaxCostPrice(DataGridView field)
    {
        if (this.access)
        {
            field.DataSource = string.Empty;

            using (SqliteConnection connection = new (this.connectionString))
            {
                await connection.OpenAsync();

                try
                {
                    SqliteCommand command = new ("SELECT ProductId AS №, Name AS 'Назва', Types.TypeName AS 'Тип', " +
                        "Suppliers.SupplierName AS 'Постачальник', Quantity AS 'Кількість', CostPrice AS 'Собівартість', " +
                        "SupplyDate AS 'Дата постачання' FROM Goods " +
                        "JOIN Types ON Goods.TypeId = Types.TypeId " +
                        "JOIN Suppliers ON Goods.SupplierId = Suppliers.SupplierId " +
                        "WHERE CostPrice = (SELECT MAX(CostPrice) FROM Goods)", connection);
                    using SqliteDataReader reader = await command.ExecuteReaderAsync();
                    DataTable dataTable = new ();
                    dataTable.Load(reader);

                    field.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при виконанні запиту: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

    public async Task PrintGoodsThisCategory(DataGridView field, string category, RadioButton radioButton)
    {
        if (this.access && radioButton.Checked)
        {
            field.DataSource = string.Empty;

            using (SqliteConnection connection = new (this.connectionString))
            {
                await connection.OpenAsync();

                try
                {
                    SqliteCommand command = new ("SELECT ProductId AS №, Name AS 'Назва', Types.TypeName AS 'Тип', " +
                        "Suppliers.SupplierName AS 'Постачальник', Quantity AS 'Кількість', CostPrice AS 'Собівартість', " +
                        "SupplyDate AS 'Дата постачання' FROM Goods " +
                        "JOIN Types ON Goods.TypeId = Types.TypeId " +
                        "JOIN Suppliers ON Goods.SupplierId = Suppliers.SupplierId " +
                        "WHERE Types.TypeName = @CategoryValue", connection);
                    command.Parameters.AddWithValue("@CategoryValue", category);
                    using SqliteDataReader reader = await command.ExecuteReaderAsync();
                    DataTable dataTable = new ();
                    dataTable.Load(reader);

                    field.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при виконанні запиту: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

    public async Task PrintGoodsThisSupplier(DataGridView field, string supplier, RadioButton radioButton)
    {
        if (this.access && radioButton.Checked)
        {
            field.DataSource = string.Empty;

            using (SqliteConnection connection = new (this.connectionString))
            {
                await connection.OpenAsync();

                try
                {
                    SqliteCommand command = new ("SELECT ProductId AS №, Name AS 'Назва', Types.TypeName AS 'Тип', " +
                        "Suppliers.SupplierName AS 'Постачальник', Quantity AS 'Кількість', CostPrice AS 'Собівартість', " +
                        "SupplyDate AS 'Дата постачання' FROM Goods " +
                        "JOIN Types ON Goods.TypeId = Types.TypeId " +
                        "JOIN Suppliers ON Goods.SupplierId = Suppliers.SupplierId " +
                        "WHERE Suppliers.SupplierName = @SupplierValue", connection);
                    command.Parameters.AddWithValue("@SupplierValue", supplier);
                    using SqliteDataReader reader = await command.ExecuteReaderAsync();
                    DataTable dataTable = new ();
                    dataTable.Load(reader);

                    field.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при виконанні запиту: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

    public async Task PrintGoodsOld(DataGridView field)
    {
        if (this.access)
        {
            field.DataSource = string.Empty;

            using (SqliteConnection connection = new (this.connectionString))
            {
                await connection.OpenAsync();

                try
                {
                    SqliteCommand command = new ("SELECT ProductId AS №, Name AS 'Назва', Types.TypeName AS 'Тип', " +
                        "Suppliers.SupplierName AS 'Постачальник', Quantity AS 'Кількість', CostPrice AS 'Собівартість', " +
                        "SupplyDate AS 'Дата постачання' FROM Goods " +
                        "JOIN Types ON Goods.TypeId = Types.TypeId " +
                        "JOIN Suppliers ON Goods.SupplierId = Suppliers.SupplierId " +
                        "ORDER BY SupplyDate LIMIT 1", connection);
                    using SqliteDataReader reader = await command.ExecuteReaderAsync();
                    DataTable dataTable = new ();
                    dataTable.Load(reader);

                    field.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при виконанні запиту: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

    public async Task PrintAverageByType(DataGridView field)
    {
        if (this.access)
        {
            field.DataSource = string.Empty;

            using (SqliteConnection connection = new (this.connectionString))
            {
                await connection.OpenAsync();

                try
                {
                    SqliteCommand command = new ("SELECT Types.TypeName AS 'Тип', ROUND(AVG(Quantity), 2) AS 'Середня кількість' FROM Goods " +
                        "JOIN Types ON Goods.TypeId = Types.TypeId " +
                        "GROUP BY TypeName", connection);
                    using SqliteDataReader reader = await command.ExecuteReaderAsync();
                    DataTable dataTable = new ();
                    dataTable.Load(reader);

                    field.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при виконанні запиту: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
