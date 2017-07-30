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

        private void button1_Click(object sender, EventArgs e)
        {
             
           
         

            // Keep the console window open in debug mode.
        }
        private void Lox(string sLox)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\work\data\log.txt",true);
            file.WriteLine(sLox);

            file.Close();
        }
        //private void ExecuteStmt (string pStmt)
        //{
        //    SqlConnection con = new SqlConnection(@"Data Source=BT101NB\SQLEXPRESS;Initial Catalog=DBWorldBank;Integrated Security=True");
        //    con.Open();
        //    SqlCommand command = new SqlCommand(pStmt, con);
        //    command.ExecuteNonQuery();
        //    con.Close();
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            DirectoryInfo d = new DirectoryInfo(@"D:\work\data\");//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*_Data.txt"); //Getting Text files
            string str = "";
            foreach (FileInfo file in Files)
            {
                Lox(file.Name + "Started"); 
                LoAndBehold ( file.Name);
                Lox(file.Name  + "Ended");
            }
        }
        private void LoAndBehold(string sFileName)
        {

            string[] lines = System.IO.File.ReadAllLines(@"D:\work\data\"  + sFileName);
            char[] delimiters = new char[] { '\t' };
            string stmt;
            SqlConnection con = new SqlConnection(@"Data Source=BT101NB\SQLEXPRESS;Initial Catalog=DBWorldBank;Integrated Security=True");
            con.Open();
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

        private void LoAndBeholdDefinition(string sFileName)
        {

            string[] lines = System.IO.File.ReadAllLines(@"D:\work\data\" + sFileName);
            char[] delimiters = new char[] { '\t' };
            string stmt;
            SqlConnection con = new SqlConnection(@"Data Source=BT101NB\SQLEXPRESS;Initial Catalog=DBWorldBank;Integrated Security=True");
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            DirectoryInfo d = new DirectoryInfo(@"D:\work\data\");//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*Definition and Source.txt"); //Getting Text files
            string str = "";
            foreach (FileInfo file in Files)
            {
                Lox(file.Name + "Started");
                LoAndBeholdDefinition(file.Name);
                Lox(file.Name + "Ended");
            }
        }
    }
}
