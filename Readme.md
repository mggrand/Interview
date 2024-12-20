# CLI f�r die Erstellung von Datenbank Migrationen
Es soll eine CLI entwickelt werden, welche es den Entwicklern erlaubt neue Dateien aufgrund eines Musters zu erstellen.

## Anwendungs Anforderungen
- Erstellung von Dateien.
- Jede Datei hat das Muster *Vollst�ndigesDatumMitZeit*_*Name*.sql
- Der Name soll �ber die Konsole eingegeben werden k�nnen.
- �ber ein Start-Argument soll auch direkt ein Pfad zum Ordner mitgegeben werden k�nnen.
- Falls kein Argument angegeben wurde, soll der Ordner "Migrations" im gleichen Ordner verwendet werden.
- Wenn im Ordner bereits ein Ordner "VorProzeduren" oder "NachProzeduren" existiert, soll gefragt werden, in welchen Unterordner die Migration abgelegt werden soll.
- Die erstellte Datei soll am Schluss mit dem Standardprogramm ge�ffnet werden.

## System Anforderungen
- Entwicklung mit C#
- Entwicklung einer Console Anwendung
- State-of-the-art Anwendung
- Wie kann das Tool am besten aus einem git Repository gestartet werden?
- Wie k�nnen Updates des Tools effizient ausgeliefert werden?

## Beispiel Ablauf der Anwendung
1. Benutzer startet Tool
2. Tool fragt nach Namen der Migration
3. Migration wird im korrekten Ordner erstellt
4. Die Standardanwendung wird gestartet


## Hilfsmittel
- C#
- Internet ist **nicht** erlaubt!