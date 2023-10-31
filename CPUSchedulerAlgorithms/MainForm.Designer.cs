using System.Windows.Forms;

namespace CPUSchedulerAlgorithms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addProcessButton = new System.Windows.Forms.Button();
            this.resetProcessesButton = new System.Windows.Forms.Button();
            this.processTimeTextLabel = new System.Windows.Forms.Label();
            this.averageRunTimeTextLabel = new System.Windows.Forms.Label();
            this.averageWaitTimeTextLabel = new System.Windows.Forms.Label();
            this.averageWaitTimeLabel = new System.Windows.Forms.Label();
            this.averageRunTimeLabel = new System.Windows.Forms.Label();
            this.processesDataGridView = new System.Windows.Forms.DataGridView();
            this.quantumTimeTextBox = new System.Windows.Forms.TextBox();
            this.quantumTimeTextLabel = new System.Windows.Forms.Label();
            this.algorithmComboBox = new System.Windows.Forms.ComboBox();
            this.algorithmTextLabel = new System.Windows.Forms.Label();
            this.processTimeTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.processesDataGridView)).BeginInit();
            this.SuspendLayout();
            //
            // addProcessButton
            //
            this.addProcessButton.Location = new System.Drawing.Point(544, 111);
            this.addProcessButton.Name = "addProcessButton";
            this.addProcessButton.Size = new System.Drawing.Size(145, 50);
            this.addProcessButton.TabIndex = 0;
            this.addProcessButton.Text = "Добавить процесс";
            this.addProcessButton.UseVisualStyleBackColor = true;
            this.addProcessButton.Click += new System.EventHandler(this.addProcessButton_Click);
            //
            // resetProcessesButton
            //
            this.resetProcessesButton.Location = new System.Drawing.Point(544, 167);
            this.resetProcessesButton.Name = "resetProcessesButton";
            this.resetProcessesButton.Size = new System.Drawing.Size(145, 50);
            this.resetProcessesButton.TabIndex = 1;
            this.resetProcessesButton.Text = "Сбросс процессов";
            this.resetProcessesButton.UseVisualStyleBackColor = true;
            this.resetProcessesButton.Click += new System.EventHandler(this.resetProcessesButton_Click);
            //
            // processTimeTextLabel
            //
            this.processTimeTextLabel.Location = new System.Drawing.Point(695, 82);
            this.processTimeTextLabel.Name = "processTimeTextLabel";
            this.processTimeTextLabel.Size = new System.Drawing.Size(93, 26);
            this.processTimeTextLabel.TabIndex = 2;
            this.processTimeTextLabel.Text = "Процессорное время\r\n";
            //
            // averageRunTimeTextLabel
            //
            this.averageRunTimeTextLabel.Location = new System.Drawing.Point(12, 333);
            this.averageRunTimeTextLabel.Name = "averageRunTimeTextLabel";
            this.averageRunTimeTextLabel.Size = new System.Drawing.Size(155, 16);
            this.averageRunTimeTextLabel.TabIndex = 5;
            this.averageRunTimeTextLabel.Text = "Среднее время выполнения:\r\n";
            //
            // averageWaitTimeTextLabel
            //
            this.averageWaitTimeTextLabel.Location = new System.Drawing.Point(12, 307);
            this.averageWaitTimeTextLabel.Name = "averageWaitTimeTextLabel";
            this.averageWaitTimeTextLabel.Size = new System.Drawing.Size(155, 16);
            this.averageWaitTimeTextLabel.TabIndex = 6;
            this.averageWaitTimeTextLabel.Text = "Среднее время ожидания:\r\n";
            //
            // averageWaitTimeLabel
            //
            this.averageWaitTimeLabel.Location = new System.Drawing.Point(173, 307);
            this.averageWaitTimeLabel.Name = "averageWaitTimeLabel";
            this.averageWaitTimeLabel.Size = new System.Drawing.Size(39, 16);
            this.averageWaitTimeLabel.TabIndex = 7;
            //
            // averageRunTimeLabel
            //
            this.averageRunTimeLabel.Location = new System.Drawing.Point(173, 333);
            this.averageRunTimeLabel.Name = "averageRunTimeLabel";
            this.averageRunTimeLabel.Size = new System.Drawing.Size(39, 16);
            this.averageRunTimeLabel.TabIndex = 8;
            //
            // processesDataGridView
            //
            this.processesDataGridView.AllowUserToAddRows = false;
            this.processesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.processesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processesDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.processesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.processesDataGridView.Name = "processesDataGridView";
            this.processesDataGridView.ReadOnly = true;
            this.processesDataGridView.Size = new System.Drawing.Size(526, 292);
            this.processesDataGridView.TabIndex = 10;
            //
            // quantumTimeTextBox
            //
            this.quantumTimeTextBox.Location = new System.Drawing.Point(695, 254);
            this.quantumTimeTextBox.Multiline = true;
            this.quantumTimeTextBox.Name = "quantumTimeTextBox";
            this.quantumTimeTextBox.Size = new System.Drawing.Size(93, 50);
            this.quantumTimeTextBox.TabIndex = 11;
            this.quantumTimeTextBox.Visible = false;
            this.quantumTimeTextBox.TextChanged += new System.EventHandler(this.quantumTimeTextBox_TextChanged);
            //
            // quantumTimeTextLabel
            //
            this.quantumTimeTextLabel.Location = new System.Drawing.Point(544, 257);
            this.quantumTimeTextLabel.Name = "quantumTimeTextLabel";
            this.quantumTimeTextLabel.Size = new System.Drawing.Size(145, 47);
            this.quantumTimeTextLabel.TabIndex = 12;
            this.quantumTimeTextLabel.Text = "Квант времени на процесс";
            this.quantumTimeTextLabel.Visible = false;
            //
            // algorithmComboBox
            //
            this.algorithmComboBox.FormattingEnabled = true;
            this.algorithmComboBox.Items.AddRange(new object[] { "FCFS", "RR", "SJF", "RR SJF" });
            this.algorithmComboBox.Location = new System.Drawing.Point(660, 12);
            this.algorithmComboBox.Name = "algorithmComboBox";
            this.algorithmComboBox.Size = new System.Drawing.Size(128, 21);
            this.algorithmComboBox.TabIndex = 13;
            this.algorithmComboBox.Text = "FCSF";
            this.algorithmComboBox.SelectedIndexChanged += new System.EventHandler(this.algorithmComboBox_SelectedIndexChanged);
            //
            // algorithmTextLabel
            //
            this.algorithmTextLabel.Location = new System.Drawing.Point(544, 12);
            this.algorithmTextLabel.Name = "algorithmTextLabel";
            this.algorithmTextLabel.Size = new System.Drawing.Size(110, 21);
            this.algorithmTextLabel.TabIndex = 14;
            this.algorithmTextLabel.Text = "Алгоритм";
            //
            // processTimeTextBox
            //
            this.processTimeTextBox.Location = new System.Drawing.Point(695, 111);
            this.processTimeTextBox.Multiline = true;
            this.processTimeTextBox.Name = "processTimeTextBox";
            this.processTimeTextBox.Size = new System.Drawing.Size(93, 50);
            this.processTimeTextBox.TabIndex = 9;
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 358);
            this.Controls.Add(this.algorithmTextLabel);
            this.Controls.Add(this.algorithmComboBox);
            this.Controls.Add(this.quantumTimeTextLabel);
            this.Controls.Add(this.quantumTimeTextBox);
            this.Controls.Add(this.processesDataGridView);
            this.Controls.Add(this.processTimeTextBox);
            this.Controls.Add(this.averageRunTimeLabel);
            this.Controls.Add(this.averageWaitTimeLabel);
            this.Controls.Add(this.averageWaitTimeTextLabel);
            this.Controls.Add(this.averageRunTimeTextLabel);
            this.Controls.Add(this.processTimeTextLabel);
            this.Controls.Add(this.resetProcessesButton);
            this.Controls.Add(this.addProcessButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.processesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox processTimeTextBox;

        private System.Windows.Forms.Label algorithmTextLabel;
        private System.Windows.Forms.ComboBox algorithmComboBox;

        private System.Windows.Forms.Label quantumTimeTextLabel;
        private System.Windows.Forms.TextBox quantumTimeTextBox;

        private System.Windows.Forms.DataGridView processesDataGridView;

        private System.Windows.Forms.Label averageWaitTimeLabel;
        private System.Windows.Forms.Label averageRunTimeLabel;

        private System.Windows.Forms.Label averageRunTimeTextLabel;
        private System.Windows.Forms.Label averageWaitTimeTextLabel;

        private System.Windows.Forms.Label processTimeTextLabel;

        private System.Windows.Forms.Button resetProcessesButton;

        private System.Windows.Forms.Button addProcessButton;

        #endregion
    }
}