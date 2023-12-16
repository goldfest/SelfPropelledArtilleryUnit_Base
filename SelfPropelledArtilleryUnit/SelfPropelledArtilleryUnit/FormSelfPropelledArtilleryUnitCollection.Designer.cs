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
            ButtonSortByType = new Button();
            ButtonSortByColor = new Button();
            groupBox2 = new GroupBox();
            listBoxStorage = new ListBox();
            ButtonDelObject = new Button();
            ButtonAddObject = new Button();
            textBoxStorageName = new TextBox();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            LoadToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCollection).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonAddUsta
            // 
            ButtonAddUsta.Location = new Point(30, 557);
            ButtonAddUsta.Margin = new Padding(3, 4, 3, 4);
            ButtonAddUsta.Name = "ButtonAddUsta";
            ButtonAddUsta.Size = new Size(190, 35);
            ButtonAddUsta.TabIndex = 0;
            ButtonAddUsta.Text = "Добавить арт. установку";
            ButtonAddUsta.UseVisualStyleBackColor = true;
            ButtonAddUsta.Click += ButtonAddUsta_Click;
            // 
            // ButtonRemoveUsta
            // 
            ButtonRemoveUsta.Location = new Point(30, 643);
            ButtonRemoveUsta.Margin = new Padding(3, 4, 3, 4);
            ButtonRemoveUsta.Name = "ButtonRemoveUsta";
            ButtonRemoveUsta.Size = new Size(190, 37);
            ButtonRemoveUsta.TabIndex = 1;
            ButtonRemoveUsta.Text = "Удалить арт. установку";
            ButtonRemoveUsta.UseVisualStyleBackColor = true;
            ButtonRemoveUsta.Click += ButtonRemoveUsta_Click;
            // 
            // ButtonRefreshCollection
            // 
            ButtonRefreshCollection.Location = new Point(30, 695);
            ButtonRefreshCollection.Margin = new Padding(3, 4, 3, 4);
            ButtonRefreshCollection.Name = "ButtonRefreshCollection";
            ButtonRefreshCollection.Size = new Size(190, 41);
            ButtonRefreshCollection.TabIndex = 2;
            ButtonRefreshCollection.Text = "Обновить коллекцию";
            ButtonRefreshCollection.UseVisualStyleBackColor = true;
            ButtonRefreshCollection.Click += ButtonRefreshCollection_Click;
            // 
            // pictureBoxCollection
            // 
            pictureBoxCollection.Location = new Point(0, 0);
            pictureBoxCollection.Margin = new Padding(3, 4, 3, 4);
            pictureBoxCollection.Name = "pictureBoxCollection";
            pictureBoxCollection.Size = new Size(728, 777);
            pictureBoxCollection.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCollection.TabIndex = 3;
            pictureBoxCollection.TabStop = false;
            // 
            // maskedTextBoxNumber
            // 
            maskedTextBoxNumber.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxNumber.Location = new Point(66, 604);
            maskedTextBoxNumber.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxNumber.Mask = "00";
            maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            maskedTextBoxNumber.Size = new Size(114, 26);
            maskedTextBoxNumber.TabIndex = 4;
            maskedTextBoxNumber.ValidatingType = typeof(int);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ButtonSortByType);
            groupBox1.Controls.Add(ButtonSortByColor);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(ButtonAddUsta);
            groupBox1.Controls.Add(ButtonRefreshCollection);
            groupBox1.Controls.Add(maskedTextBoxNumber);
            groupBox1.Controls.Add(ButtonRemoveUsta);
            groupBox1.Controls.Add(menuStrip);
            groupBox1.Location = new Point(735, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(239, 747);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Инструменты";
            // 
            // ButtonSortByType
            // 
            ButtonSortByType.Location = new Point(30, 471);
            ButtonSortByType.Margin = new Padding(3, 4, 3, 4);
            ButtonSortByType.Name = "ButtonSortByType";
            ButtonSortByType.Size = new Size(190, 35);
            ButtonSortByType.TabIndex = 9;
            ButtonSortByType.Text = "Сортировка по типу";
            ButtonSortByType.UseVisualStyleBackColor = true;
            ButtonSortByType.Click += ButtonSortByType_Click;
            // 
            // ButtonSortByColor
            // 
            ButtonSortByColor.Location = new Point(30, 514);
            ButtonSortByColor.Margin = new Padding(3, 4, 3, 4);
            ButtonSortByColor.Name = "ButtonSortByColor";
            ButtonSortByColor.Size = new Size(190, 35);
            ButtonSortByColor.TabIndex = 8;
            ButtonSortByColor.Text = "Сортировка по цвету";
            ButtonSortByColor.UseVisualStyleBackColor = true;
            ButtonSortByColor.Click += ButtonSortByColor_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBoxStorage);
            groupBox2.Controls.Add(ButtonDelObject);
            groupBox2.Controls.Add(ButtonAddObject);
            groupBox2.Controls.Add(textBoxStorageName);
            groupBox2.Location = new Point(7, 85);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(225, 365);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Наборы";
            // 
            // listBoxStorage
            // 
            listBoxStorage.FormattingEnabled = true;
            listBoxStorage.ItemHeight = 20;
            listBoxStorage.Location = new Point(23, 141);
            listBoxStorage.Margin = new Padding(3, 4, 3, 4);
            listBoxStorage.Name = "listBoxStorage";
            listBoxStorage.Size = new Size(180, 144);
            listBoxStorage.TabIndex = 9;
            listBoxStorage.SelectedIndexChanged += listBoxStorage_SelectedIndexChanged;
            // 
            // ButtonDelObject
            // 
            ButtonDelObject.Location = new Point(38, 313);
            ButtonDelObject.Margin = new Padding(3, 4, 3, 4);
            ButtonDelObject.Name = "ButtonDelObject";
            ButtonDelObject.Size = new Size(155, 44);
            ButtonDelObject.TabIndex = 8;
            ButtonDelObject.Text = "Удалить набор";
            ButtonDelObject.UseVisualStyleBackColor = true;
            ButtonDelObject.Click += ButtonDelObject_Click;
            // 
            // ButtonAddObject
            // 
            ButtonAddObject.Location = new Point(38, 72);
            ButtonAddObject.Margin = new Padding(3, 4, 3, 4);
            ButtonAddObject.Name = "ButtonAddObject";
            ButtonAddObject.Size = new Size(155, 44);
            ButtonAddObject.TabIndex = 7;
            ButtonAddObject.Text = "Добавить набор";
            ButtonAddObject.UseVisualStyleBackColor = true;
            ButtonAddObject.Click += ButtonAddObject_Click;
            // 
            // textBoxStorageName
            // 
            textBoxStorageName.Location = new Point(23, 29);
            textBoxStorageName.Margin = new Padding(3, 4, 3, 4);
            textBoxStorageName.Name = "textBoxStorageName";
            textBoxStorageName.Size = new Size(180, 27);
            textBoxStorageName.TabIndex = 0;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip.Location = new Point(3, 24);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 3, 0, 3);
            menuStrip.Size = new Size(233, 30);
            menuStrip.TabIndex = 7;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SaveToolStripMenuItem, LoadToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(59, 24);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.Size = new Size(177, 26);
            SaveToolStripMenuItem.Text = "Сохранение";
            SaveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // LoadToolStripMenuItem
            // 
            LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            LoadToolStripMenuItem.Size = new Size(177, 26);
            LoadToolStripMenuItem.Text = "Загрузка";
            LoadToolStripMenuItem.Click += LoadToolStripMenuItem_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            openFileDialog.Filter = "txt file | *.txt";
            openFileDialog.Title = "Сохранить текстовый файл";
            // 
            // saveFileDialog
            // 
            saveFileDialog.Filter = "txt file | *.txt";
            saveFileDialog.Title = "Выберите текстовый файл";
            // 
            // FormSelfPropelledArtilleryUnitCollection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 779);
            Controls.Add(groupBox1);
            Controls.Add(pictureBoxCollection);
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormSelfPropelledArtilleryUnitCollection";
            Text = "Набор арт. установок";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCollection).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonAddUsta;
        private Button ButtonRemoveUsta;
        private Button ButtonRefreshCollection;
        private PictureBox pictureBoxCollection;
        private MaskedTextBox maskedTextBoxNumber;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBoxStorageName;
        private ListBox listBoxStorage;
        private Button ButtonDelObject;
        private Button ButtonAddObject;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem LoadToolStripMenuItem;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private Button ButtonSortByType;
        private Button ButtonSortByColor;
    }
}