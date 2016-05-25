using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_Metodlar_ExtentionMetodlar
{
    public static class MyExtentions//static olmak zorunda:erişim için statik olmazsa programdan erişebilmek için sürekli nesne luştumak zorunda kalırım.
    {
        public static int ToInt32(this string str)
        {
            return Convert.ToInt32(str);
        }
        /// <summary>
        /// girilen texti büyük harflae girer.
        /// </summary>
        /// <param name="str">metin ifsde</param>
        /// <param name="hepsiBuyukmu">true false değer giriniz.</param>
        /// <returns></returns>
        public static string BuyukHarf(this string str, bool hepsiBuyukmu)
        {
            if (hepsiBuyukmu)

                return str.ToUpper();
            else
                return str;
        }





    }
}
