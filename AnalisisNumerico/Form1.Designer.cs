namespace AnalisisNumerico
{
    partial class AnalisisNumerico
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
            this.secanteBtn = new System.Windows.Forms.Button();
            this.newtonBtn = new System.Windows.Forms.Button();
            this.reglafalsaBtn = new System.Windows.Forms.Button();
            this.biseccionBtn = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.resultadoSeidel = new System.Windows.Forms.Label();
            this.calcularBtn = new System.Windows.Forms.Button();
            this.tipoCombobox = new System.Windows.Forms.ComboBox();
            this.generarBtn = new System.Windows.Forms.Button();
            this.dimensionValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iteracResult = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1306, 686);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.secanteBtn);
            this.tabPage1.Controls.Add(this.newtonBtn);
            this.tabPage1.Controls.Add(this.reglafalsaBtn);
            this.tabPage1.Controls.Add(this.biseccionBtn);
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
            this.tabPage1.Size = new System.Drawing.Size(1298, 660);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "UNIDAD 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // secanteBtn
            // 
            this.secanteBtn.Location = new System.Drawing.Point(351, 154);
            this.secanteBtn.Name = "secanteBtn";
            this.secanteBtn.Size = new System.Drawing.Size(75, 23);
            this.secanteBtn.TabIndex = 24;
            this.secanteBtn.Text = "SECANTE";
            this.secanteBtn.UseVisualStyleBackColor = true;
            this.secanteBtn.Click += new System.EventHandler(this.secanteBtn_Click);
            // 
            // newtonBtn
            // 
            this.newtonBtn.Location = new System.Drawing.Point(209, 154);
            this.newtonBtn.Name = "newtonBtn";
            this.newtonBtn.Size = new System.Drawing.Size(123, 23);
            this.newtonBtn.TabIndex = 23;
            this.newtonBtn.Text = "NEWTON-RAPHSON";
            this.newtonBtn.UseVisualStyleBackColor = true;
            this.newtonBtn.Click += new System.EventHandler(this.newtonBtn_Click);
            // 
            // reglafalsaBtn
            // 
            this.reglafalsaBtn.Location = new System.Drawing.Point(104, 154);
            this.reglafalsaBtn.Name = "reglafalsaBtn";
            this.reglafalsaBtn.Size = new System.Drawing.Size(90, 23);
            this.reglafalsaBtn.TabIndex = 22;
            this.reglafalsaBtn.Text = "REGLA FALSA";
            this.reglafalsaBtn.UseVisualStyleBackColor = true;
            this.reglafalsaBtn.Click += new System.EventHandler(this.reglafalsaBtn_Click);
            // 
            // biseccionBtn
            // 
            this.biseccionBtn.Location = new System.Drawing.Point(14, 154);
            this.biseccionBtn.Name = "biseccionBtn";
            this.biseccionBtn.Size = new System.Drawing.Size(75, 23);
            this.biseccionBtn.TabIndex = 21;
            this.biseccionBtn.Text = "BISECCIÓN";
            this.biseccionBtn.UseVisualStyleBackColor = true;
            this.biseccionBtn.Click += new System.EventHandler(this.biseccionBtn_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(11, 96);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 13);
            this.warningLabel.TabIndex = 20;
            // 
            // raizResult
            // 
            this.raizResult.AutoSize = true;
            this.raizResult.Location = new System.Drawing.Point(51, 334);
            this.raizResult.Name = "raizResult";
            this.raizResult.Size = new System.Drawing.Size(0, 13);
            this.raizResult.TabIndex = 19;
            // 
            // raizLabel
            // 
            this.raizLabel.AutoSize = true;
            this.raizLabel.Location = new System.Drawing.Point(11, 334);
            this.raizLabel.Name = "raizLabel";
            this.raizLabel.Size = new System.Drawing.Size(33, 13);
            this.raizLabel.TabIndex = 18;
            this.raizLabel.Text = "Raíz:";
            // 
            // errorResult
            // 
            this.errorResult.AutoSize = true;
            this.errorResult.Location = new System.Drawing.Point(79, 307);
            this.errorResult.Name = "errorResult";
            this.errorResult.Size = new System.Drawing.Size(0, 13);
            this.errorResult.TabIndex = 17;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(11, 307);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(69, 13);
            this.errorLabel.TabIndex = 16;
            this.errorLabel.Text = "Error relativo:";
            // 
            // iterResult
            // 
            this.iterResult.AutoSize = true;
            this.iterResult.Location = new System.Drawing.Point(115, 293);
            this.iterResult.Name = "iterResult";
            this.iterResult.Size = new System.Drawing.Size(0, 13);
            this.iterResult.TabIndex = 15;
            // 
            // iterLabel
            // 
            this.iterLabel.AutoSize = true;
            this.iterLabel.Location = new System.Drawing.Point(11, 293);
            this.iterLabel.Name = "iterLabel";
            this.iterLabel.Size = new System.Drawing.Size(104, 13);
            this.iterLabel.TabIndex = 14;
            this.iterLabel.Text = "Cant. de iteraciones:";
            // 
            // convergeResult
            // 
            this.convergeResult.AutoSize = true;
            this.convergeResult.Location = new System.Drawing.Point(76, 280);
            this.convergeResult.Name = "convergeResult";
            this.convergeResult.Size = new System.Drawing.Size(0, 13);
            this.convergeResult.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Converge: ";
            // 
            // Resultados
            // 
            this.Resultados.AutoSize = true;
            this.Resultados.Location = new System.Drawing.Point(11, 254);
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
            this.iterValue.Text = "100";
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
            this.toleValue.Text = "0,0001";
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
            this.tabPage2.Controls.Add(this.iteracResult);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.calcularBtn);
            this.tabPage2.Controls.Add(this.resultadoSeidel);
            this.tabPage2.Controls.Add(this.tipoCombobox);
            this.tabPage2.Controls.Add(this.generarBtn);
            this.tabPage2.Controls.Add(this.dimensionValue);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1298, 660);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "UNIDAD 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(10, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 412);
            this.panel1.TabIndex = 5;
            // 
            // resultadoSeidel
            // 
            this.resultadoSeidel.AutoSize = true;
            this.resultadoSeidel.Location = new System.Drawing.Point(82, 496);
            this.resultadoSeidel.Name = "resultadoSeidel";
            this.resultadoSeidel.Size = new System.Drawing.Size(0, 13);
            this.resultadoSeidel.TabIndex = 0;
            // 
            // calcularBtn
            // 
            this.calcularBtn.Location = new System.Drawing.Point(430, 1);
            this.calcularBtn.Name = "calcularBtn";
            this.calcularBtn.Size = new System.Drawing.Size(75, 23);
            this.calcularBtn.TabIndex = 4;
            this.calcularBtn.Text = "CALCULAR";
            this.calcularBtn.UseVisualStyleBackColor = true;
            this.calcularBtn.Click += new System.EventHandler(this.calcularBtn_Click);
            // 
            // tipoCombobox
            // 
            this.tipoCombobox.FormattingEnabled = true;
            this.tipoCombobox.Items.AddRange(new object[] {
            "Gauss-Jordan",
            "Gauss-Seidel"});
            this.tipoCombobox.Location = new System.Drawing.Point(293, 3);
            this.tipoCombobox.Name = "tipoCombobox";
            this.tipoCombobox.Size = new System.Drawing.Size(121, 21);
            this.tipoCombobox.TabIndex = 3;
            // 
            // generarBtn
            // 
            this.generarBtn.Location = new System.Drawing.Point(192, 4);
            this.generarBtn.Name = "generarBtn";
            this.generarBtn.Size = new System.Drawing.Size(75, 23);
            this.generarBtn.TabIndex = 2;
            this.generarBtn.Text = "GENERAR";
            this.generarBtn.UseVisualStyleBackColor = true;
            this.generarBtn.Click += new System.EventHandler(this.generarBtn_Click);
            // 
            // dimensionValue
            // 
            this.dimensionValue.Location = new System.Drawing.Point(85, 4);
            this.dimensionValue.Name = "dimensionValue";
            this.dimensionValue.Size = new System.Drawing.Size(100, 20);
            this.dimensionValue.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "DIMENSION:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Resultado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cantidad de Iteraciones:";
            // 
            // iteracResult
            // 
            this.iteracResult.AutoSize = true;
            this.iteracResult.Location = new System.Drawing.Point(150, 466);
            this.iteracResult.Name = "iteracResult";
            this.iteracResult.Size = new System.Drawing.Size(0, 13);
            this.iteracResult.TabIndex = 3;
            // 
            // AnalisisNumerico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 626);
            this.Controls.Add(this.tabControl1);
            this.Name = "AnalisisNumerico";
            this.Text = "Analisis Numerico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.Windows.Forms.Button biseccionBtn;
        private System.Windows.Forms.Button reglafalsaBtn;
        private System.Windows.Forms.Button secanteBtn;
        private System.Windows.Forms.Button newtonBtn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button calcularBtn;
        private System.Windows.Forms.ComboBox tipoCombobox;
        private System.Windows.Forms.Button generarBtn;
        private System.Windows.Forms.TextBox dimensionValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultadoSeidel;
        private System.Windows.Forms.Label iteracResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

