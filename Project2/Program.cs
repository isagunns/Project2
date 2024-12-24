using Poject2;
using Project2;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Balık bilgileri içeren metin
        string data = @"
Akya Balığı (Liça Balığı)
Maksimum 200 cm uzunluk ve 50 kg ağırlık. Genelde Ege'de 120 cm civarı.
Ege Denizi
Carangida familyasının bir üyesi olan akya balığı, boyutları ve zevkli avcılığı ile olta balıkçılarının avlanırken en çok heyecanlandığı deniz balıklarından biridir. Akya olarak bilinen bu tür, aynı zamanda liça balığı olarak da adlandırılır. Üreme dönemleri olan Mayıs ve Ağustos arasında yumurtlamak için gittikleri nehir birleşimlerinde kefaller ve sardalyaları yiyerek güç toplarlar. Ana besinleri kefal yavrularıdır. Nehir ağızlarına yakın alanlarda daha küçük boyuttakiler bulunurken büyük boyutlu akyalar, 40-50 metre derinlikte ve kıyıya uzak olmayan alanlarda yaşar.
---
Yaygın Aslan Balığı (Şeytan Ateş Balığı)
Yetişkin boyutları 35 cm’ye kadar ulaşabilir.
Ege Denizi, Hint-Pasifik, Kızıldeniz, Endonezya
Hint-Pasifik bölgesine özgü bir aslan balığı varyantı olan bu tür, bilimsel olarak Pterois miles olarak adlandırılmıştır. Benzerlikleri dolayısıyla kırmızı aslan balığı ile karıştırılırlar. Hint-Pasifik bölgesinin yanı sıra ülkemiz sularından Ege Denizi’nde de yaşadıkları biliniyor. Genel aslan balığı çeşitleri gibi bu tür de zehirli bir türdür. Sırtında toplamda 13 adet diken bulunur. Renkleri kırmızı, gri veya ten rengi tonlarındadır. Geceleri avlandıklarından gündüzleri pek aktif bir tür değillerdir. Küçük kabuklular ve balıklar ile beslenirler. Ege balıkları arasında olsalar da yaygın olarak Kızıldeniz’de ve Endonezya sularında görülürler.
---
Barbunya (Barbun)
Maksimum 40 cm. Ege Denizi'ndekiler genellikle 18-20 cm.
Ege Denizi
Gerçek adı Barbunya balığı olsa da halk arasında Barbun adı ile bilinir. Mullidae familyasından olan bu türe Mullus barbatus bilimsel adı verilmiştir. Ege Denizi gibi sıcak ve ılıman suların kıyıya yakın kumlu ve çamurlu bölgelerinde yaşarlar. Nadiren de olsa kayalık alanlarda görülmektedirler. Tekir balığına benzerlikleri ile bilinirler. Aradaki farkı anlamak için burun, göz altı ve sırt yüzgecine bakılmalıdır. Ege balıkları arasında ticari öneme sahip, eti lezzetli balıklardandır.
---
Cipura (Çupra)
200 gr ve üzeri olanlar Çipura; bunun altındakiler Lidaki.
Ege Denizi, Akdeniz
Çipura balığı diğer adıyla Çupra, Ege denizi balık türleri arasında yer alsa da aslında Akdeniz bölgesinde de yaşarlar. Ilıman sulara sahip bölgelerin, kumlu ve çamurlu bölgelerinde yaşarlar. Zaman zaman nehir ağızları ve lagünlerde bulundukları da olur. Kuvvetli bir çeneye sahiptir ve bu sayede kabukluları kolayca yiyebilir. Avlanmak isteniyorsa yaz aylarında kıyıya yakın, kış aylarında 30-40 metre derinlikte avlanabilirler. Kışın boyut olarak daha iri Çipuralar daha derin noktalara inerler. Ticari değeri yüksek ve eti oldukça lezzetli Ege Denizi balıklarındandır.
---
Citari (Sarpa)
Maksimum 51 cm, genellikle 15-30 cm.
Ege Denizi
Görüntü olarak Çipura balığına çok benzerdir. Halk arasında Sarpa balığı olarak bilinirler. Yüzeyden 70 metre derinliğe kadar uzanan yaşam alanları vardır. Maviye çalan gri renkli üst kısımları, gümüş renkli yan kısımları vardır. Ege denizi balık türleri arasında ticari değeri yoktur. Yapılan araştırmalarda tam olarak tespit edilemese de balığın tükettiği bir alg neticesinde, Sarpa yiyen insanlarda halüsinojenik balık sarhoşluğu denilen rahatsızlığa sebep olur.
---
Cizgili Hani Balığı (Yazılı Hani)
Maksimum 25 cm.
Ege Denizi, Akdeniz, Karadeniz
Hani balığı, Orfoz’un da içinde bulunduğu Serranidae familyasından ve Levreğin içinde bulunduğu Serraninae alt türünden bir balıktır. Bilimsel adı Serranus scriba’dır. Çizgili hani balığı Ege denizi balıkları arasında yer almaktadır ancak hani balıkları genel olarak Akdeniz ve Karadeniz’de yaygındır. Ülkemiz denizlerinden Ege Denizi’ne özgü Çizgili hani, 5 ila 150 metre arasında yaşam alanına sahiptir. Gündüzleri kayalıkların oluşturduğu mağaralarda geçirirken, alacakaranlık ve geceleri avlanmak için ortaya çıkar. Genellikle yalnız yaşadıkları görülse de küçük sürüler halinde yüzdüklerine de rastlanmaktadır. Kabuklular, kafadanbacaklılar ve küçük balıklar ile beslenir. Ticari değeri olmayan, eti lezzetli Ege balıklarından biridir.
---
Dikenli Vatoz
Genellikle 40-45 cm veya daha küçük.
Ege Denizi, Akdeniz, Karadeniz
Dikenli vatoz, Dasyatidae familyasından bir vatoz balığı türüdür. Akdeniz ve Karadeniz bölgelerimizde de görülen bu tür, daha fazla görülmesi sebebiyle Ege Denizi balık türleri arasında bulunmalıdır. Çok derin sularda değil, genellikle 60 metre civarı derinlikte ve çamurlu alanlarda yaşarlar. Ana besinleri dipte yaşayan kabuklu türleridir. Ek olarak yumuşakçalar, solucanlar ve küçük balıklarla da beslenir. Ege denizinde bulunan dikenli vatozlar, genellikle 40-45 cm civarında veya daha küçük boyuttadır. Tırtırlı kuyruk ve iğneleri yüzünden insanlar için tehlikeli balık türleri arasındadır. Ticari değeri yoktur.
---
Eşkina
Genellikle 30-40 cm, maksimum 60 cm.
Ege Denizi, Akdeniz
Eşkina balığı, Sciaenidae familyasından bir deniz balığı türüdür. Bilimsel adı Sciaena umbra olan bu tür, Akdeniz ve Ege Denizi bölgelerimizde bulunmaktadır. Eşkina balığı amatör avcılık yapanların sıklıkla karşılaştığı bir türdür. Yavru eşkinalar kıyı şeritlere yakın nehir ağızlarında yaşarken, yetişkinler 5 metre ile 200 metre arasında yaşarlar. Ege balıkları listemize dahil ettiğimiz eşkina, en fazla 60 cm boyuta ulaşabilir ancak, ülkemiz sularında genellikle 30-40 cm civarında görülürler. Bu balığı sıradışı kılan bir özelliği de vardır. Balığın kafasından, alın bölgesinden 1 cm çapında taş çıkar. Bilimsel olarak kanıtlanmamış olsa da bu taş limon ile eritilerek tüketildiğinde böbrek taşı rahatsızlığına iyi geldiği düşünülür.
---
Horozbina Balığı
Genellikle küçük, maksimum 55 cm.
Ege Denizi, Akdeniz
Horozbina, Blenniidae familyasından 900 civarı alt türe sahip, hem tuzlu hem de tatlı sularda (küçük bir bölümü) yaşayan alt varyantlara sahip balık türlerinin ortak adıdır. Horozbina tür adı altında 150 farklı cins ve 900 civarı da varyant tanımlanmıştır. Tatlı su blennysi olarak bilinen bir türü, nadiren de olsa akvaryumlarda beslenmektedir. Genellikle küçük boyutlara sahip olabilen bu balığın, yılan balığına benzer varyantlarıyla 55 cm boyutuna ulaştığı görülmüştür. İri bir göz ve ağız yapısına sahiptir. Zamanlarının büyük kısmını deniz tabanında ve kayalık yarıklarında geçirirler. Ticari değeri olmayan, Akdeniz ve Ege Denizi balıklarından biridir.
---
Iskaroz (Papağan Balığı)
Genellikle 20-30 cm, maksimum 50 cm.
Ege Denizi, Akdeniz
Genellikle ılıman ve sıcak sulara sahip denizlerde yaşarlar. Bilimsel adı Sparisoma cretense olan tür Scaridae familyasındandır. Parlak renklere sahip bir balıktır. Görünüşü itibariyle sazan balığının tropik halini andırır. Papağan isminin verilmesi ağızlarının papağan gagasına benzemesindendir. Erkekler daha koyu tondaki renklere sahipken dişiler, kırmızı-turuncu tonlarındadır. Zamanlarının çoğu mercan resiflerinde geçer. Burada deniz yosunu ile beslenirler. Yetişkin dönemlerinde en fazla 50 cm olabilirler ancak, ülkemizdeki iskaroz balıkları 20-30 cm civarındadır. Ticari değeri bulunmayan iskarozun eti orta lezzettedir.
---
Iskorpit
Genellikle 20-25 cm, maksimum 37 cm.
Ege Denizi, Akdeniz, Karadeniz
İskorpit, Ege balıkları arasında zehirli türlerden biridir. Yüzgeçlerinde bulunan dikenlere dokunulduğunda kişiyi zehirler ve bölgede kızarıklık, şişlik görülür. Bu etki 2-3 gün devam eder. Amonyak kullanılarak tedavi edilebilir. Özellikle amatör balıkçılar tarafından kırlangıç balığı ile karıştırılıp yaralanmalara sebep olmaktadır. Tutulduğunda dikenlerine dokunmamaya dikkat edilmelidir. Kayıt edilmiş maksimum uzunluk 37 cm iken, ülkemiz sularında yetişkin olanları 20-25 cm civarında görülürler. Akdeniz, Karadeniz ve Ege denizi balık türlerinden biridir. İskorpit, zehirli balıklardan biri olsa da eti lezzetli olan ve barındırdığı vitamin ve yağlar ile insan sağlığına çok yararlı bir balıktır.
---
Isparoz (İspari Balığı)
Genellikle 15-18 cm, maksimum 25 cm.
Ege Denizi, Akdeniz, Karadeniz
Sparidae familyasından olan isparinin bilimsel adı Diplodus annularis’dir. Bu balık genellikle ılıman sahil bölgelerine yakın alanlarda yaşar. Ege balıklarından biridir ve diğer denizlerimizde de bulunur. Maksimum 25 cm uzunluğa erişebilirler. Ülkemiz sularında 15-18 cm civarında ispariler bulunur. Sportif balıkçılıkta sevilen bir balık türüdür. Genç olanları kışın lagünlere giderek beslenirler. Karides, yavru balıklar ve kurtçuklar ana besinleridir.Ticari değeri düşüktür ve genellikle olta balıkçılığı ile avlanırlar. Eti lezzetli ve az kılçıklı bir balıktır.
---
Izmarit Balığı (Istrongilos)
Genellikle 15 cm, maksimum 25 cm (erkekler).
Ege Denizi, Akdeniz
İzmarit balığı, Ege denizi balık türleri arasında yer alıyor ancak Akdeniz bölgelemizde daha yaygın bulunur. Bilimsel adı Spicara smaris olan izmarit, Sparidae familyasından bir deniz balığı türüdür. Ilık sulara sahip bölgelerin kayalık, çamurlu dip kısımlarında yaşamaktadır. En fazla 25 cm boyutuna (erkekler) ulaşan bu tür, ülkemizde genellikle 15 cm civarında görülür. Ülkemiz sularında iki tür izmarit yaşamaktadır; İstargilos ve Menekşe izmarit. Eti lezzetli bir balıktır ve genellikle önce pişirilip sonra ayıklanır.
---
Kalkan Balığı (Scophthalmus maximus)
Yetişkinler 60-70 cm, maksimum 1 metre.
Ege Denizi, Akdeniz, Karadeniz
Kalkan balığı (Scophthalmus maximus), gözleri vücudunun solunda olan, Scophthalmidae familyasından bir deniz balığı türüdür. Vücudunun sağını deniz tabanına yatmak için kullanır. Ülkemizin tüm denizlerinde yaşayan bir türdür. Yaşam alanları 20 metre ile 70 metre arasındadır. Tipik balık türlerinden farklı olarak yuvarlak bir vücuda sahiptir. Maksimum 1 metre uzunluğa erişebilirler. Ülkemiz denizlerinde ise yetişkinler 60-70 cm civarında görülür. Henüz yavruyken gözleri sağda ve solda ayrı durmaktadır. 8-10 cm civarına ulaştıklarında sağ göz vücutlarının sol tarafına kaymaya başlar. Ticari değeri yüksek, eti çok lezzetli ege balıkları arasındadır.
---
Karagöz Balığı
Yetişkinler 25 cm civarında, maksimum 50 cm.
Ege Denizi, Akdeniz, Karadeniz
Karagöz balığının Çipura ile yakın akrabalığı bulunmaktadır. Sarmos, mırmır, sivri gaga gibi birkaç çeşidi vardır. Maksimum 50 cm boyutuna ulaşabilir. Ülkemizde Akdeniz, Karadeniz ve Ege Denizi bölgelerimizde yaşarlar. Bu bölgelerde yaygın olarak 25 cm civarında görülür. Kayalık, kumlu alanlarda yaşarlar. Görünüşü ile Çupra balığına benzemesinin yanı sıra lezzet olarak da benzerdir. Serin dönemlerde tüketimesi tavsiye edilir bu dönemlerde eti daha yağlı ve lezzetli olmaktadır.
---
Kolyoz Balığı
Yetişkinler ortalama 20-25 cm, maksimum 50 cm.
Ege Denizi, Akdeniz, Karadeniz
Uskumsugillerden olan kolyoz, Scombridae familyasından bir deniz balığıdır. Uskumruya çok benzeyen bir balıktır. Kuyruk yüzgecine bakılarak ayırt edilebilir. Bu türün kuyruk yüzgecinin ucu daha sivridir. Genç olanlar kıyılara yakın kumlu alanlar ve yosun yataklarında yaşarken, yetişkin olanlar daha açıkta derin sularda yaşar. Sürüler halinde yaşamlarını sürdürürler. En fazla 50 cm uzunluğa kadar büyüyebilir ancak ülkemiz sularında görülen yetişkinler ortalama 20-25 cm civarındadır. Eti lezzetli ege balıkları arasındadır.
---
Kırma Mercan Balığı (Pagellus erythrinus)
En fazla 50 cm, genel olarak 15-30 cm.
Ege Denizi, Akdeniz
Kırma mercan balığı (Pagellus erythrinus) çipura ailesinden, Sparidae familyası mensubu, Akdeniz ve Ege balıklarından biridir. Özellikle Akdeniz ülkelerinde bolca tüketilen lezzetli bir balık türüdür. İnce, oval yapıda bir vücuda sahip olan kırma mercan en fazla 50 cm boyutuna ulaşabilir. Genel olarak 15-30 cm arasında görülürler. Bu tür bir hermafrodittir; sonradan cinsiyet değiştirebilirler. Genellikle hayatlarının ilk yıllarında dişi, sonraki yıllarında ise erkek olurlar. Hepçil bir balıktır ve ana besinleri küçük balıklar ve omurgasızlardan oluşur. Akdeniz ülkelerinde ticari değere sahip, lezzetli bir balıktır.
---
Lahoz Balığı (Grida balığı)
En fazla 125 cm, 25 kg ağırlık.
Ege Denizi, Akdeniz
Lahoz balığı Hani balıkları ailesinden, Ege ve Akdeniz bölgelerinde bulunan bir türdür. Bu tür iri Ege balıkları arasındadır. En fazla 125 cm uzunluk ve 25 kg ağırlığa ulaşabilirler. Yaşam alanları 20-250 metre arasında kayalık, çakıllı ve taşlı alanlardır. Son derece yırtıcı etçil balıklardan biridir. Yiyebileceği her türlü balık, omurgasız ve kabuklu türleri ile beslenir. Orfoz balığı ile yakından akrabadır ve ticari değeri bulunduğu bölgeye göre değişir. Özellikle Akdeniz bölgesinde etinin lezzetli ile bilinir. Bu tür birkaç farklı isimle bilinir.
---
Levrek Balığı
En fazla 1 m, 12 kg; yaygın olarak 50 cm, 5 kg.
Ege Denizi, Akdeniz
Birçoğumuzun da yakından tanıdığı Levrek balığı, Dicentrarchus familyasından bir balık türüdür. Bilimsel olarak ilk kez 1758 yılında Dicentrarchus labrax olarak tanımlanmıştır. Şimdiye kadar kayıt altına alınan en büyük boyutları 1 m ve 12 kg olsa da yaygın olarak 50 cm ve 5 kg civarında görülürler. Akdeniz ve Ege başta olmak üzere tüm denizlerimizde yaşadıkları biliniyor. Haliçler, lagünler, akarsuların denize döküldüğü yerler ana yaşam alanlarıdır. Kısa bir süreliğine tatlı sulara geçtikleri de bilinmektedir (tatlı su levreklerinin dışında). Ticari değeri yüksek, etinin lezzetini kanıtlamış Ege denizi balık türlerinden biridir.
---
Lipsoz Balığı  
En fazla 50 cm, genellikle 25-30 cm.  
Ege Denizi, Akdeniz  
Lipsoz balığı, görünümü ile iskorpit balığına benzeyen Scorpaenidae familyasından bir balık türüdür. Lipsos ismiyle de bilinen bu tür, ülkemiz sularında Akdeniz ve Ege Denizi'nde bulunur. Karadeniz bölgesinde bulunmaz. İskorpit balığı gibi, bu balık da zehirli balıklardan biridir. Vücut rengi kiremit rengi tonlarından, pembemsi tonlara kadar değişebilir. En fazla 50 cm ve 3 kg ağırlığa ulaşabilirler; ancak, sularımızdaki yetişkin lipsoz balıkları genellikle 25-30 cm civarındadır. Yenilebilir balıklardan biridir, en çok çorba ve buğulama yapıldığında lezzetlidir.  
---
Lüfer  
Maksimum 120 cm, bölgemizde genellikle 30-60 cm.  
Ege Denizi, Akdeniz, Karadeniz  
Lüfer, Pomatomidae familyasından bir balık türüdür. Ege balıkları arasında ekonomik değeri yüksek ve çok lezzetli bir balıktır. Bilimsel adı Pomatomus saltatrix olan lüfer, ülkemizin tüm denizlerinde bulunmaktadır. Maksimum ölçülen boyutları 120 cm ve 14 kg’dır. Bölgemizde yaşayan yetişkin lüferler 30-60 cm arasında bulunurlar. Lüfer, gevşek ve küçük gruplar halinde yaşayan yırtıcı deniz balıklarından biridir. Lüfer çeşitli boyutlara göre farklı isimler almıştır: Sarıkanat: 18 – 25 cm boyutlarında olan lüfer yavrusudur. 18 cm altının avlanması veya satılması yasaktır. Lüfer: 28 – 35 cm boyutlarına ulaştığında lüfer adı verilir. Avlamak ve satış serbesttir. Kofana: 35 cm üzerine çıkan lüferlere bu ad verilmiştir. Avlanması ve satılması serbesttir. Sırtıkara: 50 cm’nin üzerindeki lüferlere verilmiş isimdir. Ülkemiz denizlerinde uzun süredir görülmemiştir. Avlamak ve satışını yapmak serbesttir. Lüfer bir dönem koruma altına alınarak avlanılması ve satışı yapılması yasaklanmış balık türlerindendir. Ancak, günümüzde yasak bitirilerek 18 cm ve üzeri olanların avlanması ve satılması serbest bırakılmıştır.  
--- 
Mahmuzlu Camgöz Köpek Balığı  
En fazla 150 cm, genellikle 80 cm ve 4 kg civarı.  
Akdeniz, Ege Denizi  
Mahmuzlu camgöz Squalidae familyasından, Akdeniz ve Ege Denizi başta olmak üzere ülkemiz sularında bulunmaktadır. Ülkemizde tüketilmese de Avrupa ülkelerinde tüketildiği bilinmektedir. Ana besinleri balık sürüleri ve ahtapotlar olan bu türün, profesyonel balıkçıların ağlarına ciddi hasar verdiği biliniyor. Nadiren de olsa dip balıklarını avlayan amatör balıkçıların oltasına takıldığı görülmektedir. En fazla 150 cm ve 10 kg boyutlarına eriştikleri tespit edilmiştir ancak, genellikle 80 cm ve 4 kg civarlarına ulaşırlar. Ticari değeri yoktur.  
---
Mandagöz Mercan Balığı  
En fazla 70 cm, yaygın olarak 30 cm ve 4 kg.  
Akdeniz, Ege Denizi  
Kırmızı (kızıl) çipura olarak da bilinen mandagöz mercan (Pagellus bogaraveo) Sparidae familyasından bir deniz balığıdır. Akdeniz başta olmak üzere ılıman ve sıcak denizleri tercih eden bir türdür, ılıman ısısıyla Ege balıklarından da biridir. Bulunduğu bölgeye göre en fazla 400 ila 700 metre derine inebilen bir balıktır. Kaydedilen en büyük uzunluk 70 cm, yaygın olarak da 30 cm ve 4 kg’dır. Eti lezzetli, ızgarada pişilmesi tercih edilen bir mercan varyantıdır.  
---
Melanur Balığı (Melanurya)  
En fazla 38 cm, yaygın olarak 20 cm.  
Akdeniz, Marmara, Ege Denizi  
Melanur diğer adıyla Melanurya, Sparidae familyasından bir deniz türüdür. Ülkemizde Akdeniz, Marmara ve Ege bölgerinde bulunur. Bilimsel adı Oblada melanura olan melanur, Ege denizi balık türleri arasında yer alıyor. Çok iri boyutlara ulaşabilen bir tür değildir. Kaydedilen maksimum boyutları, 38 cm ve 930 gr’dır. Ülkemiz sularında yaygın olarak 20 cm civarında görülürler. Hepçil olan türün ana besini omurgasızlardır. Eti lezzetli türlerden biri olan melanurun ticari değeri orta seviyelerdedir.  
---
Mersin Balığı  
Yetişkinler ortalama 140-300 cm, 100-200 kg; en büyük 7.2 m ve 1571 kg.  
Akdeniz, Ege Denizi  
Mersin balığı birçok farklı türün ortak adıdır. Mersin balığı adı altında 19 farklı cins balık bulunmaktadır. Görünümlerindeki ufak farklılar ile ayrılırlar. Bu balıklar Acipenseridae familyasına aittir. Akdeniz bölgemizde daha yaygın olan tür, Ege balıkları arasında da bulunmaktadır. Türe göre boyutları farketmektedir. Yetişkin mersin balıkları ortalama 140 ila 300 cm uzunluğa, 100 ila 200 kg ağırlığa ulaşabilirler. Şimdiye kadarki ölçülen en büyük boyutlar; 7.2 metre ve 1571 kilogramdır. Mersin balığı altında bulunan 19 farklı tür şu şekildedir: Sibirya mersini, Kısa burunlu mersin balığı, Yangtze mersin balığı, Göl mersin balığı, Rus mersin balığı, Yeşil mersin balığı, Sakhalin mersin balığı, Japon mersin balığı, Adriyatik mersin balığı, Şip balığı, Körfez mersinbalığı, Atlantik mersin balığı, İran mersin balığı, Çuka balığı, Amur mersin balığı, Çin mersin balığı, Yıldızlı mersin balığı, Kolan balığı, Beyaz mersin balığı.  
---
Mürekkepbalığı  
Cinse göre 20 cm - 17 m; yaygın olarak 50-60 cm.  
Ege Denizi, Akdeniz  
Mürekkepbalığı Cephalopoda (Kafadanbacaklılar) sınıfından, deniz türleri arasında olan bir yumuşakça türüdür. İkisi diğerlerinden daha uzun olan toplam 10 adet kolları vardır ve iç bölgelerinde çok sayıda vantuz bulunur. Ege denizi balıkları arasında yer alan mürekkepbalığı, sıcak sularda yaşayan bir türdür. Bu türün boyutları çok değişkendir. Cinse göre 20 cm ile 17 metre arasında değişen çeşitleri vardır. Yaygın olarak yetişkin olanları 50-60 cm arasındadır. Ticari değeri olan, eti lezzetli bir yumuşakça türüdür.  
---
Mırmır Balığı  
En fazla 55 cm, yaygın olarak 30 cm.  
Ege Denizi, Akdeniz, Marmara  
Sparidae familyasından olan mırmır balığı, ekonomik değeri yüksek lezzetli balık türlerinden biridir. Denizin diplerinde ve kumlu kısımlarda yaşayan mırmır balığı sıklıkla avlanan Ege balıkları arasındadır. Ülkemizde Ege, Akdeniz ve Marmara bölgelerinde bolca bulunurlar. Ana besinlerini kabuklular, solucanlar ve yumuşakçalar oluşturur. En fazla 55 cm ve 1 kg ağırlığa ulaşmaktadırlar ancak, yaygın boyutları 30 cm civarındadır. Ticari değeri yüksek Ege denizi balık türlerinden biridir.  
---
Orfoz Balığı  
En fazla 140 cm, yaygın olarak 60 cm.  
Akdeniz, Ege Denizi  
Serranidae familyasından Orfoz, Taş hanisi adıyla da bilinir. Bilimsel adı Epinephelus marginatus’dur. Orfozlar hermafrodit (çift cinsiyetli) deniz balıkları arasındadır. Orfoz balığı neslinin tükenmesiyle karşı karşıya olduğu için avlanması yasak türlerdendir. Ülkemizde Akdeniz ve Ege denizlerinin güney kısımlarında yaşarlar. En fazla 140 cm ve 60 kg boyutlarına ulaşabilirler. Boyutları ile iri ege balıklarından biridir. Ülkemiz denizlerinde yaygın görülen boyutları ortalama 60 cm ve 15 kg’dır.  
---
Orkinos (Ton balığı)
6 metre uzunluğa ve 1 ton ağırlığa ulaşmaktadır
Ege Denizi, Akdeniz  
Çoğumuzun marketlerde konserve içerinde gördüğü Orkinos, Uskumrugiller (Scombridae) ailesinin üyesidir. Kendi aralarında farklı türlere sahip olan, Orkinos ortak adı verilen bu balık denizlerdeki en iri balıklardan biridir. Ege denizi balıkları arasında en büyük türlerden biridir. Yetişkin bir ton balığı, 6 metre uzunluğa ve 1 ton ağırlığa ulaşmaktadır. Ancak, bu boyutlarda Orkinos bulma ihtimali çok düşüktür genellikle 3-4 metre ve 400-600 kg arasında avlanırlar. Ekonomik değeri çok yüksek ve son deree lezzetli balıklardandır.  
---
Pisi Balığı  
En fazla 60 cm boyut ölçülmüştür ancak, yaygın boyutları 30 cm civarındadır.
Ege Denizi, Akdeniz, Karadeniz, Marmara  
Pisi balığı kalkan ile karıştırılabilir ancak resimlerine bakıldığında kolayca ayırt edilebilir. Pleuronectidae familyasından olan pisi balığının vücudu kalkana göre daha elips şeklindedir ve kalkanın sırtında olan düğme diye tabir edilen kemikli yapılar yoktur. Yine pisi balığının gözleri de vücudun sağ tarafındadır. En fazla 60 cm boyut ölçülmüştür ancak, yaygın boyutları 30 cm civarındadır. Ülkemizde Akdeniz, Ege, Karadeniz ve Marmara bölgelerimizde bulunur.  
---
Sardalya Balığı  
Denizlerimizde 15-20 cm boyutlara ulaşırlar ancak okyanus bölgelerindeki sardalyalar 30 cm uzunluğa kadar büyümektedir.
Akdeniz, Karadeniz, Ege Denizi  
Sardalya, hamsi ile yakından akraba olup, Clupeinae familyasından bir balık türüdür. Sürüler halinde kıyıya yakın geçerek göç ederler ve yaşamlarını sürdürürler. Akdeniz ve Karadeniz’de daha yaygın görülürken, Ege Denizi balık türleri arasında da yer almaktadır. Denizlerimizde 15-20 cm boyutlarına ulaşırlar, ancak okyanus bölgelerindeki sardalyalar 30 cm'ye kadar büyüyebilirler. Ticari değeri yüksek ve lezzetli bir balık türüdür.  
---
Sargan Balığı (Zargana)  
Yaşadıkları bölgeye göre 1 metre uzunluğa erişmektedirler ancak Akdeniz ve Ege denizlerimizde 60 cm civarına kadar büyümektedirler.
Akdeniz, Ege Denizi  
Tipik balık görünümünün dışında uzun ve ince bir vücuda sahip olan sargan (Belone belone), Belonidae familyasının üyesidir. Vücut yapıları sayesinde hızlı ve çevik deniz balıklarındandır. Yaşadıkları bölgeye göre 1 metre uzunluğa erişebilirler, ancak Akdeniz ve Ege Denizi'nde 60 cm civarına kadar büyüyebilirler. Ana besinleri küçük balıklardır ve hamsi, çaça gibi balık türleri ile beslenirler. Ticari değeri yüksek, lezzetli Akdeniz ve Ege balıkları arasındadır.  
---
Sargoz  
Bilinmiyor
Akdeniz, Ege Denizi  
Sargoz, Akdeniz ve Ege bölgelerinde sıklıkla Karagöz ile karıştırılır. Diplodus sargus bilimsel adı verilen bu balık, Sparidae ailesinden bir deniz balığı türüdür. Bölgeye göre farklı isimler alır ve Baltabaş, Sargos, Ak Karagöz olarak da bilinir. Ülkemizde Akdeniz ve Ege bölgelerinde yaygındır. Güçlü çeneye sahip olan sargozun ana besinleri; kabuklular, yumuşakçalar ve deniz yosunlarıdır. Ekonomik değeri yüksek, lezzetli bir balıktır.  
---
Sinarit  
1 metre uzunluğa, 20 kg ağırlığa ulaşırlar
Akdeniz, Karadeniz, Marmara, Ege Denizi  
Sparidae familyasından olan sinarit, bilimsel adıyla Dentex dentex olarak bilinir. Akdeniz’de yaygın olmakla birlikte, Karadeniz, Marmara ve Ege balıkları arasında da yer alır. Taşlı ve kumlu bölgelerde 200 metre derinliğe kadar yaşarlar. Ana besinleri kafadanbacaklılar ve yumuşakçalardır. Genellikle yalnız yaşayan bu balıklar, üreme dönemlerinde küçük sürüler halinde görülmektedirler. 1 metre uzunluğa ve 20 kg ağırlığa ulaşabilirler. Olta avcılığı son derece zevkli, eti lezzetli ancak az bulunan bir balıktır.  
---
Tekir  
Kaydedilmiş en büyük boyutları 40 cm ve 1 kg’dır ancak sularımızda yaygın olarak 25 cm civarında görülürler. 
Akdeniz, Karadeniz, Ege Denizi  
Bilimsel adı Mullus surmuletus olan tekir, Mullidae familyasından bir deniz balığıdır. Akdeniz, Karadeniz ve Ege Denizi balık türleri arasındadır. 5 metrelik sığ sulardan 400 metre derinlikteki sulara kadar geniş bir yaşam alanına sahiptir. Kaydedilmiş en büyük boyutları 40 cm ve 1 kg olmakla birlikte, sularımızda yaygın olarak 25 cm civarında görülürler. Ticari değeri olan bir balık olup, av balığı olarak da kullanılmaktadır.  
---
Trakonya Balığı (Dragon Balığı)  
En fazla 55 cm boyuta ulaşabilirler ve genellikle 25 cm civarında görülürler. 
Ege Denizi  
Trakonya balığı, halk arasında dragon balığı olarak da bilinmektedir. Trachinidae ailesinden olan balığın bilimsel adı Trachinus draco’dur. Vücudunda zehirli dikenlere sahiptir ve dokunulduğunda toksik bir madde salgılar. Zehirli Ege balıkları arasındadır ve zehri kuvvetlidir, uzuv kaybı veya kalp krizine neden olabilmektedir. 1 metre ile 150 metre arasında kumlu, çakıllı alanlarda yaşar. Küçük balıklar, omurgasızlar ve kabuklular ana besinleridir. En fazla 55 cm boyuta ulaşabilirler ancak genellikle 25 cm civarında görülürler. Ticari değeri yoktur.  
---
Trança  
Yetişkin boyutları 60-75 cm civarındadır ancak 1 metre üzerine de çıkabilmektedir.
Ege Denizi  
Ege balıkları arasında meşhurlaşmış türlerden biri olan trança, bölgedeki diğer isimleriyle Çavuş, Antenli mercan ve Altınkaş olarak da bilinir. Bilimsel adı Pagrus caeruleostictus’dur ve mercan familyasından bir türdür. Sığ ve sıcak sularda tek olarak yaşayan iri bir balıktır. Etçil olup, kafadanbacaklılar ve küçük balıklar ana besinleridir. Okyanuslara ve farklı denizlere sürekli göç eden balıklardandır. Yetişkin boyutları 60-75 cm civarındadır, ancak 1 metreye kadar da büyüyebilirler. Ekonomik değeri yüksek, lezzetli bir balıktır.  
---
Zurna Balığı  
En fazla 50 cm, ortamala 35 cm boyutlarındadır.
Akdeniz, Ege Denizi  
Scomberesocidae familyasından bir deniz balığı olan zurna balığı, açık denizlerde yaşar. Süveyş Kanalı'nın açılmasından sonra Akdeniz ve Ege Denizi'nde görülmeye başlanmıştır. En fazla 50 cm boyutlarına ulaşabilir, ancak ortalama boyutları 35 cm civarındadır. Balık yavruları ve plankton ile beslenir. Avlanmadıkları için herhangi bir ticari değeri yoktur.  
";
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Black;

        string[] fishData = data.Split(new[] { "---" }, StringSplitOptions.RemoveEmptyEntries);
        int capacity=fishData.Length;

        List<List<EgeDeniziB>> fishList2 = new List<List<EgeDeniziB>>();//List<Generic list>
        StackClass<EgeDeniziB> fishStack = new StackClass<EgeDeniziB>(capacity);//StackClass
        QueueClass<EgeDeniziB> fishQueue = new QueueClass<EgeDeniziB>(capacity);
        PriorityQueueClass fishPq = new PriorityQueueClass();

        int i = 0;
        while (i < fishData.Length)
        {
            List<EgeDeniziB> fishList = new List<EgeDeniziB>();

            for (int x = 0; x < 10 && i < fishData.Length; x++)
            {
                string[] lines = fishData[i].Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                if (lines.Length > 3)
                {
                    string otherName = null;
                    string name;
                    if (lines[1].Contains("("))//Parantez içeriyorsa otherName VARDIR.
                    {
                        int startIndex = lines[1].IndexOf("(") + 1;
                        int length = lines[1].IndexOf(")") - startIndex;
                        otherName = lines[1].Substring(startIndex, length).Trim();
                        name = lines[1].Substring(0, startIndex-1).Trim();
                    }
                    else
                    {
                        name = lines[1].Trim();
                    }
                    EgeDeniziB balık = new EgeDeniziB
                    {
                        name = name,
                        otherName = otherName,
                        size = lines[2].Trim(), 
                        EnvironmentList = new List<string>(lines[3].Split(',').Select(env => env.Trim())), 
                        information = string.Join(" ", lines.Skip(4)) 
                    };
                    fishList.Add(balık);
                    fishStack.Push(balık);
                    fishQueue.Enqueue(balık);
                    fishPq.Enqueue(balık);
                }
                i++; 
            }

            fishList2.Add(fishList);
        }
        //Printing List
        int indexer = 0;
        foreach (List<EgeDeniziB> list2 in fishList2)
        {
            int otherNameCount = list2.Count(fish => !string.IsNullOrEmpty(fish.otherName));
            Console.WriteLine($"Group Index:{indexer} \nOther Name Count:{otherNameCount} fish have other names.\n");
            indexer++;
            foreach(EgeDeniziB list1 in list2)
            {
                Console.WriteLine(list1);
            }
            Console.WriteLine("\n\n\n");
        }
        //Printing Stack
        while (!fishStack.IsEmpty())
        {
            EgeDeniziB stackItem = fishStack.Pop();
            Console.WriteLine(stackItem);
            Console.WriteLine("----------------------------");

            
        }
        Console.WriteLine("\n\n\n");
        //Printing Queue
        while (!fishQueue.IsEmpty())
        {
            EgeDeniziB queueItem = fishQueue.Dequeue();
            Console.WriteLine(queueItem);
            Console.WriteLine("********************************");
        }
        Console.WriteLine("\n\n\n");
        //Printing Priority Queue
        while (!fishPq.IsEmpty())
        {
            EgeDeniziB pqItem = fishPq.Dequeue();
            Console.WriteLine(pqItem);
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
        }
        
        //Customer random
        Queue<int> customerQueue = new Queue<int>();
        customerQueue.Enqueue(15);
        customerQueue.Enqueue(1);
        customerQueue.Enqueue(12);
        customerQueue.Enqueue(8);
        customerQueue.Enqueue(7);
        customerQueue.Enqueue(4);
        customerQueue.Enqueue(21);
        customerQueue.Enqueue(3);
        customerQueue.Enqueue(2);
        customerQueue.Enqueue(6);
        customerQueue.Enqueue(5);
        customerQueue.Enqueue(9);
        customerQueue.Enqueue(11);

        double totalTime = 0;
        int customerNumber = 1;
        double averageTime = 0;
        while (customerQueue.Count() > 0)
        {
            totalTime += customerQueue.Dequeue() * (3.3);
            Console.WriteLine($"Customer Number:{customerNumber} Total Processing Time:{totalTime}");
            averageTime = (totalTime) / customerNumber;
            Console.WriteLine($"Average Processing Time:{averageTime}\n");
            customerNumber++;
        }
        Console.WriteLine("/////////////////////////////////////");

        //Customer Priority Queue
        PriorityQueueClass2 customerPq = new PriorityQueueClass2();
        customerPq.Enqueue(15);
        customerPq.Enqueue(1);
        customerPq.Enqueue(12);
        customerPq.Enqueue(8);
        customerPq.Enqueue(7);
        customerPq.Enqueue(4);
        customerPq.Enqueue(21);
        customerPq.Enqueue(3);
        customerPq.Enqueue(2);
        customerPq.Enqueue(6);
        customerPq.Enqueue(5);
        customerPq.Enqueue(9);
        customerPq.Enqueue(11);

        double waitingTime = 0;
        int numberOfCustomer = 1;
        double averageTimeOfCustomer = 0;
        while (customerPq.Count() > 0)
        {
            waitingTime += customerPq.Dequeue() * (3.3);
            Console.WriteLine($"Customer Number:{numberOfCustomer} Total Processing Time:{waitingTime}");
            averageTimeOfCustomer = (waitingTime) / numberOfCustomer;
            Console.WriteLine($"Average Processing Time:{averageTimeOfCustomer}\n");
            numberOfCustomer++;
        }
        Console.ReadKey();
    }
}

