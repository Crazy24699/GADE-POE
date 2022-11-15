using GADEpart1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE_POE
{
    public partial class GUI : Form
    {
        private GameEngine GameEngine;



        public bool UpInput = true, DownInput = true, LeftInput = true, RightInput = true;

        //public GameEngine GameEngine = new GameEngine();
        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            GameEngine = new GameEngine();
            UpdateView();
            
        }

        private void Map_TextChanged(object sender, EventArgs e)
        {

        }

        private void Map_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Up_Click(object sender, EventArgs e)
        {
            GameEngine.MovePlayer(Characters.Movements.Up);
            EnemyTurn();
            UpdateView();
            AttackCheck.Text = "";
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(GameEngine.Map.xAxis.ToString(), GameEngine.Map.yAxis.ToString());


        }



        private void Right_Click(object sender, EventArgs e)
        {
            GameEngine.MovePlayer(Characters.Movements.Right);
            EnemyTurn();
            UpdateView();
            AttackCheck.Text = "";
        }



        private void Left_Click(object sender, EventArgs e)
        {
            GameEngine.MovePlayer(Characters.Movements.Left);
            EnemyTurn();
            UpdateView();
            AttackCheck.Text = "";
        }

        private void Down_Click(object sender, EventArgs e)
        {
            GameEngine.MovePlayer(Characters.Movements.Down);
            EnemyTurn();
            UpdateView();
            AttackCheck.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GameEngine.Save();
        }

        private void Slot1_Click(object sender, EventArgs e)
        {

            BuyingItems(1);
        }

        //buying item method
        public void BuyingItems(int Slot)
        {
            DialogResult ChosenOption = MessageBox.Show("Confrim Purchase", "Do you want to buy " + "ITEM " + " for " + "GOLD AMMOUNT",MessageBoxButtons.YesNo);
            
            if (ChosenOption == DialogResult.Yes)
            {
                GameEngine.BuyItem(Slot);


            }
            else if(ChosenOption == DialogResult.No)
            {
                
            }
        }

        private void Slot2_Click(object sender, EventArgs e)
        {
            BuyingItems(2);
        }

        private void slot3_Click(object sender, EventArgs e)
        {
            BuyingItems(3);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            GameEngine.Load();
        }

        public void UpdateView()
        {
            MapInterface.Text = GameEngine.Map.ToString();
            HeroStats.Text = GameEngine.Map.Hero.ToString();

            EnemyList.Items.Clear();

            for (int Enemy = 0; Enemy < GameEngine.Map.TotalEnemyCount;)
            {
                EnemyList.Items.Add(GameEngine.Map.Enemies[Enemy].ToString());
                Enemy++;
            }
        }

        public void EnemyTurn()
        {
            GameEngine.EnemyMovement();
            GameEngine.EnemyAttack();
        }

    }
}
