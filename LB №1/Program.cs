using System;

internal class Program
{
    static void Main(string[] args)
    {
        bool work = true;

        while (work)
        {
            try
            {
                Console.WriteLine("----Лабораторная работа №1 ---\t");
                Console.WriteLine("-------------Методы-----------\t");
                Console.WriteLine(" 1.Cумма знаков\t");
                Console.WriteLine(" 2.Есть ли позитив\t");
                Console.WriteLine(" 3.Большая буква\t");
                Console.WriteLine(" 4.Делитель\t");
                Console.WriteLine(" 5.Многократный вызов\t");
                Console.WriteLine("------------Условия-----------\t");
                Console.WriteLine(" 6.Безопасность деление\t");
                Console.WriteLine(" 7.Строка сравнения\t");
                Console.WriteLine(" 8.Тройная сумма\t");
                Console.WriteLine(" 9.Возраст\t");
                Console.WriteLine("10.Вывод дней недели\t");
                Console.WriteLine("------------Циклы-------------\t");
                Console.WriteLine("11.Числа наоборот\t");
                Console.WriteLine("12.Степень числа\t");
                Console.WriteLine("13.Одинаковость\t");
                Console.WriteLine("14.Левый треугольник\t");
                Console.WriteLine("15.Угадайка\t");
                Console.WriteLine("-----------Массивы------------\t");
                Console.WriteLine("16.Поиск последнего значения\t");
                Console.WriteLine("17.Добавление в массив\t");
                Console.WriteLine("18.Реверс\t");
                Console.WriteLine("19.Объединение\t");
                Console.WriteLine("20.Удалить негатив\t");
                Console.WriteLine("0.Выход");
                Console.WriteLine("Введиете номер задачи:\t");

                int choice = int.Parse(Console.ReadLine());
                Solution solution = new Solution();

                switch (choice)
                {
                    case 0:
                        work = false;
                        break;

                    case 1:
                        {
                            Console.WriteLine("Введите целое число:");
                            int x = int.Parse(Console.ReadLine());

                            Console.Write("Результат: ");
                            Console.WriteLine(solution.sumLastNums(x));
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Введите целое число:");
                            int x = int.Parse(Console.ReadLine());

                            Console.Write("Результат: ");
                            Console.WriteLine(solution.isPositive(x));
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("Введите букву латинского алфавита:");
                            char x = char.Parse(Console.ReadLine());

                            Console.Write("Результат: ");
                            Console.WriteLine(solution.isUpperCase(x));
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("Введите первое целое число:");
                            int x = int.Parse(Console.ReadLine());

                            Console.WriteLine("Введите второе целое число:");
                            int y = int.Parse(Console.ReadLine());

                            Console.Write("Результат: ");
                            Console.WriteLine(solution.isDivisor(x, y));
                            break;
                        }

                    case 5:
                        {
                            Console.WriteLine("Введите первое целое число:");
                            int x = int.Parse(Console.ReadLine());

                            Console.WriteLine("Введите второе целое число:");
                            int y = int.Parse(Console.ReadLine());

                            Console.Write("Результат: ");
                            Console.WriteLine(solution.lastNumSum(x, y));
                            break;
                        }

                    case 6:
                        {
                            Console.WriteLine("Введите первое целое число:");
                            int x = int.Parse(Console.ReadLine());

                            Console.WriteLine("Введите второе целое число:");
                            int y = int.Parse(Console.ReadLine());

                            Console.Write("Результат: ");
                            Console.WriteLine(solution.safeDiv(x, y));
                            break;
                        }

                    case 7:
                        {
                            Console.WriteLine("Введите первое целое число:");
                            int x = int.Parse(Console.ReadLine());

                            Console.WriteLine("Введите второе целое число:");
                            int y = int.Parse(Console.ReadLine());

                            Console.Write("Результат: ");
                            Console.WriteLine(solution.makeDecision(x, y));
                            break;
                        }

                    case 8:
                        {
                            Console.WriteLine("Введите первое целое число:");
                            int x = int.Parse(Console.ReadLine());

                            Console.WriteLine("Введите второе целое число:");
                            int y = int.Parse(Console.ReadLine());

                            Console.WriteLine("Введите третье целое число:");
                            int z = int.Parse(Console.ReadLine());

                            Console.Write("Результат: ");
                            Console.WriteLine(solution.sum3(x, y, z));
                            break;
                        }

                    case 9:
                        {
                            Console.WriteLine("Введите возраст(целое цисло):");
                            int x = int.Parse(Console.ReadLine());

                            Console.Write("Результат: ");
                            Console.WriteLine(solution.age(x));
                            break;
                        }

                    case 10:
                        {
                            Console.WriteLine("Введите день недели(полное название):");
                            string x = Console.ReadLine();

                            Console.WriteLine("Результат: ");
                            solution.printDays(x);
                            break;
                        }

                    case 11:
                        {
                            Console.WriteLine("Введите целое число:");
                            int x = int.Parse(Console.ReadLine());

                            Console.Write("Результат: ");
                            Console.WriteLine(solution.reverseListNums(x));
                            break;
                        }

                    case 12:
                        {
                            Console.WriteLine("Введите целое число:");
                            int x = int.Parse(Console.ReadLine());

                            Console.WriteLine("Введите степень(положиетельное целое число):");
                            int y = int.Parse(Console.ReadLine());

                            Console.Write("Результат: ");
                            Console.WriteLine(solution.pow(x, y));
                            break;
                        }

                    case 13:
                        {
                            Console.WriteLine("Введите целое число:");
                            int x = int.Parse(Console.ReadLine());

                            Console.Write("Результат: ");
                            Console.WriteLine(solution.equalNum(x));
                            break;
                        }

                    case 14:
                        {
                            Console.WriteLine("Введите целое число:");
                            int x = int.Parse(Console.ReadLine());

                            Console.WriteLine("Результат: ");
                            solution.leftTriangle(x);
                            break;
                        }

                    case 15:
                        {
                            solution.guessGame();
                            break;
                        }

                    case 16:
                        {
                            int[] arr = solution.generationArr(1, 10, 5);
                            Console.WriteLine("Введите целое число от 1 до 10:");
                            int x = int.Parse(Console.ReadLine());

                            Console.Write("Массив: ");
                            for (int i = 0; i < arr.Length; i++)
                            {
                                Console.Write(arr[i] + " ");
                            }
                            Console.WriteLine();

                            Console.Write("Результат: ");
                            Console.WriteLine(solution.findLast(arr, x));
                            break;
                        }

                    case 17:
                        {
                            int[] arr = solution.generationArr(1, 10, 10);
                            Console.WriteLine("Введите целое число:");
                            int x = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите позицию для этого числа(от 1 до 10):");
                            int position = int.Parse(Console.ReadLine());

                            Console.Write("Массив: ");
                            for (int i = 0; i < arr.Length; i++)
                            {
                                Console.Write(arr[i] + " ");
                            }
                            Console.WriteLine();

                            Console.Write("Результат: ");
                            int[] newArr = solution.add(arr, x, position);
                            for (int i = 0; i < newArr.Length; i++)
                            {
                                Console.Write(newArr[i] + " ");
                            }
                            Console.WriteLine();
                            break;
                        }

                    case 18:
                        {
                            int[] arr = solution.generationArr(1, 10, 5);

                            Console.Write("Массив: ");
                            for (int i = 0; i < arr.Length; i++)
                            {
                                Console.Write(arr[i] + " ");
                            }
                            Console.WriteLine();

                            solution.reverse(arr);
                            Console.Write("Результат: ");
                            for (int i = 0; i < arr.Length; i++)
                            {
                                Console.Write(arr[i] + " ");
                            }
                            Console.WriteLine();

                            break;
                        }

                    case 19:
                        {
                            int[] arr1 = solution.generationArr(1, 10, 5);

                            Console.Write("Массив 1: ");
                            for (int i = 0; i < arr1.Length; i++)
                            {
                                Console.Write(arr1[i] + " ");
                            }
                            Console.WriteLine();

                            int[] arr2 = solution.generationArr(1, 10, 6);

                            Console.Write("Массив 2: ");
                            for (int i = 0; i < arr2.Length; i++)
                            {
                                Console.Write(arr2[i] + " ");
                            }
                            Console.WriteLine();

                            int[] arr = solution.concat(arr1, arr2);
                            Console.Write("Результат: ");
                            for (int i = 0; i < arr.Length; i++)
                            {
                                Console.Write(arr[i] + " ");
                            }
                            Console.WriteLine();
                            break;
                        }

                    case 20:
                        {
                            int[] arr = solution.generationArr(-10, 10, 10);

                            Console.Write("Массив: ");
                            for (int i = 0; i < arr.Length; i++)
                            {
                                Console.Write(arr[i] + " ");
                            }
                            Console.WriteLine();

                            int[] newArr = solution.deleteNegative(arr);
                            Console.Write("Результат: ");
                            for (int i = 0; i < newArr.Length; i++)
                            {
                                Console.Write(newArr[i] + " ");
                            }
                            Console.WriteLine();
                            break;
                        }

                    default:
                        {
                            ConsoleColor previousColor = Console.ForegroundColor;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Нет такой задачи, введите другой номер задачи!");
                            Console.ForegroundColor = previousColor;
                            break;
                        }
                }

                Console.WriteLine("Нажмите любую клавишу...");
                Console.ReadKey();
                Console.WriteLine("\n");
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели неверные данные, повторите попытку");
            }
        }
    }
}