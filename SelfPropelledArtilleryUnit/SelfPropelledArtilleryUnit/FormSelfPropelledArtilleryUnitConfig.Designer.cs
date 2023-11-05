namespace SelfPropelledArtilleryUnit
{
    partial class FormSelfPropelledArtilleryUnitConfig
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
            groupBox1 = new GroupBox();
            labelModifiedObject = new Label();
            labelSimpleObject = new Label();
            groupBox2 = new GroupBox();
            panelPurple = new Panel();
            panelYellow = new Panel();
            panelBlack = new Panel();
            panelBlue = new Panel();
            panelGray = new Panel();
            panelGreen = new Panel();
            panelWhite = new Panel();
            panelRed = new Panel();
            checkBoxBodyKit = new CheckBox();
            checkBoxPushka = new CheckBox();
            numericUpDownWeight = new NumericUpDown();
            numericUpDownSpeed = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            panelColor = new Panel();
            labelDopColor = new Label();
            labelBaseColor = new Label();
            pictureBoxObject = new PictureBox();
            ButtonOk = new Button();
            buttonCancel = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpeed).BeginInit();
            panelColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxObject).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelModifiedObject);
            groupBox1.Controls.Add(labelSimpleObject);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(checkBoxBodyKit);
            groupBox1.Controls.Add(checkBoxPushka);
            groupBox1.Controls.Add(numericUpDownWeight);
            groupBox1.Controls.Add(numericUpDownSpeed);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(519, 304);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Параметры";
            // 
            // labelModifiedObject
            // 
            labelModifiedObject.BorderStyle = BorderStyle.FixedSingle;
            labelModifiedObject.Location = new Point(358, 195);
            labelModifiedObject.Name = "labelModifiedObject";
            labelModifiedObject.Size = new Size(99, 35);
            labelModifiedObject.TabIndex = 8;
            labelModifiedObject.Text = "Продвинутый";
            labelModifiedObject.TextAlign = ContentAlignment.MiddleCenter;
            labelModifiedObject.MouseDown += LabelObject_MouseDown;
            // 
            // labelSimpleObject
            // 
            labelSimpleObject.BorderStyle = BorderStyle.FixedSingle;
            labelSimpleObject.Location = new Point(246, 195);
            labelSimpleObject.Name = "labelSimpleObject";
            labelSimpleObject.Size = new Size(99, 35);
            labelSimpleObject.TabIndex = 7;
            labelSimpleObject.Text = "Простой";
            labelSimpleObject.TextAlign = ContentAlignment.MiddleCenter;
            labelSimpleObject.MouseDown += LabelObject_MouseDown;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panelPurple);
            groupBox2.Controls.Add(panelYellow);
            groupBox2.Controls.Add(panelBlack);
            groupBox2.Controls.Add(panelBlue);
            groupBox2.Controls.Add(panelGray);
            groupBox2.Controls.Add(panelGreen);
            groupBox2.Controls.Add(panelWhite);
            groupBox2.Controls.Add(panelRed);
            groupBox2.Location = new Point(246, 43);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(211, 141);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Цвета";
            // 
            // panelPurple
            // 
            panelPurple.BackColor = Color.FromArgb(192, 0, 192);
            panelPurple.Location = new Point(159, 84);
            panelPurple.Margin = new Padding(3, 4, 3, 4);
            panelPurple.Name = "panelPurple";
            panelPurple.Size = new Size(40, 40);
            panelPurple.TabIndex = 7;
            panelPurple.MouseDown += panelColor_MouseDown;
            // 
            // panelYellow
            // 
            panelYellow.BackColor = Color.Yellow;
            panelYellow.Location = new Point(159, 29);
            panelYellow.Margin = new Padding(3, 4, 3, 4);
            panelYellow.Name = "panelYellow";
            panelYellow.Size = new Size(40, 40);
            panelYellow.TabIndex = 3;
            panelYellow.MouseDown += panelColor_MouseDown;
            // 
            // panelBlack
            // 
            panelBlack.BackColor = Color.Black;
            panelBlack.Location = new Point(112, 84);
            panelBlack.Margin = new Padding(3, 4, 3, 4);
            panelBlack.Name = "panelBlack";
            panelBlack.Size = new Size(40, 40);
            panelBlack.TabIndex = 6;
            panelBlack.MouseDown += panelColor_MouseDown;
            // 
            // panelBlue
            // 
            panelBlue.BackColor = Color.Blue;
            panelBlue.Location = new Point(112, 29);
            panelBlue.Margin = new Padding(3, 4, 3, 4);
            panelBlue.Name = "panelBlue";
            panelBlue.Size = new Size(40, 40);
            panelBlue.TabIndex = 2;
            panelBlue.MouseDown += panelColor_MouseDown;
            // 
            // panelGray
            // 
            panelGray.BackColor = Color.Gray;
            panelGray.Location = new Point(65, 84);
            panelGray.Margin = new Padding(3, 4, 3, 4);
            panelGray.Name = "panelGray";
            panelGray.Size = new Size(40, 40);
            panelGray.TabIndex = 5;
            panelGray.MouseDown += panelColor_MouseDown;
            // 
            // panelGreen
            // 
            panelGreen.BackColor = Color.FromArgb(0, 192, 0);
            panelGreen.Location = new Point(65, 29);
            panelGreen.Margin = new Padding(3, 4, 3, 4);
            panelGreen.Name = "panelGreen";
            panelGreen.Size = new Size(40, 40);
            panelGreen.TabIndex = 1;
            panelGreen.MouseDown += panelColor_MouseDown;
            // 
            // panelWhite
            // 
            panelWhite.BackColor = Color.White;
            panelWhite.Location = new Point(18, 84);
            panelWhite.Margin = new Padding(3, 4, 3, 4);
            panelWhite.Name = "panelWhite";
            panelWhite.Size = new Size(40, 40);
            panelWhite.TabIndex = 4;
            panelWhite.MouseDown += panelColor_MouseDown;
            // 
            // panelRed
            // 
            panelRed.BackColor = Color.Red;
            panelRed.Location = new Point(18, 29);
            panelRed.Margin = new Padding(3, 4, 3, 4);
            panelRed.Name = "panelRed";
            panelRed.Size = new Size(40, 40);
            panelRed.TabIndex = 0;
            panelRed.MouseDown += panelColor_MouseDown;
            // 
            // checkBoxBodyKit
            // 
            checkBoxBodyKit.AutoSize = true;
            checkBoxBodyKit.Location = new Point(11, 205);
            checkBoxBodyKit.Margin = new Padding(3, 4, 3, 4);
            checkBoxBodyKit.Name = "checkBoxBodyKit";
            checkBoxBodyKit.Size = new Size(215, 24);
            checkBoxBodyKit.TabIndex = 5;
            checkBoxBodyKit.Text = "Признак наличия батареи";
            checkBoxBodyKit.UseVisualStyleBackColor = true;
            // 
            // checkBoxPushka
            // 
            checkBoxPushka.AutoSize = true;
            checkBoxPushka.Location = new Point(11, 159);
            checkBoxPushka.Margin = new Padding(3, 4, 3, 4);
            checkBoxPushka.Name = "checkBoxPushka";
            checkBoxPushka.Size = new Size(202, 24);
            checkBoxPushka.TabIndex = 4;
            checkBoxPushka.Text = "Признак наличия пушки";
            checkBoxPushka.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            numericUpDownWeight.Location = new Point(87, 80);
            numericUpDownWeight.Margin = new Padding(3, 4, 3, 4);
            numericUpDownWeight.Name = "numericUpDownWeight";
            numericUpDownWeight.Size = new Size(83, 27);
            numericUpDownWeight.TabIndex = 3;
            numericUpDownWeight.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // numericUpDownSpeed
            // 
            numericUpDownSpeed.Location = new Point(87, 41);
            numericUpDownSpeed.Margin = new Padding(3, 4, 3, 4);
            numericUpDownSpeed.Name = "numericUpDownSpeed";
            numericUpDownSpeed.Size = new Size(83, 27);
            numericUpDownSpeed.TabIndex = 2;
            numericUpDownSpeed.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 83);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 1;
            label2.Text = "Вес:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 44);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Скорость:";
            // 
            // panelColor
            // 
            panelColor.AllowDrop = true;
            panelColor.Controls.Add(labelDopColor);
            panelColor.Controls.Add(labelBaseColor);
            panelColor.Controls.Add(pictureBoxObject);
            panelColor.Location = new Point(539, 16);
            panelColor.Margin = new Padding(3, 4, 3, 4);
            panelColor.Name = "panelColor";
            panelColor.Size = new Size(315, 245);
            panelColor.TabIndex = 1;
            panelColor.DragDrop += PanelObject_DragDrop;
            panelColor.DragEnter += PanelObject_DragEnter;
            // 
            // labelDopColor
            // 
            labelDopColor.AllowDrop = true;
            labelDopColor.BorderStyle = BorderStyle.FixedSingle;
            labelDopColor.Location = new Point(187, 13);
            labelDopColor.Name = "labelDopColor";
            labelDopColor.Size = new Size(114, 38);
            labelDopColor.TabIndex = 2;
            labelDopColor.Text = "Доп. цвет";
            labelDopColor.TextAlign = ContentAlignment.MiddleCenter;
            labelDopColor.DragDrop += LabelDopColor_DragDrop;
            labelDopColor.DragEnter += LabelColor_DragEnter;
            labelDopColor.MouseDown += LabelObject_MouseDown;
            // 
            // labelBaseColor
            // 
            labelBaseColor.AllowDrop = true;
            labelBaseColor.BorderStyle = BorderStyle.FixedSingle;
            labelBaseColor.Location = new Point(14, 13);
            labelBaseColor.Name = "labelBaseColor";
            labelBaseColor.Size = new Size(114, 38);
            labelBaseColor.TabIndex = 2;
            labelBaseColor.Text = "Цвет";
            labelBaseColor.TextAlign = ContentAlignment.MiddleCenter;
            labelBaseColor.DragDrop += LabelBaseColor_DragDrop;
            labelBaseColor.DragEnter += LabelColor_DragEnter;
            labelBaseColor.MouseDown += LabelObject_MouseDown;
            // 
            // pictureBoxObject
            // 
            pictureBoxObject.Location = new Point(14, 61);
            pictureBoxObject.Margin = new Padding(3, 4, 3, 4);
            pictureBoxObject.Name = "pictureBoxObject";
            pictureBoxObject.Size = new Size(288, 169);
            pictureBoxObject.TabIndex = 0;
            pictureBoxObject.TabStop = false;
            // 
            // ButtonOk
            // 
            ButtonOk.Location = new Point(553, 277);
            ButtonOk.Margin = new Padding(3, 4, 3, 4);
            ButtonOk.Name = "ButtonOk";
            ButtonOk.Size = new Size(114, 43);
            ButtonOk.TabIndex = 2;
            ButtonOk.Text = "Добавить";
            ButtonOk.UseVisualStyleBackColor = true;
            ButtonOk.Click += ButtonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(727, 277);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(114, 43);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormSelfPropelledArtilleryUnitConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 336);
            Controls.Add(buttonCancel);
            Controls.Add(ButtonOk);
            Controls.Add(panelColor);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormSelfPropelledArtilleryUnitConfig";
            Text = "FormSelfPropelledArtilleryUnitConfig";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpeed).EndInit();
            panelColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxObject).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown numericUpDownWeight;
        private NumericUpDown numericUpDownSpeed;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private CheckBox checkBoxBodyKit;
        private CheckBox checkBoxPushka;
        private Panel panelPurple;
        private Panel panelYellow;
        private Panel panelBlack;
        private Panel panelBlue;
        private Panel panelGray;
        private Panel panelGreen;
        private Panel panelWhite;
        private Panel panelRed;
        private Label labelSimpleObject;
        private Label labelModifiedObject;
        private Panel panelColor;
        private PictureBox pictureBoxObject;
        private Label labelDopColor;
        private Label labelBaseColor;
        private Button ButtonOk;
        private Button buttonCancel;
    }
}