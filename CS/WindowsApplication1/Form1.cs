using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.CreateMySplitControls();
        }

        private void CreateMySplitControls() {
            MemoEdit memoEdit1 = new MemoEdit();
            memoEdit1.Text = "MemoEdit1";
            MemoEdit memoEdit2 = new MemoEdit();
            memoEdit2.Text = "MemoEdit2";
            MemoEdit memoEdit3 = new MemoEdit();
            memoEdit3.Text = "MemoEdit3";
            SplitterControl splitter1 = new SplitterControl();
            SplitterControl splitter2 = new SplitterControl();
            memoEdit1.Dock = DockStyle.Left;
            splitter1.Dock = DockStyle.Left;
            memoEdit2.Dock = DockStyle.Fill;
            splitter2.Dock = DockStyle.Right;
            memoEdit3.Dock = DockStyle.Right;
            this.Controls.AddRange(new Control[] { memoEdit2, splitter1, memoEdit1, splitter2, memoEdit3 });
        }

    }
}