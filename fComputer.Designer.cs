using System.ComponentModel;

namespace lab2_5
{
    partial class fComputer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.gpData = new System.Windows.Forms.GroupBox();
            this.tbOS = new System.Windows.Forms.TextBox();
            this.tbNetworkCard = new System.Windows.Forms.TextBox();
            this.tbSoundCard = new System.Windows.Forms.TextBox();
            this.tbDrive = new System.Windows.Forms.TextBox();
            this.tbVideoCard = new System.Windows.Forms.TextBox();
            this.tbRam = new System.Windows.Forms.TextBox();
            this.lbOS = new System.Windows.Forms.Label();
            this.lbNetworkCard = new System.Windows.Forms.Label();
            this.lbSoundCard = new System.Windows.Forms.Label();
            this.lbDrive = new System.Windows.Forms.Label();
            this.lbVideocard = new System.Windows.Forms.Label();
            this.lbRam = new System.Windows.Forms.Label();
            this.tbProcessor = new System.Windows.Forms.TextBox();
            this.lbProcessor = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gpData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpData
            // 
            this.gpData.Controls.Add(this.tbOS);
            this.gpData.Controls.Add(this.tbNetworkCard);
            this.gpData.Controls.Add(this.tbSoundCard);
            this.gpData.Controls.Add(this.tbDrive);
            this.gpData.Controls.Add(this.tbVideoCard);
            this.gpData.Controls.Add(this.tbRam);
            this.gpData.Controls.Add(this.lbOS);
            this.gpData.Controls.Add(this.lbNetworkCard);
            this.gpData.Controls.Add(this.lbSoundCard);
            this.gpData.Controls.Add(this.lbDrive);
            this.gpData.Controls.Add(this.lbVideocard);
            this.gpData.Controls.Add(this.lbRam);
            this.gpData.Controls.Add(this.tbProcessor);
            this.gpData.Controls.Add(this.lbProcessor);
            this.gpData.Location = new System.Drawing.Point(26, 21);
            this.gpData.Name = "gpData";
            this.gpData.Size = new System.Drawing.Size(379, 397);
            this.gpData.TabIndex = 0;
            this.gpData.TabStop = false;
            this.gpData.Text = "Характеристики комп\'ютера";
            // 
            // tbOS
            // 
            this.tbOS.Location = new System.Drawing.Point(183, 309);
            this.tbOS.Name = "tbOS";
            this.tbOS.Size = new System.Drawing.Size(174, 22);
            this.tbOS.TabIndex = 13;
            // 
            // tbNetworkCard
            // 
            this.tbNetworkCard.Location = new System.Drawing.Point(183, 253);
            this.tbNetworkCard.Name = "tbNetworkCard";
            this.tbNetworkCard.Size = new System.Drawing.Size(174, 22);
            this.tbNetworkCard.TabIndex = 12;
            // 
            // tbSoundCard
            // 
            this.tbSoundCard.Location = new System.Drawing.Point(183, 205);
            this.tbSoundCard.Name = "tbSoundCard";
            this.tbSoundCard.Size = new System.Drawing.Size(174, 22);
            this.tbSoundCard.TabIndex = 11;
            // 
            // tbDrive
            // 
            this.tbDrive.Location = new System.Drawing.Point(183, 156);
            this.tbDrive.Name = "tbDrive";
            this.tbDrive.Size = new System.Drawing.Size(174, 22);
            this.tbDrive.TabIndex = 10;
            // 
            // tbVideoCard
            // 
            this.tbVideoCard.Location = new System.Drawing.Point(183, 113);
            this.tbVideoCard.Name = "tbVideoCard";
            this.tbVideoCard.Size = new System.Drawing.Size(174, 22);
            this.tbVideoCard.TabIndex = 9;
            // 
            // tbRam
            // 
            this.tbRam.Location = new System.Drawing.Point(183, 72);
            this.tbRam.Name = "tbRam";
            this.tbRam.Size = new System.Drawing.Size(174, 22);
            this.tbRam.TabIndex = 8;
            // 
            // lbOS
            // 
            this.lbOS.Location = new System.Drawing.Point(20, 312);
            this.lbOS.Name = "lbOS";
            this.lbOS.Size = new System.Drawing.Size(157, 22);
            this.lbOS.TabIndex = 7;
            this.lbOS.Text = "Операційна система:";
            // 
            // lbNetworkCard
            // 
            this.lbNetworkCard.Location = new System.Drawing.Point(20, 253);
            this.lbNetworkCard.Name = "lbNetworkCard";
            this.lbNetworkCard.Size = new System.Drawing.Size(157, 22);
            this.lbNetworkCard.TabIndex = 6;
            this.lbNetworkCard.Text = "Інтернет адаптер:";
            // 
            // lbSoundCard
            // 
            this.lbSoundCard.Location = new System.Drawing.Point(20, 205);
            this.lbSoundCard.Name = "lbSoundCard";
            this.lbSoundCard.Size = new System.Drawing.Size(157, 22);
            this.lbSoundCard.TabIndex = 5;
            this.lbSoundCard.Text = "Звукова карта:";
            // 
            // lbDrive
            // 
            this.lbDrive.Location = new System.Drawing.Point(20, 156);
            this.lbDrive.Name = "lbDrive";
            this.lbDrive.Size = new System.Drawing.Size(157, 22);
            this.lbDrive.TabIndex = 4;
            this.lbDrive.Text = "Пам\'ять:";
            // 
            // lbVideocard
            // 
            this.lbVideocard.Location = new System.Drawing.Point(20, 113);
            this.lbVideocard.Name = "lbVideocard";
            this.lbVideocard.Size = new System.Drawing.Size(157, 22);
            this.lbVideocard.TabIndex = 3;
            this.lbVideocard.Text = "Відеокарта:";
            // 
            // lbRam
            // 
            this.lbRam.Location = new System.Drawing.Point(20, 72);
            this.lbRam.Name = "lbRam";
            this.lbRam.Size = new System.Drawing.Size(157, 22);
            this.lbRam.TabIndex = 2;
            this.lbRam.Text = "Оперативна пам\'ять:";
            // 
            // tbProcessor
            // 
            this.tbProcessor.Location = new System.Drawing.Point(183, 33);
            this.tbProcessor.Name = "tbProcessor";
            this.tbProcessor.Size = new System.Drawing.Size(174, 22);
            this.tbProcessor.TabIndex = 1;
            // 
            // lbProcessor
            // 
            this.lbProcessor.Location = new System.Drawing.Point(20, 33);
            this.lbProcessor.Name = "lbProcessor";
            this.lbProcessor.Size = new System.Drawing.Size(157, 22);
            this.lbProcessor.TabIndex = 0;
            this.lbProcessor.Text = "Процесор:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(424, 40);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(136, 25);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Підтвердити";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(424, 89);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 25);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 439);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gpData);
            this.MaximizeBox = false;
            this.Name = "fComputer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дані про новий комп\'ютер";
            this.Load += new System.EventHandler(this.fComputer_Load);
            this.gpData.ResumeLayout(false);
            this.gpData.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnOk;

        private System.Windows.Forms.Button btnCancel;

        private System.Windows.Forms.Label lbDrive;
        private System.Windows.Forms.Label lbSoundCard;
        private System.Windows.Forms.Label lbNetworkCard;
        private System.Windows.Forms.Label lbOS;
        private System.Windows.Forms.TextBox tbRam;
        private System.Windows.Forms.TextBox tbVideoCard;
        private System.Windows.Forms.TextBox tbDrive;
        private System.Windows.Forms.TextBox tbSoundCard;
        private System.Windows.Forms.TextBox tbNetworkCard;
        private System.Windows.Forms.TextBox tbOS;

        private System.Windows.Forms.Label lbRam;
        private System.Windows.Forms.Label lbVideocard;

        private System.Windows.Forms.TextBox tbProcessor;

        private System.Windows.Forms.Label lbProcessor;

        private System.Windows.Forms.GroupBox gpData;

        #endregion
    }
}