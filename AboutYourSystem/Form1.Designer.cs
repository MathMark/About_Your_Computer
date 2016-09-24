namespace AboutYourSystem
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
            this.InfoList = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // InfoList
            // 
            this.InfoList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.InfoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoList.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoList.ForeColor = System.Drawing.SystemColors.Menu;
            this.InfoList.Location = new System.Drawing.Point(0, 0);
            this.InfoList.Name = "InfoList";
            this.InfoList.Size = new System.Drawing.Size(653, 411);
            this.InfoList.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(653, 411);
            this.Controls.Add(this.InfoList);
            this.Name = "MainForm";
            this.Text = "AYS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView InfoList;
    }
}

