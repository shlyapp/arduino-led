
namespace LedController
{
    partial class MainForm
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
            this.consoleBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.redBar = new System.Windows.Forms.VScrollBar();
            this.greenBar = new System.Windows.Forms.VScrollBar();
            this.blueBar = new System.Windows.Forms.VScrollBar();
            this.changeColorBtn = new System.Windows.Forms.Button();
            this.randomBtn = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // connectBtn
            // 
            this.connectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectBtn.Location = new System.Drawing.Point(618, 12);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(170, 60);
            this.connectBtn.TabIndex = 1;
            this.connectBtn.TabStop = false;
            this.connectBtn.Text = "Подключить";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // consoleBtn
            // 
            this.consoleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.consoleBtn.Location = new System.Drawing.Point(618, 100);
            this.consoleBtn.Name = "consoleBtn";
            this.consoleBtn.Size = new System.Drawing.Size(170, 60);
            this.consoleBtn.TabIndex = 3;
            this.consoleBtn.TabStop = false;
            this.consoleBtn.Text = "Консоль";
            this.consoleBtn.UseVisualStyleBackColor = true;
            // 
            // settingsBtn
            // 
            this.settingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsBtn.Location = new System.Drawing.Point(618, 194);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(170, 60);
            this.settingsBtn.TabIndex = 4;
            this.settingsBtn.TabStop = false;
            this.settingsBtn.Text = "Настройки";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // redBar
            // 
            this.redBar.Location = new System.Drawing.Point(180, 47);
            this.redBar.Name = "redBar";
            this.redBar.Size = new System.Drawing.Size(50, 350);
            this.redBar.TabIndex = 5;
            this.redBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ChangeColor);
            // 
            // greenBar
            // 
            this.greenBar.Location = new System.Drawing.Point(246, 47);
            this.greenBar.Name = "greenBar";
            this.greenBar.Size = new System.Drawing.Size(50, 350);
            this.greenBar.TabIndex = 6;
            this.greenBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ChangeColor);
            // 
            // blueBar
            // 
            this.blueBar.Location = new System.Drawing.Point(313, 47);
            this.blueBar.Name = "blueBar";
            this.blueBar.Size = new System.Drawing.Size(50, 350);
            this.blueBar.TabIndex = 7;
            this.blueBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ChangeColor);
            // 
            // changeColorBtn
            // 
            this.changeColorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeColorBtn.Location = new System.Drawing.Point(13, 47);
            this.changeColorBtn.Name = "changeColorBtn";
            this.changeColorBtn.Size = new System.Drawing.Size(155, 70);
            this.changeColorBtn.TabIndex = 8;
            this.changeColorBtn.Text = "Выбрать цвет";
            this.changeColorBtn.UseVisualStyleBackColor = true;
            this.changeColorBtn.Click += new System.EventHandler(this.changeColorBtn_Click);
            // 
            // randomBtn
            // 
            this.randomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randomBtn.Location = new System.Drawing.Point(12, 137);
            this.randomBtn.Name = "randomBtn";
            this.randomBtn.Size = new System.Drawing.Size(155, 70);
            this.randomBtn.TabIndex = 9;
            this.randomBtn.Text = "Случайный цвет";
            this.randomBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.randomBtn);
            this.Controls.Add(this.changeColorBtn);
            this.Controls.Add(this.blueBar);
            this.Controls.Add(this.greenBar);
            this.Controls.Add(this.redBar);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.consoleBtn);
            this.Controls.Add(this.connectBtn);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button consoleBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.VScrollBar redBar;
        private System.Windows.Forms.VScrollBar greenBar;
        private System.Windows.Forms.VScrollBar blueBar;
        private System.Windows.Forms.Button changeColorBtn;
        private System.Windows.Forms.Button randomBtn;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

