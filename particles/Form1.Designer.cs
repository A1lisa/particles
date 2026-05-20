namespace particles
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
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbRadius = new System.Windows.Forms.TrackBar();
            this.lblDirection = new System.Windows.Forms.Label();
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRedX = new System.Windows.Forms.Label();
            this.lblBlueX = new System.Windows.Forms.Label();
            this.tbRedX = new System.Windows.Forms.TrackBar();
            this.lblGreenX = new System.Windows.Forms.Label();
            this.tbGreenX = new System.Windows.Forms.TrackBar();
            this.tbBlueX = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRedX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreenX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlueX)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(12, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(832, 500);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbRadius
            // 
            this.tbRadius.Location = new System.Drawing.Point(853, 42);
            this.tbRadius.Maximum = 100;
            this.tbRadius.Minimum = 40;
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbRadius.Size = new System.Drawing.Size(180, 56);
            this.tbRadius.TabIndex = 1;
            this.tbRadius.Value = 40;
            this.tbRadius.Scroll += new System.EventHandler(this.tbRadius_Scroll);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(319, 471);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(0, 16);
            this.lblDirection.TabIndex = 2;
            // 
            // tbDirection
            // 
            this.tbDirection.Location = new System.Drawing.Point(850, 120);
            this.tbDirection.Maximum = 360;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(180, 56);
            this.tbDirection.TabIndex = 3;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(853, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Радиус: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(853, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Направление выхода: ";
            // 
            // lblRedX
            // 
            this.lblRedX.AutoSize = true;
            this.lblRedX.Location = new System.Drawing.Point(854, 179);
            this.lblRedX.Name = "lblRedX";
            this.lblRedX.Size = new System.Drawing.Size(215, 16);
            this.lblRedX.TabIndex = 7;
            this.lblRedX.Text = "Положение красного круга по Х";
            // 
            // lblBlueX
            // 
            this.lblBlueX.AutoSize = true;
            this.lblBlueX.Location = new System.Drawing.Point(854, 335);
            this.lblBlueX.Name = "lblBlueX";
            this.lblBlueX.Size = new System.Drawing.Size(200, 16);
            this.lblBlueX.TabIndex = 9;
            this.lblBlueX.Text = "Положение синего круга по Х";
            // 
            // tbRedX
            // 
            this.tbRedX.Location = new System.Drawing.Point(856, 198);
            this.tbRedX.Maximum = 500;
            this.tbRedX.Name = "tbRedX";
            this.tbRedX.Size = new System.Drawing.Size(177, 56);
            this.tbRedX.TabIndex = 10;
            this.tbRedX.Value = 400;
            this.tbRedX.Scroll += new System.EventHandler(this.tbRedX_Scroll);
            // 
            // lblGreenX
            // 
            this.lblGreenX.AutoSize = true;
            this.lblGreenX.Location = new System.Drawing.Point(854, 257);
            this.lblGreenX.Name = "lblGreenX";
            this.lblGreenX.Size = new System.Drawing.Size(217, 16);
            this.lblGreenX.TabIndex = 8;
            this.lblGreenX.Text = "Положение зеленого круга по Х";
            // 
            // tbGreenX
            // 
            this.tbGreenX.Location = new System.Drawing.Point(856, 276);
            this.tbGreenX.Maximum = 500;
            this.tbGreenX.Name = "tbGreenX";
            this.tbGreenX.Size = new System.Drawing.Size(177, 56);
            this.tbGreenX.TabIndex = 11;
            this.tbGreenX.Value = 400;
            this.tbGreenX.Scroll += new System.EventHandler(this.tbGreenX_Scroll);
            // 
            // tbBlueX
            // 
            this.tbBlueX.Location = new System.Drawing.Point(856, 368);
            this.tbBlueX.Maximum = 500;
            this.tbBlueX.Name = "tbBlueX";
            this.tbBlueX.Size = new System.Drawing.Size(177, 56);
            this.tbBlueX.TabIndex = 12;
            this.tbBlueX.Value = 400;
            this.tbBlueX.Scroll += new System.EventHandler(this.tbBlueX_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 524);
            this.Controls.Add(this.tbBlueX);
            this.Controls.Add(this.tbGreenX);
            this.Controls.Add(this.tbRedX);
            this.Controls.Add(this.lblBlueX);
            this.Controls.Add(this.lblGreenX);
            this.Controls.Add(this.lblRedX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.tbRadius);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRedX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreenX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlueX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbRadius;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.TrackBar tbDirection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRedX;
        private System.Windows.Forms.Label lblBlueX;
        private System.Windows.Forms.TrackBar tbRedX;
        private System.Windows.Forms.Label lblGreenX;
        private System.Windows.Forms.TrackBar tbGreenX;
        private System.Windows.Forms.TrackBar tbBlueX;
    }
}

