using System;
using System.Security.Principal;
using System.Windows.Forms;

namespace TetrisApp.GameHelper
{
    public class ControlToMatris
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mainPanel"></param>
        /// <returns></returns>

        ///<example>
        /// 0-1-2-3-4-5-6-7-8-9-10-11-12-13-14-15 boyle olan diziyi 
        /// {
        ///  {0,0 - 0,1 - 0,2 - 0,3}, 0-1-2-3 (satir 1)
        ///  {1,0 - 1,1 - 1,2 - 1,3}, 4-5-6-7 (satir 2)
        ///  {2,0 - 2,1 - 2,2 - 2,3}, 8-9-10-11 (satir 3)
        ///  {3,0 - 3,1 - 3,2 - 3,3} 12-13-14-15 (satir 4)
        /// } //bu hale getirmek amaç
        /// <code>
        /// public class test
        /// {
        ///      public string[,] testEt()
        ///      {
        ///          string[] test =
        ///          {
        ///            "0.0 satırının değeri", /*0*/
        ///            "0.1 satırının değeri", /*1*/
        ///            "0.2 satırının değeri", /*2*/
        ///            "0.3 satırının değeri", /*3*/
        ///
        ///            "1.0 satırının değeri", /*4*/
        ///            "1.1 satırının değeri", /*5*/
        ///            "1.2 satırının değeri", /*6*/
        ///            "1.3 satırının değeri", /*7*/
        ///
        ///            "2.0 satırının değeri", /*8*/
        ///            "2.1 satırının değeri", /*9*/
        ///            "2.2 satırının değeri", /*10*/
        ///            "2.3 satırının değeri", /*11*/
        ///
        ///            "3.0 satırının değeri", /*12*/
        ///            "3.1 satırının değeri", /*13*/
        ///            "3.2 satırının değeri", /*14*/
        ///            "3.3 satırının değeri"  /*15*/
        ///           };
        ///         int karakoku = int.Parse(Math.Sqrt(test.Length).ToString());
        ///         string[,] testStrings = new string[karakoku, karakoku];    
        ///         int tekboyutIndex = 0;
        ///         for (int i = 0; i < karakoku; i++)
        ///        {
        ///            for (int j = 0; j < karakoku; j++)
        ///            {
        ///                testStrings[i, j] = test[tekboyutIndex];
        ///                tekboyutIndex++;
        ///            }
        ///         }
        ///         return testStrings; 
        ///      } 
        /// }
        /// class Program()
        /// {
        ///    static void Main()
        ///    {
        ///       test _test = new test();
        ///       var testt = _test.testEt();
        ///       string result = "";
        ///        for (int i = 0; i <= testt.GetUpperBound(0); i++)
        ///       {
        ///           for (int j = 0; j <= testt.GetUpperBound(1); j++)
        ///          {
        ///              result += $"{i}.satir {j}.sütun degeri :{testt[i, j]} \n";
        ///          }
        ///       }
        ///       MessageBox.Show(result);
        ///    }
        /// }
        /// </code>
        /// </example>
        public Block[,] ConvertMatris(Panel mainPanel)
        {   //not: block sınıfı panel sınıfından miras alınmıştır.
            GameSetting setting = new GameSetting();
            Panel mainControl = mainPanel.Controls[setting.BlockName] as Panel;
            Control.ControlCollection controlCollection = mainControl.Controls;
            int karakoku = int.Parse(Math.Sqrt(controlCollection.Count).ToString());
            if (controlCollection.Count == 16)
            {
                Block[,] controlMatrix = new Block[karakoku, karakoku];
                int tekboyutIndex = 0;
                for (int i = 0; i < karakoku; i++)
                {
                    for (int j = 0; j < karakoku; j++)
                    {
                        controlMatrix[i, j] = controlCollection[tekboyutIndex] as Block;
                        tekboyutIndex++;
                    }
                }
                return controlMatrix;
            }
            else
            {
                throw new ArgumentOutOfRangeException(mainPanel.Name, "Control sayısı 16'yı geçmemelidir.");
            }

        }
    }
}
