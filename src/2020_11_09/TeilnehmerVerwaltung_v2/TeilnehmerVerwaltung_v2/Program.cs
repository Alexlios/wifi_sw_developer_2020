using System;
using System.IO;
using WIFI.ToolLibrary.ConsoleIO;

namespace TeilnehmerVerwaltung_v2
{
    class Program
    {
        /// <summary>
        /// Liest einen Teilnehmer ein
        /// </summary>
        /// <param name="anzahlTeilnehmer">Anzahl der Einzulesenden Teilnehmer</param>
        /// <returns></returns>
        Teilnehmer[] GetTeilnehmer(int anzahlTeilnehmer)
        {
            Teilnehmer[] teilnehmer = new Teilnehmer[anzahlTeilnehmer];
            for (int i = 0; i < anzahlTeilnehmer; ++i)
            {
                teilnehmer[i].TeilnehmerID = Guid.NewGuid();
                teilnehmer[i].Vorname = ConsoleTools.GetString($"Bitte Vorname von Teilnehmer angeben: ");
                teilnehmer[i].Nachname = ConsoleTools.GetString($"Bitte Nachname von Teilnehmer {teilnehmer[i].Vorname} angeben: ");
                teilnehmer[i].Strasse = ConsoleTools.GetString($"Bitte Strasse von Teilnehmer {teilnehmer[i].Vorname} angeben: ");
                teilnehmer[i].HausNr = ConsoleTools.GetString($"Bitte HausNr von Teilnehmer {teilnehmer[i].Vorname} angeben: ");
                teilnehmer[i].PLZ = ConsoleTools.GetInt($"Bitte PLZ von Teilnehmer {teilnehmer[i].Vorname} angeben: ");
                teilnehmer[i].Ort = ConsoleTools.GetString($"Bitte Ort von Teilnehmer {teilnehmer[i].Vorname} angeben: ");
                teilnehmer[i].GeburtsDatum = ConsoleTools.GetDateTime($"Bitte Geburtsdatum von Teilnehmer {teilnehmer[i].Vorname} angeben: ", "dd.MM.yyyy");
                ConsoleTools.DisplayMesssage("");
            }

            return teilnehmer;
        }

        /// <summary>
        /// Gibt die Teilnehmer tabellarisch aus
        /// </summary>
        /// <param name="teilnehmer">Die Teilnehmer die Ausgegeben werden</param>
        /// <returns></returns>
        void PrintTeilnehmer(Teilnehmer[] teilnehmer)
        {
            ConsoleTools.DisplayMesssage("\nTeilnehmerID\t\t\t\tVorname\tNachname\tStrasse\tHausNr\tPLZ\tOrt\tGeburtsdatum\n", ConsoleColor.Cyan);
            foreach (Teilnehmer teiln in teilnehmer)
            {
                //Ausgabe eines einzelnen Teilnehmers in Türkis
                ConsoleTools.DisplayMesssage($"{teiln.TeilnehmerID}\t{teiln.Vorname}" +
                    $"\t{teiln.Nachname}\t{teiln.Strasse}\t{teiln.HausNr}\t{teiln.PLZ}\t{teiln.Ort}" +
                    $"\t{teiln.GeburtsDatum.ToShortDateString()}", ConsoleColor.Cyan);
            }
        }

        /// <summary>
        /// Fraegt den Nutzer ob er die angegebenen Teilnehmer abspeichern will
        /// </summary>
        /// <param name="teilnehmer">Die abzuspeichernden Teilnehmer</param>
        void SaveTeilnehmer(Teilnehmer[] teilnehmer)
        {
            //Abfrage ob die Teilnehmer gespeichert werden sollen
            if (ConsoleTools.GetBool("Mochten sie die Teilnehmer abspeichern? (Y/N): "))
            {
                //Abfrage Dateiname und abspeichern
                string filePath = ConsoleTools.GetString("Dateiname: ");
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    foreach (Teilnehmer t in teilnehmer)
                    {
                        sw.WriteLine($"{t.TeilnehmerID};{t.Vorname};{t.Nachname};{t.Strasse};{t.HausNr};{t.PLZ};{t.Ort};{t.GeburtsDatum.ToShortDateString()}");
                    }
                }

                ConsoleTools.DisplayMesssage("Daten wurden abgespeichert unter " + filePath, ConsoleColor.Green);
            }

        }

        void Initialize()
        {
            int anzahlTeilnehmer = 0;

            //Einlesen der Anzahl Teinehemer
            anzahlTeilnehmer = ConsoleTools.GetInt("Bitte Anzahl Teilnehmer angeben: ");

            //Einlesen der Teilnehmer
            Teilnehmer[] teilnehmer = GetTeilnehmer(anzahlTeilnehmer);

            //Tabellarische Ausgabe der Teilnehmer
            PrintTeilnehmer(teilnehmer);

            //Abfrage ob Teilnehmer abgespeichert werden sollen
            try
            {
                SaveTeilnehmer(teilnehmer);
            }
            catch (Exception ex)
            {
                ConsoleTools.DisplayMesssage($"ERROR: {ex.Message}", ConsoleColor.Red);
            }
        }

        static void Main(string[] args)
        {
            ConsoleTools.DisplayMesssage("Willkommen in der Eingabe der Teilnehmerverwaltung.", ConsoleColor.Yellow);
            Program program = new Program();
            program.Initialize();
        }
    }
}
