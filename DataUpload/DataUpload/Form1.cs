using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataUpload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Lox(string sLox)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(txtDataFolder.Text +"log.txt",true);
            file.WriteLine(sLox);

            file.Close();
        }

        
        private void LoAndBehold(string sFileName)
        {
            SqlConnection con;
            string[] lines = System.IO.File.ReadAllLines(@"D:\work\data\" + sFileName);
            char[] delimiters = new char[] { '\t' };
            string stmt;
            try
            { 
                con = new SqlConnection(txtConnectionStr.Text);
                con.Open();
            }
            catch (Exception myExp)
            {
                MessageBox.Show("Connection String is not valid... " + myExp.Message);
                return;
            }
            int i; 
            System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                
                stmt = "select  '" + sFileName + "',";
                i = 0;
                try
                {
                    string[] parts = line.Replace("\"", "").Replace("\r", "").Replace("\n", "").Split(delimiters, StringSplitOptions.RemoveEmptyEntries) ;
                    for ( i = 0; i < parts.Length; i++)
                    {
                        stmt = stmt + "'" + parts[i].ToString().Replace("'", " ") + "',";

                    }
                    if (i == 4)
                        stmt = stmt + "' ',";
                    else if (i == 3)
                        stmt = stmt + "' ',' ',";
                    else if (i == 2)
                        stmt = stmt + "' ',' ',' ',";

                    stmt = stmt + " getdate()";
                    stmt = " INSERT INTO WBData  (IndexName,CountryName,CountryCode,SeriesName,SeriesCode,DataPeriod,Zref) " + stmt;

                    
                    SqlCommand command = new SqlCommand(stmt, con);
                    command.ExecuteNonQuery();
                }
                catch
                {
                    ;
                    Lox(stmt);
                }
            }
            con.Close();

        }

        private void LoAndBeholdDefinition(string sFileName)
        {

            string[] lines = System.IO.File.ReadAllLines(txtDataFolder.Text + sFileName);
            char[] delimiters = new char[] { '\t' };
            string stmt;

            SqlConnection con;
            try
            {
                con = new SqlConnection(txtConnectionStr.Text);
                con.Open();
            }
            catch (Exception myExp)
            {
                MessageBox.Show("Connection String is not valid... " + myExp.Message);
                return;
            }  
            con.Open();
            int i = 0;
            System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                stmt = "select  '" + sFileName + "',";
                try
                {
                    i = 0;
                    string[] parts = line.Replace("\"", "").Replace("\r", "").Replace("\n", "").Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                    for ( i = 0; i < parts.Length; i++)
                    {
                        stmt = stmt + "'" + parts[i].ToString().Replace("'", " ") + "',";

                    }
                    if (i == 3)
                        stmt = stmt + "' ',";
                    else if (i == 2)
                        stmt = stmt + "' ',' ',";
                    else if (i == 1)
                        stmt = stmt + "' ',' ',' ',";


                    stmt = stmt + " getdate()";
                    stmt = " INSERT INTO WBDataDefinition  (IndexName,Code,IndicatorName ,LongDefinition,DataSource,Zref) " + stmt;

                    //ExecuteStmt(stmt);
                    SqlCommand command = new SqlCommand(stmt, con);
                    command.ExecuteNonQuery();
                }
                catch
                {
                    ;
                    Lox(stmt);
                }
            }
            con.Close();

        }
 
        private void cmdLoadData_Click(object sender, EventArgs e)
        {
            FileInfo[] Files;
            string str = "";
            try
            {
                DirectoryInfo d = new DirectoryInfo(txtDataFolder.Text);//Assuming Test is your Folder
                Files = d.GetFiles("*_Data.txt"); //Getting Text files
            }
            catch (Exception myExp)
            {
                MessageBox.Show("Directory is not valid... " + myExp.Message);
                return;
            }

            foreach (FileInfo file in Files)
            {
                Lox(file.Name + "Started");
                LoAndBehold(file.Name);
                Lox(file.Name + "Ended");
            }
        }

        

        private void cmdLoadDefinition_Click(object sender, EventArgs e)
        {
            FileInfo[] Files;
            string str = "";
            try
            {
                DirectoryInfo d = new DirectoryInfo(txtDataFolder.Text);//Assuming Test is your Folder
                Files = d.GetFiles("*Definition and Source.txt"); //Getting Text files
            }
            catch (Exception myExp)
            {
                MessageBox.Show("Directory is not valid... " + myExp.Message);
                return;
            }

            foreach (FileInfo file in Files)
            {
                Lox(file.Name + "Started");
                LoAndBeholdDefinition(file.Name);
                Lox(file.Name + "Ended");
            }
        }
    }
}
