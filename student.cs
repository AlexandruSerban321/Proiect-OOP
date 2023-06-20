using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{
    internal class student
    {

        private int cod_student;
        private string nume_student;
        private string prenume_student;
        private string initiala;
        private int cnp;
        private string data_inscriere;
        private string ciclu_invatamant;
        private float medie_inscriere;
        private int numar_studenti;
        
        
        private student[] standard=new student[100];

        public student()
        {

        }

        private void initializare()
        {
            for(int i=0; i<=standard.Length-1; i++) 
            {
                standard[i] = new student();
            }
        }

        public int Cod_student { get => cod_student; set => cod_student = value; }
        public string Nume_student { get => nume_student; set => nume_student = value; }
        public string Prenume_student { get => prenume_student; set => prenume_student = value; }
        public string Initiala { get => initiala; set => initiala = value; }
        public int Cnp { get => cnp; set => cnp = value; }
        public string Data_inscriere { get => data_inscriere; set => data_inscriere = value; }
        public string Ciclu_invatamant { get => ciclu_invatamant; set => ciclu_invatamant = value; }
        public float Medie_inscriere { get => medie_inscriere; set => medie_inscriere = value; }
        public int Numar_studenti { get => numar_studenti; set => numar_studenti = value; }

        /*sunt get-ere din vectorul standard.
         standard este un vector de studenti care permite manipularea mai multor entitati cu aceleasi
        propietati(cele intre liniile 14 si 22).
        un obiect de tip student contine mai multe entitati de acelasi tip, care pot fi manipulate prin 
        metode.
        deocamdata, din exterior se pot returna propietatile unei entitati(dupa ce s-a apelat functia 
        "rememorare", definita mai jos)
        */
        public int get_cod_student(int k)
        {
            return standard[k].cod_student;

        }

        public string get_nume(int k)
        {
            return standard[k].nume_student;
        }

        public string get_prenume(int k)
        {
            return standard[k].prenume_student;
        }

        public string get_initiala(int k)
        {
            return standard[k].initiala;
        }

        public string get_data_inscriere(int k)
        {
            return standard[k].data_inscriere;
        }

        public string get_ciclu_invatamant(int k)
        {
            return standard[k].ciclu_invatamant;
        }

        public float get_medie_inscriere(int k)
        {
            return standard[k].medie_inscriere;
        }

        /*aduc in memorie datele din fisierul studenti,
         prin utilizarea unui vector de tip student*/
        public void rememorare()
        {
            initializare();

            StreamReader sr = new StreamReader("student.txt");

            int k = 0;
            string line;
            while((line=sr.ReadLine())!=null)
            {
                standard[k].cod_student =int.Parse(line);

                line = sr.ReadLine();
                standard[k].nume_student = line;

                line = sr.ReadLine();
                standard[k].prenume_student = line;

                line = sr.ReadLine();
                standard[k].initiala = line;

                line = sr.ReadLine();
                standard[k].cnp =int.Parse(line);

                line = sr.ReadLine();
                standard[k].data_inscriere = line;

                line = sr.ReadLine();
                standard[k].ciclu_invatamant=line;

                line = sr.ReadLine();
                standard[k].medie_inscriere = float.Parse(line);


                k++;

            }

            Numar_studenti = k;
            sr.Close();
        }



    }
}
