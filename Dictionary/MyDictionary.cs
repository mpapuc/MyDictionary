using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T1, T2>
    {
        T1[] sozlukEng;
        T1[] tempSozlukEng;
        T2[] sozlukTur;
        T2[] tempSozlukTur;

        public MyDictionary()
        {
            sozlukEng = new T1[0];
            sozlukTur = new T2[0];
        }

        public void Add(T1 Eng, T2 Tur)
        {
            tempSozlukEng = sozlukEng;
            tempSozlukTur = sozlukTur;

            sozlukEng = new T1[sozlukEng.Length + 1];
            sozlukTur = new T2[sozlukTur.Length + 1];
            for (int i = 0; i < tempSozlukEng.Length; i++)
            {
                sozlukEng[i] = tempSozlukEng[i];
                sozlukTur[i] = tempSozlukTur[i];
            }
            sozlukEng[sozlukEng.Length - 1] = Eng;
            sozlukTur[sozlukTur.Length - 1] = Tur;
        }

        public int Count
        {
            get { return sozlukEng.Length; }
        }

        public T1[] Eng
        {
            get { return sozlukEng; }
        }

        public T2[] Tur
        {
            get { return sozlukTur; }
        }
    }
}
