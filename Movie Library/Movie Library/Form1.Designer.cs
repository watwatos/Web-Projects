namespace Movie_Library
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            genre_search = new TextBox();
            label15 = new Label();
            show_btn = new Button();
            director_search = new TextBox();
            name_search = new TextBox();
            ID_search = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Movies = new ListBox();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            genre_add = new TextBox();
            label16 = new Label();
            add_btn = new Button();
            director_add = new TextBox();
            name_add = new TextBox();
            ID_add = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label5 = new Label();
            tabPage3 = new TabPage();
            groupBox3 = new GroupBox();
            label8 = new Label();
            delete_btn = new Button();
            ID_del = new TextBox();
            label7 = new Label();
            groupBox2 = new GroupBox();
            genre_mod = new TextBox();
            label17 = new Label();
            modify_btn = new Button();
            director_mod = new TextBox();
            name_mod = new TextBox();
            ID_mod = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label6 = new Label();
            tabPage5 = new TabPage();
            label18 = new Label();
            Recomment = new GroupBox();
            button1 = new Button();
            genre_rec = new TextBox();
            label19 = new Label();
            Recommend = new ListBox();
            tabPage4 = new TabPage();
            exit_btn = new Button();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage5.SuspendLayout();
            Recomment.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(581, 480);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.PaleGreen;
            tabPage1.Controls.Add(genre_search);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(show_btn);
            tabPage1.Controls.Add(director_search);
            tabPage1.Controls.Add(name_search);
            tabPage1.Controls.Add(ID_search);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(Movies);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(573, 452);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "View";
            // 
            // genre_search
            // 
            genre_search.Location = new Point(355, 324);
            genre_search.Name = "genre_search";
            genre_search.Size = new Size(137, 23);
            genre_search.TabIndex = 10;
            genre_search.TextChanged += genre_search_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(248, 327);
            label15.Name = "label15";
            label15.Size = new Size(90, 15);
            label15.TabIndex = 9;
            label15.Text = "search by genre";
            // 
            // show_btn
            // 
            show_btn.Location = new Point(57, 362);
            show_btn.Name = "show_btn";
            show_btn.Size = new Size(125, 34);
            show_btn.TabIndex = 8;
            show_btn.Text = "show all";
            show_btn.UseVisualStyleBackColor = true;
            show_btn.Click += show_btn_Click;
            // 
            // director_search
            // 
            director_search.Location = new Point(355, 276);
            director_search.Name = "director_search";
            director_search.Size = new Size(137, 23);
            director_search.TabIndex = 7;
            director_search.TextChanged += director_search_TextChanged;
            // 
            // name_search
            // 
            name_search.Location = new Point(355, 219);
            name_search.Name = "name_search";
            name_search.Size = new Size(137, 23);
            name_search.TabIndex = 6;
            name_search.TextChanged += name_search_TextChanged;
            // 
            // ID_search
            // 
            ID_search.Location = new Point(355, 165);
            ID_search.Name = "ID_search";
            ID_search.Size = new Size(137, 23);
            ID_search.TabIndex = 5;
            ID_search.TextChanged += ID_search_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 279);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 4;
            label4.Text = "search by director";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(259, 222);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 3;
            label3.Text = "search by name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 168);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 2;
            label2.Text = "search by ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(188, 22);
            label1.Name = "label1";
            label1.Size = new Size(149, 30);
            label1.TabIndex = 1;
            label1.Text = "Movie Library";
            // 
            // Movies
            // 
            Movies.BackColor = Color.DarkSeaGreen;
            Movies.FormattingEnabled = true;
            Movies.ItemHeight = 15;
            Movies.Location = new Point(22, 73);
            Movies.Name = "Movies";
            Movies.Size = new Size(190, 274);
            Movies.TabIndex = 0;
            Movies.SelectedIndexChanged += Movies_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.PaleGreen;
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(573, 452);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSeaGreen;
            groupBox1.Controls.Add(genre_add);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(add_btn);
            groupBox1.Controls.Add(director_add);
            groupBox1.Controls.Add(name_add);
            groupBox1.Controls.Add(ID_add);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Location = new Point(116, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(339, 296);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add movie";
            // 
            // genre_add
            // 
            genre_add.Location = new Point(104, 184);
            genre_add.Name = "genre_add";
            genre_add.Size = new Size(137, 23);
            genre_add.TabIndex = 16;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(50, 187);
            label16.Name = "label16";
            label16.Size = new Size(37, 15);
            label16.TabIndex = 15;
            label16.Text = "genre";
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.Lime;
            add_btn.Location = new Point(114, 233);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(105, 30);
            add_btn.TabIndex = 14;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // director_add
            // 
            director_add.Location = new Point(104, 136);
            director_add.Name = "director_add";
            director_add.Size = new Size(137, 23);
            director_add.TabIndex = 13;
            // 
            // name_add
            // 
            name_add.Location = new Point(104, 91);
            name_add.Name = "name_add";
            name_add.Size = new Size(137, 23);
            name_add.TabIndex = 12;
            // 
            // ID_add
            // 
            ID_add.Location = new Point(104, 42);
            ID_add.Name = "ID_add";
            ID_add.Size = new Size(137, 23);
            ID_add.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(50, 136);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 10;
            label9.Text = "director";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(58, 91);
            label10.Name = "label10";
            label10.Size = new Size(40, 15);
            label10.TabIndex = 9;
            label10.Text = " name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(64, 50);
            label11.Name = "label11";
            label11.Size = new Size(21, 15);
            label11.TabIndex = 8;
            label11.Text = " ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(220, 35);
            label5.Name = "label5";
            label5.Size = new Size(130, 30);
            label5.TabIndex = 2;
            label5.Text = "Add Movies";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.PaleGreen;
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Controls.Add(label6);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(573, 452);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Modify/delete";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.DarkSeaGreen;
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(delete_btn);
            groupBox3.Controls.Add(ID_del);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(306, 96);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(257, 336);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Delete Movie";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(48, 198);
            label8.Name = "label8";
            label8.Size = new Size(170, 15);
            label8.TabIndex = 22;
            label8.Text = "Note: this will delete the movie";
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.Red;
            delete_btn.ForeColor = SystemColors.Control;
            delete_btn.Location = new Point(85, 146);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(97, 38);
            delete_btn.TabIndex = 21;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // ID_del
            // 
            ID_del.Location = new Point(70, 95);
            ID_del.Name = "ID_del";
            ID_del.Size = new Size(137, 23);
            ID_del.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 98);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 18;
            label7.Text = " ID";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DarkSeaGreen;
            groupBox2.Controls.Add(genre_mod);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(modify_btn);
            groupBox2.Controls.Add(director_mod);
            groupBox2.Controls.Add(name_mod);
            groupBox2.Controls.Add(ID_mod);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label14);
            groupBox2.Location = new Point(6, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(257, 336);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modify Movie";
            // 
            // genre_mod
            // 
            genre_mod.Location = new Point(87, 216);
            genre_mod.Name = "genre_mod";
            genre_mod.Size = new Size(137, 23);
            genre_mod.TabIndex = 22;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(33, 219);
            label17.Name = "label17";
            label17.Size = new Size(37, 15);
            label17.TabIndex = 21;
            label17.Text = "genre";
            // 
            // modify_btn
            // 
            modify_btn.BackColor = Color.SpringGreen;
            modify_btn.Location = new Point(87, 272);
            modify_btn.Name = "modify_btn";
            modify_btn.Size = new Size(97, 38);
            modify_btn.TabIndex = 20;
            modify_btn.Text = "Modify";
            modify_btn.UseVisualStyleBackColor = false;
            modify_btn.Click += modify_btn_Click;
            // 
            // director_mod
            // 
            director_mod.Location = new Point(87, 161);
            director_mod.Name = "director_mod";
            director_mod.Size = new Size(137, 23);
            director_mod.TabIndex = 19;
            // 
            // name_mod
            // 
            name_mod.Location = new Point(87, 108);
            name_mod.Name = "name_mod";
            name_mod.Size = new Size(137, 23);
            name_mod.TabIndex = 18;
            // 
            // ID_mod
            // 
            ID_mod.Location = new Point(87, 53);
            ID_mod.Name = "ID_mod";
            ID_mod.Size = new Size(137, 23);
            ID_mod.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(33, 164);
            label12.Name = "label12";
            label12.Size = new Size(48, 15);
            label12.TabIndex = 16;
            label12.Text = "director";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(41, 111);
            label13.Name = "label13";
            label13.Size = new Size(40, 15);
            label13.TabIndex = 15;
            label13.Text = " name";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(50, 56);
            label14.Name = "label14";
            label14.Size = new Size(21, 15);
            label14.TabIndex = 14;
            label14.Text = " ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(167, 31);
            label6.Name = "label6";
            label6.Size = new Size(255, 30);
            label6.TabIndex = 4;
            label6.Text = "Modify or Delete Movies";
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.PaleGreen;
            tabPage5.Controls.Add(label18);
            tabPage5.Controls.Add(Recomment);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(573, 452);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Recommend";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(107, 49);
            label18.Name = "label18";
            label18.Size = new Size(388, 30);
            label18.TabIndex = 5;
            label18.Text = "generate a movie based on your taste!";
            // 
            // Recomment
            // 
            Recomment.BackColor = Color.DarkSeaGreen;
            Recomment.Controls.Add(button1);
            Recomment.Controls.Add(genre_rec);
            Recomment.Controls.Add(label19);
            Recomment.Controls.Add(Recommend);
            Recomment.Location = new Point(34, 98);
            Recomment.Name = "Recomment";
            Recomment.Size = new Size(478, 315);
            Recomment.TabIndex = 0;
            Recomment.TabStop = false;
            Recomment.Text = "Recommend";
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(286, 160);
            button1.Name = "button1";
            button1.Size = new Size(97, 38);
            button1.TabIndex = 24;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // genre_rec
            // 
            genre_rec.Location = new Point(258, 113);
            genre_rec.Name = "genre_rec";
            genre_rec.Size = new Size(166, 23);
            genre_rec.TabIndex = 23;
            genre_rec.TextChanged += genre_rec_TextChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(301, 76);
            label19.Name = "label19";
            label19.Size = new Size(73, 15);
            label19.TabIndex = 22;
            label19.Text = "What genre?";
            // 
            // Recommend
            // 
            Recommend.BackColor = Color.DarkSeaGreen;
            Recommend.FormattingEnabled = true;
            Recommend.ItemHeight = 15;
            Recommend.Location = new Point(16, 64);
            Recommend.Name = "Recommend";
            Recommend.Size = new Size(207, 154);
            Recommend.TabIndex = 0;
            Recommend.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.PaleGreen;
            tabPage4.Controls.Add(exit_btn);
            tabPage4.Controls.Add(pictureBox1);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(573, 452);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Exit";
            // 
            // exit_btn
            // 
            exit_btn.BackColor = SystemColors.ActiveCaptionText;
            exit_btn.ForeColor = SystemColors.ButtonHighlight;
            exit_btn.Location = new Point(208, 308);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(126, 39);
            exit_btn.TabIndex = 1;
            exit_btn.Text = "EXIT";
            exit_btn.UseVisualStyleBackColor = false;
            exit_btn.Click += exit_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(539, 446);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 504);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Mobie Library";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            Recomment.ResumeLayout(false);
            Recomment.PerformLayout();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private PictureBox pictureBox1;
        private Button button1;
        private TextBox director_search;
        private Button show_btn;
        private TextBox name_search;
        private TextBox ID_search;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox Movies;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private Label label5;
        private TabPage tabPage3;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Label label6;
        private Button add_btn;
        private TextBox director_add;
        private TextBox name_add;
        private TextBox ID_add;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox ID_del;
        private Label label7;
        private Button modify_btn;
        private TextBox director_mod;
        private TextBox name_mod;
        private TextBox ID_mod;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label8;
        private Button delete_btn;
        private TabPage tabPage4;
        private Button exit_btn;
        private TextBox genre_search;
        private Label label15;
        private TextBox genre_add;
        private Label label16;
        private TextBox genre_mod;
        private Label label17;
        private TabPage tabPage5;
        private Label label18;
        private GroupBox Recomment;
        private TextBox genre_rec;
        private Label label19;
        private ListBox Recommend;
    }
}