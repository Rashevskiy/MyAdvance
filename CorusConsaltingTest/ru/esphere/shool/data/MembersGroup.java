package ru.esphere.shool.data;

import java.util.ArrayList;
import java.util.List;

public class MembersGroup {
    private final String groupName;
    private final List<Member> members;
    public MembersGroup(String groupName, List<Member> members) {
        this.groupName = groupName;
        this.members = members;
    }
    public String getGroupName() {
        return groupName;
    }
    public List<Member> getMembers() {
        return members;
    }

    //Мой метод возвращает возраст всех участников данной группы
    public List<Integer> getAgesOfEachMember(){
        List<Integer> ages = new ArrayList<>();
        for(Member member : members){
            ages.add(member.getAge());
        }
        return ages;
    }
}
