using StretchApp.src.controllers;
using StretchApp.src.models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StretchApp
{
    public partial class AddTaskView : UserControl
    {
        public event Action? TaskAdded;
        public event Action? CancelRequested;

        private string selectedPriority = "";
        private string selectedStatus = "";

        private readonly TaskController _controller = new();

        public AddTaskView()
        {
            InitializeComponent();
            WireEvents();

            dateTimePicker1.MinDate = DateTime.Today;
        }

        #region Public Task Data

        public string TaskTitle => textBox2.Text.Trim();
        public string Notes => textBox1.Text.Trim();
        public DateTime Deadline => dateTimePicker1.Value;
        public string Priority => selectedPriority;
        public string Status => selectedStatus;

        #endregion

        #region Event Wiring

        private void WireEvents()
        {
            // Cancel / Add
            button1.Click += ButtonCancel_Click;
            button2.Click += ButtonAddTask_Click;

            // Priority Buttons
            button8.Click += (_, _) => SelectPriority("Low");
            button7.Click += (_, _) => SelectPriority("Medium");
            button6.Click += (_, _) => SelectPriority("High");

            // Status Buttons
            button3.Click += (_, _) => SelectStatus("Not Started");
            button4.Click += (_, _) => SelectStatus("Ongoing");
            button5.Click += (_, _) => SelectStatus("Completed");
        }

        #endregion

        #region Button Logic

        private void ButtonCancel_Click(object? sender, EventArgs e)
        {
            CancelRequested?.Invoke();
        }

        private void ButtonAddTask_Click(object? sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            _controller.AddTask(new TaskModel
            {
                Title = TaskTitle,
                Notes = Notes,
                Priority = Priority,
                Status = Status,
                Deadline = Deadline
            });

            TaskAdded?.Invoke();
        }

        #endregion

        #region Validation

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(TaskTitle))
            {
                MessageBox.Show("Task Title is required.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(selectedPriority))
            {
                MessageBox.Show("Please select a Priority.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(selectedStatus))
            {
                MessageBox.Show("Please select a Status.");
                return false;
            }

            return true;
        }

        #endregion

        #region Priority Selection

        private void SelectPriority(string priority)
        {
            selectedPriority = priority;

            ResetPriorityButtons();

            switch (priority)
            {
                case "Low":
                    HighlightButton(button8);
                    break;

                case "Medium":
                    HighlightButton(button7);
                    break;

                case "High":
                    HighlightButton(button6);
                    break;
            }
        }

        private void ResetPriorityButtons()
        {
            ResetButtonStyle(button8);
            ResetButtonStyle(button7);
            ResetButtonStyle(button6);
        }

        #endregion

        #region Status Selection

        private void SelectStatus(string status)
        {
            selectedStatus = status;

            ResetStatusButtons();

            switch (status)
            {
                case "Not Started":
                    HighlightButton(button3);
                    break;

                case "Ongoing":
                    HighlightButton(button4);
                    break;

                case "Completed":
                    HighlightButton(button5);
                    break;
            }
        }

        private void ResetStatusButtons()
        {
            ResetButtonStyle(button3);
            ResetButtonStyle(button4);
            ResetButtonStyle(button5);
        }

        #endregion

        #region Styling Helpers

        private void HighlightButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(60, 120, 220);
            btn.ForeColor = Color.White;
        }

        private void ResetButtonStyle(Button btn)
        {
            btn.BackColor = SystemColors.Control;
            btn.ForeColor = Color.Black;
        }

        #endregion
    }
}