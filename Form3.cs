using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace isparta
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 frm1sec = new Form1();
            frm1sec.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                //bakla borani
                label10.Text = "BAKLA BORANİ";
                label2.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;
                pictureBox1.BringToFront();
                label3.BringToFront();
                label3.Text = "Isparta mutfağında et yemekleri kadar sebze yemekleri de önemli bir yer tutuyor. En çok yapılan sebze yemeklerinin başında da hem sağlıklı hem de lezzetli olmasıyla dikkat çeken Bakla Borani yer alıyor. Isparta sofralarında özellikle et yemeklerinin yanına mutlaka yapılan Bakla borani, sebze yemeği sevenlerin zevkle yediği bir yemektir. Hatta bakla sevmeyenleri bile lezzetiyle büyüler.\r\n\r\nBakla, soğan, bulgurun zeytinyağında pişirilmesi, daha sonra da yoğurtlanması ile hazırlanan yemek. Genellikle meze olarak kullanılıyor. Isparta sofralarında sıklıkla yerini alan Bakla borani, baklaya karşı ön yargılı olanların bile favori yemekleri arasına giriyor. Eğer Isparta’ya yolunuz düşerse bakla sevmiyorsanız bile bu lezzeti mutlaka deneyin.";
                label3.Visible = true;
                button1.BringToFront();
                label10.BringToFront();
                label1.BringToFront();

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                //sazan dolması
                label10.Text = "SAZAN DOLMASI";
                label2.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox3.BringToFront();
                label4.BringToFront();
                label4.Text = "Üç tarafı denizlerle çevrili olan ülkemiz balık çeşitliliği açısından oldukça zengindir ve her çeşit balığın ayrı bir yeri vardır. Etten sebzeye, bakliyattan meyveye kadar birçok üründen yapılan Isparta yöresel yemekleri arasında balık yemeği olmazsa olmazdır. Isparta’ya ait yöresel bir balık yemeği olan Sazan Dolması, farklı lezzetiyle deniz ürünleri sevenleri kendine hayran bırakıyor.\r\n\r\nYapımı titizlik ve maharet isteyen Sazan Dolması, farklı lezzeti ve sunumuyla dikkat çekiyor. Balığın içi iyice temizleniyor ve üzerine sos dökülüyor. Daha sonra bulgur, çam fıstığı ve kuş üzümünden hazırlanmış iç pilav balığın içine dolduruluyor. Balık iğne iplikle dikilerek tekrar üzerine sos dökülüyor ve fırına veriliyor iyice kızardıktan sonra servise hazır hale geliyor. Balık seviyorsanız Isparta restoranlarında sıklıkla rastlanan bu farklı yemeği mutlaka denemelisiniz.";
                label4.Visible = true;
                button1.BringToFront();
                label10.BringToFront();
                label1.BringToFront();

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                //cifne
                label10.Text = "CİFNE (ZIPLAK)";
                label2.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = true;
                pictureBox4.BringToFront();
                label5.BringToFront();
                label5.Text = "Yaz sebzelerini kışın kullanmanın en sağlıklı yolu kurutmaktır. Eskiden derin dondurucuların olmadığı zamanlar sebzeler ve meyveler kurutularak kış aylarında sağlıklı bir şekilde tüketilirdi. Günümüzde de nem yoğunluğunun olmadığı birçok yörede sebzeler yazın kurutularak saklanır. Isparta’da sebze kurutmak için oldukça elverişli iklime sahip olan bir şehirdir.\r\n\r\nIsparta mutfağına ait olan geleneksel bir yemek olan Cifne, kurutulmuş domates ve taze fasulyeden yapılan bir yemektir. Yapımı oldukça kolay olan yemek, içerisindeki kıyma ile de besleyici bir yemek olur. Kıyma, soğan ve salça kavrulduktan sonra haşlanmış domates ve fasulye kuruları eklenir ve özdeşleşene kadar pişirilir. Yufka ve kuru soğan ile tüketilir. Herkes tarafından çok bilinmeyen bu yemek deneyenlerin ise favori yemeklerinden biri olur.";
                label5.Visible = true;
                button1.BringToFront();
                label10.BringToFront();
                label1.BringToFront();

            }
            else if (comboBox1.SelectedIndex == 3)
            {
                //oğmaç çorbası
                label10.Text = "OĞMAÇ ÇORBASI";
                label2.Visible = false;
                pictureBox2.Visible = false;
                pictureBox5.Visible = true;
                pictureBox5.BringToFront();
                label6.BringToFront();
                label6.Text = "Isparta usulü Oğmaç çorbası çorba menülerinizi zenginleştirecek bir lezzet. Isparta’nın meşhur yemeklerinden biri olan Oğmaç Çorbası, yapanı az olsa da seveninin çok olduğu bir çorba. Oldukça pratik bir şekilde yapılan tadı da bir o kadar enfes olan çorba yemeğe güzel bir çorba ile başlamak ve keyifli bir akşam yemeği yemek için en güzel başlangıçlardan bir tanesi.\r\n\r\nHem lezzetli hem de doyurucu çorbanın içinde domates, soğan, tereyağı, salça ve çeşitli baharatlar bulunuyor. İçerisindeki şehriyeye benzeyen küçük küçük hamurlar da çorbanın görüntüsünü şenlendiriyor. Özellikle kış aylarında içinizi ısıtacak en güzel çorbalardan biri olan Oğmaç Çorbasını çorba menünüze mutlaka ekleyin.";
                label6.Visible = true;
                button1.BringToFront();
                label10.BringToFront();
                label1.BringToFront();

            }
            else if (comboBox1.SelectedIndex == 4)
            {
                //yalvaç güllacı
                label10.Text = "YALVAÇ GÜLLACI";
                label2.Visible = false;
                pictureBox2.Visible = false;
                pictureBox6.Visible = true;
                pictureBox6.BringToFront();
                label7.BringToFront();
                label7.Text = "Ramazan tatlısı olarak bilinen güllaç, Isparta’da çok farklı bir şekilde yapılıyor. Isparta’nın Yalvaç ilçesine özgü tatlıyı diğer güllaçlardan ayıran özellik sütten yapılmış lor peynirine benzer bir peynirin güllacın yapım aşamasında kullanılması. Diğer adı da kesmik güllacı olan tatlı Isparta’nın sembolü haline gelen gül şeklinde sarılarak yapılır.\r\n\r\nIsparta’nın şirin ilçesi Yalvaç’ın sembolü haline gelen tatlı, hem lezzetiyle hem de hafifliğiyle damakları şenlendiriyor. Tüm işlemler bittikten sonra da tatlıya Isparta’ ya yakışır bir şekilde gül suyu dökülür ve bu şekilde servis edilir. Özellikle ramazan sofralarının vazgeçilmez tatlısı olan Yalvaç güllacı Isparta’da ilk denemeniz gereken tatlıların başında gelmektedir.";
                label7.Visible = true;
                button1.BringToFront();
                label10.BringToFront();
                label1.BringToFront();

            }
            else if (comboBox1.SelectedIndex == 5)
            {
                //gül şerbeti
                label10.Text = "GÜL ŞERBETİ";
                label2.Visible = false;
                pictureBox2.Visible = false;
                pictureBox7.Visible = true;
                pictureBox7.BringToFront();
                label8.BringToFront();
                label8.Text = "Her köşesinden burnunuza gül kokusunun geldiği, güller şehri Isparta’da güllerin tatlılarda ve içeceklerde kullanımı oldukça yaygındır. Dünyanın gül ihtiyacının % 65’ini karşılayan Isparta’da güller yiyeceklerde, içeceklerde, kokularda ve daha birçok alanda kullanılmaktadır. Güller ile yapılan içeceklerin en lezzetlisi olan gül şerbeti özellikle rengi ile görenleri kendine hayran bırakıyor.\r\n\r\nSıcak yaz günlerinde soğuk soğuk içilen ve içinizi serinleten şerbetin yapımı biraz uzun sürse de hazır olunca beklemesine değiyor. Şerbet pembe gül yapraklarından hazırlanıyor. Aynı zamanda içerisine gelincik çiçeğinin renkli dip kısımları da ekleniyor. Ağzı kapalı kavanozlarda 1,5-2 ay bekletilen ve sonrasında içmeye hazır hale gelen şerbet, Isparta’da deneyebileceğiniz en özgün lezzetlerden biri.";
                label8.Visible = true;
                button1.BringToFront();
                label10.BringToFront();
                label1.BringToFront();

            }
            else
            {
                //gül çayı
                label10.Text = "GÜL ÇAYI";
                label2.Visible = false;
                pictureBox2.Visible = false;
                pictureBox8.Visible = true;
                pictureBox8.BringToFront();
                label9.BringToFront();
                label9.Text = "Isparta’nın meşhur güllü içeceklerden biri olan Gül Çayı, isminden de anlaşıldığı gibi gül yapraklarından hazırlanır. Isparta’da kış aylarında en çok tüketilen içeceklerden biri olan gül çayı akşam yemeklerinden sonra keyif yaparken size eşlik eder. Kurutulmuş gül yapraklarının kaynar suya atılmasıyla demlenen gül çayı, demlenirken kokusuyla herkesi büyülüyor.\r\n\r\nRengiyle ve tadıyla da bir defa içeni kendine bağımlı hale getiren gül çayı, Isparta’da aniden gelen misafirlere ikram edilerek sohbetlere de eşlik ediyor. Isparta’da paketler halinde her yerde bulabileceğiniz Gül çayını, Isparta’ya yolunuz düşerse paket paket alarak hem sevdiklerinize hediye edebilir hem de kendiniz tüketerek Isparta’nın kokusunu evinizde hissedebilirsiniz.";
                label9.Visible = true;
                button1.BringToFront();
                label10.BringToFront();
                label1.BringToFront();

            }
        }
    }
}
