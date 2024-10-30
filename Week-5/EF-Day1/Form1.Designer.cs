namespace EF_Day1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Edit = new Button();
            DGV_Players = new DataGridView();
            Save = new Button();
            Delete = new Button();
            tb_salary = new TextBox();
            tb_name = new TextBox();
            tb_number = new TextBox();
            tb_position = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tb_nationalty = new TextBox();
            label6 = new Label();
            tb_redcards = new TextBox();
            label5 = new Label();
            tb_yellowcards = new TextBox();
            label7 = new Label();
            tb_goals = new TextBox();
            label8 = new Label();
            tb_games = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGV_Players).BeginInit();
            SuspendLayout();
            // 
            // Edit
            // 
            Edit.BackColor = Color.CornflowerBlue;
            Edit.FlatStyle = FlatStyle.Popup;
            Edit.Font = new Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Edit.ImageAlign = ContentAlignment.MiddleLeft;
            Edit.Location = new Point(347, 221);
            Edit.Name = "Edit";
            Edit.Size = new Size(292, 52);
            Edit.TabIndex = 0;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = false;
            Edit.Click += Edit_Click;
            // 
            // DGV_Players
            // 
            DGV_Players.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Players.Location = new Point(12, 338);
            DGV_Players.Name = "DGV_Players";
            DGV_Players.RowHeadersWidth = 51;
            DGV_Players.Size = new Size(627, 308);
            DGV_Players.TabIndex = 1;
            DGV_Players.RowHeaderMouseDoubleClick += DGV_Players_RowHeaderMouseDoubleClick;
            // 
            // Save
            // 
            Save.BackColor = Color.MediumSeaGreen;
            Save.FlatStyle = FlatStyle.Popup;
            Save.Font = new Font("Bookman Old Style", 9F, FontStyle.Bold);
            Save.Location = new Point(100, 279);
            Save.Name = "Save";
            Save.Size = new Size(223, 53);
            Save.TabIndex = 2;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.LightCoral;
            Delete.FlatStyle = FlatStyle.Popup;
            Delete.Font = new Font("Bookman Old Style", 9F, FontStyle.Bold);
            Delete.Location = new Point(347, 279);
            Delete.Name = "Delete";
            Delete.Size = new Size(292, 53);
            Delete.TabIndex = 3;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // tb_salary
            // 
            tb_salary.Location = new Point(100, 233);
            tb_salary.Name = "tb_salary";
            tb_salary.Size = new Size(223, 27);
            tb_salary.TabIndex = 4;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(100, 22);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(223, 27);
            tb_name.TabIndex = 5;
            // 
            // tb_number
            // 
            tb_number.Location = new Point(451, 26);
            tb_number.Name = "tb_number";
            tb_number.Size = new Size(188, 27);
            tb_number.TabIndex = 6;
            // 
            // tb_position
            // 
            tb_position.Location = new Point(100, 84);
            tb_position.Name = "tb_position";
            tb_position.Size = new Size(223, 27);
            tb_position.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 240);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 8;
            label1.Text = "Salary";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 29);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 9;
            label2.Text = "Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 29);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 10;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 87);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 11;
            label4.Text = "Position";
            // 
            // tb_nationalty
            // 
            tb_nationalty.Location = new Point(455, 86);
            tb_nationalty.Name = "tb_nationalty";
            tb_nationalty.Size = new Size(184, 27);
            tb_nationalty.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(347, 91);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 15;
            label6.Text = "Nationallity";
            // 
            // tb_redcards
            // 
            tb_redcards.Location = new Point(100, 135);
            tb_redcards.Name = "tb_redcards";
            tb_redcards.Size = new Size(223, 27);
            tb_redcards.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 142);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 17;
            label5.Text = "Red Cards";
            // 
            // tb_yellowcards
            // 
            tb_yellowcards.Location = new Point(455, 134);
            tb_yellowcards.Name = "tb_yellowcards";
            tb_yellowcards.Size = new Size(184, 27);
            tb_yellowcards.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(347, 141);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 19;
            label7.Text = "Yellow Cards";
            // 
            // tb_goals
            // 
            tb_goals.Location = new Point(100, 192);
            tb_goals.Name = "tb_goals";
            tb_goals.Size = new Size(223, 27);
            tb_goals.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 199);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 21;
            label8.Text = "Goals";
            // 
            // tb_games
            // 
            tb_games.Location = new Point(455, 188);
            tb_games.Name = "tb_games";
            tb_games.Size = new Size(184, 27);
            tb_games.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(347, 191);
            label9.Name = "label9";
            label9.Size = new Size(54, 20);
            label9.TabIndex = 23;
            label9.Text = "Games";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 658);
            Controls.Add(label9);
            Controls.Add(tb_games);
            Controls.Add(label8);
            Controls.Add(tb_goals);
            Controls.Add(label7);
            Controls.Add(tb_yellowcards);
            Controls.Add(label5);
            Controls.Add(tb_redcards);
            Controls.Add(label6);
            Controls.Add(tb_nationalty);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_position);
            Controls.Add(tb_number);
            Controls.Add(tb_name);
            Controls.Add(tb_salary);
            Controls.Add(Delete);
            Controls.Add(Save);
            Controls.Add(DGV_Players);
            Controls.Add(Edit);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "SquadDB";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_Players).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Edit;
        private DataGridView DGV_Players;
        private Button Save;
        private Button Delete;
        private TextBox tb_salary;
        private TextBox tb_name;
        private TextBox tb_number;
        private TextBox tb_position;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tb_nationalty;
        private Label label6;
        private TextBox tb_redcards;
        private Label label5;
        private TextBox tb_yellowcards;
        private Label label7;
        private TextBox tb_goals;
        private Label label8;
        private TextBox tb_games;
        private Label label9;
    }
}
