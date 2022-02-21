
namespace WinForms_Films.Veiws
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
            this.groupBoxFilms = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxFilmsGenres2 = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.userControl_ForEntitiesGenres = new WinForms_Films.UserControl_ForEntities();
            this.userControl_ForEntitiesFilms = new WinForms_Films.UserControl_ForEntities();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBoxFilms.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFilms
            // 
            this.groupBoxFilms.Controls.Add(this.groupBox1);
            this.groupBoxFilms.Controls.Add(this.userControl_ForEntitiesGenres);
            this.groupBoxFilms.Controls.Add(this.userControl_ForEntitiesFilms);
            this.groupBoxFilms.Controls.Add(this.listBox1);
            this.groupBoxFilms.Location = new System.Drawing.Point(3, 5);
            this.groupBoxFilms.Name = "groupBoxFilms";
            this.groupBoxFilms.Size = new System.Drawing.Size(706, 501);
            this.groupBoxFilms.TabIndex = 1;
            this.groupBoxFilms.TabStop = false;
            this.groupBoxFilms.Text = "Фильмы";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxFilmsGenres2);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Location = new System.Drawing.Point(9, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 209);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Жанры Фильма";
            // 
            // listBoxFilmsGenres2
            // 
            this.listBoxFilmsGenres2.FormattingEnabled = true;
            this.listBoxFilmsGenres2.ItemHeight = 15;
            this.listBoxFilmsGenres2.Location = new System.Drawing.Point(0, 22);
            this.listBoxFilmsGenres2.Name = "listBoxFilmsGenres2";
            this.listBoxFilmsGenres2.Size = new System.Drawing.Size(212, 154);
            this.listBoxFilmsGenres2.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 180);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Добавить ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(116, 180);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // userControl_ForEntitiesGenres
            // 
            this.userControl_ForEntitiesGenres._GroupBoxName = "Все Жанры";
            this.userControl_ForEntitiesGenres.Location = new System.Drawing.Point(212, 22);
            this.userControl_ForEntitiesGenres.Name = "userControl_ForEntitiesGenres";
            this.userControl_ForEntitiesGenres.Size = new System.Drawing.Size(197, 242);
            this.userControl_ForEntitiesGenres.TabIndex = 8;
            this.userControl_ForEntitiesGenres.Load += new System.EventHandler(this.userControl_ForEntitiesGenres_Load);
            // 
            // userControl_ForEntitiesFilms
            // 
            this.userControl_ForEntitiesFilms._GroupBoxName = "Все Фильмы";
            this.userControl_ForEntitiesFilms.Location = new System.Drawing.Point(9, 22);
            this.userControl_ForEntitiesFilms.Name = "userControl_ForEntitiesFilms";
            this.userControl_ForEntitiesFilms.Size = new System.Drawing.Size(197, 242);
            this.userControl_ForEntitiesFilms.TabIndex = 2;
            this.userControl_ForEntitiesFilms.Load += new System.EventHandler(this.userControl_ForEntities1_Load);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(415, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(283, 139);
            this.listBox1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 552);
            this.Controls.Add(this.groupBoxFilms);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBoxFilms.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxFilms;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBoxFilmsGenres2;
        private UserControl_ForEntities userControl_ForEntitiesFilms;
        private UserControl_ForEntities userControl_ForEntitiesGenres;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}