namespace RugbyApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TableTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GameList = new System.Windows.Forms.ListView();
            this.PlayerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tries = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Conversions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SeasonList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlayerNameInput = new System.Windows.Forms.TextBox();
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.TriesLabel = new System.Windows.Forms.Label();
            this.TriesInput = new System.Windows.Forms.NumericUpDown();
            this.ConversionsInput = new System.Windows.Forms.NumericUpDown();
            this.ConversionsLabel = new System.Windows.Forms.Label();
            this.SubmitPlayerButton = new System.Windows.Forms.Button();
            this.SubmitGameButton = new System.Windows.Forms.Button();
            this.TableTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TriesInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConversionsInput)).BeginInit();
            this.SuspendLayout();
            // 
            // TableTabs
            // 
            this.TableTabs.Controls.Add(this.tabPage1);
            this.TableTabs.Controls.Add(this.tabPage2);
            this.TableTabs.Location = new System.Drawing.Point(12, 128);
            this.TableTabs.Name = "TableTabs";
            this.TableTabs.SelectedIndex = 0;
            this.TableTabs.Size = new System.Drawing.Size(374, 339);
            this.TableTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GameList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(366, 313);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Game";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GameList
            // 
            this.GameList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PlayerName,
            this.Tries,
            this.Conversions});
            this.GameList.HideSelection = false;
            this.GameList.Location = new System.Drawing.Point(6, 6);
            this.GameList.Name = "GameList";
            this.GameList.Size = new System.Drawing.Size(353, 302);
            this.GameList.TabIndex = 0;
            this.GameList.UseCompatibleStateImageBehavior = false;
            this.GameList.View = System.Windows.Forms.View.Details;
            this.GameList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.GameList_ColumnClick);
            // 
            // PlayerName
            // 
            this.PlayerName.Text = "Player Name";
            this.PlayerName.Width = 138;
            // 
            // Tries
            // 
            this.Tries.Text = "Tries";
            this.Tries.Width = 68;
            // 
            // Conversions
            // 
            this.Conversions.Text = "Conversions";
            this.Conversions.Width = 71;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SeasonList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(366, 313);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Season";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SeasonList
            // 
            this.SeasonList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.SeasonList.HideSelection = false;
            this.SeasonList.Location = new System.Drawing.Point(6, 6);
            this.SeasonList.Name = "SeasonList";
            this.SeasonList.Size = new System.Drawing.Size(353, 302);
            this.SeasonList.TabIndex = 1;
            this.SeasonList.UseCompatibleStateImageBehavior = false;
            this.SeasonList.View = System.Windows.Forms.View.Details;
            this.SeasonList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.SeasonList_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Player Name";
            this.columnHeader1.Width = 138;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tries";
            this.columnHeader2.Width = 68;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Conversions";
            this.columnHeader3.Width = 71;
            // 
            // PlayerNameInput
            // 
            this.PlayerNameInput.Location = new System.Drawing.Point(92, 32);
            this.PlayerNameInput.Name = "PlayerNameInput";
            this.PlayerNameInput.Size = new System.Drawing.Size(133, 20);
            this.PlayerNameInput.TabIndex = 1;
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.AutoSize = true;
            this.PlayerNameLabel.Location = new System.Drawing.Point(19, 35);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(67, 13);
            this.PlayerNameLabel.TabIndex = 2;
            this.PlayerNameLabel.Text = "Player Name";
            // 
            // TriesLabel
            // 
            this.TriesLabel.AutoSize = true;
            this.TriesLabel.Location = new System.Drawing.Point(56, 63);
            this.TriesLabel.Name = "TriesLabel";
            this.TriesLabel.Size = new System.Drawing.Size(30, 13);
            this.TriesLabel.TabIndex = 3;
            this.TriesLabel.Text = "Tries";
            // 
            // TriesInput
            // 
            this.TriesInput.Location = new System.Drawing.Point(92, 61);
            this.TriesInput.Name = "TriesInput";
            this.TriesInput.Size = new System.Drawing.Size(133, 20);
            this.TriesInput.TabIndex = 4;
            // 
            // ConversionsInput
            // 
            this.ConversionsInput.Location = new System.Drawing.Point(92, 87);
            this.ConversionsInput.Name = "ConversionsInput";
            this.ConversionsInput.Size = new System.Drawing.Size(133, 20);
            this.ConversionsInput.TabIndex = 5;
            // 
            // ConversionsLabel
            // 
            this.ConversionsLabel.AutoSize = true;
            this.ConversionsLabel.Location = new System.Drawing.Point(21, 89);
            this.ConversionsLabel.Name = "ConversionsLabel";
            this.ConversionsLabel.Size = new System.Drawing.Size(65, 13);
            this.ConversionsLabel.TabIndex = 6;
            this.ConversionsLabel.Text = "Conversions";
            // 
            // SubmitPlayerButton
            // 
            this.SubmitPlayerButton.Location = new System.Drawing.Point(243, 32);
            this.SubmitPlayerButton.Name = "SubmitPlayerButton";
            this.SubmitPlayerButton.Size = new System.Drawing.Size(63, 75);
            this.SubmitPlayerButton.TabIndex = 7;
            this.SubmitPlayerButton.Text = "Submit Player";
            this.SubmitPlayerButton.UseVisualStyleBackColor = true;
            this.SubmitPlayerButton.Click += new System.EventHandler(this.SubmitPlayerButton_Click);
            // 
            // SubmitGameButton
            // 
            this.SubmitGameButton.Location = new System.Drawing.Point(312, 32);
            this.SubmitGameButton.Name = "SubmitGameButton";
            this.SubmitGameButton.Size = new System.Drawing.Size(63, 75);
            this.SubmitGameButton.TabIndex = 8;
            this.SubmitGameButton.Text = "Submit Game";
            this.SubmitGameButton.UseVisualStyleBackColor = true;
            this.SubmitGameButton.Click += new System.EventHandler(this.SubmitGameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 477);
            this.Controls.Add(this.SubmitGameButton);
            this.Controls.Add(this.SubmitPlayerButton);
            this.Controls.Add(this.ConversionsLabel);
            this.Controls.Add(this.ConversionsInput);
            this.Controls.Add(this.TriesInput);
            this.Controls.Add(this.TriesLabel);
            this.Controls.Add(this.PlayerNameLabel);
            this.Controls.Add(this.PlayerNameInput);
            this.Controls.Add(this.TableTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rugby Stats";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TableTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TriesInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConversionsInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TableTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView GameList;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ColumnHeader PlayerName;
        private System.Windows.Forms.ColumnHeader Tries;
        private System.Windows.Forms.ColumnHeader Conversions;
        private System.Windows.Forms.TextBox PlayerNameInput;
        private System.Windows.Forms.Label PlayerNameLabel;
        private System.Windows.Forms.Label TriesLabel;
        private System.Windows.Forms.NumericUpDown TriesInput;
        private System.Windows.Forms.NumericUpDown ConversionsInput;
        private System.Windows.Forms.Label ConversionsLabel;
        private System.Windows.Forms.Button SubmitPlayerButton;
        private System.Windows.Forms.Button SubmitGameButton;
        private System.Windows.Forms.ListView SeasonList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

