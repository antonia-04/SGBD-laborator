using System.Windows.Forms;

namespace SGBD___laborator_1
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
            this.components = new System.ComponentModel.Container();
            this.labelParent = new System.Windows.Forms.Label();
            this.labelChild = new System.Windows.Forms.Label();
            this.dataGridViewParent = new System.Windows.Forms.DataGridView();
            this.dataGridViewChild = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelIdPublisher = new System.Windows.Forms.Label();
            this.labelIdProvider = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxIdPublisher = new System.Windows.Forms.TextBox();
            this.textBoxIdProvider = new System.Windows.Forms.TextBox();
            this.bsChild = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsChild)).BeginInit();
            this.SuspendLayout();
            // 
            // labelParent
            // 
            this.labelParent.AutoSize = true;
            this.labelParent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParent.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelParent.Location = new System.Drawing.Point(32, 14);
            this.labelParent.Name = "labelParent";
            this.labelParent.Size = new System.Drawing.Size(105, 32);
            this.labelParent.TabIndex = 0;
            this.labelParent.Text = "Authors";
            // 
            // labelChild
            // 
            this.labelChild.AutoSize = true;
            this.labelChild.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChild.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelChild.Location = new System.Drawing.Point(633, 14);
            this.labelChild.Name = "labelChild";
            this.labelChild.Size = new System.Drawing.Size(401, 32);
            this.labelChild.TabIndex = 1;
            this.labelChild.Text = "Books Written by Selected Author";
            // 
            // dataGridViewParent
            // 
            this.dataGridViewParent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParent.Location = new System.Drawing.Point(32, 42);
            this.dataGridViewParent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewParent.Name = "dataGridViewParent";
            this.dataGridViewParent.RowHeadersWidth = 62;
            this.dataGridViewParent.Size = new System.Drawing.Size(558, 351);
            this.dataGridViewParent.TabIndex = 2;
            // 
            // dataGridViewChild
            // 
            this.dataGridViewChild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChild.Location = new System.Drawing.Point(633, 42);
            this.dataGridViewChild.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewChild.Name = "dataGridViewChild";
            this.dataGridViewChild.RowHeadersWidth = 62;
            this.dataGridViewChild.Size = new System.Drawing.Size(748, 407);
            this.dataGridViewChild.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Indigo;
            this.button1.Location = new System.Drawing.Point(407, 434);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reload Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 421);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(84, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Author:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 451);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 26);
            this.textBox1.TabIndex = 6;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.Indigo;
            this.buttonAdd.Location = new System.Drawing.Point(32, 504);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 40);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add Book";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonUpdate.ForeColor = System.Drawing.Color.Indigo;
            this.buttonUpdate.Location = new System.Drawing.Point(32, 550);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(120, 40);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.Indigo;
            this.buttonDelete.Location = new System.Drawing.Point(32, 596);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(120, 40);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.ForeColor = System.Drawing.Color.Indigo;
            this.labelTitle.Location = new System.Drawing.Point(637, 480);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(38, 20);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "Title";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.ForeColor = System.Drawing.Color.Indigo;
            this.labelPrice.Location = new System.Drawing.Point(637, 520);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(44, 20);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Price";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.ForeColor = System.Drawing.Color.Indigo;
            this.labelYear.Location = new System.Drawing.Point(637, 560);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(43, 20);
            this.labelYear.TabIndex = 9;
            this.labelYear.Text = "Year";
            // 
            // labelIdPublisher
            // 
            this.labelIdPublisher.AutoSize = true;
            this.labelIdPublisher.ForeColor = System.Drawing.Color.Indigo;
            this.labelIdPublisher.Location = new System.Drawing.Point(637, 600);
            this.labelIdPublisher.Name = "labelIdPublisher";
            this.labelIdPublisher.Size = new System.Drawing.Size(95, 20);
            this.labelIdPublisher.TabIndex = 10;
            this.labelIdPublisher.Text = "Publisher ID";
            // 
            // labelIdProvider
            // 
            this.labelIdProvider.AutoSize = true;
            this.labelIdProvider.ForeColor = System.Drawing.Color.Indigo;
            this.labelIdProvider.Location = new System.Drawing.Point(637, 640);
            this.labelIdProvider.Name = "labelIdProvider";
            this.labelIdProvider.Size = new System.Drawing.Size(87, 20);
            this.labelIdProvider.TabIndex = 11;
            this.labelIdProvider.Text = "Provider ID";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(737, 480);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(150, 26);
            this.textBoxTitle.TabIndex = 12;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(737, 520);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(150, 26);
            this.textBoxPrice.TabIndex = 13;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(737, 560);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(150, 26);
            this.textBoxYear.TabIndex = 14;
            // 
            // textBoxIdPublisher
            // 
            this.textBoxIdPublisher.Location = new System.Drawing.Point(737, 600);
            this.textBoxIdPublisher.Name = "textBoxIdPublisher";
            this.textBoxIdPublisher.Size = new System.Drawing.Size(150, 26);
            this.textBoxIdPublisher.TabIndex = 15;
            // 
            // textBoxIdProvider
            // 
            this.textBoxIdProvider.Location = new System.Drawing.Point(737, 640);
            this.textBoxIdProvider.Name = "textBoxIdProvider";
            this.textBoxIdProvider.Size = new System.Drawing.Size(150, 26);
            this.textBoxIdProvider.TabIndex = 16;
            // 
            // bsChild
            // 
            this.bsChild.CurrentChanged += new System.EventHandler(this.bsChild_CurrentChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1393, 685);
            this.Controls.Add(this.textBoxIdProvider);
            this.Controls.Add(this.textBoxIdPublisher);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelIdProvider);
            this.Controls.Add(this.labelIdPublisher);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewChild);
            this.Controls.Add(this.dataGridViewParent);
            this.Controls.Add(this.labelChild);
            this.Controls.Add(this.labelParent);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "BookStore";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsChild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelParent;
        private Label labelChild;
        private DataGridView dataGridViewParent;
        private DataGridView dataGridViewChild;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button button2;
        private Button button3;
        private Label labelTitle;
        private Label labelPrice;
        private Label labelYear;
        private Label labelIdPublisher;
        private Label labelIdProvider;
        private TextBox textBoxTitle;
        private TextBox textBoxPrice;
        private TextBox textBoxYear;
        private TextBox textBoxIdPublisher;
        private TextBox textBoxIdProvider;
    }
}
