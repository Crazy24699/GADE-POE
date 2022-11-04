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
            this.EnemyList.Location = new System.Drawing.Point(633, 413);
            this.EnemyList.Name = "EnemyList";
            this.EnemyList.Size = new System.Drawing.Size(184, 124);
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
            this.MapInterface.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MapInterface.Location = new System.Drawing.Point(70, 71);
            this.MapInterface.Name = "MapInterface";
            this.MapInterface.Size = new System.Drawing.Size(82, 24);
            this.MapInterface.TabIndex = 9;
            this.MapInterface.Text = "label1";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 549);
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
    }
}