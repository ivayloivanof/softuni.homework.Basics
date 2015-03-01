using System;

    class NumbersAsWords
    {
        static void Main(string[] args)
        {
            Console.Write("Please write your number from 0 to 999: ");
            int number = int.Parse(Console.ReadLine());
            while (number < 0 || number > 999)
            {
                Console.Write("You have wrote an invalid number! Please try again:");
                number = int.Parse(Console.ReadLine());
            }

            if (number < 20)
            {
                switch (number)
                {
                    case 0: Console.Write("Zero");
                        break;
                    case 1: Console.Write("One");
                        break;
                    case 2: Console.Write("Two");
                        break;
                    case 3: Console.Write("Three");
                        break;
                    case 4: Console.Write("Four");
                        break;
                    case 5: Console.Write("Five");
                        break;
                    case 6: Console.Write("Six");
                        break;
                    case 7: Console.Write("Seven");
                        break;
                    case 8: Console.Write("Eight");
                        break;
                    case 9: Console.Write("Nine");
                        break;
                    case 10: Console.Write("Ten");
                        break;
                    case 11: Console.Write("Eleven");
                        break;
                    case 12: Console.Write("Twelve");
                        break;
                    case 13: Console.Write("Thirteen");
                        break;
                    case 14: Console.Write("Fourteen");
                        break;
                    case 15: Console.Write("Fifteen");
                        break;
                    case 16: Console.Write("Sixteen");
                        break;
                    case 17: Console.Write("Seventeen");
                        break;
                    case 18: Console.Write("Eighteen");
                        break;
                    case 19: Console.Write("Nineteen");
                        break;
                }
            }
            if (number > 19 && number < 100)
            {
                int desetki = number / 10;
                int edinici = number % 10;
                switch (desetki)
                {
                    case 2: Console.Write("Twenty ");
                        break;
                    case 3: Console.Write("Thirty ");
                        break;
                    case 4: Console.Write("Forty ");
                        break;
                    case 5: Console.Write("Fifty ");
                        break;
                    case 6: Console.Write("Sixty ");
                        break;
                    case 7: Console.Write("Seventy ");
                        break;
                    case 8: Console.Write("Eighty ");
                        break;
                    case 9: Console.Write("Ninety ");
                        break;
                }
                switch (edinici)
                {
                    case 1: Console.Write("one");
                        break;
                    case 2: Console.Write("two");
                        break;
                    case 3: Console.Write("three");
                        break;
                    case 4: Console.Write("four");
                        break;
                    case 5: Console.Write("five");
                        break;
                    case 6: Console.Write("six");
                        break;
                    case 7: Console.Write("seven");
                        break;
                    case 8: Console.Write("eight");
                        break;
                    case 9: Console.Write("nine");
                        break;
                }
            }
            if (number > 99)
            {
                int stotici = number / 100;
                int desetki = number % 100 / 10;
                int edinici = number % 10;

                switch (stotici)
                {
                    case 1: if (number == 100)
                        {
                            Console.Write("One hundred");
                        }
                        else
                        {
                            Console.Write("One hundred and ");
                            if (number > 100 && number < 120)
                            {
                                int first20numbers = number % 100;
                                switch (first20numbers)
                                {
                                    case 0: Console.WriteLine();
                                        break;
                                    case 1: Console.Write("one");
                                        break;
                                    case 2: Console.Write("two");
                                        break;
                                    case 3: Console.Write("three");
                                        break;
                                    case 4: Console.Write("four");
                                        break;
                                    case 5: Console.Write("five");
                                        break;
                                    case 6: Console.Write("six");
                                        break;
                                    case 7: Console.Write("seven");
                                        break;
                                    case 8: Console.Write("eight");
                                        break;
                                    case 9: Console.Write("nine");
                                        break;
                                    case 10: Console.Write("ten");
                                        break;
                                    case 11: Console.Write("eleven");
                                        break;
                                    case 12: Console.Write("twelve");
                                        break;
                                    case 13: Console.Write("thirteen");
                                        break;
                                    case 14: Console.Write("fourteen");
                                        break;
                                    case 15: Console.Write("fifteen");
                                        break;
                                    case 16: Console.Write("sixteen");
                                        break;
                                    case 17: Console.Write("seventeen");
                                        break;
                                    case 18: Console.Write("eighteen");
                                        break;
                                    case 19: Console.Write("nineteen");
                                        break;
                                }
                            }
                            if (number > 119 && number < 200)
                            {

                                switch (desetki)
                                {
                                    case 2: Console.Write("twenty ");
                                        break;
                                    case 3: Console.Write("thirty ");
                                        break;
                                    case 4: Console.Write("forty ");
                                        break;
                                    case 5: Console.Write("fifty ");
                                        break;
                                    case 6: Console.Write("sixty ");
                                        break;
                                    case 7: Console.Write("seventy ");
                                        break;
                                    case 8: Console.Write("eighty ");
                                        break;
                                    case 9: Console.Write("ninety ");
                                        break;
                                }
                                switch (edinici)
                                {
                                    case 1: Console.Write("one");
                                        break;
                                    case 2: Console.Write("two");
                                        break;
                                    case 3: Console.Write("three");
                                        break;
                                    case 4: Console.Write("four");
                                        break;
                                    case 5: Console.Write("five");
                                        break;
                                    case 6: Console.Write("six");
                                        break;
                                    case 7: Console.Write("seven");
                                        break;
                                    case 8: Console.Write("eight");
                                        break;
                                    case 9: Console.Write("nine");
                                        break;
                                }
                            }
                        }
                        break;
                    case 2: if (number == 200)
                        {
                            Console.Write("Two hundred");
                        }
                        else
                        {
                            Console.Write("Two hundred and ");
                            if (number > 200 && number < 220)
                            {
                                int first20numbers = number % 100;
                                switch (first20numbers)
                                {
                                    case 0: Console.WriteLine();
                                        break;
                                    case 1: Console.Write("one");
                                        break;
                                    case 2: Console.Write("two");
                                        break;
                                    case 3: Console.Write("three");
                                        break;
                                    case 4: Console.Write("four");
                                        break;
                                    case 5: Console.Write("five");
                                        break;
                                    case 6: Console.Write("six");
                                        break;
                                    case 7: Console.Write("seven");
                                        break;
                                    case 8: Console.Write("eight");
                                        break;
                                    case 9: Console.Write("nine");
                                        break;
                                    case 10: Console.Write("ten");
                                        break;
                                    case 11: Console.Write("eleven");
                                        break;
                                    case 12: Console.Write("twelve");
                                        break;
                                    case 13: Console.Write("thirteen");
                                        break;
                                    case 14: Console.Write("fourteen");
                                        break;
                                    case 15: Console.Write("fifteen");
                                        break;
                                    case 16: Console.Write("sixteen");
                                        break;
                                    case 17: Console.Write("seventeen");
                                        break;
                                    case 18: Console.Write("eighteen");
                                        break;
                                    case 19: Console.Write("nineteen");
                                        break;
                                }
                            }
                            if (number > 219 && number < 300)
                            {

                                switch (desetki)
                                {
                                    case 2: Console.Write("twenty ");
                                        break;
                                    case 3: Console.Write("thirty ");
                                        break;
                                    case 4: Console.Write("forty ");
                                        break;
                                    case 5: Console.Write("fifty ");
                                        break;
                                    case 6: Console.Write("sixty ");
                                        break;
                                    case 7: Console.Write("seventy ");
                                        break;
                                    case 8: Console.Write("eighty ");
                                        break;
                                    case 9: Console.Write("ninety ");
                                        break;
                                }
                                switch (edinici)
                                {
                                    case 1: Console.Write("one");
                                        break;
                                    case 2: Console.Write("two");
                                        break;
                                    case 3: Console.Write("three");
                                        break;
                                    case 4: Console.Write("four");
                                        break;
                                    case 5: Console.Write("five");
                                        break;
                                    case 6: Console.Write("six");
                                        break;
                                    case 7: Console.Write("seven");
                                        break;
                                    case 8: Console.Write("eight");
                                        break;
                                    case 9: Console.Write("nine");
                                        break;
                                }
                            }
                        }
                        break;
                    case 3: if (number == 300)
                        {
                            Console.Write("Three hundred");
                        }
                        else
                        {
                            Console.Write("Three hundred and ");
                            if (number > 300 && number < 320)
                            {
                                int first20numbers = number % 100;
                                switch (first20numbers)
                                {
                                    case 0: Console.WriteLine();
                                        break;
                                    case 1: Console.Write("one");
                                        break;
                                    case 2: Console.Write("two");
                                        break;
                                    case 3: Console.Write("three");
                                        break;
                                    case 4: Console.Write("four");
                                        break;
                                    case 5: Console.Write("five");
                                        break;
                                    case 6: Console.Write("six");
                                        break;
                                    case 7: Console.Write("seven");
                                        break;
                                    case 8: Console.Write("eight");
                                        break;
                                    case 9: Console.Write("nine");
                                        break;
                                    case 10: Console.Write("ten");
                                        break;
                                    case 11: Console.Write("eleven");
                                        break;
                                    case 12: Console.Write("twelve");
                                        break;
                                    case 13: Console.Write("thirteen");
                                        break;
                                    case 14: Console.Write("fourteen");
                                        break;
                                    case 15: Console.Write("fifteen");
                                        break;
                                    case 16: Console.Write("sixteen");
                                        break;
                                    case 17: Console.Write("seventeen");
                                        break;
                                    case 18: Console.Write("eighteen");
                                        break;
                                    case 19: Console.Write("nineteen");
                                        break;
                                }
                            }
                            if (number > 319 && number < 400)
                            {

                                switch (desetki)
                                {
                                    case 2: Console.Write("twenty ");
                                        break;
                                    case 3: Console.Write("thirty ");
                                        break;
                                    case 4: Console.Write("forty ");
                                        break;
                                    case 5: Console.Write("fifty ");
                                        break;
                                    case 6: Console.Write("sixty ");
                                        break;
                                    case 7: Console.Write("seventy ");
                                        break;
                                    case 8: Console.Write("eighty ");
                                        break;
                                    case 9: Console.Write("ninety ");
                                        break;
                                }
                                switch (edinici)
                                {
                                    case 1: Console.Write("one");
                                        break;
                                    case 2: Console.Write("two");
                                        break;
                                    case 3: Console.Write("three");
                                        break;
                                    case 4: Console.Write("four");
                                        break;
                                    case 5: Console.Write("five");
                                        break;
                                    case 6: Console.Write("six");
                                        break;
                                    case 7: Console.Write("seven");
                                        break;
                                    case 8: Console.Write("eight");
                                        break;
                                    case 9: Console.Write("nine");
                                        break;
                                }
                            }
                        }
                        break;
                    case 4: if (number == 400)
                        {
                            Console.Write("Four hundred");
                        }
                        else
                        {
                            Console.Write("Four hundred and ");
                            if (number > 400 && number < 420)
                            {
                                int first20numbers = number % 100;
                                switch (first20numbers)
                                {
                                    case 0: Console.WriteLine();
                                        break;
                                    case 1: Console.Write("one");
                                        break;
                                    case 2: Console.Write("two");
                                        break;
                                    case 3: Console.Write("three");
                                        break;
                                    case 4: Console.Write("four");
                                        break;
                                    case 5: Console.Write("five");
                                        break;
                                    case 6: Console.Write("six");
                                        break;
                                    case 7: Console.Write("seven");
                                        break;
                                    case 8: Console.Write("eight");
                                        break;
                                    case 9: Console.Write("nine");
                                        break;
                                    case 10: Console.Write("ten");
                                        break;
                                    case 11: Console.Write("eleven");
                                        break;
                                    case 12: Console.Write("twelve");
                                        break;
                                    case 13: Console.Write("thirteen");
                                        break;
                                    case 14: Console.Write("fourteen");
                                        break;
                                    case 15: Console.Write("fifteen");
                                        break;
                                    case 16: Console.Write("sixteen");
                                        break;
                                    case 17: Console.Write("seventeen");
                                        break;
                                    case 18: Console.Write("eighteen");
                                        break;
                                    case 19: Console.Write("nineteen");
                                        break;
                                }
                            }
                            if (number > 419 && number < 500)
                            {

                                switch (desetki)
                                {
                                    case 2: Console.Write("twenty ");
                                        break;
                                    case 3: Console.Write("thirty ");
                                        break;
                                    case 4: Console.Write("forty ");
                                        break;
                                    case 5: Console.Write("fifty ");
                                        break;
                                    case 6: Console.Write("sixty ");
                                        break;
                                    case 7: Console.Write("seventy ");
                                        break;
                                    case 8: Console.Write("eighty ");
                                        break;
                                    case 9: Console.Write("ninety ");
                                        break;
                                }
                                switch (edinici)
                                {
                                    case 1: Console.Write("one");
                                        break;
                                    case 2: Console.Write("two");
                                        break;
                                    case 3: Console.Write("three");
                                        break;
                                    case 4: Console.Write("four");
                                        break;
                                    case 5: Console.Write("five");
                                        break;
                                    case 6: Console.Write("six");
                                        break;
                                    case 7: Console.Write("seven");
                                        break;
                                    case 8: Console.Write("eight");
                                        break;
                                    case 9: Console.Write("nine");
                                        break;
                                }
                            }
                        }
                        break;
                    case 5: if (number == 500)
                        {
                            Console.Write("Five hundred");
                        }
                        else
                        {
                            Console.Write("Five hundred and ");
                            if (number > 500 && number < 520)
                            {
                                int first20numbers = number % 100;
                                switch (first20numbers)
                                {
                                    case 0: Console.WriteLine();
                                        break;
                                    case 1: Console.Write("one");
                                        break;
                                    case 2: Console.Write("two");
                                        break;
                                    case 3: Console.Write("three");
                                        break;
                                    case 4: Console.Write("four");
                                        break;
                                    case 5: Console.Write("five");
                                        break;
                                    case 6: Console.Write("six");
                                        break;
                                    case 7: Console.Write("seven");
                                        break;
                                    case 8: Console.Write("eight");
                                        break;
                                    case 9: Console.Write("nine");
                                        break;
                                    case 10: Console.Write("ten");
                                        break;
                                    case 11: Console.Write("eleven");
                                        break;
                                    case 12: Console.Write("twelve");
                                        break;
                                    case 13: Console.Write("thirteen");
                                        break;
                                    case 14: Console.Write("fourteen");
                                        break;
                                    case 15: Console.Write("fifteen");
                                        break;
                                    case 16: Console.Write("sixteen");
                                        break;
                                    case 17: Console.Write("seventeen");
                                        break;
                                    case 18: Console.Write("eighteen");
                                        break;
                                    case 19: Console.Write("nineteen");
                                        break;
                                }
                            }
                            if (number > 519 && number < 600)
                            {

                                switch (desetki)
                                {
                                    case 2: Console.Write("twenty ");
                                        break;
                                    case 3: Console.Write("thirty ");
                                        break;
                                    case 4: Console.Write("forty ");
                                        break;
                                    case 5: Console.Write("fifty ");
                                        break;
                                    case 6: Console.Write("sixty ");
                                        break;
                                    case 7: Console.Write("seventy ");
                                        break;
                                    case 8: Console.Write("eighty ");
                                        break;
                                    case 9: Console.Write("ninety ");
                                        break;
                                }
                                switch (edinici)
                                {
                                    case 1: Console.Write("one");
                                        break;
                                    case 2: Console.Write("two");
                                        break;
                                    case 3: Console.Write("three");
                                        break;
                                    case 4: Console.Write("four");
                                        break;
                                    case 5: Console.Write("five");
                                        break;
                                    case 6: Console.Write("six");
                                        break;
                                    case 7: Console.Write("seven");
                                        break;
                                    case 8: Console.Write("eight");
                                        break;
                                    case 9: Console.Write("nine");
                                        break;
                                }
                            }
                        }
                        break;
                    case 6: if (number == 600)
                        {
                            Console.Write("Six hundred");
                        }
                        else
                        {
                            Console.Write("Six hundred and ");
                            if (number > 600 && number < 620)
                            {
                                int first20numbers = number % 100;
                                switch (first20numbers)
                                {
                                    case 0: Console.WriteLine();
                                        break;
                                    case 1: Console.Write("one");
                                        break;
                                    case 2: Console.Write("two");
                                        break;
                                    case 3: Console.Write("three");
                                        break;
                                    case 4: Console.Write("four");
                                        break;
                                    case 5: Console.Write("five");
                                        break;
                                    case 6: Console.Write("six");
                                        break;
                                    case 7: Console.Write("seven");
                                        break;
                                    case 8: Console.Write("eight");
                                        break;
                                    case 9: Console.Write("nine");
                                        break;
                                    case 10: Console.Write("ten");
                                        break;
                                    case 11: Console.Write("eleven");
                                        break;
                                    case 12: Console.Write("twelve");
                                        break;
                                    case 13: Console.Write("thirteen");
                                        break;
                                    case 14: Console.Write("fourteen");
                                        break;
                                    case 15: Console.Write("fifteen");
                                        break;
                                    case 16: Console.Write("sixteen");
                                        break;
                                    case 17: Console.Write("seventeen");
                                        break;
                                    case 18: Console.Write("eighteen");
                                        break;
                                    case 19: Console.Write("nineteen");
                                        break;
                                }
                            }
                            if (number > 619 && number < 700)
                            {

                                switch (desetki)
                                {
                                    case 2: Console.Write("twenty ");
                                        break;
                                    case 3: Console.Write("thirty ");
                                        break;
                                    case 4: Console.Write("forty ");
                                        break;
                                    case 5: Console.Write("fifty ");
                                        break;
                                    case 6: Console.Write("sixty ");
                                        break;
                                    case 7: Console.Write("seventy ");
                                        break;
                                    case 8: Console.Write("eighty ");
                                        break;
                                    case 9: Console.Write("ninety ");
                                        break;
                                }
                                switch (edinici)
                                {
                                    case 1: Console.Write("one");
                                        break;
                                    case 2: Console.Write("two");
                                        break;
                                    case 3: Console.Write("three");
                                        break;
                                    case 4: Console.Write("four");
                                        break;
                                    case 5: Console.Write("five");
                                        break;
                                    case 6: Console.Write("six");
                                        break;
                                    case 7: Console.Write("seven");
                                        break;
                                    case 8: Console.Write("eight");
                                        break;
                                    case 9: Console.Write("nine");
                                        break;
                                }
                            }
                        }
                        break;
                    case 7: if (number == 200)
                        {
                            Console.Write("Seven hundred");
                        }
                        else
                        {
                            Console.Write("Seven hundred and ");
                            if (number > 700 && number < 720)
                            {
                                int first20numbers = number % 100;
                                switch (first20numbers)
                                {
                                    case 0: Console.WriteLine();
                                        break;
                                    case 1: Console.Write("one");
                                        break;
                                    case 2: Console.Write("two");
                                        break;
                                    case 3: Console.Write("three");
                                        break;
                                    case 4: Console.Write("four");
                                        break;
                                    case 5: Console.Write("five");
                                        break;
                                    case 6: Console.Write("six");
                                        break;
                                    case 7: Console.Write("seven");
                                        break;
                                    case 8: Console.Write("eight");
                                        break;
                                    case 9: Console.Write("nine");
                                        break;
                                    case 10: Console.Write("ten");
                                        break;
                                    case 11: Console.Write("eleven");
                                        break;
                                    case 12: Console.Write("twelve");
                                        break;
                                    case 13: Console.Write("thirteen");
                                        break;
                                    case 14: Console.Write("fourteen");
                                        break;
                                    case 15: Console.Write("fifteen");
                                        break;
                                    case 16: Console.Write("sixteen");
                                        break;
                                    case 17: Console.Write("seventeen");
                                        break;
                                    case 18: Console.Write("eighteen");
                                        break;
                                    case 19: Console.Write("nineteen");
                                        break;
                                }
                            }
                            if (number > 719 && number < 800)
                            {

                                switch (desetki)
                                {
                                    case 2: Console.Write("twenty ");
                                        break;
                                    case 3: Console.Write("thirty ");
                                        break;
                                    case 4: Console.Write("forty ");
                                        break;
                                    case 5: Console.Write("fifty ");
                                        break;
                                    case 6: Console.Write("sixty ");
                                        break;
                                    case 7: Console.Write("seventy ");
                                        break;
                                    case 8: Console.Write("eighty ");
                                        break;
                                    case 9: Console.Write("ninety ");
                                        break;
                                }
                                switch (edinici)
                                {
                                    case 1: Console.Write("one");
                                        break;
                                    case 2: Console.Write("two");
                                        break;
                                    case 3: Console.Write("three");
                                        break;
                                    case 4: Console.Write("four");
                                        break;
                                    case 5: Console.Write("five");
                                        break;
                                    case 6: Console.Write("six");
                                        break;
                                    case 7: Console.Write("seven");
                                        break;
                                    case 8: Console.Write("eight");
                                        break;
                                    case 9: Console.Write("nine");
                                        break;
                                }
                            }
                        }
                        break;
                    case 8: if (number == 800)
                        {
                            Console.Write("Eight hundred");
                        }
                        else
                        {
                            Console.Write("Eight hundred and ");
                            if (number > 800 && number < 820)
                            {
                                int first20numbers = number % 100;
                                switch (first20numbers)
                                {
                                    case 0: Console.WriteLine();
                                        break;
                                    case 1: Console.Write("one");
                                        break;
                                    case 2: Console.Write("two");
                                        break;
                                    case 3: Console.Write("three");
                                        break;
                                    case 4: Console.Write("four");
                                        break;
                                    case 5: Console.Write("five");
                                        break;
                                    case 6: Console.Write("six");
                                        break;
                                    case 7: Console.Write("seven");
                                        break;
                                    case 8: Console.Write("eight");
                                        break;
                                    case 9: Console.Write("nine");
                                        break;
                                    case 10: Console.Write("ten");
                                        break;
                                    case 11: Console.Write("eleven");
                                        break;
                                    case 12: Console.Write("twelve");
                                        break;
                                    case 13: Console.Write("thirteen");
                                        break;
                                    case 14: Console.Write("fourteen");
                                        break;
                                    case 15: Console.Write("fifteen");
                                        break;
                                    case 16: Console.Write("sixteen");
                                        break;
                                    case 17: Console.Write("seventeen");
                                        break;
                                    case 18: Console.Write("eighteen");
                                        break;
                                    case 19: Console.Write("nineteen");
                                        break;
                                }
                            }
                            if (number > 819 && number < 900)
                            {

                                switch (desetki)
                                {
                                    case 2: Console.Write("twenty ");
                                        break;
                                    case 3: Console.Write("thirty ");
                                        break;
                                    case 4: Console.Write("forty ");
                                        break;
                                    case 5: Console.Write("fifty ");
                                        break;
                                    case 6: Console.Write("sixty ");
                                        break;
                                    case 7: Console.Write("seventy ");
                                        break;
                                    case 8: Console.Write("eighty ");
                                        break;
                                    case 9: Console.Write("ninety ");
                                        break;
                                }
                                switch (edinici)
                                {
                                    case 1: Console.Write("one");
                                        break;
                                    case 2: Console.Write("two");
                                        break;
                                    case 3: Console.Write("three");
                                        break;
                                    case 4: Console.Write("four");
                                        break;
                                    case 5: Console.Write("five");
                                        break;
                                    case 6: Console.Write("six");
                                        break;
                                    case 7: Console.Write("seven");
                                        break;
                                    case 8: Console.Write("eight");
                                        break;
                                    case 9: Console.Write("nine");
                                        break;
                                }
                            }
                        }
                        break;
                    case 9: if (number == 900)
                        {
                            Console.Write("Nine hundred");
                        }
                        else
                        {
                            Console.Write("Nine hundred and ");
                            if (number > 900 && number < 920)
                            {
                                int first20numbers = number % 100;
                                switch (first20numbers)
                                {
                                    case 0: Console.WriteLine();
                                        break;
                                    case 1: Console.Write("one");
                                        break;
                                    case 2: Console.Write("two");
                                        break;
                                    case 3: Console.Write("three");
                                        break;
                                    case 4: Console.Write("four");
                                        break;
                                    case 5: Console.Write("five");
                                        break;
                                    case 6: Console.Write("six");
                                        break;
                                    case 7: Console.Write("seven");
                                        break;
                                    case 8: Console.Write("eight");
                                        break;
                                    case 9: Console.Write("nine");
                                        break;
                                    case 10: Console.Write("ten");
                                        break;
                                    case 11: Console.Write("eleven");
                                        break;
                                    case 12: Console.Write("twelve");
                                        break;
                                    case 13: Console.Write("thirteen");
                                        break;
                                    case 14: Console.Write("fourteen");
                                        break;
                                    case 15: Console.Write("fifteen");
                                        break;
                                    case 16: Console.Write("sixteen");
                                        break;
                                    case 17: Console.Write("seventeen");
                                        break;
                                    case 18: Console.Write("eighteen");
                                        break;
                                    case 19: Console.Write("nineteen");
                                        break;
                                }
                            }
                            if (number > 919 && number < 1000)
                            {

                                switch (desetki)
                                {
                                    case 2: Console.Write("twenty ");
                                        break;
                                    case 3: Console.Write("thirty ");
                                        break;
                                    case 4: Console.Write("forty ");
                                        break;
                                    case 5: Console.Write("fifty ");
                                        break;
                                    case 6: Console.Write("sixty ");
                                        break;
                                    case 7: Console.Write("seventy ");
                                        break;
                                    case 8: Console.Write("eighty ");
                                        break;
                                    case 9: Console.Write("ninety ");
                                        break;
                                }
                                switch (edinici)
                                {
                                    case 1: Console.Write("one");
                                        break;
                                    case 2: Console.Write("two");
                                        break;
                                    case 3: Console.Write("three");
                                        break;
                                    case 4: Console.Write("four");
                                        break;
                                    case 5: Console.Write("five");
                                        break;
                                    case 6: Console.Write("six");
                                        break;
                                    case 7: Console.Write("seven");
                                        break;
                                    case 8: Console.Write("eight");
                                        break;
                                    case 9: Console.Write("nine");
                                        break;
                                }
                            }
                        }
                        break;
                }


            }
        }
    }

