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

            PopulateShop();
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

            //testing
            for (int i = 0; i < GameEngine.Shop.Weapons.Length; i++)
            {
                Debug.Write(GameEngine.Shop.Weapons[i].WeaponType.ToString());
            }
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


            BuyingItems(0);


        }

        public void PopulateShop()
        {
            Slot1.Text = GameEngine.Shop.Weapons[0].WeaponType.ToString();
            Slot2.Text = GameEngine.Shop.Weapons[1].WeaponType.ToString();
            slot3.Text = GameEngine.Shop.Weapons[2].WeaponType.ToString();

            PriceSlot1.Text = GameEngine.Shop.Weapons[0].WeaponCost.ToString();
            PriceSlot2.Text = GameEngine.Shop.Weapons[1].WeaponCost.ToString();
            PriceSlot3.Text = GameEngine.Shop.Weapons[2].WeaponCost.ToString();
        }

        //buying item method
        public void BuyingItems(int Slot)
        {

            DialogResult ChosenOption = MessageBox.Show("Confrim Purchase", "Do you want to buy " + "ITEM " + " for " + "GOLD AMMOUNT",MessageBoxButtons.YesNo);
            
            if (ChosenOption == DialogResult.Yes)
            {
                //GameEngine.BuyItem(Slot);
                GameEngine.Shop.handleWeapon(Slot);
                PopulateShop();
            }
            else if(ChosenOption == DialogResult.No)
            {
                
            }
        }

        private void Slot2_Click(object sender, EventArgs e)
        {
            BuyingItems(1);
            
            //Slot2.Text = GameEngine.Shop.Weapons[1].WeaponType.ToString();
        }

        private void slot3_Click(object sender, EventArgs e)
        {
            BuyingItems(2);
            //Slot2.Text = GameEngine.Shop.Weapons[2].WeaponType.ToString();
        }

        private void PriceSlot3_Click(object sender, EventArgs e)
        {

        }

        private void PriceSlot2_Click(object sender, EventArgs e)
        {

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
