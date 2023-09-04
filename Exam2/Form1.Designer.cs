namespace Exam2
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
            components = new System.ComponentModel.Container();
            btnClickMe = new Button();
            progressBar1 = new ProgressBar();
            btnCloseForm = new Button();
            timer = new System.Windows.Forms.Timer(components);
            backgroundWorker = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // btnClickMe
            // 
            btnClickMe.Location = new Point(278, 117);
            btnClickMe.Name = "btnClickMe";
            btnClickMe.Size = new Size(208, 52);
            btnClickMe.TabIndex = 0;
            btnClickMe.Text = "Click me";
            btnClickMe.UseVisualStyleBackColor = true;
            btnClickMe.Click += BtnClickMe_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(246, 188);
            progressBar1.MarqueeAnimationSpeed = 0;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(275, 37);
            progressBar1.Step = 5;
            progressBar1.TabIndex = 1;
            // 
            // btnCloseForm
            // 
            btnCloseForm.Location = new Point(278, 244);
            btnCloseForm.Name = "btnCloseForm";
            btnCloseForm.Size = new Size(208, 46);
            btnCloseForm.TabIndex = 2;
            btnCloseForm.Text = "Close form";
            btnCloseForm.UseVisualStyleBackColor = true;
            btnCloseForm.Visible = false;
            btnCloseForm.Click += BtnCloseForm_Click;
            // 
            // backgroundWorker
            // 
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCloseForm);
            Controls.Add(progressBar1);
            Controls.Add(btnClickMe);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClickMe;
        private ProgressBar progressBar1;
        private Button btnCloseForm;
        private System.Windows.Forms.Timer timer;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}