using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛабРоб23_Завдання1
{
    public partial class Form1 : Form
    {
        //змінні
        int row, col;//розмірність матриці А
        int[,] a;//матриця А
        int[] vector;//вектор
        double U = 0;//функція

        //створення матриці А
        private void CreateMatrix()
        {
            CreateHeaders(row, col);

            //Заповнення таблиці випадковими величинами
            if (rbRandom.Checked)
            {
                Random rand = new Random();
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        dgvMatrix.Rows[i].Cells[j].Value = rand.Next(-10, 10).ToString();
                        dgvMatrix.Rows[i].Cells[j].ReadOnly = true;
                        dgvMatrix.AutoResizeColumn(j);
                    }
                }
            }

            // заповнення таблиці вручну шляхом безпосереднього внесення даних у комірки
            if (rbHand.Checked)
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        dgvMatrix.Rows[i].Cells[j].Value = "";
                        dgvMatrix.Rows[i].Cells[j].ReadOnly = false;
                    }
                }
            }

            //заповнення матриці за формулою
            if(rbFormula.Checked)
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        dgvMatrix.Rows[i].Cells[j].Value = Convert.ToInt32((j - 5.7) * Math.Pow(j + 1.0, -3) * (i - Math.Pow(Math.Abs(j - 7), 4)) * (i + 7.6) * Math.Log(Math.Abs(Math.Tan((i + 1) / 2.0))));
                        dgvMatrix.Rows[i].Cells[j].ReadOnly = true;
                        dgvMatrix.AutoResizeColumn(j);
                    }
                }
            }
        }

        // створення заголовків та необхідної кількості рядків та стовпців у dgvMatrix
        private void CreateHeaders(int row, int col)
        {
            dgvMatrix.ColumnCount = col;
            dgvMatrix.RowCount = row;
            dgvMatrix.TopLeftHeaderCell.Value = "Матриця";

            for (int j = 0; j < col; j++)
            {
                dgvMatrix.Columns[j].HeaderText = "j=" + j;
            }
            for (int i = 0; i < row; i++)
            {
                dgvMatrix.Rows[i].HeaderCell.Value = "i=" + i;
            }

            dgvMatrix.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        //обробка натискання клавіші Створити матрицю
        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateMatrix();
        }

        //обробка зміни кількості рядків
        private void nudRow_ValueChanged(object sender, EventArgs e)
        {
            if(nudRow.Value>0&&nudCol.Value>0)
            {
                col = (int)nudCol.Value;
                row = (int)nudRow.Value;
                a = new int[row, col];
            }
        }

        //обробка зміни кількості стовпців
        private void nudCol_ValueChanged(object sender, EventArgs e)
        {
            if(nudRow.Value>0&&nudCol.Value>0)
            {
                col = (int)nudCol.Value;
                row = (int)nudRow.Value;
                a = new int[row, col];
            }
        }

        //обробка натискання клавіші Створення вектору
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // записуємо в масив дані з комірок dgvMatrix
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    a[i, j] = Convert.ToInt32(dgvMatrix.Rows[i].Cells[j].Value);
                }
            }

            //визначення варіанту формування вектору
            int k = 0, v = -1;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (a[i, j] > 0)
                    {
                        k++;
                    }
                }
                if (k <= 2)
                {
                    v = i;
                    break;
                }
                k = 0;
            }

            //створення вектору
            if (v == -1)
            {
                vector = new int[row];
                for (int i = 0; i < row; i++)
                {
                    vector[i] = a[i, col - 1];
                }
            }
            else
            {
                vector = new int[col];
                for (int j = 0; j < col; j++)
                {
                    vector[j] = a[v, j];
                }
            }

            //виведення елементів вектору за допомогою dgvVector
            dgvVector.ColumnCount = vector.Length;
            dgvVector.RowCount = 1;
            dgvVector.TopLeftHeaderCell.Value = "Вектор";
            for(int i =0; i< dgvVector.ColumnCount; i++)
            {
                dgvVector.Columns[i].HeaderText = "j=" + i;
                dgvVector.Rows[0].Cells[i].Value = vector[i].ToString();
                dgvVector.AutoResizeColumn(i);
            }
            dgvVector.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        //вихід через меню
        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //створення матриці через меню
        private void створитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMatrix();
        }

        //Інформація про автора
        private void інформаціяПроАвтораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t\tІнформація про автора\nПрограма створена з метою навчання\nстуденткою другого курсу спеціальності Комп'ютерні науки\nКиївського університету ім. Бориса Грінченка,\nЗдебською Антоніною, група Інб-1-19-4.0д\n\n\t\t\t\t\t22/11/2020", "Довідка про автора", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Інформація про програму
        private void інформаціяПроПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t\tІнформація про програму\nПрограма курсової роботи створена згідно варіанту 8.\nЗа умовою:\nНеобхідно створити матрицю А (розмірність матриці може задаватися користувачем під час роботи). Елементи матриці можуть бути задані трьома способами: вручну, випадковими величинами, або за формулою відповідно до варіанту 8:\n\na[i,j] = (j – 5,7)(j+1)^-3 ( i - |j-7|^4 ) (i +7,6) ln(|tg((i + 1)/2)|)\n\nНа базі матриці необхідно створити вектор Х за визначеним алгоритмом:\n\nЗа вектор X взяти перший  за порядком рядок матриці, який  містить не більш ніж два додатних елемента. Якщо такого рядку немає, тоді за вектор X взяти останній  стовпчик.\n\nТакож потрібно обчислити значення функції U=f(x):\n\n\t\tU = ∑ 1 / (1 + |xi|),\ti=1,...,n", "Довідка про програму", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //обробка натискання клавіші Вихід
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //обробка натискання клавіші Обчислення функції
        private void btnCalculateU_Click(object sender, EventArgs e)
        {
            //обчислення функції
            for (int i = 0; i < vector.Length; i++)
            {
                U += 1.0 / (1.0 + Math.Abs(vector[i]));
            }

            //виведення функції
            lblU.Text = Convert.ToString(U);
            U = 0;
        }

        //очищення
        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvMatrix.Rows.Clear();
            dgvVector.Rows.Clear();
            lblU.Text = "0";
        }

        //обмеження неправильного вводу
        private void dgvMatrix_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Control_KeyPress);
            e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
        }
        void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)|| e.KeyChar=='-')
            {
                return;
            }
            MessageBox.Show("неправильний символ!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.Handled = true;
        }

        //збереження результатів в файл
        private void btnOutput_Click(object sender, EventArgs e)
        {
            using (StreamWriter file = new StreamWriter("output.txt", false))
            {
                file.WriteLine("Матриця:");
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        file.Write(a[i, j] + "\t");
                    }
                    file.WriteLine();
                }
                file.WriteLine();
                file.WriteLine("Вектор:");
                for (int i = 0; i < vector.Length; i++)
                {
                    file.Write(vector[i] + "\t");
                }
                file.WriteLine();
                file.WriteLine();
                file.WriteLine("Функція: " + lblU.Text);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
