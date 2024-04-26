namespace workARM
{
    partial class mainForm1
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
            listView1 = new ListView();
            Name = new ColumnHeader();
            LastName = new ColumnHeader();
            Number = new ColumnHeader();
            Post = new ColumnHeader();
            Model = new ColumnHeader();
            Breaking = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Name, LastName, Number, Post, Model, Breaking });
            listView1.Location = new Point(11, 11);
            listView1.Margin = new Padding(2);
            listView1.Name = "listView1";
            listView1.Size = new Size(766, 171);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Name
            // 
            Name.Text = "Имя";
            Name.Width = 100;
            // 
            // LastName
            // 
            LastName.Text = "Фамилия";
            LastName.Width = 100;
            // 
            // Number
            // 
            Number.Text = "Номер телефона";
            Number.Width = 200;
            // 
            // Post
            // 
            Post.Text = "Почта";
            // 
            // Model
            // 
            Model.Text = "Модель телефона";
            Model.Width = 150;
            // 
            // Breaking
            // 
            Breaking.Text = "Причина поломки ";
            Breaking.Width = 300;
            // 
            // button1
            // 
            button1.Location = new Point(11, 322);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(232, 27);
            button1.TabIndex = 1;
            button1.Text = "Создать заявку";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(283, 322);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(232, 27);
            button2.TabIndex = 2;
            button2.Text = "Обновить таблицу";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(545, 322);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(232, 27);
            button3.TabIndex = 3;
            button3.Text = "Удалить заявку";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // mainForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 360);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Margin = new Padding(2);
            //Name = "mainForm1";
            Text = "mainForm1";
            Load += mainForm1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button button1;
        private ColumnHeader Name;
        private ColumnHeader LastName;
        private ColumnHeader Number;
        private ColumnHeader Post;
        private ColumnHeader Model;
        private ColumnHeader Breaking;
        private Button button2;
        private Button button3;
    }
}