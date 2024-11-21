// Version 3.xxxy

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using System.IO;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Media;

namespace Texas_Holdem
{



    public partial class Timer : Form
    {

        int Players = 0;
        int House = 0;
        int HH = 0;
        int Bnty = 0;
        int Payouts = 0;
        string Chips = "";
        string Timeint = "";
        string Initbl = "";
        decimal Total = 0;
        string mins = "20";
        bool restart = false;
        bool breaktime = false;
        bool beenhere = false;
        string secs = "00";
        int minutes = 0;
        int seconds = 0;
        bool level0 = false;
        bool level1 = false;
        bool level2 = false;
        bool level3 = false;
        bool level4 = false;
        bool level5 = false;
        bool level6 = false;
        bool level7 = false;
        bool level8 = false;
        bool level9 = false;
        bool level10 = false;
        bool nextlevelwait = false;  // flag used to stop the levels from incrementing too soon
        int littleblind = 0;
        int bigblind = 0;
        int levelcnt = 0; // Count used to regulate sound and reset cycles
        // % values for prize money
        decimal fifth1 = .42M;
        decimal fifth2 = .25M;
        decimal fifth3 = .15M;
        decimal fifth4 = .10M;
        decimal fifth5 = .08M;
        decimal fourth1 = .46M;
        decimal fourth2 = .27M;
        decimal fourth3 = .17M;
        decimal fourth4 = .10M;
        decimal third1 = .50M;
        decimal third2 = .30M;
        decimal third3 = .20M;
        decimal second1 = .70M;
        decimal second2 = .30M;
        int rebuycount = 0;

        string[] playersarray = new string[99];


        public string GetlostplayerBoxValue()
        {
            return lostplayer.Text;
        }






        // needed to maintain form when switching between forms
        public static Timer timerstatic = null;

        Init_Screen init2 = new Init_Screen(); //Needed to get info from other screen
        public Timer()
        {
            InitializeComponent();
            // Get profile data
            timer1.Enabled = false;
            timer2.Enabled = false;
            StartTimerbtn.Enabled = false;
            Pausebtn.Enabled = false;
            secretbox1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            housetxt.Visible = false;
            Highhandtxt.Visible = false;
            Bountytxt.Visible = false;




        }


        private void Timer_Load(object sender, EventArgs e)
        {
            level0 = true;  // Start at first level
            firsttxt.Text = "";
            secondtxt.Text = "";
            thirdtxt.Text = "";
            fourthtxt.Text = "";
            fifthtxt.Text = "";
            firsttxt.Visible = false;
            secondtxt.Visible = false;
            thirdtxt.Visible = false;
            fourthtxt.Visible = false;
            fifthtxt.Visible = false;

        }



        private void StartTimerbtn_Click(object sender, EventArgs e)
        {



            levelcnt = 0;
            timer1.Enabled = true;
            StartTimerbtn.Enabled = false;
            Pausebtn.Enabled = true;
            timer2.Enabled = false;



        }

        
        private void playsound()

