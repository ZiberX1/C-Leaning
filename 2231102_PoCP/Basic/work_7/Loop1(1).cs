            int sum = 0;
            int max = 0;
            int min = int.MaxValue;
            string strNum = "";
            int num;

            Console.WriteLine("Warning: If you don't to input number: you should key -999");

            do
            {
                Console.Write("Input your number (1-100)? : ");
                num = int.Parse(Console.ReadLine());

                if (num > 0 && num <= 100)
                {
                    sum += num;
                    strNum += num + " ";

                    if (min > num)
                    {
                        min = num;
                    }

                    if (max < num)
                    {
                        max = num;
                    }
                }
                else if (num == -999 && min == int.MaxValue)
                {
                    min = 0;
                }

            } while (num != -999);

            Console.WriteLine("\nOutput:");
            Console.WriteLine("\t Input number is : " + strNum);
            Console.WriteLine("\t Sum = " + sum);
            Console.WriteLine("\t Max number = " + max);
            Console.WriteLine("\t Min number = " + min);