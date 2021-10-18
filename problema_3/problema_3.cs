using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace entrega_3_punto_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Observer> l_observer= new List<Observer>();
            Subject s_temp = new Subject(0, l_observer);
            Observer o_perro = new Observer("dog");
            Observer o_canario = new Observer("canario");

            Cat Hopkins = new Cat("hopkins", s_temp,false);
            Dog Alfred = new Dog("alfred", o_perro);
            Canario tweety = new Canario("tweety", o_canario);

            Alfred.Smell(Alfred, Hopkins);
            tweety.See(tweety, Hopkins);

            Hopkins.Speak(Hopkins, Alfred,tweety);
           
            Console.ReadKey();
        }
    }
    class Dog
    {

        public string name;
        public Observer observer_new;

        public Dog(string name, Observer observer_new)
        {
            this.name = name;
            this.observer_new = observer_new;
        }

        public void Smell (Dog d_temp,Cat c_temp)
        {
            c_temp.Register_observer(c_temp, d_temp.observer_new);

            Console.WriteLine(d_temp.name +" Just smelled "+ c_temp.Name);
        }
        public void Handle_cat_event(Dog d_temp, Cat c_temp)
        {
            Console.WriteLine(d_temp.name + " Just heard " + c_temp.Name);

        }
        public void Handle_cat_event(Canario d_temp, Cat c_temp)
        {
            Console.WriteLine(d_temp.name + " Just heard " + c_temp.Name);

        }
        public void notify(Dog d_temp,int numero,Cat c_temp )
        {
            
            Handle_cat_event(d_temp,c_temp);
        }
        

    }
    class Canario
    {

        public string name;
        public Observer observer_new;

        public Canario(string name, Observer observer_new)
        {
            this.name = name;
            this.observer_new = observer_new;
        }

        public void See(Canario d_temp, Cat c_temp)
        {
            c_temp.Register_observer(c_temp, observer_new);

            Console.WriteLine(this.name + " Just saw " + c_temp.Name);
        }
        public void Handle_cat_event(Canario d_temp, Cat c_temp)
        {
            Console.WriteLine(this.name + " Just heard " + c_temp.Name);

        }
        public void notify(Canario d_temp, int numero, Cat c_temp)
        {
            Handle_cat_event(d_temp, c_temp);
            
        }


    }
    class Cat
    {
        string name;
        Subject subject_new;
        bool speck_cat = false;

        public Cat(string name, Subject subject_new, bool speck_cat)
        {
            this.name = name;
            this.subject_new = subject_new;
            this.speck_cat = speck_cat;
        }

        public string Name { get => name; set => name = value; }
        internal Subject Subject_new { get => subject_new; set => subject_new = value; }
        public bool Speck_cat { get => speck_cat; set => speck_cat = value; }

        public int Register_observer(Cat c_temp,Observer o_temp)
        {
            return c_temp.Subject_new.Register_observer(c_temp, o_temp);


        }
        public int Unregister_observer(Cat c_temp, Observer o_temp)
        {
            return c_temp.Subject_new.Unregister_observer(c_temp.Subject_new, o_temp);
        }
        public void Speak(Cat c_temp,Dog d_temp, Canario p_temp)
        {
            Console.WriteLine("My name is ");
            Console.WriteLine(this.Name);
            Console.WriteLine("miaaaau");

            c_temp.Speck_cat = true;
            c_temp.subject_new.Notifyobservers(c_temp.subject_new, d_temp.observer_new,c_temp,d_temp);
            c_temp.subject_new.Notifyobservers(c_temp.subject_new, p_temp.observer_new, c_temp, p_temp);
        }
        

    }
    class Observer
    {

        string tipo;

        public Observer(string tipo)
        {
            this.tipo = tipo;
        }

        public void Notify( Dog d_temp, Cat c_temp)
        {
            d_temp.notify(d_temp, 0, c_temp);
        }
        public void Notify(Canario d_temp, Cat c_temp)
        {
            d_temp.notify(d_temp, 0, c_temp);
        }




    }
    class Subject
    {
        int type;
        List<Observer> observers;

        public Subject(int type, List<Observer> observers)
        {
            this.type = type;
            this.observers = observers;
        }

        public int Register_observer(Cat c_temp, Observer s_observer)
        {
                          
                    c_temp.Subject_new.observers.Add( s_observer);
                    return 0;               
                     
        }
        public int Unregister_observer(Subject s_temp, Observer s_observer)
        {

            for (int i = 0; i < 3; i++)
            {
                if (s_temp.observers[i] == s_observer)
                {
                    s_temp.observers.Remove(s_observer);

                    return 0;
                }
            }

            return 0;
        }
        public void Notifyobservers(Subject s_temp,Observer o_temp,Cat c_temp,Dog d_temp)
        {

            

                    o_temp.Notify(d_temp, c_temp);
                    
                

        }
        public void Notifyobservers(Subject s_temp, Observer o_temp, Cat c_temp, Canario d_temp)
        {

            

                    o_temp.Notify(d_temp, c_temp);

                

        }

    }

}
