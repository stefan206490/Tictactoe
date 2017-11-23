using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace boterkaaseierenapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool turn = true;
        public bool AI = false;
        public bool AIzet = true;
        public string strLastMove = string.Empty;
        public string check = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (btn1.Content.ToString() == " ")
            {
                strLastMove = "btn1";
                if (turn)
                {
                    btn1.Content = "x";
                }
                else
                {
                    btn1.Content = "o";
                }
                Beurt();
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (btn2.Content.ToString() == " ")
            {
                strLastMove = "btn2";
                if (turn)
                {
                    btn2.Content = "x";
                }
                else
                {
                    btn2.Content = "o";
                }
                Beurt();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (btn3.Content.ToString() == " ")
            {
                strLastMove = "btn3";
                if (turn)
                {
                    btn3.Content = "x";
                }
                else
                {
                    btn3.Content = "o";
                }
                Beurt();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (btn4.Content.ToString() == " ")
            {
                strLastMove = "btn4";
                if (turn)
                {
                    btn4.Content = "x";
                }
                else
                {
                    btn4.Content = "o";
                }
                Beurt();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (btn5.Content.ToString() == " ")
            {
                strLastMove = "btn5";
                if (turn)
                {
                    btn5.Content = "x";
                }
                else
                {
                    btn5.Content = "o";
                }
                Beurt();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (btn6.Content.ToString() == " ")
            {
                strLastMove = "btn6";
                if (turn)
                {
                    btn6.Content = "x";
                }
                else
                {
                    btn6.Content = "o";
                }
                Beurt();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (btn7.Content.ToString() == " ")
            {
                strLastMove = "btn7";
                if (turn)
                {
                    btn7.Content = "x";
                }
                else
                {
                    btn7.Content = "o";
                }
                Beurt();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (btn8.Content.ToString() == " ")
            {
                strLastMove = "btn8";
                if (turn)
                {
                    btn8.Content = "x";
                }
                else
                {
                    btn8.Content = "o";
                }
                Beurt();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (btn9.Content.ToString() == " ")
            {
                strLastMove = "btn9";
                if (turn)
                {
                    btn9.Content = "x";
                }
                else
                {
                    btn9.Content = "o";
                }
                Beurt();
            }
        }

        public void Beurt()
        {
            if (turn)
            {
                turn = false;
                AIzet = true;
            } else
            {
                turn = true;
                AIzet = false;
            }
            CheckWon();
            if (turn)
            {
                lblturn.Content = "X his turn";
            } else
            {
                if (AI)
                {
                    lblturn.Content = "AI thinking..";
                    AIMove();
                }
                else
                {
                    lblturn.Content = "o his turn";
                }
            }
        }


        public void block()
        {
            if (AIzet)
            {
                if (btn2.Content.ToString() == check && btn3.Content.ToString() == check)
                {
                    //eerste horizontale lijn 1
                    btn1_Click(null, null);
                }
                else if (btn1.Content.ToString() == check && btn3.Content.ToString() == check)
                {
                    //eerste horizontale lijn 2
                    btn2_Click(null, null);
                }
                else if (btn1.Content.ToString() == check && btn2.Content.ToString() == check)
                {
                    //eerste horizontale lijn 3
                    btn3_Click(null, null);
                }
                else if (btn5.Content.ToString() == check && btn9.Content.ToString() == check)
                {
                    //schuin boven links onder rechts 1
                    btn1_Click(null, null);
                }
                else if (btn1.Content.ToString() == check && btn9.Content.ToString() == check)
                {
                    //schuin boven links onder rechts 2
                    btn5_Click(null, null);
                }
                else if (btn1.Content.ToString() == check && btn5.Content.ToString() == check)
                {
                    //schuin boven links onder rechts 3
                    btn9_Click(null, null);
                }
                else if (btn4.Content.ToString() == check && btn7.Content.ToString() == check)
                {
                    //eerste verticale lijn 1
                    btn1_Click(null, null);
                }
                else if (btn1.Content.ToString() == check && btn7.Content.ToString() == check)
                {
                    //eerste verticale lijn 2
                    btn4_Click(null, null);
                }
                else if (btn1.Content.ToString() == check && btn4.Content.ToString() == check)
                {
                    //eerste verticale lijn 3
                    btn7_Click(null, null);
                }
                else if (btn5.Content.ToString() == check && btn8.Content.ToString() == check)
                {
                    //tweede verticale lijn 1
                    btn2_Click(null, null);
                }
                else if (btn2.Content.ToString() == check && btn8.Content.ToString() == check)
                {
                    //tweede verticale lijn 2
                    btn5_Click(null, null);
                }
                else if (btn2.Content.ToString() == check && btn5.Content.ToString() == check)
                {
                    //tweede verticale lijn 3
                    btn8_Click(null, null);
                }
                else if (btn5.Content.ToString() == check && btn6.Content.ToString() == check)
                {
                    //tweede horizontale lijn 1
                    btn4_Click(null, null);
                }
                else if (btn4.Content.ToString() == check && btn6.Content.ToString() == check)
                {
                    //tweede horizontale lijn 2
                    btn5_Click(null, null);
                }
                else if (btn4.Content.ToString() == check && btn5.Content.ToString() == check)
                {
                    //tweede horizontale lijn 3
                    btn6_Click(null, null);
                }
                else if (btn5.Content.ToString() == check && btn7.Content.ToString() == check)
                {
                    //schuin boven rechts onder links 1
                    btn3_Click(null, null);
                }
                else if (btn3.Content.ToString() == check && btn7.Content.ToString() == check)
                {
                    //schuin boven rechts onder links 2
                    btn5_Click(null, null);
                }
                else if (btn3.Content.ToString() == check && btn5.Content.ToString() == check)
                {
                    //schuin boven rechts onder links 3
                    btn7_Click(null, null);
                }
                else if (btn8.Content.ToString() == check && btn9.Content.ToString() == check)
                {
                    //derde horizontale lijn 1
                    btn7_Click(null, null);
                }
                else if (btn7.Content.ToString() == check && btn9.Content.ToString() == check)
                {
                    //derde horizontale lijn 2
                    btn8_Click(null, null);
                }
                else if (btn7.Content.ToString() == check && btn8.Content.ToString() == check)
                {
                    //derde horizontale lijn 3
                    btn9_Click(null, null);
                }
                else if (btn6.Content.ToString() == check && btn9.Content.ToString() == check)
                {
                    //derde verticale lijn 1
                    btn3_Click(null, null);
                }
                else if (btn3.Content.ToString() == check && btn9.Content.ToString() == check)
                {
                    //derde verticale lijn 2
                    btn6_Click(null, null);
                }
                else if (btn3.Content.ToString() == check && btn6.Content.ToString() == check)
                {
                    //derde verticale lijn 3
                    btn9_Click(null, null);
                }
            }
        }


        public void AIMove()
        {
            //dit zijn de keuzes die de AI maakt als hij kansen van de tegenspeler moet blokkeren
            check = "o";
            block();
            //dit zijn de keuzes die de AI maakt als hij kansen van zichzelf ziet.
            check = "x";
            block();
            /*dit zijn mijn responses wanneer ik geen kansen heb of niets kan verhelpen
             * 
             * 
             * ik heb gezien dat het in de lastcheck mis gaat. nu ga ik kijken of ik nog iets kan veranderen door naar het hele bord te kijken.
             */
            if (AIzet)
            {
                //FullBoard();
            }
            if (AIzet)
            {
                LastCheck();
            }
        }


        public void FullBoard()
        {
            if (strLastMove == "btn1")
            {
                if (btn2.Content.ToString() == " ")
                {
                    btn2_Click(null, null);
                }
                else if (btn3.Content.ToString() == " ")
                {
                    btn3_Click(null, null);
                }
                else if (btn5.Content.ToString() == " ")
                {
                    btn5_Click(null, null);
                }
            }
        }

        public void LastCheck()
        {
            if (btn1.Content.ToString() == " ")
            {
                btn1_Click(null, null);
            }
            else if (btn3.Content.ToString() == " ")
            {
                btn3_Click(null, null);
            }
            else if (btn7.Content.ToString() == " ")
            {
                btn7_Click(null, null);
            }
            else if (btn9.Content.ToString() == " ")
            {
                btn9_Click(null, null);
            }
            else if (btn2.Content.ToString() == " ")
            {
                btn2_Click(null, null);
            }
            else if (btn4.Content.ToString() == " ")
            {
                btn4_Click(null, null);
            }
            else if (btn5.Content.ToString() == " ")
            {
                btn5_Click(null, null);
            }
            else if (btn6.Content.ToString() == " ")
            {
                btn6_Click(null, null);
            }
            else if (btn8.Content.ToString() == " ")
            {
                btn8_Click(null, null);
            }
        }

        public void Won(string check)
        {
            check = check + " heeft gewonnen";
            MessageBox.Show(check, "gefeliciteerd");
        }

        public void CheckWon()
        {
            string check = btn1.Content.ToString();
            if (check == "x" || check == "o")
            {
                if (btn2.Content.ToString() == check && btn3.Content.ToString() == check)
                {
                    //eerste horizontale lijn
                    Won(check);
                    Restart();
                }
                if (btn5.Content.ToString() == check && btn9.Content.ToString() == check)
                {
                    //schuin boven links onder rechts
                    Won(check);
                    Restart();
                }
                if (btn4.Content.ToString() == check && btn7.Content.ToString() == check)
                {
                    //eerste verticale lijn
                    Won(check);
                    Restart();
                }
            }

            check = btn5.Content.ToString();

            if (check == "x" || check == "o")
            {
                if (btn2.Content.ToString() == check && btn8.Content.ToString() == check)
                {
                    //tweede verticale lijn
                    Won(check);
                    Restart();
                }
                if (btn4.Content.ToString() == check && btn6.Content.ToString() == check)
                {
                    //tweede horizontale lijn
                    Won(check);
                    Restart();
                }
                if (btn3.Content.ToString() == check && btn7.Content.ToString() == check)
                {
                    //schuin boven rechts onder links
                    Won(check);
                    Restart();
                }
            }

            check = btn9.Content.ToString();

            if (check == "x" || check == "o")
            {
                if (btn7.Content.ToString() == check && btn8.Content.ToString() == check)
                {
                    //derde horizontale lijn
                    Won(check);
                    Restart();
                }
                if (btn3.Content.ToString() == check && btn6.Content.ToString() == check)
                {
                    //derde verticale lijn
                    Won(check);
                    Restart();
                }
            }

            //check for tie
            if (btn1.Content.ToString() != " " && btn2.Content.ToString() != " " && btn3.Content.ToString() != " " && btn4.Content.ToString() != " " && btn5.Content.ToString() != " " && btn6.Content.ToString() != " " && btn7.Content.ToString() != " " && btn8.Content.ToString() != " " && btn9.Content.ToString() != " ")
            {
                MessageBox.Show("het is gelijk spel", "Tic Tac Toe");
                Restart();
            }
        }

        private void btnRestart_Click(object sender, RoutedEventArgs e)
        {
            Restart();
        }
        public void Restart()
        {
            btn1.Content = " ";
            btn2.Content = " ";
            btn3.Content = " ";
            btn4.Content = " ";
            btn5.Content = " ";
            btn6.Content = " ";
            btn7.Content = " ";
            btn8.Content = " ";
            btn9.Content = " ";
            turn = true;
            lblturn.Content = "X his turn";
        }

        private void btnAI_Click(object sender, RoutedEventArgs e)
        {
            if (AI)
            {
                AI = false;
                btnAI.Content = "AI OFF";
            }else
            {
                AI = true;
                btnAI.Content = "AI ON";
            }
        }
    }
}
