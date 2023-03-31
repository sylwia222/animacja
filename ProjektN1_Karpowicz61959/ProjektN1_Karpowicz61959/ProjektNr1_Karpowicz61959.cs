using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjektN1_Karpowicz61959.LaboratoriumNr1_Karpowicz61959;

namespace ProjektN1_Karpowicz61959
{
    public partial class ProjektNr1_Karpowicz61959 : Form
    {
        const int SKMargines = 10;
        const int SKPromieńOA = 5; //OA: Obiekt Animowany

        const double SKDGprzedziałuX = double.MinValue;
        const double SKGGprzedziałuX = double.MaxValue;
        // deklaracje zmiennych dla przechowania pobranych wartości danych we.......
        //float h; // przyrost zmian wartości zmiennej niezależnej X w przedziale
        int SKLiczbaPrzedziałówH;
        Graphics SKRysownica;
        Pen SKPióroXY = new Pen(Color.Blue, 0.5F);
        Pen SKPióroLiniiToru;
        double[,] TWS;
        int SKIndexPOA; // POA: Położenie Obiektu Animowanego
        int SKMaxIndexPOA;
        double SKXd, SKXg, SKh;
        static ProjektNr1_Karpowicz61959 SKUchwytFormularza;
        public ProjektNr1_Karpowicz61959()
        {
            InitializeComponent();
            SKUchwytFormularza = this;
            // utworzenie egzemplarza PióraLiniiToru
            SKPióroLiniiToru = new Pen(Color.Black, 1.5F);
            // ustawienie linii kropkowej
            SKPióroLiniiToru.DashStyle = DashStyle.Dot;
            // wstępne sformatowanie kontrolki PictureBox
            SKpbRysownica.BackColor = Color.LightSeaGreen;
            SKpbRysownica.BorderStyle = BorderStyle.Fixed3D;
            // utworzenie BitMapy i podpięcie jej do PictureBox
            SKpbRysownica.Image = new Bitmap(SKpbRysownica.Width, SKpbRysownica.Height);
            // utworzenie egzemplarza powierzchni graficznej na BitMapie
            SKRysownica = Graphics.FromImage(SKpbRysownica.Image);
        }

       
        private void label2_Click(object sender, EventArgs e)
        {

        }// bledny klik

