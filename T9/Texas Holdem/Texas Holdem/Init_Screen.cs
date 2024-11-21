using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;


namespace Texas_Holdem
{
  
    
    public partial class Init_Screen : Form
   
    {
        string desdir = @"c:\the";
        string filename;
        string filenamepro;
        string players;
        decimal house;
        decimal hh;
        decimal bnty;
        int payouts;
        int chips;
        int timeint;
        int initbl;
        int prizes;
        int total = 0;
        int x = 0;
        String[] playersarray = new String[99];
        string[,] tablechart = new string[100,100];
        bool restart = false;
        
    


        public Init_Screen()
        {
            
            InitializeComponent();
            
            hhtxt.Visible = false;
            bntytxt.Visible = false;
            
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            Table1.Visible = false;
            Table2.Visible = false;
            Table3.Visible = false;
            Table4.Visible = false;
            Table5.Visible = false;
            tbl1.Visible = false;
            tbl2.Visible = false;
            tbl3.Visible = false;
            tbl4.Visible = false;
            tbl5.Visible = false;
            
            returnbtn.Visible = false;
           

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {hhtxt.Visible = true;}
            if (checkBox1.Checked == false)
            { hhtxt.Visible = false; }

            if (checkBox2.Checked == true)
            { bntytxt.Visible = true; }
            if (checkBox2.Checked == false)
            { bntytxt.Visible = false; }
      //   string   line = "";
            //string filenamepro = @"c:\the\names.txt";
            //StreamReader sr = new StreamReader(filenamepro);
            //while ((line = sr.ReadLine()) != null)
            //{
            //    archivelst.Items.Add(line);  // load default names to list
            //}
            //sr.Close();
            


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            { hhtxt.Visible = true; }
            if (checkBox1.Checked == false)
            { hhtxt.Visible = false; }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            { bntytxt.Visible = true; }
            if (checkBox2.Checked == false)
            { bntytxt.Visible = false; }
        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            //See if c:\the folder exists

            if (Directory.Exists(desdir))
                desdir = desdir;
            else
                Directory.CreateDirectory(desdir);
            blank();

            try
            {
                // Get profile  andload form
                OpenFileDialog();
                string[] readtext = System.IO.File.ReadAllLines(filenamepro);
                int z = 0;
                foreach (string s in readtext)
                {
                    if (z == 0)
                        playerstxt.Text = s;
                    else if (z == 1)
                        Housetxt.Text = s;
                    else if (z == 2 & s != "")
                    {
                        hhtxt.Text = s;
                        checkBox1.Checked = true;
                            
                       
                    }
                    else if (z == 3 & s != "")
                    {
                        bntytxt.Text = s;
                        checkBox2.Checked = true;
                                        
                    }
                    else if (z == 4)
                        Payoutstxt.Text = s;
                    else if (z == 5)
                        chipstxt.Text = s;
                    else if (z == 6)
                        Timeinttxt.Text = s;
                    else if (z == 7)
                        Initbltxt.Text = s;
                    else if (z == 8)
                        Totaltxt.Text = s;
                    z++;

                }
            }
            catch
            {
            }
        }

        private void blank()
        {
            hhtxt.Visible = false;
            bntytxt.Visible = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            playerstxt.Text = "0";
            Housetxt.Text = "0";
            hhtxt.Text = "0";
            bntytxt.Text = "0";
            Payoutstxt.Text = "2";
            chipstxt.Text = "0";
            Timeinttxt.Text = "0";
            Initbltxt.Text = "0";
            Totaltxt.Text = "0";



        }

        private void Savebtn_Click(object sender, EventArgs e)
        {

            //See if c:\the folder exists

            if (Directory.Exists(desdir))
                desdir = desdir;
            else
                Directory.CreateDirectory(desdir);

            try
            {
                SaveFileDialog();

                string[] createtext = { playerstxt.Text, Housetxt.Text, hhtxt.Text, bntytxt.Text, Payoutstxt.Text, chipstxt.Text, Timeinttxt.Text, Initbltxt.Text, Totaltxt.Text };
                System.IO.File.WriteAllLines(filenamepro, createtext);

            }
            catch
            {
            }

        }

       

        private string SaveFileDialog()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = ".ini files (*.ini)|*.ini| All files (*.*)|*.*";
            dialog.InitialDirectory = desdir;
            dialog.Title = "Save a Init file";
            dialog.ShowDialog();
           return filenamepro = dialog.FileName;
            
        }

