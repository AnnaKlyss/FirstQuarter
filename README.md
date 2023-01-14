# Задача
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

# Алгоритм решения
* Вводим массив с клавиатуры.
* Создаем цикл для подсчета количества.элементов, длина которых меньше, либо равна 3 символам.  
* Задаем новый массив, длиной равной получившемуся значению в цикле, описанном выше.
* Создаем цикл, в котором заполняем новый массив, где каждому элементу второго массива соответствует элемент первого массива, удовлетворяющий условию  arr[i].Length <= 3.
* Выводим второй массив на печать.
  

 Блок-схема алгоритма содержится в файле diagram.drawio.png