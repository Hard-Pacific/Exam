using System.ComponentModel;

namespace Exam2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnClickMe_Click(object sender, EventArgs e)
        {
            this.backgroundWorker.RunWorkerAsync();
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var backgroundWorker = sender as BackgroundWorker;
            for (int j = 0; j < 20; j++)
            {
                System.Threading.Thread.Sleep(50);
                backgroundWorker.ReportProgress((j * 100) / 20);
            }
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.PerformStep();
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.btnCloseForm.Visible = true;
        }

        private void BtnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}