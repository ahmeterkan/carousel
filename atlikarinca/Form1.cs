using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atlikarinca
{
    public partial class Form1 : Form
    {
        int k = 0;
        int R = 0;
        int N = 0;
        int sayac = 0;
        int[] turlar;
        CircularArrayTypedQueue cq;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (txtCalismaSayisiR.Text != "" && txtGrupSayisiN.Text != "" && txtKapasiteK.Text != "")
            {
                k = Convert.ToInt16(txtKapasiteK.Text);
                R = Convert.ToInt16(txtCalismaSayisiR.Text);
                N = Convert.ToInt16(txtGrupSayisiN.Text);
                cq = new CircularArrayTypedQueue(N);
                MessageBox.Show("Değerler Başarıyla Alındı.");
            }
            else
            {
                MessageBox.Show("Lütfen boş kısım olmadığından emin olun!!");
            }



        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtGrupKisiSayisi.Text) > k)
            {
                MessageBox.Show("Lütfen Atlı karıncanın kapasitesinden fazla kişi sayısı girmeyiniz");
            }
            else
            {

                if (txtGrupKisiSayisi.Text != "")
                {
                    if (N == 0)
                    {
                        MessageBox.Show("Lütfen önce grup sayısını giriniz.");
                    }
                    else
                    {
                        if (sayac < N)
                        {
                            cq.Insert(txtGrupKisiSayisi.Text);
                            MessageBox.Show("Ekleme Başarıyla Tamamlandı.");
                            txtGrupKisiSayisi.Text = "";
                            sayac++;
                        }
                        else
                        {
                            MessageBox.Show("Yeterli grup sayısına ulaşılmıştır. Sonucu görmek için lütefen Hesapla butonuna basınız");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen boş kısım olmadığından emin olun!!");
                }

            }
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int temp = 0, toplam = 0, peek = 0, kazanc = 0;
            turlar = new int[N];
            if (k == 0)
            {
                MessageBox.Show("Lütfen önce istenilen bilgileri giriniz.");
            }
            else
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        peek = Convert.ToInt16(cq.Peek());
                        if ((toplam + peek) <= k)
                        {
                            temp = Convert.ToInt16(cq.Remove());
                            toplam += temp;
                            cq.Insert(temp.ToString());
                        }
                        else
                        {
                            kazanc += toplam;
                            break;
                        }

                    }
                    turlar[i] = toplam;
                    toplam = 0;
                }
                for (int i = 0; i < R-N; i++)
                {
                    kazanc += turlar[i];
                }
                MessageBox.Show("Toplam Kazanç= " + kazanc.ToString() + " TL");
            }
        }

        private void txtCalismaSayisiR_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtGrupSayisiN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtKapasiteK_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtGrupKisiSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
