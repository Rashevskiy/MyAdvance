package com.company;

import com.sun.org.apache.xpath.internal.operations.Bool;

import java.io.*;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import java.util.Locale;

/*
Читаем и пишем в файл: JavaRush
*/
public class Solution {
    public static void main(String[] args) {
        //you can find your_file_name.tmp in your TMP directory or adjust outputStream/inputStream according to your file's actual location
        //вы можете найти your_file_name.tmp в папке TMP или исправьте outputStream/inputStream в соответствии с путем к вашему реальному файлу
        try {
            File yourFile = File.createTempFile("your_file_name", null);

            OutputStream outputStream = new FileOutputStream(yourFile);
            InputStream inputStream = new FileInputStream(yourFile);

            JavaRush javaRush = new JavaRush();
            //initialize users field for the javaRush object here - инициализируйте поле users для объекта javaRush тут
            User user1 = new User();
            user1.setCountry(User.Country.RUSSIA);
            user1.setMale(true);
            user1.setBirthDate(new Date());
            user1.setFirstName("Vasia");
            user1.setLastName("Kakashkin");

            User user2 = new User();
            user2.setCountry(User.Country.UKRAINE);
            user2.setMale(false);
            user2.setBirthDate(new Date());
            user2.setFirstName("Nastya");
            user2.setLastName("Shaboldkina");

            javaRush.users.add(user1);
            javaRush.users.add(user2);
            javaRush.save(outputStream);
            outputStream.flush();

            JavaRush loadedObject = new JavaRush();
            loadedObject.load(inputStream);
//            here check that the javaRush object is equal to the loadedObject object - проверьте тут, что javaRush и loadedObject равны
            System.out.println(javaRush.equals(loadedObject));
            System.out.println("javaRush.getbirthdate = " + javaRush.users.get(0).getBirthDate().getTime());
            System.out.println("loadedObject.getbirthdate = " + loadedObject.users.get(0).getBirthDate().getTime());
            System.out.println("javaRush.getFirstName() = " + javaRush.users.get(0).getFirstName());
            System.out.println("loadedObject.getFirstName() = " + loadedObject.users.get(0).getFirstName());
            System.out.println("javaRush.getLastName() = " + javaRush.users.get(0).getLastName());
            System.out.println("loadedObject.getLastName() = " + loadedObject.users.get(0).getLastName());
            System.out.println("javaRush.getCountry() = " + javaRush.users.get(0).getCountry());
            System.out.println("loadedObject.getCountry() = " + loadedObject.users.get(0).getCountry());
            System.out.println("javaRush.isMale() = " + javaRush.users.get(0).isMale());
            System.out.println("loadedObject.isMale() = " + loadedObject.users.get(0).isMale());

            outputStream.close();
            inputStream.close();
        } catch (IOException e) {
            //e.printStackTrace();
            System.out.println("Oops, something is wrong with my file");
        } catch (Exception e) {
            //e.printStackTrace();
            System.out.println("Oops, something is wrong with the save/load method");
        }
    }

    public static class JavaRush {
        public List<User> users = new ArrayList<>();

        public void save(OutputStream outputStream) throws Exception {
            PrintWriter printwriter = new PrintWriter(outputStream);
            String isUsers = !users.isEmpty() ? "Yes": "No";
            printwriter.println(isUsers); // 1
            printwriter.flush();
            if(!users.isEmpty()){
                for(User item : users){
                   if(item.getFirstName() != null) printwriter.println(item.getFirstName());         // 2
                    printwriter.println(item.getLastName());          // 3
                    long birthdate = item.getBirthDate().getTime();
                    printwriter.println(String.valueOf(birthdate));  // 4
                    printwriter.println(String.valueOf(item.isMale()));// 5
                    printwriter.println(String.valueOf(item.getCountry()));//6
                    printwriter.flush();
                }
            }
            printwriter.close();
        }

        public void load(InputStream inputStream) throws Exception {
            BufferedReader reader = new BufferedReader(new InputStreamReader(inputStream));
            String str = reader.readLine();         // 1
            if(str.equals("Yes")){
                while(reader.ready()){
                    User user = new User();
                    user.setFirstName(reader.readLine()); //2
                    user.setLastName(reader.readLine());  //3
                    long dateNum = Long.parseLong(reader.readLine());
                    user.setBirthDate(new Date(dateNum));   // 4
                    user.setMale(Boolean.parseBoolean(reader.readLine()));
                    String country = reader.readLine();


                    switch (country) {
                        case "UKRAINE":
                            user.setCountry(User.Country.UKRAINE);
                            break;
                        case "RUSSIA":
                            user.setCountry(User.Country.RUSSIA);
                            break;
                        case "OTHER":
                            user.setCountry(User.Country.OTHER);
                            break;
                    }
                    users.add(user);
                }
            }
            reader.close();
        }

        @Override
        public boolean equals(Object o) {
            if (this == o) return true;
            if (o == null || getClass() != o.getClass()) return false;

            JavaRush javaRush = (JavaRush) o;

            return users != null ? users.equals(javaRush.users) : javaRush.users == null;

        }

        @Override
        public int hashCode() {
            return users != null ? users.hashCode() : 0;
        }
    }
}
