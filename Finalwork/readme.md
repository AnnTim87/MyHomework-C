Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Решение:
1. Объявляется два массива: имеющийся массив и второй такой же длины. 
2. Метод, в котором цикл соразмерный длине массива, внутри цикла проверка условия ( <=3 ). Если условие подтверждается, элемент первого массива заносится в count элемент второго массива. После присвоения увеличивается переменная count на 1 и возвращается к циклу for в котором i увеличивается на 1. И так проверяется до конца.