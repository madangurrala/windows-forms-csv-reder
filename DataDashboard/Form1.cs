using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.ComponentModel;
using System;
using System.Data;
using System.Resources;
using DataDashboard.Properties;

namespace DataDashboard
{

    public partial class Form1 : Form
    {
       
        //Loads the data to datagrid view
        private void loadCsv()
        {
            string fileName = @"D:\Projects\DataDashboard\data.csv";
            List<StationData> stationsData;
            using (var reader = new StreamReader(fileName))
            {
                using (var data = new CsvReader(reader, CultureInfo.CurrentCulture))
                {
                    stationsData = data.GetRecords<StationData>().ToList();
                }
            }
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = stationsData;
            stationDatagrid.DataSource = bindingSource;

        }

        public Form1()
        {
            InitializeComponent();
            loadCsv();
            ResourceManager resources = new ResourceManager(typeof(Resources));

            //Appends the text boxes with text from resources
            textBox1.Text = resources.GetString("AddInstructions");
            textBox2.Text = resources.GetString("UpdateInstructions");
            textBox3.Text = resources.GetString("DeleteInstructions");

        }


        //Load csv file on Load CSV button click
        private void btnLoad_Click(object sender, System.EventArgs e)
        {
            loadCsv();
        }

        //Delete selected row
        private void deleteRow(object sender, System.EventArgs e)
        {
            if(stationDatagrid.CurrentRow !=null && stationDatagrid.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in stationDatagrid.SelectedRows)
                {
                    if (row != null)
                    {
                        stationDatagrid.Rows.Remove(row);
                        stationDatagrid.Refresh();
                        MessageBox.Show("Record has been deleted from dashboard.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }

            }
            else
            {
                MessageBox.Show("Please select a row to delete it from dashboard.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        //Display friendly error on data error
        private void stationDatagrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Please enter a valid input", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if ((e.Exception) is ConstraintException)
            {


                e.ThrowException = false;
            }
        }

        //unload the CSV file
        private void btnUnload_MouseClick(object sender, MouseEventArgs e)
        {
            stationDatagrid.Rows.Clear();
            stationDatagrid.Refresh();
        }
    }
}
