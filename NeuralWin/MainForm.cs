using System;
using System.Globalization;
using System.Windows.Forms;

namespace NeuralWin
{
    public partial class UIMainForm : Form
    {
        public UIMainForm()
        {
            InitializeComponent();
        }

        Network _network;
        FileReader _inputFile;
        private double _effectivity;
        private int _errorRate;

        private void UIReadDataButton_Click(object sender, EventArgs e)
        {
            _inputFile = new FileReader();
            _network = new Network(35);
        }

        private void UIEducationOnTrainingDataButton_Click(object sender, EventArgs e)
        {
            for (int j=0; j<100;j++)
            {
                for (int i = 0; i < 460; i++)
                {
                    _network.Teach(_inputFile.GetTrainingDatasetEntrance(i), _inputFile.GetTrainingDatasetValid(i));
                }
            }
        }

        private void UIEducationOnValidateDataButton_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 100; j++)
            {
                for (int i = 0; i < 230; i++)
                {
                    _network.Teach(_inputFile.GetValidDatasetEntrance(i), _inputFile.GetValidDatasetValid(i));
                }
            }
        }

        private void UIEducationOnTestDataButton_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 100; j++)
            {
                for (int i = 0; i < 230; i++)
                {
                    _network.Teach(_inputFile.GetTestDatasetEntrance(i), _inputFile.GetTestDatasetValid(i));
                }
            }
        }

        private void UICheckOnTrainingDataButton_Click(object sender, EventArgs e)
        {
            _effectivity = 0;
           
            for (int i = 0; i < 460; i++)
            {
                if (_network.Validate(_inputFile.GetTrainingDatasetEntrance(i), _inputFile.GetTrainingDatasetValid(i)))
                {
                    _effectivity++;
                }
            }              
            UIErrorRateOnTrainingDataTextBox.Text = ErrorRate(460);
        }

        private void UICheckOnValidateDataButton_Click(object sender, EventArgs e)
        {
            _effectivity = 0;

            for (int i = 0; i < 230; i++)
            {
                if (_network.Validate(_inputFile.GetValidDatasetEntrance(i), _inputFile.GetValidDatasetValid(i)))
                {
                    _effectivity++;
                }
            }
            UIErrorRateOnValidateDataTextBox.Text = ErrorRate(230);
        }

        private void UICheckOnTestDataButton_Click(object sender, EventArgs e)
        {
            _effectivity = 0;

            for (int i = 0; i < 230; i++)
            {
                if (_network.Validate(_inputFile.GetTestDatasetEntrance(i), _inputFile.GetTestDatasetValid(i)))
                {
                    _effectivity++;
                }
            }
            UIErrorRateOnTestDataTextBox.Text = ErrorRate(230);
        }

        private string ErrorRate(int count)
        {
            _effectivity /= count;
            _errorRate = (int)((1 - _effectivity));

            return _errorRate.ToString(CultureInfo.InvariantCulture) + "%";
        }
    }
}
