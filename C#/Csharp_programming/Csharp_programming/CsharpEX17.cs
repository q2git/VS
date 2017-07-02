using System;

//例17 洗牌和发牌

//构建一个扑克牌的洗牌和发牌类，完成洗牌和发牌；

namespace CsharpEX17

{

    class Program

    {

        public static void Example17()

        {

            Card card = new Card();

            card.deal();

            card.Shuffle();

            card.deal();

        }

    }

    struct CNode

    {

        public char suit;

        public string face;

    }

    enum CardNum

    {

        CARDNUMBER = 52,

        SUITNUMBER = 4,

        FACENUMBER = 13

    }

    class Card

    {

        //定义扑克牌的数组

        private CNode[] deck;

        public Card()

        {

            deck = new CNode[(int)CardNum.CARDNUMBER];

            //Heart,Diamod,Club,Spade

            char[] suit = { (char)3, (char)4, (char)5, (char)6 };

            string[] face = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            for (int i = 0; i < (int)CardNum.CARDNUMBER; i++)

            {

                deck[i].face = face[i % (int)CardNum.FACENUMBER];

                deck[i].suit = suit[i / (int)CardNum.FACENUMBER];

            }

        }

        public void deal()

        {

            Console.Write("================");

            Console.Write("52张牌的发牌次序");

            Console.Write("================");

            Console.WriteLine();

            Console.WriteLine(" 甲 乙 丙 丁");

            for (int i = 0; i < (int)CardNum.CARDNUMBER; i++)

            {

                Console.Write("第{0,2}张：{1} {2}\t", i + 1, deck[i].suit, deck[i].face);

                if ((i + 1) % 4 == 0)

                    Console.WriteLine();

            }

            Console.WriteLine();

        }

        public void Shuffle()

        {

            int j;

            CNode temp;

            Random r = new Random();

            for (int i = 0; i < (int)CardNum.CARDNUMBER; i++)

            {

                j = r.Next((int)CardNum.CARDNUMBER);

                temp = deck[i];

                deck[i] = deck[j];

                deck[j] = temp;

            }

        }

    }

}

