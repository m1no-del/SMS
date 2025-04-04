using Microsoft.EntityFrameworkCore.Diagnostics;
using SMS.App.Views.iViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.App
{
    public partial class ProgramView : Form, IProgramView
    {
        public ProgramView()
        {
            InitializeComponent();

        }


        public int ProgramId { get => Convert.ToInt16(txtBoxId.Text); set => txtBoxId.Text = value.ToString(); }

        public string ProgramName { get => txtBoxProgramName.Text.Trim(); set => txtBoxProgramName.Text = value; }

        public string Description { get => txtBoxDescription.Text.Trim(); set => txtBoxDescription.Text = value; }

        public void GetProgramList(BindingSource bindingSource)
        {
            dataGridViewProgramList.DataSource = bindingSource;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateEvent?.Invoke(this, EventArgs.Empty);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            ReadEvent?.Invoke(this, EventArgs.Empty);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateEvent?.Invoke(this, EventArgs.Empty);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteEvent?.Invoke(this, EventArgs.Empty);

        }

        public event EventHandler CreateEvent;
        public event EventHandler ReadEvent;
        public event EventHandler UpdateEvent;
        public event EventHandler DeleteEvent;

    }
}
