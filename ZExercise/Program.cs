using System;
using System.Dynamic;

namespace Course_Finishing_Exersice
{
    class Program
    {
        static (string userLogin, string userPassword) InputLoginAndPassword()
        {
            Console.Write("Enter Login: ");
            string login = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            return (login, password);
        }
        static bool AuthorizeUser()
        {

            bool userAuthorized; // = AuthorizeUser();
            {
                userAuthorized = false;

                string[] loginList = { "Admin", "Ivanova", "Petrova", "Sergeeva", "Vasilyeva", "Semyonova" };
                string[] passwordList = { "000", "111", "222", "333", "444", "555" };

                int authorizationAttemptCounter = 0;
                const int ALLOABLE_NUMBER_OF_AUTHORIZATION_ATTEMPTS = 3;
                bool authorizationAttemptAvailable = authorizationAttemptCounter < ALLOABLE_NUMBER_OF_AUTHORIZATION_ATTEMPTS;

                while (authorizationAttemptAvailable)
                {
                    (string lgn, string psw) input = InputLoginAndPassword();
                    string login = input.Item1, password = input.Item2;

                    //authorized = TryAuthorizedUser(login, password);
                    {
                        for (int i = 0; i < loginList.Length && i < passwordList.Length; i++)
                        {
                            bool loginMatched, passwordMatched; // = MatchLoginAndPassword()
                            {
                                string loginByCurrentIndex = loginList[i];
                                loginMatched = loginByCurrentIndex == login;
                                string passwordByCurrentIndex = passwordList[i];
                                passwordMatched = passwordByCurrentIndex == password;
                            }

                            if (loginMatched && passwordMatched)
                            {
                                userAuthorized = true;
                                break;
                            }
                        }
                    }

                    if (userAuthorized)
                    {
                        Console.WriteLine("Access");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Login or Password");
                        authorizationAttemptAvailable = ++authorizationAttemptCounter < ALLOABLE_NUMBER_OF_AUTHORIZATION_ATTEMPTS;

                        if (authorizationAttemptAvailable)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("You Exceeded Trying Limit. Contact With Administrator");
                            break;
                        }
                    }
                }

                return userAuthorized;
            }
        }

        static void RunOutputUserInterface(decimal tilePriceWithRate,
                                           decimal tileCost,
                                           decimal discount,
                                           decimal paymentAmount)
        {
            {
                Console.WriteLine($"Price with coefficient: {tilePriceWithRate}ru");
                Console.WriteLine($"Total price           : {tileCost}ru");
                Console.WriteLine($"Discount              : {discount}ru");
                Console.WriteLine($"Final price           : {paymentAmount}ru");
                Console.WriteLine("\nPress enter to sreve next costumer...");
            }
        }


