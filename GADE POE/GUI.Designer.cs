namespace GADE_POE
{
    partial class GUI
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
            this.Up = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.HeroStats = new System.Windows.Forms.Label();
            this.EnemyList = new System.Windows.Forms.ListBox();
            this.AttackCheck = new System.Windows.Forms.Label();
            this.MapInterface = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Slot1 = new System.Windows.Forms.Button();
            this.Slot2 = new System.Windows.Forms.Button();
            this.slot3 = new System.Windows.Forms.Button();
            this.PriceSlot1 = new System.Windows.Forms.Label();
            this.PriceSlot2 = new System.Windows.Forms.Label();
            this.PriceSlot3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(592, 135);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(81, 39);
            this.Up.TabIndex = 1;
            this.Up.Text = "Up";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(507, 183);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(81, 39);
            this.Left.TabIndex = 1;
            this.Left.Text = "Left";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Down
            // 
            this.Down.Location = new System.Drawing.Point(592, 183);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(81, 39);
            this.Down.TabIndex = 1;
            this.Down.Text = "Down";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(679, 183);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(81, 39);
            this.Right.TabIndex = 1;
            this.Right.Text = "RIght";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(438, 11);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 29);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(679, 53);
            this.btnAttack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(97, 59);
            this.btnAttack.TabIndex = 3;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(438, 53);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(80, 26);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // HeroStats
            // 
            this.HeroStats.AutoSize = true;
            this.HeroStats.Location = new System.Drawing.Point(633, 285);
            this.HeroStats.Name = "HeroStats";
            this.HeroStats.Size = new System.Drawing.Size(38, 15);
            this.HeroStats.TabIndex = 6;
            this.HeroStats.Text = "label2";
            // 
            // EnemyList
            // 
            this.EnemyList.FormattingEnabled = true;
            this.EnemyList.ItemHeight = 15;
            this.EnemyList.Location = new System.Drawing.Point(533, 413);
            this.EnemyList.Name = "EnemyList";
            this.EnemyList.Size = new System.Drawing.Size(284, 124);
            this.EnemyList.TabIndex = 7;
            // 
            // AttackCheck
            // 
            this.AttackCheck.AutoSize = true;
            this.AttackCheck.Location = new System.Drawing.Point(464, 385);
            this.AttackCheck.Name = "AttackCheck";
            this.AttackCheck.Size = new System.Drawing.Size(38, 15);
            this.AttackCheck.TabIndex = 8;
            this.AttackCheck.Text = "label1";
            // 
            // MapInterface
            // 
            this.MapInterface.AutoSize = true;
            this.MapInterface.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MapInterface.Location = new System.Drawing.Point(70, 71);
            this.MapInterface.Name = "MapInterface";
            this.MapInterface.Size = new System.Drawing.Size(104, 32);
            this.MapInterface.TabIndex = 9;
            this.MapInterface.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(244, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Shop";
            // 
            // Slot1
            // 
            this.Slot1.Location = new System.Drawing.Point(133, 442);
            this.Slot1.Name = "Slot1";
            this.Slot1.Size = new System.Drawing.Size(80, 60);
            this.Slot1.TabIndex = 11;
            this.Slot1.UseVisualStyleBackColor = true;
            this.Slot1.Click += new System.EventHandler(this.Slot1_Click);
            // 
            // Slot2
            // 
            this.Slot2.Location = new System.Drawing.Point(239, 442);
            this.Slot2.Name = "Slot2";
            this.Slot2.Size = new System.Drawing.Size(80, 60);
            this.Slot2.TabIndex = 11;
            this.Slot2.UseVisualStyleBackColor = true;
            this.Slot2.Click += new System.EventHandler(this.Slot2_Click);
            // 
            // slot3
            // 
            this.slot3.Location = new System.Drawing.Point(346, 442);
            this.slot3.Name = "slot3";
            this.slot3.Size = new System.Drawing.Size(80, 60);
            this.slot3.TabIndex = 11;
            this.slot3.UseVisualStyleBackColor = true;
            this.slot3.Click += new System.EventHandler(this.slot3_Click);
            // 
            // PriceSlot1
            // 
            this.PriceSlot1.AutoSize = true;
            this.PriceSlot1.Location = new System.Drawing.Point(153, 505);
            this.PriceSlot1.Name = "PriceSlot1";
            this.PriceSlot1.Size = new System.Drawing.Size(38, 15);
            this.PriceSlot1.TabIndex = 12;
            this.PriceSlot1.Text = "label2";
            this.PriceSlot1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceSlot2
            // 
            this.PriceSlot2.AutoSize = true;
            this.PriceSlot2.Location = new System.Drawing.Point(261, 505);
            this.PriceSlot2.Name = "PriceSlot2";
            this.PriceSlot2.Size = new System.Drawing.Size(38, 15);
            this.PriceSlot2.TabIndex = 13;
            this.PriceSlot2.Text = "label2";
            this.PriceSlot2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PriceSlot2.Click += new System.EventHandler(this.PriceSlot2_Click);
            // 
            // PriceSlot3
            // 
            this.PriceSlot3.AutoSize = true;
            this.PriceSlot3.Location = new System.Drawing.Point(364, 505);
            this.PriceSlot3.Name = "PriceSlot3";
            this.PriceSlot3.Size = new System.Drawing.Size(38, 15);
            this.PriceSlot3.TabIndex = 14;
            this.PriceSlot3.Text = "label3";
            this.PriceSlot3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PriceSlot3.Click += new System.EventHandler(this.PriceSlot3_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 549);
            this.Controls.Add(this.PriceSlot3);
            this.Controls.Add(this.PriceSlot2);
            this.Controls.Add(this.PriceSlot1);
            this.Controls.Add(this.slot3);
            this.Controls.Add(this.Slot2);
            this.Controls.Add(this.Slot1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MapInterface);
            this.Controls.Add(this.AttackCheck);
            this.Controls.Add(this.EnemyList);
            this.Controls.Add(this.HeroStats);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Up);
            this.Name = "GUI";
            this.Text = "GUI";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label HeroStats;
        private System.Windows.Forms.ListBox EnemyList;
        private System.Windows.Forms.Label AttackCheck;
        private System.Windows.Forms.Label MapInterface;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Slot1;
        private System.Windows.Forms.Button Slot2;
        private System.Windows.Forms.Button slot3;
        private System.Windows.Forms.Label PriceSlot1;
        private System.Windows.Forms.Label PriceSlot2;
        private System.Windows.Forms.Label PriceSlot3;
    }
}