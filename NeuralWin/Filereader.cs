using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuralWin
{
    class FileReader
    {
        private readonly ArrayList _datasetEntrance;
        private readonly ArrayList _datasetValid;


        public double[] GetTrainingDatasetEntrance(int row)
        {
            return (double[])_datasetEntrance[row];
        }

        public double[] GetTrainingDatasetValid(int row)
        {
            return (double[])_datasetValid[row];
        }

        public double[] GetValidDatasetEntrance(int row)
        {
            return (double[])_datasetEntrance[460+row];
        }

        public double[] GetValidDatasetValid(int row)
        {
            return (double[])_datasetValid[460+row];
        }

        public double[] GetTestDatasetEntrance(int row)
        {
            return (double[])_datasetEntrance[460+230+row];
        }

        public double[] GetTestDatasetValid(int row)
        {
            return (double[])_datasetValid[460+230+row];
        }

        public FileReader()
        {
            _datasetEntrance = new ArrayList();
            _datasetValid = new ArrayList();

            int _counter = 0;
            string line;

 
            var file = new System.IO.StreamReader("heart3.dt");

            while ((line = file.ReadLine()) != null)
            {

                var entranceValues = new double[35];
                var validValues = new double[2];
                String s;
                int k = 0;
                while (k < 35)
                {
                    s = line.Substring(0, line.IndexOf(" "));
                    s = s.Replace(".", ",");
                    entranceValues[k] = Convert.ToDouble(s);
                    line = line.Substring(line.IndexOf(" ") + 1, line.Length - line.IndexOf(" ") - 1);
                    k++;
                }

                k = 0;

                s = line.Substring(0, line.IndexOf(" "));
                s = s.Replace(".", ",");
                validValues[0] = Convert.ToDouble(s);
                line = line.Substring(line.IndexOf(" ") + 1, line.Length - line.IndexOf(" ") - 1);

                s = line.Replace(".", ",");
                validValues[1] = Convert.ToDouble(s);
                line = line.Substring(line.IndexOf(" ") + 1, line.Length - line.IndexOf(" ") - 1);


                _datasetEntrance.Add(entranceValues);
                _datasetValid.Add(validValues);

                _counter++;
            }
            file.Close();
        }
    }
}