        private void label3_Click(object sender, EventArgs e)
        {

        }// bledny klik

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SKIndexPOA >= SKMaxIndexPOA)
                // "przedstawienie" OA na początku linii toru
                SKIndexPOA = 0;
            else
                SKIndexPOA++;
        }

        private void ProjektNr1_Karpowicz61959_FormClosing(object sender, FormClosingEventArgs e)
        {
            // utworzenie okna dialogowego dla spytania Użytkownika
            DialogResult OknoMessage = MessageBox.Show("Czy chcesz zamknąć bieżący formularz i przejść do formularza głównego? (Utracisz niezapisane dane w bieżącym formularzu)", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // sprawdzenie odpowiedzi Użytkownika programu
            if (OknoMessage == DialogResult.Yes)
            {// odszukanie formularza głównego w kolekcji OpenForms
                foreach (Form Formularz in Application.OpenForms)
                    // czy to jest formularz główny
                    if (Formularz.Name == "Kokpit_Projektu")
                    {// ukrycie bieżącego formularza
                        this.Hide();
                        // odsłonięcie znalezionego egzemplarza formularza głównego
                        Formularz.Show();
                        // zakończenie obsługi zdarzenia FormClosing
                        return;
                    }
                // jeżeli znajdziemy się tutaj, to znaczy, że "ktoś" usunął egzemplarz formularza głównego z kolekcji OpenForms
                MessageBox.Show("AWARIA: 'ktoś' usunął egzemplarz formularza głównego i program nie może działać dalej!!!", this.Text);
                // zamknięcie wszystkich formularzy i wątków (procesów równoległych)
                Application.ExitThread();
            }
            else
                //skasowanie zdarzenia FormClosing
                e.Cancel = true;
        }

        private void SKpbRysownica_Paint(object sender, PaintEventArgs e)
        {
            // dodatkowe zabezpieczenie gdy TWS jest puste
            if (TWS is null)
                return;
            // "wymazanie" obrazu animacji
            SKRysownica.Clear(Color.LightSeaGreen);
            // wykreślenie osi Y
            SKRysownica.DrawLine(SKPióroXY,
                PrzeliczanieWspółrzędnych.WspX(0),
                PrzeliczanieWspółrzędnych.WspY(PrzeliczanieWspółrzędnych.Ymin),
                PrzeliczanieWspółrzędnych.WspX(0),
                PrzeliczanieWspółrzędnych.WspY(PrzeliczanieWspółrzędnych.Ymax));
            // wykreślenie osi X
            SKRysownica.DrawLine(SKPióroXY,
                PrzeliczanieWspółrzędnych.WspX(PrzeliczanieWspółrzędnych.Xmin),
                PrzeliczanieWspółrzędnych.WspY(0),
                PrzeliczanieWspółrzędnych.WspX(PrzeliczanieWspółrzędnych.Xmax),
                PrzeliczanieWspółrzędnych.WspY(0));
            // wykreślenie linii toru
            for (int j = 0; j < TWS.GetLength(0) - 1; j++)
                SKRysownica.DrawLine(SKPióroLiniiToru,
                PrzeliczanieWspółrzędnych.WspX(TWS[j, 0]),
                PrzeliczanieWspółrzędnych.WspY(TWS[j, 1]),
                PrzeliczanieWspółrzędnych.WspX(TWS[j + 1, 0]),
                PrzeliczanieWspółrzędnych.WspY(TWS[j + 1, 1]));

            // wykreślenie OA w nowym położeniu określonym przez IndexPOA
            SKRysownica.FillEllipse(Brushes.Yellow,
                PrzeliczanieWspółrzędnych.WspX(TWS[SKIndexPOA, 0]) - SKPromieńOA,
                PrzeliczanieWspółrzędnych.WspY(TWS[SKIndexPOA, 1]) - SKPromieńOA,
                2 * SKPromieńOA, 2 * SKPromieńOA);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }// bledny klik
     
        private void SKbtnAnimacja_Click(object sender, EventArgs e)
        {
            // zgaszenie kontrolki errorProvider
            errorProvider1.Dispose();
            // pobranie danych wejściowych z kontrolek formularza
            if (!SKPobierzDaneWejściowe(out SKXd, out SKXg, out SKh))
                // bezwarunkowe zakończenie obsługi zdarzenia Click
                return;
            // wyznaczenie liczby podprzedziałów 'h' w przedziale: [Xd, Xg]
            SKLiczbaPrzedziałówH = (int)((SKXg - SKXd) / SKh) + 1;
            // utworzenie egzemplarza tablicy TWS
            TWS = new double[SKLiczbaPrzedziałówH, 2];
            // tablicowanie wartości szeregu
            SKTablicowanieWartościSzeregu(TWS, SKXd, SKXg, SKh);
            // ustalenie op==początkowego położenia OA (Obiekt Animacji)
            SKIndexPOA = 0;
            // ustalenie końcowego położenia OA (Obiekt Animacji)
            SKMaxIndexPOA = TWS.GetLength(0) - 1;
            timer1.Enabled = true;
            // ustawienie stanu braku aktywności przycisku btnAnimacja
            SKbtnAnimacja.Enabled = false;
        }

        bool SKPobierzDaneWejściowe(out double SKXd, out double SKXg, out double SKh)
        { // pomocnicze ustalenie tzw. wartości technicznych dla parametrów wyjściowych
            SKXd = SKXg = SKh = 0.0F;
            // pobranie Xd
            if (!double.TryParse(SKtxtXd.Text, out SKXd))
            {// był błąd, to musimy go sygnalizować
                errorProvider1.SetError(SKtxtXd, "ERROR: w podanym zapisie wartości dla Xd wystąpił niedozwolony znak");
                // przerwanie pobierania danych
                return false;
            }
            // sprawdzenie, czy Xd należy do przedziału zbieżności szeregu
            if ((SKXd < SKDGprzedziałuX) || (SKXd > SKGGprzedziałuX))
            {// był błąd, to musimy go sygnalizować
                errorProvider1.SetError(SKtxtXd, "ERROR: podana wartość dla Xd nie należy do przedziału zbieżności szeregu");
                // przerwanie pobierania danych
                return false;
            }
            // pobranie Xg
            if (!double.TryParse(SKtxtXg.Text, out SKXg))
            {// był błąd, to musimy go sygnalizować
                errorProvider1.SetError(SKtxtXg, "ERROR: w podanym zapisie wartości dla Xg wystąpił niedozwolony znak");
                // przerwanie pobierania danych
                return false;
            }
            // sprawdzenie, czy Xg należy do przedziału zbieżności szeregu
            if ((SKXg < SKDGprzedziałuX) || (SKXg > SKGGprzedziałuX))
            {// był błąd, to musimy go sygnalizować
                errorProvider1.SetError(SKtxtXg, "ERROR: podana wartość dla Xg nie należy do przedziału zbieżności szeregu");
                // przerwanie pobierania danych
                return false;
            }
            // sprawdzenie tzw. warunku wejściowego (logicznego) nakładanego na granice przedziału zmiana wartości zmiennej X
            if (SKXd > SKXg)
            {// był błąd, to musimy go sygnalizować
                errorProvider1.SetError(SKtxtXg, "ERROR: nie jest spełniony tzw. warunek wejściowy nałożony na granice przedziału zmiana wartości zmiennej X");
                // przerwanie pobierania danych
                return false;
            }
            // pobranie przyrostu 'h'
            if (!double.TryParse(SKtxth.Text, out SKh))
            {// był błąd, to musimy go sygnalizować
                errorProvider1.SetError(SKtxth, "ERROR: w zapisie wartości przyrostu 'h' wystąpił niedozwolony znak");
                // przerwanie pobierania danych
                return false;
            }
            // sprawdzenie warunku wejściowego nałożonego na 'h': 0 < h < 1.0
            if ((SKh < 0.0F) || (SKh > 1.0F))
            {// był błąd, to musimy go sygnalizować
                errorProvider1.SetError(SKtxth, "ERROR: podana wartość przyrostu 'h' nie spełnia warunku wejściowego: 0 < h < 1.0");
                // przerwanie pobierania danych
                return false;
            }

            // zwrotne przekazanie wartości 'true' gdy nie było błędów
            return true;
        }

        void SKTablicowanieWartościSzeregu(double[,] TWS, double SKXd, double SKXg, double SKh)
        {
            // deklaracje pomocnicze
            double SKX;
            int SKi; // licznik podprzedziałów 'h'
            for (SKX = SKXd, SKi = 0; SKi < TWS.GetLength(0); SKX = SKXd + SKi * SKh, SKi++) // X => ............
            {
                // wpisanie do i-tego wiersz TWS wartości X oraz Wartości szeregu (X) 
                TWS[SKi, 0] = SKX;
                TWS[SKi, 1] = SKObliczenieWartościSzeregu(SKX);
            }
        }
        double SKObliczenieWartościSzeregu(double SKx)
        {
            // deklaracje pomocnicze
            const float SKEps = 0.000001F;

            double SKn, SKw, SKS;
            
            // ustalenie początkowego stanu obliczeń
            SKn = 0;
            SKw = SKx;
            SKS = SKw;
            // iteracyjne obliczanie sumy wyrazów szeregu
            while (Math.Abs(SKw) > SKEps)
            {// zwiększenie licznika wyrazów szeregu
                SKn++;
                // obliczenie wartości k-ego wyrazu szeregu
                SKw = (Math.Pow(SKx, SKn) / SKn);

                // obliczenie sumy k wyrazów szeregu
                SKS = SKS + SKw;
            }
            // zwrotne przekazanie wyniku obliczeń
            return SKS;
        }

        static class PrzeliczanieWspółrzędnych
        {
            // deklaracja zmiennych przechowujących wartości współczynników skali po osi X i osi Y oraz przesunięcia wzdłuż osi X i osi Y
            static double Sx, Sy;
            static double Dx, Dy;
            // deklaracja zmiennych opisujcych rozmiar powierzchni graficznej
            static int Xe_min, Xe_max, Ye_min, Ye_max;
            // deklaracja właściwości opisujących rozmiar powierzchni rzeczywistej
            static public double Xmin
            {
                get;
                private set;
            }
            static public double Xmax
            {
                get;
                private set;
            }
            static public double Ymin
            {
                get;
                private set;
            }
            static public double Ymax
            {
                get;
                private set;
            }
            //wyznaczenie rozmiarów i współczynników
            // deklaracja konstruktora klasy statycznej
            static PrzeliczanieWspółrzędnych()
            {// wyznaczenie rozmiaru powierzchni rzeczywistej
                Xmin = SKUchwytFormularza.SKXd;
                Xmax = SKUchwytFormularza.SKXg;
                Ymin = EkstremumSzeregu.MinSX(SKUchwytFormularza.TWS);
                Ymax = EkstremumSzeregu.MaxSX(SKUchwytFormularza.TWS);
                //wyznaczenie rozmiaru powierzchni graficznej na formularzu (kontrolce PictureBox)
                Xe_min = SKMargines;
                Xe_max = SKUchwytFormularza.SKpbRysownica.Width - (SKMargines + SKMargines);
                Ye_min = SKMargines;
                Ye_max = SKUchwytFormularza.SKpbRysownica.Height - (SKMargines + SKMargines);
                // wyznaczenie współczynników skali: Sx i Sy
                Sx = (Xe_max - Xe_min) / (Xmax - Xmin);
                Sy = (Ye_max - Ye_min) / (Ymax - Ymin);
                // obliczenie przesunięć: Dx i Dy
                Dx = Xe_min - Xmin * Sx;
                Dy = Ye_min - Ymin * Sy;
            } // koniec deklaracji konstruktora
            //deklaracja publicznych metod: WspX i WspY
            public static int WspX(double x)
            {
                return (int)(Sx * x + Dx);
            }
            static public int WspY(double y)
            {
                return (int)(Sy * y + Dy);
            }
        }
    }
}
