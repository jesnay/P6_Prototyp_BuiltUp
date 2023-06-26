# P6 VR Integration für virtuelle Arbeits- und Konferenzräume

Für die Nutzung des Prototypen muss eine Meta Quest Pro vorhanden sein.

Schritt 1 bis 3 können übersprungen werden, wenn der Prototyp bereits auf der VR-Brille installiert ist. 

## 1. Installation & benötigte Programme

Für die erfolgreiche Einstellung und Übertragung des Prototypen müssen folgende Programme installiert und eingerichtet sein:
* Unity Version 2021.3.23f1 (Link für Download folgt)
* **Mac:** [Meta Quest Developer Hub](https://developer.oculus.com/downloads/package/oculus-developer-hub-mac)
* **Windows:** [Meta Quest Developer Hub](https://developer.oculus.com/downloads/package/oculus-developer-hub-win)


## 2. Einstellungen

1. Öffnen Sie das Projekt in Unity. Hierbei sollten alle genutzten Packages und Plugins automatisch installiert werden. 
2. Unter **File > Build Settings** wählen Sie die Plattform **Android** und klicken Sie auf **Switch Platform**.
3. Schließen Sie die Meta Quest Pro mit dem **USB-Typ-C 3.0** an den Laptop an.
4. Setzen Sie die VR-Brille auf und bestätigen Sie das Gerät.

Note:
In der **Meta Quest Developer Hub** App (Mac) oder der **Oculus Software** App (Windows) sollte nun die Meta Quest Pro als **Active** angezeigt werden.

5. Wechseln Sie zurück in Unity > Build Settings und wählen Sie unter **Run Device** die Meta Quest Pro aus. Wenn das Gerät nicht sofort angezeigt wird, klicken Sie auf **Refresh**.
Note: Stellen Sie sicher, dass unter **Scenes In Build** folgendes ausgewählt ist: **Scenes/P6 Unity/P6 Unity**
6. Klicken Sie nun auf **Build** und speichern Sie das Programm an einem ausgewählten Speicherort.

Note:
App und Gerät müssen mit dem gleichen Account angemeldet sein.


## 3. Übertragung auf VR Brille

**Windows:**
Das Projekt wird automatisch nach Schritt 6 gebildet und startet automatisch auf der Meta Quest Pro

**Mac:**
1. Im Meta Quest Developer Hub wählen sie Device Manager aus und klicken Sie dort **Add Build**
2. Gehen Sie nun an den Speicherort, wo Sie das Programm gespeichert haben und wählen Sie die apk Datei aus. Das Programm wird jetzt auf die VR-Brille hochgeladen.

## 4. Ausführung
1. Setzen Sie die Meta Quest Pro auf und wählen Sie in der Menüleiste **App Library** aus. Graues App Icon mit 4 weißen Kacheln auf linker Seite (Kann je nach Betriebssystem Version abweichen). So gelangen Sie zu den Apps.

2. Oben rechts erscheint ein Filter Icon. Dieses wählen Sie aus und filtern nach **unbekannten Quellen**.

3. Wählen Sie das Projekt **P6 Team 5 Meta Quest Pro** aus. Sie betreten nun den Prototypen.

[Hier finden Sie die Hand-Tracking Gesten der Meta Quest](https://www.meta.com/de-de/help/quest/articles/headsets-and-accessories/controllers-and-hand-tracking/hand-tracking-quest-2/)

Note: Sollte man nicht auf der richtigen Position starten, kann man sich mit dem Joystick der Controller im Raum bewegen, um zu seinem Platz zu kommen.

### Prototyp verlassen
Schauen Sie Ihre rechte Handfläche Innenseite an und führen Sie Daumen und Zeigefinger zusammen.
Alternativ drücken Sie auf dem rechten Controller die Taste mit dem Oculus Logo.

## 5. Erwartetes Resultat

1. Bei Betreten des Prototypen erscheint ein schwarzer Screen mit “Made with Unity”. Nach kurzem Warten landet man im “Teamraum”. 
2. Hier sind 3 Avatare um einen transparenten Tisch angeordnet. Vor einem sind unterschiedliche Bausteine zu finden, die zum Bauen verwendet werden können. 
3. Mit dem Zeigefinger und Daumen können die Bausteine gegriffen und in den Raum gesetzt werden. 
4. Zieht man einen Baustein auf das **X** und lässt ihn los, wird er gelöscht.

### Prototyp zurücksetzen
Dreht man sich um, findet man hinter sich einen Reset Button. Klickt man diesen, wird der Prototyp zurückgesetzt und alles was gebaut wurde verschwindet.

Note: Den Button kann man mit einem Finger klicken (Poke geste).

