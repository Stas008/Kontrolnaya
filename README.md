# Readme

*Данная программа позволяет создать массив строк, где каждое слово состит не более, чем из трех букв*

##  Алгоритм 


1. Исходный текст (строка) находится в файле **input.txt**
2. С помощью команды **split** данная строка вносится в массив **words**, каждое слово на новой строчке
3. С помощью цикла **for** мы проходим все строчки до конца массива *(array.GetLength(0))*
4. С помощью оператора **if** сравниваем слово в строчке с заданной длиной *(l int (в нашем случае l=3))*
* если слово менее 3 букв (меньше или равно), то в переменную **temp** *(типа стринг)* записываем это слово и прибавляем пробел (для разделения слов)
* если слово более трех букв, то переходим к следующему.
5. в новый массив **result** c помощью команды сплит вносим слова из переменной **temp** *result=Zadacha(words).Split (' ');*
6. Пременную **temp** записываем в файл **output.txt**

 Таким образом мы отобрали все слова длинной нен более 3 символов и:
 * записали их в массив **result** и с помощью заранее описанного метода **PrintStringArray** вывели в консоль.
 *  записали эти слова в файл **output.txt


##  Альтернативный код

начиная с пункта 5, если не пользоваться коммандой сплит, можно было проделать все тоже самое через цикл **for**,

j=0; (индекс в новом массиве)
for (int i = 0; i < input.GetLength(0); i++)
{
     if (words[i].Length<=3)
     {
         result[j]=words[i];
         j++;
     }
}

 