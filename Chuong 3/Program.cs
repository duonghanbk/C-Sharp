using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong_3
{
    class Program

    {
        enum SoTuoi
        {
            TuoiCha = 60,
            TuoiCon = 10,
            TuoiMe = 55,
            TuoiVo = 20,
            TuoiChong,
        }
        static void Main()
        {
            Console.WriteLine("Hello World");

            //------------------------------------------------
            //BIEN

            //khoi tao bien(C# bat buoc phai khoi tao bien)
            //khong giong nhu C hay C++ chi can ten bien
            int bien = 100;
            Console.WriteLine("Khoi tao bien = {0}",bien);
            //gan bien
            bien = 10;
            Console.WriteLine("Sau khi gan bien = {0}",bien);
            //y = (short)x;
            //------------------------------------------------



            //----------------------------------------
            //HANG

            //khoi tao hang

            const int tuoi = 20;
            Console.WriteLine(" Tuoi = {0}", tuoi);
            //khi gan hang bang gia tri khac

            //tuoi = 30;

            /*chuong trinh se bao loi: error CS0131: The left-hand side of
             * an assignment must be a variable,
			property or indexer.*/
            //----------------------------------------

            //KIEU LIET KE HANG: Dung enum
            //-------------------------------------------------------
           

			Console.WriteLine("Tuoi cua vo: {0}" , SoTuoi.TuoiVo);
			Console.WriteLine("Tuoi cua chong: {0}", SoTuoi.TuoiChong);
			//-------------------------------------------------------
            Console.ReadKey();
            
        }
    }
}
