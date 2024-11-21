namespace Texas_Holdem
{
    partial class Timer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timer));
            this.StartTimerbtn = new System.Windows.Forms.Button();
            this.Pausebtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bglbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firsttxt = new System.Windows.Forms.TextBox();
            this.secondtxt = new System.Windows.Forms.TextBox();
            this.thirdtxt = new System.Windows.Forms.TextBox();
            this.fourthtxt = new System.Windows.Forms.TextBox();
            this.Highhandtxt = new System.Windows.Forms.TextBox();
            this.Bountytxt = new System.Windows.Forms.TextBox();
            this.housetxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.secretbox1 = new System.Windows.Forms.TextBox();
            this.levellbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsm1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetBlindsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nextLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setNewTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayPLayersListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FinalTable = new System.Windows.Forms.ListBox();
            this.scramblebtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.lasttable = new System.Windows.Forms.ListBox();
            this.playerslst = new System.Windows.Forms.ListBox();
            this.Timetxt = new System.Windows.Forms.TextBox();
            this.delbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.secrettext = new System.Windows.Forms.TextBox();
            this.Removebtn = new System.Windows.Forms.Button();
            this.savelst = new System.Windows.Forms.Button();
            this.fifthtxt = new System.Windows.Forms.TextBox();
            this.rebuybtn = new System.Windows.Forms.Button();
            this.lostplayer = new System.Windows.Forms.TextBox();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartTimerbtn
            // 
            this.StartTimerbtn.BackColor = System.Drawing.Color.Crimson;
            this.StartTimerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartTimerbtn.Location = new System.Drawing.Point(212, 620);
            this.StartTimerbtn.Name = "StartTimerbtn";
            this.StartTimerbtn.Size = new System.Drawing.Size(75, 53);
            this.StartTimerbtn.TabIndex = 0;
            this.StartTimerbtn.Text = "Start Timer";
            this.StartTimerbtn.UseVisualStyleBackColor = false;
            this.StartTimerbtn.Click += new System.EventHandler(this.StartTimerbtn_Click);
            // 
            // Pausebtn
            // 
            this.Pausebtn.BackColor = System.Drawing.Color.Crimson;
            this.Pausebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pausebtn.Location = new System.Drawing.Point(839, 620);
            this.Pausebtn.Name = "Pausebtn";
            this.Pausebtn.Size = new System.Drawing.Size(75, 53);
            this.Pausebtn.TabIndex = 1;
            this.Pausebtn.Text = "Pause Timer";
            this.Pausebtn.UseVisualStyleBackColor = false;
            this.Pausebtn.Click += new System.EventHandler(this.Pausebtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblbl
            // 
            this.lblbl.AutoSize = true;
            this.lblbl.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblbl.Location = new System.Drawing.Point(179, 421);
            this.lblbl.Name = "lblbl";
            this.lblbl.Size = new System.Drawing.Size(371, 90);
            this.lblbl.TabIndex = 5;
            this.lblbl.Text = "Little Blind";
            this.lblbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(567, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "-";
            // 
            // bglbl
            // 
            this.bglbl.AutoSize = true;
            this.bglbl.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bglbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bglbl.Location = new System.Drawing.Point(746, 421);
            this.bglbl.Name = "bglbl";
            this.bglbl.Size = new System.Drawing.Size(297, 90);
            this.bglbl.TabIndex = 7;
            this.bglbl.Text = "Big Blind";
            this.bglbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1044, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prizes";
            // 
            // firsttxt
            // 
            this.firsttxt.Location = new System.Drawing.Point(1041, 73);
            this.firsttxt.Name = "firsttxt";
            this.firsttxt.Size = new System.Drawing.Size(75, 26);
            this.firsttxt.TabIndex = 9;
            this.firsttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secondtxt
            // 
            this.secondtxt.Location = new System.Drawing.Point(1041, 105);
            this.secondtxt.Name = "secondtxt";
            this.secondtxt.Size = new System.Drawing.Size(75, 26);
            this.secondtxt.TabIndex = 10;
            this.secondtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // thirdtxt
            // 
            this.thirdtxt.Location = new System.Drawing.Point(1041, 137);
            this.thirdtxt.Name = "thirdtxt";
            this.thirdtxt.Size = new System.Drawing.Size(75, 26);
            this.thirdtxt.TabIndex = 11;
            this.thirdtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fourthtxt
            // 
            this.fourthtxt.Location = new System.Drawing.Point(1041, 169);
            this.fourthtxt.Name = "fourthtxt";
            this.fourthtxt.Size = new System.Drawing.Size(75, 26);
            this.fourthtxt.TabIndex = 12;
            this.fourthtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Highhandtxt
            // 
            this.Highhandtxt.Location = new System.Drawing.Point(1041, 266);
            this.Highhandtxt.Name = "Highhandtxt";
            this.Highhandtxt.Size = new System.Drawing.Size(75, 26);
            this.Highhandtxt.TabIndex = 13;
            this.Highhandtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Highhandtxt.Visible = false;
            this.Highhandtxt.TextChanged += new System.EventHandler(this.Highhandtxt_TextChanged);
            // 
            // Bountytxt
            // 
            this.Bountytxt.Location = new System.Drawing.Point(1041, 312);
            this.Bountytxt.Name = "Bountytxt";
            this.Bountytxt.Size = new System.Drawing.Size(75, 26);
            this.Bountytxt.TabIndex = 14;
            this.Bountytxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bountytxt.Visible = false;
            this.Bountytxt.TextChanged += new System.EventHandler(this.Bountytxt_TextChanged);
            // 
            // housetxt
            // 
            this.housetxt.Location = new System.Drawing.Point(1041, 355);
            this.housetxt.Name = "housetxt";
            this.housetxt.Size = new System.Drawing.Size(75, 26);
            this.housetxt.TabIndex = 15;
            this.housetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.housetxt.Visible = false;
            this.housetxt.TextChanged += new System.EventHandler(this.housetxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(913, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "High Hand";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(913, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Bounty";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(913, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "House";
            this.label5.Visible = false;
            // 
            // secretbox1
            // 
            this.secretbox1.Location = new System.Drawing.Point(448, 155);
            this.secretbox1.Name = "secretbox1";
            this.secretbox1.Size = new System.Drawing.Size(75, 26);
            this.secretbox1.TabIndex = 19;
            this.secretbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.secretbox1.DoubleClick += new System.EventHandler(this.secretbox1_DoubleClick);
            this.secretbox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secretbox1_KeyPress);
            // 
            // levellbl
            // 
            this.levellbl.AutoSize = true;
            this.levellbl.Location = new System.Drawing.Point(570, 379);
            this.levellbl.Name = "levellbl";
            this.levellbl.Size = new System.Drawing.Size(39, 18);
            this.levellbl.TabIndex = 21;
            this.levellbl.Text = "None";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1353, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsm1
            // 
            this.tsm1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.tsm1.Name = "tsm1";
            this.tsm1.Size = new System.Drawing.Size(61, 20);
            this.tsm1.Text = "Options";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetBlindsToolStripMenuItem1,
            this.nextLevelToolStripMenuItem,
            this.getProfileToolStripMenuItem,
            this.setNewTimeToolStripMenuItem,
            this.finalTableToolStripMenuItem,
            this.displayPLayersListToolStripMenuItem,
            this.newGameToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toolsToolStripMenuItem.Text = "Tools";
        //    this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
            // 
            // resetBlindsToolStripMenuItem1
            // 
            this.resetBlindsToolStripMenuItem1.Name = "resetBlindsToolStripMenuItem1";
            this.resetBlindsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.resetBlindsToolStripMenuItem1.Text = "Reset Blinds";
            this.resetBlindsToolStripMenuItem1.Click += new System.EventHandler(this.resetBlindsToolStripMenuItem1_Click);
            // 
            // nextLevelToolStripMenuItem
            // 
            this.nextLevelToolStripMenuItem.Name = "nextLevelToolStripMenuItem";
            this.nextLevelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nextLevelToolStripMenuItem.Text = "Next Level";
            this.nextLevelToolStripMenuItem.Click += new System.EventHandler(this.nextLevelToolStripMenuItem_Click);
            // 
            // getProfileToolStripMenuItem
            // 
            this.getProfileToolStripMenuItem.Name = "getProfileToolStripMenuItem";
            this.getProfileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.getProfileToolStripMenuItem.Text = "Get Profile";
            this.getProfileToolStripMenuItem.Click += new System.EventHandler(this.getProfileToolStripMenuItem_Click);
            // 
            // setNewTimeToolStripMenuItem
            // 
            this.setNewTimeToolStripMenuItem.Name = "setNewTimeToolStripMenuItem";
            this.setNewTimeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setNewTimeToolStripMenuItem.Text = "Set New Time";
            this.setNewTimeToolStripMenuItem.Click += new System.EventHandler(this.setNewTimeToolStripMenuItem_Click);
            // 
            // finalTableToolStripMenuItem
            // 
            this.finalTableToolStripMenuItem.Name = "finalTableToolStripMenuItem";
            this.finalTableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.finalTableToolStripMenuItem.Text = "Final Table";
            this.finalTableToolStripMenuItem.Click += new System.EventHandler(this.finalTableToolStripMenuItem_Click);
            // 
            // displayPLayersListToolStripMenuItem
            // 
            this.displayPLayersListToolStripMenuItem.Name = "displayPLayersListToolStripMenuItem";
            this.displayPLayersListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.displayPLayersListToolStripMenuItem.Text = "Display Players List";
            this.displayPLayersListToolStripMenuItem.Click += new System.EventHandler(this.displayPLayersListToolStripMenuItem_Click);
            // 
            // FinalTable
            // 
            this.FinalTable.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalTable.FormattingEnabled = true;
            this.FinalTable.ItemHeight = 23;
            this.FinalTable.Location = new System.Drawing.Point(447, 331);
            this.FinalTable.Name = "FinalTable";
            this.FinalTable.Size = new System.Drawing.Size(120, 234);
            this.FinalTable.TabIndex = 24;
            this.FinalTable.Visible = false;
            // 
            // scramblebtn
            // 
            this.scramblebtn.AutoSize = true;
            this.scramblebtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scramblebtn.Location = new System.Drawing.Point(292, 456);
            this.scramblebtn.Name = "scramblebtn";
            this.scramblebtn.Size = new System.Drawing.Size(104, 35);
            this.scramblebtn.TabIndex = 25;
            this.scramblebtn.Text = "Scramble";
            this.scramblebtn.UseVisualStyleBackColor = true;
            this.scramblebtn.Visible = false;
            this.scramblebtn.Click += new System.EventHandler(this.scramblebtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.AutoSize = true;
            this.clearbtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.Location = new System.Drawing.Point(292, 539);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(104, 35);
            this.clearbtn.TabIndex = 26;
            this.clearbtn.Text = "Return";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Visible = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // lasttable
            // 
            this.lasttable.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lasttable.FormattingEnabled = true;
            this.lasttable.ItemHeight = 29;
            this.lasttable.Location = new System.Drawing.Point(648, 331);
            this.lasttable.Name = "lasttable";
            this.lasttable.Size = new System.Drawing.Size(266, 323);
            this.lasttable.TabIndex = 28;
            this.lasttable.Visible = false;
            // 
            // playerslst
            // 
            this.playerslst.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerslst.FormattingEnabled = true;
            this.playerslst.ItemHeight = 23;
            this.playerslst.Location = new System.Drawing.Point(1181, 41);
            this.playerslst.Name = "playerslst";
            this.playerslst.Size = new System.Drawing.Size(120, 510);
            this.playerslst.TabIndex = 23;
            this.playerslst.Visible = false;
            this.playerslst.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.playerslst_MouseDoubleClick);
            // 
            // Timetxt
            // 
            this.Timetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timetxt.Location = new System.Drawing.Point(24, 31);
            this.Timetxt.Name = "Timetxt";
            this.Timetxt.Size = new System.Drawing.Size(846, 116);
            this.Timetxt.TabIndex = 4;
            this.Timetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Timetxt.TextChanged += new System.EventHandler(this.Timetxt_TextChanged);
            this.Timetxt.DoubleClick += new System.EventHandler(this.Timetxt_DoubleClick);
            // 
            // delbtn
            // 
            this.delbtn.AutoSize = true;
            this.delbtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbtn.Location = new System.Drawing.Point(292, 331);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(104, 35);
            this.delbtn.TabIndex = 27;
            this.delbtn.Text = "Delete";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Visible = false;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(292, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 35);
            this.button2.TabIndex = 29;
            this.button2.Text = "Clear All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.secrettext);
            this.panel1.Controls.Add(this.Timetxt);
            this.panel1.Controls.Add(this.secretbox1);
            this.panel1.Location = new System.Drawing.Point(27, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 298);
            this.panel1.TabIndex = 30;
            // 
            // secrettext
            // 
            this.secrettext.Location = new System.Drawing.Point(420, 196);
            this.secrettext.Name = "secrettext";
            this.secrettext.Size = new System.Drawing.Size(148, 26);
            this.secrettext.TabIndex = 20;
            this.secrettext.Text = "(Whole Number only)";
            this.secrettext.Visible = false;
            // 
            // Removebtn
            // 
            this.Removebtn.AutoSize = true;
            this.Removebtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Removebtn.Location = new System.Drawing.Point(1181, 557);
            this.Removebtn.Name = "Removebtn";
            this.Removebtn.Size = new System.Drawing.Size(104, 35);
            this.Removebtn.TabIndex = 31;
            this.Removebtn.Text = "Remove";
            this.Removebtn.UseVisualStyleBackColor = true;
            this.Removebtn.Visible = false;
            this.Removebtn.Click += new System.EventHandler(this.Removebtn_Click);
            // 
            // savelst
            // 
            this.savelst.AutoSize = true;
            this.savelst.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savelst.Location = new System.Drawing.Point(1181, 637);
            this.savelst.Name = "savelst";
            this.savelst.Size = new System.Drawing.Size(104, 35);
            this.savelst.TabIndex = 33;
            this.savelst.Text = "Hide";
            this.savelst.UseVisualStyleBackColor = true;
            this.savelst.Visible = false;
            this.savelst.Click += new System.EventHandler(this.savelst_Click);
            // 
            // fifthtxt
            // 
            this.fifthtxt.Location = new System.Drawing.Point(1041, 201);
            this.fifthtxt.Name = "fifthtxt";
            this.fifthtxt.Size = new System.Drawing.Size(75, 26);
            this.fifthtxt.TabIndex = 34;
            this.fifthtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rebuybtn
            // 
            this.rebuybtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rebuybtn.Location = new System.Drawing.Point(1181, 598);
            this.rebuybtn.Name = "rebuybtn";
            this.rebuybtn.Size = new System.Drawing.Size(104, 33);
            this.rebuybtn.TabIndex = 35;
            this.rebuybtn.Text = "Rebuy";
            this.rebuybtn.UseVisualStyleBackColor = true;
            this.rebuybtn.Visible = false;
            this.rebuybtn.Click += new System.EventHandler(this.rebuybtn_Click_1);
            // 
            // lostplayer
            // 
            this.lostplayer.Location = new System.Drawing.Point(1005, 594);
            this.lostplayer.Name = "lostplayer";
            this.lostplayer.Size = new System.Drawing.Size(127, 26);
            this.lostplayer.TabIndex = 36;
            this.lostplayer.Visible = false;
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1353, 788);
            this.Controls.Add(this.lostplayer);
            this.Controls.Add(this.rebuybtn);
            this.Controls.Add(this.fifthtxt);
            this.Controls.Add(this.savelst);
            this.Controls.Add(this.Removebtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.playerslst);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.lasttable);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.scramblebtn);
            this.Controls.Add(this.FinalTable);
            this.Controls.Add(this.levellbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.housetxt);
            this.Controls.Add(this.Bountytxt);
            this.Controls.Add(this.Highhandtxt);
            this.Controls.Add(this.fourthtxt);
            this.Controls.Add(this.thirdtxt);
            this.Controls.Add(this.secondtxt);
            this.Controls.Add(this.firsttxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bglbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblbl);
            this.Controls.Add(this.Pausebtn);
            this.Controls.Add(this.StartTimerbtn);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Timer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Timer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartTimerbtn;
        private System.Windows.Forms.Button Pausebtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bglbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firsttxt;
        private System.Windows.Forms.TextBox secondtxt;
        private System.Windows.Forms.TextBox thirdtxt;
        private System.Windows.Forms.TextBox fourthtxt;
        private System.Windows.Forms.TextBox Highhandtxt;
        private System.Windows.Forms.TextBox Bountytxt;
        private System.Windows.Forms.TextBox housetxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox secretbox1;
        private System.Windows.Forms.Label levellbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetBlindsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nextLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setNewTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalTableToolStripMenuItem;
        private System.Windows.Forms.ListBox FinalTable;
        private System.Windows.Forms.Button scramblebtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.ListBox lasttable;
        private System.Windows.Forms.ListBox playerslst;
        private System.Windows.Forms.TextBox Timetxt;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem displayPLayersListToolStripMenuItem;
        private System.Windows.Forms.Button Removebtn;
        private System.Windows.Forms.Button savelst;
        private System.Windows.Forms.TextBox fifthtxt;
        private System.Windows.Forms.TextBox secrettext;
        private System.Windows.Forms.Button rebuybtn;
        private System.Windows.Forms.TextBox lostplayer;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
    }
}