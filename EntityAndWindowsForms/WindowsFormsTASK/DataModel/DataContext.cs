    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

/*
*  Пространство сущностей базы данных
*/
namespace WindowsFormsTASK.DataModel
    {
        
        public class DataContext : DbContext
        {

            public DataContext()
                : base("DataContext")
            {
            }

            public DbSet<User> Users { get; set; }
            public DbSet<Marker> Markers { get; set; }
            public DbSet<Department> Departments { get; set; }
        }


   
        public class User
        {
            public int Id { get; set; }
            [MaxLength(50)]
            public string firstName { get; set; }
            [MaxLength(50)]
            public string secondName { get; set; }
            public DateTime birthData { get; set; }
            public int age { get; set; }
            public int personNum { get; set; }
            public int departmentId { get; set; }
            public Department department { get; set; }
            [MaxLength(50)]
            public string occupation { get; set; }
            public bool remoteWork { get; set; }
            [MaxLength(50)]
            public string address { get; set; }

            public List<Marker> Markers { get; set; }

            public User()
            {
                Markers = new List<Marker>();
            }

            public List<Marker> getMarkersOfMonth(int monthNumber)
            {
                List<Marker> markersOfMonth = new List<Marker>();
                int countDay = DateTime.DaysInMonth(2020, monthNumber);
                foreach (Marker marker in Markers)
                {
                    if (marker.month == monthNumber) markersOfMonth.Add(marker);
                }
                markersOfMonth.Sort();
                return markersOfMonth;
            }


        }

        //метки на календаре 
        public class Marker : IComparable
        {
            public int Id { get; set; }
            public int month { get; set; }
            public int day { get; set; }
            public CodingMarker state { get; set; }
            public int UserId { get; set; }


            public Marker()
            {

            }
            public Marker(int month, int day, CodingMarker state, int UserId)
            {
                this.month = month;
                this.day = day;
                this.state = state;
                this.UserId = UserId;

            }

            public int CompareTo(object obj)
            {
                Marker m = obj as Marker;
                if (m != null)
                {
                    if (this.day < m.day)
                    {
                        return -1;
                    }
                    else if (this.day > m.day)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    throw new Exception("Параметр должен быть типа day");
                }

            }
        }

    /*
     * Я – полный рабочий день;
     * Н – отсутствие на рабочее место по невыясненным причинам;
     * В – выходные и праздничные дни;
     * Рв – работа в праздничные и выходные дни; а также работа в праздничные и выходные дни, при
     * нахождении в командировке;
     * Б – дни временной нетрудоспособности;
     * К – командировочные дни; а также, выходные (нерабочие) дни при нахождении в командировке,
     * когда сотрудник отдыхает, в соответствии с графиком работы ООО «Наука» в командировке;
     * ОТ – ежегодный основной оплаченный отпуск;
     * До – неоплачиваемый отпуск (отпуск за свой счет);
     * Хд – хозяйственный день;
     * У – отпуск на период обучения.
     * Ож – Отпуск по уходу за ребенком.
     */
    public enum CodingMarker
        {
            Я,
            Н,
            В,
            Рв,
            Б,
            К,
            ОТ,
            До,
            Хд,
            У,
            Ож
        }

        public class Department
        {
            public int Id { get; set; }
            public string name { get; set; }

            public override string ToString()
            {
                return name;
            }
        }
    }
