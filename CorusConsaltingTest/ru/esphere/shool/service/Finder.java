package ru.esphere.shool.service;

import ru.esphere.shool.data.Member;
import ru.esphere.shool.data.MembersGroup;

import java.util.HashSet;
import java.util.List;
import java.util.Set;
import java.util.stream.Stream;

public class Finder {
    /**
     * Поиск групп людей старше определенного возраста.
     *
     * @param groups группы
     * @param targetAge возраст для поиска
     * @return список имен групп из списка групп старше возраста targetAge
     */
    public Set<String> findOldMembers(List<MembersGroup> groups, int targetAge) {
        Set<String> groupsNames = new HashSet<>();
        for(MembersGroup membersGroup : groups){
            Stream stream = membersGroup.getAgesOfEachMember().stream();
            stream.filter(x -> (int) x > targetAge)
                    .forEach( x -> groupsNames.add(membersGroup.getGroupName()));
        }

        return groupsNames;
    }
}
