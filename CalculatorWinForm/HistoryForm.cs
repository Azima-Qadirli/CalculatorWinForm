using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinForm
{
    public partial class HistoryForm : Form
    {
        private const string NoHistoryMessage = "There is no history yet";
        private List<string> _history;
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listBoxHistory.Items.Clear();
            _history.Clear();
            UpdateHistory();
        }
        public void SetHistory(List<string> history)
        {
            _history = history ?? new List<string>();
            UpdateHistory();

        }
        private void UpdateHistory()
        {
            listBoxHistory.Items.Clear();

            if (_history.Count == 0)
            {
                listBoxHistory.Items.Add(NoHistoryMessage);
            }
            else
            {
                foreach (var item in _history)
                {
                    listBoxHistory.Items.Add(item);
                }
            }
        }
    }
}
