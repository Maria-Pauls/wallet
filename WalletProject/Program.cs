namespace WalletProject;
class Program
{

    static bool ShowPaymentCardInformation(PaymentCard[] paymentCards)
    {
        foreach (PaymentCard paymentCard in paymentCards)
        {
            Console.WriteLine("Card number: {0}, Expiry date: {1}, Card holder: {2}, CVV: {3}", paymentCard.CardNumber, paymentCard.ExpiryDate, paymentCard.CardHolder, paymentCard.CVV);
        }

        return true;
    }
    static void Main(string[] args)
    {
        PaymentCard paymentCard1 = new PaymentCard();
        paymentCard1.CardNumber = "3256 2542 6598 1254";
        paymentCard1.ExpiryDate = "03.2026";
        paymentCard1.CardHolder = "Alexandr Pyshkin";
        paymentCard1.CVV = 020;

        PaymentCard paymentCard2 = new PaymentCard();
        paymentCard2.CardNumber = "2020 6545 2485 3652";
        paymentCard2.ExpiryDate = "07.2027";
        paymentCard2.CardHolder = "Djozef Albahary";
        paymentCard2.CVV = 951;

        PaymentCard paymentCard3 = new PaymentCard();
        paymentCard3.CardNumber = "6532 2545 2598 3624";
        paymentCard3.ExpiryDate = "05.2024";
        paymentCard3.CardHolder = "Brothers Strugazkie";
        paymentCard3.CVV = 362;

        PaymentCard paymentCard4 = new PaymentCard();
        paymentCard4.CardNumber = "6598 2365 4574 9564";
        paymentCard4.ExpiryDate = "07.2031";
        paymentCard4.CardHolder = "Anders Hejlsberg";
        paymentCard4.CVV = 206;

        PaymentCard paymentCard5 = new PaymentCard();
        paymentCard5.CardNumber = "3625 5412 9865 1111";
        paymentCard5.ExpiryDate = "11.2024";
        paymentCard5.CardHolder = "Charles Babbage";
        paymentCard5.CVV = 111;

        PaymentCard[] paymentCards = new PaymentCard[] { paymentCard1, paymentCard2, paymentCard3, paymentCard4, paymentCard5 };

        ShowPaymentCardInformation(paymentCards);
    }
}

