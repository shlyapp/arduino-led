
namespace LedController.Settings
{
    partial class SettingsForm
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
            this.portBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.saveColorBtn = new System.Windows.Forms.Button();
            this.autoSaveColorBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // portBox
            // 
            this.portBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portBox.FormattingEnabled = true;
            this.portBox.Location = new System.Drawing.Point(270, 40);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(121, 33);
            this.portBox.TabIndex = 0;
            this.portBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Порт подключения";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Location = new System.Drawing.Point(243, 241);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(179, 58);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // saveColorBtn
            // 
            this.saveColorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveColorBtn.Location = new System.Drawing.Point(45, 114);
            this.saveColorBtn.Name = "saveColorBtn";
            this.saveColorBtn.Size = new System.Drawing.Size(186, 40);
            this.saveColorBtn.TabIndex = 3;
            this.saveColorBtn.Text = "Сохранить цвет";
            this.saveColorBtn.UseVisualStyleBackColor = true;
            this.saveColorBtn.Click += new System.EventHandler(this.saveColorBtn_Click);
            // 
            // autoSaveColorBox
            // 
            this.autoSaveColorBox.AutoSize = true;
            this.autoSaveColorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autoSaveColorBox.Location = new System.Drawing.Point(45, 79);
            this.autoSaveColorBox.Name = "autoSaveColorBox";
            this.autoSaveColorBox.Size = new System.Drawing.Size(244, 29);
            this.autoSaveColorBox.TabIndex = 4;
            this.autoSaveColorBox.Text = "Автосохранение цвета";
            this.autoSaveColorBox.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.autoSaveColorBox);
            this.Controls.Add(this.saveColorBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portBox);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox portBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button saveColorBtn;
        private System.Windows.Forms.CheckBox autoSaveColorBox;
    }
}