using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SelfPropelledArtilleryUnit.DrawningObjects;
using SelfPropelledArtilleryUnit.Drawnings;
using SelfPropelledArtilleryUnit.Generics;
using SelfPropelledArtilleryUnit.MovementStrategy;


namespace SelfPropelledArtilleryUnit
{
    public partial class FormSelfPropelledArtilleryUnitCollection : Form
    {
        private readonly UstaGenericCollection<DrawningUsta, DrawningObjectUsta> _usta;
        public FormSelfPropelledArtilleryUnitCollection()
        {
            InitializeComponent();
            _usta = new UstaGenericCollection<DrawningUsta, DrawningObjectUsta>(pictureBoxCollection.Width, pictureBoxCollection.Height);
        }

        private void ButtonAddUsta_Click(object sender, EventArgs e)
        {
            FormSelfPropelledArtilleryUnit form = new();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (_usta + form.SelectedUsta > -1)
                {
                    MessageBox.Show("Объект добавлен");
                    pictureBoxCollection.Image = _usta.ShowUsta();
                }
                else
                {
                    MessageBox.Show("Не удалось добавить объект");
                }
            }

        }

        private void ButtonRemoveUsta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить объект?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            int pos = Convert.ToInt32(maskedTextBoxNumber.Text);
            if (_usta - pos != null)
            {
                MessageBox.Show("Объект удален");
                pictureBoxCollection.Image = _usta.ShowUsta();
            }
            else
            {
                MessageBox.Show("Не удалось удалить объект");
            }

        }

        private void ButtonRefreshCollection_Click(object sender, EventArgs e)
        {
            pictureBoxCollection.Image = _usta.ShowUsta();
        }
    }
}
