using System;
namespace OverrideTest
{
    class Parent
    {
        protected void Say() => Console.WriteLine("Hello Parent");
        protected void Hi() => Console.WriteLine("Guten Tag");

        public virtual void Arbeits_Son() => Console.WriteLine("Arzt");
        public virtual void Arbeits_Tochter() => Console.WriteLine("Ärztin");



    }

    class Child : Parent
    {
/*
        //Warning CS0108	'Child.Say()' hides inherited member 'Parent.Say()'.
        //Use the new keyword if hiding was intended
        public void Say() => Console.WriteLine("Hello Child");

        //Warning CS0108	'Child.Hi()' hides inherited member 'Parent.Hi()'.
        //Use the new keyword if hiding was intended.
        public void Hi() => Console.WriteLine("Moin");
*/
        public new void Say() => Console.WriteLine("Hello Child");
        public new void Hi() => Console.WriteLine("Moin");
        /*
                public override void Arbeits()
                {
                    base.Arbeits();
                }

        */
        public override void Arbeits_Son() => Console.WriteLine("Der Sohn will Wissenschaftler werden");
        //public override void Arbeits_Tochter() => Console.WriteLine("Die Tochter will Rechtsanwalt werde"); 
        public override void Arbeits_Tochter() => base.Arbeits_Tochter();
    


    }
    class OverrideTest
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.Say();
            child.Hi();

            child.Arbeits_Son();
            child.Arbeits_Tochter();

        }
    }
}
