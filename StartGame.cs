using MathGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MathGame.Form1;
using static MathGame.StartGame;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MathGame
{
    public partial class StartGame : Form
    {
        public static stQuizz qzz = new stQuizz();
        public static short rawndgf = 0;
        public StartGame()
        {
            InitializeComponent();
            
        }
        public enum EnLivel
        {
            mix = 3, easy = 2, med = 1, hard = 0
        };
        public enum TypeOpe
        {
            add = 0, sub = 1, mul = 2, div1 = 3, mix1 = 4
        };
        public struct StGameStart
        {
            public int number1;
            public int number2;
            public int RowndGame;
            public int TimeGame;
            public EnLivel QueLivil;
            public TypeOpe QueType;
            public int ChoseAnawser ;
            public int TrueAnawser;
            public bool AnawserReslt;

        }
       public struct stQuizz
        {
        public StGameStart anwsaeListe;
        public int numberOfQusetins;
        public EnLivel QusetinsLivel;
        public TypeOpe OpType;
        public short NumberOfWrongAnswer ;
        public short NuberOfRightAnswer ;
        public bool IsPass ;
        };

        public static  StGameStart info;
        public static bool chick=true;

      private void StartGame_Load(object sender, EventArgs e)
        {
          
            setDateGame();
            timer1.Enabled = true;
            playMathGame(ref qzz);
           // PrentQwuse(quizz, 0);

        }
      StGameStart setDateGame()
        {
            Form1 frm = new Form1();
            frm.ShowDialog();

            info.QueLivil = (EnLivel)frm.Livel;
            info.QueType = (TypeOpe)frm.Opretor;
            info.RowndGame = frm.rowndRow;
            info.TimeGame = frm.TimeGame;
            return info;

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
           
            info.TimeGame--;
            TimeSpan ts = TimeSpan.FromSeconds(info.TimeGame);
            LpTime.Text = ts.Minutes.ToString()+":"+ts.Seconds.ToString();
           
            //if (info.TimeGame == 0)
            //{
               
            //    timer1.Stop();
            //    timer1.Enabled = false;
            //    MessageBox.Show("end");
            //}
        }

        int OpretorGame(int num1, int num2, TypeOpe Ope)
        {
            if (Ope == TypeOpe.add)
            {
                return num1 + num2;
            }
            else if (Ope == TypeOpe.sub)
            {
                return num1 - num2;
            }
            else if (Ope == TypeOpe.mul)
            {
                return num1 * num2;
            }
            else if (Ope == TypeOpe.div1)
            {
                return num1 / num2;
            }
            return 1;
        }

        TypeOpe GetRondomType()
        {
            Random random = new Random();
            int Op = random.Next(0,4);
            return (TypeOpe)Op;
        }
        StGameStart QwuseRownd(EnLivel Livel, TypeOpe Opretoin)
        {
            StGameStart Anawser=new StGameStart();
            Random random = new Random();
            if (Livel == EnLivel.mix)
            {
                Livel = (EnLivel)random.Next(0,2);
            }
            if (Opretoin == TypeOpe.mix1)
            {
                Opretoin = (TypeOpe)random.Next(0, 3);
            }
            Anawser.QueType = Opretoin;
            switch (Livel)
            {
                case EnLivel.easy:
                    Anawser.number1 = random.Next(1, 10);
                    Anawser.number2 = random.Next(1, 10);
                    Anawser.TrueAnawser = OpretorGame(Anawser.number1, Anawser.number2, Anawser.QueType);
                    Anawser.QueLivil = Livel;
                    return Anawser;

                case EnLivel.med:
                    Anawser.number1 = random.Next(10, 20);
                    Anawser.number2 = random.Next(10, 20);
                    Anawser.TrueAnawser = OpretorGame(Anawser.number1, Anawser.number2, Anawser.QueType);
                    Anawser.QueLivil = Livel;
                    return Anawser;
                   
                case EnLivel.hard:
                    Anawser.number1 = random.Next(20, 30);
                    Anawser.number2 = random.Next(20, 30);
                    Anawser.TrueAnawser = OpretorGame(Anawser.number1, Anawser.number2, Anawser.QueType);
                    Anawser.QueLivil = Livel;
                    return Anawser;
                   
                default:
                    break;
            }
            return Anawser;
        }
        void QuseGameRownd(ref stQuizz quzz )
        {
          

           
                quzz.anwsaeListe = QwuseRownd(quzz.QusetinsLivel, quzz.OpType);
            
            
        }


        void corectUserAnawser(ref stQuizz quizz)
        {
             
            quizz.anwsaeListe.ChoseAnawser =Convert.ToInt32(txchoseUser.Text);
            if (quizz.anwsaeListe.ChoseAnawser != quizz.anwsaeListe.TrueAnawser)
            {
                quizz.anwsaeListe.AnawserReslt = false;
                quizz.NumberOfWrongAnswer++;
                lbAnawserWiring.Text = quizz.NumberOfWrongAnswer.ToString();
               //quizz.anwsaeListe[NumberASK].TrueAnawser ;
            }
            else
            {
                quizz.anwsaeListe.AnawserReslt = true;
                quizz.NuberOfRightAnswer++;
                LbAnawserTuro.Text = quizz.NuberOfRightAnswer.ToString();
            }
            quizz.IsPass = quizz.anwsaeListe.AnawserReslt;
            txchoseUser.Clear();
        }
        void chosePcsherOretor(stQuizz quizz)
        {
            if (quizz.anwsaeListe.QueType== TypeOpe.add)
            {
                pcOpretorShow.Image = Resources.plas;
            }else if(quizz.anwsaeListe.QueType == TypeOpe.sub)
            {
                pcOpretorShow.Image = Resources.sup;
            }
            else if (quizz.anwsaeListe.QueType == TypeOpe.mul)
            {
                pcOpretorShow.Image = Resources.mult;
            }
            else if (quizz.anwsaeListe.QueType == TypeOpe.div1)
            {
                pcOpretorShow.Image = Resources.div;
            }
        }


        void PrentQwuse(stQuizz quizz)
        {

            chosePcsherOretor(quizz);
            lbNum1.Text = quizz.anwsaeListe.number1.ToString();
            lbNum2.Text = quizz.anwsaeListe.number2.ToString();

        }
        void AskAndCorrectQuseList(stQuizz quizz)
        {
        
            quizz.IsPass = (quizz.NuberOfRightAnswer >= quizz.NumberOfWrongAnswer);
            if (quizz.IsPass)
            {
                MessageBox.Show("you wiin");
            }
            else
            {
                MessageBox.Show("loser");
            }
            
        }
           
        
        string ConvertLivl(EnLivel lIVE)
        {
           
            string[] liv = { "hard", "med", "easy", "  mix" };
            return liv[Convert.ToInt32(lIVE)];
        }
        string ConvertOpretor(TypeOpe typedx)
        {
            
            string[] liv = { "add", "sub", "mul", "  div1", "mix1" };
            return liv[Convert.ToInt32(typedx)];
        }
        void playMathGame(ref stQuizz quizz)
        {
           
            quizz.numberOfQusetins = info.RowndGame;
            quizz.QusetinsLivel = info.QueLivil;
            quizz.OpType = info.QueType;
            lbRawnd.Text = info.RowndGame.ToString();
            lpLivel.Text = ConvertLivl(info.QueLivil);
            LbOparetor.Text = ConvertOpretor(info.QueType);
          

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
            if (chick == true)
            {
                if (rawndgf == info.RowndGame || info.TimeGame == 0)
                {

                    btnChick.Enabled = false;
                    panel2.Visible = false;
                    timer1.Stop();
                    timer1.Enabled = false;
                    MessageBox.Show("game end");
                    AskAndCorrectQuseList(qzz);
                }
                QuseGameRownd(ref qzz);
                PrentQwuse(qzz);
               
               
                chick = false;
                rawndgf++;
            }
            
            
           
            return;
        }

        private void btnChick_Click(object sender, EventArgs e)
        {
            
            corectUserAnawser(ref qzz);
           
            chick = true;
           

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           
           
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txchoseUser_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
