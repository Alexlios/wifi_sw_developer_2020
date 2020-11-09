using System;

namespace TeilnehmerVerwaltung_v2
{
    struct Teilnehmer
    {
        public Guid TeilnehmerID;
        public string Vorname;
        public string Nachname;
        public string Strasse;
        public string HausNr;
        public int PLZ;
        public string Ort;
        public DateTime GeburtsDatum;
    }
}
