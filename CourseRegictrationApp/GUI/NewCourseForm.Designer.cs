namespace CourseRegictrationApp.GUI
{
    partial class NewCourseForm
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
            this.grpTeacherName = new System.Windows.Forms.GroupBox();
            this.lblCourseDescription = new System.Windows.Forms.Label();
            this.btnClearCourseForm = new System.Windows.Forms.Button();
            this.txtCourseDescription = new System.Windows.Forms.TextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.txtCourseDuration = new System.Windows.Forms.TextBox();
            this.lblCourseId = new System.Windows.Forms.Label();
            this.lblCourseIdRemark = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.lblCourseDuration = new System.Windows.Forms.Label();
            this.lblCoursePrerequisite = new System.Windows.Forms.Label();
            this.txtCourseId = new System.Windows.Forms.TextBox();
            this.cmbBoxCoursePrerequisiteId = new System.Windows.Forms.ComboBox();
            this.lblCourseNameRemark = new System.Windows.Forms.Label();
            this.lblCourseDurationRemark = new System.Windows.Forms.Label();
            this.lblCoursePrequisiteIdRemark = new System.Windows.Forms.Label();
            this.lblTeacherObligatoryRemark = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTeacherName.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTeacherName
            // 
            this.grpTeacherName.Controls.Add(this.label1);
            this.grpTeacherName.Controls.Add(this.lblTeacherObligatoryRemark);
            this.grpTeacherName.Controls.Add(this.lblCoursePrequisiteIdRemark);
            this.grpTeacherName.Controls.Add(this.lblCourseDurationRemark);
            this.grpTeacherName.Controls.Add(this.lblCourseNameRemark);
            this.grpTeacherName.Controls.Add(this.cmbBoxCoursePrerequisiteId);
            this.grpTeacherName.Controls.Add(this.txtCourseId);
            this.grpTeacherName.Controls.Add(this.lblCourseDescription);
            this.grpTeacherName.Controls.Add(this.btnClearCourseForm);
            this.grpTeacherName.Controls.Add(this.txtCourseDescription);
            this.grpTeacherName.Controls.Add(this.btnAddCourse);
            this.grpTeacherName.Controls.Add(this.txtCourseDuration);
            this.grpTeacherName.Controls.Add(this.lblCourseId);
            this.grpTeacherName.Controls.Add(this.lblCourseIdRemark);
            this.grpTeacherName.Controls.Add(this.lblCourseName);
            this.grpTeacherName.Controls.Add(this.txtCourseName);
            this.grpTeacherName.Controls.Add(this.lblCourseDuration);
            this.grpTeacherName.Controls.Add(this.lblCoursePrerequisite);
            this.grpTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTeacherName.Location = new System.Drawing.Point(21, 21);
            this.grpTeacherName.Name = "grpTeacherName";
            this.grpTeacherName.Size = new System.Drawing.Size(290, 634);
            this.grpTeacherName.TabIndex = 35;
            this.grpTeacherName.TabStop = false;
            this.grpTeacherName.Text = "Create new course";
            // 
            // lblCourseDescription
            // 
            this.lblCourseDescription.AutoSize = true;
            this.lblCourseDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseDescription.Location = new System.Drawing.Point(16, 292);
            this.lblCourseDescription.Name = "lblCourseDescription";
            this.lblCourseDescription.Size = new System.Drawing.Size(130, 17);
            this.lblCourseDescription.TabIndex = 26;
            this.lblCourseDescription.Text = "Course description:";
            // 
            // btnClearCourseForm
            // 
            this.btnClearCourseForm.Location = new System.Drawing.Point(16, 529);
            this.btnClearCourseForm.Name = "btnClearCourseForm";
            this.btnClearCourseForm.Size = new System.Drawing.Size(256, 37);
            this.btnClearCourseForm.TabIndex = 41;
            this.btnClearCourseForm.Text = "Clear";
            this.btnClearCourseForm.UseVisualStyleBackColor = true;
            this.btnClearCourseForm.Click += new System.EventHandler(this.btnClearCourseForm_Click);
            // 
            // txtCourseDescription
            // 
            this.txtCourseDescription.Location = new System.Drawing.Point(19, 310);
            this.txtCourseDescription.Multiline = true;
            this.txtCourseDescription.Name = "txtCourseDescription";
            this.txtCourseDescription.Size = new System.Drawing.Size(253, 189);
            this.txtCourseDescription.TabIndex = 25;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(16, 572);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(256, 37);
            this.btnAddCourse.TabIndex = 39;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnSubmitCourse_Click);
            // 
            // txtCourseDuration
            // 
            this.txtCourseDuration.Location = new System.Drawing.Point(18, 172);
            this.txtCourseDuration.Multiline = true;
            this.txtCourseDuration.Name = "txtCourseDuration";
            this.txtCourseDuration.Size = new System.Drawing.Size(253, 26);
            this.txtCourseDuration.TabIndex = 2;
            // 
            // lblCourseId
            // 
            this.lblCourseId.AutoSize = true;
            this.lblCourseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseId.Location = new System.Drawing.Point(15, 35);
            this.lblCourseId.Name = "lblCourseId";
            this.lblCourseId.Size = new System.Drawing.Size(72, 17);
            this.lblCourseId.TabIndex = 23;
            this.lblCourseId.Text = "Course Id:";
            // 
            // lblCourseIdRemark
            // 
            this.lblCourseIdRemark.AutoSize = true;
            this.lblCourseIdRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseIdRemark.Location = new System.Drawing.Point(187, 83);
            this.lblCourseIdRemark.Name = "lblCourseIdRemark";
            this.lblCourseIdRemark.Size = new System.Drawing.Size(85, 13);
            this.lblCourseIdRemark.TabIndex = 24;
            this.lblCourseIdRemark.Text = "* Enter course Id";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(15, 91);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(96, 17);
            this.lblCourseName.TabIndex = 1;
            this.lblCourseName.Text = "Course name:";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(18, 111);
            this.txtCourseName.Multiline = true;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(253, 26);
            this.txtCourseName.TabIndex = 0;
            // 
            // lblCourseDuration
            // 
            this.lblCourseDuration.AutoSize = true;
            this.lblCourseDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseDuration.Location = new System.Drawing.Point(16, 152);
            this.lblCourseDuration.Name = "lblCourseDuration";
            this.lblCourseDuration.Size = new System.Drawing.Size(113, 17);
            this.lblCourseDuration.TabIndex = 3;
            this.lblCourseDuration.Text = "Course duration:";
            // 
            // lblCoursePrerequisite
            // 
            this.lblCoursePrerequisite.AutoSize = true;
            this.lblCoursePrerequisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoursePrerequisite.Location = new System.Drawing.Point(16, 221);
            this.lblCoursePrerequisite.Name = "lblCoursePrerequisite";
            this.lblCoursePrerequisite.Size = new System.Drawing.Size(136, 17);
            this.lblCoursePrerequisite.TabIndex = 5;
            this.lblCoursePrerequisite.Text = "Course prerequisite:";
            // 
            // txtCourseId
            // 
            this.txtCourseId.Location = new System.Drawing.Point(18, 55);
            this.txtCourseId.Multiline = true;
            this.txtCourseId.Name = "txtCourseId";
            this.txtCourseId.Size = new System.Drawing.Size(253, 26);
            this.txtCourseId.TabIndex = 42;
            // 
            // cmbBoxCoursePrerequisiteId
            // 
            this.cmbBoxCoursePrerequisiteId.FormattingEnabled = true;
            this.cmbBoxCoursePrerequisiteId.Location = new System.Drawing.Point(19, 241);
            this.cmbBoxCoursePrerequisiteId.Name = "cmbBoxCoursePrerequisiteId";
            this.cmbBoxCoursePrerequisiteId.Size = new System.Drawing.Size(253, 26);
            this.cmbBoxCoursePrerequisiteId.TabIndex = 43;
            // 
            // lblCourseNameRemark
            // 
            this.lblCourseNameRemark.AutoSize = true;
            this.lblCourseNameRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseNameRemark.Location = new System.Drawing.Point(169, 140);
            this.lblCourseNameRemark.Name = "lblCourseNameRemark";
            this.lblCourseNameRemark.Size = new System.Drawing.Size(102, 13);
            this.lblCourseNameRemark.TabIndex = 44;
            this.lblCourseNameRemark.Text = "* Enter course name";
            // 
            // lblCourseDurationRemark
            // 
            this.lblCourseDurationRemark.AutoSize = true;
            this.lblCourseDurationRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseDurationRemark.Location = new System.Drawing.Point(157, 198);
            this.lblCourseDurationRemark.Name = "lblCourseDurationRemark";
            this.lblCourseDurationRemark.Size = new System.Drawing.Size(114, 13);
            this.lblCourseDurationRemark.TabIndex = 45;
            this.lblCourseDurationRemark.Text = "* Enter course duration";
            // 
            // lblCoursePrequisiteIdRemark
            // 
            this.lblCoursePrequisiteIdRemark.AutoSize = true;
            this.lblCoursePrequisiteIdRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoursePrequisiteIdRemark.Location = new System.Drawing.Point(175, 270);
            this.lblCoursePrequisiteIdRemark.Name = "lblCoursePrequisiteIdRemark";
            this.lblCoursePrequisiteIdRemark.Size = new System.Drawing.Size(96, 13);
            this.lblCoursePrequisiteIdRemark.TabIndex = 46;
            this.lblCoursePrequisiteIdRemark.Text = "* Choose course Id";
            // 
            // lblTeacherObligatoryRemark
            // 
            this.lblTeacherObligatoryRemark.AutoSize = true;
            this.lblTeacherObligatoryRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherObligatoryRemark.Location = new System.Drawing.Point(175, 4);
            this.lblTeacherObligatoryRemark.Name = "lblTeacherObligatoryRemark";
            this.lblTeacherObligatoryRemark.Size = new System.Drawing.Size(115, 13);
            this.lblTeacherObligatoryRemark.TabIndex = 36;
            this.lblTeacherObligatoryRemark.Text = "* - the field is obligatory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "* Enter course description";
            // 
            // NewCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 675);
            this.Controls.Add(this.grpTeacherName);
            this.Name = "NewCourseForm";
            this.Text = "NewCourseForm";
            this.Load += new System.EventHandler(this.NewCourseForm_Load);
            this.grpTeacherName.ResumeLayout(false);
            this.grpTeacherName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTeacherName;
        private System.Windows.Forms.Label lblCourseDescription;
        private System.Windows.Forms.Button btnClearCourseForm;
        private System.Windows.Forms.TextBox txtCourseDescription;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.TextBox txtCourseDuration;
        private System.Windows.Forms.Label lblCourseId;
        private System.Windows.Forms.Label lblCourseIdRemark;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label lblCourseDuration;
        private System.Windows.Forms.Label lblCoursePrerequisite;
        private System.Windows.Forms.TextBox txtCourseId;
        private System.Windows.Forms.Label lblCoursePrequisiteIdRemark;
        private System.Windows.Forms.Label lblCourseDurationRemark;
        private System.Windows.Forms.Label lblCourseNameRemark;
        private System.Windows.Forms.ComboBox cmbBoxCoursePrerequisiteId;
        private System.Windows.Forms.Label lblTeacherObligatoryRemark;
        private System.Windows.Forms.Label label1;
    }
}