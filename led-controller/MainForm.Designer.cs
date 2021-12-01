
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
            this.components = new System.ComponentModel.Container();
            this.connectBtn = new System.Windows.Forms.Button();
            this.buttonContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.consoleBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectBtn
            // 
            this.connectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectBtn.Location = new System.Drawing.Point(618, 12);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(170, 60);
            this.connectBtn.TabIndex = 1;
            this.connectBtn.Text = "Подключить";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // buttonContextMenu
            // 
            this.buttonContextMenu.Name = "buttonContextMenu";
            this.buttonContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // consoleBtn
            // 
            this.consoleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.consoleBtn.Location = new System.Drawing.Point(618, 100);
            this.consoleBtn.Name = "consoleBtn";
            this.consoleBtn.Size = new System.Drawing.Size(170, 60);
            this.consoleBtn.TabIndex = 3;
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
            this.settingsBtn.Text = "Настройки";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.consoleBtn);
            this.Controls.Add(this.connectBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.ContextMenuStrip buttonContextMenu;
        private System.Windows.Forms.Button consoleBtn;
        private System.Windows.Forms.Button settingsBtn;
    }
}

