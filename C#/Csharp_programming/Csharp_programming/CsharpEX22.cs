using System;

//例22 包裹投递

namespace CsharpEX22

{

    class Program

    {

        public static void Example()

        {

            ThreedayPackage tp = new ThreedayPackage("XIAOWANG", "XIAOMING",

            "XIAN", 900m, 0.234m, 0.02m); //m represents a decimal number

            Console.WriteLine(tp.CalculateCost());

        }

    }

    class Package

    {

        protected string SenderName { get; set; }

        protected string ReciverName { get; set; }

        protected string Address { get; set; }

        protected decimal weight;

        protected decimal fee;

        public Package(string sn, string rn, string adr, decimal w, decimal f)

        {

            SenderName = sn;

            ReciverName = rn;

            Address = adr;

            Weight = w;

            Fee = f;

        }

        protected decimal Weight

        {

            get

            {

                return weight;

            }

            set

            {

                if (value > 0)

                    weight = value;

                else

                    weight = 0;

            }

        }

        protected decimal Fee

        {

            get

            {

                return fee;

            }

            set

            {

                if (value > 0)

                    fee = value;

                else

                    fee = 0;

            }

        }

        public decimal CalculateCost()

        {

            return fee * weight;

        }

    }

    class ThreedayPackage : Package

    {

        protected decimal exFee;

        protected decimal ExFee

        {

            get

            {

                return exFee;

            }

            set

            {

                if (value > 0)

                    exFee = value;

                else

                    exFee = 0;

            }

        }

        public ThreedayPackage(string sn, string rn, string adr, decimal w, decimal f, decimal ex)

        : base(sn, rn, adr, w, f)

        {

            exFee = ex;

        }

        public new decimal CalculateCost()

        {

            return base.CalculateCost() + weight * exFee;

        }

    }

}