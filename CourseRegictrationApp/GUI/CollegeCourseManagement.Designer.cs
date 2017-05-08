namespace CourseRegictrationApp.GUI
{
    partial class CollegeCourseManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollegeCourseManagement));
            this.pictureBoxStudents = new System.Windows.Forms.PictureBox();
            this.pictureBoxTeachers = new System.Windows.Forms.PictureBox();
            this.groupBoxTeachers = new System.Windows.Forms.GroupBox();
            this.groupBoxStudents = new System.Windows.Forms.GroupBox();
            this.groupBoxCourses = new System.Windows.Forms.GroupBox();
            this.pictureBoxCourses = new System.Windows.Forms.PictureBox();
            this.groupBoxGroups = new System.Windows.Forms.GroupBox();
            this.pictureBoxGroups = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeachers)).BeginInit();
            this.groupBoxTeachers.SuspendLayout();
            this.groupBoxStudents.SuspendLayout();
            this.groupBoxCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCourses)).BeginInit();
            this.groupBoxGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxStudents
            // 
            this.pictureBoxStudents.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStudents.Image")));
            this.pictureBoxStudents.Location = new System.Drawing.Point(23, 23);
            this.pictureBoxStudents.Name = "pictureBoxStudents";
            this.pictureBoxStudents.Size = new System.Drawing.Size(175, 170);
            this.pictureBoxStudents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxStudents.TabIndex = 0;
            this.pictureBoxStudents.TabStop = false;
            this.pictureBoxStudents.Click += new System.EventHandler(this.pictureBoxAddNewStudent_Click);
            // 
            // pictureBoxTeachers
            // 
            this.pictureBoxTeachers.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTeachers.Image")));
            this.pictureBoxTeachers.Location = new System.Drawing.Point(22, 23);
            this.pictureBoxTeachers.Name = "pictureBoxTeachers";
            this.pictureBoxTeachers.Size = new System.Drawing.Size(175, 170);
            this.pictureBoxTeachers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxTeachers.TabIndex = 2;
            this.pictureBoxTeachers.TabStop = false;
            this.pictureBoxTeachers.Click += new System.EventHandler(this.pictureBoxAddNewTeacher_Click);
            // 
            // groupBoxTeachers
            // 
            this.groupBoxTeachers.Controls.Add(this.pictureBoxTeachers);
            this.groupBoxTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTeachers.Location = new System.Drawing.Point(50, 37);
            this.groupBoxTeachers.Name = "groupBoxTeachers";
            this.groupBoxTeachers.Size = new System.Drawing.Size(217, 205);
            this.groupBoxTeachers.TabIndex = 4;
            this.groupBoxTeachers.TabStop = false;
            this.groupBoxTeachers.Text = "Teachers";
            // 
            // groupBoxStudents
            // 
            this.groupBoxStudents.Controls.Add(this.pictureBoxStudents);
            this.groupBoxStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStudents.Location = new System.Drawing.Point(301, 37);
            this.groupBoxStudents.Name = "groupBoxStudents";
            this.groupBoxStudents.Size = new System.Drawing.Size(217, 205);
            this.groupBoxStudents.TabIndex = 5;
            this.groupBoxStudents.TabStop = false;
            this.groupBoxStudents.Text = "Students";
            // 
            // groupBoxCourses
            // 
            this.groupBoxCourses.Controls.Add(this.pictureBoxCourses);
            this.groupBoxCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCourses.Location = new System.Drawing.Point(50, 261);
            this.groupBoxCourses.Name = "groupBoxCourses";
            this.groupBoxCourses.Size = new System.Drawing.Size(217, 205);
            this.groupBoxCourses.TabIndex = 5;
            this.groupBoxCourses.TabStop = false;
            this.groupBoxCourses.Text = "Courses";
            // 
            // pictureBoxCourses
            // 
            this.pictureBoxCourses.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCourses.Image")));
            this.pictureBoxCourses.Location = new System.Drawing.Point(22, 23);
            this.pictureBoxCourses.Name = "pictureBoxCourses";
            this.pictureBoxCourses.Size = new System.Drawing.Size(175, 170);
            this.pictureBoxCourses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCourses.TabIndex = 2;
            this.pictureBoxCourses.TabStop = false;
            this.pictureBoxCourses.Click += new System.EventHandler(this.pictureBoxCreateCourse_Click);
            // 
            // groupBoxGroups
            // 
            this.groupBoxGroups.Controls.Add(this.pictureBoxGroups);
            this.groupBoxGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGroups.Location = new System.Drawing.Point(301, 261);
            this.groupBoxGroups.Name = "groupBoxGroups";
            this.groupBoxGroups.Size = new System.Drawing.Size(217, 205);
            this.groupBoxGroups.TabIndex = 6;
            this.groupBoxGroups.TabStop = false;
            this.groupBoxGroups.Text = "Groups";
            // 
            // pictureBoxGroups
            // 
            this.pictureBoxGroups.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGroups.Image")));
            this.pictureBoxGroups.Location = new System.Drawing.Point(22, 23);
            this.pictureBoxGroups.Name = "pictureBoxGroups";
            this.pictureBoxGroups.Size = new System.Drawing.Size(175, 170);
            this.pictureBoxGroups.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxGroups.TabIndex = 2;
            this.pictureBoxGroups.TabStop = false;
            this.pictureBoxGroups.Click += new System.EventHandler(this.pictureBoxFillGroup_Click);
            // 
            // CollegeCourseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 527);
            this.Controls.Add(this.groupBoxGroups);
            this.Controls.Add(this.groupBoxCourses);
            this.Controls.Add(this.groupBoxStudents);
            this.Controls.Add(this.groupBoxTeachers);
            this.Name = "CollegeCourseManagement";
            this.Text = "CollegeCourseManagement";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeachers)).EndInit();
            this.groupBoxTeachers.ResumeLayout(false);
            this.groupBoxStudents.ResumeLayout(false);
            this.groupBoxCourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCourses)).EndInit();
            this.groupBoxGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxStudents;
        private System.Windows.Forms.PictureBox pictureBoxTeachers;
        private System.Windows.Forms.GroupBox groupBoxTeachers;
        private System.Windows.Forms.GroupBox groupBoxStudents;
        private System.Windows.Forms.GroupBox groupBoxCourses;
        private System.Windows.Forms.PictureBox pictureBoxCourses;
        private System.Windows.Forms.GroupBox groupBoxGroups;
        private System.Windows.Forms.PictureBox pictureBoxGroups;
    }
}