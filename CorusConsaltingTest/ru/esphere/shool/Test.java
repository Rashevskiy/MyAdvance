package ru.esphere.shool;

import ru.esphere.shool.data.Member;
import ru.esphere.shool.data.MembersGroup;
import ru.esphere.shool.service.Finder;


import java.util.*;

public class Test
{
    public static void main(String[] args) {
        List<Member> members1 = new ArrayList<>();
        int num = 0;
        members1.add(new Member("Вася_" + num++, 23));
        members1.add(new Member("Вася_" + num++, 14));
        members1.add(new Member("Вася_" + num++, 26));
        members1.add(new Member("Вася_" + num++, 15));
        MembersGroup group1 = new MembersGroup("group1",members1);

        List<Member> members2 = new ArrayList<>();
        num = 0;
        members2.add(new Member("Петя_" + num++, 3));
        members2.add(new Member("Петя_" + num++, 4));
        members2.add(new Member("Петя_" + num++, 1));
        members2.add(new Member("Петя_" + num++, 5));
        MembersGroup group2 = new MembersGroup("group2",members2);

        List<Member> members3 = new ArrayList<>();
        num = 0;
        members3.add(new Member("Жора_" + num++, 56));
        members3.add(new Member("Жора_" + num++, 74));
        members3.add(new Member("Жора_" + num++, 62));
        members3.add(new Member("Жора_" + num++, 71));
        MembersGroup group3 = new MembersGroup("group3",members3);

        List<MembersGroup> groups = new ArrayList<>();
        groups.add(group1);
        groups.add(group2);
        groups.add(group3);

        Finder finder = new Finder();


        Set<String> listOfGroupNames;

        listOfGroupNames = finder.findOldMembers(groups,50);
        for(String name : listOfGroupNames){
            System.out.println(name);
        }


    }
}
