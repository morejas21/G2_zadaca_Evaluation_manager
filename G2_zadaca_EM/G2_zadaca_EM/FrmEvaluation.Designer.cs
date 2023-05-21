namespace G2_zadaca_EM
{
    partial class FrmEvaluation
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
            this.lblActivities = new System.Windows.Forms.Label();
            this.cboActivities = new System.Windows.Forms.ComboBox();
            this.lblMinForSignature = new System.Windows.Forms.Label();
            this.lblMinForGrade = new System.Windows.Forms.Label();
            this.txtMinForSignature = new System.Windows.Forms.TextBox();
            this.txtMinForGrade = new System.Windows.Forms.TextBox();
            this.txtActivityDescription = new System.Windows.Forms.TextBox();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.txtEvaluationDate = new System.Windows.Forms.TextBox();
            this.numPoints = new System.Windows.Forms.NumericUpDown();
            this.lblEvaluationDate = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // lblActivities
            // 
            this.lblActivities.AutoSize = true;
            this.lblActivities.Location = new System.Drawing.Point(121, 16);
            this.lblActivities.Name = "lblActivities";
            this.lblActivities.Size = new System.Drawing.Size(54, 13);
            this.lblActivities.TabIndex = 0;
            this.lblActivities.Text = "Aktivnost:";
            // 
            // cboActivities
            // 
            this.cboActivities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActivities.FormattingEnabled = true;
            this.cboActivities.Location = new System.Drawing.Point(46, 32);
            this.cboActivities.Name = "cboActivities";
            this.cboActivities.Size = new System.Drawing.Size(208, 21);
            this.cboActivities.TabIndex = 1;
            // 
            // lblMinForSignature
            // 
            this.lblMinForSignature.AutoSize = true;
            this.lblMinForSignature.Location = new System.Drawing.Point(306, 16);
            this.lblMinForSignature.Name = "lblMinForSignature";
            this.lblMinForSignature.Size = new System.Drawing.Size(80, 13);
            this.lblMinForSignature.TabIndex = 2;
            this.lblMinForSignature.Text = "Uvjet za potpis:";
            // 
            // lblMinForGrade
            // 
            this.lblMinForGrade.AutoSize = true;
            this.lblMinForGrade.Location = new System.Drawing.Point(462, 16);
            this.lblMinForGrade.Name = "lblMinForGrade";
            this.lblMinForGrade.Size = new System.Drawing.Size(84, 13);
            this.lblMinForGrade.TabIndex = 3;
            this.lblMinForGrade.Text = "Uvjet za ocjenu:";
            // 
            // txtMinForSignature
            // 
            this.txtMinForSignature.Location = new System.Drawing.Point(260, 32);
            this.txtMinForSignature.Name = "txtMinForSignature";
            this.txtMinForSignature.ReadOnly = true;
            this.txtMinForSignature.Size = new System.Drawing.Size(161, 20);
            this.txtMinForSignature.TabIndex = 4;
            // 
            // txtMinForGrade
            // 
            this.txtMinForGrade.Location = new System.Drawing.Point(427, 32);
            this.txtMinForGrade.Name = "txtMinForGrade";
            this.txtMinForGrade.ReadOnly = true;
            this.txtMinForGrade.Size = new System.Drawing.Size(154, 20);
            this.txtMinForGrade.TabIndex = 5;
            // 
            // txtActivityDescription
            // 
            this.txtActivityDescription.Location = new System.Drawing.Point(46, 68);
            this.txtActivityDescription.Multiline = true;
            this.txtActivityDescription.Name = "txtActivityDescription";
            this.txtActivityDescription.ReadOnly = true;
            this.txtActivityDescription.Size = new System.Drawing.Size(535, 122);
            this.txtActivityDescription.TabIndex = 6;
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(269, 204);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(57, 13);
            this.lblTeacher.TabIndex = 7;
            this.lblTeacher.Text = "Ocjenjivač";
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(233, 220);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.ReadOnly = true;
            this.txtTeacher.Size = new System.Drawing.Size(124, 20);
            this.txtTeacher.TabIndex = 8;
            // 
            // txtEvaluationDate
            // 
            this.txtEvaluationDate.Location = new System.Drawing.Point(363, 220);
            this.txtEvaluationDate.Name = "txtEvaluationDate";
            this.txtEvaluationDate.ReadOnly = true;
            this.txtEvaluationDate.Size = new System.Drawing.Size(124, 20);
            this.txtEvaluationDate.TabIndex = 9;
            // 
            // numPoints
            // 
            this.numPoints.Location = new System.Drawing.Point(493, 220);
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(88, 20);
            this.numPoints.TabIndex = 10;
            // 
            // lblEvaluationDate
            // 
            this.lblEvaluationDate.AutoSize = true;
            this.lblEvaluationDate.Location = new System.Drawing.Point(375, 204);
            this.lblEvaluationDate.Name = "lblEvaluationDate";
            this.lblEvaluationDate.Size = new System.Drawing.Size(92, 13);
            this.lblEvaluationDate.TabIndex = 11;
            this.lblEvaluationDate.Text = "Datum evaluacije:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(363, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 38);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(477, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 38);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(515, 204);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(43, 13);
            this.lblPoints.TabIndex = 14;
            this.lblPoints.Text = "Bodovi:";
            // 
            // FrmEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 316);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblEvaluationDate);
            this.Controls.Add(this.numPoints);
            this.Controls.Add(this.txtEvaluationDate);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.txtActivityDescription);
            this.Controls.Add(this.txtMinForGrade);
            this.Controls.Add(this.txtMinForSignature);
            this.Controls.Add(this.lblMinForGrade);
            this.Controls.Add(this.lblMinForSignature);
            this.Controls.Add(this.cboActivities);
            this.Controls.Add(this.lblActivities);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEvaluation";
            this.Text = "FrmEvaluation";
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActivities;
        private System.Windows.Forms.ComboBox cboActivities;
        private System.Windows.Forms.Label lblMinForSignature;
        private System.Windows.Forms.Label lblMinForGrade;
        private System.Windows.Forms.TextBox txtMinForSignature;
        private System.Windows.Forms.TextBox txtMinForGrade;
        private System.Windows.Forms.TextBox txtActivityDescription;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.TextBox txtEvaluationDate;
        private System.Windows.Forms.NumericUpDown numPoints;
        private System.Windows.Forms.Label lblEvaluationDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPoints;
    }
}