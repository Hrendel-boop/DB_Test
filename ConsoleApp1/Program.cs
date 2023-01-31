namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db= new ApplicationContext())
            {
                Console.WriteLine("Напишите имя, а затем возраст");
                User newUser = new User { Name = Console.ReadLine(), Age = int.Parse(Console.ReadLine())};
                

                db.Users.Add(newUser);
                   
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                var users= db.Users.ToList();
                Console.WriteLine("Список объeтов:");
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
                Console.ReadLine();
            }


        }
    }
}