        {
            SoundPlayer alarm = new SoundPlayer(@"C:\Windows\Media\Alarm01.wav");
            alarm.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {



            seconds = seconds - 1; // Set clock to correct time, manage seconds and mins
            //minutes = Math.Abs(minutes);
            //seconds = Math.Abs(seconds);
            if (seconds < 0)
            {
                seconds = 59;
                minutes = minutes - 1;
            }
            if (minutes < 0)
            {
                minutes = 1;
                seconds = 0;
            }
            if (minutes == 0 && seconds == 0)
            {

                breaktime = false;
                timer1.Enabled = true;
                timer1.Enabled = false;
                timer1.Stop();
                timer2.Enabled = true;
                //   System.Media.SystemSounds.Beep.Play();
                // Play sound();
                //    System.Media.SystemSounds.Beep.Play();
                //    System.Media.SystemSounds.Beep.Play();
                playsound();



            }
                if (restart == true)
                {
                    level0 = true;
                    level1 = false;
                    level2 = false;
                    level3 = false;
                    level4 = false;
                    level5 = false;
                    level6 = false;
                    level7 = false;
                    level8 = false;
                    level9 = false;
                    level10 = false;
                    nextlevelwait = false;
                    restart = false;
                    levellbl.Text = "Level 1";


                }
                // figure out next level
                Timetxt.Text = String.Format("{0:0}", minutes) + " : " + String.Format("{0:00}", seconds);
                if (level0 == true)
                {
                    littleblind = System.Convert.ToInt32(Initbl);
                    bigblind = littleblind * 2;
                    lblbl.Text = System.Convert.ToString(littleblind);
                    bglbl.Text = System.Convert.ToString(bigblind);
                    levellbl.Text = "Level 1";

                }
                else if (level1 == true)
                {
                    littleblind = (System.Convert.ToInt32(Initbl) * 2);
                    bigblind = littleblind * 2;
                    lblbl.Text = System.Convert.ToString(littleblind);
                    bglbl.Text = System.Convert.ToString(bigblind);
                    levellbl.Text = "Level 2";
                }
                else if (level2 == true)
                {
                    littleblind = (System.Convert.ToInt32(Initbl) * 3);
                    bigblind = littleblind * 2;
                    lblbl.Text = System.Convert.ToString(littleblind);
                    bglbl.Text = System.Convert.ToString(bigblind);
                    levellbl.Text = "Level 3";
                }
                else if (level3 == true)
                {
                    littleblind = (System.Convert.ToInt32(Initbl) * 4);
                    bigblind = littleblind * 2;
                    lblbl.Text = System.Convert.ToString(littleblind);
                    bglbl.Text = System.Convert.ToString(bigblind);
                    levellbl.Text = "Level 4";
                    if (breaktime == true)
                    {
                        lblbl.Text = "Break";
                        bglbl.Text = "Time";


                    }
                }
                else if (level4 == true)
                {
                    beenhere = false;
                    breaktime = false;
                    littleblind = (System.Convert.ToInt32(Initbl) * 5);
                    bigblind = littleblind * 2;
                    lblbl.Text = System.Convert.ToString(littleblind);
                    bglbl.Text = System.Convert.ToString(bigblind);
                    levellbl.Text = "Level 5";
                }
                else if (level5 == true)
                {

                    littleblind = (System.Convert.ToInt32(Initbl) * 10);
                    bigblind = littleblind * 2;
                    lblbl.Text = System.Convert.ToString(littleblind);
                    bglbl.Text = System.Convert.ToString(bigblind);
                    levellbl.Text = "Level 6";
                }
                else if (level6 == true)
                {
                    littleblind = (System.Convert.ToInt32(Initbl) * 20);
                    bigblind = littleblind * 2;
                    lblbl.Text = System.Convert.ToString(littleblind);
                    bglbl.Text = System.Convert.ToString(bigblind);
                    levellbl.Text = "Level 7";
                }
                else if (level7 == true)
                {
                    littleblind = (System.Convert.ToInt32(Initbl) * 30);
                    bigblind = littleblind * 2;
                    lblbl.Text = System.Convert.ToString(littleblind);
                    bglbl.Text = System.Convert.ToString(bigblind);
                    levellbl.Text = "Level 8";
                }
                else if (level8 == true)
                {
                    littleblind = (System.Convert.ToInt32(Initbl) * 40);
                    bigblind = littleblind * 2;
                    lblbl.Text = System.Convert.ToString(littleblind);
                    bglbl.Text = System.Convert.ToString(bigblind);
                    levellbl.Text = "Level 9";
                }
                else if (level9 == true)
                {
                    littleblind = (System.Convert.ToInt32(Initbl) * 50);
                    bigblind = littleblind * 2;
                    lblbl.Text = System.Convert.ToString(littleblind);
                    bglbl.Text = System.Convert.ToString(bigblind);
                    levellbl.Text = "Level 10";
                }
                else if (level10 == true)
                {
                    littleblind = (System.Convert.ToInt32(Initbl) * 100);
                    bigblind = littleblind * 2;
                    lblbl.Text = System.Convert.ToString(littleblind);
                    bglbl.Text = System.Convert.ToString(bigblind);
                    levellbl.Text = "Level 11";
                }



            }


        private void Pausebtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            StartTimerbtn.Enabled = true;
            timer2.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e) // this timer pauses between levels, and increments level
        {
            System.Media.SystemSounds.Beep.Play();
           // SoundPlayer alarm = new SoundPlayer(@"C:\Windows\Media\Alarm01.wav");



            if (level10 == true && nextlevelwait == false)
            {
                level10 = true;
                level9 = false;
            }
            else if (level9 == true && nextlevelwait == false)
            {
                level10 = true;
                level9 = false;
            }
            else if (level8 == true && nextlevelwait == false)
            {
                level9 = true;
                level8 = false;
            }

            else if (level7 == true && nextlevelwait == false)
            {
                level8 = true;
                level7 = false;
            }
            else if (level6 == true && nextlevelwait == false)
            {
                level7 = true;
                level6 = false;
            }
            else if (level5 == true && nextlevelwait == false)
            {
                level6 = true;
                level5 = false;

            }
            else if (level4 == true && nextlevelwait == false)
            {
                level5 = true;
                level4 = false;

            }
            else if (level3 == true && nextlevelwait == false)
            {
                if (beenhere == true)
                {
                    level4 = true;
                    level3 = false;

                }
                if (breaktime == false && beenhere == false)
                {
                    breaktime = true; // set breaktime bit, 
                    level3 = true;
                    level2 = false;

                }


            }
            else if (level2 == true && nextlevelwait == false)
            {
                level3 = true;
                level2 = false;
            }
            else if (level1 == true && nextlevelwait == false)
            {
                level2 = true;
                level1 = false;
            }
            else if (level0 == true && nextlevelwait == false)
            {
                level1 = true;
                level0 = false;
            }

            nextlevelwait = true;
            levelcnt++;
            if (levelcnt == 9)
            {
                levelcnt = 0;
                nextlevelwait = false;
                timer1.Enabled = true;
                timer2.Enabled = false;
                StartTimerbtn.Enabled = false;
                Pausebtn.Enabled = true;
                minutes = System.Convert.ToInt32(Timeint);
                if (breaktime == true)
                {
                    minutes = 5;
                    beenhere = true;

                }
            }

        }

