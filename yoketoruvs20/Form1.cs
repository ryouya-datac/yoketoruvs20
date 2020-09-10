using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yoketoruvs20
{
    public partial class Form1 : Form
    {
        enum State
        {
            None = -1,  // 無効
            Title,      // タイトル
            Game,       // ゲーム
            Gameover,   // ゲームオーバー
            Clear       // クリア
        }
        State currentState = State.None;
        State nextState = State.Title;


        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(nextState != State.None)
            {
                initProc();
            }
        }
        void initProc()
        {
            currentState = nextState;
            nextState = State.None;

            switch(currentState)
            {
                case State.Title:
                    timeLabel.Visible = true;
                    startbutton1.Visible = true;
                    copyrightLabel.Visible = true;
                    hiLabel.Visible = true;
                    gmaeOverlabel.Visible = true;
                    titlebutton.Visible = true;
                    clearlabel.Visible = true;
                    break;

                case State.Game:
                    timeLabel.Visible = true;
                    startbutton1.Visible = true;
                    copyrightLabel.Visible = true;
                    hiLabel.Visible = true;
                    break;
            }
        }

        private void startbutton1_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }
    }

}
