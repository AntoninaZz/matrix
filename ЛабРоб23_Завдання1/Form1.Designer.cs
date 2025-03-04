namespace ЛабРоб23_Завдання1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeader1 = new System.Windows.Forms.Label();
            this.lblHeader2 = new System.Windows.Forms.Label();
            this.nudRow = new System.Windows.Forms.NumericUpDown();
            this.nudCol = new System.Windows.Forms.NumericUpDown();
            this.grpbVariant = new System.Windows.Forms.GroupBox();
            this.rbFormula = new System.Windows.Forms.RadioButton();
            this.rbHand = new System.Windows.Forms.RadioButton();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.btnCreateMatrix = new System.Windows.Forms.Button();
            this.dgvMatrix = new System.Windows.Forms.DataGridView();
            this.btnCreateVector = new System.Windows.Forms.Button();
            this.dgvVector = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.створитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.довідкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.інформаціяПроАвтораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.інформаціяПроПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCalculateU = new System.Windows.Forms.Button();
            this.lblHeader3 = new System.Windows.Forms.Label();
            this.lblU = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDescription1 = new System.Windows.Forms.Label();
            this.lblDescription2 = new System.Windows.Forms.Label();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCol)).BeginInit();
            this.grpbVariant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVector)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader1
            // 
            this.lblHeader1.AutoSize = true;
            this.lblHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeader1.Location = new System.Drawing.Point(36, 62);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(147, 20);
            this.lblHeader1.TabIndex = 0;
            this.lblHeader1.Text = "Кількість рядків";
            // 
            // lblHeader2
            // 
            this.lblHeader2.AutoSize = true;
            this.lblHeader2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeader2.Location = new System.Drawing.Point(36, 102);
            this.lblHeader2.Name = "lblHeader2";
            this.lblHeader2.Size = new System.Drawing.Size(165, 20);
            this.lblHeader2.TabIndex = 1;
            this.lblHeader2.Text = "Кількість стовпців";
            // 
            // nudRow
            // 
            this.nudRow.Location = new System.Drawing.Point(222, 60);
            this.nudRow.Name = "nudRow";
            this.nudRow.Size = new System.Drawing.Size(73, 26);
            this.nudRow.TabIndex = 2;
            this.nudRow.ValueChanged += new System.EventHandler(this.nudRow_ValueChanged);
            // 
            // nudCol
            // 
            this.nudCol.Location = new System.Drawing.Point(222, 100);
            this.nudCol.Name = "nudCol";
            this.nudCol.Size = new System.Drawing.Size(73, 26);
            this.nudCol.TabIndex = 3;
            this.nudCol.ValueChanged += new System.EventHandler(this.nudCol_ValueChanged);
            // 
            // grpbVariant
            // 
            this.grpbVariant.Controls.Add(this.rbFormula);
            this.grpbVariant.Controls.Add(this.rbHand);
            this.grpbVariant.Controls.Add(this.rbRandom);
            this.grpbVariant.Location = new System.Drawing.Point(320, 39);
            this.grpbVariant.Name = "grpbVariant";
            this.grpbVariant.Size = new System.Drawing.Size(334, 122);
            this.grpbVariant.TabIndex = 4;
            this.grpbVariant.TabStop = false;
            this.grpbVariant.Text = "Варіант формування елементів матриці";
            // 
            // rbFormula
            // 
            this.rbFormula.AutoSize = true;
            this.rbFormula.Location = new System.Drawing.Point(16, 92);
            this.rbFormula.Name = "rbFormula";
            this.rbFormula.Size = new System.Drawing.Size(140, 24);
            this.rbFormula.TabIndex = 2;
            this.rbFormula.TabStop = true;
            this.rbFormula.Text = "За формулою";
            this.rbFormula.UseVisualStyleBackColor = true;
            // 
            // rbHand
            // 
            this.rbHand.AutoSize = true;
            this.rbHand.Location = new System.Drawing.Point(16, 62);
            this.rbHand.Name = "rbHand";
            this.rbHand.Size = new System.Drawing.Size(86, 24);
            this.rbHand.TabIndex = 1;
            this.rbHand.TabStop = true;
            this.rbHand.Text = "Вручну";
            this.rbHand.UseVisualStyleBackColor = true;
            // 
            // rbRandom
            // 
            this.rbRandom.AutoSize = true;
            this.rbRandom.Checked = true;
            this.rbRandom.Location = new System.Drawing.Point(16, 33);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(118, 24);
            this.rbRandom.TabIndex = 0;
            this.rbRandom.TabStop = true;
            this.rbRandom.Text = "Випадково";
            this.rbRandom.UseVisualStyleBackColor = true;
            // 
            // btnCreateMatrix
            // 
            this.btnCreateMatrix.Location = new System.Drawing.Point(677, 39);
            this.btnCreateMatrix.Name = "btnCreateMatrix";
            this.btnCreateMatrix.Size = new System.Drawing.Size(189, 38);
            this.btnCreateMatrix.TabIndex = 5;
            this.btnCreateMatrix.Text = "Створити матрицю";
            this.btnCreateMatrix.UseVisualStyleBackColor = true;
            this.btnCreateMatrix.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dgvMatrix
            // 
            this.dgvMatrix.AllowUserToAddRows = false;
            this.dgvMatrix.AllowUserToDeleteRows = false;
            this.dgvMatrix.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvMatrix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrix.GridColor = System.Drawing.Color.Turquoise;
            this.dgvMatrix.Location = new System.Drawing.Point(40, 186);
            this.dgvMatrix.Name = "dgvMatrix";
            this.dgvMatrix.RowHeadersWidth = 62;
            this.dgvMatrix.RowTemplate.Height = 28;
            this.dgvMatrix.Size = new System.Drawing.Size(826, 267);
            this.dgvMatrix.TabIndex = 6;
            this.dgvMatrix.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvMatrix_EditingControlShowing);
            // 
            // btnCreateVector
            // 
            this.btnCreateVector.Location = new System.Drawing.Point(677, 83);
            this.btnCreateVector.Name = "btnCreateVector";
            this.btnCreateVector.Size = new System.Drawing.Size(189, 38);
            this.btnCreateVector.TabIndex = 7;
            this.btnCreateVector.Text = "Створити вектор";
            this.btnCreateVector.UseVisualStyleBackColor = true;
            this.btnCreateVector.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // dgvVector
            // 
            this.dgvVector.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvVector.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVector.GridColor = System.Drawing.Color.Turquoise;
            this.dgvVector.Location = new System.Drawing.Point(40, 517);
            this.dgvVector.Name = "dgvVector";
            this.dgvVector.RowHeadersWidth = 62;
            this.dgvVector.RowTemplate.Height = 28;
            this.dgvVector.Size = new System.Drawing.Size(826, 85);
            this.dgvVector.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.створитиToolStripMenuItem,
            this.довідкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 33);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вихідToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(156, 34);
            this.вихідToolStripMenuItem.Text = "В&ихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // створитиToolStripMenuItem
            // 
            this.створитиToolStripMenuItem.Name = "створитиToolStripMenuItem";
            this.створитиToolStripMenuItem.Size = new System.Drawing.Size(186, 29);
            this.створитиToolStripMenuItem.Text = "&Створити матрицю";
            this.створитиToolStripMenuItem.Click += new System.EventHandler(this.створитиToolStripMenuItem_Click);
            // 
            // довідкаToolStripMenuItem
            // 
            this.довідкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.інформаціяПроАвтораToolStripMenuItem,
            this.інформаціяПроПрограмуToolStripMenuItem});
            this.довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            this.довідкаToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.довідкаToolStripMenuItem.Text = "&Довідка";
            // 
            // інформаціяПроАвтораToolStripMenuItem
            // 
            this.інформаціяПроАвтораToolStripMenuItem.Name = "інформаціяПроАвтораToolStripMenuItem";
            this.інформаціяПроАвтораToolStripMenuItem.Size = new System.Drawing.Size(332, 34);
            this.інформаціяПроАвтораToolStripMenuItem.Text = "Інформація про автора";
            this.інформаціяПроАвтораToolStripMenuItem.Click += new System.EventHandler(this.інформаціяПроАвтораToolStripMenuItem_Click);
            // 
            // інформаціяПроПрограмуToolStripMenuItem
            // 
            this.інформаціяПроПрограмуToolStripMenuItem.Name = "інформаціяПроПрограмуToolStripMenuItem";
            this.інформаціяПроПрограмуToolStripMenuItem.Size = new System.Drawing.Size(332, 34);
            this.інформаціяПроПрограмуToolStripMenuItem.Text = "Інформація про програму";
            this.інформаціяПроПрограмуToolStripMenuItem.Click += new System.EventHandler(this.інформаціяПроПрограмуToolStripMenuItem_Click);
            // 
            // btnCalculateU
            // 
            this.btnCalculateU.Location = new System.Drawing.Point(677, 127);
            this.btnCalculateU.Name = "btnCalculateU";
            this.btnCalculateU.Size = new System.Drawing.Size(189, 37);
            this.btnCalculateU.TabIndex = 10;
            this.btnCalculateU.Text = "Обчислити функцію";
            this.btnCalculateU.UseVisualStyleBackColor = true;
            this.btnCalculateU.Click += new System.EventHandler(this.btnCalculateU_Click);
            // 
            // lblHeader3
            // 
            this.lblHeader3.AutoSize = true;
            this.lblHeader3.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeader3.Location = new System.Drawing.Point(36, 636);
            this.lblHeader3.Name = "lblHeader3";
            this.lblHeader3.Size = new System.Drawing.Size(40, 22);
            this.lblHeader3.TabIndex = 11;
            this.lblHeader3.Text = "U =";
            // 
            // lblU
            // 
            this.lblU.AutoSize = true;
            this.lblU.Font = new System.Drawing.Font("Book Antiqua", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblU.Location = new System.Drawing.Point(82, 632);
            this.lblU.Name = "lblU";
            this.lblU.Size = new System.Drawing.Size(23, 27);
            this.lblU.TabIndex = 12;
            this.lblU.Text = "0";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(746, 629);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 37);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "&Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDescription1
            // 
            this.lblDescription1.AutoSize = true;
            this.lblDescription1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescription1.Location = new System.Drawing.Point(36, 474);
            this.lblDescription1.Name = "lblDescription1";
            this.lblDescription1.Size = new System.Drawing.Size(828, 20);
            this.lblDescription1.TabIndex = 14;
            this.lblDescription1.Text = "За вектор X взяти перший  за порядком рядок матриці, який  містить не більш ніж д" +
    "ва додатних елемента.";
            // 
            // lblDescription2
            // 
            this.lblDescription2.AutoSize = true;
            this.lblDescription2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescription2.Location = new System.Drawing.Point(36, 494);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(537, 20);
            this.lblDescription2.TabIndex = 15;
            this.lblDescription2.Text = "Якщо такого рядку немає, тоді за вектор X взяти останній  стовпчик.";
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(620, 629);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(120, 37);
            this.btnOutput.TabIndex = 17;
            this.btnOutput.Text = "Зберегти";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(494, 629);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 37);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(907, 691);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.lblDescription2);
            this.Controls.Add(this.lblDescription1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblU);
            this.Controls.Add(this.lblHeader3);
            this.Controls.Add(this.btnCalculateU);
            this.Controls.Add(this.dgvVector);
            this.Controls.Add(this.btnCreateVector);
            this.Controls.Add(this.dgvMatrix);
            this.Controls.Add(this.btnCreateMatrix);
            this.Controls.Add(this.grpbVariant);
            this.Controls.Add(this.nudCol);
            this.Controls.Add(this.nudRow);
            this.Controls.Add(this.lblHeader2);
            this.Controls.Add(this.lblHeader1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Курсова робота";
            ((System.ComponentModel.ISupportInitialize)(this.nudRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCol)).EndInit();
            this.grpbVariant.ResumeLayout(false);
            this.grpbVariant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVector)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader1;
        private System.Windows.Forms.Label lblHeader2;
        private System.Windows.Forms.NumericUpDown nudRow;
        private System.Windows.Forms.NumericUpDown nudCol;
        private System.Windows.Forms.GroupBox grpbVariant;
        private System.Windows.Forms.RadioButton rbHand;
        private System.Windows.Forms.RadioButton rbRandom;
        private System.Windows.Forms.Button btnCreateMatrix;
        private System.Windows.Forms.DataGridView dgvMatrix;
        private System.Windows.Forms.Button btnCreateVector;
        private System.Windows.Forms.DataGridView dgvVector;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem створитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem інформаціяПроАвтораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem інформаціяПроПрограмуToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbFormula;
        private System.Windows.Forms.Button btnCalculateU;
        private System.Windows.Forms.Label lblHeader3;
        private System.Windows.Forms.Label lblU;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDescription1;
        private System.Windows.Forms.Label lblDescription2;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnClear;
    }
}

