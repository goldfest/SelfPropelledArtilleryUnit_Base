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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(454, 228);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Параметры";
            // 
            // labelModifiedObject
            // 
            labelModifiedObject.BorderStyle = BorderStyle.FixedSingle;
            labelModifiedObject.Location = new Point(313, 146);
            labelModifiedObject.Name = "labelModifiedObject";
            labelModifiedObject.Size = new Size(87, 27);
            labelModifiedObject.TabIndex = 8;
            labelModifiedObject.Text = "Продвинутый";
            labelModifiedObject.TextAlign = ContentAlignment.MiddleCenter;
            labelModifiedObject.MouseDown += LabelObject_MouseDown;
            // 
            // labelSimpleObject
            // 
            labelSimpleObject.BorderStyle = BorderStyle.FixedSingle;
            labelSimpleObject.Location = new Point(215, 146);
            labelSimpleObject.Name = "labelSimpleObject";
            labelSimpleObject.Size = new Size(87, 27);
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
            groupBox2.Location = new Point(215, 32);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(185, 106);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Цвета";
            // 
            // panelPurple
            // 
            panelPurple.BackColor = Color.Purple;
            panelPurple.Location = new Point(139, 63);
            panelPurple.Name = "panelPurple";
            panelPurple.Size = new Size(35, 30);
            panelPurple.TabIndex = 7;
            panelPurple.MouseDown += panelColor_MouseDown;
            // 
            // panelYellow
            // 
            panelYellow.BackColor = Color.Yellow;
            panelYellow.Location = new Point(139, 22);
            panelYellow.Name = "panelYellow";
            panelYellow.Size = new Size(35, 30);
            panelYellow.TabIndex = 3;
            panelYellow.MouseDown += panelColor_MouseDown;
            // 
            // panelBlack
            // 
            panelBlack.BackColor = Color.Black;
            panelBlack.Location = new Point(98, 63);
            panelBlack.Name = "panelBlack";
            panelBlack.Size = new Size(35, 30);
            panelBlack.TabIndex = 6;
            panelBlack.MouseDown += panelColor_MouseDown;
            // 
            // panelBlue
            // 
            panelBlue.BackColor = Color.Blue;
            panelBlue.Location = new Point(98, 22);
            panelBlue.Name = "panelBlue";
            panelBlue.Size = new Size(35, 30);
            panelBlue.TabIndex = 2;
            panelBlue.MouseDown += panelColor_MouseDown;
            // 
            // panelGray
            // 
            panelGray.BackColor = Color.Gray;
            panelGray.Location = new Point(57, 63);
            panelGray.Name = "panelGray";
            panelGray.Size = new Size(35, 30);
            panelGray.TabIndex = 5;
            panelGray.MouseDown += panelColor_MouseDown;
            // 
            // panelGreen
            // 
            panelGreen.BackColor = Color.Green;
            panelGreen.Location = new Point(57, 22);
            panelGreen.Name = "panelGreen";
            panelGreen.Size = new Size(35, 30);
            panelGreen.TabIndex = 1;
            panelGreen.MouseDown += panelColor_MouseDown;
            // 
            // panelWhite
            // 
            panelWhite.BackColor = Color.White;
            panelWhite.Location = new Point(16, 63);
            panelWhite.Name = "panelWhite";
            panelWhite.Size = new Size(35, 30);
            panelWhite.TabIndex = 4;
            panelWhite.MouseDown += panelColor_MouseDown;
            // 
            // panelRed
            // 
            panelRed.BackColor = Color.Red;
            panelRed.Location = new Point(16, 22);
            panelRed.Name = "panelRed";
            panelRed.Size = new Size(35, 30);
            panelRed.TabIndex = 0;
            panelRed.MouseDown += panelColor_MouseDown;
            // 
            // checkBoxBodyKit
            // 
            checkBoxBodyKit.AutoSize = true;
            checkBoxBodyKit.Location = new Point(10, 154);
            checkBoxBodyKit.Name = "checkBoxBodyKit";
            checkBoxBodyKit.Size = new Size(170, 19);
            checkBoxBodyKit.TabIndex = 5;
            checkBoxBodyKit.Text = "Признак наличия батареи";
            checkBoxBodyKit.UseVisualStyleBackColor = true;
            // 
            // checkBoxPushka
            // 
            checkBoxPushka.AutoSize = true;
            checkBoxPushka.Location = new Point(10, 119);
            checkBoxPushka.Name = "checkBoxPushka";
            checkBoxPushka.Size = new Size(163, 19);
            checkBoxPushka.TabIndex = 4;
            checkBoxPushka.Text = "Признак наличия пушки";
            checkBoxPushka.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            numericUpDownWeight.Location = new Point(76, 60);
            numericUpDownWeight.Name = "numericUpDownWeight";
            numericUpDownWeight.Size = new Size(73, 23);
            numericUpDownWeight.TabIndex = 3;
            numericUpDownWeight.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // numericUpDownSpeed
            // 
            numericUpDownSpeed.Location = new Point(76, 31);
            numericUpDownSpeed.Name = "numericUpDownSpeed";
            numericUpDownSpeed.Size = new Size(73, 23);
            numericUpDownSpeed.TabIndex = 2;
            numericUpDownSpeed.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 62);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "Вес:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 33);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Скорость:";
            // 
            // panelColor
            // 
            panelColor.AllowDrop = true;
            panelColor.Controls.Add(labelDopColor);
            panelColor.Controls.Add(labelBaseColor);
            panelColor.Controls.Add(pictureBoxObject);
            panelColor.Location = new Point(472, 12);
            panelColor.Name = "panelColor";
            panelColor.Size = new Size(276, 184);
            panelColor.TabIndex = 1;
            panelColor.DragDrop += PanelObject_DragDrop;
            panelColor.DragEnter += PanelObject_DragEnter;
            // 
            // labelDopColor
            // 
            labelDopColor.AllowDrop = true;
            labelDopColor.BorderStyle = BorderStyle.FixedSingle;
            labelDopColor.Location = new Point(164, 10);
            labelDopColor.Name = "labelDopColor";
            labelDopColor.Size = new Size(100, 29);
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
            labelBaseColor.Location = new Point(12, 10);
            labelBaseColor.Name = "labelBaseColor";
            labelBaseColor.Size = new Size(100, 29);
            labelBaseColor.TabIndex = 2;
            labelBaseColor.Text = "Цвет";
            labelBaseColor.TextAlign = ContentAlignment.MiddleCenter;
            labelBaseColor.DragDrop += LabelBaseColor_DragDrop;
            labelBaseColor.DragEnter += LabelColor_DragEnter;
            labelBaseColor.MouseDown += LabelObject_MouseDown;
            // 
            // pictureBoxObject
            // 
            pictureBoxObject.Location = new Point(12, 46);
            pictureBoxObject.Name = "pictureBoxObject";
            pictureBoxObject.Size = new Size(252, 127);
            pictureBoxObject.TabIndex = 0;
            pictureBoxObject.TabStop = false;
            // 
            // ButtonOk
            // 
            ButtonOk.Location = new Point(484, 208);
            ButtonOk.Name = "ButtonOk";
            ButtonOk.Size = new Size(100, 32);
            ButtonOk.TabIndex = 2;
            ButtonOk.Text = "Добавить";
            ButtonOk.UseVisualStyleBackColor = true;
            ButtonOk.Click += ButtonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(636, 208);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(100, 32);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormSelfPropelledArtilleryUnitConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 252);
            Controls.Add(buttonCancel);
            Controls.Add(ButtonOk);
            Controls.Add(panelColor);
            Controls.Add(groupBox1);
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