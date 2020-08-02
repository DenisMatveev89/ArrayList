using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayList
{
    public class ArrayList
    {
        private int[] _array;
        private int _realLength = 0;
        private int _counter = 0;
        public ArrayList(int initSize = 0)
        {
            _array = new int[initSize];

        }
        public ArrayList(int[] array)
        {
            _array = new int[array.Length+5];
            for (int i = 0; i < array.Length; i++)
            {
                _array[i] = array[i];
            }
            _counter = array.Length;
            _realLength = array.Length;
        }
        // Сдиг вправо.
        public int[] ShiftRight(int[] array, int[] newArray, int start)
        {
            for (int i = start; i < array.Length - 1; i++)
            {
                newArray[i] = array[i - 1];
            }
            return newArray;
        }
        // Сдиг влево.
        public int[] ShiftLeft(int[] array, int[] newArray, int start)
        {
            for (int i = start; i < array.Length - 1; i++)
            {
                newArray[i] = array[i+1];
            }
            return newArray;
        }
        // Копирование старого массива в новый увеличенного размера.
        public int[] CopyArr(int[] array, int[] newArray)
        {
            for (int j = 0; j < _counter; j++)
            {
                newArray[j] = array[j];
            }
            return newArray;
        }
        // Добавление элемента в конец массива.
        public void AddLast(int item)
        {

            if (_counter >= _realLength || _realLength == 0)
            {

                int[] newArray = new int[(int)(_array.Length + 10)];
                CopyArr(_array, newArray);
                newArray[_counter] = item;
                _array = newArray;
                _counter++;
                _realLength = newArray.Length;
            }
            else
            {
                _array[_counter] = item;
                _counter++;
            }
        }
        // Добавление массива в конец массива.
        public void AddLast(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                AddLast(array[i]);
            }
        }
        // Добавление элемента в начало массива.
        public void AddFirst(int item)
        {

            if (_counter >= _realLength)
            {
                int[] newArray = new int[(int)(_array.Length * 1.5)];
                ShiftRight(_array, newArray, 1);
                newArray[0] = item;
                _array = newArray;
                _realLength = newArray.Length;
                _counter++;
            }
            else
            {
                int[] newArray = new int[_realLength];
                ShiftRight(_array, newArray, 1);
                newArray[0] = item;
                _array = newArray;
                _counter++;
                _realLength = newArray.Length;
            }

        }
        // Добавление массива в начало массива.
        public void AddFirst(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                AddFirst(array[i]);
            }
        }
        // Вставка элемента в массив по указанному индексу.
        public void AddAt(int index, int item)
        {
            if (index < _counter && index > 0)
            {
                if (_counter >= _realLength)
                {
                    int[] newArray = new int[(int)(_array.Length * 1.5 - 1)];
                    CopyArr(_array, newArray);
                    ShiftRight(_array, newArray, index);
                    newArray[index] = item;
                    _counter++;
                    _array = newArray;
                    _realLength = newArray.Length;
                }
                else
                {
                    int[] newArray = new int[_realLength];
                    CopyArr(_array, newArray);
                    ShiftRight(_array, newArray, index);
                    newArray[index] = item;
                    _counter++;
                    _array = newArray;
                    _realLength = newArray.Length;
                }

            }
            else if (index == 0) { AddFirst(item); }
            else return;
        }
        // Вставка массива в массив по указанному индексу.
        public void AddAt(int index, int[] array) 
        {
            if (index >= _counter)
            {
                AddLast(array);
            }
            else
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    AddAt(index, array[i]);
                }
            }

        }
        // Узнать кол-во элементов в списке.
        public int GetSize()
        {
            return _counter;
        }
        // Поменять значение элемента с указанным индексом.
        public void Set(int index, int items)
        {
            if (index <= _counter - 1)
            {
                _array[index] = items;
            }
            else
            {
                Console.WriteLine($"\nИндекса {index} для изменения не существует в этом массиве");
            }
        }
        // Удаление первого элемента в массиве.
        public void RemoveFirst() 
        {
            int[] newArray = new int[_array.Length];
            _array[0] = 0;
            ShiftLeft(_array, newArray, 0);

            _array = newArray;
            _counter--;
        }
        // Удаление последнего элемента из массива.
        public void RemoveLast() 
        {
            _array[_counter] = 0;
            _counter--;
        }
        // Удаление элемента из массива по индексу.
        public void RemoveAt(int index) 
        {

            if (index < _counter)
            {

                ShiftLeft(_array, _array, index);
                _counter--;
            }
            else
            {
                Console.WriteLine($"\nИндекса {index} для удаления не существует в этом массиве");
            }
        }
        // Удалить все элементы из массива, равные val.
        public void RemoveAll(int item) 
        {
            for (int i = 0; i < _counter; i++)
            {
                if (item == _array[i])
                {
                    RemoveAt(i);
                }
            }
        }
        // Проверка, есть ли элемент в списке.
        public bool Contains(int item) 
        {
            bool result = false;
            for (int i = 0; i < _counter; i++)
            {
                if (_array[i] == item)
                {
                    return result = true;
                }
            }
            return false;
        }
        // Вернёт индекс первого найденного элемента, равного val(или -1, если элементов с таким значением в списке нет).
        public int IndexOf(int item) 
        {
            int index = -1;
            //bool res = Contains(items);
            for (int i = 0; i < _counter; i++)
            {
                if (_array[i] == item)
                {
                    return index = i;
                }
            }
            return index;
        }
        // Вернёт хранимые данные в виде массива.
        public int[] ToArray() 
        {
            int[] newArray = new int[_counter];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = _array[i];
            }
            return newArray;
        }
        // Вернёт значение первого элемента списка.
        public int GetFirst()
        {
            return _array[0];
        }
        // Вернёт значение последнего элемента списка.
        public int GetLast() 
        {
            return _array[_counter - 1];
        }
        // Вернёт значение элемента списка c указанным индексом.
        public int Get(int index) 
        {
            if (index > _counter - 1) return 0;
            else return _array[index];
        }
        // Реверс массива
        public int[] ReverseArray(int[] array)
        {
            int tmp = 0;
            int l = array.Length;
            int[] revArray = new int[l];
            for (int i = 0; i < array.Length; i++)
            {
                tmp = array[i];
                array[i] = array[array.Length - i - 1];
                array[i] = tmp;
                revArray[i] = array[array.Length - i - 1];
            }
            return revArray;
        }
        // Изменение порядка элементов списка на обратный.
        public int[] Reverse() 
        {
            int[] revArray = ToArray();
            return _array = ReverseArray(revArray);
        }
        // Поиск значения максимального элемента.
        public int Max() 
        {
            int max = 0;
            for (int i = 0; i < _counter; i++)
            {

                if (_array[i] > _array[max])
                {
                    max = i;
                }
            }
            return _array[max];
        }
        // Поиск значения минимального элемента.
        public int Min() 
        {
            int min = 0;
            for (int i = 0; i < _counter; i++)
            {

                if (_array[i] < _array[min])
                {
                    min = i;
                }
            }
            return _array[min];
        }
        // Поиск индекса максимального элемента.
        public int IndexOfMax() 
        {
            int max = 0;
            for (int i = 0; i < _counter; i++)
            {

                if (_array[i] > _array[max])
                {
                    max = i;
                }
            }
            return max;
        }
        // Поиск индекса минимального элемента.
        public int IndexOfMin() 
        {
            int min = 0;
            for (int i = 0; i < _counter; i++)
            {

                if (_array[i] < _array[min])
                {
                    min = i;
                }
            }
            return min;
        }
        private void Swap(ref int a,ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        // Сортировка по возрастанию.
        public void Sort()
        {
            int d = _counter / 2;
            while (d >= 1)
            {
                for (int i = d; i < _counter; i++)
                {
                    int j = i;
                    while ((j >= d) && (_array[j - d] > _array[j]))
                    {
                        Swap(ref _array[j], ref _array[j - d]);
                        j = j - d;
                    }
                }

                d = d / 2;
            }
        }
        // Сортировка по убыванию.
        public void SortDesc() 
        {
            int d = _counter / 2;
            while (d >= 1)
            {
                for (int i = d; i < _counter; i++)
                {
                    int j = i;
                    while ((j >= d) && (_array[j - d] < _array[j]))
                    {
                        Swap(ref _array[j], ref _array[j - d]);
                        j = j - d;
                    }
                }

                d = d / 2;
            }
        }
        // Вывод списка в консоль.
        public void PrintArrayList()
        {
            Console.WriteLine("\n");
            for (int i = 0; i < _counter; i++)
            {
                Console.Write(_array[i] + " ");
            }
        }
        // Очистка списка.
        public void Clear()
        {
            _counter = 0;
        }
    }
}
