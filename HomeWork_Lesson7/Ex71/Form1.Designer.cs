namespace Ex71
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.начатьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startGameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stopGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoStepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCurrentValue = new System.Windows.Forms.Label();
            this.lblStepsText = new System.Windows.Forms.Label();
            this.lblStepsCount = new System.Windows.Forms.Label();
            this.lblGoalText = new System.Windows.Forms.Label();
            this.lblGoal = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(171, 125);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(46, 17);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "label1";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCommand1
            // 
            this.btnCommand1.Location = new System.Drawing.Point(325, 61);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(75, 34);
            this.btnCommand1.TabIndex = 1;
            this.btnCommand1.Text = "button1";
            this.btnCommand1.UseVisualStyleBackColor = true;
            this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click_1);
            // 
            // btnCommand2
            // 
            this.btnCommand2.Location = new System.Drawing.Point(325, 120);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(75, 35);
            this.btnCommand2.TabIndex = 2;
            this.btnCommand2.Text = "button2";
            this.btnCommand2.UseVisualStyleBackColor = true;
            this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(325, 184);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 31);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "button3";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьИгруToolStripMenuItem,
            this.undoStepToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // начатьИгруToolStripMenuItem
            // 
            this.начатьИгруToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGameToolStripMenuItem1,
            this.stopGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.начатьИгруToolStripMenuItem.Name = "начатьИгруToolStripMenuItem";
            this.начатьИгруToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.начатьИгруToolStripMenuItem.Text = "Меню";
            // 
            // startGameToolStripMenuItem1
            // 
            this.startGameToolStripMenuItem1.Name = "startGameToolStripMenuItem1";
            this.startGameToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.startGameToolStripMenuItem1.Text = "Начать игру";
            this.startGameToolStripMenuItem1.Click += new System.EventHandler(this.startGameToolStripMenuItem1_Click);
            // 
            // stopGameToolStripMenuItem
            // 
            this.stopGameToolStripMenuItem.Name = "stopGameToolStripMenuItem";
            this.stopGameToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.stopGameToolStripMenuItem.Text = "Остановить игру";
            this.stopGameToolStripMenuItem.Click += new System.EventHandler(this.stopGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // undoStepToolStripMenuItem
            // 
            this.undoStepToolStripMenuItem.Name = "undoStepToolStripMenuItem";
            this.undoStepToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.undoStepToolStripMenuItem.Text = "Отменить ход";
            this.undoStepToolStripMenuItem.Click += new System.EventHandler(this.undoStepToolStripMenuItem_Click);
            // 
            // lblCurrentValue
            // 
            this.lblCurrentValue.AutoSize = true;
            this.lblCurrentValue.Location = new System.Drawing.Point(0, 125);
            this.lblCurrentValue.Name = "lblCurrentValue";
            this.lblCurrentValue.Size = new System.Drawing.Size(137, 17);
            this.lblCurrentValue.TabIndex = 5;
            this.lblCurrentValue.Text = "Текущее значение:";
            // 
            // lblStepsText
            // 
            this.lblStepsText.AutoSize = true;
            this.lblStepsText.Location = new System.Drawing.Point(3, 189);
            this.lblStepsText.Name = "lblStepsText";
            this.lblStepsText.Size = new System.Drawing.Size(114, 17);
            this.lblStepsText.TabIndex = 6;
            this.lblStepsText.Text = "Сделано ходов: ";
            // 
            // lblStepsCount
            // 
            this.lblStepsCount.AutoSize = true;
            this.lblStepsCount.Location = new System.Drawing.Point(171, 189);
            this.lblStepsCount.Name = "lblStepsCount";
            this.lblStepsCount.Size = new System.Drawing.Size(0, 17);
            this.lblStepsCount.TabIndex = 7;
            // 
            // lblGoalText
            // 
            this.lblGoalText.AutoSize = true;
            this.lblGoalText.Location = new System.Drawing.Point(0, 66);
            this.lblGoalText.Name = "lblGoalText";
            this.lblGoalText.Size = new System.Drawing.Size(46, 17);
            this.lblGoalText.TabIndex = 8;
            this.lblGoalText.Text = "Цель:";
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Location = new System.Drawing.Point(107, 66);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(0, 17);
            this.lblGoal.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.lblGoalText);
            this.Controls.Add(this.lblStepsCount);
            this.Controls.Add(this.lblStepsText);
            this.Controls.Add(this.lblCurrentValue);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCommand2);
            this.Controls.Add(this.btnCommand1);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem начатьИгруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startGameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem undoStepToolStripMenuItem;
        private System.Windows.Forms.Label lblCurrentValue;
        private System.Windows.Forms.Label lblStepsText;
        private System.Windows.Forms.Label lblStepsCount;
        private System.Windows.Forms.Label lblGoalText;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.ToolStripMenuItem stopGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

