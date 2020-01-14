package nioUnZip;

import java.io.*;
import java.nio.charset.Charset;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;
import java.util.zip.ZipInputStream;

public class Solution {
    public static void main(String[] args) throws IOException {

        List<String> list = new ArrayList<>(Arrays.asList(args).subList(1, args.length));
        Collections.sort(list);
        List<InputStream> list2 = new ArrayList<>();
        for (String s : list) {
            list2.add(new FileInputStream(s));
        }
        FileOutputStream fos = new FileOutputStream(args[0]);
        try(ZipInputStream zis = new ZipInputStream(new SequenceInputStream(Collections.enumeration(list2)))) {

            while(zis.getNextEntry()!=null) {
                byte[] buffer = new byte[1024];
                int countOfBytes;
                while ((countOfBytes = zis.read(buffer)) > 0) {
                    fos.write(buffer, 0, countOfBytes);
                    fos.flush();
                }
                zis.closeEntry();
            }
            /*int b;
            while (true){
                b = zis.read();
                if (b==-1)break;
                fos.write(b);

            }
            fos.flush();*/
        }
        catch (Exception e){
            e.printStackTrace();
        }
        fos.close();
    }
}