        private string SaveFileDialogpl()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = ".txt files (*.txt)|*.txt| All files (*.*)|*.*";
            dialog.InitialDirectory = desdir;
            dialog.Title = "Save a txt file";
            dialog.ShowDialog();
            return filename = dialog.FileName;

        }


        
        
        private string OpenFileDialog()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = ".ini files (*.ini)|*.ini| All files (*.*)|*.*";
            dialog.InitialDirectory = desdir;
            dialog.Title = "Select a Init file";
            dialog.ShowDialog();
            return filenamepro = dialog.FileName;
                
            
            
            
        }


        private string OpenFileDialogpl()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = ".txt files (*.txt)|*.txt| All files (*.*)|*.*";
            dialog.InitialDirectory = desdir;
            dialog.Title = "Select a txt file";
            dialog.ShowDialog();
            return filename = dialog.FileName;

        }
        // Set up methods to return values to other form

        public string GetPlayerBoxValue()
        {
            return playerstxt.Text;
        }
        public string GetHouseBoxValue()
        {
            return Housetxt.Text;
        }
        public string GetHhBoxValue()
        {
            return hhtxt.Text;
        }
        public string GetBntyBoxValue()
        {
            return bntytxt.Text;
        }
        public string GetPayoutsBoxValue()
        {
            return Payoutstxt.Text;
        }
        public string GetChipsBoxValue()
        {
            return chipstxt.Text;
        }
        public string GetTimeintBoxValue()
        {
            return Timeinttxt.Text;
        }
        public string GetInitblBoxValue()
        {
            return Initbltxt.Text;
        }
        public string GetTotalBoxValue()
        {
            return Totaltxt.Text;
        }
        public bool getrestart()
        {
            return restart;
        }




        private void Contbtn_Click(object sender, EventArgs e)
        {
            Timer timer2 = new Timer(); // Needed to allow form switching ?

            Timer.timerstatic.Show();
            this.Hide();
            this.Close();
            
            
        }

        

        

        private void textBox1_Leave(object sender, EventArgs e)
        {
            // Move data from textbox to listbox & array & clear box when we leave the textbox
            Playerslst.Items.Add(textBox1.Text);
            playersarray[x] = textBox1.Text;
            x++;
            textBox1.Text = "";
            playerstxt.Text = System.Convert.ToString(Playerslst.Items.Count);
            Totalcashtxt.Text = System.Convert.ToString((Playerslst.Items.Count * System.Convert.ToInt32(Totaltxt.Text)));
        }

        private void seatbtn_Click(object sender, EventArgs e)
        {
            // This section scrambles the player list & creates the seating chart
            int b = 0;
            int m = 0;
            int p = 0;
            int totalplayer = 0;
            int tables = 0;
         
            totalplayer = System.Convert.ToInt32(playerstxt.Text);
            //Load playersarray with paid players list
            x = totalplayer;
            for (int i = 0; i != x; i++)
            {
                playersarray[i] = Convert.ToString(Playerslst.Items[i]);
            }

     // Figure out how many tables are needed
            if (totalplayer < 11)
            {
                tables = 1;
                               
            }
            else if (totalplayer > 10 && totalplayer < 21)
            {
                tables = 2;
            }
            else if (totalplayer > 20 && totalplayer < 31)
            {
                tables = 3;
            }
            else if (totalplayer > 30 && totalplayer < 41)
            {
                tables = 4;
            }
            else if (totalplayer > 40 && totalplayer < 51)
            {
                tables = 5;
            }
            else if (totalplayer > 50 && totalplayer < 61)
            {
                tables = 6;
            }
            else if (totalplayer > 60 && totalplayer < 71)
            {
                tables = 7;
            }
            else if (totalplayer > 70 && totalplayer < 81)
            {
                tables = 8;
            }
            else if (totalplayer > 80 && totalplayer < 91)
            {
                tables = 9;
            }
            else if (totalplayer > 90)
            {
                tables = 10;
            }
            

            // scramble the array
          
            Random random = new Random();
            bool redo = false;
            int w = 0;
            int v = 0;
            int g = 0;
           int y = totalplayer;
           int[] compare = new int[y];

           clearall(); //clear the form

            for (int i = 0; i != y; i++)
            {
                if (tables == 1)
                {
                    v = 1;
                    Table1.Visible = true;
                    tbl1.Visible = true;
                }
                v = 0;

                    w = random.Next(1, (totalplayer + 1));
                // this section insures we do not display the same player twice (unique random number)
                    for (int f = 0; f != y; f++)
                    {
                        if (w == compare[f]) // see if the number is already used
                        {
                            redo = true;
                        }

                    }

                    if (redo == true)
                    {
                        i = i - 1;
                        redo = false;
                    }
                    else
                    {
                        tablechart[(v), w] = playersarray[i];  // load tablechart array with player
                        
                        compare[g] = w;  // the compare array holds all the used numbers, so load it
                        g++;
                    }
            
    }
    
            // all players are now scrambled
            // save names to file so we can create final table list

    filename = @"c:\the\allplayers.fnl";
    File.Delete(filename);
    StreamWriter sw = new StreamWriter(filename);
    string tempallnames = "";
    for (int i = 0; i != y; i++)
    {
        tempallnames = playersarray[i];
        sw.WriteLine(tempallnames);
    }
    sw.Close();


                if (tables == 1)
                {
                    Table1.Items.Clear();
                    int n = 1;
                    for (int j = 1; j != y +1 ; j++)
                        // load table 1 list with list of players ( n = seat position)
                    {
                        Table1.Items.Add(n + " - " + tablechart[0, j]);
                         n++;
                    }
                    b = n;
                                                    
                }
                if (tables == 2)
                {
                    Table1.Items.Clear();
                    Table2.Items.Clear();
                    int n = 1;
                    Table1.Visible = true;
                    tbl1.Visible = true;
                    Table2.Visible = true;
                    tbl2.Visible = true;
                    m = y / 2;
                    for (int j = 1; j != (m + 1); j++)
                    {
                        Table1.Items.Add(n + " - " + tablechart[0, j]);
                        n++;
                    }
                    for (int j = (m +1); j!= (y + 1); j++)
                    {
                        Table2.Items.Add(((n+1) - (m+1)) + " - " + tablechart[0, j]);
                        n++;
                    }

                }

                if (tables == 3)
                {
                    Table1.Items.Clear();
                    Table2.Items.Clear();
                    Table3.Items.Clear();
                    int n = 1;
                     p = 0;
                    Table1.Visible = true;
                    tbl1.Visible = true;
                    Table2.Visible = true;
                    tbl2.Visible = true;
                    Table3.Visible = true;
                    tbl3.Visible = true;
                    m = y / 3;
                  // j = player position in array
                    
                    for (int j = 1; j != (m + 1); j++)
                    {
                        Table1.Items.Add(n + " - " + tablechart[0, j]);
                        n++;
                    }
                    int y2 = (y - m) / 2;
                    for (int j = (m + 1); j != ((y - y2) + 1) ; j++)
                    {
                        Table2.Items.Add(((n + 1) - (m + 1)) + " - " + tablechart[0, j]);
                        n++;
                    }
                    b = n;  // b = last seat position used
                    for (int j = (((y - y2) + 1 )) ; j != (y + 1); j++)
                    {
                       // seat position = current count + 1 - last count used (needed if count not divisable by 3 evenly)
                        Table3.Items.Add(((n + 1) - b)  + " - " + tablechart[0, j]);
                        n++;
                    }
                    b = n;

                }
            if (tables == 4)
            {
                Table1.Items.Clear();
                Table2.Items.Clear();
                Table3.Items.Clear();
                Table4.Items.Clear();
                
                int n = 1;
                p = 0;
                int remainder = 0;
                Table1.Visible = true;
                tbl1.Visible = true;
                Table2.Visible = true;
                tbl2.Visible = true;
                Table3.Visible = true;
                tbl3.Visible = true;
                Table4.Visible = true;
                tbl4.Visible = true;
                m = y / 4;
                int t1t = m;  //table 1 total players
                int t2t = m + m;  //table 2 total players 
                int t3t = m +m + m;  // table 3 totoal players
                int t4t = m + m + m + m;  //table 4 total players
                remainder = y - (4 * m);
                // figure remainder so tables balance out
                if (remainder == 3)
                {
                     t1t = (m + 1);
                     t2t = (m + m + 2);
                     t3t = (m + m + m + 3);
                     t4t = (m + m + m + m + 3);
                }
                if (remainder == 2)
                {
                    t1t = (m + 1);
                    t2t = (m + m + 2);
                    t3t = (m + m + m + 2);
                    t4t = (m + m + m + m + 2);
                    
                }
                if (remainder == 1)
                {
                    t1t = (m + 1);
                    t2t = (m + m + 1);
                    t3t = (m + m + m + 1);
                    t4t = (m + m + m + m + 1);
                    
                }

                for (int j = 1; j != t1t + 1; j++)
                {
                    Table1.Items.Add(n +  " - " + tablechart[0,j]);
                    n++;
                    // create table 1 chart
                }
                b = n; //last player position used
              int n2 = 1;   //Line counter reset
                for (int j = b ; j != t2t + 1; j++)
                {
                    Table2.Items.Add(n2 + " - " + tablechart[0, j]);
                    n2++;
                    n++;
                    //CREATE TABLE 2 CHART
                }
                b = n;// last player pos. used
                int n3 = 1;//Line counter reset
                for (int j = b  ; j != t3t + 1; j++)
                {
                    Table3.Items.Add(n3 + " - " + tablechart[0, j]);
                    n3++;
                    n++;
                    //CREATE TABLE 3 CHART
                }
                b = n;// last player pos. used
                int n4 = 1;//Line counter reset
                for (int j = b; j != t4t + 1; j++)
                {
                    Table4.Items.Add(n4 + " - " + tablechart[0, j]);
                    n4++;
                    n++;
                    //CREATE TABLE 4 CHART
                }
                b = n;// last player pos. used


            }



           
          }

        private void clearall()
        {
            playerstxt.Visible = false;
            chipstxt.Visible = false;
            Timeinttxt.Visible = false;
            Initbltxt.Visible = false;
            Housetxt.Visible = false;
            Payoutstxt.Visible = false;
            Totaltxt.Visible = false;
            Totalcashtxt.Visible = false;
            Playerslbl.Visible = false;
            chipslbl.Visible = false;
            Timeintlbl.Visible = false;
            Initbldlbl.Visible = false;
            Houselbl.Visible = false;
            Payoutslbl.Visible = false;
            tblbl.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            hhtxt.Visible = false;
            bntytxt.Visible = false;
            Contbtn.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            Playerslbl.Visible = false;
            Playerslst.Visible = false;
            textBox1.Visible = false;
            delbtn.Visible = false;
            textBox2.Visible = false;
            archivelst.Visible = false;
            returnbtn.Visible = true;
            button1.Visible = false;
            Newgamebtn.Visible = false;
            swap.Visible = false;



            
            
        }

        private void Totalcashtxt_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Focus();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            archivelst.Items.Remove(archivelst.SelectedItem);
            int arccount = archivelst.Items.Count;
            string[] temp = new string[100];
        }

        

        

       

       

        

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                //Looks for enter key press while entering name in textbox
                archivelst.Items.Add(textBox2.Text);
                textBox2.Text = "";
                int arccount = archivelst.Items.Count;
            }
        }

       
        private void returnbtn_Click(object sender, EventArgs e)
        {
            showall();
        }

        private void showall()
        {
            playerstxt.Visible = true;
            chipstxt.Visible = true;
            Timeinttxt.Visible = true;
            Initbltxt.Visible = true;
            Housetxt.Visible = true;
            Payoutstxt.Visible = true;
            Totaltxt.Visible = true;
            Totalcashtxt.Visible = true;
            Playerslbl.Visible = true;
            Playerslst.Visible = true;
            chipslbl.Visible = true;
            Timeintlbl.Visible = true;
            Initbldlbl.Visible = true;
            Houselbl.Visible = true;
            Payoutslbl.Visible = true;
            tblbl.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            hhtxt.Visible = false;
            bntytxt.Visible = false;
            Contbtn.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            Playerslst.Visible = true;
            textBox1.Visible = false;
            delbtn.Visible = true;
            textBox2.Visible = true;
            archivelst.Visible = true;
            Table1.Visible = false;
            Table2.Visible = false;
            Table3.Visible = false;
            Table4.Visible = false;
            Table5.Visible = false;
            tbl1.Visible = false;
            tbl2.Visible = false;
            tbl3.Visible = false;
            tbl4.Visible = false;
            tbl5.Visible = false;
            swap.Visible = false;
            returnbtn.Visible = false;
            button1.Visible = true;
            Newgamebtn.Visible = true;

        }

        private void archivelst_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // moves item from archive list to players list
            Playerslst.Items.Add(archivelst.SelectedItem);
            //playersarray[x] = System.Convert.ToString(archivelst.SelectedItem);
            //x++;
            //  textBox1.Text = "";
            playerstxt.Text = System.Convert.ToString(Playerslst.Items.Count);
            Totalcashtxt.Text = System.Convert.ToString((Playerslst.Items.Count * System.Convert.ToInt32(Totaltxt.Text)));
       

        }

        private void showchartbtn_Click(object sender, EventArgs e)
        {
            clearall();
            Table1.Visible = true;
            Table2.Visible = true;
            Table3.Visible = true;
            Table4.Visible = true;
            Table5.Visible = true;
            returnbtn.Visible = true;
            swap.Visible = false;
            tbl1.Visible = true;
            tbl2.Visible = true;
            tbl3.Visible = true;
            tbl4.Visible = true;
            tbl5.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // del button for players list
            Playerslst.Items.Remove(Playerslst.SelectedItem);
            int temp = Convert.ToInt32(playerstxt.Text);
            temp = temp - 1;
            playerstxt.Text = Convert.ToString(temp);
            Totalcashtxt.Text = System.Convert.ToString((Playerslst.Items.Count * System.Convert.ToInt32(Totaltxt.Text)));
         
            
        }

        private void Newgamebtn_Click(object sender, EventArgs e)
        {
            Array.Clear(playersarray, 0, playersarray.Length);
            Playerslst.Items.Clear();
            Array.Clear(tablechart, 0, tablechart.Length);
            restart = true;
            x = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int j = 1; j != 38; j++)
            {
                Playerslst.Items.Add(System.Convert.ToString(j));
                playersarray[x] = System.Convert.ToString(j);
                x++;
                //  textBox1.Text = "";
                playerstxt.Text = System.Convert.ToString(Playerslst.Items.Count);
                Totalcashtxt.Text = System.Convert.ToString((Playerslst.Items.Count * System.Convert.ToInt32(Totaltxt.Text)));
       
            }
        }

       

        private void swap_Click(object sender, EventArgs e)
        {
            try
            {
                string tb1sel = "";
                string tb2sel = "";
                string tb1num = "";
                string tb2num = "";
               
                tb1sel = Table1.SelectedItem.ToString();
                tb2sel = Table2.SelectedItem.ToString();
                string s1 = tb1sel.Substring(0, 4);
                string s2 = tb2sel.Substring(0, 4);
                tb1sel = tb1sel.Remove(0, 4);
                tb2sel = tb2sel.Remove(0, 4);
                tb1sel = s2 + tb1sel;
                tb2sel = s1 + tb2sel;
                int x1 = Table1.SelectedIndex;
                int x2 = Table2.SelectedIndex;
                Table1.Items.Insert(x1, tb2sel);
                Table1.Items.RemoveAt(x1 + 1);
                Table2.Items.Insert(x2, tb1sel);
                Table2.Items.RemoveAt(x2 + 1);
               
            }
            catch
            {
            }
            ///////////////////////////////////////////////////////
            try
            {
                
                string tb2sel = "";
                
                string tb2num = "";
                string tb3sel = "";
                
                string tb3num = "";
                
                tb3sel = Table3.SelectedItem.ToString();
                tb2sel = Table2.SelectedItem.ToString();
                string s1 = tb3sel.Substring(0, 4);
                string s2 = tb2sel.Substring(0, 4);
                tb3sel = tb3sel.Remove(0, 4);
                tb2sel = tb2sel.Remove(0, 4);
                tb3sel = s2 + tb3sel;
                tb2sel = s1 + tb2sel;
                int x1 = Table3.SelectedIndex;
                int x2 = Table2.SelectedIndex;
                Table3.Items.Insert(x1, tb2sel);
                Table3.Items.RemoveAt(x1 + 1);
                Table2.Items.Insert(x2, tb3sel);
                Table2.Items.RemoveAt(x2 + 1);

            }
            catch
            {
            }
               
            try
            {
                string tb4sel = "";
                
                string tb4num = "";
                string tb3sel = "";
                
                string tb3num = "";
                
                tb3sel = Table3.SelectedItem.ToString();
                tb4sel = Table4.SelectedItem.ToString();
                string s1 = tb3sel.Substring(0, 4);
                string s2 = tb4sel.Substring(0, 4);
                tb3sel = tb3sel.Remove(0, 4);
                tb4sel = tb4sel.Remove(0, 4);
                tb3sel = s2 + tb3sel;
                tb4sel = s1 + tb4sel;
                int x1 = Table3.SelectedIndex;
                int x2 = Table4.SelectedIndex;
                Table3.Items.Insert(x1, tb4sel); 
                Table3.Items.RemoveAt(x1 + 1);
                Table4.Items.Insert(x2, tb3sel);
                Table4.Items.RemoveAt(x2 + 1);

            }
            catch
            {
            }

        }

        private void returnbtn_MouseClick(object sender, MouseEventArgs e)
        {
            int a = 1;
        }

        private void returnbtn_MouseUp(object sender, MouseEventArgs e)
        {
            int a = 1;
            if (e.Button == MouseButtons.Right)
            {
                swap.Visible = true;
            }
        }

        private void swap_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                swap.Visible = false;
            }
        }

        

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //See if c:\the folder exists

            if (Directory.Exists(desdir))
                desdir = desdir;
            else
                Directory.CreateDirectory(desdir);
            blank();

            try
            {
                // Get profile  andload form
                OpenFileDialog();
                string[] readtext = System.IO.File.ReadAllLines(filenamepro);
                int z = 0;
                foreach (string s in readtext)
                {
                    if (z == 0)
                        playerstxt.Text = s;
                    else if (z == 1)
                        Housetxt.Text = s;
                    else if (z == 2 & s != "")
                    {
                        hhtxt.Text = s;
                        checkBox1.Checked = true;
                            
                       
                    }
                    else if (z == 3 & s != "")
                    {
                        bntytxt.Text = s;
                        checkBox2.Checked = true;
                                        
                    }
                    else if (z == 4)
                        Payoutstxt.Text = s;
                    else if (z == 5)
                        chipstxt.Text = s;
                    else if (z == 6)
                        Timeinttxt.Text = s;
                    else if (z == 7)
                        Initbltxt.Text = s;
                    else if (z == 8)
                        Totaltxt.Text = s;
                    z++;

                }
            }
            catch
            {
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //See if c:\the folder exists

            if (Directory.Exists(desdir))
                desdir = desdir;
            else
                Directory.CreateDirectory(desdir);
            blank();

            try
            {
                // Get profile  andload form
                OpenFileDialog();
                string[] readtext = System.IO.File.ReadAllLines(filenamepro);
                int z = 0;
                foreach (string s in readtext)
                {
                    if (z == 0)
                        playerstxt.Text = s;
                    else if (z == 1)
                        Housetxt.Text = s;
                    else if (z == 2 & s != "")
                    {
                        hhtxt.Text = s;
                        checkBox1.Checked = true;
                            
                       
                    }
                    else if (z == 3 & s != "")
                    {
                        bntytxt.Text = s;
                        checkBox2.Checked = true;
                                        
                    }
                    else if (z == 4)
                        Payoutstxt.Text = s;
                    else if (z == 5)
                        chipstxt.Text = s;
                    else if (z == 6)
                        Timeinttxt.Text = s;
                    else if (z == 7)
                        Initbltxt.Text = s;
                    else if (z == 8)
                        Totaltxt.Text = s;
                    z++;

                }
            }
            catch
            {
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //See if c:\the folder exists

            if (Directory.Exists(desdir))
                desdir = desdir;
            else
                Directory.CreateDirectory(desdir);

            try
            {
                SaveFileDialog();

                string[] createtext = { playerstxt.Text, Housetxt.Text, hhtxt.Text, bntytxt.Text, Payoutstxt.Text, chipstxt.Text, Timeinttxt.Text, Initbltxt.Text, Totaltxt.Text };
                System.IO.File.WriteAllLines(filenamepro, createtext);

            }
            catch
            {
            }

        }

        private void displaySeatingChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearall();
            Table1.Visible = true;
            Table2.Visible = true;
            Table3.Visible = true;
            Table4.Visible = true;
            Table5.Visible = true;            
            returnbtn.Visible = true;
            swap.Visible = false;
            tbl1.Visible = true;
            tbl2.Visible = true;
            tbl3.Visible = true;
            tbl4.Visible = true;
            tbl5.Visible = true;
         }

        private void createNewSeatingChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // This section scrambles the player list & creates the seating chart
            int b = 0;
            int m = 0;
            int p = 0;
            int totalplayer = 0;
            int tables = 0;

            totalplayer = System.Convert.ToInt32(playerstxt.Text);
            //Load playersarray with paid players list
            x = totalplayer;
            for (int i = 0; i != x; i++)
            {
                playersarray[i] = Convert.ToString(Playerslst.Items[i]);
            }

            // Figure out how many tables are needed
            if (totalplayer < 11)
            {
                tables = 1;

            }
            else if (totalplayer > 10 && totalplayer < 21)
            {
                tables = 2;
            }
            else if (totalplayer > 20 && totalplayer < 31)
            {
                tables = 3;
            }
            else if (totalplayer > 30 && totalplayer < 41)
            {
                tables = 4;
            }
            else if (totalplayer > 40 && totalplayer < 51)
            {
                tables = 5;
            }
            else if (totalplayer > 50 && totalplayer < 61)
            {
                tables = 6;
            }
            else if (totalplayer > 60 && totalplayer < 71)
            {
                tables = 7;
            }
            else if (totalplayer > 70 && totalplayer < 81)
            {
                tables = 8;
            }
            else if (totalplayer > 80 && totalplayer < 91)
            {
                tables = 9;
            }
            else if (totalplayer > 90)
            {
                tables = 10;
            }


            // scramble the array

            Random random = new Random();
            bool redo = false;
            int w = 0;
            int v = 0;
            int g = 0;
            int y = totalplayer;
            int[] compare = new int[y];

            clearall(); //clear the form

            for (int i = 0; i != y; i++)
            {
                if (tables == 1)
                {
                    v = 1;
                    Table1.Visible = true;
                    tbl1.Visible = true;
                }
                v = 0;

                w = random.Next(1, (totalplayer + 1));
                // this section insures we do not display the same player twice (unique random number)
                for (int f = 0; f != y; f++)
                {
                    if (w == compare[f]) // see if the number is already used
                    {
                        redo = true;
                    }

                }

                if (redo == true)
                {
                    i = i - 1;
                    redo = false;
                }
                else
                {
                    tablechart[(v), w] = playersarray[i];  // load tablechart array with player

                    compare[g] = w;  // the compare array holds all the used numbers, so load it
                    g++;
                }

            }

            // all players are now scrambled
            // save names to file so we can create final table list

            filename = @"c:\the\allplayers.fnl";
            File.Delete(filename);
            StreamWriter sw = new StreamWriter(filename);
            string tempallnames = "";
            for (int i = 0; i != y; i++)
            {
                tempallnames = playersarray[i];
                sw.WriteLine(tempallnames);
            }
            sw.Close();


            if (tables == 1)
            {
                Table1.Items.Clear();
                int n = 1;
                for (int j = 1; j != y + 1; j++)
                // load table 1 list with list of players ( n = seat position)
                {
                    Table1.Items.Add(n + " - " + tablechart[0, j]);
                    n++;
                }
                b = n;

            }
            if (tables == 2)
            {
                Table1.Items.Clear();
                Table2.Items.Clear();
                int n = 1;
                Table1.Visible = true;
                tbl1.Visible = true;
                Table2.Visible = true;
                tbl2.Visible = true;
                m = y / 2;
                for (int j = 1; j != (m + 1); j++)
                {
                    Table1.Items.Add(n + " - " + tablechart[0, j]);
                    n++;
                }
                for (int j = (m + 1); j != (y + 1); j++)
                {
                    Table2.Items.Add(((n + 1) - (m + 1)) + " - " + tablechart[0, j]);
                    n++;
                }

            }

            if (tables == 3)
            {
                Table1.Items.Clear();
                Table2.Items.Clear();
                Table3.Items.Clear();
                int n = 1;
                p = 0;
                Table1.Visible = true;
                tbl1.Visible = true;
                Table2.Visible = true;
                tbl2.Visible = true;
                Table3.Visible = true;
                tbl3.Visible = true;
                m = y / 3;
                // j = player position in array

                for (int j = 1; j != (m + 1); j++)
                {
                    Table1.Items.Add(n + " - " + tablechart[0, j]);
                    n++;
                }
                int y2 = (y - m) / 2;
                for (int j = (m + 1); j != ((y - y2) + 1); j++)
                {
                    Table2.Items.Add(((n + 1) - (m + 1)) + " - " + tablechart[0, j]);
                    n++;
                }
                b = n;  // b = last seat position used
                for (int j = (((y - y2) + 1)); j != (y + 1); j++)
                {
                    // seat position = current count + 1 - last count used (needed if count not divisable by 3 evenly)
                    Table3.Items.Add(((n + 1) - b) + " - " + tablechart[0, j]);
                    n++;
                }
                b = n;

            }
            if (tables == 4)
            {
                Table1.Items.Clear();
                Table2.Items.Clear();
                Table3.Items.Clear();
                Table4.Items.Clear();
                int n = 1;
                p = 0;
                int remainder = 0;
                Table1.Visible = true;
                tbl1.Visible = true;
                Table2.Visible = true;
                tbl2.Visible = true;
                Table3.Visible = true;
                tbl3.Visible = true;
                Table4.Visible = true;
                tbl4.Visible = true;
                m = y / 4;
                int t1t = m;  //table 1 total players
                int t2t = m + m;  //table 1 + 2 total players 
                int t3t = m + m + m;  // table 1 + 2 + 3 totoal players
                int t4t = m + m + m + m;  //table  1 + 2 + 3 + 4 total players
                remainder = y - (4 * m);
                // figure remainder so tables balance out
                /* The way this section works is tit, is all the players for table 1
                 * T2t  is all the players fromtable 1 & table 2. t3t is all the players for 
                 * tables 1, 2, & 3. m is the total players / total tables without a fraction.
                 * ie remainder 3 add, 1 player to table 1, 2 players to table 2 ( one additional from table 1)
                 * t3t adds 1 additional, (for a total of 2) and table 4 is the same number as table 2.
                 * so we have 1 added player to table 1, 1 added player to table 2, and 1 added player
                 * to table 3. table 4 gets no added player. (note t4t is the sum total players for all tables
                 * */
                if (remainder == 3)
                {
                    t1t = (m + 1);
                    t2t = (m + m + 2);
                    t3t = (m + m + m + 3);
                    t4t = (m + m + m + m + 3);
                }
                if (remainder == 2)
                {
                    t1t = (m + 1);
                    t2t = (m + m + 2);
                    t3t = (m + m + m + 2);
                    t4t = (m + m + m + m + 2);

                }
                if (remainder == 1)
                {
                    t1t = (m + 1);
                    t2t = (m + m + 1);
                    t3t = (m + m + m + 1);
                    t4t = (m + m + m + m + 1);

                }

                for (int j = 1; j != t1t + 1; j++)
                {
                    Table1.Items.Add(n + " - " + tablechart[0, j]);
                    n++;
                    // create table 1 chart
                }
                b = n; //last player position used
                int n2 = 1;   //Line counter reset
                for (int j = b; j != t2t + 1; j++)
                {
                    Table2.Items.Add(n2 + " - " + tablechart[0, j]);
                    n2++;
                    n++;
                    //CREATE TABLE 2 CHART
                }
                b = n;// last player pos. used
                int n3 = 1;//Line counter reset
                for (int j = b; j != t3t + 1; j++)
                {
                    Table3.Items.Add(n3 + " - " + tablechart[0, j]);
                    n3++;
                    n++;
                    //CREATE TABLE 2 CHART
                }
                b = n;// last player pos. used
                int n4 = 1;//Line counter reset
                for (int j = b; j != t4t + 1; j++)
                {
                    Table4.Items.Add(n4 + " - " + tablechart[0, j]);
                    n4++;
                    n++;
                    //CREATE TABLE 2 CHART
                }
                b = n;// last player pos. used

                /*  Start new code
                 */
            if (tables == 5)
            {
                Table1.Items.Clear();
                Table2.Items.Clear();
                Table3.Items.Clear();
                Table4.Items.Clear();
                Table5.Items.Clear();

                n = 1; //line count
                p = 0; //?????
                remainder = 0;
                Table1.Visible = true;
                tbl1.Visible = true;
                Table2.Visible = true;
                tbl2.Visible = true;
                Table3.Visible = true;
                tbl3.Visible = true;
                Table4.Visible = true;
                tbl4.Visible = true;
                Table5.Visible = true;
                tbl5.Visible = true;
                // Show tables & labels
                m = y / 5;  //find min playes for each table (y = total players)
                t1t = m;  //table 1 total players
                t2t = m + m;  //table 1 + 2 total players 
                t3t = m + m + m;  // table 1 + 2 + 3 totoal players
                t4t = m + m + m + m;  //table  1 + 2 + 3 + 4 total players
                int t5t = m + m + m + m + m; //table 1 + 2 + 3 + 4 + 5 total players

                remainder = y - (5 * m);
                // balance tables
                if (remainder == 4)
                {
                    t1t = (m + 1);
                    t2t = (m + m + 2);
                    t3t = (m + m + m + 3);
                    t4t = (m + m + m + m + 4);
                    t5t = (m + m + m + m + m + 4);
                }

                if (remainder == 3)
                {
                    t1t = (m + 1);
                    t2t = (m + m + 2);
                    t3t = (m + m + m + 3);
                    t4t = (m + m + m + m + 3);
                }
                if (remainder == 2)
                {
                    t1t = (m + 1);
                    t2t = (m + m + 2);
                    t3t = (m + m + m + 2);
                    t4t = (m + m + m + m + 2);
                }
                if (remainder == 1)
                {   
                    t1t = (m + 1);
                    t2t = (m + m + 1);
                    t3t = (m + m + m + 1);
                    t4t = (m + m + m + m + 1);

                }


                for (int j = 1; j != t1t + 1; j++)
                {
                    Table1.Items.Add(n + " - " + tablechart[0, j]);
                    n++;
                    // create table 1 chart
                }
                b = n; //last player position used
                n2 = 1;   //Line counter reset
                for (int j = b; j != t2t + 1; j++)
                {
                    Table2.Items.Add(n2 + " - " + tablechart[0, j]);
                    n2++;
                    n++;
                    //CREATE TABLE 2 CHART
                }
                b = n;// last player pos. used
                n3 = 1;//Line counter reset
                for (int j = b; j != t3t + 1; j++)
                {
                    Table3.Items.Add(n3 + " - " + tablechart[0, j]);
                    n3++;
                    n++;
                    //CREATE TABLE 3 CHART
                }
                b = n;// last player pos. used
                n4 = 1;//Line counter reset
                for (int j = b; j != t4t + 1; j++)
                {
                    Table4.Items.Add(n4 + " - " + tablechart[0, j]);
                    n4++;
                    n++;
                    //CREATE TABLE 4 CHART

                }
                b = n;// last player pos. used
                int n5 = 1;//Line counter reset
                for (int j = b; j != t5t + 1; j++)
                {
                    Table5.Items.Add(n5 + " - " + tablechart[0, j]);
                    n5++;
                    n++;
                    //CREATE TABLE 5 CHART
                }



                b = n;// last player pos. used




            }
                 
                 /* End new code
                  */
                 


            }




        }

        private void loadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //See if c:\the folder exists
            if (Directory.Exists(desdir))
                desdir = desdir;
            else
                Directory.CreateDirectory(desdir);
            //     blank();
            OpenFileDialogpl();
            if (filename == "")
            {
                filename = @"c:\the\names.txt";
            }
            string line = "";

            archivelst.Items.Clear();
            Playerslst.Items.Clear();
            StreamReader sr = new StreamReader(filename);
            while ((line = sr.ReadLine()) != null)
            {
                archivelst.Items.Add(line);
            }
            sr.Close();

        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //See if c:\the folder exists

            if (Directory.Exists(desdir))
                desdir = desdir;
            else
                Directory.CreateDirectory(desdir);
            //blank();
            SaveFileDialogpl();
            if (filename == "")
            {
                filename = @"c:\the\names.txt";
            }

            int arccount = archivelst.Items.Count;
            string[] temp = new string[100];

            StreamWriter sw = new StreamWriter(filename);

            try
            {
                for (int i = 0; i != arccount; i++)
                {
                    temp[i] = archivelst.Items[i].ToString();
                    sw.WriteLine(temp[i]);
                }
            }
            catch
            {
            }

            sw.Close();
        }

        private void Table5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }






    
}