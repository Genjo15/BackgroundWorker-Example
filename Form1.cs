using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace BackgroundWorker
{//test
    public partial class Form1 : Form
    {
        private System.ComponentModel.BackgroundWorker bgwCode;

        public Form1()
        {
            InitializeComponent();

            bgwCode = new System.ComponentModel.BackgroundWorker();

            bgwCode.WorkerReportsProgress = true;
            bgwCode.WorkerSupportsCancellation = true;

            bgwCode.DoWork += new DoWorkEventHandler(bgwCode_DoWork);
            bgwCode.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgwCode_RunWorkerCompleted);
            bgwCode.ProgressChanged += new ProgressChangedEventHandler(bgwCode_ProgressChanged);
        }

        private void bgwCode_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                lbResult.Text = "Une erreur est survenue ! Détail : " + e.Error.Message;
            }
            else if (e.Cancelled)
            {
                lbResult.Text = "Opération annulée !";
            }
            else
            {
                lbResult.Text = "Opération terminée ! Résultat : " + e.Result.ToString();
            }

            btnStartCancel.Text = "Démarrer";
            textBox.Enabled = true;
            pgbState.Value = 0;
        }

        private void bgwCode_DoWork(object sender, DoWorkEventArgs e)
        {
            System.ComponentModel.BackgroundWorker worker = sender as System.ComponentModel.BackgroundWorker;

            int value = (int)e.Argument;
            e.Result = Treatment((int)e.Argument, (int)e.Argument, worker, e);
        }

        private long Treatment(int nb, int max, System.ComponentModel.BackgroundWorker worker, DoWorkEventArgs e)
        {
            long result = 0;

            if (worker.CancellationPending)
            {
                e.Cancel = true;

            }

            else
            {
                int pourcent = (int)(((double)max - (double)nb) / (double)max * 100);
                worker.ReportProgress(pourcent);

                if (nb <= 1)
                {
                    result = 1;
                }
                else
                {
                    System.Threading.Thread.Sleep(100);
                    result = Treatment(nb - 1, max, worker, e) + 1;
                }
            }

            return result;

        }

        public void bgwCode_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgbState.Value = e.ProgressPercentage;
        }

        private void btnStartCancel_Click(object sender, EventArgs e)
        {
            if (btnStartCancel.Text.Equals("Démarrer"))
	        {
		        lbResult.Text = "Traitement en cours...";
		        btnStartCancel.Text = "Annuler";
		        textBox.Enabled = false;
                bgwCode.RunWorkerAsync(int.Parse(textBox.Text));
	        }
	        else
	        {
                bgwCode.CancelAsync();
                btnStartCancel.Text = "Démarrer";
                pgbState.Value = 0;
                textBox.Enabled = true;
	        }
        }
    }
}
