﻿/*
 * Задача : 
 * Получить от пользователя четырехзначное натуральное число 
 * и напечатать его цифры в обратном порядке.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 1234
 * -------test_2-------
 * 5669
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 4321
 * -------test_2-------
 * 9665
 * --------------------
 */

using System;

namespace Task_4 {
	class Program {
		static void Main(string[] args) {
			int x;
			// TODO : Считать целочисленное значение.
			x = int.Parse(Console.ReadLine());
			// TODO : Вычислить значение и вывести.
			Console.WriteLine(ReverseNumber(x));
		}

		static int ReverseNumber(int x) {
			// Предлагается 2 решения данной задачи : 
			// 1) Выделить каждую цифру в отдельную переменную и собрать их в обратном порядке.
			// 2) Преобразовать переменную в строку использовать метод Reverse и выполнить обратное преобразование.
			// Выбор метода остаётся за вами.
			int first = x / 1000,
				second = x / 100 % 10,
				third = x / 10 % 10,
				fourth = x % 10;
			return fourth * 1000 + third * 100 + second * 10 + first;
		}
	}
}
