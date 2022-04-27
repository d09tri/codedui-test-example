namespace GUI
{
    partial class FrmCalculator
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtResullt = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Teal;
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(284, 31);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "SIMPLE CALCULATION";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(12, 12);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(83, 13);
            this.lblNum1.TabIndex = 1;
            this.lblNum1.Text = "The first number";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(121, 35);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(125, 20);
            this.txtNum2.TabIndex = 2;
            this.txtNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum2_KeyPress);
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(12, 38);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(102, 13);
            this.lblNum2.TabIndex = 3;
            this.lblNum2.Text = "The second number";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(121, 9);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(125, 20);
            this.txtNum1.TabIndex = 4;
            this.txtNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum1_KeyPress);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Controls.Add(this.btnAddition);
            this.pnlMain.Controls.Add(this.lblResult);
            this.pnlMain.Controls.Add(this.txtResullt);
            this.pnlMain.Controls.Add(this.lblNum2);
            this.pnlMain.Controls.Add(this.txtNum2);
            this.pnlMain.Controls.Add(this.txtNum1);
            this.pnlMain.Controls.Add(this.lblNum1);
            this.pnlMain.Location = new System.Drawing.Point(17, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(279, 201);
            this.pnlMain.TabIndex = 5;
            // 
            // txtResullt
            // 
            this.txtResullt.Location = new System.Drawing.Point(121, 61);
            this.txtResullt.Name = "txtResullt";
            this.txtResullt.ReadOnly = true;
            this.txtResullt.Size = new System.Drawing.Size(125, 20);
            this.txtResullt.TabIndex = 5;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 64);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Result";
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(39, 118);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(75, 23);
            this.btnAddition.TabIndex = 7;
            this.btnAddition.Text = "Addition";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(121, 118);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 273);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblHeader);
            this.Name = "FrmCalculator";
            this.Text = "FrmCalculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCalculator_FormClosing);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtResullt;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddition;
    }
}