        private void Timetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Timetxt_DoubleClick(object sender, EventArgs e)

        {
            //   seconds = System.Convert.ToInt32(secs);
            secretbox1.Visible = true;
            //    minutes = System.Convert.ToInt32(mins);
        }

        private void secretbox1_DoubleClick(object sender, EventArgs e)
        {
            minutes = System.Convert.ToInt32(secretbox1.Text);
            seconds = 0;
            secretbox1.Visible = false;

        }


        private void resetBlindsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            level0 = true;
            level1 = false;
            level2 = false;
            level3 = false;
            level4 = false;
            level5 = false;
            level6 = false;
            level7 = false;
            level8 = false;
            level9 = false;
            level10 = false;
            nextlevelwait = false;
            levellbl.Text = "Level 1";


        }

        private void nextLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            levelcnt = 0;
            //       levelcnt++;
            nextlevelwait = false;
            timer1.Enabled = true;
            timer2.Enabled = false;
            StartTimerbtn.Enabled = false;
            Pausebtn.Enabled = true;
            seconds = 0;
            minutes = System.Convert.ToInt32(Timeint);

            if (level10 == true && nextlevelwait == false)
            {
                level10 = true;
                level9 = false;
            }
            else if (level9 == true && nextlevelwait == false)
            {
                level10 = true;
                level9 = false;
            }
            else if (level8 == true && nextlevelwait == false)
            {
                level9 = true;
                level8 = false;
            }

            else if (level7 == true && nextlevelwait == false)
            {
                level8 = true;
                level7 = false;
            }
            else if (level6 == true && nextlevelwait == false)
            {
                level7 = true;
                level6 = false;
            }
            else if (level5 == true && nextlevelwait == false)
            {
                level6 = true;
                level5 = false;
            }
            else if (level4 == true && nextlevelwait == false)
            {
                level5 = true;
                level4 = false;
            }
            else if (level3 == true && nextlevelwait == false)
            {
                level4 = true;
                level3 = false;
            }
            else if (level2 == true && nextlevelwait == false)
            {
                level3 = true;
                level2 = false;
            }
            else if (level1 == true && nextlevelwait == false)
            {
                level2 = true;
                level1 = false;
            }
            else if (level0 == true && nextlevelwait == false)
            {
                level1 = true;
                level0 = false;
            }

