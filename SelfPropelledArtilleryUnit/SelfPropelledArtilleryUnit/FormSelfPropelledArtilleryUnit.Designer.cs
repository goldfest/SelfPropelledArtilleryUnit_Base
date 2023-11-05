namespace SelfPropelledArtilleryUnit
{
    partial class FormSelfPropelledArtilleryUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelfPropelledArtilleryUnit));
            pictureBoxUsta = new PictureBox();
            buttonCreate = new Button();
            buttonRight = new Button();
            buttonLeft = new Button();
            buttonDown = new Button();
            buttonUp = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsta).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxUsta
            // 
            pictureBoxUsta.Dock = DockStyle.Fill;
            pictureBoxUsta.Location = new Point(0, 0);
            pictureBoxUsta.Name = "pictureBoxUsta";
            pictureBoxUsta.Size = new Size(884, 461);
            pictureBoxUsta.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxUsta.TabIndex = 0;
            pictureBoxUsta.TabStop = false;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(22, 417);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(109, 28);
            buttonCreate.TabIndex = 8;
            buttonCreate.Text = "Создать";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonRight
            // 
            buttonRight.BackgroundImage = (Image)resources.GetObject("buttonRight.BackgroundImage");
            buttonRight.Location = new Point(778, 390);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(50, 50);
            buttonRight.TabIndex = 12;
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += buttonMove_Click;
            // 
            // buttonLeft
            // 
            buttonLeft.BackgroundImage = (Image)resources.GetObject("buttonLeft.BackgroundImage");
            buttonLeft.Location = new Point(666, 390);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(50, 50);
            buttonLeft.TabIndex = 11;
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += buttonMove_Click;
            // 
            // buttonDown
            // 
            buttonDown.BackgroundImage = (Image)resources.GetObject("buttonDown.BackgroundImage");
            buttonDown.Location = new Point(722, 390);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(50, 50);
            buttonDown.TabIndex = 10;
            buttonDown.UseVisualStyleBackColor = true;
            buttonDown.Click += buttonMove_Click;
            // 
            // buttonUp
            // 
            buttonUp.BackgroundImage = (Image)resources.GetObject("buttonUp.BackgroundImage");
            buttonUp.Location = new Point(722, 334);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(50, 50);
            buttonUp.TabIndex = 9;
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += buttonMove_Click;
            // 
            // FormSelfPropelledArtilleryUnit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(buttonRight);
            Controls.Add(buttonLeft);
            Controls.Add(buttonDown);
            Controls.Add(buttonUp);
            Controls.Add(buttonCreate);
            Controls.Add(pictureBoxUsta);
            Name = "FormSelfPropelledArtilleryUnit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelfPropelledArtilleryUnit";
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxUsta;
        private Button buttonCreate;
        private Button buttonRight;
        private Button buttonLeft;
        private Button buttonDown;
        private Button buttonUp;
    }
}