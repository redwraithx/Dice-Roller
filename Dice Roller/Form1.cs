using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Dice_Roller
{
    public partial class Form1 : Form
    {
        
        


        AppLogic _diceRoller = new AppLogic();


        public Form1()
        {
            InitializeComponent();
            OneDiceRadioSelectedGroupChanger(); // make sure you can see the right forms at the start

            // Dice Roller App init functions
            SetDefaultDiceValues();


            // hide this form
            //CardDeckForm.instance = new CardDeckForm();
            ////CardDeckForm.instance.Parent = this;
            
            //CardDeckForm.instance.Visible = true;

        }

        private void SetDefaultDiceValues()
        {
            // update all dice boxes to low Number = 1 and high Number = 6;
            oneDiceLowNumber.Text = "1";
            oneDiceHighNumber.Text = "6";

            threeDiceLowNumber1.Text = "1";
            threeDiceLowNumber2.Text = "1";
            threeDiceLowNumber3.Text = "1";
            threeDiceHighNumber1.Text = "6";
            threeDiceHighNumber2.Text = "6";
            threeDiceHighNumber3.Text = "6";

            // Set Default textbox max length

            // One Dice MaxLength Setup
            oneDiceHighNumber.MaxLength = 2;

            // Three Dice MaxLength Setup
            threeDiceHighNumber1.MaxLength = 2;
            threeDiceHighNumber2.MaxLength = 2;
            threeDiceHighNumber3.MaxLength = 2;
        }

        private void oneDiceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _diceRoller.IsOneDiceRadioSelected(true);
            OneDiceRadioSelectedGroupChanger();

            //MessageLabel.Text = _diceRoller.GetRadioSelection().ToString(); // /////////////////////////////
        }

        private void OneDiceRadioSelectedGroupChanger()
        {
            // Enable The One Dice Roll Group
            OneDiceRollGroup.Visible = true;
            OneDiceRollGroup.Enabled = true;
            oneDiceRollResultsGroupBox.Visible = true;
            oneDiceRollResultsGroupBox.Enabled = true;

            // Disable The Three Dice Rolls Group
            ThreeDiceRollGroup.Visible = false;
            ThreeDiceRollGroup.Enabled = false;
            threeDiceRollResultsGroupBox.Visible = false;
            threeDiceRollResultsGroupBox.Enabled = false;

        }

        private void threeDiceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _diceRoller.IsOneDiceRadioSelected(false);
            ThreeDiceRadioSelectedGroupChanger();

            //MessageLabel.Text = _diceRoller.GetRadioSelection().ToString(); // ////////////////////////
        }

        private void ThreeDiceRadioSelectedGroupChanger()
        {
            // Disable The One Dice Roll Group
            OneDiceRollGroup.Visible = false;
            OneDiceRollGroup.Enabled = false;
            oneDiceRollResultsGroupBox.Visible = false;
            oneDiceRollResultsGroupBox.Enabled = false;

            // Enable The Three Dice Rolls Group
            ThreeDiceRollGroup.Visible = true;
            ThreeDiceRollGroup.Enabled = true;
            threeDiceRollResultsGroupBox.Visible = true;
            threeDiceRollResultsGroupBox.Enabled = true;
        }

        private void oneDiceRollButton_Click(object sender, EventArgs e)
        {
            int n;
            bool isStringANumber = int.TryParse(oneDiceHighNumber.Text, out n);

            //MessageLabel.Text = n.ToString();

            if (string.IsNullOrEmpty(oneDiceHighNumber.Text) || isStringANumber == false)
            {
                return;
            }


            // lets do the math
            int oneDiceRoll = _diceRoller.OneDiceGetRandomValueAndReturnValue();

            // set results to RichTextBox
            oneDiceRollResultTextbox.Text = oneDiceRoll.ToString();
            oneDiceRollResultTextbox.SelectAll();
            oneDiceRollResultTextbox.SelectionAlignment = HorizontalAlignment.Center;
            //oneDiceRollResult.SelectionAlignment = VerticalAlignment.Center;
        }

        private void oneDiceHighNumber_TextChanged(object sender, EventArgs e)
        {
            // prevent any character from being entered.
            if (oneDiceHighNumber.Text.Length == 0)
            {
                return;
            }

            string testString = oneDiceHighNumber.Text;

            int result;
            bool isValid = int.TryParse(testString, out result);
            if (!isValid)
            {
                oneDiceHighNumber.Text = testString.Remove(testString.Length - 1);
                oneDiceHighNumber.SelectionStart = testString.Length;
            }// END of char prevention



            int userVal;
            bool isStringANumber = int.TryParse(oneDiceHighNumber.Text, out userVal);

            if (string.IsNullOrEmpty(oneDiceHighNumber.Text) || isStringANumber == false)
            {
                // clear the roll result Text
                oneDiceRollResultTextbox.Text = "";

                // disable rolling button
                oneDiceRollButton.Enabled = false;

                return;
            }

            // set variable to new value
            if (!_diceRoller.GetAppInitializingStatus())
            {
                int num;
                if(!(int.TryParse(oneDiceHighNumber.Text, out num)))
                {
                    oneDiceHighNumber.Text = "";

                    return;
                }


                _diceRoller.SetOneDiceHighNumber(num);
                oneDiceHighNumber.Text = _diceRoller.GetOneDiceHighNumber().ToString();
                //message2lbl.Text = _diceRoller.GetOneDiceHighNumber().ToString();
                //oneDiceRollResultsTextbox.SelectAll();
                //oneDiceRollResultsTextbox.SelectionAlignment = HorizontalAlignment.Center;
            }

            // enable the button to allow the maths to begin
            oneDiceRollButton.Enabled = true;
        }



        private void oneDiceHighNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) /*&& (e.KeyChar != '.')*/)
            //{
            //    //e.Handled = true;
            //}
        }



        private void threeDiceHighNumber1_TextChanged(object sender, EventArgs e)
        {
            // prevent any character from being entered.
            if (threeDiceHighNumber1.Text.Length == 0)
            {
                return;
            }

            string testString = threeDiceHighNumber1.Text;

            int result;
            bool isValid = int.TryParse(testString, out result);
            if (!isValid)
            {
                threeDiceHighNumber1.Text = testString.Remove(testString.Length - 1);
                threeDiceHighNumber1.SelectionStart = testString.Length;
            }// END of char prevention


            //int n;
            //bool isStringANumber = int.TryParse(threeDiceHighNumber1.Text, out n);

            //if (string.IsNullOrEmpty(threeDiceHighNumber1.Text) || isStringANumber == false)
            //{
            //    threeDiceRollButton.Enabled = false;

            //    return;
            //}

            //threeDiceRollButton.Enabled = true;


            int userVal;
            bool isStringANumber = int.TryParse(threeDiceHighNumber1.Text, out userVal);

            if (string.IsNullOrEmpty(threeDiceHighNumber1.Text) || isStringANumber == false)
            {
                // clear the roll result Text
                threeDiceRollResultTextbox1.Text = "";

                // disable rolling button
                threeDiceRollButton.Enabled = false;

                return;
            }

            // set variable to new value
            if (!_diceRoller.GetAppInitializingStatus())
            {
                int num;
                if (!(int.TryParse(threeDiceHighNumber1.Text, out num)))
                {
                    threeDiceHighNumber1.Text = "";

                    return;
                }


                _diceRoller.SetThreeDiceHighNumber1(num);
                threeDiceHighNumber1.Text = _diceRoller.GetThreeDiceHighNumber1().ToString();
                //message2lbl.Text = _diceRoller.GetThreeDiceHighNumber1().ToString();
                //oneDiceRollResultsTextbox.SelectAll();
                //oneDiceRollResultsTextbox.SelectionAlignment = HorizontalAlignment.Center;
            }

            // enable the button to allow the maths to begin
            threeDiceRollButton.Enabled = true;
        }

        private void threeDiceHighNumber2_TextChanged(object sender, EventArgs e)
        {
            // prevent any character from being entered.
            if (threeDiceHighNumber2.Text.Length == 0)
            {
                return;
            }

            string testString = threeDiceHighNumber2.Text;

            int result;
            bool isValid = int.TryParse(testString, out result);
            if (!isValid)
            {
                threeDiceHighNumber2.Text = testString.Remove(testString.Length - 1);
                threeDiceHighNumber2.SelectionStart = testString.Length;
            }// END of char prevention

            //int n;
            //bool isStringANumber = int.TryParse(threeDiceHighNumber2.Text, out n);

            //if (string.IsNullOrEmpty(threeDiceHighNumber2.Text) || isStringANumber == false)
            //{
            //    threeDiceRollButton.Enabled = false;

            //    return;
            //}

            //threeDiceRollButton.Enabled = true;



            int userVal;
            bool isStringANumber = int.TryParse(threeDiceHighNumber2.Text, out userVal);

            if (string.IsNullOrEmpty(threeDiceHighNumber2.Text) || isStringANumber == false)
            {
                // clear the roll result Text
                threeDiceRollResultTextbox2.Text = "";

                // disable rolling button
                threeDiceRollButton.Enabled = false;

                return;
            }

            // set variable to new value
            if (!_diceRoller.GetAppInitializingStatus())
            {
                int num;
                if (!(int.TryParse(threeDiceHighNumber2.Text, out num)))
                {
                    threeDiceHighNumber2.Text = "";

                    return;
                }


                _diceRoller.SetThreeDiceHighNumber2(num);
                threeDiceHighNumber2.Text = _diceRoller.GetThreeDiceHighNumber2().ToString();
                //message2lbl.Text = _diceRoller.GetThreeDiceHighNumber2().ToString();
                //oneDiceRollResultsTextbox.SelectAll();
                //oneDiceRollResultsTextbox.SelectionAlignment = HorizontalAlignment.Center;
            }

            // enable the button to allow the maths to begin
            threeDiceRollButton.Enabled = true;
        }

        private void threeDiceHighNumber3_TextChanged(object sender, EventArgs e)
        {
            // prevent any character from being entered.
            if (threeDiceHighNumber3.Text.Length == 0)
            {
                return;
            }

            string testString = threeDiceHighNumber3.Text;

            int result;
            bool isValid = int.TryParse(testString, out result);
            if (!isValid)
            {
                threeDiceHighNumber3.Text = testString.Remove(testString.Length - 1);
                threeDiceHighNumber3.SelectionStart = testString.Length;
            }// END of char prevention

            //int n;
            //bool isStringANumber = int.TryParse(threeDiceHighNumber1.Text, out n);

            //if (string.IsNullOrEmpty(threeDiceHighNumber3.Text) || isStringANumber == false)
            //{
            //    threeDiceRollButton.Enabled = false;

            //    return;
            //}

            //threeDiceRollButton.Enabled = true;



            int userVal;
            bool isStringANumber = int.TryParse(threeDiceHighNumber3.Text, out userVal);

            if (string.IsNullOrEmpty(threeDiceHighNumber3.Text) || isStringANumber == false)
            {
                // clear the roll result Text
                threeDiceRollResultTextbox3.Text = "";

                // disable rolling button
                threeDiceRollButton.Enabled = false;

                return;
            }

            // set variable to new value
            if (!_diceRoller.GetAppInitializingStatus())
            {
                int num;
                if (!(int.TryParse(threeDiceHighNumber3.Text, out num)))
                {
                    threeDiceHighNumber3.Text = "";

                    return;
                }


                _diceRoller.SetThreeDiceHighNumber3(num);
                threeDiceHighNumber3.Text = _diceRoller.GetThreeDiceHighNumber3().ToString();
                //message2lbl.Text = _diceRoller.GetThreeDiceHighNumber3().ToString();
                //oneDiceRollResultsTextbox.SelectAll();
                //oneDiceRollResultsTextbox.SelectionAlignment = HorizontalAlignment.Center;
            }

            // enable the button to allow the maths to begin
            threeDiceRollButton.Enabled = true;
        }

        private void threeDiceRollButton_Click(object sender, EventArgs e)
        {
            int _diceCount = 3;

            // temp arrays for form varaible names.
            TextBox[] _diceNum = { threeDiceHighNumber1, threeDiceHighNumber2, threeDiceHighNumber3 };
            RichTextBox[] _diceNumResults = { threeDiceRollResultTextbox1, threeDiceRollResultTextbox2, threeDiceRollResultTextbox3 };
            
            

            for (int i = 0; i < _diceCount; i++)
            {
                int tempNum;
                bool isStringANumber = int.TryParse(_diceNum[i].Text, out tempNum);

                //MessageLabel.Text = tempNum.ToString();

                if (string.IsNullOrEmpty(_diceNum[i].Text) || isStringANumber == false)
                {
                    return;
                }


                // lets do the math
                int oneDiceRoll;

                if (i == 0)
                {
                    oneDiceRoll = _diceRoller.ThreeDiceGetRandomValueAndReturnValue(_diceRoller.GetThreeDiceLowDice(i), _diceRoller.GetThreeDiceHighDice(i));
                }
                else
                {
                    if(i == 1)
                        oneDiceRoll = _diceRoller.ThreeDiceGetRandomValueAndReturnValue(_diceRoller.GetThreeDiceLowDice(i), _diceRoller.GetThreeDiceHighDice(i));
                    else // if(i == 2
                        oneDiceRoll = _diceRoller.ThreeDiceGetRandomValueAndReturnValue(_diceRoller.GetThreeDiceLowDice(i), _diceRoller.GetThreeDiceHighDice(i));
                }

    //MessageBox.Show("One dice roll: " + _diceRoller.GetThreeDiceHighDice(0).ToString());    

                // set results to RichTextBox
                _diceNumResults[i].Text = oneDiceRoll.ToString();
                _diceNumResults[i].SelectAll();
                _diceNumResults[i].SelectionAlignment = HorizontalAlignment.Center;
                //oneDiceRollResult.SelectionAlignment = VerticalAlignment.Center;
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            MessageBox.Show("Random Dice Roller Application\n_________________________________\n\nVersion: 1.010.1081a\nCreated by: Brian Purdy");
        }
    }
}
