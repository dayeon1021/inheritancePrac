using inheritancePrac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrac
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals =
                new List<Animal>(){
                new Dog(), new Dog(), new Cat(),
                new Dog(), new Cat(), new Cat()
                };
            animals.Add(new Dog());
            animals.Add(new Cat());

            foreach (var item in animals)
            {
                item.Eat();
                item.Sleep();
                if( item is Dog)
                {
                    ((Dog)item).Bark();
                }
                if( item is Cat)
                {
                    ((Cat)item).Meow();
                }

                //as  :  is와 달리 형변환을 하지 않아도 됨
                var dog = item as Dog;
                if(dog != null) { dog.Bark(); }
                var cat = item as Cat;
                if (cat != null) { cat.Meow(); }
            }


            //List<Dog> dogs =
            //    new List<Dog>() { new Dog(), new Dog(), new Dog() };
            //List<Cat> cats = new List<Cat>();
            //cats.Add(new Cat());
            //cats.Add(new Cat());
            //cats.Add(new Cat());

            //foreach (var item in dogs)
            //{
            //    item.Eat();
            //    item.Sleep();
            //    item.Bark();
            //}

            //foreach (var item in cats)
            //{
            //    item.Eat();
            //    item.Sleep();
            //    item.Meow();
            //}
        }
    }
}