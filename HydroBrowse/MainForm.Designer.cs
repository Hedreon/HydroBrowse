namespace HydroBrowse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties57 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties58 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties59 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties60 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.PageContainer = new System.Windows.Forms.Panel();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnForward = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.AddressBar = new Bunifu.UI.WinForms.BunifuTextBox();
            this.SuspendLayout();
            // 
            // PageContainer
            // 
            this.PageContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PageContainer.Location = new System.Drawing.Point(12, 38);
            this.PageContainer.Name = "PageContainer";
            this.PageContainer.Size = new System.Drawing.Size(776, 400);
            this.PageContainer.TabIndex = 1;
            // 
            // BtnBack
            // 
            this.BtnBack.FlatAppearance.BorderSize = 0;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnBack.Location = new System.Drawing.Point(12, 7);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(25, 25);
            this.BtnBack.TabIndex = 3;
            this.BtnBack.Text = "<";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnForward
            // 
            this.BtnForward.FlatAppearance.BorderSize = 0;
            this.BtnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnForward.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnForward.Location = new System.Drawing.Point(43, 7);
            this.BtnForward.Name = "BtnForward";
            this.BtnForward.Size = new System.Drawing.Size(25, 25);
            this.BtnForward.TabIndex = 4;
            this.BtnForward.Text = ">";
            this.BtnForward.UseVisualStyleBackColor = true;
            this.BtnForward.Click += new System.EventHandler(this.BtnForward_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.FlatAppearance.BorderSize = 0;
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnRefresh.Location = new System.Drawing.Point(74, 7);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(75, 25);
            this.BtnRefresh.TabIndex = 5;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // AddressBar
            // 
            this.AddressBar.AcceptsReturn = false;
            this.AddressBar.AcceptsTab = false;
            this.AddressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressBar.AnimationSpeed = 200;
            this.AddressBar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.AddressBar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.AddressBar.BackColor = System.Drawing.Color.White;
            this.AddressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddressBar.BackgroundImage")));
            this.AddressBar.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.AddressBar.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddressBar.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.AddressBar.BorderColorIdle = System.Drawing.Color.Silver;
            this.AddressBar.BorderRadius = 25;
            this.AddressBar.BorderThickness = 1;
            this.AddressBar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.AddressBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressBar.DefaultFont = new System.Drawing.Font("Segoe UI", 10F);
            this.AddressBar.DefaultText = "https://duckduckgo.com/";
            this.AddressBar.FillColor = System.Drawing.Color.White;
            this.AddressBar.HideSelection = true;
            this.AddressBar.IconLeft = null;
            this.AddressBar.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressBar.IconPadding = 10;
            this.AddressBar.IconRight = null;
            this.AddressBar.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressBar.Lines = new string[] {
        "https://duckduckgo.com/"};
            this.AddressBar.Location = new System.Drawing.Point(155, 7);
            this.AddressBar.MaxLength = 32767;
            this.AddressBar.MinimumSize = new System.Drawing.Size(1, 1);
            this.AddressBar.Modified = false;
            this.AddressBar.Multiline = false;
            this.AddressBar.Name = "AddressBar";
            stateProperties57.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties57.FillColor = System.Drawing.Color.Empty;
            stateProperties57.ForeColor = System.Drawing.Color.Empty;
            stateProperties57.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.AddressBar.OnActiveState = stateProperties57;
            stateProperties58.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties58.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties58.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties58.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.AddressBar.OnDisabledState = stateProperties58;
            stateProperties59.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties59.FillColor = System.Drawing.Color.Empty;
            stateProperties59.ForeColor = System.Drawing.Color.Empty;
            stateProperties59.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.AddressBar.OnHoverState = stateProperties59;
            stateProperties60.BorderColor = System.Drawing.Color.Silver;
            stateProperties60.FillColor = System.Drawing.Color.White;
            stateProperties60.ForeColor = System.Drawing.Color.Empty;
            stateProperties60.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.AddressBar.OnIdleState = stateProperties60;
            this.AddressBar.Padding = new System.Windows.Forms.Padding(3);
            this.AddressBar.PasswordChar = '\0';
            this.AddressBar.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.AddressBar.PlaceholderText = "Enter address";
            this.AddressBar.ReadOnly = false;
            this.AddressBar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AddressBar.SelectedText = "";
            this.AddressBar.SelectionLength = 0;
            this.AddressBar.SelectionStart = 23;
            this.AddressBar.ShortcutsEnabled = true;
            this.AddressBar.Size = new System.Drawing.Size(633, 25);
            this.AddressBar.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.AddressBar.TabIndex = 0;
            this.AddressBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddressBar.TextMarginBottom = 0;
            this.AddressBar.TextMarginLeft = 3;
            this.AddressBar.TextMarginTop = 0;
            this.AddressBar.TextPlaceholder = "Enter address";
            this.AddressBar.UseSystemPasswordChar = false;
            this.AddressBar.WordWrap = true;
            this.AddressBar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AddressBar_KeyUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddressBar);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnForward);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.PageContainer);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HydroBrowse";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PageContainer;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnForward;
        private System.Windows.Forms.Button BtnRefresh;
        private Bunifu.UI.WinForms.BunifuTextBox AddressBar;
    }
}

