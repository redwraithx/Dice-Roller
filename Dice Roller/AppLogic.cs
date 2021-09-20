using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Roller
{
    class AppLogic
    {
        public AppLogic()
        {
            // one Dice Initial Setup


            _appInitializing = false;
        }

        internal RNGCryptoServiceProvider Rand = new RNGCryptoServiceProvider();



        



        // One Dice Variables
        private const int _oneDiceLowNumber = 1;
        private int _oneDiceHighNumber = 6;

        // Three Dice Variables
        private const int _threeDiceLowNumber1 = 1;
        private int _threeDiceHighNumber1 = 6;
        private const int _threeDiceLowNumber2 = 1;
        private int _threeDiceHighNumber2 = 6;
        private const int _threeDiceLowNumber3 = 1;
        private int _threeDiceHighNumber3 = 6;

        private bool _oneDiceSelected = true;
        private bool _appInitializing = true;

        internal bool GetAppInitializingStatus()
        {
            return _appInitializing;
        }
        internal void UpdateAppInitializingBool()
        {
            _appInitializing = false;
        }

        // One Dice Functions
        #region OneDiceFunctions
        
        internal void SetOneDiceHighNumber(int value)
        {
            _oneDiceHighNumber = value;
        }

        internal int GetOneDiceHighNumber()
        {
            return _oneDiceHighNumber;
        }

        internal int GetOneDiceLowNumber()
        {
            return _oneDiceLowNumber;
        }

        internal int OneDiceGetRandomValueAndReturnValue()
        {

            //random = new System.Random(); // create this variable at the start and just update the system.random() per use

            return RandomInteger(_oneDiceLowNumber, _oneDiceHighNumber + 1);

            //return random.Next(_oneDiceLowNumber, _oneDiceHighNumber + 1);
        }

        #endregion // OneDiceFunctions




        // Three Dice Functions
        #region ThreeDiceFunctions

        internal int GetThreeDiceHighDice(int id)
        {
            switch (id)
            {
                case 0:
                    {
                        return _threeDiceHighNumber1;
                    }

                case 1:
                    {
                        return _threeDiceHighNumber2;
                    }

                case 2:
                    {
                        return _threeDiceHighNumber3;
                    }

                default:
                    MessageBox.Show("What you entered was completely wrong!");
                    break;
            }



            return 6;
        }



        internal int GetThreeDiceLowDice(int id)
        {
            switch (id)
            {
                case 0:
                    {
                        return _threeDiceLowNumber1;
                    }

                case 1:
                    {
                        return _threeDiceLowNumber2;
                    }

                case 2:
                    {
                        return _threeDiceLowNumber3;
                    }

                default:
                    MessageBox.Show("What you entered was completely wrong!");
                    break;
            }



            return 1;
        }


        internal int ThreeDiceGetRandomValueAndReturnValue(int lowNumber, int highNumber)
        {
            int newRand;
            
            newRand = RandomInteger(lowNumber, highNumber + 1);

            return newRand;
        }


        internal int RandomInteger(int min, int max)
        {
            uint scale = uint.MaxValue;

            while (scale == uint.MaxValue)
            {
                byte[] four_bytes = new byte[4];
                Rand.GetBytes(four_bytes);

                scale = BitConverter.ToUInt32(four_bytes, 0);
            }

            return (int)(min + (max - min) * (scale / (double)uint.MaxValue));

        }

        #endregion // ThreeDiceFunctions




        // Radio Button Functions
        #region RadioButtonStuff

        internal bool GetRadioSelection()
        {
            return _oneDiceSelected;
        }

        internal void IsOneDiceRadioSelected(bool oneDiceSelectedIsTrue)
        {
            //_oneDiceSelected = !_oneDiceSelected;

            switch (oneDiceSelectedIsTrue)
            {
                case false:
                    _oneDiceSelected = false;
                    break;

                case true:
                    _oneDiceSelected = true;
                    break;
            }
        }

        internal void SetThreeDiceHighNumber1(int value)
        {
            _threeDiceHighNumber1 = value;
        }

        internal void SetThreeDiceHighNumber2(int value)
        {
            _threeDiceHighNumber2 = value;
        }

        internal void SetThreeDiceHighNumber3(int value)
        {
            _threeDiceHighNumber3 = value;
        }

        internal int GetThreeDiceHighNumber1()
        {
            return _threeDiceHighNumber1;
        }

        internal int GetThreeDiceHighNumber2()
        {
            return _threeDiceHighNumber2;
        }

        internal int GetThreeDiceHighNumber3()
        {
            return _threeDiceHighNumber3;
        }

        internal int GetThreeDiceLowNumber1()
        {
            return _threeDiceLowNumber1;
        }

        internal int GetThreeDiceLowNumber2()
        {
            return _threeDiceLowNumber2;
        }

        internal int GetThreeDiceLowNumber3()
        {
            return _threeDiceLowNumber3;
        }

        #endregion // RadioButtonStuff

    }



}
