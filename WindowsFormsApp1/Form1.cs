using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        dernek yenidernek = null;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void vakifkayit_Click(object sender, EventArgs e)
        {
            string Vakifadi = vakifadi.Text;
            int Vakifuye = Int32.Parse(vakifuyesayisi.Text);

            yenidernek = new dernek(Vakifadi, Vakifuye);
            MessageBox.Show("Vakıf Oluşturuldu.", "VAKIF OLUŞTURULDU.", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            vakifadi.Enabled= false;
            vakifuyesayisi.Enabled = false;
            vakifkayit.Enabled = false;


        }

        private void uyekayıt_Click(object sender, EventArgs e)
        {
            string uyeadi = uyead.Text;
            string uyenum= uyeno.Text;
            string uyedog = uyedogum.Text;
            string uyeyasi = uyeyas.Text;
            string uyetelno = uyetel.Text;
            string bilgi = "Üye Adı:"+uyeadi + 
                " ,Üye No:" + uyenum + 
                " ,Doğum yılı :" + uyedog +
                " ,Üye Yaşı:" + uyeyasi +
                " ,Üye Tel:" + uyetelno;
            System.IO.File.WriteAllText(@"D:\Okul\Çalışma C#\PROJE\WindowsFormsApp1\uyebilgileri.txt", bilgi);
            MessageBox.Show("Kayıt oluşturuldu 'uyebilgileri.txt' dosyasından bilgilere erişebilirsiniz."
                ,"BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            uyesec.Items.Add(uyeadi);
            uyeaidatisim.Items.Add(uyeadi);


        }
        
        private void uyesec_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void uyegoster_Click(object sender, EventArgs e)
        {
            string uyeadi = uyead.Text;
            string uyenum = uyeno.Text;
            string uyedog = uyedogum.Text;
            string uyeyasi = uyeyas.Text;
            string uyetelno = uyetel.Text;
            MessageBox.Show(
                "Üye Adı :" + uyeadi + "\n" +
                "Üye No:" + uyenum + "\n" +
                "Doğum yılı :" + uyedog + "\n" +
                "Üye yaşı: " + uyeyasi + "\n" +
                "Üye tel : " + uyetelno,"ÜYE BİLGİLERİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void uyeaidatno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aidatodeme_Click(object sender, EventArgs e)
        {
            int aidatode = Int32.Parse(uyeaidatodememik.Text);
            string uyeadi3 = uyeaidatisim.Text;
            yenidernek.aidatodeme(aidatode);
            string aidatbilgi = uyeadi3 + "adlı üye" + aidatode + " TL ödedi.";
            System.IO.File.WriteAllText(@"D:\Okul\Çalışma C#\PROJE\WindowsFormsApp1\uyeaidatodeme.txt",aidatbilgi);
            MessageBox.Show("Ödeme işlemi tamamlandı."+ "\n"+ " 'uyeaidatodeme.txt' " +
                "dosyasından ödeme bilgilerine erişebilirsiniz.",
                "AİDAT ÖDEME",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void giderekle_Click(object sender, EventArgs e)
        {
            string gideracik  =vakifgider.Text;
            int gidermik = Int32.Parse(vakifgidertl.Text);
            yenidernek.dernekgider(gidermik);
            string giderbilgi = "Gider Sebebi :  " + gideracik + "Gider Miktarı:  " + gidermik;
            System.IO.File.WriteAllText(@"D:\Okul\Çalışma C#\PROJE\WindowsFormsApp1\vakifgider.txt", giderbilgi);
            MessageBox.Show("Gider işlemi tamamlandı." + "\n" + 
                " 'vakifgider.txt' dosyasından gider bilgilerine erişebilirsiniz.",
                "GİDER BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void hesapsorgula_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hesap Cüzdanı: Kasada " + yenidernek.hesapsorgu() +  
                " TL bulunmaktadır.","HESAP CÜZDANI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
