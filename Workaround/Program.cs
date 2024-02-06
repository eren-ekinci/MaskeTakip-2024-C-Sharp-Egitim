




using Business.Concrete;
using Entities.Concrete;

string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";

Console.WriteLine(sehirler2[0]);


Console.WriteLine();


foreach (string sehir in sehirler1)
{
	Console.WriteLine(sehir);
}

Person person = new Person();
person.FirstName = "Eren";
person.LastName = "Ekinci";
person.NationalIdentity = 000000000;
person.DateOfBirthYear = 1998;

PttManager pttManager = new PttManager(new PersonManager());

pttManager.GiveMask(person);




//degiskenler();


static void degiskenler()
{
	string msg = "Merhaba!";
	double tutar = 100000;
	int sayi = 100;
	bool girisYapmismi = false;

	string ad = "Eren";
	string soyad = "Ekinci";
	int dogumYili = 1998;
	long tcNo = 12345678910;



	Console.WriteLine(tutar * 1.18);

	Console.WriteLine(tutar * 1.18);
}