        static void Main()
        {
            bool userAuthorized = AuthorizeUser();

            // Run (userAuthorized);
            {
                while (userAuthorized)
                {
                    string countryCode;
                    decimal tileQuantity, tilePrice;
                    //countryCode, tileQuantity, tilePrice = runInputUserInterface ()
                    {

                        const string COUNTRY_CODES =
                            "=========================================================  \n" +
                            "Armenia    (374) | Kazakhstan (007K) | Russia       (007)  \n" +
                            "Azerbaijan (994) | Kirgiziya  (996)  | Tajikistan   (992)  \n" +
                            "Belarus    (375) | Latvia     (371)  | Turkmenistan (993)  \n" +
                            "Estonia    (372) | Lithuania  (370)  | Ukraine      (380)  \n" +
                            "Georgia    (995) | Moldova    (373)  | Uzbekistan   (998)  \n" +
                            "---------------------------------------------------------  \n";

                        Console.WriteLine(COUNTRY_CODES);

                        //countryCode = ProcessCountryCode (countryCode)
                        {
                            bool countryCodeIsCorrect;

                            do
                            {
                                Console.Write("Telephone code: ");
                                countryCode = Console.ReadLine();

                                // countryCode = DetectKazakhsatnCode (countryCode)
                                {
                                    const string KAZAKHSTAN_CODE = "007";
                                    const string LOWERCASE_ENGLISH_LETTER_k = "k",
                                                 UPPERCASE_RUSSIAN_LETTER_K = "К", LOWERCASE_RUSSIAN_LETTER_k = "к";

                                    bool countryCodeIsKazakhstanCodeAndAnyLetterK = countryCode == (KAZAKHSTAN_CODE + LOWERCASE_ENGLISH_LETTER_k) ||
                                                                                    countryCode == (KAZAKHSTAN_CODE + UPPERCASE_RUSSIAN_LETTER_K) ||
                                                                                    countryCode == (KAZAKHSTAN_CODE + LOWERCASE_RUSSIAN_LETTER_k);

                                    if (countryCodeIsKazakhstanCodeAndAnyLetterK)
                                    {
                                        const string UPPERCASE_ENGLISH_LETTER_K = "K";
                                        countryCode = KAZAKHSTAN_CODE + UPPERCASE_ENGLISH_LETTER_K;
                                    }
                                }

                                //ChekCountryCode (countryCode)
                                {
                                    const string UPPERCASE_ENGLISH_LETTER_K = "K";
                                    const string ARMENIA_CODE = "374", AZERBAIJAN_CODE = "994", BELARUS_CODE = "375",
                                                 ESTONIA_CODE = "372", GEORGIA_CODE = "995", KAZAKHSTAN_CODE = "007" + UPPERCASE_ENGLISH_LETTER_K,
                                                 KIRGIZIYA_CODE = "996", LATVIA_CODE = "371", LITHUANIA_CODE = "370",
                                                 MOLDOVA_CODE = "373", RUSSIA_CODE = "007", TAJIKISTAN_CODE = "992",
                                                 TURKMENISTAN_CODE = "993", UKRAINE_CODE = "380", UZBEKISTAN_CODE = "998";

                                    switch (countryCode)
                                    {
                                        case ARMENIA_CODE:
                                        case AZERBAIJAN_CODE:
                                        case BELARUS_CODE:
                                        case ESTONIA_CODE:
                                        case GEORGIA_CODE:
                                        case KAZAKHSTAN_CODE:
                                        case KIRGIZIYA_CODE:
                                        case LATVIA_CODE:
                                        case LITHUANIA_CODE:
                                        case MOLDOVA_CODE:
                                        case RUSSIA_CODE:
                                        case TAJIKISTAN_CODE:
                                        case TURKMENISTAN_CODE:
                                        case UKRAINE_CODE:
                                        case UZBEKISTAN_CODE:
                                            {
                                                countryCodeIsCorrect = true;
                                                break;
                                            }
                                        default:
                                            {
                                                countryCodeIsCorrect = false;
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine($"You entered undefined code: {countryCode}!");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                Console.WriteLine("\nPress enter to sreve next costumer...");
                                                Console.ReadKey();
                                                break;
                                            }
                                    }
                                }
                            }
                            while (countryCodeIsCorrect == false);
                        }

                        Console.Write("Enter quantity: ");
                        string stringQuantity = Console.ReadLine();
                        tileQuantity = Convert.ToDecimal(stringQuantity);

                        Console.Write("Enter price: ");
                        string stringPrice = Console.ReadLine();
                        tilePrice = Convert.ToDecimal(stringPrice);
                    }

                    decimal rate;

                    //rate = CalculatePriceRate = (countryCode)
                    {
                        const string UPPERCASE_ENGLISH_LETTER_K = "K";
                        const string ARMENIA_CODE = "374", AZERBAIJAN_CODE = "994", BELARUS_CODE = "375",
                                     ESTONIA_CODE = "372", GEORGIA_CODE = "995", KAZAKHSTAN_CODE = "007" + UPPERCASE_ENGLISH_LETTER_K,
                                     KIRGIZIYA_CODE = "996", LATVIA_CODE = "371", LITHUANIA_CODE = "370",
                                     MOLDOVA_CODE = "373", RUSSIA_CODE = "007", TAJIKISTAN_CODE = "992",
                                     TURKMENISTAN_CODE = "993", UKRAINE_CODE = "380", UZBEKISTAN_CODE = "998";

                        switch (countryCode)
                        {
                            case ARMENIA_CODE:
                                {
                                    const decimal ARMENIA_RATE = 0.95m;
                                    rate = ARMENIA_RATE;
                                    break;
                                }
                            case AZERBAIJAN_CODE:
                                {
                                    const decimal AZERBAIJAN_RATE = 1.07m;
                                    rate = AZERBAIJAN_RATE;
                                    break;
                                }
                            case BELARUS_CODE:
                                {
                                    const decimal BELARUS_RATE = 1m;
                                    rate = BELARUS_RATE;
                                    break;
                                }
                            case GEORGIA_CODE:
                                {
                                    const decimal GEORGIA_RATE = 0.94m;
                                    rate = GEORGIA_RATE;
                                    break;
                                }
                            case KAZAKHSTAN_CODE:
                                {
                                    const decimal KAZAKHSTAN_RATE = 0.79m;
                                    rate = KAZAKHSTAN_RATE;
                                    break;
                                }
                            case KIRGIZIYA_CODE:
                                {
                                    const decimal KIRGIZIYA_RATE = 0.83m;
                                    rate = KIRGIZIYA_RATE;
                                    break;
                                }
                            case ESTONIA_CODE:
                            case LATVIA_CODE:
                            case LITHUANIA_CODE:
                                {
                                    const decimal LITHUANIA_LATVIA_ESTONIA_RATE = 1.12m;
                                    rate = LITHUANIA_LATVIA_ESTONIA_RATE;
                                    break;
                                }
                            case MOLDOVA_CODE:
                                {
                                    const decimal MOLDOVA_RATE = 0.97m;
                                    rate = MOLDOVA_RATE;
                                    break;
                                }
                            case RUSSIA_CODE:
                                {
                                    const decimal RUSSIA_RATE = 1m;
                                    rate = RUSSIA_RATE;
                                    break;
                                }
                            case TAJIKISTAN_CODE:
                                {
                                    const decimal TAJIKISTAN_RATE = 0.76m;
                                    rate = TAJIKISTAN_RATE;
                                    break;
                                }
                            case TURKMENISTAN_CODE:
                                {
                                    const decimal TURKMENISTAN_RATE = 0.81m;
                                    rate = TURKMENISTAN_RATE;
                                    break;
                                }
                            case UKRAINE_CODE:
                                {
                                    const decimal UKRAINE_RATE = 1m;
                                    rate = UKRAINE_RATE;
                                    break;
                                }
                            case UZBEKISTAN_CODE:
                                {
                                    const decimal UZBEKISTAN_RATE = 0.98m;
                                    rate = UZBEKISTAN_RATE;
                                    break;
                                }
                            default:
                                {
                                    rate = 0;
                                    break;
                                }
                        }
                    }

                    decimal tilePriceWithRate = tilePrice * rate;
                    decimal tileCost = tileQuantity * tilePriceWithRate;

                    decimal discount;
                    {
                        decimal discountPercentage;
                        {
                            bool discount20PctAvailable, discount50PctAvailable;
                            {
                                const decimal MIN_TILE_QTY_FOR_DISCOUNT_20_PCT = 500,
                                              MIN_TILE_QTY_FOR_DISCOUNT_50_PCT = 1000;

                                discount20PctAvailable = tileQuantity >= MIN_TILE_QTY_FOR_DISCOUNT_20_PCT &&
                                                         tileQuantity < MIN_TILE_QTY_FOR_DISCOUNT_50_PCT;

                                discount50PctAvailable = tileQuantity >= MIN_TILE_QTY_FOR_DISCOUNT_50_PCT;
                            }

                            if (discount20PctAvailable)
                                discountPercentage = 20;
                            else if (discount50PctAvailable)
                                discountPercentage = 50;
                            else
                                discountPercentage = 0;

                        }

                        discount = tileCost / 100 * discountPercentage;
                    }

                    decimal paymentAmount = tileCost - discount;

                    RunOutputUserInterface(tilePriceWithRate, tileCost, discount, paymentAmount);

                    Console.ReadKey();
                }
            }
        }
    }
}