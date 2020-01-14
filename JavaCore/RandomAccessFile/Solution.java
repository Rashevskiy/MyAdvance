//package RandomAccessFile;

import java.io.*;

/*
В метод main приходят три параметра:
1) fileName - путь к файлу;
2) number - число, позиция в файле;
3) text - текст.
Записать text в файл fileName начиная с позиции number.
Запись должна производиться поверх старых данных, содержащихся в файле.
Если файл слишком короткий, то записать в конец файла.
Используй RandomAccessFile и его методы seek и write.

Требования:
•	В методе main класса Solution необходимо использовать RandomAccessFile.
•	В методе main класса Solution программа должна записывать данные в файл при помощи метода write класса RandomAccessFile.
•	Запись в файл должна происходить с указанной позиции с заменой содержимого.
•	Если файл слишком короткий, то запись text должна происходить в конец файла.
 */
//public class Solution {
//    public static void main(String... args) throws IOException {
////        args = new String[]{"test", "25", "hello"};
//
//        final String fileName = args[0];
//        final long position = Long.parseLong(args[1]);
//        final String text = args[2];
//
//        RandomAccessFile raf = new RandomAccessFile(fileName, "rw");
//
//
//
//        if (raf.length() < position) {
//            raf.seek(raf.length());
//            raf.write(text.getBytes());
//        } else {
//            raf.seek(position);
//            raf.write(text.getBytes());
//        }
//
//        raf.close();
//
//    }
//}
