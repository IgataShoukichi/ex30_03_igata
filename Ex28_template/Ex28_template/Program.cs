using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("222e020", DateTime.Today, "igata", 50, 164, 20, 60); 
            Console.WriteLine($"名前{student.Name}：ID{student.ID}：重さ{student.weight}kg");
            Worker worker = new Worker("クリエイター", DateTime.Today, "桜井", 50, 172, 20, 56); 
            Console.WriteLine($"名前{worker.Name}：職業{worker.Occupation}：重さ{worker.weight}kg");
            Fish fish = new Fish("うまい", DateTime.Today, "サーモン", 70, 15, 2, 9); 
            Console.WriteLine($"名前{fish.Name}：味{fish.Taste}：重さ{fish.weight}kg");
            Refrigerator refrigerator = new Refrigerator(25, "sharp", 685, 1833, 699, 70);
            Console.WriteLine($"値段{refrigerator.Price}万：名前{refrigerator.Name}：重さ{refrigerator.Weight}kg");
            Insect insect = new Insect("春", DateTime.Today, "テントウムシ", 1, 1, 1, 1);
            Console.WriteLine($"名前{insect.Name}:季節{insect.Season}");
            Cat cat = new Cat("ノルウェージャンフォレストキャット", DateTime.Today, "ポンタ", 50, 25, 10, 10);
            Console.WriteLine($"名前{cat.Name}：猫種{cat.catBreed}：重さ{cat.weight}kg");
            Car car = new Car(490, "ブガッティシロンスーパースポーツ300+", 4544, 2038, 1212, 1995);
            Console.WriteLine($"速さ{car.Speed}km/h：名前{car.Name}：重さ{car.Weight}kg");
        }
    }
}
