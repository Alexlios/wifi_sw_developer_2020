using System;

namespace WIFI.ToolLibrary
{
    public class RandomAdv : Random
    {
        #region Constructors

        public RandomAdv() : base()
        {

        }

        public RandomAdv(int Seed) : base(Seed)
        {

        }

        #endregion

        #region PublicMethods

        /// <summary>
        /// Generates a random System.String with universal printable ASCII characters
        /// </summary>
        /// <param name="length">The length of the string</param>
        /// <returns>The generated string</returns>
        public string NextString(int length)
        {
            string result = string.Empty;

            for(int i = 0;i < length;++i)
            {
                result += GenerateReadableChar();
            }

            return result;
        }

        #endregion

        #region PrivateMethods

        private char GenerateReadableChar()
        {
            char result;

            switch(Next(0,4))
            {
                case 0://lowercase
                    result = (char)Next(97, 123);//a-z
                    break;

                case 1://uppercase
                    result = (char)Next(65, 91);//A-Z
                    break;

                case 2://number
                    result = (char)Next(48, 58);//0-9
                    break;

                case 3://any printable
                    result = (char)Next(33, 127);//!-~
                    break;

                default:
                    result = ' ';
                    break;
            }

            return result;
        }

        #endregion
    }
}
