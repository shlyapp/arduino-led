
namespace arduino_with_pc
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
            this.connectBtn = new System.Windows.Forms.Button();
            this.consoleText = new System.Windows.Forms.TextBox();
            this.ledBtn = new System.Windows.Forms.Button();
            this.redLed = new System.Windows.Forms.VScrollBar();
            this.greenLed = new System.Windows.Forms.VScrollBar();
            this.blueLed = new System.Windows.Forms.VScrollBar();
            this.speedLed = new System.Windows.Forms.VScrollBar();
            this.infoText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // connectBtn
            // 
            this.connectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectBtn.Location = new System.Drawing.Point(357, 27);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(161, 72);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // consoleText
            // 
            this.consoleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.consoleText.Location = new System.Drawing.Point(357, 125);
            this.consoleText.Multiline = true;
            this.consoleText.Name = "consoleText";
            this.consoleText.ReadOnly = true;
            this.consoleText.Size = new System.Drawing.Size(405, 60);
            this.consoleText.TabIndex = 1;
            this.consoleText.TabStop = false;
            this.consoleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ledBtn
            // 
            this.ledBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ledBtn.Location = new System.Drawing.Point(593, 27);
            this.ledBtn.Name = "ledBtn";
            this.ledBtn.Size = new System.Drawing.Size(169, 72);
            this.ledBtn.TabIndex = 2;
            this.ledBtn.Text = "Turn on the LED";
            this.ledBtn.UseVisualStyleBackColor = true;
            this.ledBtn.Click += new System.EventHandler(this.ledBtn_Click);
            // 
            // redLed
            // 
            this.redLed.Location = new System.Drawing.Point(37, 66);
            this.redLed.Name = "redLed";
            this.redLed.Size = new System.Drawing.Size(50, 281);
            this.redLed.TabIndex = 3;
            this.redLed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.redLed_Scroll);
            // 
            // greenLed
            // 
            this.greenLed.Location = new System.Drawing.Point(123, 66);
            this.greenLed.Name = "greenLed";
            this.greenLed.Size = new System.Drawing.Size(50, 281);
            this.greenLed.TabIndex = 4;
            this.greenLed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.greenLed_Scroll);
            // 
            // blueLed
            // 
            this.blueLed.Location = new System.Drawing.Point(201, 66);
            this.blueLed.Name = "blueLed";
            this.blueLed.Size = new System.Drawing.Size(50, 281);
            this.blueLed.TabIndex = 5;
            this.blueLed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.blueLed_Scroll);
            // 
            // speedLed
            // 
            this.speedLed.Location = new System.Drawing.Point(280, 27);
            this.speedLed.Name = "speedLed";
            this.speedLed.Size = new System.Drawing.Size(50, 320);
            this.speedLed.TabIndex = 6;
            this.speedLed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.speedLed_Scroll);
            // 
            // infoText
            // 
            this.infoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoText.Location = new System.Drawing.Point(37, 8);
            this.infoText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.infoText.Multiline = true;
            this.infoText.Name = "infoText";
            this.infoText.ReadOnly = true;
            this.infoText.Size = new System.Drawing.Size(199, 49);
            this.infoText.TabIndex = 7;
            this.infoText.TabStop = false;
            this.infoText.Text = "R G B";
            this.infoText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(357, 207);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(407, 184);
            this.textBox1.TabIndex = 8;
            this.textBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.speedLed);
            this.Controls.Add(this.blueLed);
            this.Controls.Add(this.greenLed);
            this.Controls.Add(this.redLed);
            this.Controls.Add(this.ledBtn);
            this.Controls.Add(this.consoleText);
            this.Controls.Add(this.connectBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.TextBox consoleText;
        private System.Windows.Forms.Button ledBtn;
        private System.Windows.Forms.VScrollBar redLed;
        private System.Windows.Forms.VScrollBar greenLed;
        private System.Windows.Forms.VScrollBar blueLed;
        private System.Windows.Forms.VScrollBar speedLed;
        private System.Windows.Forms.TextBox infoText;
        private System.Windows.Forms.TextBox textBox1;
    }
}

