using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
//MAIN VERSION

namespace SoftwareEngineering
{
    public partial class MainForm : Form
    {
        public static string connectionString;
        public static SqlConnection cnn;
        public static SqlDataAdapter adapter;
        public static BindingSource bindingSource1 = new BindingSource();

        public MainForm()
        {
            InitializeComponent();
        }

        //MENU BUTTONS:
        private void MenuQuickButton_Click(object sender, EventArgs e)
        {
            SidePanel.Top = MenuQuickButton.Top;
            quickFindPanel.BringToFront();
            quickFindPanel.StartTable();
            TitleLabel.Text = "Quick Find";
        }

        private void MenuSearchButton_Click(object sender, EventArgs e)
        {
            SidePanel.Top = MenuSearchButton.Top;
            advancedSearchPanel.BringToFront();
            TitleLabel.Text = "Search";
        }

        private void MenuFilterButton_Click(object sender, EventArgs e)
        {
            SidePanel.Top = MenuFilterButton.Top;
            advancedFilterPanel.StartTable();
            advancedFilterPanel.BringToFront();
            TitleLabel.Text = "Advanced Filters";
        }

        private void ConnectToDatabase() 
        {
            try
            {
                //EDIT THIS BIT FOR YOUR DATABASE!!!
                connectionString = @"Data Source= LAPTOP-J83S1KQQ\SQLEXPRESS;Initial Catalog=CarDatabase;Integrated Security=SSPI;"; 
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                MessageBox.Show("Connection Open!");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection! ");
                Application.Exit();
            }
            
        }


        private void MenuAddButton_Click(object sender, EventArgs e)
        {
            SidePanel.Top = MenuAddButton.Top;
            addVehicle1.StartTable();
            addVehicle1.BringToFront();
            TitleLabel.Text = "Add Car";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quickFindPanel_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectToDatabase();
            advancedSearchPanel.LoadDataString();
            quickFindPanel.StartTable();
            quickFindPanel.BringToFront();
        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //View Engines
            SidePanel.Top = button1.Top;
            viewEngine.StartTable();
            viewEngine.BringToFront();
            TitleLabel.Text = "View Engines";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Add Engine
            SidePanel.Top = button2.Top;
            addEngine1.StartTable();
            addEngine1.BringToFront();
            TitleLabel.Text = "Add Engine";
        }
    }
}
