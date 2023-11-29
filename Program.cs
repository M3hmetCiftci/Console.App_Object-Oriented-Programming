using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming_Encapsulation
//{
    //public class ogrenci
    //{
    //    private int _id;
    //    public string Name;
    //    public static int Devamsizlik = 20;

    //    public void SetId(int id)
    //    {
    //        if (id<=0)
    //        {
    //            Console.WriteLine("Id değeri sıfırdan küçük olamaz");
    //        }
    //        else
    //        {
    //            _id = id;
    //        }
    //    }
    //    public int GetId()
    //    {
    //        return _id;
    //    }
    //}
    // class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        ogrenci o = new ogrenci();
    //        o.SetId(-4);
    //        Console.WriteLine("Id ={0}"+o.GetId());
    //        Console.ReadKey();
    //    }
    //<---------------------------------------------------------------------------------------------------------->
    //public class ogrenci
    //{
    //    private int _id;
    //    public string _Name;
    //    public static int _devamsizlik = 20;

    //    public void SetId(int id)
    //    {
    //        if (id <= 0)
    //        {
    //            Console.WriteLine("Id değeri sıfırdan küçük olamaz");
    //        }
    //        else
    //        {
    //            _id = id;
    //        }
    //    }
    //    public int GetId()
    //    {
    //        return _id;
    //    }

    //    public void SetName(string Name)
    //    {
    //        if (string.IsNullOrEmpty(Name))
    //        {
    //            Console.Write("İsim kısmı boş bıraklımaz");
    //        }
    //        else { _Name = Name; }
    //    }

    //    public string GetName()
    //    {
    //        return _Name;
    //    }

    //   public int GetDevamsizlik()
    //    {
    //        return ogrenci._devamsizlik;
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        ogrenci o = new ogrenci();
    //        o.SetId(5);
    //        o.SetName("Mehmet");
    //        Console.WriteLine("Id = " + o.GetId());
    //        Console.WriteLine("İsim Kısmı = " + o.GetName());
    //        Console.WriteLine("Öğrenci Devamsızlık Durumu = "+ogrenci._devamsizlik);
    //        Console.ReadKey();
    //    }

    //<---------------------------------------------------------------------------------------------------------->
    //public class ogrenci
    //{
    //    private int _id;
    //    public string _Name;
    //    public static int _devamsizlik = 20;

    //    public int Id
    //    {
    //        set
    //        {
    //            if (value<=0) 
    //            {
    //                Console.WriteLine("Id 0 veya daha küçük olamaz");
    //            }
    //            else
    //            {
    //             this._id = value;
    //            }
    //        }
    //        get
    //        {
    //        return _id;
    //        }
    //    }

    //    public string Name
    //    {
    //        set
    //        {
    //            if (string.IsNullOrEmpty(Name))
    //            {
    //                throw new Exception("isim boş bırakılamaz");
    //            }
    //            _Name = value;
    //        }
    //        get
    //        {
    //            if (string.IsNullOrEmpty(_Name))
    //            {
    //                return "isim girilmemiştir";
    //            }
    //            else
    //            {
    //                return _Name;
    //            }
    //        }
    //    }


    //    public int Devamsizlik
    //    {
    //        get
    //        {
    //return ogrenci._devamsizlik;
    //        }
    //    }
    //}
    //class Program
    //{
    //static void Main(string[] args)
    //    {
    //ogrenci ogrenci = new ogrenci();
    //ogrenci.Id = 3;
    //ogrenci.Name = "Mehmet";
    //Console.WriteLine($"Sıra Numarası = {ogrenci.Id} Adı = {ogrenci.Name}");
    //    }
    //<-----------------------------------------------Inthretance (Yapıcı Methodlar)----------------------------------------------------------->
    //public class customer
    //    {
    //   public string Name;
    //   public string LastName;
    //   public string City;

    //    public void TamAdiYazdir()
    //    {
    //        Console.WriteLine(Name + "" + LastName);
    //    }
    //    public class LocalCustomer:customer
    //    {
    //      public int aylikodeme;
    //        public void yazdirodeme()
    //        {
    //            Console.WriteLine("Aylık Ödeme = "+aylikodeme);
    //        }
    //    }
    //    public class ForeignCustomer:customer
    //    {
    //       public int yillikodeme;
    //       public string ulke;
    //        public void yazdiryabanciodeme()
    //        {
    //            Console.WriteLine($"Ülke{ulke} Yıllık Ödeme = {yillikodeme}");
    //        }
    //    }
    //        static void Main(string[] args)
    //        {
    //        LocalCustomer lcs=new LocalCustomer();
    //        lcs.Name = "Mehmet";
    //        lcs.LastName = "ali";
    //        lcs.aylikodeme = 100;
    //        lcs.TamAdiYazdir();
    //        lcs.yazdirodeme();


    //        Console.WriteLine("******************************************************************");

    //        ForeignCustomer fcs = new ForeignCustomer();
    //        fcs.Name = "Kelvin";
    //        fcs.LastName = "Arnold";
    //        fcs.TamAdiYazdir();
    //        fcs.yillikodeme = 10000;
    //        fcs.ulke = "United Kingdom";   
    //        fcs.yazdiryabanciodeme();
    //    }
    //public class customer
    //{
    //public class BaseClass
    //{
    //   public BaseClass() 
    //    {
    //        Console.WriteLine("Base Class çağırıldı");           
    //    }
    //    public BaseClass(string Message) 
    //    {
    //    Console.WriteLine(Message);
    //    }
    //}
    //public class DerivedClass:BaseClass
    //{
    //    public DerivedClass()
    //    {
    //        Console.WriteLine("Derived class çağğırıldı");
    //    }
    //}

    //static void Main(string[] args)
    //    {
    //    DerivedClass drv= new DerivedClass();
    //    BaseClass bsc=new BaseClass("Mesage class");
    //    }
    //<---------------------------------------------------------------------------------------------------------->

    //public class intertance
    //{
    //    public class A
    //    {
    //        public A()
    //        {
    //            Console.WriteLine("A sınıfı");
    //        }
    //    }
    //    public class B:A
    //    {
    //        public B()
    //        {
    //            Console.WriteLine("B Sınıfı");
    //        }
    //    }
    //    public class C:B
    //    {
    //        public C()
    //        {
    //            Console.WriteLine("C sınıfı");
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //       C c = new C();

    //  }


    //<-----------------------------------------------Name Hiddng(Method Gizleme)----------------------------------------------------------->
    //public class intertance
    //{
    //   public class BaseClass
    //    {
    //        public void Islem()
    //        {
    //            Console.WriteLine("Base Class Çağırıldı");
    //        }
    //    }
    //    public class DerivedClass : BaseClass
    //    {
    //      new public void Islem()
    //        {
    //            base.Islem();
    //            Console.WriteLine("Devide çağırıldı");
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //     DerivedClass drv = new DerivedClass();
    //        drv.Islem();
    //    }

    //<-----------------------------------------------Polimorphism----------------------------------------------------------->
    //public class intertance
    //{
    //    public class TemelSinif
    //    {
    //        virtual public void yazdir()
    //        {
    //            Console.WriteLine("Temel sınıf");
    //        }
    //    }
    //    public class TureyenSinif1:TemelSinif
    //    {
    //       override public void yazdir()
    //        {
    //            Console.WriteLine("Türeyen sınıf1");
    //        }
    //    }
    //    public class TureyenSinif2:TemelSinif
    //    {
    //        override public void yazdir()
    //        {
    //            Console.WriteLine("Türeyen sınıf2");
    //        }
    //    }
    //    public class TureyenSinif3:TureyenSinif2
    //    {
    //        override public void yazdir()
    //        {
    //            Console.WriteLine("Türeyen sınıf3");
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        TemelSinif tml1=new TureyenSinif1();
    //        tml1.yazdir();

    //        TemelSinif tml2 = new TureyenSinif2();
    //        tml2.yazdir();

    //        TemelSinif tml3 = new TureyenSinif3();
    //        tml3.yazdir();
    //    }
    //<-----------------------------------------------Polimorphism----------------------------------------------------------->

  //      public interface IMusteri
  //      {
  //      void EkranaYaz();
  //      }
  //  public interface IA
  //  {
  //      void Islem();
  //  }
  //      public class BireyselMusteri:IMusteri
  //      {
  //      public void EkranaYaz() 
  //      {
  //          Console.WriteLine("Ben bireysel müşteriyim");
  //      }
  //      }
  //      public class KurumsalMusteri:IMusteri
  //      {
  //      public void EkranaYaz()
  //      {
  //          Console.WriteLine("Benkurumsal müşteriyim");
  //      }
  //      }
  //class Program
  //  {
        
  //          static private void Goster(IMusteri musteri)
  //          {
  //              musteri.EkranaYaz();
              
  //          }
        
  //      static void Main(string[] args)
  //      {
  //          //       BireyselMusteri bireyselMusteri = new BireyselMusteri();
  //          //     bireyselMusteri.EkranaYaz();       
  //          //   KurumsalMusteri kurumsalMusteri = new KurumsalMusteri();
  //          // kurumsalMusteri.EkranaYaz();
  //          //<////////////////////////////////////////////////////////////////////////////////////////>
  //          //  IMusteri musteri = new BireyselMusteri();
  //          // musteri.EkranaYaz();
  //          // IMusteri musteri1= new KurumsalMusteri();
  //          // musteri1.EkranaYaz();
  //          //<////////////////////////////////////////////////////////////////////////////////////////>
  //          //  KurumsalMusteri kurumsalMusteri=new KurumsalMusteri();
  //          //    BireyselMusteri bireyselMusteri=new BireyselMusteri();
  //          //  Program.Goster(kurumsalMusteri);
  //          //  Program.Goster(bireyselMusteri);
  //          //<////////////////////////////////////////////////////////////////////////////////////////>
  //          //Program.Goster(new  BireyselMusteri());
  //          //Program.Goster(new  KurumsalMusteri());

  //      }
//    }

//}