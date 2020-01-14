package textDublicate;

/*
Считай с консоли имя файла.
В методе main подмени объект System.out написанной тобой ридер-оберткой по аналогии с лекцией.
Твоя ридер-обертка должна выводить весь текст и на консоль и в файл, имя которого ты считал.
Вызови готовый метод printSomething(), воспользуйся testString.
Верни переменной System.out первоначальный поток.
Закрой поток файла.

Пример вывода на экран:
it's a text for testing

Пример тела файла:
it's a text for testing

Требования:
•	Класс Solution должен содержать класс TestString.
•	Класс Solution должен содержать публичное статическое поле testString типа TestString, которое сразу проинициализировано.
•	Класс TestString должен содержать публичный void метод printSomething().
•	Метод printSomething() класса TestString должен выводить на экран строку "it's a text for testing".
•	В методе main(String[] args) программа должна считывать имена файлов с консоли (используй BufferedReader).
•	В методе main(String[] args) BufferedReader для считывания данных с консоли должен быть закрыт.
•	Метод main(String[] args) класса Solution должен создавать поток PrintStream (используй PrintStream c конструктором принимающим ByteArrayOutputStream).
•	Метод main(String[] args) класса Solution должен подменять и восстанавливать поток вывода в консоль объекта System.out.
•	Метод main(String[] args) класса Solution должен один раз вызвать метод printSomething() объекта testString.
•	Метод main(String[] args) класса Solution должен выводить и в консоль и в файл строку выведенную методом printSomething() (используй FileOutputStream).
•	Поток записи в файл (FileOutputStream) должен быть закрыт.
*/

import java.io.*;

public class Solution {
    public static TestString testString = new TestString();



    public static void main(String[] args) throws IOException {
        //запоминаем настоящий PrintStream в специальную переменную
        PrintStream consoleStream = System.out;
        //Создаем динамический массив
        ByteArrayOutputStream byteArray = new ByteArrayOutputStream();
        //создаем адаптер к классу PrintStream
        PrintStream printStream = new PrintStream(byteArray);
        //Устанавливаем его как текущий System.out
        System.setOut(printStream);

        //А теперь вызываеть с нашим шпионом System.out.println
        TestString testString = new TestString();
        testString.printSomething();

        // Возвращаем все как было
        System.setOut(consoleStream);
        consoleStream.close();
        printStream.close();




    }

    public static class TestString {
        public void printSomething() {
            System.out.println("it's a text for testing");
        }
    }
}
