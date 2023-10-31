using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace CPUSchedulerAlgorithms
{
    public partial class MainForm : Form
    {
        private readonly List<int> _processList = new List<int>();
        private string _selectedAlgorithm = "FCFS";

        public MainForm()
        {
            InitializeComponent();
        }

        #region Utilities

        private int? GetQuantumTime()
        {
            var quantumTime = int.MaxValue;
            if (_selectedAlgorithm == "FCFS" || _selectedAlgorithm == "SJF") return quantumTime;
            if (int.TryParse(quantumTimeTextBox.Text, out quantumTime)) return quantumTime;

            quantumTimeTextBox.Text = "";
            return null;
        }

        private void ClearUi()
        {
            processesDataGridView.Rows.Clear();
            processesDataGridView.Columns.Clear();
            averageWaitTimeLabel.Text = "";
            averageRunTimeLabel.Text = "";
        }

        private void CreateDataGrid()
        {
            for (var tickIndex = 0; tickIndex < _processList.Sum(); tickIndex++)
            {
                var column = new DataGridViewColumn();
                column.CellTemplate = new DataGridViewTextBoxCell();
                column.Name = (tickIndex + 1).ToString();

                processesDataGridView.Columns.Add(column);
            }

            for (var processIndex = 0; processIndex < _processList.Count; processIndex++)
            {
                var row = new DataGridViewRow();
                row.HeaderCell.Value = "Процесс " + (processIndex + 1);

                processesDataGridView.Rows.Add(row);
            }
        }

        #endregion

        private void algorithmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedAlgorithm = algorithmComboBox.Text;

            if (_selectedAlgorithm == "FCFS" || _selectedAlgorithm == "SJF")
            {
                quantumTimeTextBox.Hide();
                quantumTimeTextLabel.Hide();
            }
            else
            {
                quantumTimeTextBox.Show();
                quantumTimeTextLabel.Show();
            }

            RunSimulation();
        }

        private void addProcessButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(processTimeTextBox.Text, out var cpuTime))
            {
                MessageBox.Show("Значение не является числом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                processTimeTextBox.Text = "";

                return;
            }

            _processList.Add(cpuTime);
            processTimeTextBox.Text = "";

            RunSimulation();
        }

        private void resetProcessesButton_Click(object sender, EventArgs e)
        {
            _processList.Clear();
            ClearUi();
        }

        private void quantumTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            RunSimulation();
        }

        private void RunSimulation()
        {
            if (_processList.Count == 0) return;

            var quantumTime = GetQuantumTime();
            if (quantumTime == null) return;

            ClearUi();
            CreateDataGrid();

            var processKeyValuePairs = _processList.Select((ticksRemaining, index) => new KeyValuePair<int, int>(index, ticksRemaining)).ToList();
            if (_selectedAlgorithm == "SJF" || _selectedAlgorithm == "RR SJF") processKeyValuePairs.Sort((x, y) => x.Value.CompareTo(y.Value));

            var processQueue = new Queue<KeyValuePair<int, int>>(processKeyValuePairs);

            var waitTime = 0;
            var runTime = 0;

            var currentTickIndex = 0;
            while (processQueue.Count > 0)
            {
                var currentProcess = processQueue.Dequeue();
                var currentProcessExecutionTime = Math.Min(quantumTime.Value, currentProcess.Value);

                waitTime += currentProcessExecutionTime * processQueue.Count;
                runTime += currentProcessExecutionTime + currentTickIndex;

                for (var tickIndex = currentTickIndex; tickIndex < currentTickIndex + currentProcessExecutionTime; tickIndex++)
                {
                    processesDataGridView[tickIndex, currentProcess.Key].Value = "И";

                    foreach (var process in processQueue) processesDataGridView[tickIndex, process.Key].Value = "Г";
                }

                if (currentProcess.Value - currentProcessExecutionTime > 0)
                    processQueue.Enqueue(new KeyValuePair<int, int>(currentProcess.Key, currentProcess.Value - currentProcessExecutionTime));

                currentTickIndex += currentProcessExecutionTime;
            }

            averageWaitTimeLabel.Text = ((double)waitTime / _processList.Count).ToString(CultureInfo.InvariantCulture);
            averageRunTimeLabel.Text = ((double)runTime / _processList.Count).ToString(CultureInfo.InvariantCulture);
        }
    }
}