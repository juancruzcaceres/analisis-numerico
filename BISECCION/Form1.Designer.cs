﻿namespace BISECCION
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.raizResult = new System.Windows.Forms.Label();
            this.raizLabel = new System.Windows.Forms.Label();
            this.errorResult = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.iterResult = new System.Windows.Forms.Label();
            this.iterLabel = new System.Windows.Forms.Label();
            this.convergeResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Resultados = new System.Windows.Forms.Label();
            this.iterValue = new System.Windows.Forms.TextBox();
            this.iter = new System.Windows.Forms.Label();
            this.toleValue = new System.Windows.Forms.TextBox();
            this.tolerancia = new System.Windows.Forms.Label();
            this.xdValue = new System.Windows.Forms.TextBox();
            this.xdLabel = new System.Windows.Forms.Label();
            this.xiValue = new System.Windows.Forms.TextBox();
            this.Xi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.functionInput = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.warningLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.warningLabel);
            this.tabPage1.Controls.Add(this.raizResult);
            this.tabPage1.Controls.Add(this.raizLabel);
            this.tabPage1.Controls.Add(this.errorResult);
            this.tabPage1.Controls.Add(this.errorLabel);
            this.tabPage1.Controls.Add(this.iterResult);
            this.tabPage1.Controls.Add(this.iterLabel);
            this.tabPage1.Controls.Add(this.convergeResult);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Resultados);
            this.tabPage1.Controls.Add(this.iterValue);
            this.tabPage1.Controls.Add(this.iter);
            this.tabPage1.Controls.Add(this.toleValue);
            this.tabPage1.Controls.Add(this.tolerancia);
            this.tabPage1.Controls.Add(this.xdValue);
            this.tabPage1.Controls.Add(this.xdLabel);
            this.tabPage1.Controls.Add(this.xiValue);
            this.tabPage1.Controls.Add(this.Xi);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.functionInput);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bisección";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // raizResult
            // 
            this.raizResult.AutoSize = true;
            this.raizResult.Location = new System.Drawing.Point(48, 218);
            this.raizResult.Name = "raizResult";
            this.raizResult.Size = new System.Drawing.Size(0, 13);
            this.raizResult.TabIndex = 19;
            // 
            // raizLabel
            // 
            this.raizLabel.AutoSize = true;
            this.raizLabel.Location = new System.Drawing.Point(8, 218);
            this.raizLabel.Name = "raizLabel";
            this.raizLabel.Size = new System.Drawing.Size(33, 13);
            this.raizLabel.TabIndex = 18;
            this.raizLabel.Text = "Raíz:";
            // 
            // errorResult
            // 
            this.errorResult.AutoSize = true;
            this.errorResult.Location = new System.Drawing.Point(76, 191);
            this.errorResult.Name = "errorResult";
            this.errorResult.Size = new System.Drawing.Size(0, 13);
            this.errorResult.TabIndex = 17;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(8, 191);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(69, 13);
            this.errorLabel.TabIndex = 16;
            this.errorLabel.Text = "Error relativo:";
            // 
            // iterResult
            // 
            this.iterResult.AutoSize = true;
            this.iterResult.Location = new System.Drawing.Point(112, 177);
            this.iterResult.Name = "iterResult";
            this.iterResult.Size = new System.Drawing.Size(0, 13);
            this.iterResult.TabIndex = 15;
            // 
            // iterLabel
            // 
            this.iterLabel.AutoSize = true;
            this.iterLabel.Location = new System.Drawing.Point(8, 177);
            this.iterLabel.Name = "iterLabel";
            this.iterLabel.Size = new System.Drawing.Size(104, 13);
            this.iterLabel.TabIndex = 14;
            this.iterLabel.Text = "Cant. de iteraciones:";
            // 
            // convergeResult
            // 
            this.convergeResult.AutoSize = true;
            this.convergeResult.Location = new System.Drawing.Point(73, 164);
            this.convergeResult.Name = "convergeResult";
            this.convergeResult.Size = new System.Drawing.Size(0, 13);
            this.convergeResult.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Converge: ";
            // 
            // Resultados
            // 
            this.Resultados.AutoSize = true;
            this.Resultados.Location = new System.Drawing.Point(8, 138);
            this.Resultados.Name = "Resultados";
            this.Resultados.Size = new System.Drawing.Size(60, 13);
            this.Resultados.TabIndex = 11;
            this.Resultados.Text = "Resultados";
            // 
            // iterValue
            // 
            this.iterValue.Location = new System.Drawing.Point(253, 29);
            this.iterValue.Name = "iterValue";
            this.iterValue.Size = new System.Drawing.Size(100, 20);
            this.iterValue.TabIndex = 10;
            // 
            // iter
            // 
            this.iter.AutoSize = true;
            this.iter.Location = new System.Drawing.Point(165, 32);
            this.iter.Name = "iter";
            this.iter.Size = new System.Drawing.Size(82, 13);
            this.iter.TabIndex = 9;
            this.iter.Text = "Max Iteraciónes";
            // 
            // toleValue
            // 
            this.toleValue.Location = new System.Drawing.Point(253, 6);
            this.toleValue.Name = "toleValue";
            this.toleValue.Size = new System.Drawing.Size(100, 20);
            this.toleValue.TabIndex = 8;
            // 
            // tolerancia
            // 
            this.tolerancia.AutoSize = true;
            this.tolerancia.Location = new System.Drawing.Point(165, 9);
            this.tolerancia.Name = "tolerancia";
            this.tolerancia.Size = new System.Drawing.Size(57, 13);
            this.tolerancia.TabIndex = 7;
            this.tolerancia.Text = "Tolerancia";
            // 
            // xdValue
            // 
            this.xdValue.Location = new System.Drawing.Point(33, 52);
            this.xdValue.Name = "xdValue";
            this.xdValue.Size = new System.Drawing.Size(100, 20);
            this.xdValue.TabIndex = 6;
            // 
            // xdLabel
            // 
            this.xdLabel.AutoSize = true;
            this.xdLabel.Location = new System.Drawing.Point(3, 55);
            this.xdLabel.Name = "xdLabel";
            this.xdLabel.Size = new System.Drawing.Size(20, 13);
            this.xdLabel.TabIndex = 5;
            this.xdLabel.Text = "Xd";
            // 
            // xiValue
            // 
            this.xiValue.Location = new System.Drawing.Point(33, 29);
            this.xiValue.Name = "xiValue";
            this.xiValue.Size = new System.Drawing.Size(100, 20);
            this.xiValue.TabIndex = 4;
            // 
            // Xi
            // 
            this.Xi.AutoSize = true;
            this.Xi.Location = new System.Drawing.Point(3, 32);
            this.Xi.Name = "Xi";
            this.Xi.Size = new System.Drawing.Size(16, 13);
            this.Xi.TabIndex = 3;
            this.Xi.Text = "Xi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "F(x)";
            // 
            // functionInput
            // 
            this.functionInput.Location = new System.Drawing.Point(33, 6);
            this.functionInput.Name = "functionInput";
            this.functionInput.Size = new System.Drawing.Size(100, 20);
            this.functionInput.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(11, 96);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 13);
            this.warningLabel.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Resultados;
        private System.Windows.Forms.TextBox iterValue;
        private System.Windows.Forms.Label iter;
        private System.Windows.Forms.TextBox toleValue;
        private System.Windows.Forms.Label tolerancia;
        private System.Windows.Forms.TextBox xdValue;
        private System.Windows.Forms.Label xdLabel;
        private System.Windows.Forms.TextBox xiValue;
        private System.Windows.Forms.Label Xi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox functionInput;
        private System.Windows.Forms.Label raizLabel;
        private System.Windows.Forms.Label errorResult;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label iterResult;
        private System.Windows.Forms.Label iterLabel;
        private System.Windows.Forms.Label convergeResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label raizResult;
        private System.Windows.Forms.Label warningLabel;
    }
}