            //        nextlevelwait = true;
            levelcnt++;
            if (levelcnt == 9)
            {
                levelcnt = 0;
                nextlevelwait = false;
                timer1.Enabled = true;
                timer2.Enabled = false;
                StartTimerbtn.Enabled = false;
                Pausebtn.Enabled = true;
                minutes = System.Convert.ToInt32(Timeint);

            }
        }

        private void getProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (rebuycount < 1)
            {
                init2.ShowDialog();
                Pausebtn.Enabled = true;
                StartTimerbtn.Enabled = true;
                timer1.Enabled = false;
                timer2.Enabled = false;
                level0 = true;
                firsttxt.Text = "";
                secondtxt.Text = "";
                thirdtxt.Text = "";
                fourthtxt.Text = "";
                fifthtxt.Text = "";
                firsttxt.Visible = false;
                secondtxt.Visible = false;
                thirdtxt.Visible = false;
                fourthtxt.Visible = false;
                fifthtxt.Visible = false;
                timerstatic = this;




                Players = System.Convert.ToInt32(init2.GetPlayerBoxValue());
                // Get values from init screen
                House = System.Convert.ToInt32(init2.GetHouseBoxValue());
                housetxt.Text = System.Convert.ToString(House * Players);
                HH = System.Convert.ToInt32(init2.GetHhBoxValue());
                Highhandtxt.Text = System.Convert.ToString((System.Convert.ToInt32(init2.GetHhBoxValue()) * System.Convert.ToInt32(init2.GetPlayerBoxValue())));
                Bnty = System.Convert.ToInt32(init2.GetBntyBoxValue());
                Bountytxt.Text = System.Convert.ToString(Bnty * Players);
                Payouts = System.Convert.ToInt32(init2.GetPayoutsBoxValue());
                Chips = init2.GetChipsBoxValue();
                Timeint = init2.GetTimeintBoxValue();
                restart = init2.getrestart();
                Initbl = init2.GetInitblBoxValue();
                Total = System.Convert.ToInt32(init2.GetTotalBoxValue());
                init2.Hide();
                mins = Timeint;
                secs = "00";
                seconds = System.Convert.ToInt32(secs);
                minutes = System.Convert.ToInt32(mins);
                Timetxt.Text = String.Format("{0:0}", minutes) + " : " + string.Format("{0:00}", seconds);


            }

            //Display prizes boxes
            if (Payouts == 5)
            {
                firsttxt.Visible = true;
                secondtxt.Visible = true;
                thirdtxt.Visible = true;
                fourthtxt.Visible = true;
                fifthtxt.Visible = true;
                decimal ttotal = (Total * Players);
                decimal thh = (HH * Players);
                decimal thouse = (House * Players);
                decimal tbnty = (Bnty * Players);
                decimal ptotal = (ttotal) + (rebuycount * Total);
                firsttxt.Text = System.Convert.ToString((ptotal * fifth1));
                secondtxt.Text = System.Convert.ToString((ptotal * fifth2));
                thirdtxt.Text = System.Convert.ToString((ptotal * fifth3));
                fourthtxt.Text = System.Convert.ToString((ptotal * fifth4));
                fifthtxt.Text = System.Convert.ToString((ptotal * fifth5));

            }

            if (Payouts == 4)
            {
                firsttxt.Visible = true;
                secondtxt.Visible = true;
                thirdtxt.Visible = true;
                fourthtxt.Visible = true;
                decimal ttotal = (Total * Players);
                decimal thh = (HH * Players);
                decimal thouse = (House * Players);
                decimal tbnty = (Bnty * Players);
                decimal ptotal = (ttotal) + (rebuycount * Total);
                firsttxt.Text = System.Convert.ToString((ptotal * fourth1));
                secondtxt.Text = System.Convert.ToString((ptotal * fourth2));
                thirdtxt.Text = System.Convert.ToString((ptotal * fourth3));
                fourthtxt.Text = System.Convert.ToString((ptotal * fourth4));

            }
            if (Payouts == 3)
            {
                firsttxt.Visible = true;
                secondtxt.Visible = true;
                thirdtxt.Visible = true;

                decimal ttotal = (Total * Players);
                decimal thh = (HH * Players);
                decimal thouse = (House * Players);
                decimal tbnty = (Bnty * Players);
                decimal ptotal = (ttotal) + (rebuycount * Total);
                firsttxt.Text = System.Convert.ToString((ptotal * third1));
                secondtxt.Text = System.Convert.ToString((ptotal * third2));
                thirdtxt.Text = System.Convert.ToString((ptotal * third3));

            }
            if (Payouts == 2)
            {
                firsttxt.Visible = true;
                secondtxt.Visible = true;


                decimal ttotal = (Total * Players);
                decimal thh = (HH * Players);
                decimal thouse = (House * Players);
                decimal tbnty = (Bnty * Players);
                decimal ptotal = (ttotal) + (rebuycount * Total);
                firsttxt.Text = System.Convert.ToString((ptotal * second1));
                secondtxt.Text = System.Convert.ToString((ptotal * second2));

            }

            if (Payouts == 1)
            {
                firsttxt.Visible = true;
                decimal ttotal = (Total * Players);
                decimal thh = (HH * Players);
                decimal thouse = (House * Players);
                decimal tbnty = (Bnty * Players);
                decimal ptotal = (ttotal) + (rebuycount * Total); //- (thh + thouse + tbnty));
                firsttxt.Text = System.Convert.ToString(ptotal);
            }
            //rebuycount = 0;
        }

        private void setNewTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            secretbox1.Visible = true;
            secrettext.Visible = true;
        }

        private void secretbox1_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == (char)13)
            {
                //Looks for enter key press while entering name in textbox
                minutes = System.Convert.ToInt32(secretbox1.Text);
                seconds = 0;
                secretbox1.Visible = false;
                secrettext.Visible = false;

            }
        }

        private void Highhandtxt_TextChanged(object sender, EventArgs e)
        {
            if (Highhandtxt.Text == "0")
            {
                label3.Visible = false;
                Highhandtxt.Visible = false;
            }
            else
            {
                label3.Visible = true;
                Highhandtxt.Visible = true;
            }

        }

        private void Bountytxt_TextChanged(object sender, EventArgs e)
        {
            if (Bountytxt.Text == "0")
            {
                label4.Visible = false;
                Bountytxt.Visible = false;
            }
            else
            {
                label4.Visible = true;
                Bountytxt.Visible = true;
            }
        }

        private void housetxt_TextChanged(object sender, EventArgs e)
        {
            if (housetxt.Text == "0")
            {
                label5.Visible = false;
                housetxt.Visible = false;
            }
            else
            {
                label5.Visible = true;
                housetxt.Visible = true;
            }
        }

        private void finalTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearall();
            string[] playersarray = new string[99];
            string[,] tablechart = new string[99, 99];
            int i = 0;
            string line = "";
            // load playersarray
            StreamReader sr = new StreamReader(@"c:\the\allplayers.fnl");
            while ((line = sr.ReadLine()) != null)
            {
                playersarray[i] = line;
                playerslst.Items.Add(line);
            }
            sr.Close();
            playerslst.Items.Clear();
            getplayers();
            playerslst.Visible = true;
            FinalTable.Visible = true;
            scramblebtn.Visible = true;
            clearbtn.Visible = true;
            delbtn.Visible = true;
            button2.Visible = true;

        }

        private void getplayers()
        {
            int i = 0;
            string line = "";

            Array.Clear(playersarray, 0, playersarray.Length);
            StreamReader sr = new StreamReader(@"c:\the\allplayers.fnl");
            playerslst.Items.Clear();

            while ((line = sr.ReadLine()) != null)
            {
                playersarray[i] = line;
                playerslst.Items.Add(line);
                i++;
            }
            sr.Close();
        }

        private void clearall()
        {
            playerslst.Visible = false;
            FinalTable.Visible = false;
            scramblebtn.Visible = false;
            clearbtn.Visible = false;
            delbtn.Visible = false;
            lasttable.Visible = false;
            button2.Visible = false;
            Timetxt.Visible = false;
            //label1.Visible = false;
            //label2.Visible = false;
            //label3.Visible = false;
            //label4.Visible = false;
            //label5.Visible = false;
            //firsttxt.Visible = false;
            //secondtxt.Visible = false;
            //thirdtxt.Visible = false;
            bglbl.Visible = false;
            lblbl.Visible = false;
            StartTimerbtn.Visible = false;
            Pausebtn.Visible = false;
            levellbl.Visible = false;
            panel1.Visible = false;

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            playerslst.Visible = false;
            FinalTable.Visible = false;
            scramblebtn.Visible = false;
            clearbtn.Visible = false;
            delbtn.Visible = false;
            lasttable.Visible = false;
            button2.Visible = false;
            Timetxt.Visible = true;
            //label1.Visible = true;
            //label2.Visible = true;
            //label3.Visible = true;
            //label4.Visible = true;
            //label5.Visible = true;
            //firsttxt.Visible = true;
            //secondtxt.Visible = true;
            //thirdtxt.Visible = true;
            bglbl.Visible = true;
            lblbl.Visible = true;
            StartTimerbtn.Visible = true;
            Pausebtn.Visible = true;
            levellbl.Visible = true;
            panel1.Visible = true;

        }

        private void playerslst_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FinalTable.Items.Add(playerslst.SelectedItem);
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            FinalTable.Items.Remove(FinalTable.SelectedItem);
        }

        public void scramblebtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            string[,] tablechart = new string[100, 100];
            bool redo = false;
            int totalplayers = 0;
            int w = 0;
            int v = 0;
            int g = 0;

            totalplayers = FinalTable.Items.Count;
            int[] compare = new int[totalplayers];

            // load the playersarry array
            for (int i = 0; i != totalplayers; i++)
            {
               playersarray[i] = FinalTable.Items[i].ToString();
            }
            for (int i = 0; i != totalplayers; i++)
            {

                w = random.Next(1, (totalplayers + 1));
                //  w = Random.next(1, (totalplayers + 1));



                for (int f = 0; f != totalplayers; f++) // see if #is already used
                {
                    if (w == compare[f])
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
                     tablechart[(v), w] = playersarray[i];
                    compare[g] = w;
                    g++;
                }
            }
            //all players are scrambled
            lasttable.Visible = true;
            playerslst.Visible = false;
            FinalTable.Visible = false;
            scramblebtn.Visible = false;
            delbtn.Visible = false;
            button2.Visible = false;


            lasttable.Items.Clear();
            int n = 1;
            lasttable.Items.Add("Seat   -  Player");
            for (int j = 1; j != (totalplayers + 1); j++)
            {
                lasttable.Items.Add("  " + n + "       -     " + tablechart[0, j]);
                n++;
            }
            //     graphicmode();

            //******************************************************************
            Graphics table;
            table = this.CreateGraphics();
            Pen pen1 = new Pen(Color.Blue, 1.0f);
            //   table.DrawLine(pen1, 10, 10, 100, 100);
            //     Rectangle rec1 = new Rectangle(250, 10, 500, 200);
            Rectangle rec1 = new Rectangle(200, 75, 325, 200);
            table.DrawRectangle(pen1, rec1);
            table.DrawString("     10                       1                     2", new Font("comic", 12, FontStyle.Bold), SystemBrushes.WindowText, new Point(200, 80));
            table.DrawString("      7                       6                     5", new Font("comic", 12, FontStyle.Bold), SystemBrushes.WindowText, new Point(200, 250));
            table.DrawString(" 9                                                          3", new Font("comic", 12, FontStyle.Bold), SystemBrushes.WindowText, new Point(200, 125));
            table.DrawString(" 8                                                          4", new Font("comic", 12, FontStyle.Bold), SystemBrushes.WindowText, new Point(200, 200));

            table.DrawString(tablechart[0, 10] + "\t" + "\t" + tablechart[0, 1] + "\t" + "\t" + tablechart[0, 2], new Font("comic", 12, FontStyle.Bold), SystemBrushes.WindowText, new Point(200, 50));
            table.DrawString(tablechart[0, 7] + "\t" + "\t" + tablechart[0, 6] + "\t" + "\t" + tablechart[0, 5], new Font("comic", 12, FontStyle.Bold), SystemBrushes.WindowText, new Point(200, 280));
            table.DrawString(tablechart[0, 9] + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + tablechart[0, 3], new Font("comic", 12, FontStyle.Bold), SystemBrushes.WindowText, new Point(130, 125));
            table.DrawString(tablechart[0, 8] + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + tablechart[0, 4], new Font("comic", 12, FontStyle.Bold), SystemBrushes.WindowText, new Point(130, 200));



            //************************************************************************
        }

        //private void graphicmode()
        //{


        //}

        private void button2_Click(object sender, EventArgs e)
        {
            FinalTable.Items.Clear();

        }


        private void smokebreak()
        {
            breaktime = true;
        }

        private void displayPLayersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerslst.Items.Clear();
            playerslst.Visible = true;
            Removebtn.Visible = true;
            rebuybtn.Visible = true;
            savelst.Visible = true;
            getplayers();
        }

 
        private void rebuybtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                int a = playerslst.Items.Count;
                int c = playerslst.Items.IndexOf(playerslst.SelectedItem);
                string temp = playerslst.SelectedItem.ToString();
                Total = System.Convert.ToInt32(init2.GetTotalBoxValue());
                rebuycount = rebuycount + 1;
                getProfileToolStripMenuItem_Click(sender, new EventArgs());
            }
            catch (Exception ex)
            { }
        }

        private void Removebtn_Click(object sender, EventArgs e)
         
        {   try
            {
                int a = playerslst.Items.Count;
                int c = playerslst.Items.IndexOf(playerslst.SelectedItem);

                string temp = playerslst.SelectedItem.ToString();
                lostplayer.Text = temp;
                playerslst.Items.Remove(temp);
                init2.Getcheckbox2();
               
              
                init2.ShowDialog();
               // int tc = init2
            }
            catch 
            { 
             }
            // get total number of active tables
            string tblstring = init2.GetTotalBoxValue();

            }
       

        private void savelst_Click(object sender, EventArgs e)
        {
            playerslst.Visible =false;
            Removebtn.Visible = false;
            rebuybtn.Visible = false;
            savelst.Visible = false;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rebuycount = 0;
            
            clearbtn_Click(sender, new EventArgs());

        
            }
    }

}

    //    private void Removebtn_Click(object sender, EventArgs e)
    //   {
    //       int a = playerslst.Items.Count;
    //       int c = playerslst.Items.IndexOf(playerslst.SelectedItem);
    //        string temp = playerslst.SelectedItem.ToString();
    //    }
    /*
     * call method. send as arguments, table #, seat position, and name.  
     * return new table number, seat pos and name.

//      lostplayer.Text = temp;

   playerslst.Items.Remove(lostplayer.Text);
   int b = playerslst.Items.Count;


   saveplayers();
}

private void saveplayers()
{
  string  filename = @"c:\the\allplayers.fnl";
    File.Delete(filename);
    StreamWriter sw = new StreamWriter(filename);

    int y = playerslst.Items.Count;
    for (int i = 0; i != y; i++)

    {

        playersarray[i] = playerslst.Items[i].ToString();
        sw.WriteLine(playersarray[i]);

    }
    sw.Close();
}

private void savelst_Click(object sender, EventArgs e)
{
    playerslst.Visible = false;
    savelst.Visible = false;
    Removebtn.Visible = false;
    rebuybtn.Visible=false;
}

public void rebuybtn_Click(object sender, EventArgs e)
{
    int a = playerslst.Items.Count;
    int c = playerslst.Items.IndexOf(playerslst.SelectedItem);
    string temp = playerslst.SelectedItem.ToString();
    Total = System.Convert.ToInt32(init2.GetTotalBoxValue());
    rebuycount = rebuycount + 1;
    getProfileToolStripMenuItem_Click(sender, new EventArgs());

        // int b = playerslst.Items.Count;
}


/* This method is expected to receive a player (string), delete the player from a table,
 * then check to see if the tables are balanced. If they are it will return a blank. If the
 * tables are not balanced, it will return a player (string ) to be moved from a table to
 * a different and add the moved player to the new table. int c is the seat position.
 * The remove button from the players list will sent the seat number and player name
 * to the method. The method will return the move.


    //    String balance(int c, string playerlost)
    //  {
    //      string pm = " ";

    //     int tt = System.Convert.ToInt32(init2.GetTablesBoxValue());
    //      string temp = playerslst.SelectedItem.ToString();
    //       //for (int i = 0; i != init2.)
    //      return  pm;
    // }

           */


       

