using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamWork
{
    public partial class WorkerForm : Form
    {
        public Worker EditedWorker { get; set; }

        int currentOperation = 0;
        string timeTemplate = "numTime";
        string operationIdTemplate = "tbOperationId";
        string nextOperationTemplate = "tbNext";
        string deleteButtonTemplate = "btnDelete";
        public WorkerForm()
        {
            InitializeComponent();

            if (EditedWorker != null)
            {

            }
        }

        private void btnAddOperation_Click(object sender, EventArgs e)
        {
            currentOperation++;

            var tbId = new TextBox
            {
                Size = tbOperationId0.Size,

                Name = operationIdTemplate + currentOperation,
                Text = currentOperation.ToString(),
                ReadOnly = true,
                Tag = currentOperation,

                Location = new Point(tbOperationId0.Location.X, tbOperationId0.Location.Y + (tbOperationId0.Height + 3) * currentOperation)
            };
            this.Controls.Add(tbId);

            var numTime = new NumericUpDown
            {
                Size = numTime0.Size,

                Name = timeTemplate + currentOperation,
                Tag = currentOperation,
                Location = new Point(numTime0.Location.X, numTime0.Location.Y + (numTime0.Height + 3) * currentOperation)
            };

            this.Controls.Add(numTime);

            var nextOp = new TextBox
            {
                Size = tbNext0.Size,
                Name = nextOperationTemplate + currentOperation,
                Tag = currentOperation,
                Location = new Point(tbNext0.Location.X, tbNext0.Location.Y + (tbNext0.Height + 3) * currentOperation)
            };
            this.Controls.Add(nextOp);

            var deleteButton = new Button
            {
                Size = btnDelete0.Size,
                Text = "Delete",
                Tag = currentOperation,

                Name = deleteButtonTemplate + currentOperation,
                Location = new Point(btnDelete0.Location.X, btnDelete0.Location.Y + btnDelete0.Height * currentOperation)
            };

            deleteButton.Click += DeleteOperation;
            this.Controls.Add(deleteButton);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Worker newWorker = new Worker();

            for (int i = 0; i <= currentOperation; i++)
            {
                var num = (NumericUpDown)this.Controls.Find(timeTemplate + i, true)[0];
                Operation newOperation = new Operation()
                {
                    Name = this.Controls.Find(operationIdTemplate + i, true)[0].Text,
                    Time = (int)num.Value,
                    NextOperation = null
                };
                newWorker.OperationList.Add(newOperation);
            }

            EditedWorker = newWorker;

            for (int i = 0; i <= currentOperation; i++)
            {
                var currentOperName = this.Controls.Find(operationIdTemplate + i, true)[0].Text;
                var nextOperName = this.Controls.Find(nextOperationTemplate + i, true)[0].Text;

                if (nextOperName != String.Empty)
                {
                    if (EditedWorker.GetOperationByName(nextOperName) == null) throw new Exception("invalid operation name");
                    EditedWorker.GetOperationByName(currentOperName).NextOperation = EditedWorker.GetOperationByName(nextOperName);
                }
            }

            var workerName = this.Controls.Find("tbWorkerName", true)[0].Text;
            EditedWorker.Name = workerName;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void DeleteOperation(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var tag = button.Tag;

            var tb = this.Controls.Find(operationIdTemplate + tag, true);
            var num = this.Controls.Find(timeTemplate + tag, true);
            var tb2 = this.Controls.Find(nextOperationTemplate + tag, true);
            var btn = this.Controls.Find(deleteButtonTemplate + tag, true);

            if (EditedWorker != null)
            {
                EditedWorker.OperationList.Remove(EditedWorker.GetOperationByName(tb[0].Text));
            }

            this.Controls.Remove(tb[0]);
            this.Controls.Remove(tb2[0]);
            this.Controls.Remove(num[0]);
            this.Controls.Remove(btn[0]);
        }
    }
}
