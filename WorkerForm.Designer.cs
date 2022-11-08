namespace TeamWork
{
    partial class WorkerForm
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
            this.lblOperations = new System.Windows.Forms.Label();
            this.btnAddOperation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddRelationship = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tbWorkerName = new System.Windows.Forms.TextBox();
            this.tbOperationId0 = new System.Windows.Forms.TextBox();
            this.btnDelete0 = new System.Windows.Forms.Button();
            this.tbNext0 = new System.Windows.Forms.TextBox();
            this.numTime0 = new System.Windows.Forms.NumericUpDown();
            this.btnDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTime0)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOperations
            // 
            this.lblOperations.AutoSize = true;
            this.lblOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblOperations.Location = new System.Drawing.Point(13, 41);
            this.lblOperations.Name = "lblOperations";
            this.lblOperations.Size = new System.Drawing.Size(193, 20);
            this.lblOperations.TabIndex = 0;
            this.lblOperations.Text = "Выполняемые операции";
            // 
            // btnAddOperation
            // 
            this.btnAddOperation.Location = new System.Drawing.Point(12, 282);
            this.btnAddOperation.Name = "btnAddOperation";
            this.btnAddOperation.Size = new System.Drawing.Size(75, 23);
            this.btnAddOperation.TabIndex = 2;
            this.btnAddOperation.Text = "Добавить";
            this.btnAddOperation.UseVisualStyleBackColor = true;
            this.btnAddOperation.Click += new System.EventHandler(this.btnAddOperation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Взаимоотношения с другими работниками";
            // 
            // btnAddRelationship
            // 
            this.btnAddRelationship.Location = new System.Drawing.Point(13, 332);
            this.btnAddRelationship.Name = "btnAddRelationship";
            this.btnAddRelationship.Size = new System.Drawing.Size(75, 23);
            this.btnAddRelationship.TabIndex = 4;
            this.btnAddRelationship.Text = "Добавить";
            this.btnAddRelationship.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(13, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Имя";
            // 
            // tbWorkerName
            // 
            this.tbWorkerName.Location = new System.Drawing.Point(59, 9);
            this.tbWorkerName.Name = "tbWorkerName";
            this.tbWorkerName.Size = new System.Drawing.Size(486, 20);
            this.tbWorkerName.TabIndex = 6;
            // 
            // tbOperationId0
            // 
            this.tbOperationId0.Location = new System.Drawing.Point(7, 66);
            this.tbOperationId0.Name = "tbOperationId0";
            this.tbOperationId0.ReadOnly = true;
            this.tbOperationId0.Size = new System.Drawing.Size(46, 20);
            this.tbOperationId0.TabIndex = 13;
            this.tbOperationId0.Text = "0";
            // 
            // btnDelete0
            // 
            this.btnDelete0.Location = new System.Drawing.Point(179, 63);
            this.btnDelete0.Name = "btnDelete0";
            this.btnDelete0.Size = new System.Drawing.Size(75, 23);
            this.btnDelete0.TabIndex = 12;
            this.btnDelete0.Tag = "0";
            this.btnDelete0.Text = "Delete";
            this.btnDelete0.UseVisualStyleBackColor = true;
            // 
            // tbNext0
            // 
            this.tbNext0.Location = new System.Drawing.Point(127, 65);
            this.tbNext0.Name = "tbNext0";
            this.tbNext0.Size = new System.Drawing.Size(46, 20);
            this.tbNext0.TabIndex = 14;
            // 
            // numTime0
            // 
            this.numTime0.Location = new System.Drawing.Point(59, 66);
            this.numTime0.Name = "numTime0";
            this.numTime0.Size = new System.Drawing.Size(62, 20);
            this.numTime0.TabIndex = 15;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(619, 415);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(169, 23);
            this.btnDone.TabIndex = 16;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.numTime0);
            this.Controls.Add(this.tbNext0);
            this.Controls.Add(this.tbOperationId0);
            this.Controls.Add(this.btnDelete0);
            this.Controls.Add(this.tbWorkerName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAddRelationship);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddOperation);
            this.Controls.Add(this.lblOperations);
            this.Name = "WorkerForm";
            this.Text = "Worker";
            ((System.ComponentModel.ISupportInitialize)(this.numTime0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperations;
        private System.Windows.Forms.Button btnAddOperation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddRelationship;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbWorkerName;
        private System.Windows.Forms.TextBox tbOperationId0;
        private System.Windows.Forms.Button btnDelete0;
        private System.Windows.Forms.TextBox tbNext0;
        private System.Windows.Forms.NumericUpDown numTime0;
        private System.Windows.Forms.Button btnDone;
    }
}