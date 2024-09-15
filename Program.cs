using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using lab2_1;

namespace lab2_1
{
    class ClassRoom
    {
        private Pupil[] pupils = new Pupil[4];
    public ClassRoom(params Pupil[] args) {
            for(int i=0; i<args.Length; i++) this.pupils[i] = args[i];
        }
        public void Info()
        {
            for(int i = 0; i<this.pupils.Length; i++)
            {
                pupils[i].Study();
                pupils[i].Read();
                pupils[i].Write();
                pupils[i].Relax();
            }
        }
    }

    class Pupil
    {
        public virtual void Study() { }
        public virtual void Read() { }
        public virtual void Write() { }
        public virtual void Relax() { }
    }

    class ExcelentPupil: Pupil { 
        public override void Study() { Console.WriteLine("Study ExelentPupil"); }
        public override void Read() { Console.WriteLine("Read ExelentPupil"); }
        public override void Write() { Console.WriteLine("Write ExelentPupil"); }
        public override void Relax() { Console.WriteLine("Relax ExelentPupil"); }
    }
    class GoodPupil : Pupil {
        public override void Study() { Console.WriteLine("Study GoodPupil"); }
        public override void Read() { Console.WriteLine("Read GoodPupil"); }
        public override void Write() { Console.WriteLine("Write GoodPupil"); }
        public override void Relax() { Console.WriteLine("Relax GoodPupil"); }
    }

    class BadPupil : Pupil
    {
        public override void Study() { Console.WriteLine("Study BadPupil"); }
        public override void Read() { Console.WriteLine("Read BadPupil"); }
        public override void Write() { Console.WriteLine("Write BadPupil"); }
        public override void Relax() { Console.WriteLine("Relax BadPupil"); }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            BadPupil p1 = new BadPupil();
            ExcelentPupil p2 = new ExcelentPupil();
            GoodPupil p3 = new GoodPupil();
            BadPupil p4 = new BadPupil();
            ClassRoom room = new ClassRoom(p1,p2,p3,p4);
            room.Info();
            Console.ReadLine();
        }
    }
}
