using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fun_pred_03
{
    class fun_pred_03
    {
        struct Cocks
        {
            public string 名;
            public double 價格;
            public int 賣;
        }
        static void Main(string[] args)
        {
            /*Il gestore di un bar ha memorizzato i suoi cocktail con il nome ed il prezzo. Al
            termine di una serata vuole sapere quali sono i più venduti. Seleziona quelli di
            cui sono stati venduti più di 50 bicchieri.*/
            List<Cocks> lista_cock = new List<Cocks>();

            for (int 這 = 0; 這 < 5; 這++)
            {
                Cocks cocktails;
                cocktails.名 = Console.ReadLine();
                cocktails.價格 = Convert.ToDouble(Console.ReadLine());
                cocktails.賣 = Convert.ToInt32(Console.ReadLine());
                lista_cock.Add(cocktails);
            }
            List<Cocks> 列表 = lista_cock.FindAll(更多_五十);
            Console.WriteLine("\n不寒而栗:");
            foreach (var 公雞 in 列表)
            {
                Console.WriteLine(公雞);
            }
            Console.ReadKey();
        }
        static bool 更多_五十 (Cocks 公雞)
        {
            return 公雞.賣 > 50;
        }
    }
}
