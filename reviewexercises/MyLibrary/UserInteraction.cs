using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public static class UserInteraction
    {
        public static float UserInputFloat()
        {
            float userNum;
            try
            {
                userNum = float.Parse(Console.ReadLine());
            }
            catch
            {
                userNum = 0.0f;
            }
            return userNum;
        }
    }
}
