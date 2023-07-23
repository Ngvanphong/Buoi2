
using Buoi9;
using System.Collections;
using System.Data;

Student std1 = new Student();
std1.Name = "Student 1";
std1.Id = 1;
std1.Age = 17;
Student std2 = new Student { Name = "Student 2", Id = 2, Age = 20 };
Student std3 = new Student("Student 3", 3, 18);
Student std4 = new Student("Student 3", 4, 19);

List<int> listInt = new List<int>();
listInt.Add(3);
listInt.Add(4);
listInt.Add(3);


//for(int i= 0; i < listStudent.Count; i++)
//{
//    Student item = listStudent[i];
//    Console.WriteLine("Tuoi: "+item.Age);
//}


//int[] arrayInt = { 1, 2, 2, 2, 33, 6 };
//int total = 0;
//listInt.ForEach((x) =>total += x);
//Console.WriteLine(total);

List<Student> listStudent = new List<Student>();
listStudent.Add(std1);
listStudent.Add(std2);
listStudent.Add(std3);
listStudent.Add(std4);

IEnumerable<Student> student18s = listStudent.Where(x => x.Age >16 && x.Age<=18);

//Console.WriteLine(student18s.Count());
//foreach (Student student in student18s)
//{
//    Console.WriteLine(student.Name);
//}

IList listTypes = new ArrayList();
listTypes.Add(0);
listTypes.Add(1);
listTypes.Add(std4);
listTypes.Add("Demo");
listTypes.Add('d');

IEnumerable<Student> listStringFromType = listTypes.OfType<Student>();
//Console.WriteLine(listStringFromType.Count());
//foreach(var item in listStringFromType)
//{
//    Console.WriteLine(item.Name);
//}

IEnumerable<Student> listOrder = listStudent.OrderBy(x => x.Age).ThenBy(x=>x.Name);
//listOrder= listStudent.OrderByDescending(x => x.Age);
//foreach(Student student in listOrder)
//{
//    Console.WriteLine(student.Name);
//}

var listOrderBy = from st in listStudent
                  orderby st.Age, st.Name
                  select st.Name;

//foreach(var name in listOrderBy)
//{
//    Console.WriteLine(name);
//}
                  

var listGroup = from std in listStudent
                group std by std.Age;

//foreach (var item in listGroup)
//{
//    Console.WriteLine(item.Key);
//    foreach (var studentItem in item)
//    {
//        Console.WriteLine(studentItem.Name);
//    }
//}

IEnumerable<string> allName = from st in listStudent select st.Name;
allName = allName.Distinct();
//foreach (var name in allName)
//{
//    Console.WriteLine(name);
//}

//List<string> allName2 = new List<string>();
//foreach(Student st in listStudent)
//{
//    allName2.Add(st.Name);
//}

//allName2 = allName2.Distinct().ToList();

//foreach (var name in allName2)
//{
//    Console.WriteLine(name);
//}


IEnumerable<Student> listAllSameName = listStudent.Where(x => x.Name == "Student 3");
//foreach (var student in listAllSameName)
//{
//    Console.WriteLine(student.Age);
//}

//Console.WriteLine(listAllSameName.Count());


//Student std1 = new Student();
//std1.Name = "Student 1";
//std1.Id = 1;
//std1.Age = 17;
//Student std2 = new Student { Name = "Student 2", Id = 2, Age = 20 };
//Student std3 = new Student("Student 3", 3, 18);
//Student std4 = new Student("Student 3", 4, 19);

//bool isAll = listStudent.All(x => x.Name == "Student 3");
bool isExist = listStudent.Exists(x => x.Name == "Student 3");
//Console.WriteLine(isAll);

bool isHasIitem = listStudent.Any(x=>x.Name== "Student 3");

Student st5 = new Student();

bool isContain = listStudent.Contains(std1);

//Console.WriteLine(isContain);
List<int> listInt2 = new List<int>() { 22, 2, 2, 2, };
int max2= listInt2.Max();

int maxAge = listStudent.Max(x=>x.Age);

int total2 = listInt2.Sum();
int totalSum= listStudent.Sum(x=>x.Age);

Student firstStudent = listStudent.First();
Student lastStudent = listStudent.Last();
Student middleStudent = listStudent[2];

//listStudent.Remove(std1);
//int totaRemove= listStudent.RemoveAll(x => x.Age < 19);

//Console.WriteLine(totaRemove);

List<Student> testList= new List<Student>();
Student firstStudentDefault = testList.FirstOrDefault(x => x.Name == "Student 3");
Student lastOrDefault = testList.LastOrDefault();

Student firstBy = listStudent.First(x => x.Name == "Student 3");
//Student singleStudent = listStudent.Single(x => x.Name == "Student 2");
Console.WriteLine(firstBy.Name);

////
List<Student> newListStudent = new List<Student>();
foreach(var item in listStudent)
{
    if (!newListStudent.Exists(x => x.Name == item.Name))
    {
        newListStudent.Add(item);
    }
}

Console.WriteLine(newListStudent.Count);
































