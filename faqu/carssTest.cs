﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using carsss;
using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace faqu
{
    [TestClass]
    public class carssTest
    {

        public enum RoWState
        {
            Existed,
            New,
            Modified,
            ModifiedNew,
            Deleted,
        }
        [TestMethod]
        public void TestMethod1()
        {
            DataBaseConnection dataBase = new DataBaseConnection();

            //тест на налоги
            var res = new Resolver();
            Assert.AreEqual(87000, res.TaxesCount(100000));
            
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataGridView dataGrid = new DataGridView();

            dataGrid.Columns.Add("id", "ID");
            dataGrid.Columns.Add("mark", "Модель");
            dataGrid.Columns.Add("color", "Цвет");
            dataGrid.Columns.Add("year", "Год");
            dataGrid.Columns.Add("cond", "Состояние");
            dataGrid.Columns.Add("price", "Доход с НДФ");
            Assert.AreEqual(6, dataGrid.ColumnCount);
        }

        [TestMethod] // тест на правильность заненсения данных
        public void Testmethod3()
        {
            DataBaseConnection dataBase = new DataBaseConnection();
            DataGridView dataGrid = new DataGridView();
            dataGrid.Columns.Add("id", "ID");
            dataGrid.Columns.Add("mark", "Модель");
            dataGrid.Columns.Add("color", "Цвет");
            dataGrid.Columns.Add("year", "Год");
            dataGrid.Columns.Add("cond", "Состояние");
            dataGrid.Columns.Add("price", "Доход с НДФ");
            void ReadSingleRow(DataGridView dgw, IDataRecord record)
            {
                dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetString(4), record.GetInt32(5));
            }


            dataGrid.Rows.Clear();

            string sql = $"select * from accountant_table";

            MySqlCommand command = new MySqlCommand(sql, dataBase.GetSqlConnection());

            dataBase.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dataGrid, reader);
            }
            reader.Close();

            Assert.AreEqual("BMW", dataGrid.Rows[0].Cells[1].Value.ToString());
        }

        [TestMethod]

        public void TestMethod4()
        {
            var rowState = RoWState.Deleted;
        }
    }

   
}
