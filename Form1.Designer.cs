namespace MathGame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.labe = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmRownd = new System.Windows.Forms.NumericUpDown();
            this.nmTimeGame = new System.Windows.Forms.NumericUpDown();
            this.comOpretore = new System.Windows.Forms.ComboBox();
            this.comLivel = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmRownd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTimeGame)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnStartGame);
            this.panel1.Controls.Add(this.labe);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nmRownd);
            this.panel1.Controls.Add(this.nmTimeGame);
            this.panel1.Controls.Add(this.comOpretore);
            this.panel1.Controls.Add(this.comLivel);
            this.panel1.Location = new System.Drawing.Point(106, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 354);
            this.panel1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(273, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "ثانية";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "تهيئة اللعبة";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(131, 261);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(105, 31);
            this.btnStartGame.TabIndex = 23;
            this.btnStartGame.Text = "بدا اللعب";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe.Location = new System.Drawing.Point(38, 73);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(64, 16);
            this.labe.TabIndex = 22;
            this.labe.Text = "المستوى";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "وفت انتهاء اللعب";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "عدد الجولات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "اختيار العمليات";
            // 
            // nmRownd
            // 
            this.nmRownd.Location = new System.Drawing.Point(147, 154);
            this.nmRownd.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmRownd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmRownd.Name = "nmRownd";
            this.nmRownd.Size = new System.Drawing.Size(120, 20);
            this.nmRownd.TabIndex = 16;
            this.nmRownd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmTimeGame
            // 
            this.nmTimeGame.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmTimeGame.Location = new System.Drawing.Point(147, 198);
            this.nmTimeGame.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nmTimeGame.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nmTimeGame.Name = "nmTimeGame";
            this.nmTimeGame.Size = new System.Drawing.Size(120, 20);
            this.nmTimeGame.TabIndex = 15;
            this.nmTimeGame.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nmTimeGame.ValueChanged += new System.EventHandler(this.nmTimeGame_ValueChanged);
            // 
            // comOpretore
            // 
            this.comOpretore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comOpretore.FormattingEnabled = true;
            this.comOpretore.Items.AddRange(new object[] {
            "جمع ",
            "طرح",
            "ضرب",
            "قسمة",
            "mix"});
            this.comOpretore.Location = new System.Drawing.Point(147, 113);
            this.comOpretore.Name = "comOpretore";
            this.comOpretore.Size = new System.Drawing.Size(121, 21);
            this.comOpretore.TabIndex = 13;
            // 
            // comLivel
            // 
            this.comLivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comLivel.FormattingEnabled = true;
            this.comLivel.Items.AddRange(new object[] {
            "عالي",
            "متوسط",
            "منخفض",
            "خلط"});
            this.comLivel.Location = new System.Drawing.Point(147, 72);
            this.comLivel.Name = "comLivel";
            this.comLivel.Size = new System.Drawing.Size(121, 21);
            this.comLivel.TabIndex = 12;
            this.comLivel.SelectedIndexChanged += new System.EventHandler(this.comLivel_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmRownd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTimeGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmRownd;
        private System.Windows.Forms.NumericUpDown nmTimeGame;
        private System.Windows.Forms.ComboBox comOpretore;
        private System.Windows.Forms.ComboBox comLivel;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}

