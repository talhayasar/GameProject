using GameProject.CheckGamer;
using System;
/* 
2.     Oyun satışı yapılabilecek satış ortamını simule ediniz.( Yapılan satışlar oyuncu ile ilişkilendirilmelidir. Oyuncunun parametre olarak metotta olmasını kastediyorum.)

3.     Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.

4.     Satışlarda kampanya entegrasyonunu simule ediniz.*/
namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer() { FirstName = "Talha", LastName = "Yasar", GameId = 1 };
            SystemFeaturesManager systemFeaturesManager = new SystemFeaturesManager(new RealCheckGamerService());
            systemFeaturesManager.Register(gamer1);
            /*BaseCheckGamerService baseCheckGamerService = new FakeCheckGamerService();
            baseCheckGamerService.CheckIfRealGamer(gamer1);
            BaseCheckGamerService baseCheckGamerService1 = new RealCheckGamerService();
            baseCheckGamerService1.CheckIfRealGamer(gamer1);
            bu kullanım kodu değişmeden önceydi. Burada checkservicemizi kendimiz seçip ona gamer objesini
            gönderiyorduk.Verilen gamer objesine göre bu servis çalışıyordu.
            
             Ama son halinde featuresmanager'e constructor olarak basechechmanager classını verdik
            yani parametre olarak bizden hangi servisi istediğimizi newlerken istiyor.*/
        }
    }
}
