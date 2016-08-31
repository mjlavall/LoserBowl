using System.Windows.Forms;

namespace LoserBowl.Forms
{
    partial class LoserBowl
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
            this.numericUpDownWeek = new System.Windows.Forms.NumericUpDown();
            this.listBoxGames = new System.Windows.Forms.ListBox();
            this.checkedListBoxAFCEast = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBoxAFCWest = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBoxAFCNorth = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBoxAFCSouth = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkedListBoxNFCEast = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkedListBoxNFCWest = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkedListBoxNFCNorth = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkedListBoxNFCSouth = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeek)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownWeek
            // 
            this.numericUpDownWeek.Location = new System.Drawing.Point(12, 15);
            this.numericUpDownWeek.Maximum = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.numericUpDownWeek.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWeek.Name = "numericUpDownWeek";
            this.numericUpDownWeek.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownWeek.TabIndex = 1;
            this.numericUpDownWeek.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWeek.ValueChanged += new System.EventHandler(this.numericUpDownWeek_ValueChanged);
            // 
            // listBoxGames
            // 
            this.listBoxGames.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGames.FormattingEnabled = true;
            this.listBoxGames.ItemHeight = 24;
            this.listBoxGames.Location = new System.Drawing.Point(465, 41);
            this.listBoxGames.Name = "listBoxGames";
            this.listBoxGames.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxGames.Size = new System.Drawing.Size(458, 388);
            this.listBoxGames.TabIndex = 10;
            // 
            // checkedListBoxAFCEast
            // 
            this.checkedListBoxAFCEast.CheckOnClick = true;
            this.checkedListBoxAFCEast.FormattingEnabled = true;
            this.checkedListBoxAFCEast.Location = new System.Drawing.Point(12, 63);
            this.checkedListBoxAFCEast.Name = "checkedListBoxAFCEast";
            this.checkedListBoxAFCEast.Size = new System.Drawing.Size(214, 64);
            this.checkedListBoxAFCEast.TabIndex = 2;
            this.checkedListBoxAFCEast.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "AFC East";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "AFC West";
            // 
            // checkedListBoxAFCWest
            // 
            this.checkedListBoxAFCWest.CheckOnClick = true;
            this.checkedListBoxAFCWest.FormattingEnabled = true;
            this.checkedListBoxAFCWest.Location = new System.Drawing.Point(12, 153);
            this.checkedListBoxAFCWest.Name = "checkedListBoxAFCWest";
            this.checkedListBoxAFCWest.Size = new System.Drawing.Size(214, 64);
            this.checkedListBoxAFCWest.TabIndex = 4;
            this.checkedListBoxAFCWest.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "AFC North";
            // 
            // checkedListBoxAFCNorth
            // 
            this.checkedListBoxAFCNorth.CheckOnClick = true;
            this.checkedListBoxAFCNorth.FormattingEnabled = true;
            this.checkedListBoxAFCNorth.Location = new System.Drawing.Point(12, 245);
            this.checkedListBoxAFCNorth.Name = "checkedListBoxAFCNorth";
            this.checkedListBoxAFCNorth.Size = new System.Drawing.Size(214, 64);
            this.checkedListBoxAFCNorth.TabIndex = 6;
            this.checkedListBoxAFCNorth.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "AFC South";
            // 
            // checkedListBoxAFCSouth
            // 
            this.checkedListBoxAFCSouth.CheckOnClick = true;
            this.checkedListBoxAFCSouth.FormattingEnabled = true;
            this.checkedListBoxAFCSouth.Location = new System.Drawing.Point(12, 337);
            this.checkedListBoxAFCSouth.Name = "checkedListBoxAFCSouth";
            this.checkedListBoxAFCSouth.Size = new System.Drawing.Size(214, 64);
            this.checkedListBoxAFCSouth.TabIndex = 8;
            this.checkedListBoxAFCSouth.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(233, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "NFC East";
            // 
            // checkedListBoxNFCEast
            // 
            this.checkedListBoxNFCEast.CheckOnClick = true;
            this.checkedListBoxNFCEast.FormattingEnabled = true;
            this.checkedListBoxNFCEast.Location = new System.Drawing.Point(232, 63);
            this.checkedListBoxNFCEast.Name = "checkedListBoxNFCEast";
            this.checkedListBoxNFCEast.Size = new System.Drawing.Size(214, 64);
            this.checkedListBoxNFCEast.TabIndex = 3;
            this.checkedListBoxNFCEast.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(233, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "NFC West";
            // 
            // checkedListBoxNFCWest
            // 
            this.checkedListBoxNFCWest.CheckOnClick = true;
            this.checkedListBoxNFCWest.FormattingEnabled = true;
            this.checkedListBoxNFCWest.Location = new System.Drawing.Point(232, 153);
            this.checkedListBoxNFCWest.Name = "checkedListBoxNFCWest";
            this.checkedListBoxNFCWest.Size = new System.Drawing.Size(214, 64);
            this.checkedListBoxNFCWest.TabIndex = 5;
            this.checkedListBoxNFCWest.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(233, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "NFC North";
            // 
            // checkedListBoxNFCNorth
            // 
            this.checkedListBoxNFCNorth.CheckOnClick = true;
            this.checkedListBoxNFCNorth.FormattingEnabled = true;
            this.checkedListBoxNFCNorth.Location = new System.Drawing.Point(232, 245);
            this.checkedListBoxNFCNorth.Name = "checkedListBoxNFCNorth";
            this.checkedListBoxNFCNorth.Size = new System.Drawing.Size(214, 64);
            this.checkedListBoxNFCNorth.TabIndex = 7;
            this.checkedListBoxNFCNorth.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(233, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "NFC South";
            // 
            // checkedListBoxNFCSouth
            // 
            this.checkedListBoxNFCSouth.CheckOnClick = true;
            this.checkedListBoxNFCSouth.FormattingEnabled = true;
            this.checkedListBoxNFCSouth.Location = new System.Drawing.Point(232, 337);
            this.checkedListBoxNFCSouth.Name = "checkedListBoxNFCSouth";
            this.checkedListBoxNFCSouth.Size = new System.Drawing.Size(214, 64);
            this.checkedListBoxNFCSouth.TabIndex = 9;
            this.checkedListBoxNFCSouth.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            // 
            // LoserBowl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 439);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkedListBoxNFCSouth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkedListBoxNFCNorth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkedListBoxNFCWest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkedListBoxNFCEast);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkedListBoxAFCSouth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedListBoxAFCNorth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBoxAFCWest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxGames);
            this.Controls.Add(this.numericUpDownWeek);
            this.Controls.Add(this.checkedListBoxAFCEast);
            this.Name = "LoserBowl";
            this.Text = "Loser Bowl";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDownWeek;
        private System.Windows.Forms.ListBox listBoxGames;
        private System.Windows.Forms.CheckedListBox checkedListBoxAFCEast;
        private Label label1;
        private Label label2;
        private CheckedListBox checkedListBoxAFCWest;
        private Label label3;
        private CheckedListBox checkedListBoxAFCNorth;
        private Label label4;
        private CheckedListBox checkedListBoxAFCSouth;
        private Label label5;
        private CheckedListBox checkedListBoxNFCEast;
        private Label label6;
        private CheckedListBox checkedListBoxNFCWest;
        private Label label7;
        private CheckedListBox checkedListBoxNFCNorth;
        private Label label8;
        private CheckedListBox checkedListBoxNFCSouth;
    }
}

