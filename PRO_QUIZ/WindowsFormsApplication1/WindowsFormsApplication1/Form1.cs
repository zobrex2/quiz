using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; // sound lib
using System.Reflection;
using System.Resources;
using System.Globalization;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {

        //BTNs With CAPS
        //Image BTN_T_E = Properties.Resources.GAMES_BTN_GR;
        //Image BTN_T_E = Properties.Resources.TECHNOLOGY_BTN_S;
        /*
        Image BTN_T_E = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN_FX/TECHNOLOGY_BTNFX.PNG");
        Image BTN_T_S = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN\TECHNOLOGY_BTN.PNG");
        Image BTN_G_E = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN_FX\GAMES_BTNFX.PNG");
        Image BTN_G_S = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN\GAMES_BTN.PNG");
        Image BTN_M_E = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN_FX\MOVIES_BTNFX.PNG");
        Image BTN_M_S = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN\MOVIES_BTN.PNG");
        Image BTN_R_E = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN_FX\RANDOM_BTNFX.PNG");
        Image BTN_R_S = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN\RANDOM_BTN.PNG");
        */
        //BTNs With lowercase
        /*
        Image BTN_T_Es = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN_FX\TECHNOLOGY_BTNFX_S.PNG");
        Image BTN_T_Ss = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN\TECHNOLOGY_BTN_S.PNG");
        Image BTN_G_Es = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN_FX\GAMES_BTNFX_S.PNG");
        Image BTN_G_Ss = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN\GAMES_BTN_S.PNG");
        Image BTN_M_Es = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN_FX\MOVIES_BTNFX_S.PNG");
        Image BTN_M_Ss = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN\MOVIES_BTN_S.PNG");
        Image BTN_R_Es = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN_FX\RANDOM_BTNFX_S.PNG");
        Image BTN_R_Ss = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN\RANDOM_BTN_S.PNG");
        */
        Image BTN_T_Es = Properties.Resources.TECHNOLOGY_BTNFX_S;
        Image BTN_T_Ss = Properties.Resources.TECHNOLOGY_BTN_S;
        Image BTN_G_Es = Properties.Resources.GAMES_BTNFX_S;
        Image BTN_G_Ss = Properties.Resources.GAMES_BTN_S;
        Image BTN_M_Es = Properties.Resources.MOVIES_BTNFX_S;
        Image BTN_M_Ss = Properties.Resources.MOVIES_BTN_S;
        Image BTN_R_Es = Properties.Resources.RANDOM_BTNFX_S;
        Image BTN_R_Ss = Properties.Resources.RANDOM_BTN_S;




        private void GRf_Click(object sender, EventArgs e){
            //myflag.Image=(Image)rm.GetObject("TECHNOLOGY_BTN", ci);
            //LANG_C.Text = "Epilexte Glwssa:";
            CultureInfo ci = new CultureInfo("el-GR");
            Assembly a = Assembly.Load("WindowsFormsApplication1");
            ResourceManager rm = new ResourceManager(
                "WindowsFormsApplication1.MyLangs.L_GR", a);

            Info.Text = rm.GetString("Info", ci);
            BTN_E.Text = rm.GetString("Exit", ci);
            LANG_C.Text = rm.GetString("Lang", ci);
            LANG_C.Text = rm.GetString("Lang", ci);
            BTN_S.Text= rm.GetString("Settings", ci);


            //SET BG IMAGE
            OPT_T.BackgroundImage=(Image)rm.GetObject("TECHNOLOGY_BTN_GR", ci);
            OPT_G.BackgroundImage = (Image)rm.GetObject("GAMES_BTN_GR", ci);
            OPT_M.BackgroundImage = (Image)rm.GetObject("MOVIES_BTN_GR", ci);
            OPT_R.BackgroundImage = (Image)rm.GetObject("RANDOM_BTN_GR", ci);

            OPT_T.SizeMode = PictureBoxSizeMode.StretchImage;
            OPT_G.SizeMode = PictureBoxSizeMode.StretchImage;
            OPT_M.SizeMode = PictureBoxSizeMode.StretchImage;
            OPT_R.SizeMode = PictureBoxSizeMode.StretchImage;

            //BTN_T (GR - EnterMouse+LeaveMouse)
                BTN_T_Ss = Properties.Resources.TECHNOLOGY_BTN_GR;
                BTN_T_Es = Properties.Resources.TECHNOLOGY_BTNFX_GR;
                //BTN_T_Ss = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN\TECHNOLOGY_BTN_GR.PNG");
                //BTN_T_Es = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN_FX\TECHNOLOGY_BTNFX_GR.PNG");

            //BTN_G (GR - EnterMouse+LeaveMouse)
                BTN_G_Es = Properties.Resources.GAMES_BTNFX_GR;
                BTN_G_Ss = Properties.Resources.GAMES_BTN_GR;
                //BTN_G_Es = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN_FX\GAMES_BTNFX_GR.PNG");
                //BTN_G_Ss = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN\GAMES_BTN_GR.PNG");

            //BTN_M (GR - EnterMouse+LeaveMouse)
                BTN_M_Es = Properties.Resources.MOVIES_BTNFX_GR;
                BTN_M_Ss = Properties.Resources.MOVIES_BTN_GR;
                //BTN_M_Es = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN_FX\MOVIES_BTNFX_GR.PNG");
                //BTN_M_Ss = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN\MOVIES_BTN_GR.PNG");

            //BTN_R (GR - EnterMouse+LeaveMouse)
                BTN_R_Es = Properties.Resources.RANDOM_BTNFX_GR;
                BTN_R_Ss = Properties.Resources.RANDOM_BTN_GR;
                //BTN_R_Es = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN_FX\RANDOM_BTNFX_GR.PNG");
                //BTN_R_Ss = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN\RANDOM_BTN_GR.PNG");
        }

 /*=====================================================================================================*/

        private void ENf_Click(object sender, EventArgs e){
            //OPT_T.Image=(Image)rm.GetObject("TECHNOLOGY_BTN", ci);
            //LANG_C.Text = "Choose Language:";
            CultureInfo ci = new CultureInfo("en-US");
            Assembly a = Assembly.Load("WindowsFormsApplication1");
            ResourceManager rm = new ResourceManager(
                "WindowsFormsApplication1.MyLangs.L_EN", a);

            Info.Text = rm.GetString("Info", ci);
            BTN_E.Text = rm.GetString("Exit", ci);
            LANG_C.Text = rm.GetString("Lang", ci);
            BTN_S.Text = rm.GetString("Settings", ci);

            //SET BG IMAGE
            OPT_T.BackgroundImage = (Image)rm.GetObject("TECHNOLOGY_BTN_S", ci);
            OPT_G.BackgroundImage = (Image)rm.GetObject("GAMES_BTN_S", ci);
            OPT_M.BackgroundImage = (Image)rm.GetObject("MOVIES_BTN_S", ci);
            OPT_R.BackgroundImage = (Image)rm.GetObject("RANDOM_BTN_S", ci);

            OPT_T.SizeMode = PictureBoxSizeMode.StretchImage;
            OPT_G.SizeMode = PictureBoxSizeMode.StretchImage;
            OPT_M.SizeMode = PictureBoxSizeMode.StretchImage;
            OPT_R.SizeMode = PictureBoxSizeMode.StretchImage;


            //BTN_T (EN - EnterMouse+LeaveMouse)
                BTN_T_Es = Properties.Resources.TECHNOLOGY_BTNFX_S;
                BTN_T_Ss = Properties.Resources.TECHNOLOGY_BTN_S;
                //BTN_T_Es = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN_FX\TECHNOLOGY_BTNFX_S.PNG");
                //BTN_T_Ss = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN\TECHNOLOGY_BTN_S.PNG");

            //BTN_G (EN - EnterMouse+LeaveMouse)
                BTN_G_Es = Properties.Resources.GAMES_BTNFX_S;
                BTN_G_Ss = Properties.Resources.GAMES_BTN_S;
                //BTN_G_Es = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN_FX\GAMES_BTNFX_S.PNG");
                //BTN_G_Ss = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN\GAMES_BTN_S.PNG");

            //BTN_M (EN - EnterMouse+LeaveMouse)
                BTN_M_Es = Properties.Resources.MOVIES_BTNFX_S;
                BTN_M_Ss = Properties.Resources.MOVIES_BTN_S;
                //BTN_M_Es = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN_FX\MOVIES_BTNFX_S.PNG");
                //BTN_M_Ss = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN\MOVIES_BTN_S.PNG");

            //BTN_R (EN - EnterMouse+LeaveMouse)
                BTN_R_Es = Properties.Resources.RANDOM_BTNFX_S;
                BTN_R_Ss = Properties.Resources.RANDOM_BTN_S;
                //BTN_R_Es = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN_FX\RANDOM_BTNFX_S.PNG");
                //BTN_R_Ss = Image.FromFile(@"C:\Users\user\Desktop\QUIZ\BTN\RANDOM_BTN_S.PNG");
        }




        





        public Form1()
        {
            InitializeComponent();
        }

        //hover sound Properties.Resources.
        //SoundPlayer clickp = new SoundPlayer(@"C:\Users\user\Desktop\QUIZ\SOUND\clicks.wav");
        SoundPlayer clickp = new SoundPlayer(Properties.Resources.clicks);

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }



        private void LANG_C_Click(object sender, EventArgs e)
        {

        }



        private void BTN_E_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Closing Program",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                System.Windows.Forms.Application.Exit();
            
        }




        //TECHNOLOGY BUTTON

        private void OPT_T_Click(object sender, EventArgs e)
        {



            


            Form_T temp = new Form_T();
            temp.Region = this.Region;
            temp.Show();
            this.Hide();
            //temp.Close();
            temp.Location = this.Location;

        }

        private void OPT_T_MouseEnter(object sender, EventArgs e)
        {
            OPT_T.BackgroundImage = BTN_T_Es;

            clickp.Play();
        }

        private void OPT_T_MouseLeave(object sender, EventArgs e)
        {
            OPT_T.BackgroundImage = BTN_T_Ss;
        }

        //GAMES BUTTON
        private void OPT_G_Click_1(object sender, EventArgs e)
        {
            Form_G temp = new Form_G();
            temp.Region = this.Region;
            temp.Show();
            this.Hide();
            //temp.Close();
            temp.Location = this.Location;
        }


        private void OPT_G_MouseEnter(object sender, EventArgs e)
        {
            OPT_G.BackgroundImage = BTN_G_Es;

            clickp.Play();
        }

        private void OPT_G_MouseLeave(object sender, EventArgs e)
        {
            OPT_G.BackgroundImage = BTN_G_Ss;
        }



        //MOVIES BUTTON
        private void OPT_M_Click(object sender, EventArgs e)
        {
            Form_M temp = new Form_M();
            temp.Region = this.Region;
            temp.Show();
            this.Hide();
            //temp.Close();
            temp.Location = this.Location;
        }

        private void OPT_M_MouseEnter(object sender, EventArgs e)
        {
            OPT_M.BackgroundImage = BTN_M_Es;
            clickp.Play();
        }

        private void OPT_M_MouseLeave(object sender, EventArgs e)
        {
            OPT_M.BackgroundImage = BTN_M_Ss;
        }

       

        //RANDOM BUTTON

         private void OPT_R_Click(object sender, EventArgs e)
         {
            Form_R temp = new Form_R();
            temp.Region = this.Region;
            temp.Show();
            this.Hide();
            //temp.Close();
            temp.Location = this.Location;
        }

        private void OPT_R_MouseEnter(object sender, EventArgs e)
        {
            OPT_R.BackgroundImage = BTN_R_Es;
            clickp.Play();
        }

        private void OPT_R_MouseLeave(object sender, EventArgs e)
        {
            OPT_R.BackgroundImage = BTN_R_Ss;
        }

        private void BTN_S_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SOON...", "Settings");
        }
    }
}
