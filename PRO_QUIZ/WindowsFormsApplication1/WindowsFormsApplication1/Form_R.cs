using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace WindowsFormsApplication1
{
    public partial class Form_R : Form
    {

        int c = 0, r1 = 0, r2 = 1, r3 = 2, r4 = 3, s = 1;
        string[] questions = new string[30] {
           /*0*/"Pote idrithike i apple?",//1-----------------------------------T
           /*1*/"Pios idrise tin apple?",//2
           /*2*/"Pios itan o 1os ipologistis tis apple?",//3
           /*3*/"Pios itan o 3os ipologistis tis apple?",//4
           /*4*/"Pia einai pio dimofilis glwssa programatismou (web)?",//5
           /*5*/"pia den einai glwssa programatismou apo tis parakatw?",//6
           /*6*/"Apo pies lexeis proerxode ta arxika SSD?",//7
           /*7*/"Apo pies lexeis proerxode ta arxika VRAM",//8
           /*8*/"Pia einai i pio akrivi mnimi panw se ena PC?",//9
           /*9*/"Pistevete pws tha perasume to examino? :p",//10
           /*0*/"Pote kikloforise to Minecraft?",//1-----------------------------------G
           /*1*/"Pio einai to Top Steam Game pu espase recor se paixtes (2018)?",//2
           /*2*/"Se pia consola anikei to UNCHARTED: THE LOST LEGACY?",//3
           /*3*/"Se pia consola anikei to Rust?",//4
           /*4*/"Se pia consola anikei to UNTIL DAWN?",//5
           /*5*/"Se pia consola anikei to Age of Empires: Definitive Edition?",//6
           /*6*/"Se pia consola anikei to KNACK?",//7
           /*7*/"To kalitero se poliseis ps4 game 2018 einai?",//8
           /*8*/"To kalitero se poliseis ps4 game 2017 einai?",//9
           /*9*/"Poses poliseis ekane to PlayStation 4?",//10
           /*0*/"Pio einai to pragmatiko onoma tou Harry Potter?",//1-----------------------------------M
           /*1*/"Pia apo tis parakatw tainies anikei stin DC?",//2
           /*2*/"Pia apo tis parakatw tainies anikei stin MARVEL?",//3
           /*3*/"Pote vgike to proto episodio tu Game Of Thrones?",//4
           /*4*/"Poses tainies exoun giristei me ton Spider-Man?",//5
           /*5*/"Pia tainia espase ta tamia to 2018?",//6
           /*6*/"Pia tainia espase ta tamia to 2017?",//7
           /*7*/"Pios einai o protagonistis tu Woman In Black?",//8
           /*8*/"Pios einai o protagonistis tu The Amazing Spider-Man 2?",//9
           /*9*/"Pios einai o protagonistis tu Spiderman 3?"//10
            };

        string[,] answers = new string[,] { 
                       /*0*/{"1  Απριλίου 1976","4  Απριλίου 1977","6  Απριλίου 1978","1  Απριλίου 1979"},//1
           /*1*/{"Steve Jobs και τον Steven Wozniak","Steve Jobs","Steven Wozniak","None"},//2
           /*2*/{"Apple I"," Apple II","Lisa","Macintosh"},//3
           /*3*/{"Lisa"," Apple II","Apple I ","Macintosh"},//4
           /*4*/{"PHP","CSS","HTML",".NET"},//5
           /*5*/{"HTML","PYTHON","C","PASCAL"},//6
           /*6*/{"Solid State Drives","Solid Storage Drives","Storage State Dives","Solid State Dives"},//7
           /*7*/{"Video RAM","Virtual RAM","Visual RAM","None"},//8
           /*8*/{"cache","RAM","SSD","None"},//9
           /*9*/{"Fisika Kai Oxi!","oxi","nai","borei"},//10
                      /*0*/{"17 Μαΐου 2009","17 Μαΐου 2010","17 Μαΐου 2011","17 Μαΐου 2012"},//1
           /*1*/{"PUBG","GTA V","RUST","None"},//2
           /*2*/{"PlayStation 4","PC","Nintendo Switch","None"},//3
           /*3*/{"PlayStation 4","PC","Nintendo Switch","None"},//4
           /*4*/{"PlayStation 4","PC","Nintendo Switch","None"},//5
           /*5*/{"PlayStation 4","PC","Nintendo Switch","None"},//6
           /*6*/{"PlayStation 4","PC","Nintendo Switch","None"},//7
           /*7*/{"Marvel's Spider-Man","Metal Gear Solid V: The Phantom Pain","Battlefield 1","None"},//8
           /*8*/{"Horizon Zero Dawn","The Witcher 3: Wild Hunt","God of War","None"},//9
           /*9*/{"91.6 million","10.7 million","20 million","40 million"},//10
                      /*0*/{"Ντάνιελ Ράντκλιφ","Ρούπερτ Γκριντ","Τομ Φέλτον","Χάρι Μέλινγκ"},//1
           /*1*/{"Wonder Woman","Iron Man","Thor","Black Panther"},//2
           /*2*/{"Ant-Man","Watchmen","Green Lantern","Σούπερμαν"},//3
           /*3*/{"17 Απριλίου 2011","17 Απριλίου 2012","17 Απριλίου 2013","17 Απριλίου 2014"},//4
           /*4*/{"6","7","8","3"},//5
           /*5*/{"AVENGERS: INFINITY WAR","BLACK PANTHER","NCREDIBLES 2","AQUAMAN"},//6
           /*6*/{"Star Wars: The Last Jedi","Wonder Woman","It","Beauty and the Beast "},//7
           /*7*/{"Ντάνιελ Ράντκλιφ","Ρούπερτ Γκριντ","Τομ Φέλτον","Χάρι Μέλινγκ"},//8
           /*8*/{"Άντριου Γκάρφιλντ","Πολ Τζιαμάτι","Χάρι Μέλινγκ","None"},//9
           /*9*/{"Τόμπι Μαγκουάιρ","Μπρους Κάμπελ","Κλιφ Ρόμπερτσον","None"}//10
                };

        string[] lisi = new string[] { 
           /*0*/"1  Απριλίου 1976",//1
           /*1*/"Steve Jobs και τον Steven Wozniak",//2
           /*2*/"Apple I",//3
           /*3*/"Lisa",//4
           /*4*/"PHP",//5
           /*5*/"HTML",//6
           /*6*/"Solid State Drives",//7
           /*7*/"Video RAM",//8
           /*8*/"cache",//9
           /*9*/"Fisika Kai Oxi!",//10
                      /*0*/"17 Μαΐου 2009",//1
           /*1*/"PUBG",//2
           /*2*/"PlayStation 4",//3
           /*3*/"PC",//4
           /*4*/"PlayStation 4",//5
           /*5*/"PC",//6
           /*6*/"PlayStation 4",//7
           /*7*/"Marvel's Spider-Man",//8
           /*8*/"Horizon Zero Dawn",//9
           /*9*/"91.6 million",//10
                      /*0*/"Ντάνιελ Ράντκλιφ",//1
           /*1*/"Wonder Woman",//2
           /*2*/"Ant-Man",//3
           /*3*/"17 Απριλίου 2011",//4
           /*4*/"6",//5
           /*5*/"AVENGERS: INFINITY WAR",//6
           /*6*/"Star Wars: The Last Jedi",//7
           /*7*/"Ντάνιελ Ράντκλιφ",//8
           /*8*/"Άντριου Γκάρφιλντ",//9
           /*9*/"Τόμπι Μαγκουάιρ"//10
                };


        int Win = 0;

        int[] arr = new int[10];
        int counter=0;
        int[] arr2 = new int[4];
        int counter2 = 0;

        //int TimeCount = 160;


         int TimeCurrent = 120;
            DateTime dt = new DateTime();

        int WinC = 10; //MAX EROTISEIS (WIN)

        public Form_R()
        {

            InitializeComponent();

            



          
            LBL_TIMER.Text = dt.AddSeconds(TimeCurrent).ToString("HH:mm:ss");
           // LBL_TIMER.Text = TimeCurrent.ToString("HH:mm:ss");
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();

            
            






            var random = new Random();
            var pithanoi_arithmoi = Enumerable.Range(0, 31).ToList();
            var apotel = pithanoi_arithmoi.OrderBy(arithmos => random.Next()).Take(10).ToArray();

            foreach (var arithmos in apotel) {
             //   test.Text = test.Text + " " + arithmos;
                arr[counter] = arithmos;
                counter += 1;
            }
            //-----------------------------------------------------------------------------------
            var R_ans = new Random();
            var R_ans_num = Enumerable.Range(0, 4).ToList();
            var R_apotel = R_ans_num.OrderBy(R_arithm => R_ans.Next()).Take(4).ToArray();

            foreach (var R_arithm in R_apotel)
            {
                arr2[counter2] = R_arithm;
                counter2 += 1;
            }

            counter = 0;
            c = arr[counter];
            counter2 = 0;
        
            r1 = arr2[0];
            r2 = arr2[1];
            r3 = arr2[2];
            r4 = arr2[3];

            ASK_T.Text = questions[c];
            BTN_A1.Text = answers[c, r1];
            BTN_A2.Text = answers[c, r2];
            BTN_A3.Text = answers[c, r3];
            BTN_A4.Text = answers[c, r4];




        }
        SoundPlayer clickp = new SoundPlayer(Properties.Resources.clicks);
        SoundPlayer closeup = new SoundPlayer(Properties.Resources.tick_tock);
        SoundPlayer correct = new SoundPlayer(Properties.Resources.correct);
        SoundPlayer wrong = new SoundPlayer(Properties.Resources.wrong);
        SoundPlayer gamewin = new SoundPlayer(Properties.Resources.success);
        SoundPlayer gameover = new SoundPlayer(Properties.Resources.gameover);


        private void button5_Click(object sender, EventArgs e)
        {

            //Canceling

            timer1.Stop();

            //..........

            Form1 temp = new Form1();
            temp.Region = this.Region;
            temp.Show();
           // this.Hide();
            
            temp.Location = this.Location;
            this.Close();
        }

        private void BTN_E_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?","Closing Program",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            System.Windows.Forms.Application.Exit();
        }

        private void BTN_A1_MouseEnter(object sender, EventArgs e)
        {
            clickp.Play();
        }

        private void BTN_A2_MouseEnter(object sender, EventArgs e)
        {
            clickp.Play();
        }

        private void BTN_A3_MouseEnter(object sender, EventArgs e)
        {
            clickp.Play();
        }



        private void Form_T_Load(object sender, EventArgs e)
        {

        }

        private void BTN_A4_MouseEnter(object sender, EventArgs e)
        {
            clickp.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            TimeCurrent--;
            if (TimeCurrent == 30)
                closeup.Play();

            if (TimeCurrent == 0)
            {
                timer1.Stop();
                LBL_TIMER.Text = dt.AddSeconds(TimeCurrent).ToString("HH:mm:ss");
                gameover.Play();
                MessageBox.Show("Your Score:"+ Win + "/10", "Time Out!");
                Form1 temp = new Form1();
                temp.Region = this.Region;
                temp.Show();
                temp.Location = this.Location;
                this.Close();

            }
            

            
            LBL_TIMER.Text = dt.AddSeconds(TimeCurrent).ToString("HH:mm:ss");
            //LBL_TIMER.Text = TimeCount.ToString("HH:mm:ss");

        }

        private void BTN_E_MouseEnter(object sender, EventArgs e)
        {
            clickp.Play();
        }

        private void ASK_T_Click(object sender, EventArgs e)
        {

        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            clickp.Play();
        }

        private async void BTN_A1_Click(object sender, EventArgs e)
        {
            
            if (BTN_A1.Text == lisi[c])
            {
                BTN_A1.BackColor = Color.Green;
                Win += 1;
                if (Win == WinC)
                {
                    timer1.Stop();
                    gamewin.Play();
                    MessageBox.Show("YOU WIN!\nYour Score:" + Win + "/10", "Victory!");
                    //------------------------------//WIN_GO_TO
                    Form1 temp = new Form1();
                    temp.Region = this.Region;
                    temp.Show();
                    temp.Location = this.Location;
                    this.Close();
                    //------------------------------//
                }
                else correct.Play();

            }
            else
            {
                BTN_A1.BackColor = Color.Red;
                wrong.Play();
            }


            //=====================================//END ASK:start
            if (Win != WinC && s == WinC)
            {
                timer1.Stop();
                gameover.Play();
                MessageBox.Show("Nice Try!\nYour Score:" + Win + "/10", "Try Again!");
                //------------------------------//WIN_GO_TO
                Form1 temp = new Form1();
                temp.Region = this.Region;
                temp.Show();
                temp.Location = this.Location;
                this.Close();
                //------------------------------//
            }
            //=====================================//END ASK:stop


            if (counter < 9) counter += 1;

            BTN_A1.Enabled = false;
            BTN_A2.Enabled = false;
            BTN_A3.Enabled = false;
            BTN_A4.Enabled = false;


            await Task.Delay(2000);
            BTN_A1.BackColor = Color.LightSeaGreen;

            BTN_A1.Enabled = true;
            BTN_A2.Enabled = true;
            BTN_A3.Enabled = true;
            BTN_A4.Enabled = true;

            //----------------------------------------------Randomize/start
            int counter2 = 0;

            var R_ans = new Random();
            var R_ans_num = Enumerable.Range(0, 4).ToList();
            var R_apotel = R_ans_num.OrderBy(R_arithm => R_ans.Next()).Take(4).ToArray();

            foreach (var R_arithm in R_apotel)
            { arr2[counter2] = R_arithm; counter2 += 1; }

            counter2 = 0;
            r1 = arr2[0]; r2 = arr2[1]; r3 = arr2[2]; r4 = arr2[3];
            //----------------------------------------------Randomize/stop

            c = arr[counter];
            ASK_T.Text = questions[c];
            BTN_A1.Text = answers[c, r1];
            BTN_A2.Text = answers[c, r2];
            BTN_A3.Text = answers[c, r3];
            BTN_A4.Text = answers[c, r4];


            

            s = s + 1;
            LBL_Q.Text = "Question: "+ s +" of 10";

        }

        private async void BTN_A2_Click(object sender, EventArgs e)
        {

            if (BTN_A2.Text == lisi[c])
            {
                BTN_A2.BackColor = Color.Green;
                Win += 1;
                if (Win == WinC)
                {
                    timer1.Stop();
                    gamewin.Play();
                    MessageBox.Show("YOU WIN!\nYour Score:" + Win + "/10", "Victory!");
                    //------------------------------//WIN_GO_TO
                    Form1 temp = new Form1();
                    temp.Region = this.Region;
                    temp.Show();
                    temp.Location = this.Location;
                    this.Close();
                    //------------------------------//
                }
                else correct.Play();
            }
            else
            {
                BTN_A2.BackColor = Color.Red;
                wrong.Play();
            }

            //=====================================//END ASK:start
            if (Win != WinC && s == WinC)
            {
                timer1.Stop();
                gameover.Play();
                MessageBox.Show("Nice Try!\nYour Score:" + Win + "/10", "Try Again!");
                //------------------------------//WIN_GO_TO
                Form1 temp = new Form1();
                temp.Region = this.Region;
                temp.Show();
                temp.Location = this.Location;
                this.Close();
                //------------------------------//
            }
            //=====================================//END ASK:stop

            if (counter < 9) counter += 1;


            BTN_A1.Enabled = false;
            BTN_A2.Enabled = false;
            BTN_A3.Enabled = false;
            BTN_A4.Enabled = false;

            await Task.Delay(2000);
            BTN_A2.BackColor = Color.LightSeaGreen;

            BTN_A1.Enabled = true;
            BTN_A2.Enabled = true;
            BTN_A3.Enabled = true;
            BTN_A4.Enabled = true;

            //----------------------------------------------Randomize/start
            int counter2 = 0;

            var R_ans = new Random();
            var R_ans_num = Enumerable.Range(0, 4).ToList();
            var R_apotel = R_ans_num.OrderBy(R_arithm => R_ans.Next()).Take(4).ToArray();

            foreach (var R_arithm in R_apotel)
            { arr2[counter2] = R_arithm; counter2 += 1; }

            counter2 = 0;
            r1 = arr2[0]; r2 = arr2[1]; r3 = arr2[2]; r4 = arr2[3];
            //----------------------------------------------Randomize/stop

            c = arr[counter];
            ASK_T.Text = questions[c];
            BTN_A1.Text = answers[c, r1];
            BTN_A2.Text = answers[c, r2];
            BTN_A3.Text = answers[c, r3];
            BTN_A4.Text = answers[c, r4];

            s = s + 1;
            LBL_Q.Text = "Question: " + s + " of 10";
        }

        private async void BTN_A3_Click(object sender, EventArgs e)
        {

            if (BTN_A3.Text == lisi[c])
            {
                BTN_A3.BackColor = Color.Green;
                Win += 1;
                if (Win == WinC)
                {
                    timer1.Stop();
                    gamewin.Play();
                    MessageBox.Show("YOU WIN!\nYour Score:" + Win + "/10", "Victory!");
                    //------------------------------//WIN_GO_TO
                    Form1 temp = new Form1();
                    temp.Region = this.Region;
                    temp.Show();
                    temp.Location = this.Location;
                    this.Close();
                    //------------------------------//

                }
                else correct.Play();

            }
            else { 
                BTN_A3.BackColor = Color.Red;
                wrong.Play();
            }

            //=====================================//END ASK:start
            if (Win != WinC && s == WinC)
            {
                timer1.Stop();
                gameover.Play();
                MessageBox.Show("Nice Try!\nYour Score:" + Win + "/10", "Try Again!");
                //------------------------------//WIN_GO_TO
                Form1 temp = new Form1();
                temp.Region = this.Region;
                temp.Show();
                temp.Location = this.Location;
                this.Close();
                //------------------------------//
            }
            //=====================================//END ASK:stop


            if (counter < 9) counter += 1;

            BTN_A1.Enabled = false;
            BTN_A2.Enabled = false;
            BTN_A3.Enabled = false;
            BTN_A4.Enabled = false;

            await Task.Delay(2000);
            BTN_A3.BackColor = Color.LightSeaGreen;

            BTN_A1.Enabled = true;
            BTN_A2.Enabled = true;
            BTN_A3.Enabled = true;
            BTN_A4.Enabled = true;

            //----------------------------------------------Randomize/start
            int counter2 = 0;

            var R_ans = new Random();
            var R_ans_num = Enumerable.Range(0, 4).ToList();
            var R_apotel = R_ans_num.OrderBy(R_arithm => R_ans.Next()).Take(4).ToArray();

            foreach (var R_arithm in R_apotel)
            { arr2[counter2] = R_arithm; counter2 += 1; }

            counter2 = 0;
            r1 = arr2[0]; r2 = arr2[1]; r3 = arr2[2]; r4 = arr2[3];
            //----------------------------------------------Randomize/stop

            c = arr[counter];
            ASK_T.Text = questions[c];
            BTN_A1.Text = answers[c, r1];
            BTN_A2.Text = answers[c, r2];
            BTN_A3.Text = answers[c, r3];
            BTN_A4.Text = answers[c, r4];

            s = s + 1;
            LBL_Q.Text = "Question: " + s + " of 10";
        }

        private async void BTN_A4_Click(object sender, EventArgs e)
        {

            if (BTN_A4.Text == lisi[c])
            {
                BTN_A4.BackColor = Color.Green;
                
                Win += 1;
                if (Win == WinC) {
                    timer1.Stop();
                    gamewin.Play();
                    MessageBox.Show("YOU WIN!\nYour Score:" + Win + "/10", "Victory!");
                    //------------------------------//WIN_GO_TO
                    Form1 temp = new Form1();
                    temp.Region = this.Region;
                    temp.Show();
                    temp.Location = this.Location;
                    this.Close();
                    //------------------------------//
                }
                else correct.Play();

            }
            else
            {
                BTN_A4.BackColor = Color.Red;
                wrong.Play();



            }

            //=====================================//END ASK:start
            if (Win!=WinC && s==WinC) {
                timer1.Stop();
                gameover.Play();
                MessageBox.Show("Nice Try!\nYour Score:" + Win + "/10", "Try Again!");
                //------------------------------//WIN_GO_TO
                Form1 temp = new Form1();
                temp.Region = this.Region;
                temp.Show();
                temp.Location = this.Location;
                this.Close();
                //------------------------------//
            }
            //=====================================//END ASK:stop

            if (counter < 9) counter += 1;

            BTN_A1.Enabled = false;
            BTN_A2.Enabled = false;
            BTN_A3.Enabled = false;
            BTN_A4.Enabled = false;

            await Task.Delay(2000);
            BTN_A4.BackColor = Color.LightSeaGreen;


            BTN_A1.Enabled = true;
            BTN_A2.Enabled = true;
            BTN_A3.Enabled = true;
            BTN_A4.Enabled = true;




            //----------------------------------------------Randomize/start
            int counter2 = 0;

            var R_ans = new Random();
            var R_ans_num = Enumerable.Range(0, 4).ToList();
            var R_apotel = R_ans_num.OrderBy(R_arithm => R_ans.Next()).Take(4).ToArray();

            foreach (var R_arithm in R_apotel)
            { arr2[counter2] = R_arithm;   counter2 += 1;}

            counter2 = 0;
            r1 = arr2[0];  r2 = arr2[1];  r3 = arr2[2];  r4 = arr2[3];
            //----------------------------------------------Randomize/stop







            c = arr[counter];
            ASK_T.Text = questions[c];
            BTN_A1.Text = answers[c, r1];
            BTN_A2.Text = answers[c, r2];
            BTN_A3.Text = answers[c, r3];
            BTN_A4.Text = answers[c, r4];

            s = s + 1;
            LBL_Q.Text = "Question: " + s + " of 10";



        }
    }
}
