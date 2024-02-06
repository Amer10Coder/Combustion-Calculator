using System.Resources;

namespace Combustion_Calculator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Fuel_C = new Label();
            Fuel_H2 = new Label();
            Fuel_S = new Label();
            Fuel_CO = new Label();
            Fuel_CH4 = new Label();
            Fuel_C2H2 = new Label();
            Fuel_C2H4 = new Label();
            Fuel_C2H6 = new Label();
            Fuel_C3H8 = new Label();
            Fuel_C4H10 = new Label();
            Fuel_C5H12 = new Label();
            Fuel_O2 = new Label();
            Input_C = new TextBox();
            Input_H2 = new TextBox();
            Input_S = new TextBox();
            Input_CO = new TextBox();
            Input_CH4 = new TextBox();
            Input_C2H2 = new TextBox();
            Input_C2H4 = new TextBox();
            Input_C2H6 = new TextBox();
            Input_C3H8 = new TextBox();
            Input_C4H10 = new TextBox();
            Input_C5H12 = new TextBox();
            Input_O2 = new TextBox();
            ResultPanel = new Panel();
            Quantity_O2req = new Label();
            Output_O2 = new TextBox();
            Fuel_O2req = new Label();
            ResultPanelText = new Label();
            Quantity_C = new Label();
            Quantity_H2 = new Label();
            Quantity_S = new Label();
            Quantity_CO = new Label();
            Quantity_CH4 = new Label();
            Quantity_C2H2 = new Label();
            Quantity_C2H4 = new Label();
            Quantity_C2H6 = new Label();
            Quantity_C3H8 = new Label();
            Quantity_C4H10 = new Label();
            Quantity_C5H12 = new Label();
            MenuMainForm = new MenuStrip();
            FileToolStripMenuItem = new ToolStripMenuItem();
            ResetToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            AboutToolStripMenuItem = new ToolStripMenuItem();
            CleanButton = new Button();
            toolTip = new ToolTip(components);
            Quantity_O2 = new Label();
            DevInfo = new LinkLabel();
            ResultButton = new Button();
            ResultPanel.SuspendLayout();
            MenuMainForm.SuspendLayout();
            SuspendLayout();
            // 
            // Fuel_C
            // 
            Fuel_C.FlatStyle = FlatStyle.Flat;
            Fuel_C.Font = new Font("Simple Bold Jut Out", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Fuel_C.ForeColor = Color.FromArgb(64, 0, 64);
            Fuel_C.Location = new Point(34, 51);
            Fuel_C.Name = "Fuel_C";
            Fuel_C.Size = new Size(86, 33);
            Fuel_C.TabIndex = 13;
            Fuel_C.Text = "C";
            Fuel_C.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Fuel_H2
            // 
            Fuel_H2.FlatStyle = FlatStyle.Flat;
            Fuel_H2.Font = new Font("Simple Bold Jut Out", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Fuel_H2.ForeColor = Color.FromArgb(64, 0, 64);
            Fuel_H2.Location = new Point(34, 102);
            Fuel_H2.Name = "Fuel_H2";
            Fuel_H2.Size = new Size(86, 33);
            Fuel_H2.TabIndex = 14;
            Fuel_H2.Text = "H2";
            Fuel_H2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Fuel_S
            // 
            Fuel_S.FlatStyle = FlatStyle.Flat;
            Fuel_S.Font = new Font("Simple Bold Jut Out", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Fuel_S.ForeColor = Color.FromArgb(64, 0, 64);
            Fuel_S.Location = new Point(34, 153);
            Fuel_S.Name = "Fuel_S";
            Fuel_S.Size = new Size(86, 33);
            Fuel_S.TabIndex = 15;
            Fuel_S.Text = "S";
            Fuel_S.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Fuel_CO
            // 
            Fuel_CO.FlatStyle = FlatStyle.Flat;
            Fuel_CO.Font = new Font("Simple Bold Jut Out", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Fuel_CO.ForeColor = Color.FromArgb(64, 0, 64);
            Fuel_CO.Location = new Point(34, 204);
            Fuel_CO.Name = "Fuel_CO";
            Fuel_CO.Size = new Size(86, 33);
            Fuel_CO.TabIndex = 16;
            Fuel_CO.Text = "CO";
            Fuel_CO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Fuel_CH4
            // 
            Fuel_CH4.FlatStyle = FlatStyle.Flat;
            Fuel_CH4.Font = new Font("Simple Bold Jut Out", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Fuel_CH4.ForeColor = Color.FromArgb(64, 0, 64);
            Fuel_CH4.Location = new Point(34, 255);
            Fuel_CH4.Name = "Fuel_CH4";
            Fuel_CH4.Size = new Size(86, 33);
            Fuel_CH4.TabIndex = 17;
            Fuel_CH4.Text = "CH4";
            Fuel_CH4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Fuel_C2H2
            // 
            Fuel_C2H2.FlatStyle = FlatStyle.Flat;
            Fuel_C2H2.Font = new Font("Simple Bold Jut Out", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Fuel_C2H2.ForeColor = Color.FromArgb(64, 0, 64);
            Fuel_C2H2.Location = new Point(34, 306);
            Fuel_C2H2.Name = "Fuel_C2H2";
            Fuel_C2H2.Size = new Size(86, 33);
            Fuel_C2H2.TabIndex = 18;
            Fuel_C2H2.Text = "C2H2";
            Fuel_C2H2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Fuel_C2H4
            // 
            Fuel_C2H4.FlatStyle = FlatStyle.Flat;
            Fuel_C2H4.Font = new Font("Simple Bold Jut Out", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Fuel_C2H4.ForeColor = Color.FromArgb(64, 0, 64);
            Fuel_C2H4.Location = new Point(34, 357);
            Fuel_C2H4.Name = "Fuel_C2H4";
            Fuel_C2H4.Size = new Size(86, 33);
            Fuel_C2H4.TabIndex = 19;
            Fuel_C2H4.Text = "C2H4";
            Fuel_C2H4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Fuel_C2H6
            // 
            Fuel_C2H6.FlatStyle = FlatStyle.Flat;
            Fuel_C2H6.Font = new Font("Simple Bold Jut Out", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Fuel_C2H6.ForeColor = Color.FromArgb(64, 0, 64);
            Fuel_C2H6.Location = new Point(34, 408);
            Fuel_C2H6.Name = "Fuel_C2H6";
            Fuel_C2H6.Size = new Size(86, 33);
            Fuel_C2H6.TabIndex = 20;
            Fuel_C2H6.Text = "C2H6";
            Fuel_C2H6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Fuel_C3H8
            // 
            Fuel_C3H8.FlatStyle = FlatStyle.Flat;
            Fuel_C3H8.Font = new Font("Simple Bold Jut Out", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Fuel_C3H8.ForeColor = Color.FromArgb(64, 0, 64);
            Fuel_C3H8.Location = new Point(34, 459);
            Fuel_C3H8.Name = "Fuel_C3H8";
            Fuel_C3H8.Size = new Size(86, 33);
            Fuel_C3H8.TabIndex = 21;
            Fuel_C3H8.Text = "C3H8";
            Fuel_C3H8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Fuel_C4H10
            // 
            Fuel_C4H10.FlatStyle = FlatStyle.Flat;
            Fuel_C4H10.Font = new Font("Simple Bold Jut Out", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Fuel_C4H10.ForeColor = Color.FromArgb(64, 0, 64);
            Fuel_C4H10.Location = new Point(34, 510);
            Fuel_C4H10.Name = "Fuel_C4H10";
            Fuel_C4H10.Size = new Size(86, 33);
            Fuel_C4H10.TabIndex = 22;
            Fuel_C4H10.Text = "C4H10";
            Fuel_C4H10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Fuel_C5H12
            // 
            Fuel_C5H12.FlatStyle = FlatStyle.Flat;
            Fuel_C5H12.Font = new Font("Simple Bold Jut Out", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Fuel_C5H12.ForeColor = Color.FromArgb(64, 0, 64);
            Fuel_C5H12.Location = new Point(34, 561);
            Fuel_C5H12.Name = "Fuel_C5H12";
            Fuel_C5H12.Size = new Size(86, 33);
            Fuel_C5H12.TabIndex = 23;
            Fuel_C5H12.Text = "C5H12";
            Fuel_C5H12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Fuel_O2
            // 
            Fuel_O2.FlatStyle = FlatStyle.Flat;
            Fuel_O2.Font = new Font("Segoe UI Symbol", 8F, FontStyle.Bold, GraphicsUnit.Point);
            Fuel_O2.ForeColor = Color.FromArgb(0, 0, 64);
            Fuel_O2.Location = new Point(325, 61);
            Fuel_O2.Name = "Fuel_O2";
            Fuel_O2.Size = new Size(97, 34);
            Fuel_O2.TabIndex = 24;
            Fuel_O2.Text = "O2 (if any)";
            Fuel_O2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Input_C
            // 
            Input_C.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Input_C.Location = new Point(126, 51);
            Input_C.Name = "Input_C";
            Input_C.PlaceholderText = "not exist";
            Input_C.Size = new Size(129, 34);
            Input_C.TabIndex = 0;
            Input_C.Enter += Inputs_All_Enter;
            Input_C.KeyDown += Inputs_All_KeyDown;
            Input_C.KeyPress += Inputs_All_KeyPress;
            Input_C.Leave += Inputs_All_Leave;
            // 
            // Input_H2
            // 
            Input_H2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Input_H2.Location = new Point(126, 102);
            Input_H2.Name = "Input_H2";
            Input_H2.PlaceholderText = "not exist";
            Input_H2.Size = new Size(129, 34);
            Input_H2.TabIndex = 1;
            Input_H2.Enter += Inputs_All_Enter;
            Input_H2.KeyDown += Inputs_All_KeyDown;
            Input_H2.KeyPress += Inputs_All_KeyPress;
            Input_H2.Leave += Inputs_All_Leave;
            // 
            // Input_S
            // 
            Input_S.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Input_S.Location = new Point(126, 153);
            Input_S.Name = "Input_S";
            Input_S.PlaceholderText = "not exist";
            Input_S.Size = new Size(129, 34);
            Input_S.TabIndex = 2;
            Input_S.Enter += Inputs_All_Enter;
            Input_S.KeyDown += Inputs_All_KeyDown;
            Input_S.KeyPress += Inputs_All_KeyPress;
            Input_S.Leave += Inputs_All_Leave;
            // 
            // Input_CO
            // 
            Input_CO.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Input_CO.Location = new Point(126, 204);
            Input_CO.Name = "Input_CO";
            Input_CO.PlaceholderText = "not exist";
            Input_CO.Size = new Size(129, 34);
            Input_CO.TabIndex = 3;
            Input_CO.Enter += Inputs_All_Enter;
            Input_CO.KeyDown += Inputs_All_KeyDown;
            Input_CO.KeyPress += Inputs_All_KeyPress;
            Input_CO.Leave += Inputs_All_Leave;
            // 
            // Input_CH4
            // 
            Input_CH4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Input_CH4.Location = new Point(126, 255);
            Input_CH4.Name = "Input_CH4";
            Input_CH4.PlaceholderText = "not exist";
            Input_CH4.Size = new Size(129, 34);
            Input_CH4.TabIndex = 4;
            Input_CH4.Enter += Inputs_All_Enter;
            Input_CH4.KeyDown += Inputs_All_KeyDown;
            Input_CH4.KeyPress += Inputs_All_KeyPress;
            Input_CH4.Leave += Inputs_All_Leave;
            // 
            // Input_C2H2
            // 
            Input_C2H2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Input_C2H2.Location = new Point(126, 306);
            Input_C2H2.Name = "Input_C2H2";
            Input_C2H2.PlaceholderText = "not exist";
            Input_C2H2.Size = new Size(129, 34);
            Input_C2H2.TabIndex = 5;
            Input_C2H2.Enter += Inputs_All_Enter;
            Input_C2H2.KeyDown += Inputs_All_KeyDown;
            Input_C2H2.KeyPress += Inputs_All_KeyPress;
            Input_C2H2.Leave += Inputs_All_Leave;
            // 
            // Input_C2H4
            // 
            Input_C2H4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Input_C2H4.Location = new Point(126, 357);
            Input_C2H4.Name = "Input_C2H4";
            Input_C2H4.PlaceholderText = "not exist";
            Input_C2H4.Size = new Size(129, 34);
            Input_C2H4.TabIndex = 6;
            Input_C2H4.Enter += Inputs_All_Enter;
            Input_C2H4.KeyDown += Inputs_All_KeyDown;
            Input_C2H4.KeyPress += Inputs_All_KeyPress;
            Input_C2H4.Leave += Inputs_All_Leave;
            // 
            // Input_C2H6
            // 
            Input_C2H6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Input_C2H6.Location = new Point(126, 408);
            Input_C2H6.Name = "Input_C2H6";
            Input_C2H6.PlaceholderText = "not exist";
            Input_C2H6.Size = new Size(129, 34);
            Input_C2H6.TabIndex = 7;
            Input_C2H6.Enter += Inputs_All_Enter;
            Input_C2H6.KeyDown += Inputs_All_KeyDown;
            Input_C2H6.KeyPress += Inputs_All_KeyPress;
            Input_C2H6.Leave += Inputs_All_Leave;
            // 
            // Input_C3H8
            // 
            Input_C3H8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Input_C3H8.Location = new Point(126, 459);
            Input_C3H8.Name = "Input_C3H8";
            Input_C3H8.PlaceholderText = "not exist";
            Input_C3H8.Size = new Size(129, 34);
            Input_C3H8.TabIndex = 8;
            Input_C3H8.Enter += Inputs_All_Enter;
            Input_C3H8.KeyDown += Inputs_All_KeyDown;
            Input_C3H8.KeyPress += Inputs_All_KeyPress;
            Input_C3H8.Leave += Inputs_All_Leave;
            // 
            // Input_C4H10
            // 
            Input_C4H10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Input_C4H10.Location = new Point(126, 510);
            Input_C4H10.Name = "Input_C4H10";
            Input_C4H10.PlaceholderText = "not exist";
            Input_C4H10.Size = new Size(129, 34);
            Input_C4H10.TabIndex = 9;
            Input_C4H10.Enter += Inputs_All_Enter;
            Input_C4H10.KeyDown += Inputs_All_KeyDown;
            Input_C4H10.KeyPress += Inputs_All_KeyPress;
            Input_C4H10.Leave += Inputs_All_Leave;
            // 
            // Input_C5H12
            // 
            Input_C5H12.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Input_C5H12.Location = new Point(126, 561);
            Input_C5H12.Name = "Input_C5H12";
            Input_C5H12.PlaceholderText = "not exist";
            Input_C5H12.Size = new Size(129, 34);
            Input_C5H12.TabIndex = 10;
            Input_C5H12.Enter += Inputs_All_Enter;
            Input_C5H12.KeyDown += Inputs_All_KeyDown;
            Input_C5H12.KeyPress += Inputs_All_KeyPress;
            Input_C5H12.Leave += Inputs_All_Leave;
            // 
            // Input_O2
            // 
            Input_O2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Input_O2.Location = new Point(325, 98);
            Input_O2.Name = "Input_O2";
            Input_O2.PlaceholderText = "not exist";
            Input_O2.Size = new Size(129, 34);
            Input_O2.TabIndex = 11;
            Input_O2.Enter += Inputs_All_Enter;
            Input_O2.KeyDown += Inputs_All_KeyDown;
            Input_O2.KeyPress += Inputs_All_KeyPress;
            Input_O2.Leave += Inputs_All_Leave;
            // 
            // ResultPanel
            // 
            ResultPanel.BackColor = Color.Azure;
            ResultPanel.BorderStyle = BorderStyle.Fixed3D;
            ResultPanel.Controls.Add(Quantity_O2req);
            ResultPanel.Controls.Add(Output_O2);
            ResultPanel.Controls.Add(Fuel_O2req);
            ResultPanel.Location = new Point(326, 238);
            ResultPanel.Name = "ResultPanel";
            ResultPanel.Size = new Size(273, 148);
            ResultPanel.TabIndex = 26;
            // 
            // Quantity_O2req
            // 
            Quantity_O2req.AutoSize = true;
            Quantity_O2req.FlatStyle = FlatStyle.Flat;
            Quantity_O2req.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Quantity_O2req.ForeColor = Color.FromArgb(60, 40, 60);
            Quantity_O2req.Location = new Point(210, 12);
            Quantity_O2req.Name = "Quantity_O2req";
            Quantity_O2req.Size = new Size(36, 26);
            Quantity_O2req.TabIndex = 28;
            Quantity_O2req.Text = "Kg";
            // 
            // Output_O2
            // 
            Output_O2.BorderStyle = BorderStyle.None;
            Output_O2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Output_O2.Location = new Point(54, 11);
            Output_O2.Name = "Output_O2";
            Output_O2.ReadOnly = true;
            Output_O2.Size = new Size(150, 30);
            Output_O2.TabIndex = 1;
            Output_O2.TabStop = false;
            // 
            // Fuel_O2req
            // 
            Fuel_O2req.AutoSize = true;
            Fuel_O2req.Font = new Font("Simple Bold Jut Out", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Fuel_O2req.Location = new Point(9, 9);
            Fuel_O2req.Name = "Fuel_O2req";
            Fuel_O2req.Size = new Size(39, 29);
            Fuel_O2req.TabIndex = 0;
            Fuel_O2req.Text = "O2";
            // 
            // ResultPanelText
            // 
            ResultPanelText.AutoSize = true;
            ResultPanelText.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            ResultPanelText.Location = new Point(335, 201);
            ResultPanelText.Name = "ResultPanelText";
            ResultPanelText.Size = new Size(99, 28);
            ResultPanelText.TabIndex = 27;
            ResultPanelText.Text = "Required";
            ResultPanelText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Quantity_C
            // 
            Quantity_C.AutoSize = true;
            Quantity_C.FlatStyle = FlatStyle.Flat;
            Quantity_C.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Quantity_C.ForeColor = Color.FromArgb(64, 0, 60);
            Quantity_C.Location = new Point(261, 56);
            Quantity_C.Name = "Quantity_C";
            Quantity_C.Size = new Size(28, 26);
            Quantity_C.TabIndex = 28;
            Quantity_C.Text = "%";
            // 
            // Quantity_H2
            // 
            Quantity_H2.AutoSize = true;
            Quantity_H2.FlatStyle = FlatStyle.Flat;
            Quantity_H2.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Quantity_H2.ForeColor = Color.FromArgb(64, 0, 60);
            Quantity_H2.Location = new Point(261, 107);
            Quantity_H2.Name = "Quantity_H2";
            Quantity_H2.Size = new Size(28, 26);
            Quantity_H2.TabIndex = 28;
            Quantity_H2.Text = "%";
            // 
            // Quantity_S
            // 
            Quantity_S.AutoSize = true;
            Quantity_S.FlatStyle = FlatStyle.Flat;
            Quantity_S.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Quantity_S.ForeColor = Color.FromArgb(64, 0, 60);
            Quantity_S.Location = new Point(261, 158);
            Quantity_S.Name = "Quantity_S";
            Quantity_S.Size = new Size(28, 26);
            Quantity_S.TabIndex = 28;
            Quantity_S.Text = "%";
            // 
            // Quantity_CO
            // 
            Quantity_CO.AutoSize = true;
            Quantity_CO.FlatStyle = FlatStyle.Flat;
            Quantity_CO.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Quantity_CO.ForeColor = Color.FromArgb(64, 0, 60);
            Quantity_CO.Location = new Point(261, 209);
            Quantity_CO.Name = "Quantity_CO";
            Quantity_CO.Size = new Size(28, 26);
            Quantity_CO.TabIndex = 28;
            Quantity_CO.Text = "%";
            // 
            // Quantity_CH4
            // 
            Quantity_CH4.AutoSize = true;
            Quantity_CH4.FlatStyle = FlatStyle.Flat;
            Quantity_CH4.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Quantity_CH4.ForeColor = Color.FromArgb(64, 0, 60);
            Quantity_CH4.Location = new Point(261, 260);
            Quantity_CH4.Name = "Quantity_CH4";
            Quantity_CH4.Size = new Size(28, 26);
            Quantity_CH4.TabIndex = 28;
            Quantity_CH4.Text = "%";
            // 
            // Quantity_C2H2
            // 
            Quantity_C2H2.AutoSize = true;
            Quantity_C2H2.FlatStyle = FlatStyle.Flat;
            Quantity_C2H2.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Quantity_C2H2.ForeColor = Color.FromArgb(64, 0, 60);
            Quantity_C2H2.Location = new Point(261, 311);
            Quantity_C2H2.Name = "Quantity_C2H2";
            Quantity_C2H2.Size = new Size(28, 26);
            Quantity_C2H2.TabIndex = 28;
            Quantity_C2H2.Text = "%";
            // 
            // Quantity_C2H4
            // 
            Quantity_C2H4.AutoSize = true;
            Quantity_C2H4.FlatStyle = FlatStyle.Flat;
            Quantity_C2H4.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Quantity_C2H4.ForeColor = Color.FromArgb(64, 0, 60);
            Quantity_C2H4.Location = new Point(261, 362);
            Quantity_C2H4.Name = "Quantity_C2H4";
            Quantity_C2H4.Size = new Size(28, 26);
            Quantity_C2H4.TabIndex = 28;
            Quantity_C2H4.Text = "%";
            // 
            // Quantity_C2H6
            // 
            Quantity_C2H6.AutoSize = true;
            Quantity_C2H6.FlatStyle = FlatStyle.Flat;
            Quantity_C2H6.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Quantity_C2H6.ForeColor = Color.FromArgb(64, 0, 60);
            Quantity_C2H6.Location = new Point(261, 413);
            Quantity_C2H6.Name = "Quantity_C2H6";
            Quantity_C2H6.Size = new Size(28, 26);
            Quantity_C2H6.TabIndex = 28;
            Quantity_C2H6.Text = "%";
            // 
            // Quantity_C3H8
            // 
            Quantity_C3H8.AutoSize = true;
            Quantity_C3H8.FlatStyle = FlatStyle.Flat;
            Quantity_C3H8.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Quantity_C3H8.ForeColor = Color.FromArgb(64, 0, 60);
            Quantity_C3H8.Location = new Point(261, 464);
            Quantity_C3H8.Name = "Quantity_C3H8";
            Quantity_C3H8.Size = new Size(28, 26);
            Quantity_C3H8.TabIndex = 28;
            Quantity_C3H8.Text = "%";
            // 
            // Quantity_C4H10
            // 
            Quantity_C4H10.AutoSize = true;
            Quantity_C4H10.FlatStyle = FlatStyle.Flat;
            Quantity_C4H10.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Quantity_C4H10.ForeColor = Color.FromArgb(64, 0, 60);
            Quantity_C4H10.Location = new Point(261, 515);
            Quantity_C4H10.Name = "Quantity_C4H10";
            Quantity_C4H10.Size = new Size(28, 26);
            Quantity_C4H10.TabIndex = 28;
            Quantity_C4H10.Text = "%";
            // 
            // Quantity_C5H12
            // 
            Quantity_C5H12.AutoSize = true;
            Quantity_C5H12.FlatStyle = FlatStyle.Flat;
            Quantity_C5H12.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Quantity_C5H12.ForeColor = Color.FromArgb(64, 0, 60);
            Quantity_C5H12.Location = new Point(261, 566);
            Quantity_C5H12.Name = "Quantity_C5H12";
            Quantity_C5H12.Size = new Size(28, 26);
            Quantity_C5H12.TabIndex = 28;
            Quantity_C5H12.Text = "%";
            // 
            // MenuMainForm
            // 
            MenuMainForm.ImageScalingSize = new Size(24, 24);
            MenuMainForm.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem, AboutToolStripMenuItem });
            MenuMainForm.Location = new Point(0, 0);
            MenuMainForm.Name = "MenuMainForm";
            MenuMainForm.Size = new Size(634, 33);
            MenuMainForm.TabIndex = 29;
            MenuMainForm.Text = "Menu";
            // 
            // FileToolStripMenuItem
            // 
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ResetToolStripMenuItem, ExitToolStripMenuItem });
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            FileToolStripMenuItem.Size = new Size(54, 29);
            FileToolStripMenuItem.Text = "&File";
            // 
            // ResetToolStripMenuItem
            // 
            ResetToolStripMenuItem.AutoSize = false;
            ResetToolStripMenuItem.Name = "ResetToolStripMenuItem";
            ResetToolStripMenuItem.ShortcutKeyDisplayString = "Alt+R";
            ResetToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.R;
            ResetToolStripMenuItem.Size = new Size(270, 34);
            ResetToolStripMenuItem.Text = "&Reset";
            ResetToolStripMenuItem.Click += ResetToolStripMenuItem_Click;
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.AutoSize = false;
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.RightToLeft = RightToLeft.No;
            ExitToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4";
            ExitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            ExitToolStripMenuItem.Size = new Size(270, 34);
            ExitToolStripMenuItem.Text = "E&xit";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // AboutToolStripMenuItem
            // 
            AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            AboutToolStripMenuItem.Size = new Size(78, 29);
            AboutToolStripMenuItem.Text = "&About";
            AboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            // 
            // CleanButton
            // 
            CleanButton.BackgroundImageLayout = ImageLayout.Center;
            CleanButton.FlatAppearance.BorderSize = 0;
            CleanButton.FlatStyle = FlatStyle.Flat;
            CleanButton.Image = (Image)resources.GetObject("CleanButton.Image");
            CleanButton.Location = new Point(548, 56);
            CleanButton.Name = "CleanButton";
            CleanButton.Size = new Size(51, 52);
            CleanButton.TabIndex = 30;
            CleanButton.TabStop = false;
            toolTip.SetToolTip(CleanButton, "Reset");
            CleanButton.UseVisualStyleBackColor = true;
            CleanButton.Click += CleanButton_Click;
            // 
            // Quantity_O2
            // 
            Quantity_O2.AutoSize = true;
            Quantity_O2.FlatStyle = FlatStyle.Flat;
            Quantity_O2.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Quantity_O2.ForeColor = Color.FromArgb(64, 0, 60);
            Quantity_O2.Location = new Point(460, 102);
            Quantity_O2.Name = "Quantity_O2";
            Quantity_O2.Size = new Size(28, 26);
            Quantity_O2.TabIndex = 28;
            Quantity_O2.Text = "%";
            // 
            // DevInfo
            // 
            DevInfo.AutoSize = true;
            DevInfo.Dock = DockStyle.Bottom;
            DevInfo.LinkBehavior = LinkBehavior.HoverUnderline;
            DevInfo.Location = new Point(0, 630);
            DevInfo.Name = "DevInfo";
            DevInfo.Padding = new Padding(3, 0, 2, 0);
            DevInfo.Size = new Size(128, 25);
            DevInfo.TabIndex = 31;
            DevInfo.TabStop = true;
            DevInfo.Text = "Amer10Coder";
            // 
            // ResultButton
            // 
            ResultButton.BackColor = SystemColors.HotTrack;
            ResultButton.FlatStyle = FlatStyle.Popup;
            ResultButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ResultButton.ForeColor = SystemColors.Window;
            ResultButton.Location = new Point(382, 464);
            ResultButton.Name = "ResultButton";
            ResultButton.Size = new Size(156, 71);
            ResultButton.TabIndex = 32;
            ResultButton.TabStop = false;
            ResultButton.Text = "OK";
            ResultButton.UseVisualStyleBackColor = false;
            ResultButton.Click += ResultButton_Click;
            ResultButton.MouseLeave += ResultButton_MouseLeave;
            ResultButton.MouseMove += ResultButton_MouseMove;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(634, 655);
            Controls.Add(ResultButton);
            Controls.Add(DevInfo);
            Controls.Add(MenuMainForm);
            Controls.Add(CleanButton);
            Controls.Add(Quantity_O2);
            Controls.Add(Quantity_C5H12);
            Controls.Add(Quantity_C4H10);
            Controls.Add(Quantity_C3H8);
            Controls.Add(Quantity_C2H6);
            Controls.Add(Quantity_C2H4);
            Controls.Add(Quantity_C2H2);
            Controls.Add(Quantity_CH4);
            Controls.Add(Quantity_CO);
            Controls.Add(Quantity_S);
            Controls.Add(Quantity_H2);
            Controls.Add(Quantity_C);
            Controls.Add(ResultPanel);
            Controls.Add(Input_C);
            Controls.Add(Input_H2);
            Controls.Add(Input_S);
            Controls.Add(Input_CO);
            Controls.Add(Input_CH4);
            Controls.Add(Input_C2H2);
            Controls.Add(Input_C2H4);
            Controls.Add(Input_C2H6);
            Controls.Add(Input_C3H8);
            Controls.Add(Input_C4H10);
            Controls.Add(Input_C5H12);
            Controls.Add(Input_O2);
            Controls.Add(Fuel_C);
            Controls.Add(Fuel_H2);
            Controls.Add(Fuel_S);
            Controls.Add(Fuel_CO);
            Controls.Add(Fuel_CH4);
            Controls.Add(Fuel_C2H2);
            Controls.Add(Fuel_C2H4);
            Controls.Add(Fuel_C2H6);
            Controls.Add(Fuel_C3H8);
            Controls.Add(Fuel_C4H10);
            Controls.Add(Fuel_C5H12);
            Controls.Add(Fuel_O2);
            Controls.Add(ResultPanelText);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MenuMainForm;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Combustion Calculator";
            ResultPanel.ResumeLayout(false);
            ResultPanel.PerformLayout();
            MenuMainForm.ResumeLayout(false);
            MenuMainForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Fuel_C;
        private Label Fuel_H2;
        private Label Fuel_S;
        private Label Fuel_CO;
        private Label Fuel_CH4;
        private Label Fuel_C2H2;
        private Label Fuel_C2H4;
        private Label Fuel_C2H6;
        private Label Fuel_C3H8;
        private Label Fuel_C4H10;
        private Label Fuel_C5H12;
        private Label Fuel_O2;
        private Panel ResultPanel;
        private Label Fuel_O2req;
        private TextBox Output_O2;
        private Label ResultPanelText;
        private Label Quantity_C;
        private Label Quantity_H2;
        private Label Quantity_S;
        private Label Quantity_CO;
        private Label Quantity_CH4;
        private Label Quantity_C2H2;
        private Label Quantity_C2H4;
        private Label Quantity_C2H6;
        private Label Quantity_C3H8;
        private Label Quantity_C4H10;
        private Label Quantity_C5H12;
        private Label Quantity_O2req;
        public TextBox Input_C;
        public TextBox Input_H2;
        public TextBox Input_S;
        public TextBox Input_CO;
        public TextBox Input_CH4;
        public TextBox Input_C2H2;
        public TextBox Input_C2H4;
        public TextBox Input_C2H6;
        public TextBox Input_C3H8;
        public TextBox Input_C4H10;
        public TextBox Input_C5H12;
        public TextBox Input_O2;
        private MenuStrip MenuMainForm;
        private ToolStripMenuItem FileToolStripMenuItem;
        private Button CleanButton;
        private ToolTip toolTip;
        private Label Quantity_O2;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem AboutToolStripMenuItem;
        private ToolStripMenuItem ResetToolStripMenuItem;
        private LinkLabel DevInfo;
        private Button ResultButton;
    }
}