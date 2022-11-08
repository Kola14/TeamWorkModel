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
    public partial class MainForm : Form
    {
        int currentWorker = 0;
        string editButtonTemplate = "btnEditWorker";
        string deleteButtonTemplate = "btnDeleteWorker";

        Simulation currentSimulation;
        public MainForm()
        {
            InitializeComponent();
            btnEditWorker0.Click += EditWorker;
            btnDeleteWorker0.Click += DeleteWorker;
            currentSimulation = new Simulation();
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            currentWorker++;

            var tbId = new TextBox
            {
                Size = tbWorkerId0.Size,

                Name = "tbWorkerId" + currentWorker,
                Text = currentWorker.ToString(),
                ReadOnly = true,
                Tag = currentWorker,

                Location = new Point(tbWorkerId0.Location.X, tbWorkerId0.Location.Y + (tbWorkerId0.Height + 3) * currentWorker)
            };
            this.Controls.Add(tbId);


            var editButton = new Button
            {
                Size = btnEditWorker0.Size,
                Text = "Edit",
                Tag = currentWorker,

                Name = editButtonTemplate + currentWorker,
                Location = new Point(btnEditWorker0.Location.X, btnEditWorker0.Location.Y + btnEditWorker0.Height * currentWorker)
            };

            editButton.Click += EditWorker;
            this.Controls.Add(editButton);

            var deleteButton = new Button
            {
                Size = btnEditWorker0.Size,
                Text = "Delete",
                Tag = currentWorker,

                Name = deleteButtonTemplate + currentWorker,
                Location = new Point(btnDeleteWorker0.Location.X, btnDeleteWorker0.Location.Y + btnDeleteWorker0.Height * currentWorker)
            };

            deleteButton.Click += DeleteWorker;
            this.Controls.Add(deleteButton);
        }
        private void EditWorker(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var tag = button.Tag;
            var tb = this.Controls.Find("tbWorkerId" + tag, true);
            var id = Int32.Parse(tb[0]?.Text);

            var workerForm = new WorkerForm();
            if (currentSimulation.WorkerList != null)
            {
                workerForm.EditedWorker = currentSimulation.GetWorkerById(id);
            }
 
            var result = workerForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (currentSimulation.GetWorkerById(id) != null)
                {
                    currentSimulation.GetWorkerById(id).Name = workerForm.EditedWorker.Name;
                    currentSimulation.GetWorkerById(id).OperationList = workerForm.EditedWorker.OperationList;
                }
                else
                {
                    currentSimulation.WorkerList.Add(workerForm.EditedWorker);
                }
            }
        }

        private void DeleteWorker(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var tag = button.Tag;

            var tb = this.Controls.Find("tbWorkerId" + tag, true);
            var btn1 = this.Controls.Find(editButtonTemplate + tag, true);
            var btn2 = this.Controls.Find(deleteButtonTemplate + tag, true);

            this.Controls.Remove(tb[0]);
            this.Controls.Remove(btn1[0]);
            this.Controls.Remove(btn2[0]);
        }
    }
}
