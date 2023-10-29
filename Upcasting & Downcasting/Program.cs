//Upcasting
using Upcasting___Downcasting;

Person person = new Teacher();
person.Name = "Test";
//person.Salary; Doesn't work

//Downcasting
Teacher teacher = (Teacher)person;// or Teacher teacher = person as Teahcer;
Person[] people = { new Teacher(), new Student() };
