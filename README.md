# 11-vrprj-4ahmns-sosem-ptaitl

Dieses VR-Spiel ist im Rahmen des MTIN Unterrichts bei Frau Prof. Meerwald-Stadler, Dipl.-Ing. Susanne der HTL Salzburg entstanden. (Schuhljahr 2021/22)

## Aufgabenstellung

Auf Basis eines vorab bereitgestellten Unity / XR-Interaction-Toolkit Boilerplate soll eine spielbare .apk eines Oster VR-Games erstellt werden. Inhaltlich soll der Spieler durch das Lösen zweier Minigames aus einem vordefinierten Labyrinth enkommen.


> **Note:** Aufgrund vieler ausgefallender Unterrichtseinheiten wurden die Anforderungen auf ein Minigame inkl. Onboarding und Verabschiedung beschränkt und das ursprüngliche Konzept entsprechend angepasst (siehe unterhalb).

## Konzept
Vor dem Labyrinth wartet ein Hase. Kommt der Spieler in die Nähe des Hasen, erscheint über ihm eine Sprechblase mit Spielanweisungen. Um Buttoninputs zu vermeiden, indiziert ein UI-Slider wie lange die Sprechblase noch sichtbar ist.

Der Hase hoppelt zum Rätsel. Jedes Mal, wenn er den Boden berührt, hört der Spieler einen dumpfen Schlag, der ihn akustisch durch das Labyrinth leiten soll. Außerdem gibt der Hase hasentypische Idle- Sounds von sich. So gelingt es dem Spieler dem Hasen bis zum Rätsel zu folgen, obwohl der Hase unter Umständen schneller ist und der Spieler ihn auf dem Weg zum Rätsel verliert.

Sobald der Spieler das Labyrinth betritt, schließt sich der Eingang. Das Labyrinth kann dann nur mehr über den Ausgang verlassen werden. Beim Rätsel angekommen erscheint wieder eine Sprechblase über dem Hasen, in dem der Spieler aufgefordert wird ein mathematisches Rätsel zu lösen und das Ergebnis in ein Zahlenfeld einzugeben.

Hat der Spieler das Ergebnis über das Zahlenfeld eingegeben wird dieses grün und es erscheint wieder eine Sprechblase über dem Hasen. Dem Spieler wird gesagt, er könne jetzt den Ausgang suchen, um aus dem Labyrinth zu entkommen. Der Hase hoppelt zum Ausgang.

Der Spieler folgt dem Hasen bis zum Ausgang. Die Tür geht auf und der Hase verabschiedet sich.


## Stil & Spielspaß

Grundsätzlich soll das Spiel mithilfe eines Toonshaders (Tutorial von Erik Roystan), stilisierten Figuren und einem Natursetting eine helle und farbenfrohe Atmosphäre ausstrahlen. Für eine bessere Immersivität soll auch Wind, in Form von vorbeiwehenden Blättern und entsprechenden Soundeffekten sorgen. Der Spaßfaktor besteht also nicht nur daraus, seinen Kopf zu benutzten, um aus dem Labyrinth zu entkommen, sondern auch darin, die stilisierte Umgebung und interessante Klangkulisse auf sich wirken zu lassen.

## Auditive Gestaltung

Um das Spiel noch immersiver zu machen, sollen 3D Sounds, sowie 2D Atmo Sounds eingebaut werden. Folgende AudioClips (teils aus dem Internet, teils selbst aufgenommen) sind im Projekt enthalten:

* Hase
  * Idle Sound
  * Hoppelsound, wenn er beim Springen den Biden berührt
* Minigame
  * Klick Sound, wenn beim ersten Rätsel ein Input getätigt wird
  * Bestätigungssound, wenn das Ergebnis stimmt
  * Fehlersound, wenn das Ergebnis nicht stimmt
  * Schleifgeräusch, wenn sich das Eingangstor schließt bzw. das Ausgangstor öffnet
* Atmo bzw. globaler Sound
  * Vögelgeräusche
  * Hintergrundmusik

Alle Sounds sind im .wav Format mit 48 kHz und 16 bit. Abhängig davon, ob es sich um 3D oder 2D Sounds handelt, sind die AudioClips Mono oder Stereo

## Arbeitsschritte
1. Projekt aufsetzten
2. Projekt builden und Fortbewegung, Scale, etc. am Headset ausprobieren
3. Assets suchen
4. Hase und Führung durchs Spiel einbauen
5. Rechenrätsel einbauen
6. Restlichen Spielfluss einbauen (Sprechblasen)
7. Projekt final builden

## User Testing

Die oberhalb beschriebenen Arbeitsschritte sind iterativ zu verstehen: Es wurde immer wieder getestet und Bugs gefixed. Außerdem wurden User Tests während der Entwicklung durchgeführt, um sicherzustellen, dass die Spieler sich auskennen. Dabei wurde u.A. folgendes festgestellt:

- Zeitlich limitierte Sprechblasen brauchen einen Zeitindikator
- Wenn das Zahlenrätsel nicht gelöst werden kann, muss ein Hinweis angezeigt werden

## Limitations

Das Spiel ist lediglich auf Oculus VR-Brillen spielbar.

## Packages

- JetBrains Rider Editor | com.unity.ide.rider | 2.0.7
- Oculus XR Plugin | com.unity.xr.oculus | 1.10.0
- Test Framework | com.unity.test-framework | 1.1.29
- TextMeshPro | com.unity.textmeshpro | 3.0.6
- Timeline | com.unity.timeline | 1.4.8
- Unity UI | com.unity.ugui | 1.0.0
- Version Control | com.unity.collab-proxy | 1.9.0
- Visual Studio Code Editor | com.unity.ide.vscode | 1.2.3
- Visual Studio Editor | com.unity.ide.visualstudio | 2.0.11
- XR Interaction Toolkit | com.unity.xr.interaction.toolkit | 2.0.0-pre.7
- XR Plugin Management | com.unity.xr.management | 4.0.7

> **Note:** Alle verwendeten Packages sind dauerhaft kostenlos und im Repository inkludiert. Beim Clonen des Projekts müssen keine zusätzlichen Packages installiert werden.

## Entwicklungsplattform

MacOS 12.3.1 (21E258), Unity 2020.3.18f1, Visual Studio 2019, XR Interaction Toolkit 1.0.0-pre.8, XR Plugin Management 4.2.1, Oculus XR Plugin 1.10.0.

## Assets

Der Hase, die Bäume, sowie die vorbeifliegenden Vögel sind kostenlose Modelle von folgenden Seiten:

- https://www.turbosquid.com
- https://www.cgtrader.com/

## Abschließende Anmerkung

Da es sich um ein Schulprojekt handelt, sind alle Scripts sehr detalliert kommentiert, damit das Beurteilen der Arbeit leichter fällt und Zusammenhänger besser verständlich werden. Diese Kommentare sind also nicht als Code-Smells zu beurteilen.

Copyright © 2022 by ptaitl
