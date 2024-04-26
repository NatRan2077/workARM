namespace workARM
{
    partial class MakeTicket
    {
        private const string V = "MakeTicket";

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
            Name = new TextBox();
            LastName = new TextBox();
            PhoneNumber = new TextBox();
            Post = new TextBox();
            Model = new TextBox();
            Breaking = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // Name
            // 
            Name.Location = new Point(10, 23);
            Name.Margin = new Padding(2);
            Name.Name = "Name";
            Name.Size = new Size(167, 27);
            Name.TabIndex = 0;
            // 
            // LastName
            // 
            LastName.Location = new Point(10, 69);
            LastName.Margin = new Padding(2);
            LastName.Name = "LastName";
            LastName.Size = new Size(167, 27);
            LastName.TabIndex = 1;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Location = new Point(10, 117);
            PhoneNumber.Margin = new Padding(2);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(167, 27);
            PhoneNumber.TabIndex = 2;
            // 
            // Post
            // 
            Post.Location = new Point(10, 169);
            Post.Margin = new Padding(2);
            Post.Name = "Post";
            Post.Size = new Size(167, 27);
            Post.TabIndex = 3;
            // 
            // Model
            // 
            Model.Location = new Point(10, 218);
            Model.Margin = new Padding(2);
            Model.Name = "Model";
            Model.Size = new Size(167, 27);
            Model.TabIndex = 4;
            // 
            // Breaking
            // 
            Breaking.Location = new Point(10, 268);
            Breaking.Margin = new Padding(2);
            Breaking.Name = "Breaking";
            Breaking.Size = new Size(167, 27);
            Breaking.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(10, 319);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(166, 27);
            button1.TabIndex = 7;
            button1.Text = "Создать заявку";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 1);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 8;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 50);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 9;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 96);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 10;
            label3.Text = "Номер телефона";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 146);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 11;
            label4.Text = "Почта";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 196);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 12;
            label5.Text = "Модель";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 246);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 13;
            label6.Text = "Поломка";
            // 
            // button2
            // 
            button2.Location = new Point(321, 319);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(166, 27);
            button2.TabIndex = 14;
            button2.Text = "Назад";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MakeTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 361);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(Breaking);
            Controls.Add(Model);
            Controls.Add(Post);
            Controls.Add(PhoneNumber);
            Controls.Add(LastName);
            Controls.Add(Name);
            Margin = new Padding(2);
            //Name = "MakeTicket";
            Text = "MakeTicket";
            Load += MakeTicket_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Name;
        private TextBox LastName;
        private TextBox PhoneNumber;
        private TextBox Post;
        private TextBox Model;
        private TextBox Breaking;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
    }
}