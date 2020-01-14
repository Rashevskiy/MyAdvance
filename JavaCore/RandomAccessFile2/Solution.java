package RandomAccessFile2;

/*
В метод main приходят три параметра:
1) fileName - путь к файлу;
2) number - число, позиция в файле;
3) text - текст.

Считать текст с файла начиная с позиции number, длинной такой же как и длинна переданного текста в третьем параметре.
Если считанный текст такой же как и text, то записать в конец файла строку 'true', иначе записать 'false'.
Используй RandomAccessFile и его методы seek(long pos), read(byte[] b, int off, int len), write(byte[] b).
Используй один из конструкторов класса String для конвертации считанной строчки в текст.

Требования:
•	В методе main класса Solution необходимо использовать RandomAccessFile, который должен использовать файл, который приходит первым параметром.
•	В методе main класса Solution программа должна устанавливать позицию в файле, которая передана во втором параметре.
•	В методе main класса Solution программа должна считывать данные с файла при помощи метода read(byte[] b, int off, int len).
•	Запись должна происходить в конец файла.
•	Если считанный текст такой же как и text, то программа должна записать в конец переданного файла строку 'true'.
•	Если считанный текст НЕ такой же как и text, то программа должна записать в конец переданного файла строку 'false'.
*/

import java.io.ByteArrayInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.RandomAccessFile;
import java.nio.ByteBuffer;

//public class Solution {
//    public static void main(String... args) {
//        try (RandomAccessFile raFile = new RandomAccessFile(args[0], "rw")){
//            int posInFile = Integer.parseInt(args[1]);
//            String textInArgs = args[2];
//            byte[] arr = new byte[textInArgs.getBytes().length];
//            raFile.seek(posInFile);
//            raFile.read(arr, 0, textInArgs.getBytes().length);
//            String textInFile = new String(arr);
//            raFile.seek(raFile.length());
//            if (textInArgs.equals(textInFile)) {
//                raFile.write("true".getBytes());
//            } else {
//                raFile.write("false".getBytes());
//            }
//        } catch (IOException e) {
//            e.printStackTrace();
//        }
//    }
//}
