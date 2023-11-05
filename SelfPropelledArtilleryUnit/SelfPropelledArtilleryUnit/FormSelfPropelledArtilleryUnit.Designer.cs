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
            comboBoxStrategy = new ComboBox();
            ButtonCreateUstaBat = new Button();
            ButtonCreateUsta = new Button();
            ButtonStep = new Button();
            buttonUp = new Button();
            buttonDown = new Button();
            buttonLeft = new Button();
            buttonRight = new Button();
            pictureBoxUsta = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsta).BeginInit();
            SuspendLayout();
            // 
            // comboBoxStrategy
            // 
            comboBoxStrategy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStrategy.FormattingEnabled = true;
            comboBoxStrategy.Items.AddRange(new object[] { "MoveToCenter", "MoveToBorder", "-" });
            comboBoxStrategy.Location = new Point(667, 12);
            comboBoxStrategy.Name = "comboBoxStrategy";
            comboBoxStrategy.Size = new Size(121, 23);
            comboBoxStrategy.TabIndex = 0;
            // 
            // ButtonCreateUstaBat
            // 
            ButtonCreateUstaBat.Location = new Point(19, 393);
            ButtonCreateUstaBat.Name = "ButtonCreateUstaBat";
            ButtonCreateUstaBat.Size = new Size(160, 42);
            ButtonCreateUstaBat.TabIndex = 1;
            ButtonCreateUstaBat.Text = "Создать арт. установку с вооружением";
            ButtonCreateUstaBat.UseVisualStyleBackColor = true;
            ButtonCreateUstaBat.Click += ButtonCreateUstaBat_Click;
            // 
            // ButtonCreateUsta
            // 
            ButtonCreateUsta.Location = new Point(185, 393);
            ButtonCreateUsta.Name = "ButtonCreateUsta";
            ButtonCreateUsta.Size = new Size(157, 42);
            ButtonCreateUsta.TabIndex = 2;
            ButtonCreateUsta.Text = "Создать арт. установку";
            ButtonCreateUsta.UseVisualStyleBackColor = true;
            ButtonCreateUsta.Click += ButtonCreateUsta_Click;
            // 
            // ButtonStep
            // 
            ButtonStep.Location = new Point(713, 50);
            ButtonStep.Name = "ButtonStep";
            ButtonStep.Size = new Size(75, 23);
            ButtonStep.TabIndex = 3;
            ButtonStep.Text = "Шаг";
            ButtonStep.UseVisualStyleBackColor = true;
            ButtonStep.Click += ButtonStep_Click;
            // 
            // buttonUp
            // 
            buttonUp.BackgroundImage = (Image)resources.GetObject("buttonUp.BackgroundImage");
            buttonUp.Location = new Point(617, 314);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(50, 50);
            buttonUp.TabIndex = 4;
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += ButtonMove_Click;
            // 
            // buttonDown
            // 
            buttonDown.BackgroundImage = (Image)resources.GetObject("buttonDown.BackgroundImage");
            buttonDown.Location = new Point(617, 370);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(50, 50);
            buttonDown.TabIndex = 5;
            buttonDown.UseVisualStyleBackColor = true;
            buttonDown.Click += ButtonMove_Click;
            // 
            // buttonLeft
            // 
            buttonLeft.BackgroundImage = (Image)resources.GetObject("buttonLeft.BackgroundImage");
            buttonLeft.Location = new Point(561, 370);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(50, 50);
            buttonLeft.TabIndex = 6;
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += ButtonMove_Click;
            // 
            // buttonRight
            // 
            buttonRight.BackgroundImage = (Image)resources.GetObject("buttonRight.BackgroundImage");
            buttonRight.Location = new Point(673, 370);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(50, 50);
            buttonRight.TabIndex = 7;
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += ButtonMove_Click;
            // 
            // pictureBoxUsta
            // 
            pictureBoxUsta.Dock = DockStyle.Fill;
            pictureBoxUsta.Location = new Point(0, 0);
            pictureBoxUsta.Name = "pictureBoxUsta";
            pictureBoxUsta.Size = new Size(800, 450);
            pictureBoxUsta.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxUsta.TabIndex = 8;
            pictureBoxUsta.TabStop = false;
            // 
            // FormSelfPropelledArtilleryUnit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRight);
            Controls.Add(buttonLeft);
            Controls.Add(buttonDown);
            Controls.Add(buttonUp);
            Controls.Add(ButtonStep);
            Controls.Add(ButtonCreateUsta);
            Controls.Add(ButtonCreateUstaBat);
            Controls.Add(comboBoxStrategy);
            Controls.Add(pictureBoxUsta);
            Name = "FormSelfPropelledArtilleryUnit";
            Text = "SelfPropelledArtilleryUnit";
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxStrategy;
        private Button ButtonCreateUstaBat;
        private Button ButtonCreateUsta;
        private Button ButtonStep;
        private Button buttonUp;
        private Button buttonDown;
        private Button buttonLeft;
        private Button buttonRight;
        private PictureBox pictureBoxUsta;
    }
}