
namespace MatrixMultiplication
{
    partial class MatrixMultiplication
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
            this.dgvMatrixA = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbN = new System.Windows.Forms.TextBox();
            this.dgvMatrixB = new System.Windows.Forms.DataGridView();
            this.dgvMatrixC = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnMultParCSOpt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMultParCannonOther = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbProc = new System.Windows.Forms.TextBox();
            this.btnMultParCannon = new System.Windows.Forms.Button();
            this.btnCannonMultiplication = new System.Windows.Forms.Button();
            this.btnCreateTestMatrix = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btrnCannonNonCreate = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixC)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMatrixA
            // 
            this.dgvMatrixA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrixA.Location = new System.Drawing.Point(39, 46);
            this.dgvMatrixA.Name = "dgvMatrixA";
            this.dgvMatrixA.Size = new System.Drawing.Size(343, 346);
            this.dgvMatrixA.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(39, 456);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "N";
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(39, 430);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(100, 20);
            this.tbN.TabIndex = 3;
            this.tbN.Text = "4";
            // 
            // dgvMatrixB
            // 
            this.dgvMatrixB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrixB.Location = new System.Drawing.Point(430, 46);
            this.dgvMatrixB.Name = "dgvMatrixB";
            this.dgvMatrixB.Size = new System.Drawing.Size(343, 346);
            this.dgvMatrixB.TabIndex = 4;
            // 
            // dgvMatrixC
            // 
            this.dgvMatrixC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrixC.Location = new System.Drawing.Point(818, 46);
            this.dgvMatrixC.Name = "dgvMatrixC";
            this.dgvMatrixC.Size = new System.Drawing.Size(343, 346);
            this.dgvMatrixC.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(815, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "C";
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(132, 456);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(84, 23);
            this.btnMultiplication.TabIndex = 9;
            this.btnMultiplication.Text = "Multiplication";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(145, 433);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 13);
            this.lblTime.TabIndex = 10;
            // 
            // btnMultParCSOpt
            // 
            this.btnMultParCSOpt.Location = new System.Drawing.Point(13, 40);
            this.btnMultParCSOpt.Name = "btnMultParCSOpt";
            this.btnMultParCSOpt.Size = new System.Drawing.Size(182, 23);
            this.btnMultParCSOpt.TabIndex = 11;
            this.btnMultParCSOpt.Text = "Multiplication with C# optimization";
            this.btnMultParCSOpt.UseVisualStyleBackColor = true;
            this.btnMultParCSOpt.Click += new System.EventHandler(this.btnMultParCSOpt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Parallel";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnMultParCannonOther);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbProc);
            this.panel1.Controls.Add(this.btnMultParCannon);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnMultParCSOpt);
            this.panel1.Location = new System.Drawing.Point(350, 414);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 94);
            this.panel1.TabIndex = 13;
            // 
            // btnMultParCannonOther
            // 
            this.btnMultParCannonOther.Location = new System.Drawing.Point(201, 66);
            this.btnMultParCannonOther.Name = "btnMultParCannonOther";
            this.btnMultParCannonOther.Size = new System.Drawing.Size(146, 23);
            this.btnMultParCannonOther.TabIndex = 18;
            this.btnMultParCannonOther.Text = "Multiplication Cannon Other";
            this.btnMultParCannonOther.UseVisualStyleBackColor = true;
            this.btnMultParCannonOther.Click += new System.EventHandler(this.btnMultParCannonOther_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "PxP";
            // 
            // tbProc
            // 
            this.tbProc.Location = new System.Drawing.Point(353, 41);
            this.tbProc.Name = "tbProc";
            this.tbProc.Size = new System.Drawing.Size(37, 20);
            this.tbProc.TabIndex = 14;
            this.tbProc.Text = "12";
            this.tbProc.TextChanged += new System.EventHandler(this.tbProc_TextChanged);
            // 
            // btnMultParCannon
            // 
            this.btnMultParCannon.Location = new System.Drawing.Point(201, 40);
            this.btnMultParCannon.Name = "btnMultParCannon";
            this.btnMultParCannon.Size = new System.Drawing.Size(146, 23);
            this.btnMultParCannon.TabIndex = 13;
            this.btnMultParCannon.Text = "Multiplication Cannon";
            this.btnMultParCannon.UseVisualStyleBackColor = true;
            this.btnMultParCannon.Click += new System.EventHandler(this.btnMultParCannon_Click);
            // 
            // btnCannonMultiplication
            // 
            this.btnCannonMultiplication.Location = new System.Drawing.Point(222, 456);
            this.btnCannonMultiplication.Name = "btnCannonMultiplication";
            this.btnCannonMultiplication.Size = new System.Drawing.Size(122, 23);
            this.btnCannonMultiplication.TabIndex = 13;
            this.btnCannonMultiplication.Text = "Multiplication Cannon";
            this.btnCannonMultiplication.UseVisualStyleBackColor = true;
            this.btnCannonMultiplication.Click += new System.EventHandler(this.btnCannonMultiplication_Click);
            // 
            // btnCreateTestMatrix
            // 
            this.btnCreateTestMatrix.Location = new System.Drawing.Point(39, 547);
            this.btnCreateTestMatrix.Name = "btnCreateTestMatrix";
            this.btnCreateTestMatrix.Size = new System.Drawing.Size(75, 23);
            this.btnCreateTestMatrix.TabIndex = 14;
            this.btnCreateTestMatrix.Text = "Test matrix";
            this.btnCreateTestMatrix.UseVisualStyleBackColor = true;
            this.btnCreateTestMatrix.Click += new System.EventHandler(this.btnCreateTestMatrix_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 520);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Test for matrix 4x4";
            // 
            // btrnCannonNonCreate
            // 
            this.btrnCannonNonCreate.Location = new System.Drawing.Point(222, 485);
            this.btrnCannonNonCreate.Name = "btrnCannonNonCreate";
            this.btrnCannonNonCreate.Size = new System.Drawing.Size(122, 23);
            this.btrnCannonNonCreate.TabIndex = 16;
            this.btrnCannonNonCreate.Text = "Cannon non create";
            this.btrnCannonNonCreate.UseVisualStyleBackColor = true;
            this.btrnCannonNonCreate.Click += new System.EventHandler(this.btrnCannonNonCreate_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(39, 485);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 17;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // MatrixMultiplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 657);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btrnCannonNonCreate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCannonMultiplication);
            this.Controls.Add(this.btnCreateTestMatrix);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMatrixC);
            this.Controls.Add(this.dgvMatrixB);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgvMatrixA);
            this.Name = "MatrixMultiplication";
            this.Text = "Matrix Multiplication";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatrixA;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.DataGridView dgvMatrixB;
        private System.Windows.Forms.DataGridView dgvMatrixC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnMultParCSOpt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCannonMultiplication;
        private System.Windows.Forms.Button btnCreateTestMatrix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btrnCannonNonCreate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbProc;
        private System.Windows.Forms.Button btnMultParCannon;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnMultParCannonOther;
    }
}

