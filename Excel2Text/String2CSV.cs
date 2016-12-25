using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace Excel2Text
{
    public partial class String2CSV : Form
    {
        public String2CSV(string inputString)
        {
            InitializeComponent();
            textBoxHexValues.Clear();
            displayStringInTextBox(inputString);
            angle = new AngleShort();
        }

        private string showMessage
        {
            set
            {
                MessageBox.Show(value);
            }
        }

        [StructLayout(LayoutKind.Explicit)]
    struct AngleShort
    {
        [FieldOffset(0)]
        public byte AfterDecimal;
        [FieldOffset(1)]
        public byte BeforeDecimal;           
        [FieldOffset(0)]
        public UInt16 ShortAngle;
    }
        AngleShort angle;
    private void displayStringInTextBox(string inputString)
        {
            var angleStrings = inputString.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);          
            var angleValue = new List<ushort>();
            for (var index=0; index<angleStrings.Count(); index++)
            {
              var angleStringValue = angleStrings[index].Split('.');

                if (angleStrings[index].Length > 1)
                {
                    if (angleStringValue.Count() == 2) //Decimal Point found 
                    {
                        if (angleStringValue[1].Split('E').Count() == 1) //Means there's no Exponential
                        {
                            string afterDecimalString;
                            var beforeDecimalString = angleStringValue[0];
                            if (angleStringValue[1].Count() > 1)
                            {
                                afterDecimalString = angleStringValue[1].Substring(0, 2);//Two Digits only
                                byte.TryParse(afterDecimalString, out angle.AfterDecimal);
                                byte.TryParse(beforeDecimalString, out angle.BeforeDecimal);


                                if (angleStringValue[1].Count() > 2) //For Round off
                                {
                                    var thirdDecimalValue = angleStringValue[1].ElementAt(2);

                                    if (thirdDecimalValue - 48 > 4) //Rounding off value
                                    {
                                        angle.AfterDecimal++;
                                        if (angle.AfterDecimal > 99)
                                            angle.BeforeDecimal++;
                                    }
                                }
                            }
                            angleValue.Insert(index, angle.ShortAngle);
                        }
                        else
                            angleValue.Insert(index, 0);
                    }
                    else
             if (angleStringValue.Count() == 1) //No Decimal Point
                    {
                        angle.AfterDecimal = 0;
                        byte.TryParse(angleStringValue[0], out angle.BeforeDecimal);
                        angleValue.Insert(index, angle.ShortAngle);
                    }
                }
                else break;
             
                textBoxHexValues.AppendText(Convert.ToString((index+1)*2)+"\t\t"+angleValue[index].ToString("X4") + "\n");
                textBoxCSV.AppendText(Convert.ToString(angleValue[index]) + ",");
            }
            //removing last , from CSV textBox
            try
            {
                var lastText = textBoxCSV.TextLength;
                textBoxCSV.Select(lastText - 1, lastText);
                textBoxCSV.ReadOnly = false;
                if (textBoxCSV.SelectedText == ",")
                    textBoxCSV.SelectedText = "";
                textBoxCSV.ReadOnly = true;
            }
            catch (Exception)
            {
                showMessage = "Data isn't in proper format";
            }
           
        }

        private void buttonSaveCSVFile_Click(object sender, EventArgs e)
        {
            try
            {
                var res = saveFileDialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    var fileName = saveFileDialog.FileName;
                    using (StreamWriter fs = new StreamWriter(fileName, true))
                    {
                      
                        fs.Write(textBoxCSV.Text);
                        fs.Flush(); 
                    }
                }

            }
            catch (Exception)
            {
                showMessage = "Error in saving Image, did you open or made New file?";
            }
        }
    }
}
