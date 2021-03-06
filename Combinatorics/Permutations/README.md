# Генерация всех перестановок

Число всех перестановок из **n** равно факториалу **n!**

## Генерация всех перестановок в лексикографическом порядке

### Определение
Определение лексикографического порядка можно найти [здесь](http://surl.li/unzr)

#### Алгоритм Нарайаны  
Рассмотрим нерекурсивный алгоритм, генерирующий по данной перестановке следующую за ней перестановку
в лексикографическом порядке.

1. Последовательность элементов просматривается с конца до тех пор, пока не будет встречен первый эелемент *a[i] < a[i+1]*
2. В "хвосте" последовательности, состоящем из элементов, расположенных за найденым элементом, производим поиск минимального элемента **min**, большего, чем a[i].
3. Меняем местами a[i] и найденный элемент **min**
4. Сортируем "хвост" последовательности

К примеру, у нас есть перестановка [1,2,5,8,7,3]

![picture1](https://github.com/kaarenina/AlgorithmWorkshop/blob/combinatorics/images/Combinatorics/example1.png)


следующая перестановка по лексикографическому порядку будет выглядеть так: [1,2,7,3,5,8].

Псевдокод:


![picture2](https://github.com/kaarenina/AlgorithmWorkshop/blob/combinatorics/images/Combinatorics/psevdocode.png)

#### Реализация на языке C#

[Здесь](https://github.com/kaarenina/AlgorithmWorkshop/blob/combinatorics/Combinatorics/Permutations/NarayanaSimple.cs) полный код алгоритма. Это простая реализация алгоритма, которая может быть переписана на любом ЯП.

1. Находим такое *a[ i ]*, чтобы *a[ i ] < a[ i+1 ]* и сохраняем его и его индекс. 
```csharp
                if(array[i+1] > array[i])
                {
                    int minValue = array[i+1], minIndex = i+1;
```

2. Ищем в "хвосте" последовательности такое *a[ j ]*, чтобы *a[ i ] < a[ j ] < a[ i+1 ]*
```csharp
                for(int j = i+2; j<n; j++)
                    {
                        if(array[j] > array[i] && array[j] < minValue)
                        {
                            minValue = array[j];
                            minIndex = j;
                        }
                    }
```

3. Меняем местами минимальное число, найденное в предидущем пункте, и *a[ i ]* и сортируем хвост последовательности
```csharp
                    Swap(ref array, i, minIndex);
                    // Четвертый этап
                    Array.Sort(array, i+1, n-i-1);
```






