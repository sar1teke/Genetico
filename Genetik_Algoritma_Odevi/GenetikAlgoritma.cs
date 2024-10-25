using System;
using System.Collections.Generic;

namespace Genetik_Algoritma_Odevi
{
    public class GenetikAlgoritma
    {
        private Random rastgele;

        //Parametreler
        private int populasyonBuyuklugu;
        private double caprazlamaOrani;
        private double mutasyonOrani;
        private double elitizmOrani;
        private int jenerasyonSayisi;
        private int iterasyonSayisi;

        private int problemBoyutu;
        private List<Cozum> populasyon;

        public double[] EnIyiCozum { get; private set; }
        public double EnIyiSonuc { get; private set; }

        // Yakınsama grafiğinin tanımı
        public List<double> YakinsamaGrafik { get; private set; }

        public GenetikAlgoritma()
        {
            rastgele = new Random();
            YakinsamaGrafik = new List<double>();
        }

        public void Baslat(int populasyonBuyuklugu, double caprazlamaOrani, double mutasyonOrani, double elitizmOrani, int jenerasyonSayisi, int iterasyonSayisi)
        {
            this.populasyonBuyuklugu = populasyonBuyuklugu;
            this.caprazlamaOrani = caprazlamaOrani;
            this.mutasyonOrani = mutasyonOrani;
            this.elitizmOrani = elitizmOrani;
            this.jenerasyonSayisi = jenerasyonSayisi;
            this.iterasyonSayisi = iterasyonSayisi;

            for (int iterasyon = 0; iterasyon < iterasyonSayisi; iterasyon++)
            {
                // Problem boyutunu al, problem boyutu ile ilgili herhangi bir işlem yapmadım çünkü problem boyutu özgün bir değerdir.
                // Sadece gen ve fitness değerlerinin uzunluğunu belirlemek için kullanacağım.
                this.problemBoyutu = 10; // Örnek olarak 10 diyelim.

                populasyon = new List<Cozum>();

                for (int i = 0; i < populasyonBuyuklugu; i++)
                {
                    populasyon.Add(new Cozum(problemBoyutu));
                }

                // Jenerasyonları işleme kısmı
                for (int jenerasyon = 0; jenerasyon < jenerasyonSayisi; jenerasyon++)
                {
                    // Fitness hesaplama
                    foreach (Cozum cozum in populasyon)
                    {
                        cozum.HesaplaFitness();
                    }

                    // En iyi çözümü güncelle
                    EnIyiCozum = populasyon[0].Gen;
                    EnIyiSonuc = populasyon[0].Fitness;

                    foreach (Cozum cozum in populasyon)
                    {
                        if (cozum.Fitness < EnIyiSonuc)
                        {
                            EnIyiCozum = cozum.Gen;
                            EnIyiSonuc = cozum.Fitness;
                        }
                    }

                    // Yakınsama grafiği için en iyi fitness değerini ekleme kısmı
                    YakinsamaGrafik.Add(EnIyiSonuc);

                    List<Cozum> yeniPopulasyon = new List<Cozum>();

                    // Seçkinlik: En iyi bireyler doğrudan yeni nesile kopyalanır
                    int elitizmSayisi = Math.Min(populasyonBuyuklugu, (int)Math.Ceiling(populasyonBuyuklugu * elitizmOrani));

                    for (int i = 0; i < elitizmSayisi; i++)
                    {
                        Cozum enIyiCozum = populasyon[i];
                        yeniPopulasyon.Add(new Cozum(enIyiCozum));
                    }

                    // Çaprazlama ve mutasyon ile yeni bireyler üret
                    while (yeniPopulasyon.Count < populasyonBuyuklugu)
                    {
                        Cozum ebeveyn1 = RuletTekerlegiSecimi();
                        Cozum ebeveyn2 = RuletTekerlegiSecimi();
                        Cozum cocuk = Caprazlama(ebeveyn1, ebeveyn2);

                        if (rastgele.NextDouble() < mutasyonOrani)
                        {
                            Mutasyon(cocuk);
                        }

                        yeniPopulasyon.Add(cocuk);
                    }

                    // Yeni popülasyonu güncelleme
                    populasyon = new List<Cozum>(yeniPopulasyon);
                }
            }
        }

        private Cozum RuletTekerlegiSecimi()
        {
            double toplamFitness = 0;
            foreach (Cozum cozum in populasyon)
            {
                toplamFitness += cozum.Fitness;
            }

            double secilenFitness = rastgele.NextDouble() * toplamFitness;
            double toplam = 0;
            foreach (Cozum cozum in populasyon)
            {
                toplam += cozum.Fitness;
                if (toplam >= secilenFitness)
                {
                    return new Cozum(cozum);
                }
            }

            // Eğer herhangi bir birey seçilemezse son bireyi döndürücek
            return new Cozum(populasyon[populasyon.Count - 1]);
        }

        private Cozum Caprazlama(Cozum ebeveyn1, Cozum ebeveyn2)
        {
            Cozum cocuk = new Cozum(problemBoyutu);
            int caprazlamaNoktasi = rastgele.Next(problemBoyutu);

            for (int i = 0; i < problemBoyutu; i++)
            {
                if (i < caprazlamaNoktasi)
                {
                    cocuk.Gen[i] = ebeveyn1.Gen[i];
                }
                else
                {
                    cocuk.Gen[i] = ebeveyn2.Gen[i];
                }
            }

            return cocuk;
        }

        private void Mutasyon(Cozum cozum)
        {
            int mutationPoint = rastgele.Next(problemBoyutu);
            double randomValue = rastgele.NextDouble();

            // Mutasyonu gerçekleştiririyor
            cozum.Gen[mutationPoint] = randomValue;
        }
    }
}

public class Cozum
{
    public double[] Gen { get; set; } // Genotip (Çözüm)
    public double Fitness { get; private set; } // Fitness değeri

    public Cozum(int boyut)
    {
        Gen = new double[boyut];
        Random rastgele = new Random();
        for (int i = 0; i < boyut; i++)
        {
            Gen[i] = rastgele.NextDouble(); // -sonsuz +sonsuz arası
        }
    }

    // Mevcut çözümü kopyala
    public Cozum(Cozum diger)
    {
        Gen = new double[diger.Gen.Length];
        Array.Copy(diger.Gen, Gen, diger.Gen.Length);
        Fitness = diger.Fitness;
    }

    // Fitness değerini hesapla(Çözümü istenen Problem)
    public void HesaplaFitness()
    {
        double toplam = 0;
        foreach (double gen in Gen)
        {
            toplam += Math.Pow(gen, 2);
        }

        Fitness = toplam;
    }
}
