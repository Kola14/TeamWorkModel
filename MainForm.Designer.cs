namespace TeamWork
{
    partial class MainForm
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
            this.lblWorkers = new System.Windows.Forms.Label();
            this.btnModel = new System.Windows.Forms.Button();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.btnEditWorker0 = new System.Windows.Forms.Button();
            this.btnDeleteWorker0 = new System.Windows.Forms.Button();
            this.tbWorkerId0 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblWorkers
            // 
            this.lblWorkers.AutoSize = true;
            this.lblWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWorkers.Location = new System.Drawing.Point(12, 9);
            this.lblWorkers.Name = "lblWorkers";
            this.lblWorkers.Size = new System.Drawing.Size(128, 20);
            this.lblWorkers.TabIndex = 5;
            this.lblWorkers.Text = "Список рабочих";
            // 
            // btnModel
            // 
            this.btnModel.Location = new System.Drawing.Point(13, 415);
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(190, 23);
            this.btnModel.TabIndex = 6;
            this.btnModel.Text = "Провести моделирование";
            this.btnModel.UseVisualStyleBackColor = true;
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.Location = new System.Drawing.Point(12, 389);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(75, 23);
            this.btnAddWorker.TabIndex = 7;
            this.btnAddWorker.Text = "Добавить";
            this.btnAddWorker.UseVisualStyleBackColor = true;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // btnEditWorker0
            // 
            this.btnEditWorker0.Location = new System.Drawing.Point(65, 32);
            this.btnEditWorker0.Name = "btnEditWorker0";
            this.btnEditWorker0.Size = new System.Drawing.Size(75, 23);
            this.btnEditWorker0.TabIndex = 8;
            this.btnEditWorker0.Tag = "0";
            this.btnEditWorker0.Text = "Edit";
            this.btnEditWorker0.UseVisualStyleBackColor = true;
            // 
            // btnDeleteWorker0
            // 
            this.btnDeleteWorker0.Location = new System.Drawing.Point(146, 32);
            this.btnDeleteWorker0.Name = "btnDeleteWorker0";
            this.btnDeleteWorker0.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteWorker0.TabIndex = 9;
            this.btnDeleteWorker0.Tag = "0";
            this.btnDeleteWorker0.Text = "Delete";
            this.btnDeleteWorker0.UseVisualStyleBackColor = true;
            // 
            // tbWorkerId0
            // 
            this.tbWorkerId0.Location = new System.Drawing.Point(13, 34);
            this.tbWorkerId0.Name = "tbWorkerId0";
            this.tbWorkerId0.ReadOnly = true;
            this.tbWorkerId0.Size = new System.Drawing.Size(46, 20);
            this.tbWorkerId0.TabIndex = 10;
            this.tbWorkerId0.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbWorkerId0);
            this.Controls.Add(this.btnDeleteWorker0);
            this.Controls.Add(this.btnEditWorker0);
            this.Controls.Add(this.btnAddWorker);
            this.Controls.Add(this.btnModel);
            this.Controls.Add(this.lblWorkers);
            this.Name = "MainForm";
            this.Text = "Модель производства";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblWorkers;
        private System.Windows.Forms.Button btnModel;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.Button btnEditWorker0;
        private System.Windows.Forms.Button btnDeleteWorker0;
        private System.Windows.Forms.TextBox tbWorkerId0;
    }
}

