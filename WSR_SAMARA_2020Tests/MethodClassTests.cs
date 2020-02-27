using Microsoft.VisualStudio.TestTools.UnitTesting;
using WSR_SAMARA_2020;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSR_SAMARA_2020.Tests
{
    [TestClass()]
    public class MethodClassTests
    {
        IMethodClass mc = new MethodClass();
        
        ChessBoard chessBoard = new ChessBoard
        {
            chessCells = new List<ChessCell>
                {
                   new ChessCell {  C='c' , I =2 , Color='w'  },
                   new ChessCell {  C='c' , I =3 , Color='b'  },
                   new ChessCell {  C='c' , I =4 , Color='w'  },
                   new ChessCell {  C='c' , I =5 , Color='b' ,  figure = new Figure { Name='п' , Color ='b' }  },
                   new ChessCell {  C='c' , I =6 , Color='w'  },

                   new ChessCell {  C='d' , I =2 , Color='b' , figure = new Figure { Name ='п' , Color ='w' } },
                   new ChessCell {  C='d' , I =3 , Color='w'  },
                   new ChessCell {  C='d' , I =4 , Color='b'  },
                   new ChessCell {  C='d' , I =5 , Color='w'  },
                   new ChessCell {  C='d' , I =6 , Color='b'  },

                   new ChessCell {  C='e' , I =2 , Color='w'  },
                   new ChessCell {  C='e' , I =3 , Color='b'  },
                   new ChessCell {  C='e' , I =4 , Color='w', figure =new Figure {Name='к', Color='w' } },
                   new ChessCell {  C='e' , I =5 , Color='b'  },
                   new ChessCell {  C='e' , I =6 , Color='w'  },

                   new ChessCell {  C='f' , I =2 , Color='b'  },
                   new ChessCell {  C='f' , I =3 , Color='w'  },
                   new ChessCell {  C='f' , I =4 , Color='b'  },
                   new ChessCell {  C='f' , I =5 , Color='w'  },
                   new ChessCell {  C='f' , I =6 , Color='b'  },

                   new ChessCell {  C='g' , I =2 , Color='w'  },
                   new ChessCell {  C='g' , I =3 , Color='b'  },
                   new ChessCell {  C='g' , I =4 , Color='w'  },
                   new ChessCell {  C='g' , I =5 , Color='b'  },
                   new ChessCell {  C='g' , I =6 , Color='w'  },
                }
        };

        [TestMethod()]
        public void GetInitialsTest_name_surname_patronymic_string()
        {
            Assert.AreEqual("Юстус А.В.", mc.GetInitials("Юстус", "Александр", "Викторович"));
            Assert.AreEqual("Юстус А.В.", mc.GetInitials("  Юстус", "  Александр", "  Викторович"));
            Assert.AreEqual("Юстус А.В.", mc.GetInitials("юстус", "александр", " викторович"));
            Assert.AreEqual("Юстус А.В.", mc.GetInitials("Юстус", "Алекс", "викторович"));
            Assert.AreEqual("Ustys A.V.", mc.GetInitials("Ustys", "Alekx", "Victirivich"));
        }

        [TestMethod()]
        public void GetInitialsTest_Negative_parameters_ArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => mc.GetInitials("", "!!Алекс", "Fвикторович"));
            Assert.ThrowsException<ArgumentException>(() => mc.GetInitials("Юстус", "Алexс", "Виктрович"));
            Assert.ThrowsException<ArgumentException>(() => mc.GetInitials("Юс!ус", "Алexс", "ВиктрFGвич"));
            Assert.ThrowsException<ArgumentException>(() => mc.GetInitials(" Юстус", "", "Виктрович"));
        }

        [TestMethod()]
        public void GetPhoneNumberTest_String_Int()
        {
            Assert.AreEqual(89276566410, mc.GetMobilePhoneNumber("+7(927) 65-66-410"));
            Assert.AreEqual(89276566410, mc.GetMobilePhoneNumber("+7(927)656-64-10"));
            Assert.AreEqual(89276566410, mc.GetMobilePhoneNumber(" 8(927)656-64-10"));
            Assert.AreEqual(89276566410, mc.GetMobilePhoneNumber("8(927)65-66-410"));
            Assert.AreEqual(89276566410, mc.GetMobilePhoneNumber("+7-927-656-64-10"));
            Assert.AreEqual(89276566410, mc.GetMobilePhoneNumber("89276566410"));
            Assert.AreEqual(89276566410, mc.GetMobilePhoneNumber("+7 927 656 64 10"));
            Assert.AreEqual(89276566410, mc.GetMobilePhoneNumber(" +7 927 656 64 10"));
            Assert.AreEqual(89276566410, mc.GetMobilePhoneNumber(" 8 927 656 64 10"));
        }

        [TestMethod()]
        public void GetPhoneNumberTest_Negative_String_Exceprion()
        {
            Assert.ThrowsException<Exception>(() => mc.GetMobilePhoneNumber("+9(927) 65-66-410"));
            Assert.ThrowsException<Exception>(() => mc.GetMobilePhoneNumber("9(927) 65-66-410"));
            Assert.ThrowsException<Exception>(() => mc.GetMobilePhoneNumber("+7(927) 65-66-41010"));
            Assert.ThrowsException<Exception>(() => mc.GetMobilePhoneNumber("+7(000) 65-66-410"));
            Assert.ThrowsException<Exception>(() => mc.GetMobilePhoneNumber("0(927) 65-66-410"));
            Assert.ThrowsException<Exception>(() => mc.GetMobilePhoneNumber("+7(9!7) 65-66-410"));
        }

        [TestMethod()]
        public void HashMD5Test_Content_MD5()
        {
            Assert.AreEqual("E870C036AD4002D908F2FC401A0D5595", mc.GetHash("привет мой друг", TypeHas.MD5));
            Assert.AreEqual("B136B8D882359128EF7C4EB8AD7390F7", mc.GetHash("WSR", TypeHas.MD5));
        }

        [TestMethod()]
        public void HashMD5Test_Content_SHA1()
        {
            Assert.AreEqual("D101785561E65B9371B9DD215BBA96BC67ADDAD3", mc.GetHash("привет мой друг", TypeHas.SHA1));
            Assert.AreEqual("D8EFD1321B589AED89E855FC4F425EE794CF1FE3", mc.GetHash("WSR", TypeHas.SHA1));
        }

        [TestMethod()]
        public void HashMD5Test_Content_SHA256()
        {
            Assert.AreEqual("842ACEB7A1519327698DAC3FD18486DE90052366EECB6345A6440CC34C3793A4", mc.GetHash("привет мой друг", TypeHas.SHA256));
            Assert.AreEqual("BBD16B52189BC341944518B294809F0D338EBD62EB95AD52F53111A38894BF50", mc.GetHash("WSR", TypeHas.SHA256));
        }

        [TestMethod()]
        public void HashMD5Test_nevative_Content_ArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => mc.GetHash("", TypeHas.MD5));
            Assert.ThrowsException<ArgumentException>(() => mc.GetHash("", TypeHas.SHA1));
            Assert.ThrowsException<ArgumentException>(() => mc.GetHash("", TypeHas.SHA256));

        }

        [TestMethod()]
        public void ConvertCurrencyTest_Cash_dollar_double()
        {
            Assert.AreEqual(65.719, mc.ConvertCurrency(1, '$'));
            Assert.AreEqual(657.19, mc.ConvertCurrency(10, '$'));
            Assert.AreEqual(328.595, mc.ConvertCurrency(5, '$'));
        }

        [TestMethod()]
        public void ConvertCurrencyTest_cash_Evro_double()
        {
            Assert.AreEqual(71.849, mc.ConvertCurrency(1, '€'));
            Assert.AreEqual(718.49, mc.ConvertCurrency(10, '€'));
        }

        [TestMethod()]
        public void ConvertCurrencyTest_Negative_Cash_Exception()
        {
            Assert.ThrowsException<Exception>(() => mc.ConvertCurrency(-100, '$'));
            Assert.ThrowsException<Exception>(() => mc.ConvertCurrency(100, 'G'));
            Assert.ThrowsException<Exception>(() => mc.ConvertCurrency(100, '1'));
            Assert.ThrowsException<Exception>(() => mc.ConvertCurrency(100, ' '));
        }

        [TestMethod()]
        public void DistanceToKindergartenTest_xCount_xRow_double()
        {
            Assert.AreEqual(20, mc.DistanceToKindergarten(15, 2));
            Assert.AreEqual(40, mc.DistanceToKindergarten(12, 5));
            Assert.AreEqual(20, mc.DistanceToKindergarten(15, 2));
            Assert.AreEqual(28.284, mc.DistanceToKindergarten(1, 1));
            Assert.AreEqual(28.284, mc.DistanceToKindergarten(9, 11));
            Assert.AreEqual(82.262, mc.DistanceToKindergarten(1, 8));
        }

        [TestMethod()]
        public void DistanceToKindergartenTest_NegativeX_ArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => mc.DistanceToKindergarten(0, 0));
            Assert.ThrowsException<ArgumentException>(() => mc.DistanceToKindergarten(0, 12));
            Assert.ThrowsException<ArgumentException>(() => mc.DistanceToKindergarten(5, 2));
            Assert.ThrowsException<ArgumentException>(() => mc.DistanceToKindergarten(10, 10));
            Assert.ThrowsException<ArgumentException>(() => mc.DistanceToKindergarten(1, 13));
        }

        [TestMethod()]
        public void DistanceToKindergartenTest_NegativeX_ArgumentOutOfRangeException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => mc.DistanceToKindergarten(20, 15));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => mc.DistanceToKindergarten(100, 0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => mc.DistanceToKindergarten(2, 150));
        }

        [TestMethod()]
        public void GetAgeTest_Data_int()
        {
            Assert.AreEqual(20, mc.GetAge(new DateTime(2000, 1, 1)));
            Assert.AreEqual(19, mc.GetAge(new DateTime(2001, 1, 1)));
            Assert.AreEqual(19, mc.GetAge(new DateTime(2000, 10, 10)));
        }

        [TestMethod()]
        public void GetAgeTest_Negative_Data_ArgumentException()
        {
            DateTime dateTime = DateTime.Now.AddDays(1);
            Assert.ThrowsException<ArgumentException>(() => mc.GetAge(dateTime));
        }

        [TestMethod()]
        public void GetPowTest_2_3_8()
        {
            Assert.AreEqual(8, mc.GetPow(2, 3));
        }

        [TestMethod()]
        public void HorseRideTest_Start_Begin_True_Or_False()
        {
            Assert.AreEqual(true, mc.HorseRide(chessBoard.chessCells[12], chessBoard.chessCells[3]));
            Assert.AreEqual(true, mc.HorseRide(chessBoard.chessCells[12], chessBoard.chessCells[1]));
            Assert.AreEqual(true, mc.HorseRide(chessBoard.chessCells[12], chessBoard.chessCells[15]));
            Assert.AreEqual(false, mc.HorseRide(chessBoard.chessCells[12], chessBoard.chessCells[5]));
            Assert.AreEqual(true, mc.HorseRide(chessBoard.chessCells[12], chessBoard.chessCells[6]));
        }

        [TestMethod()]
        public void HorseRideTest_Negative_Exception()
        {
            Assert.ThrowsException<ArgumentException>(() => mc.HorseRide(chessBoard.chessCells[10], chessBoard.chessCells[1]));
            Assert.ThrowsException<ArgumentException>(() => mc.HorseRide(chessBoard.chessCells[12],
                new ChessCell { C = 'z', Color = 'b', I = 8 }));
               
        }

    }
}