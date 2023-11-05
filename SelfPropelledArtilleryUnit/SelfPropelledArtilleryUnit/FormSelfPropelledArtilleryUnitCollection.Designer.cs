namespace SelfPropelledArtilleryUnit
{
    partial class FormSelfPropelledArtilleryUnitCollection
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
            ButtonAddUsta = new Button();
            ButtonRemoveUsta = new Button();
            ButtonRefreshCollection = new Button();
            pictureBoxCollection = new PictureBox();
            maskedTextBoxNumber = new MaskedTextBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCollection).BeginInit();
            SuspendLayout();
            // 
            // ButtonAddUsta
            // 
            ButtonAddUsta.Location = new Point(665, 45);
            ButtonAddUsta.Name = "ButtonAddUsta";
            ButtonAddUsta.Size = new Size(166, 31);
            ButtonAddUsta.TabIndex = 0;
            ButtonAddUsta.Text = "Добавить арт. установку";
            ButtonAddUsta.UseVisualStyleBackColor = true;
            ButtonAddUsta.Click += ButtonAddUsta_Click;
            // 
            // ButtonRemoveUsta
            // 
            ButtonRemoveUsta.Location = new Point(665, 129);
            ButtonRemoveUsta.Name = "ButtonRemoveUsta";
            ButtonRemoveUsta.Size = new Size(166, 31);
            ButtonRemoveUsta.TabIndex = 1;
            ButtonRemoveUsta.Text = "Удалить арт. установку";
            ButtonRemoveUsta.UseVisualStyleBackColor = true;
            ButtonRemoveUsta.Click += ButtonRemoveUsta_Click;
            // 
            // ButtonRefreshCollection
            // 
            ButtonRefreshCollection.Location = new Point(665, 215);
            ButtonRefreshCollection.Name = "ButtonRefreshCollection";
            ButtonRefreshCollection.Size = new Size(166, 31);
            ButtonRefreshCollection.TabIndex = 2;
            ButtonRefreshCollection.Text = "Обновить коллекцию";
            ButtonRefreshCollection.UseVisualStyleBackColor = true;
            ButtonRefreshCollection.Click += ButtonRefreshCollection_Click;
            // 
            // pictureBoxCollection
            // 
            pictureBoxCollection.Location = new Point(0, 0);
            pictureBoxCollection.Name = "pictureBoxCollection";
            pictureBoxCollection.Size = new Size(643, 423);
            pictureBoxCollection.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCollection.TabIndex = 3;
            pictureBoxCollection.TabStop = false;
            // 
            // maskedTextBoxNumber
            // 
            maskedTextBoxNumber.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxNumber.Location = new Point(695, 100);
            maskedTextBoxNumber.Mask = "00";
            maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            maskedTextBoxNumber.Size = new Size(100, 22);
            maskedTextBoxNumber.TabIndex = 4;
            maskedTextBoxNumber.ValidatingType = typeof(int);
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(643, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(209, 411);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Инструменты";
            // 
            // FormSelfPropelledArtilleryUnitCollection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 435);
            Controls.Add(ButtonRefreshCollection);
            Controls.Add(ButtonRemoveUsta);
            Controls.Add(maskedTextBoxNumber);
            Controls.Add(ButtonAddUsta);
            Controls.Add(groupBox1);
            Controls.Add(pictureBoxCollection);
            Name = "FormSelfPropelledArtilleryUnitCollection";
            Text = "Набор арт. установок";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCollection).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonAddUsta;
        private Button ButtonRemoveUsta;
        private Button ButtonRefreshCollection;
        private PictureBox pictureBoxCollection;
        private MaskedTextBox maskedTextBoxNumber;
        private GroupBox groupBox1;
    }
}