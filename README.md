# SkullLearningGiorgio
Learing C# in Code Architects By Giorgio Masci Guide.

Progetto: Modello di Classi
Specifiche
1. Classe Astratta Person
Caratteristiche:

firstName: string
lastName: string
birthdate: DateOnly
age: int (calcolato sulla base di birthdate, sola lettura)

2. Classe Student

Estende la classe Person
Aggiunge le informazioni relative al corso di studio

3. Classe Professor

Estende la classe Person
Aggiunge le informazioni relative all’istituto di appartenenza

4. Classe Istituto

(Definire le caratteristiche e relazioni)

Obiettivo
Progettare il modello con le relazioni tra le varie classi.



%% Diagramma delle classi
classDiagram
    direction LR

    class Person {
        <<abstract>>
        - string firstName
        - string lastName
        - DateOnly birthdate
        + int age
        --
        + getFullName() string
        .. age calcolata da birthdate (sola lettura) ..
    }

    class Student {
        + string corsoDiStudio
    }

    class Professor {
        + string istitutoDiAppartenenza
    }

    class Istituto {
        + string nome
        + string indirizzo
        + string codice
        + getDocenti() List~Professor~
        + getStudenti() List~Student~
    }

    %% Ereditarietà
    Person <|-- Student
    Person <|-- Professor

    %% Relazioni
    Istituto "1" o-- "0..*" Student : iscrive
    Istituto "1" o-- "0..*" Professor : impiega

    %% Nota sulla proprietà calcolata
    note for Person "age è derivata da birthdate ed è in sola lettura"

<img width="1601" height="830" alt="Image" src="https://github.com/user-attachments/assets/8247ca17-8a3e-429a-a7e5-df6b9e180359" />
