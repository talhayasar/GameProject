using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Fake ve real check services açıcaz.Fake olan direkt true dönüyor.Diğeri ise
/// bir doğrulama işlemi yapacakmışcasına metodu override edebilir.
/// BU overrideyi sağlamak için abstract bir class tanımlayalım.
/// override etmeden ortak interfaceden metodu alıp gövdesini değişmeyi düşünüyorum.
/// ikiside olur ama program.cs ye gelince interfaceden obje yapamayız ama abstract
/// classımız olursa onu implemente edenleri newleyebiliriz.
/// Ortak interfaceden deiğim gibi iki class açıp metodları yazdım ama mainde kullanırken
/// bu ikisinden hangisini kullanacaksak onu newlwyip .IfCheckRealGamer dememiz gerek.
/// Şuan da ayrı ayrı newleniyor.Mecburen yine bi abstract class açıp bunları ona inheritance
/// ederek oetrak bi basede tutalım.Mainde abstract classtan newleyip metodu çapırırız.
/// 
/// Diğer projede abstractan starbucks yada nero uretip içine check service verirken burada
/// check servisi üretip içine gameri veriyorum çümkü sadece gamer var
/// hem gamer hem başka insan olsaydı ozaman değişebilirdik
/// </summary>
namespace GameProject.CheckGamer
{
    class FakeCheckGamerService : BaseCheckGamerService
    {
        public override bool CheckIfRealGamer(Gamer gamer)
        {
            return false;
        }
    }
}
