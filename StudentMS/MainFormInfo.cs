﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMS
{
    public partial class MainFormInfo : Form
    {
        public MainFormInfo()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            Info.FormShow show = new Info.FormShow();
            this.Hide();
            show.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Info.FormAdd add = new Info.FormAdd();
            this.Hide();
            add.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Info.FormSearch search = new Info.FormSearch();
            this.Hide();
            search.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Info.FormModify update = new Info.FormModify();
            this.Hide();
            update.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = "現在時間是：" + DateTime.Now.ToString();
        }

        private void MainFormInfo_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainFormInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("真的要退出嗎？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No;
        }

        private void buttonStudentMS_Click(object sender, EventArgs e)
        {
            StudentMainForm main = new StudentMainForm();
            this.Hide();
            main.Show();
        }
    }
}