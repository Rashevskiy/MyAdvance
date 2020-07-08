using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsTASK.DataModel;

namespace WindowsFormsTASK
{

    class Controller
    {
        // Вовзращает тех Юзеров с маркерами что были выделенны ListBoxом
        public static List<User> getUsersFromDatabase(System.Windows.Forms.ListBox SelectedDepartment, int monthNumber)
        {
            List<Department> departments = new List<Department>();
            List<User> returnUsers = new List<User>();
            foreach (Department item in SelectedDepartment.SelectedItems)
            {
                departments.Add(item);
            }

            using (DataContext context = new DataContext())
            {
                foreach (Department depart in departments)
                {
                    IQueryable<User> userIQuer = context.Users;
                    userIQuer = userIQuer.Where(p => p.department.Id == depart.Id);
                    returnUsers.AddRange(userIQuer.ToList());

                }
                foreach(User user in returnUsers)
                {
                    IQueryable<Marker> markerIQuer = context.Markers;
                    markerIQuer = markerIQuer.Where(p => p.UserId == user.Id);
                    user.Markers.AddRange(markerIQuer.ToList());
                }
            }
            return returnUsers;
        }

 
        // Устанавливает кодированную метку Юзера в календарь, если метка == Н то удаляется т.к метка Н всегда по дефолту даже в выходные дни=)
        public static void setMarkerToDatabase(int monthNumber,int Day,int UserId, CodingMarker state)
        {
            using (DataContext context = new DataContext())
            {
                try
                {

                    var marker = context.Markers.FirstOrDefault(m => m.month == monthNumber && m.day == Day && m.UserId == UserId);
                    if(state == CodingMarker.Н)
                    {
                        context.Markers.Remove(marker);
                        context.SaveChanges();
                    }
                    else
                    {
                        marker.state = state;
                        context.SaveChanges();
                    }
                }
                catch(System.NullReferenceException error)
                {
                    if (state == CodingMarker.Н) return;

                    var marker = new Marker()
                    {
                        month = monthNumber,
                        day = Day,
                        UserId = UserId,
                        state = state
                    };
                    context.Markers.Add(marker);
                    context.SaveChanges();
                }
                              
            }
        }


        public static void updateUserData(User user)
        {
            using (DataContext context = new DataContext())
            {
                var userDB = context.Users.FirstOrDefault(x => x.Id == user.Id);
                userDB.firstName = user.firstName;
                userDB.secondName = user.secondName;
                userDB.occupation = user.occupation;
                userDB.birthData = user.birthData;
                userDB.age = user.age;
                userDB.remoteWork = user.remoteWork;
                userDB.address = user.address;
                userDB.department = user.department;

                context.SaveChanges();
                
            }
        }

        //Если Отдела нету в базе данных, создается новый отдел
        public static void setDepartmentToUser(User user, string stringDepart)
        {

            List<Department> departments = new List<Department>();
            stringDepart = stringDepart.ToLower();
            

            using (DataContext context = new DataContext())
            {
                var departDB = context.Departments.FirstOrDefault(x => x.name.Equals(stringDepart));
                var userDB = context.Users.FirstOrDefault(x => x.Id == user.Id);

                if (departDB == null)
                {


                    Department newDepar = new Department()
                    {
                        name = stringDepart
                    };

                    userDB.department = newDepar;
                    context.Departments.Add(newDepar);

                }
                else
                {
                    userDB.department = departDB;

                }
                context.SaveChanges();
            }
        }

        //При создании Юзера проверяет наличие департамента, если нету создается новый отдел
        public static void createNewUser(User user, string depart)
        {

            using (DataContext context = new DataContext())
            {
                var departDB = context.Departments.FirstOrDefault(x => x.name.Equals(depart));

                if (departDB == null)
                {
                    Department newDepar = new Department()
                    {
                        name = depart
                    };
                    context.Departments.Add(newDepar);

                }

                context.SaveChanges();
            }


            using (DataContext context = new DataContext())
            {
                var departDB = context.Departments.FirstOrDefault(x => x.name.Equals(depart));
                user.departmentId = departDB.Id;
                context.Users.Add(user);
                context.SaveChanges();
            }

            setDepartmentToUser(user, depart);
        }


        public static List<User> getAllUsersFromDatabase()
        {
            List<User> returnUsers = new List<User>();

            using (DataContext context = new DataContext())
            {
                returnUsers = context.Users.ToList();
                foreach (User user in returnUsers)
                {
                    IQueryable<Department> deparIQuer = context.Departments;
                    deparIQuer = context.Departments.Where(d => d.Id == user.departmentId);
                    user.department = deparIQuer.Single();
                }
            }

            return returnUsers;
        }


        public static List<Department> GetAllDepartments()
        {
            List<Department> departments = new List<Department>();
            using (DataContext context = new DataContext())
            {
                departments = context.Departments.ToList();

            }

            return departments;
        }
    }
}
