﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAISSchool
{
    public partial class FormStudents : Form
    {
        public FormStudents()
        {
            InitializeComponent();
        }

        private void FormStudents_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Оценки". При необходимости она может быть перемещена или удалена.
            this.оценкиTableAdapter.Fill(this.schoolDataSet.Оценки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Ученики". При необходимости она может быть перемещена или удалена.
            this.ученикиTableAdapter.Fill(this.schoolDataSet.Ученики);

        }

        private void ученикиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ученикиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolDataSet);

        }

        private void классLabel_Click(object sender, EventArgs e)
        {

        }

        private void классTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void код_предмета_1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void оценка_2Label_Click(object sender, EventArgs e)
        {

        }

        private void оценка_3Label_Click(object sender, EventArgs e)
        {

        }

        private void оценка_1Label_Click(object sender, EventArgs e)
        {

        }
    }
}
